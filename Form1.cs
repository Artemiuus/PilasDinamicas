using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilasDinamicas
{
    public partial class Form1 : Form
    {
        PilaDin p1;
        public Form1()
        {
            InitializeComponent();
            p1 = new PilaDin();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtDts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (e.KeyChar == '\b'))
            { }
            e.Handled = true;
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            int num= int.Parse(txtDts1.Text);
            p1.Push(ref p1, num);
            p1.DesplegarPila(p1, listBox1);
            txtDts1.Clear();
            txtDts1.Focus();
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            int num = -1;
            num = p1.Pop(ref p1);
            if (num != 1)
                MessageBox.Show("DATO = " + num.ToString());
            p1.DesplegarPila(p1, listBox1 );
            
        }
    }
}
