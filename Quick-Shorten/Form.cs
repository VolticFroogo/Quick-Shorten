using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quick_Shorten
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void ShortenButton_Click(object sender, EventArgs e)
        {
            var response = Shorten.Run(LongURLTextBox.Text);

            Clipboard.SetText(response.ShortURL);
            ShortURLLabel.Text = response.ShortURL;
            ShortURLLabel.LinkVisited = false;
        }

        private void ShortURLLabel_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            ShortURLLabel.LinkVisited = true;
            System.Diagnostics.Process.Start(ShortURLLabel.Text);
        }
    }
}
