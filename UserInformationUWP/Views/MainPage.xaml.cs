using UserInformationUWP.ViewModels;
using Windows.UI.Xaml.Controls;

namespace UserInformationUWP.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.DataContext = new StartViewModel();
        }
    }
}
