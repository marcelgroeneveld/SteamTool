using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SteamTool;

namespace SteamIDtoolV3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var process2 = Process.Start("userid.bat");
            process2.WaitForExit();
            richTextBox1.Text = "http://steamcommunity.com/profiles" + File.ReadAllText("useridresult.txt");






        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            button2.Visible = true;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please go back to the facepunch thread and make a reply there, or go to the github(links on facepunch thread");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 myForm5 = new Form5();
            this.Hide();
            myForm5.ShowDialog();
            this.Close();

        }

        private void Form4_Load(object sender, EventArgs e)
        {

            button2.Visible = false;
            button3.Visible = false;
        }
    }
}
