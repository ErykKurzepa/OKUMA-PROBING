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
    /// Interaction logic for WKS_C_A_90_4_POINT_HOLE_BOSS.xaml
    /// </summary>
    public partial class WKS_C_A_90_4_POINT_HOLE_BOSS : Page
    {
        public WKS_C_A_90_4_POINT_HOLE_BOSS()
        {
            InitializeComponent();
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

        private void HOLE_Checked(object sender, RoutedEventArgs e)
        {
            FEATURE_HEIGHT.IsReadOnly = true;
            FEATURE_HEIGHT.Background = Brushes.LightGray;
            Application.Current.Properties["WKS_C_A_90_4_POINT_HOLE_BOSS_FEATURE"] = "HOLE";

        }

        private void BOSS_Checked(object sender, RoutedEventArgs e)
        {
            FEATURE_HEIGHT.IsReadOnly = false;
            FEATURE_HEIGHT.Background = Brushes.White;
            Application.Current.Properties["WKS_C_A_90_4_POINT_HOLE_BOSS_FEATURE"] = "BOSS";
        }

        private void A_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(A.Text, A);
            Application.Current.Properties["WKS_C_A_90_4_POINT_HOLE_BOSS_A"] = A.Text;
        }

        private void C_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(C.Text, C);
            Application.Current.Properties["WKS_C_A_90_4_POINT_HOLE_BOSS_C"] = C.Text;
        }

        private void X_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(X.Text, X);
            Application.Current.Properties["WKS_C_A_90_4_POINT_HOLE_BOSS_X"] = X.Text;
        }

        private void Y_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(Y.Text, Y);
            Application.Current.Properties["WKS_C_A_90_4_POINT_HOLE_BOSS_Y"] = Y.Text;
        }

        private void Z_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(Z.Text, Z);
            Application.Current.Properties["WKS_C_A_90_4_POINT_HOLE_BOSS_Z"] = Z.Text;
        }
        private void D_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(D.Text, D);
            Application.Current.Properties["WKS_C_A_90_4_POINT_HOLE_BOSS_D"] = D.Text;
        }

        private void FEATURE_HEIGHT_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(FEATURE_HEIGHT.Text, FEATURE_HEIGHT);
            Application.Current.Properties["WKS_C_A_90_4_POINT_HOLE_BOSS_FEATURE_HEIGHT"] = FEATURE_HEIGHT.Text;
        }
    }
}
