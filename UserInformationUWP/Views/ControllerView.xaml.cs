using UserInformationUWP.ViewModels;
using Windows.UI.Xaml.Controls;

namespace UserInformationUWP.Views
{
    public sealed partial class ControllerView : Page
    {
        public ControllerView()
        {
            this.InitializeComponent();
            this.DataContext = new ControlViewModel();
        }
    }
}
