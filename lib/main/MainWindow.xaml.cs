using System.Windows;
using System.Windows.Input;
using intnet22.lib.associate;
using intnet22.lib.financial;
using intnet22.lib.jud;
using intnet22.lib.legal;

namespace anpnet22.lib.main
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {

        public static RoutedCommand AssociatesOpen = new RoutedCommand();

        public MainWindow()
        {
            //
            //waterMark();

            //
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.WindowState = WindowState.Maximized;

            //
            InitializeComponent();

            //
            //MenuAssociados_Click(null, null);
        }

        private void MenuAssociados_Click(object? sender = null, RoutedEventArgs? e = null)
        {
            //
            AssociatesWindow window = new()
            {
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                WindowState = WindowState.Normal,
                //
                Owner = this
            };

            window.Show();
        }

        private void MenuJuridico_Click(object? sender, RoutedEventArgs? e)
        {
            //
            JudList window = new()
            {
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                WindowState = WindowState.Normal,
                //
                Owner = this
            };

            window.Show();
        }

        private void MenuDespesas_Click(object sender, RoutedEventArgs e)
        {
            //
            Despesas window = new()
            {
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                WindowState = WindowState.Normal,
                //
                Owner = this
            };

            window.Show();
        }

        private void MenuReceitas_Click(object sender, RoutedEventArgs e)
        {
            //
            Receitas window = new()
            {
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                WindowState = WindowState.Normal
            };

            //
            window.Owner = this;
            window.Show();

        }

        private void MenuPendencias_Click(object sender, RoutedEventArgs e)
        {
            //
            Pendencias window = new()
            {
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                WindowState = WindowState.Normal
            };

            //
            window.Owner = this;
            window.Show();
        }

        private void OpenCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MenuAssociados_Click();
        }
    }
}
