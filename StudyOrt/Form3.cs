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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void BtnPrimerAño_Click(object sender, EventArgs e)
        {
            Form5 F5 = new Form5("Primero");
            F5.Show();
            this.Hide();

        }

        private void BtnSegundoAño_Click(object sender, EventArgs e)
        {
            Form5 F5 = new Form5("Segundo");
            F5.Show();
            this.Hide();
        }
    }
}
