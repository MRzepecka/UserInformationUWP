using UserInformationUWP.Enumes;
using UserInformationUWP.Services;
using System;
using System.Collections;

namespace UserInformationUWP.ViewModels.Base
{
    public abstract class BaseControlerViewModel : BaseViewModel
    { 
        protected UserInformationService userInformationService;

        public abstract string NameText { get; }

        public abstract string Value { get; set; }

        public UserInformationIndex Index;
    }
}
