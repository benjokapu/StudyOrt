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


namespace StudyOrt
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public string USUARIO;

        public const string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = .\\StudyOrtDB.accdb;Persist Security Info=False;";

        OleDbConnection con = new OleDbConnection(connString);
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataSet ds;
        


        private void Form4_Load(object sender, EventArgs e)
        {
            nameSurname.Text = "";
            dni.Text = "";


            if (USUARIO != null)
            {
                string cmdSQL = "SELECT Nombre, Apellido FROM Users WHERE DNI = " + USUARIO;
                cmd = new OleDbCommand(cmdSQL, con);
                da = new OleDbDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "User");
                string nombre = ds.Tables["User"].Rows[0][0].ToString();
                string apellido = ds.Tables["User"].Rows[0][1].ToString();

                nameSurname.Text = nombre + " " + apellido;
                dni.Text = USUARIO;
            }
            else
            {
                nameSurname.Text = "Usuario Deesconocido";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 F5 = new Form5("");
            F5.USUARIO = USUARIO;
            F5.Show();
            this.Hide();
        }
    }
}
