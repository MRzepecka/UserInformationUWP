﻿using UserInformationUWP.Enumes;
using UserInformationUWP.Services;
using UserInformationUWP.ViewModels.Base;

namespace UserInformationUWP.ViewModels
{
    public class LastNameViewModel : BaseControlerViewModel
    {
        public override string NameText { get => ResourceLoader.GetString(UserInformationIndex.LastName.ToString()); }

        private string value;

        public LastNameViewModel(UserInformationService informationServices)
        {
            userInformationService = informationServices;
            Index = UserInformationIndex.LastName;
        }

        public override string Value
        {
            get => value = userInformationService.GetLastName();

            set
            {
                if (SetProperty(ref this.value, value))
                {
                    userInformationService.UpdateLastName(value);
                }
            }
        }
    }
}
