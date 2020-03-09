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

namespace _2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click1(object sender, EventArgs e)
        {
            if (Button2.IsEnabled == false) Button2.IsEnabled = true;
            else Button2.IsEnabled = false;
 
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            if (Button1.IsEnabled == false) Button1.IsEnabled = true;
            else Button1.IsEnabled = false;
        }
    }
}
