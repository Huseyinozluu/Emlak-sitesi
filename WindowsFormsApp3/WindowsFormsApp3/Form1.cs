using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Form2 frm2 = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
            frm2.Show();
        }

        Form3 frm3 = new Form3();
        private void button2_Click(object sender, EventArgs e)
        {
            frm3.Show();
        }

        Form4 frm4 = new Form4();
        private void button3_Click(object sender, EventArgs e)
        {
            frm4.Show();
        }
        Form5 frm5 = new Form5();
        private void button4_Click(object sender, EventArgs e)
        {
            frm5.Show();
        }
        Form6 frm6 = new Form6();
        private void button5_Click(object sender, EventArgs e)
        {
            frm6.Show();
        }
        Form7 frm7 = new Form7();
        private void button6_Click(object sender, EventArgs e)
        {
            frm7.Show();
        }
    }
}
