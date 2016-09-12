using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamIDtoolV3
{
    public partial class Installation : Form
    {
        public Installation()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            button2.Visible = !button2.Visible;

            checkBox1.Visible = false;
            label2.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkBox1.Visible = true;
            button1.Enabled = false;
            label2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            button2.Enabled = false;

            Form3 myForm3 = new Form3();
            this.Hide();
            myForm3.ShowDialog();
            this.Close();

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button2.Enabled = false;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button2.Visible = true;

            checkBox1.Enabled = false;
            label2.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
