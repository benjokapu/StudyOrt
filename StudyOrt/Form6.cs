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
using System.Net;
using System.Security.Policy;
using System.Xml.Linq;

namespace StudyOrt
{
    public partial class Form6 : Form
    {
        public string USUARIO;

        public const string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = .\\StudyOrtDB.accdb;Persist Security Info=False;";

        OleDbConnection con = new OleDbConnection(connString);
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataSet ds;

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

                DateTime fechaActual = DateTime.Now;


                con.Open();
                string subirsql = "INSERT INTO files (Nombre, ACLARACIONES, FECHA, URL, DNI, [Year], Subject) VALUES (\"{0}\",\"{1}\",\"{2}\",\"{3}\",{4},\"{5}\",\"{6}\")";
                string subir = string.Format(subirsql, textBox1.Text, textBox2.Text, fechaActual, string.Empty, USUARIO, comboBox2.Text, comboBox1.Text);

                cmd = new OleDbCommand(subir, con);
                cmd.ExecuteNonQuery();

                con.Close();
                textBox1.Text = "";
                textBox2.Text = "";

                MessageBox.Show("Tu archivo se subio", "Subida Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            //Años
            comboBox2.Items.Clear();

            string cmdExec = "SELECT * FROM Years";
            cmd = new OleDbCommand(cmdExec, con);
            da = new OleDbDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Years");

            for (int i = 0; i < ds.Tables["Years"].Rows.Count; i++)
            {
                string year = ds.Tables["Years"].Rows[i][0].ToString();

                comboBox2.Items.Add(year);
            }

            comboBox2.SelectedItem = comboBox2.Items[0];


            //Subjects
            comboBox1.Items.Clear();

            cmdExec = "SELECT * FROM subjects";
            cmd = new OleDbCommand(cmdExec, con);
            da = new OleDbDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Subjects");

            for (int i = 0; i < ds.Tables["Subjects"].Rows.Count; i++)
            {
                string year = ds.Tables["Subjects"].Rows[i][0].ToString();

                comboBox1.Items.Add(year);
            }

            comboBox1.SelectedItem = comboBox1.Items[0];



        }
    }
}
