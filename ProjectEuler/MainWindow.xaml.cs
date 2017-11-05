using System.Collections.ObjectModel;
using System.Windows;

namespace ProjectEuler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();

            viewModel = new ViewModel();

            DataContext = viewModel;
        }
    }
}
