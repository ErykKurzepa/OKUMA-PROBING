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
    /// Interaction logic for WKS_Y_4_POINTS_HOLE.xaml
    /// </summary>
    public partial class WKS_Y_4_POINTS_HOLE : Page
    {
        public WKS_Y_4_POINTS_HOLE()
        {
            InitializeComponent();

          
        }



        private void X_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(X.Text, X);
            Application.Current.Properties["WKS_Y_4_POINTS_HOLE_X"] = X.Text;
        }

        private void Y_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(Y.Text, Y);
            Application.Current.Properties["WKS_Y_4_POINTS_HOLE_Y"] = Y.Text;
        }

        private void Z_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(Z.Text, Z);
            Application.Current.Properties["WKS_Y_4_POINTS_HOLE_Z"] = Z.Text;
        }

        private void Z0_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(Z0.Text, Z0);
            Application.Current.Properties["WKS_Y_4_POINTS_HOLE_Y0"] = Z0.Text;
        }

        private void D_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(D.Text, D);
            Application.Current.Properties["WKS_Y_4_POINTS_HOLE_D"] = D.Text;
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

        }

        private void BOSS_Checked(object sender, RoutedEventArgs e)
        {
            FEATURE_HEIGHT.IsReadOnly = false;
            FEATURE_HEIGHT.Background = Brushes.White;

        }

        private void FEATURE_HEIGHT_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(FEATURE_HEIGHT.Text, FEATURE_HEIGHT);
            Application.Current.Properties["WKS_Y_4_POINT_POCKET_FEATURE_HEIGHT"] = FEATURE_HEIGHT.Text;
        }

        private void SAMEASX_Checked(object sender, RoutedEventArgs e)
        {
         
                X.IsReadOnly = true;
                X.Background = Brushes.LightGray;
                X.Text = Application.Current.Properties["WKS_X_4_POINTS_HOLE_BOSS_X"].ToString();
            Application.Current.Properties["WKS_Y_4_POINTS_HOLE_BOSS_X"] = X.Text;
                Y.IsReadOnly = true;
                Y.Background = Brushes.LightGray;
            Y.Text = Application.Current.Properties["WKS_X_4_POINTS_HOLE_BOSS_Y"].ToString();
            Application.Current.Properties["WKS_Y_4_POINTS_HOLE_BOSS_Y"] = Y.Text;
            Z.IsReadOnly = true;
                Z.Background = Brushes.LightGray;
            Z.Text = Application.Current.Properties["WKS_X_4_POINTS_HOLE_BOSS_Z"].ToString();
            Application.Current.Properties["WKS_Y_4_POINTS_HOLE_BOSS_Z"] = Z.Text;
            Z0.IsReadOnly = true;
                Z0.Background = Brushes.LightGray;
            Z0.Text = Application.Current.Properties["WKS_X_4_POINTS_HOLE_BOSS_X0"].ToString();
            Application.Current.Properties["WKS_Y_4_POINTS_HOLE_BOSS_X0"] = Z0.Text;
            D.IsReadOnly = true;
                D.Background = Brushes.LightGray;
            D.Text = Application.Current.Properties["WKS_X_4_POINTS_HOLE_BOSS_D"].ToString();
            Application.Current.Properties["WKS_Y_4_POINTS_HOLE_BOSS_D"] = D.Text;
            FEATURE_HEIGHT.IsReadOnly = true;
                FEATURE_HEIGHT.Background = Brushes.LightGray;
            FEATURE_HEIGHT.Text = Application.Current.Properties["WKS_X_4_POINTS_HOLE_BOSS_HEIGHT"].ToString();
            Application.Current.Properties["WKS_Y_4_POINTS_HOLE_BOSS_HEIGHT"] = FEATURE_HEIGHT.Text;

            Application.Current.Properties["WKS_Y_4_POINT_POCKET_SAME_AS_X_CHECKED"] = "1";




        }

        private void SAMEASX_Unchecked(object sender, RoutedEventArgs e)
        {
            X.IsReadOnly = false;
            X.Background = Brushes.White;
            Y.IsReadOnly = false;
            Y.Background = Brushes.White;
            Z.IsReadOnly = false;
            Z.Background = Brushes.White;
            Z0.IsReadOnly = false;
            Z0.Background = Brushes.White;
            D.IsReadOnly = false;
            D.Background = Brushes.White;
            FEATURE_HEIGHT.IsReadOnly = false;
            FEATURE_HEIGHT.Background = Brushes.White;
            Application.Current.Properties["WKS_Y_4_POINT_POCKET_SAME_AS_X_CHECKED"] = "0";
        }
    }
}
