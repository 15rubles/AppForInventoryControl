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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            PassBox.PasswordChar = '\0';
            PassBox2.PasswordChar = '\0';
            LoginBox.Text = "Логин";
            PassBox.Text = "Пароль";
            PassBox2.Text = "Повторите пароль";
            PassBox.ForeColor = ColorTranslator.FromHtml("#D9D9E2");
            PassBox2.ForeColor = ColorTranslator.FromHtml("#D9D9E2");
            LoginBox.ForeColor = ColorTranslator.FromHtml("#D9D9E2");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //try to registrate
        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            
            if (LoginBox.Text == "Логин")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (PassBox.Text == "Пароль")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            if (PassBox2.Text == "Повторите пароль")
            {
                MessageBox.Show("Введите пароль повторно");
                return;
            }
            if (PassBox.Text != PassBox2.Text)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`) VALUES (@uL, @uP);", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginBox.Text;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = PassBox.Text;
            if (IsUserExist()) return;
            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                this.Hide();
                LoginForm form = new LoginForm();
                form.Show();
            }
            else MessageBox.Show("Ошибка при регистрации");

            db.CloseConnection();
        }
        public bool IsUserExist()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginBox.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с таким логином уже существует, введите другой");
                return true;
            }
            else return false;
        }

        private void LoginBox_Enter(object sender, EventArgs e)
        {
            if (LoginBox.Text == "Логин")
            {
                LoginBox.Text = "";
                LoginBox.ForeColor = ColorTranslator.FromHtml("#080708"); 
            }

        }

        private void LoginBox_Leave(object sender, EventArgs e)
        {
            if (LoginBox.Text == "") 
            {
                LoginBox.Text = "Логин";
                LoginBox.ForeColor = ColorTranslator.FromHtml("#D9D9E2");
            }
        }

        private void PassBox_Enter(object sender, EventArgs e)
        {
            if (PassBox.Text == "Пароль")
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
                PassBox.Text = "Пароль";
                PassBox.ForeColor = ColorTranslator.FromHtml("#D9D9E2");
            }
        }

        private void PassBox2_Enter(object sender, EventArgs e)
        {
            if (PassBox2.Text == "Повторите пароль")
            {
                PassBox2.PasswordChar = '*';
                PassBox2.Text = "";
                PassBox2.ForeColor = ColorTranslator.FromHtml("#080708");
            }
        }

        private void PassBox2_Leave(object sender, EventArgs e)
        {
            if (PassBox2.Text == "")
            {
                PassBox2.PasswordChar = '\0';
                PassBox2.Text = "Повторите пароль";
                PassBox2.ForeColor = ColorTranslator.FromHtml("#D9D9E2");
            }
        }

        private void toRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form = new LoginForm();
            form.Show();
        }

        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
