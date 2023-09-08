using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyOrt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                Form3 F3 = new Form3();
                F3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(" La contraseña es incorrecta ");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnCrearCuenta_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.Show();
            this.Hide();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void TxtBxDni_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
