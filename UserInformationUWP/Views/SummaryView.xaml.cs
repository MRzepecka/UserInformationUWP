using UserInformationUWP.Models;
using UserInformationUWP.Services;
using UserInformationUWP.ViewModels;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=234238

namespace UserInformationUWP.Views
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class SummaryView : Page
    {
        UserInformationService service;

        public SummaryView()
        {
            this.InitializeComponent();
            this.DataContext = new SummaryViewModel(new UserInformationService());
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            service = (UserInformationService)e.Parameter;
            this.DataContext = new SummaryViewModel(service);
        }

    }
}
