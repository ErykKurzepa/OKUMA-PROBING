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

namespace PROBING
{
    /// <summary>
    /// Logika interakcji dla klasy MAIN_MENU.xaml
    /// </summary>
    public partial class MAIN_MENU : Page
    {

   

        public MAIN_MENU()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)System.Windows.Application.Current.MainWindow).WORK_FRAME.Content = new WKS_SETUP();
           // ((MainWindow)System.Windows.Application.Current.MainWindow).MAIN_MENU.Content = new IMAGES();
        }
    }

   

}
