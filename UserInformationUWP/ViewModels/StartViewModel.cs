using GalaSoft.MvvmLight.Command;
using UserInformationUWP.ViewModels.Base;
using UserInformationUWP.Views;
using Windows.ApplicationModel.Resources;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UserInformationUWP.ViewModels
{
    public class StartViewModel : BaseViewModel
    {
        public RelayCommand GoToStartCommand { get; }

        public StartViewModel()
        {
            GoToStartCommand = new RelayCommand(GoToStart);
        }

        public string WelcomeText
        {
            get => ResourceLoader.GetString("Welcome");
        }

        public void GoToStart()
        {
            ((Frame)Window.Current.Content).Navigate(typeof(ControllerView), null);
        }
    }
}
