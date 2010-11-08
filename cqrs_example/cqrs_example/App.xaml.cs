using System.Windows;
using NServiceBus;

namespace cqrs_example
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            new AppConfiguration().Setup();
            MainWindow.Show();
        }
    }

    public class AppConfiguration
    {
        public void Setup()
        {
            CurrentBus.AssociatedCurrentBus(
                Configure
                    .With()
                    .Log4Net()
                    .DefaultBuilder()
                    .XmlSerializer()
                    .MsmqTransport()
                    .UnicastBus()
                    .CreateBus()
                    .Start());
        }
    }
}
