using UserInformationUWP.Interfaces;
using UserInformationUWP.ViewModels;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace UserInformationUWP.Views
{
    public sealed partial class SummaryView : Page
    {
        IUserInformationService service;

        public SummaryView()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            service = (IUserInformationService)e.Parameter;
            this.DataContext = new SummaryViewModel(service);
        }
    }
}
