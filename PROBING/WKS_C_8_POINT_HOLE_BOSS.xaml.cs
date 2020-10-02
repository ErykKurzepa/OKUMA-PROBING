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
    /// Interaction logic for WKS_C_8_POINT_HOLE_BOSS.xaml
    /// </summary>
    public partial class WKS_C_8_POINT_HOLE_BOSS : Page
    {
        public WKS_C_8_POINT_HOLE_BOSS()
        {
            InitializeComponent();
        }


        private void X1_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(X1.Text, X1);
            Application.Current.Properties["WKS_C_8_POINT_HOLE_BOSS_X1"] = X1.Text;
        }

        private void Y1_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(Y1.Text, Y1);
            Application.Current.Properties["WKS_C_8_POINT_HOLE_BOSS_Y1"] = Y1.Text;
        }

        private void Z1_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(Z1.Text, Z1);
            Application.Current.Properties["WKS_C_8_POINT_HOLE_BOSS_Z1"] = Z1.Text;
        }

        private void X2_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(X2.Text, X2);
            Application.Current.Properties["WKS_C_8_POINT_HOLE_BOSS_X2"] = X2.Text;
        }

        private void Y2_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(Y2.Text, Y2);
            Application.Current.Properties["WKS_C_8_POINT_HOLE_BOSS_Y2"] = Y2.Text;
        }

        private void Z2_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(Z2.Text, Z2);
            Application.Current.Properties["WKS_C_8_POINT_HOLE_BOSS_Z2"] = Z2.Text;
        }

     


        private void C0_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(C0.Text, C0);
            Application.Current.Properties["WKS_C_8_POINT_HOLE_BOSS_C0"] = C0.Text;
        }

        private void HOLE_Checked(object sender, RoutedEventArgs e)
        {
            HEIGHT.IsReadOnly = true;
            HEIGHT.Background = Brushes.LightGray;
            Application.Current.Properties["WKS_C_8_POINT_HOLE_BOSS_FEATURE"] = "HOLE";

        }

        private void BOSS_Checked(object sender, RoutedEventArgs e)
        {
            HEIGHT.IsReadOnly = false;
            HEIGHT.Background = Brushes.White;
            Application.Current.Properties["WKS_C_8_POINT_HOLE_BOSS_FEATURE"] = "BOSS";

        }







        public bool IsNumericCheck(string tekst, TextBox TheTextBox)
        {
            float parsedValue;

            if (!float.TryParse(tekst, out parsedValue))
            {
                MessageBox.Show(tekst + " is not numeric");
                TheTextBox.Text = "0";

            }
            else
            {
               float x1;
               float.TryParse(X1.Text, out x1);
                float y1;
                float.TryParse(Y1.Text, out y1);
                
                float x2;
                float.TryParse(X2.Text, out x2);
                float y2;
                float.TryParse(Y2.Text, out y2);

                double C_Angle = Math.Atan2((y2 - y1), (x2 - x1));
                ANGLE.Content = (C_Angle * (180 / Math.PI)).ToString();

               

            }
            return true;
        }

        private void HEIGHT_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(HEIGHT.Text, HEIGHT);
            Application.Current.Properties["WKS_C_8_POINT_HOLE_BOSS_HEIGHT"] = HEIGHT.Text;
        }
    }
}
