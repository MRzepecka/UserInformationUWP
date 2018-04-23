using UserInformationUWP.ViewModels;
using Windows.UI.Xaml.Controls;

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=234238

namespace UserInformationUWP.Views
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class ControllerView : Page
    {
        public ControllerView()
        {
            this.InitializeComponent();
            this.DataContext = new ControlViewModel();
        }
    }
}
