using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter both username and password.",
                    "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ChooseForm chooseForm = new ChooseForm();
            chooseForm.Show();
            Hide();
        }
    }
}
