using GalaSoft.MvvmLight.Command;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UserInformationUWP.Services;
using UserInformationUWP.ViewModels.Base;
using UserInformationUWP.ViewModels.Base.UserControlViewModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UserInformationUWP.ViewModels
{
    public class SummaryViewModel : BaseViewModel
    {
        private UserInformationService userInformationService;

        public RelayCommand ReturnToStrartCommand { get; }

        public SummaryViewModel(UserInformationService userInformationService)
        {
            this.userInformationService = userInformationService;
            ReturnToStrartCommand = new RelayCommand(GoToMain);
        }

        private ObservableCollection<BaseControllerViewModel> controlUserInformations;

        public ObservableCollection<BaseControllerViewModel> ControlUserInformations
        {
            get 
            {
                if (controlUserInformations == null)
                    LeodControlUserInformations();

                return controlUserInformations;
            }
        }

        private void LeodControlUserInformations()
        {
            var stepsList = new List<BaseControllerViewModel>
            {
                new FirstNameViewModel(userInformationService),
                new LastNameViewModel(userInformationService),
                new AddressViewModel(userInformationService),
                new PhoneNumberViewModel(userInformationService)
            };
            controlUserInformations = new ObservableCollection<BaseControllerViewModel>(stepsList);
        }

        private void GoToMain()
        {
            ((Frame)Window.Current.Content).Navigate(typeof(Views.MainPage), null);
        }
    }
}
