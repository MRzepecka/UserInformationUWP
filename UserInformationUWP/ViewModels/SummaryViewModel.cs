using GalaSoft.MvvmLight.Command;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UserInformationUWP.Services;
using UserInformationUWP.ViewModels.Base;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UserInformationUWP.ViewModels
{
    public class SummaryViewModel : BaseViewModel
    {
        private UserInformationService userInformationService;

        public RelayCommand ReturnToStartCommand { get; }

        public SummaryViewModel(UserInformationService userInformationService)
        {
            this.userInformationService = userInformationService;
            ReturnToStartCommand = new RelayCommand(GoToMain);
        }

        private ObservableCollection<BaseControlerViewModel> controlUserInformationList;

        public ObservableCollection<BaseControlerViewModel> ControlUserInformationList
        {
            get 
            {
                if (controlUserInformationList == null)
                    LoadControlUserInformations();

                return controlUserInformationList;
            }
        }

        private void LoadControlUserInformations()
        {
            var stepsList = new List<BaseControlerViewModel>
            {
                new FirstNameViewModel(userInformationService),
                new LastNameViewModel(userInformationService),
                new AddressViewModel(userInformationService),
                new PhoneNumberViewModel(userInformationService)
            };
            controlUserInformationList = new ObservableCollection<BaseControlerViewModel>(stepsList);
        }

        private void GoToMain()
        {
            ((Frame)Window.Current.Content).Navigate(typeof(Views.MainPage), null);
        }
    }
}
