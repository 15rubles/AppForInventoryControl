
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    
    public partial class LoginForm : Form
    {
        const string LOGIN = "Логин";
        const string PASSWORD = "Пароль";
        const string USER_DOES_NOT_EXIST = "Пользователь с введенными\nданными не существует";
        public LoginForm()
        {
            InitializeComponent();
            PassBox.PasswordChar = '\0';
            LoginBox.Text = LOGIN;
            PassBox.Text = PASSWORD;
            PassBox.ForeColor = ColorTranslator.FromHtml("#D9D9E2");
            LoginBox.ForeColor = ColorTranslator.FromHtml("#D9D9E2");
        }
        //try to login
        private void LoginButton_Click(object sender, EventArgs e)
        {
            String userLogin = LoginBox.Text;
            String userPass = PassBox.Text;

            DataBase db = new DataBase();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP",db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = userLogin;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = userPass;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                if (table.Rows[0][1].ToString() == "True")
                {
                    AdminMain form = new AdminMain();
                    this.Hide();
                    form.Show();
                }
                else
                {
                    this.Hide();
                    MainUser form = new MainUser();
                    form.Show();
                }
            }
            else MessageBox.Show(USER_DOES_NOT_EXIST);

        }

        private void LoginBox_Enter(object sender, EventArgs e)
        {
            if (LoginBox.Text == LOGIN)
            {
                LoginBox.Text = "";
                LoginBox.ForeColor = ColorTranslator.FromHtml("#080708");
            }

        }

        private void LoginBox_Leave(object sender, EventArgs e)
        {
            if (LoginBox.Text == "")
            {
                LoginBox.Text = LOGIN;
                LoginBox.ForeColor = ColorTranslator.FromHtml("#D9D9E2");
            }
        }

        private void PassBox_Enter(object sender, EventArgs e)
        {
            if (PassBox.Text == PASSWORD)
            {
                PassBox.PasswordChar = '*';
                PassBox.Text = "";
                PassBox.ForeColor = ColorTranslator.FromHtml("#080708");
            }
        }

        private void PassBox_Leave(object sender, EventArgs e)
        {
            if (PassBox.Text == "")
            {
                PassBox.PasswordChar = '\0';
                PassBox.Text = PASSWORD;
                PassBox.ForeColor = ColorTranslator.FromHtml("#D9D9E2");
            }
        }

        private void toRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm form = new RegistrationForm();
            form.Show();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
