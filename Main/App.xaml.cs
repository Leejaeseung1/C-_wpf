using Main.Util;
using Main.View;
using Main.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;

namespace Main
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// start func // app.xaml startup
        /// </summary>
        /// <param name="s"></param>
        /// <param name="e"></param>
        private void Application_Startup(object s, StartupEventArgs e)
        {
            var builder = Host.CreateApplicationBuilder();
            var services = Host.CreateApplicationBuilder().Services;

            //add viewmodel
            services.AddTransient<MainWindowViewModel>();

            AppDI.Instance.Services = builder.Build().Services;

            MainWindow main = new();
            main.ShowDialog(); //open dependent window, block parent window control
            //main.Show(); //open independent window
        }
    }
}
