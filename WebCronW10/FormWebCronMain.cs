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
                //MessageBox.Show(((string[])varCron)[varI]);
                WCRunScript(((string[])varCron)[varI]);
                varI++;
            }
        }

        private void WCRunScript(string vCommand)
        {
            string[] varLocalArray = vCommand.Split(',');
            int varI = 0;
            foreach (string varLocalArrayKey in varLocalArray)
            {
                //MessageBox.Show(((string[])varLocalArray)[varI]);
                //varI++;
            }

            if(varLocalArray[0]=="nav")
            {
                WCRunScriptNavigate(varLocalArray);
            }
            else if (varLocalArray[0] == "inputset")
            {
                WCRunScriptSetValue(varLocalArray);
            }
            else if (varLocalArray[0] == "inputget")
            {
                WCRunScriptGetValue(varLocalArray);
            }
            else if (varLocalArray[0] == "click")
            {
                WCRunScriptClick(varLocalArray);
            }
        }

        private void WCRunScriptClick(string[] varLocalArray)
        {
            //throw new NotImplementedException();
            //MessageBox.Show("WC Execute: "+ varLocalArray[0]);
            webBrowserWebCron.Document.GetElementById(varLocalArray[1]).InvokeMember("Click");
        }

        private void WCRunScriptGetValue(string[] varLocalArray)
        {
            //throw new NotImplementedException();
            MessageBox.Show("WC Execute: "+ varLocalArray[0]);
        }

        private void WCRunScriptSetValue(string[] varLocalArray)
        {
            //throw new NotImplementedException();
            //MessageBox.Show("WC Execute: "+ varLocalArray[0]);
            webBrowserWebCron.Document.GetElementById(varLocalArray[1].ToString()).SetAttribute("Value",varLocalArray[2].ToString());
        }

        private void WCRunScriptNavigate(string[] varLocalArray)
        {
            //throw new NotImplementedException();
            //MessageBox.Show("WC Execute: "+ varLocalArray[0]);
            webBrowserWebCron.Navigate(varLocalArray[2]);
        }
    }
}
