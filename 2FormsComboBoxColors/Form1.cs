using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2FormsComboBoxColors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s;
            Form2 nForm = new Form2();
            s = comboBox3.Text;
            nForm.Height = int.Parse(comboBox1.Text);
            nForm.Width = int.Parse(comboBox2.SelectedItem.ToString());
            nForm.BackColor = Color.FromName(s);
            nForm.Text = comboBox4.Text;
            nForm.Show();

        }
    }
}
