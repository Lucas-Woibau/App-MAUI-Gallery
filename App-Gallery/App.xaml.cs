namespace App_Gallery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Current.UserAppTheme = AppTheme.Light;

            MainPage = new AppFlyout();
        }
    }
}
 