using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SteamIDtoolV3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            button2.Visible = false;
            button3.Visible = false;
  
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            button2.Visible = true;
            button1.Enabled = false;
            button3.Visible = true;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var process = Process.Start("id.bat");
            process.WaitForExit();
            richTextBox1.Text = File.ReadAllText("log.txt");
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (new FileInfo("gensteamid.txt").Length == 0)
            {
                MessageBox.Show("Installation aborted! No data found! Have you installed Steam on this machine? (PORTABLE NOT SUPPORTED) Please report bug @ github");
            }
            else
            {
                Form4 myForm4 = new Form4();
                this.Hide();
                myForm4.ShowDialog();
                this.Close();
                

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Please go back to the facepunch thread and make a reply there, or go to the github(links on facepunch thread");
        }
    }
}