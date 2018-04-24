using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using UserInformationUWP.ViewModels.Base;
using UserInformationUWP.Views;
using Windows.ApplicationModel.Resources;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UserInformationUWP.ViewModels
{
    public class StartViewModel : BaseViewModel
    {
        public ICommand GoToStartCommand { get; }

        public StartViewModel()
        {
            GoToStartCommand = new RelayCommand(GoToStart);
        }

        public string WelcomeText => ResourceLoader.GetString("Welcome");

        public void GoToStart()
        {
            ((Frame)Window.Current.Content).Navigate(typeof(ControllerView), null);
        }
    }
}
