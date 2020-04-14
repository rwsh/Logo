using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Logo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Logo = new TLogo(g);
        }

        TLogo Logo;

        private void cmUp(object sender, RoutedEventArgs e)
        {
            Logo.Up(10);
        }

        private void cmDown(object sender, RoutedEventArgs e)
        {
            Logo.Up(-10);
        }

        private void cmRight(object sender, RoutedEventArgs e)
        {
            Logo.Right(10);
        }

        private void cmLeft(object sender, RoutedEventArgs e)
        {
            Logo.Right(-10);
        }

        private void cmJump(object sender, RoutedEventArgs e)
        {
            Logo.Jump();
        }

        private void cmHome(object sender, RoutedEventArgs e)
        {
            Logo.ToHome();
        }
    }
}
