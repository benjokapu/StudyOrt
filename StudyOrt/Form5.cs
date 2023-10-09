using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudyOrt
{
    public partial class Form5 : Form
    {
        public string USUARIO;

        string curso;


        public const string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = .\\StudyOrtDB.accdb;Persist Security Info=False;";

        OleDbConnection con = new OleDbConnection(connString);
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataSet ds;


        public Form5(string palabra)
        {
            InitializeComponent();

            curso = palabra;
        }

        

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            F3.USUARIO = USUARIO;
            F3.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            LblAño.Text = curso;

            if (USUARIO != null)
            {
                string cmdSQL = "SELECT Nombre, Apellido FROM Users WHERE DNI = " + USUARIO;
                cmd = new OleDbCommand(cmdSQL, con);
                da = new OleDbDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "User");
                string nombre = ds.Tables["User"].Rows[0][0].ToString();
                string apellido = ds.Tables["User"].Rows[0][1].ToString();

                label1.Text = nombre + " " + apellido;
            }
            else
            {
                label1.Text = "Usuario Deesconocido";
            }
            

            

        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PanelMenu.Visible = true;
        }

        private void BtnSubir_Click(object sender, EventArgs e)
        {
            Form6 F6 = new Form6();
            F6.USUARIO = USUARIO;
            F6.Show();
            this.Hide();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            USUARIO = string.Empty;
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void BtnPerfil_Click(object sender, EventArgs e)
        {
            Form4 F4 = new Form4();
            F4.Show();
            this.Hide();
        }
    }
}
