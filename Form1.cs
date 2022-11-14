using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client; // Oracle Client Library
using System.Configuration;// To Access App Config Attributes
using System.Text.RegularExpressions;
namespace oraclecsharp
{
    public partial class Form1 : Form
    {
     //   const double interval60Minutes = 60 * 60 * 1000; // milliseconds to one hour
     //   Timer checkForTime = new Timer(interval60Minutes);
     //   checkForTime.Elapsed += new ElapsedEventHandler(checkForTime_Elapsed); //and then in your event handler
     //   checkForTime.Enabled = true;

        string linea = ""; 
        string num_maq = "";
        string track = "";
        string feeder = "";
        string selfsn = "";
        string L = "";
        string M = "";
        string T = "";
        static int _counter;
        //Combo_tablero.Enabled = false;
        //Boxtrack.Enabled = false;
        //Combo_linea.SelectedIndex = -1;

        //Object of Oracle Connection Class 
        //its constructor only takes one string parameter which is 
        //since our connection string is in app config file we need to access it using configuration
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        
       public Form1()
        {
            InitializeComponent();
          //  this.StartPosition = FormStartPosition.Manual;
         //   this.Location = new Point(250, 180);
            CreateMyStatusBar();
        }

public void CreateMyStatusBar()
{
    // Create a StatusBar control.
    StatusBar statusBar1 = new StatusBar();
    // Create two StatusBarPanel objects to display in the StatusBar.
    StatusBarPanel panel1 = new StatusBarPanel();

    // Display the first panel with a sunken border style.
    panel1.BorderStyle = StatusBarPanelBorderStyle.Sunken;
    // Initialize the text of the panel.
    panel1.Text = "yr2022";
    // Set the AutoSize property to use all remaining space on the StatusBar.
    panel1.AutoSize = StatusBarPanelAutoSize.Spring;               
    // Display panels in the StatusBar control.
    statusBar1.ShowPanels = true;
    // Add both panels to the StatusBarPanelCollection of the StatusBar.			
    statusBar1.Panels.Add(panel1);
    // Add the StatusBar to the form.
    this.Controls.Add(statusBar1);
}
        void Limpiar()
        {
            linea = "";
            num_maq = "";
            track = "";
            feeder = "";
            selfsn = "";
            L = "";
            M = "";
            T = "";
            Boxtrack.Clear();
            Boxtrack.Focus();
        }


        private void Button1_Click_1(object sender, EventArgs e)
        {
            linea = "";
            num_maq = "";
            track = "";
            feeder = "";
            selfsn = "";
            L = "";
            M = "";
            T = "";

            L = Combo_linea.Text;
            M = Combo_tablero.Text;
            T = Boxtrack.Text;
            if (L == "TOP_S01")
                L = "S01";
            else L = "ST01";
            _counter = 0;
            //DateTime fecha = Convert.ToDateTime(Admit_F);//En esta linea fue neseario convertir la cadena de text

            //this class is responsible to execute dml commands r you can say this class executes queries
            OracleCommand cmd = new OracleCommand("select line_name,location,trackrec_main,feederno,self_sn from sfism4.u_smt_msl_log_online_t where line_name='" + L + "' and location='" + M + "' and trackrec_main='" + T + "'", con);
            con.Open();
            //reads record return by the query this works with connected environment so first
            //we need to open connection
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())//it is like cursor it will triverse until the number of records gets 0
            {
                //since datareader consist of object type values we need to convert it    string NOMBRE2 = dr["NOMBRE"].ToString();
                //method to add items into listbox     listBox1.Items.Add(NOMBRE2);
                linea = dr["line_name"].ToString();
                num_maq = dr["location"].ToString();
                track = dr["trackrec_main"].ToString();
                feeder = dr["feederno"].ToString();
                selfsn = dr["self_sn"].ToString();

                txt_linea.Text = linea;
                txt_tablero.Text = num_maq;
                txt_track.Text = track;
                txt_Feeder.Text = feeder;
                txt_selfsn.Text = selfsn;

            }
            else
                    MessageBox.Show("ERROR, NO EXISTE ROLLO EN ESE FEEDER");
            Limpiar();
            con.Close();
         
        }

        private void Combo_linea_SelectedIndexChanged(object sender, EventArgs e)
        {
            Combo_tablero.Enabled = true;
            Boxtrack.Enabled = true;
            _counter = 0;
            Combo_tablero.Items.Clear(); 

            if (Combo_linea.Text == "TOP_S01")
            {
                Combo_tablero.Items.Add("1");
                Combo_tablero.Items.Add("2");
                Combo_tablero.Items.Add("3");
                Combo_tablero.Items.Add("4");
                Combo_tablero.Items.Add("5");
                Combo_tablero.Items.Add("6");
                Combo_tablero.Items.Add("7");
                Combo_tablero.Items.Add("8");
                Combo_tablero.Items.Add("9");
                Combo_tablero.Items.Add("10");
                Combo_tablero.Items.Add("11");
            }
            else
            {
                Combo_tablero.Items.Add("1");
                Combo_tablero.Items.Add("2");
                Combo_tablero.Items.Add("3");
                Combo_tablero.Items.Add("4");
                Combo_tablero.Items.Add("5");
                Combo_tablero.Items.Add("6");
            }
        }

    }
}
