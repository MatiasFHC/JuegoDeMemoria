using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormReglas form = new FormReglas();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormReglas2 form = new FormReglas2();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormReglas3 form = new FormReglas3();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormReglas4 form = new FormReglas4();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormReglas5 form = new FormReglas5();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormReglas6 form = new FormReglas6();
            form.Show();
        }
    }
}
