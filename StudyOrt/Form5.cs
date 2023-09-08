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
    public partial class Form5 : Form
    {
        string curso;

        public Form5(string palabra)
        {
            InitializeComponent();

            curso = palabra; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            F3.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            LblAño.Text = curso;
        }
    }
}
