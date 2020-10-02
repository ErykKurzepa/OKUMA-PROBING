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
    /// Interaction logic for WKS_C_4_POINT_SLOT_ISLAND.xaml
    /// </summary>
    public partial class WKS_C_4_POINT_SLOT_ISLAND : Page
    {
        public WKS_C_4_POINT_SLOT_ISLAND()
        {
            InitializeComponent();
        }

        private void X1_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(X1.Text, X1);
            Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_X1"] = X1.Text;
        }

        private void Y1_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(Y1.Text, Y1);
            Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_Y1"] = Y1.Text;
        }

        private void Z1_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(Z1.Text, Z1);
            Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_Z1"] = Z1.Text;
        }

        private void X2_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(X2.Text, X2);
            Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_X2"] = X2.Text;
        }

        private void Y2_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(Y2.Text, Y2);
            Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_Y2"] = Y2.Text;
        }

        private void Z2_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(Z2.Text, Z2);
            Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_Z2"] = Z2.Text;
        }


       

        private void C0_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(C0.Text, C0);
            Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_C0"] = C0.Text;
        }







        public bool IsNumericCheck(string tekst, TextBox TheTextBox)
        {
            float parsedValue;

            if (!float.TryParse(tekst, out parsedValue))
            {
                MessageBox.Show(tekst + " is not numeric");
                TheTextBox.Text = "0";

            }
            return true;
        }



        private void PARALELL_Y_Checked(object sender, RoutedEventArgs e)
        {
            X2.Visibility = Visibility.Hidden;
            Y2.Visibility = Visibility.Visible;
            Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_AXIS"] = "Y";
        }

        private void PARALLEL_X_Checked(object sender, RoutedEventArgs e)
        {


            X2.Visibility = Visibility.Visible;
            Y2.Visibility = Visibility.Hidden;
            Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_AXIS"] = "X";
        }

        private void slot_Checked(object sender, RoutedEventArgs e)
        {
            
                ISLAND_HEIGHT.IsReadOnly = true;
            ISLAND_HEIGHT.Background = Brushes.LightGray;
            Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_FEATURE"] = "POCKET";
        }

        private void island_Checked(object sender, RoutedEventArgs e)
        {
            ISLAND_HEIGHT.IsReadOnly = false;
            ISLAND_HEIGHT.Background = Brushes.White;
            Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_FEATURE"] = "ISLAND";
        }

        private void WIDTH_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(WIDTH.Text, WIDTH);
            Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_WIDTH"] = WIDTH.Text;
        }

        private void HEIGHT_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(ISLAND_HEIGHT.Text, ISLAND_HEIGHT);
            Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_HEIGHT"] = ISLAND_HEIGHT.Text;
        }
    }
}
