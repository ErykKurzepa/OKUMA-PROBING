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
    /// Logika interakcji dla klasy WKS_SETUP.xaml
    /// </summary>
    public partial class WKS_SETUP : Page
    {
        

        public WKS_SETUP()
        {

            InitializeComponent();

            COMBOBOX_X.SelectedIndex = 0;
            COMBOBOX_Y.SelectedIndex = 0;
            COMBOBOX_Z.SelectedIndex = 0;
            COMBOBOX_C.SelectedIndex = 0;
           

            //preselections HOME POSITION
            Application.Current.Properties["WKS_VZOFX"] = 0;
            Application.Current.Properties["WKS_VZOFY"] = 0;
            Application.Current.Properties["WKS_VZOFZ"] = 200;
            Application.Current.Properties["WKS_VZOFA"] = 0;
            Application.Current.Properties["WKS_VZOFC"] = 0;
            //PRESELECTION MEASUREMENT METHOD
            Application.Current.Properties["WKS_X_METHOD"] = "NO MEASUREMENT";
            Application.Current.Properties["WKS_Y_METHOD"] = "NO MEASUREMENT";
            Application.Current.Properties["WKS_Z_METHOD"] = "NO MEASUREMENT";
            Application.Current.Properties["WKS_C_METHOD"] = "NO MEASUREMENT";
            //PRESELECTIONS X
            //PRESELECTION WKS_X_1_POINT_WALL
            Application.Current.Properties["WKS_X_1_POINT_X"] = 0;
            Application.Current.Properties["WKS_X_1_POINT_Y"] = 0;
            Application.Current.Properties["WKS_X_1_POINT_Z"] = 0;
            Application.Current.Properties["WKS_X_1_POINT_X0"] = 0;
            Application.Current.Properties["WKS_X_1_POINT_SAFET_OFFSET"] = 10;
            //PRESELECTION WKS_X_2_POINT_POCKET_ISLAND
            Application.Current.Properties["WKS_X_2_POINT_POCKET_ISLAND_X"] = 0;
            Application.Current.Properties["WKS_X_2_POINT_POCKET_ISLAND_Y"] = 0;
            Application.Current.Properties["WKS_X_2_POINT_POCKET_ISLAND_Z"] = 0;
            Application.Current.Properties["WKS_X_2_POINT_POCKET_ISLAND_X0"] = 0;
            Application.Current.Properties["WKS_X_2_POINT_POCKET_ISLAND_D"] = 10;
            Application.Current.Properties["WKS_X_2_POINT_POCKET_ISLAND_HEIGHT"] = 10;
            Application.Current.Properties["WKS_X_2_POINT_POCKET_ISLAND_FEATURE"] = "POCKET";
            //PRESELECTION WKS_X_4_POINTS_HOLE_BOSS
            Application.Current.Properties["WKS_X_4_POINTS_HOLE_BOSS_X"] = 0;
            Application.Current.Properties["WKS_X_4_POINTS_HOLE_BOSS_Y"] = 0;
            Application.Current.Properties["WKS_X_4_POINTS_HOLE_BOSS_Z"] = 0;
            Application.Current.Properties["WKS_X_4_POINTS_HOLE_BOSS_X0"] = 0;
            Application.Current.Properties["WKS_X_4_POINTS_HOLE_BOSS_D"] = 10;
            Application.Current.Properties["WKS_X_4_POINTS_HOLE_BOSS_HEIGHT"] = 10;
            Application.Current.Properties["WKS_X_4_POINTS_HOLE_BOSS_FEATURE"] = "HOLE";

//PRESELECTIONS Y
            //PRESELECTION WKS_Y_1_POINT_WALL
            Application.Current.Properties["WKS_Y_1_POINT_X"] = 0;
            Application.Current.Properties["WKS_Y_1_POINT_Y"] = 0;
            Application.Current.Properties["WKS_Y_1_POINT_Z"] = 0;
            Application.Current.Properties["WKS_Y_1_POINT_Y0"] = 0;
            Application.Current.Properties["WKS_Y_1_POINT_SAFET_OFFSET"] = 10;
            //PRESELECTION WKS_Y_2_POINT_POCKET_ISLAND
            Application.Current.Properties["WKS_Y_2_POINT_POCKET_ISLAND_X"] = 0;
            Application.Current.Properties["WKS_Y_2_POINT_POCKET_ISLAND_Y"] = 0;
            Application.Current.Properties["WKS_Y_2_POINT_POCKET_ISLAND_Z"] = 0;
            Application.Current.Properties["WKS_Y_2_POINT_POCKET_ISLAND_Y0"] = 0;
            Application.Current.Properties["WKS_Y_2_POINT_POCKET_ISLAND_D"] = 10;
            Application.Current.Properties["WKS_Y_2_POINT_POCKET_ISLAND_HEIGHT"] = 10;
            Application.Current.Properties["WKS_Y_2_POINT_POCKET_ISLAND_FEATURE"] = "POCKET";
            //PRESELECTION WKS_Y_4_POINTS_HOLE_BOSS
            Application.Current.Properties["WKS_Y_4_POINTS_HOLE_BOSS_X"] = 0;
            Application.Current.Properties["WKS_Y_4_POINTS_HOLE_BOSS_Y"] = 0;
            Application.Current.Properties["WKS_Y_4_POINTS_HOLE_BOSS_Z"] = 0;
            Application.Current.Properties["WKS_Y_4_POINTS_HOLE_BOSS_Y0"] = 0;
            Application.Current.Properties["WKS_Y_4_POINTS_HOLE_BOSS_D"] = 10;
            Application.Current.Properties["WKS_Y_4_POINTS_HOLE_BOSS_HEIGHT"] = 10;
            Application.Current.Properties["WKS_Y_4_POINTS_HOLE_BOSS_FEATURE"] = "HOLE";
            Application.Current.Properties["WKS_Y_4_POINT_POCKET_SAME_AS_X_CHECKED"] = "0";

            //PRESELECTIONS Z
            //PRESELECTION WKS_Z_1_POINT
            Application.Current.Properties["WKS_Z_1_POINT_X"] = 0;
            Application.Current.Properties["WKS_Z_1_POINT_Y"] = 0;
            Application.Current.Properties["WKS_Z_1_POINT_Z"] = 0;
            Application.Current.Properties["WKS_Z_1_POINT_Z0"] = 0;
            // PRESELECTION WKS_Z_4_POINT
            Application.Current.Properties["WKS_Z_4_POINT_X"] = 0;
            Application.Current.Properties["WKS_Z_4_POINT_Y"] = 0;
            Application.Current.Properties["WKS_Z_4_POINT_Z"] = 0;
            Application.Current.Properties["WKS_Z_4_POINT_Z0"] = 0;
            Application.Current.Properties["WKS_Z_4_POINT_D"] = 30;
            //PRESELECTION WKS_Z_1_POINT_BOTTOM
            Application.Current.Properties["WKS_Z_1_POINT_BOTTOM_X"] = 0;
            Application.Current.Properties["WKS_Z_1_POINT_BOTTOM_Y"] = 0;
            Application.Current.Properties["WKS_Z_1_POINT_BOTTOM_Z"] = 0;
            Application.Current.Properties["WKS_Z_1_POINT_BOTTOM_C"] = 0;
            Application.Current.Properties["WKS_Z_1_POINT_BOTTOM_Z0"] = 0;
            Application.Current.Properties["WKS_Z_1_POINT_BOTTOM_SAFET_OFFSET"] = 10;
            //PRESELECTION WKS_Z_4_POINT_BOTTOM
            Application.Current.Properties["WKS_Z_4_POINT_BOTTOM_X"] = 0;
            Application.Current.Properties["WKS_Z_4_POINT_BOTTOM_Y"] = 0;
            Application.Current.Properties["WKS_Z_4_POINT_BOTTOM_Z"] = 0;
            Application.Current.Properties["WKS_Z_4_POINT_BOTTOM_C"] = 0;
            Application.Current.Properties["WKS_Z_4_POINT_BOTTOM_Z0"] = 0;
            Application.Current.Properties["WKS_Z_4_POINT_BOTTOM_DIAMETER"] = 10;
            Application.Current.Properties["WKS_Z_4_POINT_BOTTOM_HOLE_BOSS_FEATURE"] = "HOLE";
            Application.Current.Properties["WKS_Z_4_POINT_BOTTOM_HOLE_BOSS_HEIGHT"] = 10;

//PRESELECTION C

            //WKS_C_4_POINT_HOLE_BOSS
             Application.Current.Properties["WKS_C_4_POINT_HOLE_BOSS_X1"] = 0;
            Application.Current.Properties["WKS_C_4_POINT_HOLE_BOSS_Y1"] = 10;
            Application.Current.Properties["WKS_C_4_POINT_HOLE_BOSS_Z1"] = 0;
            Application.Current.Properties["WKS_C_4_POINT_HOLE_BOSS_D"] = 10;
            Application.Current.Properties["WKS_C_4_POINT_HOLE_BOSS_FEATURE"] = "HOLE";
            Application.Current.Properties["WKS_C_4_POINT_HOLE_BOSS_HEIGHT"] = 10;
            //PRESELECTION WKS_C_2_POINT_WALL
            Application.Current.Properties["WKS_C_2_POINT_WALL_X1"] = 0;
            Application.Current.Properties["WKS_C_2_POINT_WALL_Y1"] = 0;
            Application.Current.Properties["WKS_C_2_POINT_WALL_Z1"] = 0;
            Application.Current.Properties["WKS_C_2_POINT_WALL_X2"] = 0;
            Application.Current.Properties["WKS_C_2_POINT_WALL_Y2"] = 0;
            Application.Current.Properties["WKS_C_2_POINT_WALL_Z2"] = 0;
            Application.Current.Properties["WKS_C_2_POINT_WALL_FIRST_APPROACH"] = 10;
                Application.Current.Properties["WKS_C_2_POINT_WALL_SECOND_APPROACH"] = 10;
            Application.Current.Properties["WKS_C_2_POINT_WALL_AXIS"] = "X";

            //PRESELECTION WKS_C_4_POINT_POCKET_ISLAND
            Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_X1"] = 0;
            Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_Y1"] = 0;
            Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_Z1"] = 0;
            Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_X2"] = 0;
            Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_Y2"] = 0;
            Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_Z2"] = 0;
            Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_WIDTH"] = 10;
            Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_HEIGHT"] = 10;
            Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_AXIS"] = "X";
            Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_FEATURE"] = "POCKET";
            //WKS_C_A_90_4_POINT_HOLE_BOSS
            Application.Current.Properties["WKS_C_A_90_4_POINT_HOLE_BOSS_X"] = 0;
            Application.Current.Properties["WKS_C_A_90_4_POINT_HOLE_BOSS_Y"] = 0;
            Application.Current.Properties["WKS_C_A_90_4_POINT_HOLE_BOSS_Z"] = 0;
            Application.Current.Properties["WKS_C_A_90_4_POINT_HOLE_BOSS_A"] = -90;
            Application.Current.Properties["WKS_C_A_90_4_POINT_HOLE_BOSS_C"] = 0;
            Application.Current.Properties["WKS_C_A_90_4_POINT_HOLE_BOSS_D"] = 10;
            Application.Current.Properties["WKS_C_A_90_4_POINT_HOLE_BOSS_FEATURE_HEIGHT"] = 10;
            Application.Current.Properties["WKS_C_A_90_4_POINT_HOLE_BOSS_FEATURE"] = "HOLE";

            //WKS_C_A_90_4_POINT_HOLE_BOSS
            Application.Current.Properties["WKS_C_A-90_4_POINT_SLOT_ISLAND_X"] = 0;
            Application.Current.Properties["WKS_C_A-90_4_POINT_SLOT_ISLAND_Y"] = 0;
            Application.Current.Properties["WKS_C_A-90_4_POINT_SLOT_ISLAND_Z"] = 0;
            Application.Current.Properties["WKS_C_A-90_4_POINT_SLOT_ISLAND_A"] = -90;
            Application.Current.Properties["WKS_C_A-90_4_POINT_SLOT_ISLAND_C"] = 0;
            Application.Current.Properties["WKS_C_A-90_4_POINT_SLOT_ISLAND_D"] = 10;
            Application.Current.Properties["WKS_C_A-90_4_POINT_SLOT_ISLAND_FEATURE_HEIGHT"] = 10;
            Application.Current.Properties["WKS_C_A-90_4_POINT_SLOT_ISLAND_FEATURE"] = "HOLE";
            //WKS_C_A_90_8_POINT_HOLE_BOSS
            Application.Current.Properties["WKS_C_8_POINT_HOLE_BOSS_X1"] = 0;
            Application.Current.Properties["WKS_C_8_POINT_HOLE_BOSS_Y1"] = 0;
            Application.Current.Properties["WKS_C_8_POINT_HOLE_BOSS_Z1"] = 0;
            Application.Current.Properties["WKS_C_8_POINT_HOLE_BOSS_X2"] = 0;
            Application.Current.Properties["WKS_C_8_POINT_HOLE_BOSS_Y2"] = 0;
            Application.Current.Properties["WKS_C_8_POINT_HOLE_BOSS_Z2"] = 0;



        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {

            int error = 0;
            int probe_call = 0;


            string[] lines = {
                "(*** BASIC WKS SETUP ***)",
                "VZOFX[1]=" + Application.Current.Properties["WKS_VZOFX"],
                "VZOFY[1]="+ Application.Current.Properties["WKS_VZOFY"],
                "VZOFZ[1]="+ Application.Current.Properties["WKS_VZOFZ"],
                "VZOFA[1]=0",
                "VZOFC[1]="+ Application.Current.Properties["WKS_VZOFC"],
                "(*** PROBING WKS WITH RENISHAW: ***)",
                "( ***  SPHERE DIAMETER: " + SphereDiameter.Text + "MM, STYLUS DIAMETER: " + StylusDiameter.Text +"MM *** )",
                "(--- X METHOD: " + Application.Current.Properties["WKS_X_METHOD"] + " --- )",
                "(--- Y METHOD: " + Application.Current.Properties["WKS_Y_METHOD"] + " --- )",
                "(--- Z METHOD: " + Application.Current.Properties["WKS_Z_METHOD"] + " --- )",
                "(--- C METHOD: " + Application.Current.Properties["WKS_C_METHOD"] + " --- )",
            };

            List<string> X_CNC_CODE = new List<string> { };
            List<string> Y_CNC_CODE = new List<string> { };
            List<string> Z_CNC_CODE = new List<string> { };
            List<string> C1_CNC_CODE = new List<string> { };
            List<string> C2_CNC_CODE = new List<string> { };
            List<string> PROBE_START_CNC_CODE = new List<string> { };
            List<string> PROBE_END_CNC_CODE = new List<string> { };

              PROBE_START_CNC_CODE.Add("N200");
            PROBE_START_CNC_CODE.Add("T200 M6");
            PROBE_START_CNC_CODE.Add("G15 H1");
            PROBE_START_CNC_CODE.Add("G56 HA Z500");
            PROBE_START_CNC_CODE.Add("A0 C0");
            PROBE_START_CNC_CODE.Add("CALL OO18");


          //  PROBE_END_CNC_CODE.Add("G0 Z500");
            PROBE_END_CNC_CODE.Add("CALL OO19");
            PROBE_END_CNC_CODE.Add("M1");

            // X MEASUREMENT CALCULATION
            switch (Application.Current.Properties["WKS_X_METHOD"])
            {
                case "":
                    MessageBox.Show("Please specify X coordinate measurement method", "ERROR", MessageBoxButton.OK);
                    error = 1;
                    break;
                case "NO MEASUREMENT":
                    break;
//X WALL MEASUREMENT
                case "WALL MEASUREMENT":
                    X_CNC_CODE.Add("(*** X WALL MEASUREMENT ***)");
                    probe_call = 1;
                    float X_POSITION;
                    float X_SAFETY;
                    float.TryParse(Application.Current.Properties["WKS_X_1_POINT_X"].ToString(), out X_POSITION);
                    float.TryParse(Application.Current.Properties["WKS_X_1_POINT_SAFET_OFFSET"].ToString(), out X_SAFETY);
                    float X_OFFSET = X_POSITION + X_SAFETY;

                X_CNC_CODE.Add("G114 X" + X_OFFSET + " Y" + 
                    Application.Current.Properties["WKS_X_1_POINT_Y"]);
                    X_CNC_CODE.Add("G114 Z" + Application.Current.Properties["WKS_X_1_POINT_Z"]);
                    X_CNC_CODE.Add("CALL OO10 PMOD=1 PEI=" + Application.Current.Properties["WKS_X_1_POINT_X"]);
                    X_CNC_CODE.Add("CALL OO20 PHN=1 PX=" + Application.Current.Properties["WKS_X_1_POINT_X0"]);
                    X_CNC_CODE.Add("G0 Z500");
                    break;
//X POCKET ISLAND MEASUREMENT
                case "POCKET MEASUREMENT":
                    X_CNC_CODE.Add("(*** X POCKET / ISLAND MEASUREMENT ***)");
                    probe_call = 1;
                    X_CNC_CODE.Add("G114 X" + Application.Current.Properties["WKS_X_2_POINT_POCKET_ISLAND_X"] + " Y" +
                        Application.Current.Properties["WKS_X_2_POINT_POCKET_ISLAND_Y"]);
                    if (Application.Current.Properties["WKS_X_2_POINT_POCKET_ISLAND_FEATURE"] == "POCKET")
                    {
                        X_CNC_CODE.Add("G114 Z" + Application.Current.Properties["WKS_X_2_POINT_POCKET_ISLAND_Z"]);
                        X_CNC_CODE.Add("CALL OO10 PMOD=11 PELI=" + Application.Current.Properties["WKS_X_2_POINT_POCKET_ISLAND_D"]);
                        X_CNC_CODE.Add("CALL OO20 PHN=1 PX=" + Application.Current.Properties["WKS_X_2_POINT_POCKET_ISLAND_X0"]);
                        X_CNC_CODE.Add("G0 Z500");
                    }
                    else
                    {
                        float ISLAND_HEIGHT;
                        float Z_POSITION;
                        float.TryParse(Application.Current.Properties["WKS_X_2_POINT_POCKET_ISLAND_HEIGHT"].ToString(), out ISLAND_HEIGHT);
                        float.TryParse(Application.Current.Properties["WKS_X_2_POINT_POCKET_ISLAND_Z"].ToString(), out Z_POSITION);
                        float Z_SAFE = Z_POSITION + ISLAND_HEIGHT;
                        float Z_DEPTH = ISLAND_HEIGHT;
                        X_CNC_CODE.Add("G114 Z" + Z_SAFE);
                        X_CNC_CODE.Add("CALL OO10 PMOD=11 PELI=" + Application.Current.Properties["WKS_X_2_POINT_POCKET_ISLAND_D"] + " PIN=" + Z_DEPTH);
                        X_CNC_CODE.Add("CALL OO20 PHN=1 PX=" + Application.Current.Properties["WKS_X_2_POINT_POCKET_ISLAND_X0"]);
                        X_CNC_CODE.Add("G0 Z500");
                    }
                    break;
//X HOLE BOSS MEASUREMENT
                case "HOLE MEASUREMENT":
                    X_CNC_CODE.Add("(*** X HOLE / BOSS MEASUREMENT ***)");
                    probe_call = 1;
                    X_CNC_CODE.Add("G114 X" + Application.Current.Properties["WKS_X_4_POINTS_HOLE_BOSS_X"] + " Y" +
                        Application.Current.Properties["WKS_X_4_POINTS_HOLE_BOSS_Y"]);
                    if (Application.Current.Properties["WKS_X_4_POINTS_HOLE_BOSS_FEATURE"] == "HOLE")
                    {
                        X_CNC_CODE.Add("G114 Z" + Application.Current.Properties["WKS_X_4_POINTS_HOLE_BOSS_Z"]);
                        X_CNC_CODE.Add("CALL OO10 PMOD=7 PDI=" + Application.Current.Properties["WKS_X_4_POINTS_HOLE_BOSS_D"]);
                        X_CNC_CODE.Add("CALL OO20 PHN=1 PX=" + Application.Current.Properties["WKS_X_4_POINTS_HOLE_BOSS_X0"]);
                        X_CNC_CODE.Add("G0 Z500");
                    }
                    else
                    {
                        float ISLAND_HEIGHT;
                        float Z_POSITION;
                        float.TryParse(Application.Current.Properties["WKS_X_4_POINTS_HOLE_BOSS_HEIGHT"].ToString(), out ISLAND_HEIGHT);
                        float.TryParse(Application.Current.Properties["WKS_X_4_POINTS_HOLE_BOSS_Z"].ToString(), out Z_POSITION);
                        float Z_SAFE = Z_POSITION + ISLAND_HEIGHT;
                        float Z_DEPTH = ISLAND_HEIGHT;
                        X_CNC_CODE.Add("G114 Z" + Z_SAFE);
                        X_CNC_CODE.Add("CALL OO10 PMOD=6 PDI=" + Application.Current.Properties["WKS_X_4_POINTS_HOLE_BOSS_D"] + " PZIN=" + Z_DEPTH);
                        X_CNC_CODE.Add("CALL OO20 PHN=1 PX=" + Application.Current.Properties["WKS_X_4_POINTS_HOLE_BOSS_X0"]);
                        X_CNC_CODE.Add("G0 Z500");
                    }


                    break;
                default:
                    break;
            }

// Y MEASUREMENT CALCULATION

            switch (Application.Current.Properties["WKS_Y_METHOD"])
            {
                case "":
                    MessageBox.Show("Please specify Y coordinate measurement method", "ERROR", MessageBoxButton.OK);
                    error = 1;
                    break;
                case "NO MEASUREMENT":
                    break;
//Y WALL MEASUREMENT
                case "WALL MEASUREMENT":
                    Y_CNC_CODE.Add("(*** Y WALL MEASUREMENT ***)");
                    probe_call = 1;
                    float Y_POSITION;
                    float Y_SAFETY;
                    float.TryParse(Application.Current.Properties["WKS_Y_1_POINT_Y"].ToString(), out Y_POSITION);
                    float.TryParse(Application.Current.Properties["WKS_Y_1_POINT_SAFET_OFFSET"].ToString(), out Y_SAFETY);
                    float Y_OFFSET = Y_POSITION + Y_SAFETY;

                    Y_CNC_CODE.Add("G114 X" + Application.Current.Properties["WKS_Y_1_POINT_X"] + " Y" + Y_OFFSET) ;
                    Y_CNC_CODE.Add("G114 Z" + Application.Current.Properties["WKS_Y_1_POINT_Z"]);
                    Y_CNC_CODE.Add("CALL OO10 PMOD=2 PEI=" + Application.Current.Properties["WKS_Y_1_POINT_Y"]);
                    Y_CNC_CODE.Add("CALL OO20 PHN=1 PY=" + Application.Current.Properties["WKS_Y_1_POINT_Y0"]);
                    Y_CNC_CODE.Add("G0 Z500");
                    break;
//Y POCKET ISLAND MEASUREMENT
                case "POCKET MEASUREMENT":
                    Y_CNC_CODE.Add("(*** Y POCKET / ISLAND MEASUREMENT ***)");
                    probe_call = 1;
                    Y_CNC_CODE.Add("G114 X" + Application.Current.Properties["WKS_Y_2_POINT_POCKET_ISLAND_X"] + " Y" +
                        Application.Current.Properties["WKS_Y_2_POINT_POCKET_ISLAND_Y"]);
                    if (Application.Current.Properties["WKS_Y_2_POINT_POCKET_ISLAND_FEATURE"] == "POCKET")
                    {
                        Y_CNC_CODE.Add("G114 Z" + Application.Current.Properties["WKS_Y_2_POINT_POCKET_ISLAND_Z"]);
                        Y_CNC_CODE.Add("CALL OO10 PMOD=11 PELI=" + Application.Current.Properties["WKS_Y_2_POINT_POCKET_ISLAND_D"]);
                        Y_CNC_CODE.Add("CALL OO20 PHN=1 PX=" + Application.Current.Properties["WKS_Y_2_POINT_POCKET_ISLAND_Y0"]);
                        Y_CNC_CODE.Add("G0 Z500");
                    }
                    else
                    {
                        float ISLAND_HEIGHT;
                        float Z_POSITION;
                        float.TryParse(Application.Current.Properties["WKS_Y_2_POINT_POCKET_ISLAND_HEIGHT"].ToString(), out ISLAND_HEIGHT);
                        float.TryParse(Application.Current.Properties["WKS_Y_2_POINT_POCKET_ISLAND_Z"].ToString(), out Z_POSITION);
                        float Z_SAFE = Z_POSITION + ISLAND_HEIGHT;
                        float Z_DEPTH = ISLAND_HEIGHT;
                        Y_CNC_CODE.Add("G114 Z" + Z_SAFE);
                        Y_CNC_CODE.Add("CALL OO10 PMOD=11 PELI=" + Application.Current.Properties["WKS_Y_2_POINT_POCKET_ISLAND_D"] + " PIN=" + Z_DEPTH);
                        Y_CNC_CODE.Add("CALL OO20 PHN=1 PX=" + Application.Current.Properties["WKS_Y_2_POINT_POCKET_ISLAND_Y0"]);
                        Y_CNC_CODE.Add("G0 Z500");
                    }
                    break;
//Y HOLE BOSS MEASUREMENT
                case "HOLE MEASUREMENT":

                    if (Application.Current.Properties["WKS_Y_4_POINT_POCKET_SAME_AS_X_CHECKED"] == "1")
                    {
                        if (Application.Current.Properties["WKS_X_METHOD"] == "HOLE MEASUREMENT")
                        {
                            Y_CNC_CODE.Add("(*** X AND Y HOLE / BOSS MEASUREMENT ***)");
                        }
                        else
                        {
                            Y_CNC_CODE.Add("(*** Y HOLE / BOSS MEASUREMENT ***)");
                        }

                    }


                   
                    probe_call = 1;
                    Y_CNC_CODE.Add("G114 X" + Application.Current.Properties["WKS_Y_4_POINTS_HOLE_BOSS_X"] + " Y" +
                        Application.Current.Properties["WKS_Y_4_POINTS_HOLE_BOSS_Y"]);
                    if (Application.Current.Properties["WKS_Y_4_POINTS_HOLE_BOSS_FEATURE"] == "HOLE")
                    {
                        Y_CNC_CODE.Add("G114 Z" + Application.Current.Properties["WKS_Y_4_POINTS_HOLE_BOSS_Z"]);
                        Y_CNC_CODE.Add("CALL OO10 PMOD=7 PDI=" + Application.Current.Properties["WKS_Y_4_POINTS_HOLE_BOSS_D"]);
                       

                        if (Application.Current.Properties["WKS_Y_4_POINT_POCKET_SAME_AS_X_CHECKED"] == "1")
                        {
                            if (Application.Current.Properties["WKS_X_METHOD"] == "HOLE MEASUREMENT")
                            {
                                Y_CNC_CODE.Add("CALL OO20 PHN=1 PX=" + Application.Current.Properties["WKS_Y_4_POINTS_HOLE_BOSS_Y0"] +" PY =" + Application.Current.Properties["WKS_Y_4_POINTS_HOLE_BOSS_Y0"]);
                            }
                            else
                            {
                                Y_CNC_CODE.Add("CALL OO20 PHN=1 PY=" + Application.Current.Properties["WKS_Y_4_POINTS_HOLE_BOSS_Y0"]);
                            }

                        }

                        Y_CNC_CODE.Add("G0 Z500");
                    }
                    else
                    {
                        float ISLAND_HEIGHT;
                        float Z_POSITION;
                        float.TryParse(Application.Current.Properties["WKS_Y_4_POINTS_HOLE_BOSS_HEIGHT"].ToString(), out ISLAND_HEIGHT);
                        float.TryParse(Application.Current.Properties["WKS_Y_4_POINTS_HOLE_BOSS_Z"].ToString(), out Z_POSITION);
                        float Z_SAFE = Z_POSITION + ISLAND_HEIGHT;
                        float Z_DEPTH = ISLAND_HEIGHT;
                        Y_CNC_CODE.Add("G114 Z" + Z_SAFE);
                        Y_CNC_CODE.Add("CALL OO10 PMOD=6 PDI=" + Application.Current.Properties["WKS_Y_4_POINTS_HOLE_BOSS_D"] + " PZIN=" + Z_DEPTH);
                        if (Application.Current.Properties["WKS_Y_4_POINT_POCKET_SAME_AS_X_CHECKED"] == "1")
                        {
                            if (Application.Current.Properties["WKS_X_METHOD"] != "HOLE MEASUREMENT")
                            {
                                Y_CNC_CODE.Add("CALL OO20 PHN=1 PX=" + Application.Current.Properties["WKS_Y_4_POINTS_HOLE_BOSS_Y0"] + " PY =" + Application.Current.Properties["WKS_Y_4_POINTS_HOLE_BOSS_Y0"]);
                            }
                            else
                            {
                                Y_CNC_CODE.Add("CALL OO20 PHN=1 PY=" + Application.Current.Properties["WKS_Y_4_POINTS_HOLE_BOSS_Y0"]);
                            }

                        }
                        Y_CNC_CODE.Add("G0 Z500");
                    }


                    break;
                default:
                    break;
            }


// Z MEASUREMENT CALCULATION

            switch (Application.Current.Properties["WKS_Z_METHOD"])
            {
                case "":
                    MessageBox.Show("Please specify Z coordinate measurement method", "ERROR", MessageBoxButton.OK);
                    error = 1;
                    break;
                case "NO MEASUREMENT":
                    break;
//Z ONE POINT TOP MEASUREMENT
                case "ONE POINT TOP MEASUREMENT":
                    Z_CNC_CODE.Add("(*** Z TOP 1 POINT MEASUREMENT ***)");
                    probe_call = 1;
                    float Z_POSITION;                
                    float.TryParse(Application.Current.Properties["WKS_Z_1_POINT_Z"].ToString(), out Z_POSITION);                   
                    float Z_SAFETY = Z_POSITION + 10;
                    Z_CNC_CODE.Add("G114 X" + Application.Current.Properties["WKS_Z_1_POINT_X"] + " Y" + Application.Current.Properties["WKS_Z_1_POINT_Y"]);
                    Z_CNC_CODE.Add("G114 Z" + Z_SAFETY);
                    Z_CNC_CODE.Add("CALL OO10 PMOD=3 PEI=" + Application.Current.Properties["WKS_Z_1_POINT_Z"]);
                    Z_CNC_CODE.Add("CALL OO20 PHN=1 PZ=" + Application.Current.Properties["WKS_Z_1_POINT_Z0"]);
                    Z_CNC_CODE.Add("G0 Z500");
                    break;
//Z FOUR POINT TOP MEASUREMENT
                case "FOUR POINT TOP MEASUREMENT":
                    Z_CNC_CODE.Add("(*** Z TOP 4 POINTS MEASUREMENT ***)");
                    probe_call = 1;
                    float Z_POSITION_4;
                    float.TryParse(Application.Current.Properties["WKS_Z_4_POINT_Z"].ToString(), out Z_POSITION_4);
                    float Z_DIAMETER;
                    float.TryParse(Application.Current.Properties["WKS_Z_4_POINT_D"].ToString(), out Z_DIAMETER);
                    float Z_SAFETY_4 = Z_POSITION_4 + 10;
                    Z_CNC_CODE.Add("G114 X" + Z_DIAMETER/2 + " Y0");
                    Z_CNC_CODE.Add("G114 Z" + Z_SAFETY_4);
                    Z_CNC_CODE.Add("CALL OO10 PMOD=3 PEI=" + Application.Current.Properties["WKS_Z_4_POINT_Z"]);
                    Z_CNC_CODE.Add("VC31=VS27");
                    Z_CNC_CODE.Add("G114 X0"  + " Y" + Z_DIAMETER / 2);
                    Z_CNC_CODE.Add("CALL OO10 PMOD=3 PEI=" + Application.Current.Properties["WKS_Z_4_POINT_Z"]);
                    Z_CNC_CODE.Add("VC32=VS27");
                    Z_CNC_CODE.Add("G114 X-" + Z_DIAMETER / 2 + " Y0");
                    Z_CNC_CODE.Add("CALL OO10 PMOD=3 PEI=" + Application.Current.Properties["WKS_Z_4_POINT_Z"]);
                    Z_CNC_CODE.Add("VC33=VS27");
                    Z_CNC_CODE.Add("G114 X0" + " Y-" + Z_DIAMETER / 2);
                    Z_CNC_CODE.Add("CALL OO10 PMOD=3 PEI=" + Application.Current.Properties["WKS_Z_4_POINT_Z"]);
                    Z_CNC_CODE.Add("VC34=VS27");
                    Z_CNC_CODE.Add("VC35=[VC31+VC32+VC33+VC34]/4");
                    Z_CNC_CODE.Add("VZOFZ[1]=VC35");
                    if (Application.Current.Properties["WKS_Z_4_POINT_Z0"].ToString()!="0")
                    {
                        Z_CNC_CODE.Add("VZOFZ[1]=VZOFZ[1] - [" + Application.Current.Properties["WKS_Z_4_POINT_Z0"] + "]");
                    }
                    Z_CNC_CODE.Add("G0 Z500");
                    break;
//ONE POINT BOTTOM MEASUREMENT
                case "ONE POINT BOTTOM MEASUREMENT":
                    Z_CNC_CODE.Add("(*** Z BOTTOM 1 POINT MEASUREMENT ***)");
                    probe_call = 1;
                    float Y_POSITION;
                    float Y_OFFSET;
                    float.TryParse(Application.Current.Properties["WKS_Z_1_POINT_BOTTOM_Y"].ToString(), out Y_POSITION);
                    float.TryParse(Application.Current.Properties["WKS_Z_1_POINT_BOTTOM_SAFET_OFFSET"].ToString(), out Y_OFFSET);
                    float Y_SAFETY = Y_POSITION + Y_OFFSET;
                    Z_CNC_CODE.Add("CALL OO88 PX=0 PY=0 PZ=0 PA=-90 PC=" + Application.Current.Properties["WKS_Z_1_POINT_BOTTOM_C"]  + " PH=1 PP=2");
                    Z_CNC_CODE.Add("G15 H2");
                  Z_CNC_CODE.Add("G114 X" + Application.Current.Properties["WKS_Z_1_POINT_BOTTOM_X"] + 
                        " Y" + Y_SAFETY);
                    Z_CNC_CODE.Add("G114 A-90 C" + Application.Current.Properties["WKS_Z_1_POINT_BOTTOM_C"]);
                    Z_CNC_CODE.Add("G114 Z" + Application.Current.Properties["WKS_Z_1_POINT_BOTTOM_Z"]);
                    Z_CNC_CODE.Add("CALL OO10 PMOD=2 PEI=" + Application.Current.Properties["WKS_Z_1_POINT_BOTTOM_Y"]);
                    Z_CNC_CODE.Add("G0 Z500");
                    Z_CNC_CODE.Add("G15 H1");
                    Z_CNC_CODE.Add("VC21=VS28");
                    Z_CNC_CODE.Add("VC22=" + Application.Current.Properties["WKS_Z_1_POINT_BOTTOM_Z0"] + "-VC21");
                    Z_CNC_CODE.Add("VC23=VZOFZ[1]");
                    Z_CNC_CODE.Add("VZOFZ[1]=VC23+VC22");
                    break;

//FOUR POINT BOTTOM MEASUREMENT
                case "FOUR POINT BOTTOM MEASUREMENT":
                    Z_CNC_CODE.Add("(*** Z BOTTOM HOLE / BOSS MEASUREMENT ***)");
                    probe_call = 1;
                    float Z_POSITION_FEATURE;    
                    float.TryParse(Application.Current.Properties["WKS_Z_4_POINT_BOTTOM_Z"].ToString(), out Z_POSITION_FEATURE);
                    float Z_BOSS_HEIGHT;
                    float.TryParse(Application.Current.Properties["WKS_Z_4_POINT_BOTTOM_HOLE_BOSS_HEIGHT"].ToString(), out Z_BOSS_HEIGHT);
                    float Z_BOSS_OFFSET = Z_POSITION_FEATURE + Z_BOSS_HEIGHT;

                    Z_CNC_CODE.Add("CALL OO88 PX=0 PY=0 PZ=0 PA=-90 PC=" + Application.Current.Properties["WKS_Z_4_POINT_BOTTOM_C"] + " PH=1 PP=2");
                    Z_CNC_CODE.Add("G15 H2");
                    Z_CNC_CODE.Add("G114 X" + Application.Current.Properties["WKS_Z_4_POINT_BOTTOM_X"] +
                          " Y" + Application.Current.Properties["WKS_Z_4_POINT_BOTTOM_Y"]);
                    Z_CNC_CODE.Add("G114 A-90 C" + Application.Current.Properties["WKS_Z_4_POINT_BOTTOM_C"]);

                    if (Application.Current.Properties["WKS_Z_4_POINT_BOTTOM_HOLE_BOSS_FEATURE"] == "HOLE")
                    {

                        Z_CNC_CODE.Add("G114 Z" + Application.Current.Properties["WKS_Z_4_POINT_BOTTOM_Z"]);
                        Z_CNC_CODE.Add("CALL OO10 PMOD=7 PDI=" + Application.Current.Properties["WKS_Z_4_POINT_BOTTOM_DIAMETER"]);

                    }
                    else
                    {
                        Z_CNC_CODE.Add("G114 Z" + Z_BOSS_OFFSET);
                        Z_CNC_CODE.Add("CALL OO10 PMOD=6 PDI=" + Application.Current.Properties["WKS_Z_4_POINT_BOTTOM_DIAMETER"] +
                            " PZIN=" + Z_BOSS_HEIGHT);
                    }
                    Z_CNC_CODE.Add("G0 Z500");
                    Z_CNC_CODE.Add("G15 H1");
                    Z_CNC_CODE.Add("VC21=VS28");
                    Z_CNC_CODE.Add("VC22=" + Application.Current.Properties["WKS_Z_4_POINT_BOTTOM_Z0"] + "-VC21");
                    Z_CNC_CODE.Add("VC23=VZOFZ[1]");
                    Z_CNC_CODE.Add("VZOFZ[1]=VC23+VC22");
                    break;
                default:
                    break;



            }


// C MEASUREMENT CALCULATION

            switch (Application.Current.Properties["WKS_C_METHOD"])
            {
                case "":
                    MessageBox.Show("Please specify C coordinate measurement method", "ERROR", MessageBoxButton.OK);
                    error = 1;
                    break;
                case "NO MEASUREMENT":
                    break;
//C WALL MEASUREMENT
                case "WALL MEASUREMENT":
                    C1_CNC_CODE.Add("(*** C TOP WALL MEASUREMENT ***)");
                    probe_call = 1;
                    C1_CNC_CODE.Add("NSTAR G15 H1 A0 C0");

                    if (Application.Current.Properties["WKS_C_2_POINT_WALL_AXIS"] == "X")
                    {

                        float FIRST_APPROACH_DISTANCE;
                        float.TryParse(Application.Current.Properties["WKS_C_2_POINT_WALL_FIRST_APPROACH"].ToString(), out FIRST_APPROACH_DISTANCE);
                        float SECOND_APPROACH_DISTANCE;
                        float.TryParse(Application.Current.Properties["WKS_C_2_POINT_WALL_SECOND_APPROACH"].ToString(), out SECOND_APPROACH_DISTANCE);
                        float Y1_PROBING_POINT;
                        float.TryParse(Application.Current.Properties["WKS_C_2_POINT_WALL_Y1"].ToString(), out Y1_PROBING_POINT);
                        float Y2_PROBING_POINT;
                        float.TryParse(Application.Current.Properties["WKS_C_2_POINT_WALL_Y2"].ToString(), out Y2_PROBING_POINT);
                        float FIRST_APPROACH_POSITION = Y1_PROBING_POINT + FIRST_APPROACH_DISTANCE;
                        float SECOND_APPROACH_POSITION = Y1_PROBING_POINT + SECOND_APPROACH_DISTANCE;
                        float X1_PROBING_POINT;
                        float.TryParse(Application.Current.Properties["WKS_C_2_POINT_WALL_X1"].ToString(), out X1_PROBING_POINT);
                        float X2_PROBING_POINT;
                        float.TryParse(Application.Current.Properties["WKS_C_2_POINT_WALL_X2"].ToString(), out X2_PROBING_POINT);
                        float X_DISTANCE = Math.Abs( X1_PROBING_POINT - X2_PROBING_POINT);

                        C2_CNC_CODE.Add("G114 X" + Application.Current.Properties["WKS_C_2_POINT_WALL_X1"] + " Y" + FIRST_APPROACH_POSITION);
                        C2_CNC_CODE.Add("G114 Z" + Application.Current.Properties["WKS_C_2_POINT_WALL_Z1"]);
                        C2_CNC_CODE.Add("CALL OO10 PMOD=2 PEI=" + Y1_PROBING_POINT);
                        C2_CNC_CODE.Add("G0 Z500");
                        C2_CNC_CODE.Add("VC51 = VS29");
                        C2_CNC_CODE.Add("G114 X" + Application.Current.Properties["WKS_C_2_POINT_WALL_X2"] + " Y" + SECOND_APPROACH_POSITION);
                        C2_CNC_CODE.Add("G114 Z" + Application.Current.Properties["WKS_C_2_POINT_WALL_Z2"]);
                        C2_CNC_CODE.Add("CALL OO10 PMOD=2 PEI=" + Y1_PROBING_POINT);
                        C2_CNC_CODE.Add("G0 Z500");
                        C2_CNC_CODE.Add("VC52 = VS29");
                        C2_CNC_CODE.Add("VC53 = ABS[VC51 - VC52]");
                        C2_CNC_CODE.Add("VC54 = ATAN[VC53 / " + X_DISTANCE + "]");
                        C2_CNC_CODE.Add("IF[VC52 GT VC51]NMOD");
                        C2_CNC_CODE.Add("C = VC54 M115");
                        C2_CNC_CODE.Add("GOTO NUL");
                        C2_CNC_CODE.Add("NMOD C = -VC54 M116");
                        C2_CNC_CODE.Add("NUL VZOFC[1] = VRCOC - VMOFC");
                        C2_CNC_CODE.Add("IF[VC3 GT 0.005]NSTAR");

                    }
                    else
                    {
                        float FIRST_APPROACH_DISTANCE;
                        float.TryParse(Application.Current.Properties["WKS_C_2_POINT_WALL_FIRST_APPROACH"].ToString(), out FIRST_APPROACH_DISTANCE);
                        float SECOND_APPROACH_DISTANCE;
                        float.TryParse(Application.Current.Properties["WKS_C_2_POINT_WALL_SECOND_APPROACH"].ToString(), out SECOND_APPROACH_DISTANCE);
                        float X1_PROBING_POINT;
                        float.TryParse(Application.Current.Properties["WKS_C_2_POINT_WALL_X1"].ToString(), out X1_PROBING_POINT);
                        float X2_PROBING_POINT;
                        float.TryParse(Application.Current.Properties["WKS_C_2_POINT_WALL_X2"].ToString(), out X2_PROBING_POINT);
                        float FIRST_APPROACH_POSITION = X1_PROBING_POINT + FIRST_APPROACH_DISTANCE;
                        float SECOND_APPROACH_POSITION = X1_PROBING_POINT + SECOND_APPROACH_DISTANCE;
                        float Y1_PROBING_POINT;
                        float.TryParse(Application.Current.Properties["WKS_C_2_POINT_WALL_Y1"].ToString(), out Y1_PROBING_POINT);
                        float Y2_PROBING_POINT;
                        float.TryParse(Application.Current.Properties["WKS_C_2_POINT_WALL_Y2"].ToString(), out Y2_PROBING_POINT);
                        float Y_DISTANCE = Math.Abs(Y1_PROBING_POINT - Y2_PROBING_POINT);

                        C2_CNC_CODE.Add("G114 X" + FIRST_APPROACH_POSITION + " Y" + Application.Current.Properties["WKS_C_2_POINT_WALL_Y1"]);
                        C2_CNC_CODE.Add("G114 Z" + Application.Current.Properties["WKS_C_2_POINT_WALL_Z1"]);
                        C2_CNC_CODE.Add("CALL OO10 PMOD=1 PEI=" + X1_PROBING_POINT);
                        C2_CNC_CODE.Add("G0 Z500");
                        C2_CNC_CODE.Add("VC51 = VS28");
                        C2_CNC_CODE.Add("G114 X" + SECOND_APPROACH_POSITION + " Y" + Application.Current.Properties["WKS_C_2_POINT_WALL_Y2"]);
                        C2_CNC_CODE.Add("G114 Z" + Application.Current.Properties["WKS_C_2_POINT_WALL_Z2"]);
                        C2_CNC_CODE.Add("CALL OO10 PMOD=1 PEI=" + X1_PROBING_POINT);
                        C2_CNC_CODE.Add("G0 Z500");
                        C2_CNC_CODE.Add("VC52 = VS28");
                        C2_CNC_CODE.Add("VC53 = ABS[VC51 - VC52]");
                        C2_CNC_CODE.Add("VC54 = ATAN[VC53 / " + Y_DISTANCE + "]");
                        C2_CNC_CODE.Add("IF[VC52 LT VC51]NMOD");
                        C2_CNC_CODE.Add("C = VC54 M115");
                        C2_CNC_CODE.Add("GOTO NUL");
                        C2_CNC_CODE.Add("NMOD C = -VC54 M116");
                        C2_CNC_CODE.Add("NUL VZOFC[1] = VRCOC - VMOFC");
                        C2_CNC_CODE.Add("IF[VC3 GT 0.005]NSTAR");
                    }

                    break;
//C HOLE MEASUREMENT
                case "HOLE MEASUREMENT":
                    C1_CNC_CODE.Add("(*** C TOP HOLE / BOSS MEASUREMENT ***)");
                    probe_call = 1;
                    C1_CNC_CODE.Add("NSTAR G15 H1 A0 C0");
                    C2_CNC_CODE.Add("VC58 = " + Application.Current.Properties["WKS_C_4_POINT_HOLE_BOSS_X1"] + "(X POSITION)");
                    C2_CNC_CODE.Add("VC59 = " + Application.Current.Properties["WKS_C_4_POINT_HOLE_BOSS_Y1"] + "(Y POSITION)");
                    C2_CNC_CODE.Add("G114 X[VC58] Y[VC59]");

                    if (Application.Current.Properties["WKS_C_4_POINT_HOLE_BOSS_FEATURE"] == "HOLE")
                    {
                        C2_CNC_CODE.Add("G114 Z" + Application.Current.Properties["WKS_C_4_POINT_HOLE_BOSS_Z1"]);
                        C2_CNC_CODE.Add("CALL OO10 PMOD=7 PDI=" + Application.Current.Properties["WKS_C_4_POINT_HOLE_BOSS_D"]);
                        C2_CNC_CODE.Add("G0 Z500");
                        C2_CNC_CODE.Add("VC51 = VS29");
                        C2_CNC_CODE.Add("VC52 = VS28");
                        C2_CNC_CODE.Add("VC53=ATAN2[VC59,VC58]");
                        C2_CNC_CODE.Add("VC54 = ATAN2[VC52, VC51]");
                        C2_CNC_CODE.Add("VC55 = VC54 - VC53");
                        C2_CNC_CODE.Add("VZOFC[1] = VZOFC[1] - VC55");
                        C2_CNC_CODE.Add("VC56 = SQR[[VC58 - VC51] *[VC58 - VC51] +[VC59 - VC52] *[VC59 - VC52]");
                        C2_CNC_CODE.Add("IF[VC56 GT + 0.005]NSTAR");


                    }
                    else
                    {
                        float ISLAND_HEIGHT;
                        float Z_POSITION;
                        float.TryParse(Application.Current.Properties["WKS_C_4_POINT_HOLE_BOSS_HEIGHT"].ToString(), out ISLAND_HEIGHT);
                        float.TryParse(Application.Current.Properties["WKS_C_4_POINT_HOLE_BOSS_Z1"].ToString(), out Z_POSITION);
                        float Z_SAFE = Z_POSITION + ISLAND_HEIGHT;
                        float Z_DEPTH = ISLAND_HEIGHT;

                        C2_CNC_CODE.Add("G114 Z" + Z_SAFE);
                        C2_CNC_CODE.Add("CALL OO10 PMOD=6 PDI=" + Application.Current.Properties["WKS_C_4_POINT_HOLE_BOSS_D"] + " PZIN=" + Z_DEPTH);
                        C2_CNC_CODE.Add("G0 Z500");
                        C2_CNC_CODE.Add("VC51 = VS29");
                        C2_CNC_CODE.Add("VC52 = VS28");
                        C2_CNC_CODE.Add("VC53=ATAN2[VC59,VC58]");
                        C2_CNC_CODE.Add("VC54 = ATAN2[VC52, VC51]");
                        C2_CNC_CODE.Add("VC55 = VC54 - VC53");
                        C2_CNC_CODE.Add("VZOFC[1] = VZOFC[1] - VC55");
                        C2_CNC_CODE.Add("VC56 = SQR[[VC58 - VC51] *[VC58 - VC51] +[VC59 - VC52] *[VC59 - VC52]");
                        C2_CNC_CODE.Add("IF[VC56 GT + 0.005]NSTAR");

                    }
                    break;

//C POCKET / ISLAND MEASUREMENT
                case "POCKET MEASUREMENT":
                    C1_CNC_CODE.Add("(*** C TOP POCKET / ISLAND MEASUREMENT ***)");
                    probe_call = 1;
                    C1_CNC_CODE.Add("NSTAR G15 H1 A0 C0");

                    if (Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_AXIS"] == "X")
                    {


                        float X1_PROBING_POINT;
                        float.TryParse(Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_X1"].ToString(), out X1_PROBING_POINT);
                        float X2_PROBING_POINT;
                        float.TryParse(Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_X2"].ToString(), out X2_PROBING_POINT);
                        float X_DISTANCE = Math.Abs(X1_PROBING_POINT - X2_PROBING_POINT);


                        float Z1_PROBING_POINT;
                        float.TryParse(Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_Z1"].ToString(), out Z1_PROBING_POINT);
                        float Z2_PROBING_POINT;
                        float.TryParse(Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_Z2"].ToString(), out Z2_PROBING_POINT);
                        float HEIGHT;
                        float.TryParse(Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_HEIGHT"].ToString(), out HEIGHT);
                        float Z1_SAFE = Z1_PROBING_POINT + HEIGHT;
                        float Z2_SAFE = Z2_PROBING_POINT + HEIGHT;

                        C2_CNC_CODE.Add("G114 X" + Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_X1"] + " Y" + Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_Y1"]);
                        if (Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_FEATURE"] == "POCKET")
                        {
                            C2_CNC_CODE.Add("G114 Z" + Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_Z1"]);
                            C2_CNC_CODE.Add("CALL OO10 PMOD=12 PELI=" + Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_WIDTH"]);
                        }
                        if (Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_FEATURE"] == "ISLAND")
                        {
                            C2_CNC_CODE.Add("G114 Z" + Z1_SAFE);
                            C2_CNC_CODE.Add("CALL OO10 PMOD=12 PELI=" + Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_WIDTH"] +
                             " PZIN=" + Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_HEIGHT"]);
                        }
                        C2_CNC_CODE.Add("G0 Z500");
                        C2_CNC_CODE.Add("VC51 = VS29");
                        C2_CNC_CODE.Add("G114 X" + Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_X2"] + " Y" + Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_Y1"]);
                        if (Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_FEATURE"] == "POCKET")
                        {
                            C2_CNC_CODE.Add("G114 Z" + Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_Z2"]);
                            C2_CNC_CODE.Add("CALL OO10 PMOD=12 PELI=" + Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_WIDTH"]);
                        }
                        if (Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_FEATURE"] == "ISLAND")
                        {
                            C2_CNC_CODE.Add("G114 Z" + Z2_SAFE);
                            C2_CNC_CODE.Add("CALL OO10 PMOD=12 PELI=" + Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_WIDTH"] +
                             " PZIN=" + Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_HEIGHT"]);
                        }
                       
                        C2_CNC_CODE.Add("G0 Z500");
                        C2_CNC_CODE.Add("VC52 = VS29");
                        C2_CNC_CODE.Add("VC53 = ABS[VC51 - VC52]");
                        C2_CNC_CODE.Add("VC54 = ATAN[VC53 / " + X_DISTANCE + "]");
                        C2_CNC_CODE.Add("IF[VC52 GT VC51]NMOD");
                        C2_CNC_CODE.Add("C = VC54 M115");
                        C2_CNC_CODE.Add("GOTO NUL");
                        C2_CNC_CODE.Add("NMOD C = -VC54 M116");
                        C2_CNC_CODE.Add("NUL VZOFC[1] = VRCOC - VMOFC");
                        C2_CNC_CODE.Add("IF[VC3 GT 0.005]NSTAR");

                    }
                    else
                    {
                        float Y1_PROBING_POINT;
                        float.TryParse(Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_Y1"].ToString(), out Y1_PROBING_POINT);
                        float Y2_PROBING_POINT;
                        float.TryParse(Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_Y2"].ToString(), out Y2_PROBING_POINT);
                        float Y_DISTANCE = Math.Abs(Y1_PROBING_POINT - Y2_PROBING_POINT);

                        float Z1_PROBING_POINT;
                        float.TryParse(Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_Z1"].ToString(), out Z1_PROBING_POINT);
                        float Z2_PROBING_POINT;
                        float.TryParse(Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_Z2"].ToString(), out Z2_PROBING_POINT);
                        float HEIGHT;
                        float.TryParse(Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_HEIGHT"].ToString(), out HEIGHT);
                        float Z1_SAFE = Z1_PROBING_POINT + HEIGHT;
                        float Z2_SAFE = Z2_PROBING_POINT + HEIGHT;

                        C2_CNC_CODE.Add("G114 X" + Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_X1"] + " Y" + Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_Y1"]);
                        if (Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_FEATURE"] == "POCKET")
                        {
                            C2_CNC_CODE.Add("G114 Z" + Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_Z1"]);
                            C2_CNC_CODE.Add("CALL OO10 PMOD=12 PELI=" + Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_WIDTH"]);
                        }
                        if (Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_FEATURE"] == "ISLAND")
                        {
                            C2_CNC_CODE.Add("G114 Z" + Z1_SAFE);
                            C2_CNC_CODE.Add("CALL OO10 PMOD=12 PELI=" + Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_WIDTH"] +
                             " PZIN=" + Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_HEIGHT"]);
                        }
                        C2_CNC_CODE.Add("G0 Z500");
                        C2_CNC_CODE.Add("VC51 = VS29");
                        C2_CNC_CODE.Add("G114 X" + Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_X1"] + " Y" + Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_Y2"]);
                        if (Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_FEATURE"] == "POCKET")
                        {
                            C2_CNC_CODE.Add("G114 Z" + Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_Z2"]);
                            C2_CNC_CODE.Add("CALL OO10 PMOD=12 PELI=" + Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_WIDTH"]);
                        }
                        if (Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_FEATURE"] == "ISLAND")
                        {
                            C2_CNC_CODE.Add("G114 Z" + Z2_SAFE);
                            C2_CNC_CODE.Add("CALL OO10 PMOD=12 PELI=" + Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_WIDTH"] +
                             " PZIN=" + Application.Current.Properties["WKS_C_4_POINT_POCKET_ISLAND_HEIGHT"]);
                        }
                        C2_CNC_CODE.Add("G0 Z500");
                        C2_CNC_CODE.Add("VC52 = VS29");
                        C2_CNC_CODE.Add("VC53 = ABS[VC51 - VC52]");
                        C2_CNC_CODE.Add("VC54 = ATAN[VC53 / " + Y_DISTANCE + "]");
                        C2_CNC_CODE.Add("IF[VC52 GT VC51]NMOD");
                        C2_CNC_CODE.Add("C = VC54 M115");
                        C2_CNC_CODE.Add("GOTO NUL");
                        C2_CNC_CODE.Add("NMOD C = -VC54 M116");
                        C2_CNC_CODE.Add("NUL VZOFC[1] = VRCOC - VMOFC");
                        C2_CNC_CODE.Add("IF[VC3 GT 0.005]NSTAR");
                    }

                    break;
//90DEG HOLE MEASUREMENT
                case "90DEG HOLE MEASUREMENT":
                    C1_CNC_CODE.Add("(*** C SIDE HOLE / BOSS MEASUREMENT ***)");
                    probe_call = 1;
                    C1_CNC_CODE.Add("NSTAR G15 H1 A0 C0");
                    C2_CNC_CODE.Add("CALL OO88 PX=0 PY=0 PZ=0 PA="+
                      Application.Current.Properties["WKS_C_A_90_4_POINT_HOLE_BOSS_A"] + " PC="+
                      Application.Current.Properties["WKS_C_A_90_4_POINT_HOLE_BOSS_C"]  + " PH=1 PP=2");
                   
                    C2_CNC_CODE.Add("G114 X"+ Application.Current.Properties["WKS_C_A_90_4_POINT_HOLE_BOSS_X"]+
                        " Y"+ Application.Current.Properties["WKS_C_A_90_4_POINT_HOLE_BOSS_Y"]);
                    C2_CNC_CODE.Add("G15 H2");
                    C2_CNC_CODE.Add("G114 A" + Application.Current.Properties["WKS_C_A_90_4_POINT_HOLE_BOSS_A"] +
                        " C" + Application.Current.Properties["WKS_C_A_90_4_POINT_HOLE_BOSS_C"]);

                    if (Application.Current.Properties["WKS_C_A_90_4_POINT_HOLE_BOSS_FEATURE"] == "HOLE")
                    {
                        C2_CNC_CODE.Add("G114 Z" + Application.Current.Properties["WKS_C_A_90_4_POINT_HOLE_BOSS_Z"]);
                        C2_CNC_CODE.Add("CALL OO10 PMOD=7 PDI=" + Application.Current.Properties["WKS_C_A_90_4_POINT_HOLE_BOSS_D"]);
                        C2_CNC_CODE.Add("G0 Z500");
                        C2_CNC_CODE.Add("VC51 = VS29");
                        C2_CNC_CODE.Add("VC53 = ABS[VC51]");
                        C2_CNC_CODE.Add("VC54 = ATAN[VC53 /" + Application.Current.Properties["WKS_C_A_90_4_POINT_HOLE_BOSS_Z"] + "]");
                        C2_CNC_CODE.Add("IF[VC51 GT 0]NMOD");
                        C2_CNC_CODE.Add("M115 C=ABS[VC54]+" + Application.Current.Properties["WKS_C_A_90_4_POINT_HOLE_BOSS_C"]);
                        C2_CNC_CODE.Add("GOTO NUL");
                        C2_CNC_CODE.Add("NMOD M116 C=-VC54+" + Application.Current.Properties["WKS_C_A_90_4_POINT_HOLE_BOSS_C"]);
                        C2_CNC_CODE.Add("NUL VZOFC[1]=VRCOC-[VMOFC+" + Application.Current.Properties["WKS_C_A_90_4_POINT_HOLE_BOSS_C"] + "]");
                        C2_CNC_CODE.Add("IF[VC53 GT 0.005]NSTAR");
                        C2_CNC_CODE.Add("NSLUT G15 H1 A0 C0");


                    }
                    else
                    {
                        float ISLAND_HEIGHT;
                        float Z_POSITION;
                        float.TryParse(Application.Current.Properties["WKS_C_A_90_4_POINT_HOLE_BOSS_FEATURE_HEIGHT"].ToString(), out ISLAND_HEIGHT);
                        float.TryParse(Application.Current.Properties["WKS_C_A_90_4_POINT_HOLE_BOSS_Z"].ToString(), out Z_POSITION);
                        float Z_SAFE = Z_POSITION + ISLAND_HEIGHT;
                        float Z_DEPTH = ISLAND_HEIGHT;

                        C2_CNC_CODE.Add("G114 Z" + Z_SAFE);
                        C2_CNC_CODE.Add("CALL OO10 PMOD=6 PDI=" + Application.Current.Properties["WKS_C_A_90_4_POINT_HOLE_BOSS_D"]+
                            " PZIN="+ Z_DEPTH);
                        C2_CNC_CODE.Add("G0 Z500");
                        C2_CNC_CODE.Add("VC51 = VS29");
                        C2_CNC_CODE.Add("VC53 = ABS[VC51]");
                        C2_CNC_CODE.Add("VC54 = ATAN[VC53 /" + Application.Current.Properties["WKS_C_A_90_4_POINT_HOLE_BOSS_Z"] + "]");
                        C2_CNC_CODE.Add("IF[VC51 GT 0]NMOD");
                        C2_CNC_CODE.Add("M115 C=ABS[VC54]+" + Application.Current.Properties["WKS_C_A_90_4_POINT_HOLE_BOSS_C"]);
                        C2_CNC_CODE.Add("GOTO NUL");
                        C2_CNC_CODE.Add("NMOD M116 C=-VC54+" + Application.Current.Properties["WKS_C_A_90_4_POINT_HOLE_BOSS_C"]);
                        C2_CNC_CODE.Add("NUL VZOFC[1]=VRCOC-[VMOFC+" + Application.Current.Properties["WKS_C_A_90_4_POINT_HOLE_BOSS_C"] + "]");
                        C2_CNC_CODE.Add("IF[VC53 GT 0.005]NSTAR");
                        C2_CNC_CODE.Add("NSLUT G15 H1 A0 C0");

                    }
                    break;
                //90DEG pocket  MEASUREMENT
                case "90DEG POCKET MEASUREMENT":
                    C1_CNC_CODE.Add("(*** C SIDE POCKET / ISLAND MEASUREMENT ***)" +
                        "");
                    probe_call = 1;
                    C1_CNC_CODE.Add("NSTAR G15 H1 A0 C0");
                    C2_CNC_CODE.Add("CALL OO88 PX=0 PY=0 PZ=0 PA=" +
                      Application.Current.Properties["WKS_C_A-90_4_POINT_SLOT_ISLAND_A"] + " PC=" +
                      Application.Current.Properties["WKS_C_A-90_4_POINT_SLOT_ISLAND_C"] + " PH=1 PP=2");

                    C2_CNC_CODE.Add("G114 X" + Application.Current.Properties["WKS_C_A-90_4_POINT_SLOT_ISLAND_X"] +
                        " Y" + Application.Current.Properties["WKS_C_A-90_4_POINT_SLOT_ISLAND_Y"]);
                    C2_CNC_CODE.Add("G15 H2");
                    C2_CNC_CODE.Add("G114 A" + Application.Current.Properties["WKS_C_A-90_4_POINT_SLOT_ISLAND_A"] +
                        " C" + Application.Current.Properties["WKS_C_A-90_4_POINT_SLOT_ISLAND_C"]);

                    if (Application.Current.Properties["WKS_C_A-90_4_POINT_SLOT_ISLAND_FEATURE"] == "HOLE")
                    {
                        C2_CNC_CODE.Add("G114 Z" + Application.Current.Properties["WKS_C_A-90_4_POINT_SLOT_ISLAND_Z"]);
                        C2_CNC_CODE.Add("CALL OO10 PMOD=11 PELI=" + Application.Current.Properties["WKS_C_A-90_4_POINT_SLOT_ISLAND_D"]);
                        C2_CNC_CODE.Add("G0 Z500");
                        C2_CNC_CODE.Add("VC51 = VS29");
                        C2_CNC_CODE.Add("VC53 = ABS[VC51]");
                        C2_CNC_CODE.Add("VC54 = ATAN[VC53 /" + Application.Current.Properties["WKS_C_A-90_4_POINT_SLOT_ISLAND_Z"] + "]");
                        C2_CNC_CODE.Add("IF[VC51 GT 0]NMOD");
                        C2_CNC_CODE.Add("M115 C=ABS[VC54]+" + Application.Current.Properties["WKS_C_A-90_4_POINT_SLOT_ISLAND_C"]);
                        C2_CNC_CODE.Add("GOTO NUL");
                        C2_CNC_CODE.Add("NMOD M116 C=-VC54+" + Application.Current.Properties["WKS_C_A-90_4_POINT_SLOT_ISLAND_C"]);
                        C2_CNC_CODE.Add("NUL VZOFC[1]=VRCOC-[VMOFC+" + Application.Current.Properties["WKS_C_A-90_4_POINT_SLOT_ISLAND_C"] + "]");
                        C2_CNC_CODE.Add("IF[VC53 GT 0.005]NSTAR");
                        C2_CNC_CODE.Add("NSLUT G15 H1 A0 C0");


                    }
                    else
                    {
                        float ISLAND_HEIGHT;
                        float Z_POSITION;
                        float.TryParse(Application.Current.Properties["WKS_C_A-90_4_POINT_SLOT_ISLAND_FEATURE_HEIGHT"].ToString(), out ISLAND_HEIGHT);
                        float.TryParse(Application.Current.Properties["WKS_C_A-90_4_POINT_SLOT_ISLAND_Z"].ToString(), out Z_POSITION);
                        float Z_SAFE = Z_POSITION + ISLAND_HEIGHT;
                        float Z_DEPTH = ISLAND_HEIGHT;

                        C2_CNC_CODE.Add("G114 Z" + Z_SAFE);
                        C2_CNC_CODE.Add("CALL OO10 PMOD=1 PELI=" + Application.Current.Properties["WKS_C_A-90_4_POINT_SLOT_ISLAND_D"] +
                            " PZIN=" + Z_DEPTH);
                        C2_CNC_CODE.Add("G0 Z500");
                        C2_CNC_CODE.Add("VC51 = VS29");
                        C2_CNC_CODE.Add("VC53 = ABS[VC51]");
                        C2_CNC_CODE.Add("VC54 = ATAN[VC53 /" + Application.Current.Properties["WKS_C_A-90_4_POINT_SLOT_ISLAND_Z"] + "]");
                        C2_CNC_CODE.Add("IF[VC51 GT 0]NMOD");
                        C2_CNC_CODE.Add("M115 C=ABS[VC54]+" + Application.Current.Properties["WKS_C_A-90_4_POINT_SLOT_ISLAND_C"]);
                        C2_CNC_CODE.Add("GOTO NUL");
                        C2_CNC_CODE.Add("NMOD M116 C=-VC54+" + Application.Current.Properties["WKS_C_A-90_4_POINT_SLOT_ISLAND_C"]);
                        C2_CNC_CODE.Add("NUL VZOFC[1]=VRCOC-[VMOFC+" + Application.Current.Properties["WKS_C_A-90_4_POINT_SLOT_ISLAND_C"] + "]");
                        C2_CNC_CODE.Add("IF[VC53 GT 0.005]NSTAR");
                        C2_CNC_CODE.Add("NSLUT G15 H1 A0 C0");

                    }
                    break;

                default:
                    break;
            }



                    if (error==0)
            {
                var message = string.Join(Environment.NewLine, lines.ToArray());
               
                

                string message2;
                message2 = "";

                if (probe_call == 1)
                {
                    message2 = string.Join(Environment.NewLine, PROBE_START_CNC_CODE.ToArray());
                } 


                if (Application.Current.Properties["WKS_C_METHOD"] != "NO MEASUREMENT")
                {
                    var messageC1 = string.Join(Environment.NewLine, C1_CNC_CODE.ToArray());
                    var messageC2 = string.Join(Environment.NewLine, C2_CNC_CODE.ToArray());


                    if (Application.Current.Properties["WKS_X_METHOD"] != "NO MEASUREMENT")
                    {
                        if (Application.Current.Properties["WKS_Y_METHOD"] != "NO MEASUREMENT")
                        {
                            message2 = message2 + Environment.NewLine;
                            message2 = message2 + messageC1;

                            if (Application.Current.Properties["WKS_Y_4_POINT_POCKET_SAME_AS_X_CHECKED"] == "1" &&
                                Application.Current.Properties["WKS_X_METHOD"] == "HOLE MEASUREMENT" &&
                                 Application.Current.Properties["WKS_Y_METHOD"] == "HOLE MEASUREMENT")
                            {
                                var messageY = string.Join(Environment.NewLine, Y_CNC_CODE.ToArray());
                                message2 = message2 + Environment.NewLine;
                                message2 = message2 + messageY;

                            }
                            else
                            {
                                var messageX = string.Join(Environment.NewLine, X_CNC_CODE.ToArray());
                                message2 = message2 + Environment.NewLine;
                                message2 = message2 + messageX;
                                var messageY = string.Join(Environment.NewLine, Y_CNC_CODE.ToArray());
                                message2 = message2 + Environment.NewLine;
                                message2 = message2 + messageY;
                            }
                            message2 = message2 + Environment.NewLine;
                            message2 = message2 + messageC2;

                        }
                        else
                        {
                            message2 = message2 + Environment.NewLine;
                            message2 = "( *** ERROR: Y MEASUREMENT NEED TO BE SPECIFIED TO MEASURE C AXIS *** )";
                        }
                    }
                    else
                    {
                        message2 = message2 + Environment.NewLine;
                        message2 = "( *** ERROR: X MEASUREMENT NEED TO BE SPECIFIED TO MEASURE C AXIS *** )";
                    }
                }

                else
                {
                    if (Application.Current.Properties["WKS_X_METHOD"] != "NO MEASUREMENT")
                    {
                        if (Application.Current.Properties["WKS_Y_METHOD"] != "NO MEASUREMENT")
                        {

                            if (Application.Current.Properties["WKS_Y_4_POINT_POCKET_SAME_AS_X_CHECKED"] == "1" &&
                                Application.Current.Properties["WKS_X_METHOD"] == "HOLE MEASUREMENT" &&
                                 Application.Current.Properties["WKS_Y_METHOD"] == "HOLE MEASUREMENT")
                            {
                                var messageY = string.Join(Environment.NewLine, Y_CNC_CODE.ToArray());
                                message2 = message2 + Environment.NewLine;
                                message2 = message2 + messageY;

                            }
                            else
                            {
                                var messageX = string.Join(Environment.NewLine, X_CNC_CODE.ToArray());
                                message2 = message2 + Environment.NewLine;
                                message2 = message2 + messageX;
                                var messageY = string.Join(Environment.NewLine, Y_CNC_CODE.ToArray());
                                message2 = message2 + Environment.NewLine;
                                message2 = message2 + messageY;
                            }


                        }
                        else
                        {
                            var messageX = string.Join(Environment.NewLine, X_CNC_CODE.ToArray());
                            message2 = message2 + Environment.NewLine;
                            message2 = message2 + messageX;
                        }

                    }
                    else
                    {
                        if (Application.Current.Properties["WKS_Y_METHOD"] != "NO MEASUREMENT")
                        {
                            var messageY = string.Join(Environment.NewLine, Y_CNC_CODE.ToArray());
                            message2 = message2 + Environment.NewLine;
                            message2 = message2 + messageY;
                        }
                    }
                }
                    if (Application.Current.Properties["WKS_Z_METHOD"] != "NO MEASUREMENT")
                    {
                        var messageZ = string.Join(Environment.NewLine, Z_CNC_CODE.ToArray());
                    message2 = message2 + Environment.NewLine;
                    message2 = message2 + messageZ;
                    }

                if (probe_call == 1)
                {
                    var MessageProbeEnd = string.Join(Environment.NewLine, PROBE_END_CNC_CODE.ToArray());
                    message2 = message2 + Environment.NewLine;
                    message2 = message2 + MessageProbeEnd;
                }
             //   MessageBox.Show(message);
            //    MessageBox.Show(message2);
                output.Text = message + Environment.NewLine+ message2;
            }

                
            }
            
     
     





        private void VZOFX_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(VZOFX.Text, VZOFX);
            Application.Current.Properties["WKS_VZOFX"] = VZOFX.Text;
        }
        private void VZOFY_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(VZOFY.Text, VZOFY);
            Application.Current.Properties["WKS_VZOFY"] = VZOFY.Text;
        }
        private void VZOFZ_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(VZOFZ.Text, VZOFZ);
            Application.Current.Properties["WKS_VZOFZ"] = VZOFZ.Text;
        }
        private void VZOFC_LostFocus(object sender, RoutedEventArgs e)
        {
            IsNumericCheck(VZOFC.Text, VZOFC);
            Application.Current.Properties["WKS_VZOFC"] = VZOFC.Text;
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

        private void WKS_SETUP_Z_SELECTION_CHANGED(object sender, SelectionChangedEventArgs e)
        {

            var selected_combobox_item = sender as ComboBox;
            string name = selected_combobox_item.SelectedItem as string;
            string number = selected_combobox_item.SelectedValue as string;
            int index = selected_combobox_item.SelectedIndex;


        

            switch (index)
            {
                case 0:
                    WKS_SETUP_Z_FRAME.Content = new WKS_Z_NO_MEASUREMENT();
                    Application.Current.Properties["WKS_Z_METHOD"] = "NO MEASUREMENT";
                    break;
                case 1:
                    WKS_SETUP_Z_FRAME.Content = new WKS_Z_1_POINT_TOP();
                    Application.Current.Properties["WKS_Z_METHOD"] = "ONE POINT TOP MEASUREMENT";
                    break;
                case 2:
                    WKS_SETUP_Z_FRAME.Content = new WKS_Z_4_POINT_TOP();
                    Application.Current.Properties["WKS_Z_METHOD"] = "FOUR POINT TOP MEASUREMENT";
                    break;
                case 3:
                    WKS_SETUP_Z_FRAME.Content = new WKS_Z_1_POINT_BOTTOM();
                    Application.Current.Properties["WKS_Z_METHOD"] = "ONE POINT BOTTOM MEASUREMENT";
                    break;
                case 4:
                    WKS_SETUP_Z_FRAME.Content = new WKS_Z_4_POINT_BOTTOM();
                    Application.Current.Properties["WKS_Z_METHOD"] = "FOUR POINT BOTTOM MEASUREMENT";
                    break;
                default:
                    break;
            }
        }

      

        private void WKS_SETUP_X_SELECTION_CHANGED(object sender, SelectionChangedEventArgs e)
        {

            var selected_combobox_item = sender as ComboBox;
            string name = selected_combobox_item.SelectedItem as string;
            string number = selected_combobox_item.SelectedValue as string;
            int index = selected_combobox_item.SelectedIndex;




            switch (index)
            {
                case 0:
                    WKS_SETUP_X_FRAME.Content = new WKS_X_NO_MEASUREMENT();
                    Application.Current.Properties["WKS_X_METHOD"] = "NO MEASUREMENT";
                    break;
                case 1:
                    WKS_SETUP_X_FRAME.Content = new WKS_X_1_POINT_WALL();
                    Application.Current.Properties["WKS_X_METHOD"] = "WALL MEASUREMENT";
                    break;
                case 2:
                    WKS_SETUP_X_FRAME.Content = new WKS_X_2_POINT_POCKET();
                    Application.Current.Properties["WKS_X_METHOD"] = "POCKET MEASUREMENT";
                    break;
                case 3:
                    WKS_SETUP_X_FRAME.Content = new WKS_X_4_POINTS_HOLE();
                    Application.Current.Properties["WKS_X_METHOD"] = "HOLE MEASUREMENT";
                    break;
                default:
                    break;
            }
        }



        private void WKS_SETUP_Y_SELECTION_CHANGED(object sender, SelectionChangedEventArgs e)
        {

            var selected_combobox_item = sender as ComboBox;
            string name = selected_combobox_item.SelectedItem as string;
            string number = selected_combobox_item.SelectedValue as string;
            int index = selected_combobox_item.SelectedIndex;




            switch (index)
            {
                case 0:
                    WKS_SETUP_Y_FRAME.Content = new WKS_Y_NO_MEASUREMENT();
                    Application.Current.Properties["WKS_Y_METHOD"] = "NO MEASUREMENT";
                    break;
                case 1:
                    WKS_SETUP_Y_FRAME.Content = new WKS_Y_1_POINT_WALL();
                    Application.Current.Properties["WKS_Y_METHOD"] = "WALL MEASUREMENT";
                    break;
                case 2:
                    WKS_SETUP_Y_FRAME.Content = new WKS_Y_2_POINT_POCKET();
                    Application.Current.Properties["WKS_Y_METHOD"] = "POCKET MEASUREMENT";
                    break;
                case 3:
                    WKS_SETUP_Y_FRAME.Content = new WKS_Y_4_POINTS_HOLE();
                    Application.Current.Properties["WKS_Y_METHOD"] = "HOLE MEASUREMENT";
                    break;
                default:
                    break;
            }
        }

        private void WKS_SETUP_C_SELECTION_CHANGED(object sender, SelectionChangedEventArgs e)
        {

            var selected_combobox_item = sender as ComboBox;
            string name = selected_combobox_item.SelectedItem as string;
            string number = selected_combobox_item.SelectedValue as string;
            int index = selected_combobox_item.SelectedIndex;




            switch (index)
            {
                case 0:
                    WKS_SETUP_C_FRAME.Content = new WKS_C_NO_MEASUREMENT();
                    Application.Current.Properties["WKS_C_METHOD"] = "NO MEASUREMENT";
                    break;
                case 1:
                    WKS_SETUP_C_FRAME.Content = new WKS_C_2_POINT_WALL();
                    Application.Current.Properties["WKS_C_METHOD"] = "WALL MEASUREMENT";
                    break;
                case 2:
                    WKS_SETUP_C_FRAME.Content = new WKS_C_4_POINT_HOLE_BOSS();
                    Application.Current.Properties["WKS_C_METHOD"] = "HOLE MEASUREMENT";
                    break;
                case 3:
                    WKS_SETUP_C_FRAME.Content = new WKS_C_4_POINT_SLOT_ISLAND();
                    Application.Current.Properties["WKS_C_METHOD"] = "POCKET MEASUREMENT";
                    break;
                case 4:
                    WKS_SETUP_C_FRAME.Content = new WKS_C_A_90_4_POINT_HOLE_BOSS();
                    Application.Current.Properties["WKS_C_METHOD"] = "90DEG HOLE MEASUREMENT";
                    break;
                case 5:
                    WKS_SETUP_C_FRAME.Content = new WKS_C_A_90_4_POINT_SLOT_ISLAND();
                    Application.Current.Properties["WKS_C_METHOD"] = "90DEG POCKET MEASUREMENT";
                    break;
                case 6:
                    WKS_SETUP_C_FRAME.Content = new WKS_C_8_POINT_HOLE_BOSS();
                    Application.Current.Properties["WKS_C_METHOD"] = "8 POINT MEASUREMENT";
                    break;
                default:
                    break;
            }
        }

    }
}
