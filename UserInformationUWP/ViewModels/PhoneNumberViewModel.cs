﻿using UserInformationUWP.Enumes;
using UserInformationUWP.Services;
using UserInformationUWP.ViewModels.Base.UserControlViewModel;

namespace UserInformationUWP.ViewModels
{
    class PhoneNumberViewModel : BaseControllerViewModel
    {
        public override string NameText { get => ResourceLoader.GetString(UserInformationIndex.PhoneNumber.ToString()); }

        private string value;

        public PhoneNumberViewModel(UserInformationService informationServices)
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
