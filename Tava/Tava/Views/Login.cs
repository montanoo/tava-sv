using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tava.Controllers;

namespace Tava.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            var checking = new CheckDatabase();
            checking.Check();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var login = new LoginUser();
            var canLogin = login.Login(txtUser.Text, txtPassword.Text);
            if (!canLogin) return;

            var enterMain = new FormMainMenu();
            enterMain.Show();
            this.Hide();
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var newUser = new SignUp();
            newUser.Show();
            Hide();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
