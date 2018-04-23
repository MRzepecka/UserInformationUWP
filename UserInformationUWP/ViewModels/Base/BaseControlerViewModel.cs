using UserInformationUWP.Enumes;
using UserInformationUWP.Services;

namespace UserInformationUWP.ViewModels.Base.UserControlViewModel
{
    public abstract class BaseControllerViewModel : BaseViewModel
    {
        protected UserInformationService userInformationService;

        public abstract string NameText { get; }

        public abstract string Value { get; set; }

        public UserInformationIndex Index;
    }
}
