using UserInformationUWP.Enumes;
using UserInformationUWP.Interfaces;
using UserInformationUWP.Services;
using UserInformationUWP.ViewModels.Base;

namespace UserInformationUWP.ViewModels
{
    class PhoneNumberViewModel : BaseControlerViewModel
    {
        public override string NameText => ResourceLoader.GetString(UserInformationIndex.PhoneNumber.ToString()); 

        private string value;

        public PhoneNumberViewModel(IUserInformationService informationServices)
        {
            userInformationService = informationServices;
            Index = UserInformationIndex.PhoneNumber;
        }

        public override string Value
        {
            get => value = userInformationService.GetPhone();

            set
            {
                if (SetProperty(ref this.value, value))
                {
                    userInformationService.UpdatePhone(value);
                }
            }
        }
    }
}
