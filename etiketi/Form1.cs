using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace etiketi
{
    public partial class Form1 : Form
    {
        int a;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            a = r.Next(1, 50);
            label2.Text = a.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double S, P;
            S = Math.PI * a * a;
            P = 2 * Math.PI * a;
            MessageBox.Show("Krug s radius:" + a + "cm" + " Lice:" + Math.Round(S, 2) + "kv.cm" + " Obikolka:" + Math.Round(P, 2) + "cm");
        }
    }
}
