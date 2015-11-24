using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.ViewManagement;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BacklightBleedTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ApplicationView appView;
        public MainPage()
        {
            appView = ApplicationView.GetForCurrentView();
            this.InitializeComponent();
        }

      

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Exit();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            grdInstrustions.Visibility = Visibility.Collapsed;
            appView.TryEnterFullScreenMode();
        }

        private void Page_Loading(FrameworkElement sender, object args)
        {
        }

        private void Grid_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            appView.ExitFullScreenMode();
            grdInstrustions.Visibility = Visibility.Visible;
        }
    }
}
