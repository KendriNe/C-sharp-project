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

namespace BlackJack_project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BtnHit.IsEnabled = false;
            BtnStand.IsEnabled = false;
        }

        private void BtnDeel_Click(object sender, RoutedEventArgs e)
        {
            BtnHit.IsEnabled = true;   
            BtnStand.IsEnabled = true;
        }

        private void BtnHit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnStand_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
