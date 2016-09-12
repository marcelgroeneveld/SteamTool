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

namespace SteamTool
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            if (File.Exists("disableprofileurl.txt"))
            {
                button2.Enabled = false;
            }
            else
            {

                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.Create("disableprofileurl.txt");
            button2.Enabled = false;
            button1.Enabled = true;
            Application.Restart();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            File.Delete("disableprofileurl.txt");
            button1.Enabled = false;
            button2.Enabled = true;
            Application.Restart();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.Delete("setupcomplete.txt");
            Application.Restart();
        }
    }
}
