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
    /// Interaction logic for WKS_C_4_POINT_HOLE_BOSS.xaml
    /// </summary>
    public partial class WKS_C_4_POINT_HOLE_BOSS : Page
    {
        public WKS_C_4_POINT_HOLE_BOSS()
        {
            InitializeComponent();
        }


        private void X2_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(X2.Text, X2);
            Application.Current.Properties["WKS_C_4_POINT_HOLE_BOSS_X1"] = X2.Text;

            double X2_VALUE;
            double.TryParse(X2.Text, out X2_VALUE);
            double Y2_VALUE;
            double.TryParse(Y2.Text, out Y2_VALUE);
            double C_Angle = Math.Atan2(Y2_VALUE, X2_VALUE);
            c_angle_result.Content = (C_Angle * (180 / Math.PI)).ToString();
        }

        private void Y2_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(Y2.Text, Y2);
            Application.Current.Properties["WKS_C_4_POINT_HOLE_BOSS_Y1"] = Y2.Text;
            double X2_VALUE;
            double.TryParse(X2.Text, out X2_VALUE);
            double Y2_VALUE;
            double.TryParse(Y2.Text, out Y2_VALUE);
            double C_Angle = Math.Atan2(Y2_VALUE, X2_VALUE);
            c_angle_result.Content = (C_Angle * (180 / Math.PI)).ToString();

        }

        private void Z2_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(Z2.Text, Z2);
            Application.Current.Properties["WKS_C_4_POINT_HOLE_BOSS_Z1"] = Z2.Text;
        }

        private void D_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(D.Text, D);
            Application.Current.Properties["WKS_C_4_POINT_HOLE_BOSS_D"] = D.Text;
        }



        private void HOLE_Checked(object sender, RoutedEventArgs e)
        {
            FEATURE_HEIGHT.IsReadOnly = true;
            FEATURE_HEIGHT.Background = Brushes.LightGray;
            Application.Current.Properties["WKS_C_4_POINT_HOLE_BOSS_FEATURE"] = "HOLE";

        }

        private void BOSS_Checked(object sender, RoutedEventArgs e)
        {
            FEATURE_HEIGHT.IsReadOnly = false;
            FEATURE_HEIGHT.Background = Brushes.White;
            Application.Current.Properties["WKS_C_4_POINT_HOLE_BOSS_FEATURE"] = "BOSS";

        }

        private void FEATURE_HEIGHT_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(FEATURE_HEIGHT.Text, FEATURE_HEIGHT);
            Application.Current.Properties["WKS_C_4_POINT_HOLE_BOSS_HEIGHT"] = FEATURE_HEIGHT.Text;
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

      
    }
}
