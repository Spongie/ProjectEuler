using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Input;

namespace ProjectEuler.Problems
{
    public abstract class Problem : INotifyPropertyChanged
    {
        private ICommand _clickCommand;
        protected long _solution;
        protected double _elapsedTime;
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
            var sw = Stopwatch.StartNew();
            _solution = DoSolutionSolve();
            sw.Stop();
            _elapsedTime = sw.Elapsed.TotalMilliseconds;
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
        public double ElapsedTime => _elapsedTime;
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
