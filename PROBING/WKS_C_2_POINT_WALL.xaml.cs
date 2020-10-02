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
    /// Interaction logic for WKS_C_2_POINT_WALL.xaml
    /// </summary>
    public partial class WKS_C_2_POINT_WALL : Page
    {
        public WKS_C_2_POINT_WALL()
        {
            InitializeComponent();
        }


        private void X1_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(X1.Text, X1);
            Application.Current.Properties["WKS_C_2_POINT_WALL_X1"] = X1.Text;
        }

        private void Y1_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(Y1.Text, Y1);
            Application.Current.Properties["WKS_C_2_POINT_WALL_Y1"] = Y1.Text;
        }

        private void Z1_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(Z1.Text, Z1);
            Application.Current.Properties["WKS_C_2_POINT_WALL_Z1"] = Z1.Text;
        }

        private void X2_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(X2.Text, X2);
            Application.Current.Properties["WKS_C_2_POINT_WALL_X2"] = X2.Text;
        }

        private void Y2_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(Y2.Text, Y2);
            Application.Current.Properties["WKS_C_2_POINT_WALL_Y2"] = Y2.Text;
        }

        private void Z2_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(Z2.Text, Z2);
            Application.Current.Properties["WKS_C_2_POINT_WALL_Z2"] = Z2.Text;
        }


        private void FIRST_APPROACH_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(FIRST_APPROACH.Text, FIRST_APPROACH);
            Application.Current.Properties["WKS_C_2_POINT_WALL_FIRST_APPROACH"] = FIRST_APPROACH.Text;
        }

        private void SECOND_APPROACH_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(SECOND_APPROACH.Text, SECOND_APPROACH);
            Application.Current.Properties["WKS_C_2_POINT_WALL_SECOND_APPROACH"] = SECOND_APPROACH.Text;
        }

        private void C0_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(C0.Text, C0);
            Application.Current.Properties["WKS_C_2_POINT_WALL_C0"] = C0.Text;
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
            Application.Current.Properties["WKS_C_2_POINT_WALL_AXIS"] = "Y";
        }

        private void PARALLEL_X_Checked(object sender, RoutedEventArgs e)
        {


            X2.Visibility = Visibility.Visible;
            Y2.Visibility = Visibility.Hidden;
            Application.Current.Properties["WKS_C_2_POINT_WALL_AXIS"] = "X";
        }
    }
}
