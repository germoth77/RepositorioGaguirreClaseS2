namespace GaguirreClaseS2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new GaguirreClaseS2.VIEWS.vCalificaciones());
        }
    }
}
