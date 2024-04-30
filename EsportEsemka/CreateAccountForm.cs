using EsportEsemka.databaseDataSetTableAdapters;
using FluentValidation;
using FluentValidation.Results;
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
    public partial class CreateAccountForm : Form
    {
        userTableAdapter userTableAdapter;
        public LoginForm loginForm;
        public CreateAccountForm()
        {
            InitializeComponent();
            userTableAdapter = new userTableAdapter();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var createData = new CreateAccountData();
            createData.username = textBoxUsername.Text;
            if(radioButtonGenderMale.Checked) createData.gender = true;
            else if(radioButtonGenderFemale.Checked) createData.gender = false;
            createData.birthDate = dateTimePickerBirthdate.Value;
            createData.password = textBoxPassword.Text;
            createData.retypePassword = textBoxRetypePassword.Text;

            var validator = new CreateAccountValidator();
            var validatorResult = validator.Validate(createData);
            if (!validatorResult.IsValid)
            {
                MessageBox.Show(validatorResult.Errors[0].ToString(), "Peringatan");
                return;
            }

            userTableAdapter.InsertQuery(
                createData.username,
                createData.password,
                createData.birthDate.ToString("dd/MM/yyyy"),
                createData.gender == true ? true : false,
                false
            );

            MessageBox.Show("Akun berhasil dibuat!", "EsportEsemka");
            Close();
        }

        private void CreateAccountForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm.Show();
        }
    }
    public class CreateAccountValidator : AbstractValidator<CreateAccountData>
    {
        public CreateAccountValidator()
        {
            RuleFor(data => data.username).NotEmpty().WithMessage("Username tidak boleh kosong!");
            RuleFor(data => data.password).NotEmpty().WithMessage("Password tidak boleh kosong!");
            RuleFor(data => data.gender).NotNull().WithMessage("Gender harus dipilih!");
            RuleFor(data => data.password).NotEmpty().WithMessage("Password tidak boleh kosong!");
            RuleFor(data => data.retypePassword).NotEmpty().WithMessage("Password tidak boleh kosong!");
            RuleFor(data => data.password).Equal(data => data.retypePassword).WithMessage("Konfirmasi password salah!");
        }
    }
    public class CreateAccountData
    {
        public string username { get; set; }
        public bool? gender { get; set; }
        public DateTime birthDate { get; set; }
        public string password { get; set; }
        public string retypePassword { get; set; }
    }
}
