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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            button1.Visible = true;
            button1.Enabled = true;
            button1.PerformClick();
            button1.Visible = false;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            string geturl = System.IO.File.ReadAllText("useridresult.txt");
            this.webBrowser1.Navigate("http://steamcommunity.com/profiles/" + geturl);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string writetheurl = textBox1.Text;
            File.WriteAllText("customurl.txt", writetheurl);
            File.WriteAllText("tempcustomurlinstallation.txt", "Ayy, you're a curious one aren't you?");
            File.Create("setupcomplete.txt");
            MessageBox.Show("Setup complete, you can now disable or enable various settings in the configuration tab, you can also reset at anytime");
            Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = webBrowser1.Url.ToString();
        }  
       
    }

}
