using System.Windows;

namespace cqrs_example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        public MainWindowViewModel ViewModel { get { return (MainWindowViewModel)DataContext; } set { DataContext = value; } }
    }
}
