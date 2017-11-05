using System;
using System.ComponentModel;
using System.Windows.Input;

namespace ProjectEuler.Problems
{
    public abstract class Problem : INotifyPropertyChanged
    {
        private ICommand _clickCommand;
        protected long _solution;
        protected TimeSpan _elapsedTime;
        protected float _progress;
        protected BackgroundWorker worker;

        public event PropertyChangedEventHandler PropertyChanged;

        protected abstract long DoSolutionSolve();

        public void Solve()
        {
            worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerAsync();
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            var start = DateTime.Now;
            _solution = DoSolutionSolve();
            _elapsedTime = DateTime.Now - start;
            FirePropertyChanged();
        }

        public string Name => GetType().Name;

        public int OrderNumber => int.Parse(Name.Remove(0, 7));

        public ICommand ClickCommand
        {
            get
            {
                return _clickCommand ?? (_clickCommand = new CommandHandler(() => Solve(), true));
            }
        }

        public long Solution => _solution;
        public TimeSpan ElapsedTime => _elapsedTime;
        public float Progress
        {
            get
            {
                return _progress;
            }
            set
            {
                FirePropertyChanged();
                _progress = value;
            }
        }

        protected void FirePropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Solution)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ElapsedTime)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Progress)));
        }
    }
}
