using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Editor
{
    public partial class ConfirmationDialog : Form
    {
        private bool result = false;
        public bool Result { get { return result; } }
        public ConfirmationDialog(string content, string yesText, string noText)
        {
            InitializeComponent();
            Content.Text = content;
            YesButton.Text = yesText;
            NoButton.Text = noText;
            //this.Icon = ((System.Drawing.Icon)global::Report_Editor.Properties.Resources.Icon);
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            result = true;
            this.Close();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            result = false;
            this.Close();
        }
    }
}
