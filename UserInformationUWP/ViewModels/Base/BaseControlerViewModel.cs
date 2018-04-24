using UserInformationUWP.Enumes;
using UserInformationUWP.Interfaces;

namespace UserInformationUWP.ViewModels.Base
{
    public abstract class BaseControlerViewModel : BaseViewModel
    { 
        protected IUserInformationService userInformationService;

        public abstract string NameText { get; }

        public abstract string Value { get; set; }

        public UserInformationIndex Index;
    }
}
