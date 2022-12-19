using intnet22.lib.admin;

namespace anpnet22
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        public App()
        {
            //
            var login = new ModalLogin();
            login.Show();
        }
    }
}