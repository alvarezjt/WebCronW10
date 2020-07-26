using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebCronW10
{
    public partial class FormWebCronMain : Form
    {
        public FormWebCronMain()
        {
            InitializeComponent();
        }

        private void buttonBrowserGo_Click(object sender, EventArgs e)
        {
            webBrowserWebCron.Navigate(textBoxBrowserURL.Text);
        }

        private void webBrowserWebCron_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            textBoxBrowserURL.Text = webBrowserWebCron.Url.ToString();
            //textBoxWebCronScript.Text = "Navigating to: " + webBrowserWebCron.Url.ToString();
        }

        private void buttonRunScript_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(textBoxWebCronScript.Text, "Script:");
            Array varCron = textBoxWebCronScript.Text.Split(';');
            //MessageBox.Show(textBoxWebCronScript.Text, "Script:");
            int varI = 0;
            foreach(string varKey in varCron)
            {
                MessageBox.Show(((string[])varCron)[varI]);
                //varCron[varI] = varCron[varI].Split(','); Bad Code
                varI++;
            }
        }
    }
}
