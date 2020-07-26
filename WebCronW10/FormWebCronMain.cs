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
            textBoxWebCronScript.Text = "Navigating to: " + webBrowserWebCron.Url.ToString();
        }
    }
}
