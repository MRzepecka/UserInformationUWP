using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using UserInformationUWP.Interfaces;
using UserInformationUWP.ViewModels.Base;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UserInformationUWP.ViewModels
{
    public class SummaryViewModel : BaseViewModel
    {
        private IUserInformationService userInformationService;

        public RelayCommand ReturnToStartCommand { get; }

        public SummaryViewModel(IUserInformationService userInformationService)
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
            controlUserInformationList = new ObservableCollection<BaseControlerViewModel>
            {
                new FirstNameViewModel(userInformationService),
                new LastNameViewModel(userInformationService),
                new AddressViewModel(userInformationService),
                new PhoneNumberViewModel(userInformationService)
            };
        }

        private void GoToMain()
        {
            ((Frame)Window.Current.Content).Navigate(typeof(Views.MainPage), null);
        }
    }
}
