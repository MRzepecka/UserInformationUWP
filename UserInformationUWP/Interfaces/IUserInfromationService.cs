using UserInformationUWP.Models;

namespace UserInformationUWP.Interfaces
{
    public interface IUserInformationService
    {
        string GetFirstName();

        string GetLastName();

        string GetAddress();

        string GetPhone();

        UserInformation GetUserInformation();

        void UpdateFirstName(string firstName);

        void UpdateLastName(string lastName);

        void UpdateAddress(string address);

        void UpdatePhone(string phone);
    }
}
