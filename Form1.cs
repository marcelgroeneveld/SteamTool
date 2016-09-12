using System;
using System.IO;
using System.Globalization;
using AutoUpdaterDotNET;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Steamworks;
using System.Speech.Synthesis;
using System.Threading;
using SteamTool;
namespace SteamIDtoolV3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("disableprofileurl.txt"))
            {
                button2.Visible = false;
            }
            else
            {
                button2.Visible = true;
            }

            button3.BackgroundImageLayout = ImageLayout.Stretch;
            AutoUpdater.Start("http://mgroeneveld.tk/DONOTDELETEITSYOURPROGRAMMING/update.xml");

            label2.Text = "Ready.";

            //We're going to check if setup has been done before, if not we will run it
            if (File.Exists("setupcomplete.txt"))
            {
                //If user also configured a customURL, check if he did last session, if true delete that file and confirm it worked.
                if (File.Exists("tempcustomurlinstallation.txt"))
                {
                    File.Delete("tempcustomurlinstallation.txt");

                }

            }

            else
            {
                Installation myForm2 = new Installation();
                this.Hide();
                myForm2.ShowDialog();
                this.Close();
            }
        }
        private void Form1_KeyPress(object sender, KeyEventArgs e)
        {
            if ( e.Shift && e.KeyCode == Keys.S)
                MessageBox.Show("My message");
        }
        
        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hotkeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Planned for next update");
        }

        private void quickResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.Delete("setupcomplete.txt");
            Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var content = File.ReadAllText("gensteamid.txt");
            Clipboard.SetText(content);
            label2.Text = "SteamID copied to clipboard";

        }

        private void button2_Click(object sender, EventArgs e)
        {
        string contents = File.ReadAllText("useridresult.txt");

        Clipboard.SetText("http://steamcommunity.com/profiles/"+contents);
        label2.Text = "Profile URL copied to clipboard";
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SteamTool is a program that automatically gets your steam data, converts it and makes it usable to the end user. Hotkeys for buttons are still WIP");
        }

        private void contactToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Reply on facepunch thread, make a bug report, or email to marcel@mgroeneveld.tk");
        }

        private void reportABugToolStripMenuItem_Click(object sender, EventArgs e)
        {
           System.Diagnostics.Process.Start("https://github.com/PHSneaky/SteamTool/issues");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "Checking for update";
            AutoUpdater.Start("http://mgroeneveld.tk/DONOTDELETEITSYOURPROGRAMMING/update.xml");
            label2.Text = "Checked for updates.";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (File.Exists("customurl.txt"))
            {
                string customurlstring = File.ReadAllText("customurl.txt");
                Clipboard.SetText(customurlstring);
                label2.Text = "Custom URL copied to clipboard";
            }

            else

            {
                MessageBox.Show("No customURL detected, Please do not touch anything until restart!");
                Form5 myForm5 = new Form5();
                this.Hide();
                myForm5.ShowDialog();
                this.Close();



            }
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 myForm6 = new Form6();
            this.Hide();
            myForm6.ShowDialog();
            this.Close();
        }

        }
    }


