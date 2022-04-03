using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tava.Models;

namespace Tava.Views
{
    public partial class SignUp : Form
    {
        private int Id;
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var logUser = new Login();
            logUser.Show();
            this.Hide();
        }
        public bool WeakPassword() => txtPassword.Text.Length < 8;

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtName.Text == "" || txtId.Text == "" ||
                txtLastname.Text == "" || txtLastname.Text == "" || txtPassword.Text == "" || txtEmail.Text == "")
                MessageBox.Show("Faltan campos por completar");
            else if (WeakPassword())
                MessageBox.Show("La contraseña debe tener más de 8 carácteres");
            else
            {
                try
                {
                    using (var database = new TavaContext())
                    {
                        //primero se guardan los registros en la tabla user
                        var userData = new User();
                        userData.Username = txtUsername.Text;
                        userData.Password = txtPassword.Text;
                        database.Users.Add(userData);
                        database.SaveChanges();
                        Id = userData.Id;
                    }

                    using (var database = new TavaContext())
                    {
                        //se guardan los registros en la tabla clients
                        var adminData = new Admin
                        {
                            UserId = Id,
                            Name = txtName.Text,
                            Bankaccount = txtBank.Text,
                            Companyname = "Tava",
                            Identitynumber = txtId.Text,
                            Lastname = txtLastname.Text,
                        };
                        //relaciona el id de la tabla user con la foreign key de la tabla client
                        adminData.UserId = Id;
                        database.Admins.Add(adminData);
                        database.SaveChanges();
                    }

                    MessageBox.Show("Bienvenido a Tava SV!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var goTologin = new Login();
                    goTologin.Show();
                    Hide();
                }
                catch
                {
                    MessageBox.Show("El nombre de usuario, DUI o correo electrónico ya ha sido registrado");
                }

            }
        }
    }
}
