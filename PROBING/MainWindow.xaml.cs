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
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        public void NavigatePage(Page page)
        {
          //  MAIN_MENU.Navigate(page);
  }


        public MainWindow()
        {
            InitializeComponent();
            WORK_FRAME.Content = new WKS_SETUP();
            
        }
    }
}
