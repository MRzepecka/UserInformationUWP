using UserInformationUWP.Interfaces;
using UserInformationUWP.Models;

namespace UserInformationUWP.Services
{
    public class UserInformationService: IUserInformationService
    {
        private UserInformation userInformation;

        public UserInformationService()
        {
            userInformation = new UserInformation();
        }

        public string GetFirstName()
        {
            return userInformation.FirstName;
        }

        public string GetLastName()
        {
            return userInformation.LastName;
        }

        public string GetAddress()
        {
            return userInformation.Address;
        }

        public string GetPhone()
        {
            return userInformation.PhoneNumber;
        }

        public UserInformation GetUserInformation()
        {
            return userInformation;
        }

        public void UpdateFirstName(string firstName)
        {
            userInformation.FirstName = firstName;
        }

        public void UpdateLastName(string lastName)
        {
            userInformation.LastName = lastName;
        }

        public void UpdateAddress(string address)
        {
            userInformation.Address = address;
        }

        public void UpdatePhone(string phone)
        {
            userInformation.PhoneNumber = phone;
        }
    }
}
