using UserInformationUWP.Enumes;
using UserInformationUWP.Interfaces;
using UserInformationUWP.ViewModels.Base;

namespace UserInformationUWP.ViewModels
{
    public class FirstNameViewModel : BaseControlerViewModel
    {
        public override string NameText => ResourceLoader.GetString(UserInformationIndex.FirstName.ToString()); 

        private string value;

        public FirstNameViewModel(IUserInformationService informationServices)
        {
            userInformationService = informationServices;
            Index = UserInformationIndex.FirstName;
        }

        public override string Value 
        {
            get => value = userInformationService.GetFirstName();

            set
            {
                if (SetProperty(ref this.value, value))
                {
                    userInformationService.UpdateFirstName(value);
                }
            }
        }
    }
}
