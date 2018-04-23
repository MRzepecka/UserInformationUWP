﻿using UserInformationUWP.Enumes;
using UserInformationUWP.Services;
using UserInformationUWP.ViewModels.Base.UserControlViewModel;

namespace UserInformationUWP.ViewModels
{
    public class FirstNameViewModel : BaseControllerViewModel
    {
        public override string NameText { get => ResourceLoader.GetString(UserInformationIndex.FirstName.ToString()); }

        private string value;

        public FirstNameViewModel(UserInformationService informationServices)
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
