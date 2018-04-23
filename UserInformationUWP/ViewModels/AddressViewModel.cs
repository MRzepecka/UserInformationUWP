using UserInformationUWP.Enumes;
using UserInformationUWP.Services;
using UserInformationUWP.ViewModels.Base;

namespace UserInformationUWP.ViewModels
{
    class AddressViewModel : BaseControlerViewModel
    {
        public override string NameText => ResourceLoader.GetString(UserInformationIndex.Address.ToString());

        private string value;

        public AddressViewModel(UserInformationService informationServices)
        {
            userInformationService = informationServices;
            Index = UserInformationIndex.Address;
        }

        public override string Value
        {
            get => value = userInformationService.GetAddress();

            set
            {
                if (SetProperty(ref this.value, value))
                {
                    userInformationService.UpdateAddress(value);
                }
            }
        }
    }
}
