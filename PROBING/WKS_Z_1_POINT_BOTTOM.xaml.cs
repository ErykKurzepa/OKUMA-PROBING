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
    /// Interaction logic for WKS_Z_1_POINT_BOTTOM.xaml
    /// </summary>
    public partial class WKS_Z_1_POINT_BOTTOM : Page
    {
        public WKS_Z_1_POINT_BOTTOM()
        {
            InitializeComponent();
        }

        private void X_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(X.Text, X);
            Application.Current.Properties["WKS_Z_1_POINT_BOTTOM_X"] = X.Text;
        }

        private void Y_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(Y.Text, Y);
            Application.Current.Properties["WKS_Z_1_POINT_BOTTOM_Y"] = Y.Text;
        }

        private void Z_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(Z.Text, Z);
            Application.Current.Properties["WKS_Z_1_POINT_BOTTOM_Z"] = Z.Text;
        }

        private void Z0_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(Z0.Text, Z0);
            Application.Current.Properties["WKS_Z_1_POINT_BOTTOM_Z0"] = Z0.Text;
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

        private void C_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(C.Text, C);
            Application.Current.Properties["WKS_Z_1_POINT_BOTTOM_C"] = C.Text;
        }

        private void SAFET_OFFSET_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(SAFET_OFFSET.Text, SAFET_OFFSET);
            Application.Current.Properties["WKS_Z_1_POINT_BOTTOM_SAFET_OFFSET"] = SAFET_OFFSET.Text;
        }
    }
}
