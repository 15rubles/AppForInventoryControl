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
    public partial class UpdateUserForm : Form
    {
        const string ADD = "Добавить элемент";
        const string ADD_BUTTON = "Добавить";
        const string USER_EXIST_ERROR = "Пользователь с таким логином уже существует";
        const string NULL_ERROR = "Пароль или логин не могут быть пустыми";
        string idPush;
        bool isAddPush;
        string loginPush;

        public UpdateUserForm(string id, bool isAdd, string login)
        {
            InitializeComponent();
            Errorlabel.Visible = false;
            ErrorPanel.Visible = false;
            idPush = id;
            TopLable.Text += id;
            isAddPush = isAdd;
            loginPush = login;
            if (isAdd)
            {
                TopLable.Text = ADD;
                UpdateButton.Text = ADD_BUTTON;
            }
        }
        public bool IsUserExist()
        {
            if (LoginBox.Text == loginPush) return false;
            DataBase db = new DataBase();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginBox.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                Errorlabel.Visible = true;
                ErrorPanel.Visible = true;
                Errorlabel.Text = USER_EXIST_ERROR;
                return true;
            }
            else return false;
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (IsUserExist()) return;
            if(LoginBox.Text == "" || PasswordBox.Text == "")
            {
                Errorlabel.Visible = true;
                ErrorPanel.Visible = true;
                Errorlabel.Text = NULL_ERROR;
                return;
            }
            DialogResult result = MessageBox.Show("Хотите продолжить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                DataBase db = new DataBase();
                DataTable table = new DataTable();
                MySqlCommand command = new MySqlCommand();
                if (isAddPush) command.CommandText = "INSERT INTO `users` (`id`, `admin`, `login`, `password`) VALUES (NULL, @admin, @login, @pass);";
                else command.CommandText = "UPDATE `users` SET `admin` = @admin, `login` = @login, `password` = @pass WHERE `users`.`id` = @id";
                command.Connection = db.GetConnection();
                if (AdminCheckBox.Checked) command.Parameters.Add("@admin", MySqlDbType.VarChar).Value = "1";
                else command.Parameters.Add("@admin", MySqlDbType.VarChar).Value = "0";
                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = LoginBox.Text;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PasswordBox.Text;
                if (!isAddPush) command.Parameters.Add("@id", MySqlDbType.VarChar).Value = idPush;
                command.ExecuteNonQuery();
                this.Hide();
            }
        }

        private void toAdminMain_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
