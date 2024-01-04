using MVVMInWPF.ViewModel;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Exercise1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Exercise1.View.MainPage window = new Exercise1.View.MainPage();
            UserViewModel VM = new UserViewModel();
            window.DataContext = VM;
            window.Show();
        }
    }
}
