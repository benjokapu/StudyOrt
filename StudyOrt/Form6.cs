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
    public partial class Form6 : Form
    {

        public const string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = .\\StudyOrtDB.accdb;Persist Security Info=False;";

        OleDbConnection con = new OleDbConnection(connString);
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataSet ds = new DataSet();

        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Algún campo esta vacío", "Subida fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                //TERMINAR
                string subir = "INSERT INTO files VALUES (" + textBox1.Text + ",'" + textBox2.Text + "',0,)";
                cmd = new OleDbCommand(subir, con);
                cmd.ExecuteNonQuery();

                con.Close();
                textBox1.Text = "";
                textBox2.Text = "";

                MessageBox.Show("Tu archivo se  subio", "Subida Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
