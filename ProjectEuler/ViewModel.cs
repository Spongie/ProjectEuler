using ProjectEuler.Problems;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace ProjectEuler
{
    public class ViewModel : INotifyPropertyChanged
    {
        private Problem _selectedProblem;

        public ObservableCollection<Problem> Problems { get; set; }

        public Problem SelectedProblem
        {
            get
            {
                return _selectedProblem;
            }
            set
            {
                _selectedProblem = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedProblem)));
            }
        }

        public ViewModel()
        {
            Problems = new ObservableCollection<Problem>();

            foreach (var problem in Assembly.GetExecutingAssembly().GetExportedTypes().Where(type => type.IsSubclassOf(typeof(Problem))))
            {
                Problems.Add((Problem)Activator.CreateInstance(problem));
            }

            Problems = new ObservableCollection<Problem>(Problems.OrderBy(problem => problem.OrderNumber));

            SelectedProblem = Problems.First();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
