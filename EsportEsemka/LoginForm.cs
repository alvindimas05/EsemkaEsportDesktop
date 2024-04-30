using EsportEsemka.databaseDataSetTableAdapters;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsportEsemka
{
    public partial class LoginForm : Form
    {
        userTableAdapter userTableAdapter;
        public LoginForm()
        {
            InitializeComponent();
            userTableAdapter = new userTableAdapter();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var loginData = new LoginData();
            loginData.username = textBoxUsername.Text;
            loginData.password = textBoxPassword.Text;

            var validator = new LoginValidator();
            var validatorResult = validator.Validate(loginData);

            if(!validatorResult.IsValid)
            {
                MessageBox.Show(validatorResult.Errors[0].ToString(), "Peringatan");
                return;
            }

            var loginResult = userTableAdapter.LoginQuery(loginData.username, loginData.password);
            MessageBox.Show(loginResult > 0 ? "Login berhasil!" : "Login gagal!", "EsportEsemka");
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = checkBoxShowPassword.Checked ? '\0' : '*';
        }

        private void labelCreateAccount_Click(object sender, EventArgs e)
        {
            Hide();

            var form = new CreateAccountForm();
            form.loginForm = this;
            form.Show();
        }
    }
    public class LoginValidator : AbstractValidator<LoginData>
    {
        public LoginValidator()
        {
            RuleFor(data => data.username).NotEmpty().WithMessage("Username tidak boleh kosong!");
            RuleFor(data => data.password).NotEmpty().WithMessage("Password tidak boleh kosong!");
        }
    }
    public class LoginData
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}
