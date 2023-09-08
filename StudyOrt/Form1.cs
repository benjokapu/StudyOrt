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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source =./mydatabase.mdb;");
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataSet ds = new DataSet();
        OleDbDataReader dr;



        private void BtnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM users WHERE DNI= '" + TxtBxDni.Text + "' and PASSWORD= '" + TxtBxContra.Text + "'";
            cmd = new OleDbCommand(login, con);
            dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Dni o Contraseña inválidos. Volvé a intentar.", "Login Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtBxDni.Text = "";
                TxtBxContra.Text = "";
                TxtBxDni.Focus();
            
            }


        }


        

        private void BtnCrearCuenta_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.Show();
            this.Hide();
        }

        

     
    }
}
