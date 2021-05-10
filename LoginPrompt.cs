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
    public partial class LoginPrompt : Form
    {
        public string UserID { get; set; }
        public string Password { get; set; }
        public LoginPrompt()
        {
            InitializeComponent();
            //this.Icon = ((System.Drawing.Icon)global::Report_Editor.Properties.Resources.Icon);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UserID = UserBox.Text;
            Password = PasswordBox.Text;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            UserID = "";
            Password = "";
        }

        private void UserBox_TextChanged(object sender, EventArgs e)
        {
            CheckInput();
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            CheckInput();
        }

        private void CheckInput()
        {
            if (UserBox.Text != "" && PasswordBox.Text != "")
            {
                SubmitButton.Enabled = true;
            } else
            {
                SubmitButton.Enabled = false;
            }
        }
    }
}
