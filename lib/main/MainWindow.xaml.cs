using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using intnet22.lib.associate;
using intnet22.lib.financial;
using intnet22.lib.jud;

// ReSharper disable All

namespace anpnet22.lib.main
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public static readonly RoutedCommand AssociatesOpen = new RoutedCommand();

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
            var bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri($"https://inat.to/farm/backs/anp.jpg", UriKind.Absolute);
            bitmap.EndInit();

            //
            var brush = new ImageBrush(bitmap);
            brush.Stretch = Stretch.Fill;
            this.Background = brush;

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
            PartsList window = new()
            {
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                WindowState = WindowState.Normal,
                //
                Owner = this
            };

            window.Show();
        }

        private void MenuProcessos_Click(object? sender, RoutedEventArgs? e)
        {
            //
            ProcessesList window = new()
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
                Owner = this,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                WindowState = WindowState.Normal,
            };

            window.Show();
        }

        private void MenuPendencias_Click(object sender, RoutedEventArgs e)
        {
            //
            Pendencias window = new()
            {
                Owner = this,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                WindowState = WindowState.Normal,
            };

            window.Show();
        }

        private void OpenCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MenuAssociados_Click();
        }

        private void MenuGrupos_Click(object sender, RoutedEventArgs e)
        {
            //
            GruposContabeis window = new()
            {
                Owner = this,
                WindowState = WindowState.Normal,
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };

            window.Show();
        }
    }
}