using GalaSoft.MvvmLight.Command;
using UserInformationUWP.Enumes;
using UserInformationUWP.Services;
using UserInformationUWP.ViewModels.Base;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using UserInformationUWP.ViewModels.Base.UserControlViewModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace UserInformationUWP.ViewModels
{
    public class ControlViewModel : BaseViewModel
    {
        private UserInformationIndex currentIndex;

        private UserInformationService userInformationService;

        public RelayCommand NextCommand { get;}
        public RelayCommand BackCommand { get;}
        public RelayCommand FinishCommand { get;}

        public ControlViewModel()
        {
            userInformationService = new UserInformationService();
            next = true;
            NextCommand = new RelayCommand(NextStep, ()=> Next);
            BackCommand = new RelayCommand(BackToLastStep, () => Back);
            FinishCommand = new RelayCommand(FinishStep, ()=> Finish);

            currentIndex = UserInformationIndex.FirstName;
            currentStep = ControlUserInformations.First(s => s.Index == currentIndex);
        }

        private BaseControllerViewModel currentStep;
        public BaseControllerViewModel CurrentStep
        {
            get => currentStep;
            set => SetProperty(ref currentStep, value);
        }

        private ReadOnlyCollection<BaseControllerViewModel> controlUserInformations;
        public ReadOnlyCollection<BaseControllerViewModel> ControlUserInformations
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

            controlUserInformations = new ReadOnlyCollection<BaseControllerViewModel>(stepsList);
        }

        private bool next;
        public bool Next
        {
            get => next; 
            set
            {
                if (SetProperty(ref next, value))
                {
                    NextCommand.RaiseCanExecuteChanged();
                }
            }
        }

        private bool finish;
        public bool Finish
        {
            get => finish; 
            set
            {
                if (SetProperty(ref finish, value))
                {
                    FinishCommand.RaiseCanExecuteChanged();
                }
            }
        }

        private bool back;
        public bool Back
        {
            get => back; 
            set
            {
                if (SetProperty(ref back, value))
                {
                    BackCommand.RaiseCanExecuteChanged();
                }
            }
        }

        public void NextStep()
        {
            if ((int)currentIndex < controlUserInformations.Count)
            {
                ++(currentIndex);
                CurrentStep = controlUserInformations.First(s => s.Index == currentIndex);
            }

            Next = NextBool();
            Back = BackBool();
            Finish = FinishBool();
        }

        public void BackToLastStep()
        {
            if ((int)currentIndex > 0)
            {
                --currentIndex;
                CurrentStep = controlUserInformations.First(s => s.Index == currentIndex);
            }

            Next = NextBool();
            Back = BackBool();
            Finish = FinishBool();
        }

        public void FinishStep()
        {
            ((Frame)Window.Current.Content).Navigate(typeof(Views.SummaryView), userInformationService);
        }

        public bool NextBool() => (int)currentIndex < controlUserInformations.Count ? true : false;

        public bool BackBool() => (int)currentIndex > 1 ? true : false;

        public bool FinishBool() => (int)currentIndex == controlUserInformations.Count ? true : false;
    }
}
