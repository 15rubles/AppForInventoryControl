using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class AdminUsers : Form
    {
        const string ADMIN = "Админ";
        const string LOGIN = "Логин";
        const string PASSWORD = "Пароль";
        const string NOT_FOUNT = "Пользователи не найдены";
        const string UPDATE = "Изменить";
        const string DELETE = "Удалить";
        const string CANT_DELETE = "Вы не можете удалить или изменить этого пользователя";
        public AdminUsers()
        {
            InitializeComponent();
            AllTable();
            SearchBox.ForeColor = ColorTranslator.FromHtml("#D9D9E2");
            SearchBox.Text = ADMIN;
        }
        private void FillTable(DataTable table)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                dataGridView1.Rows.Add();
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    string str = table.Rows[i][j].ToString();
                    dataGridView1.Rows[i].Cells[j].Value = str;
                }
                dataGridView1.Rows[i].Cells[table.Columns.Count].Value = UPDATE;
                dataGridView1.Rows[i].Cells[table.Columns.Count + 1].Value = DELETE;
            }
        }
        public void AllTable()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users`", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            FillTable(table);
        }
        private bool IsVoid()
        {
            if (SearchBox.Text == ADMIN || SearchBox.Text == LOGIN || SearchBox.Text == PASSWORD) return true;
            return false;
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form = new LoginForm();
            form.Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string whatToSearch,ComnandText;
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            if (radioButtonAdmin.Checked) ComnandText = "SELECT * FROM `users` WHERE `admin` LIKE @s ";
            else if(radioButtonLogin.Checked) ComnandText = "SELECT * FROM `users` WHERE `login` LIKE @s ";
            else ComnandText = "SELECT * FROM `users` WHERE `password` LIKE @s ";

            String search = SearchBox.Text;
            search += "%";

            MySqlCommand command = new MySqlCommand(ComnandText, db.GetConnection());
            command.Parameters.Add("@s", MySqlDbType.VarChar).Value = search;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                    FillTable(table);
            else MessageBox.Show(NOT_FOUNT);
            return;
           
        }
        private void SearchBox_Enter(object sender, EventArgs e)
        {
            if (IsVoid())
            {
                SearchBox.Text = "";
                SearchBox.ForeColor = ColorTranslator.FromHtml("#080708");
            }
        }

        private void SearchBox_Leave(object sender, EventArgs e)
        {
            if (SearchBox.Text == "")
            {
                AllTable();
                if (radioButtonAdmin.Checked) SearchBox.Text = ADMIN;
                else if (radioButtonLogin.Checked) SearchBox.Text = LOGIN;
                else if (radioButtonPassword.Checked) SearchBox.Text = PASSWORD;
                SearchBox.ForeColor = ColorTranslator.FromHtml("#D9D9E2");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 4 && e.ColumnIndex != 5) return;
            if(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() == "1")
            {
                MessageBox.Show(CANT_DELETE);
                return;
            }
            if (e.ColumnIndex == 4)
            {
                UpdateUserForm form = new UpdateUserForm(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), false, dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                form.Show();
            }
            if (e.ColumnIndex == 5)
            {
                DialogResult result = MessageBox.Show("Хотите продолжить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.Yes)
                {
                    DataBase db = new DataBase();
                    DataTable table = new DataTable();

                    MySqlCommand command = new MySqlCommand();
                    command.CommandText = "DELETE FROM `users` WHERE `users`.`id` = @id";
                    command.Connection = db.GetConnection();
                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    command.ExecuteNonQuery();
                    AllTable();
                }

            }
        }

        private void AnotherTableButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMain form = new AdminMain();
            form.Show();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            AllTable();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            UpdateUserForm form = new UpdateUserForm("NULL", true, "NULL");
            form.Show();
        }

        private void radioButtonAdmin_CheckedChanged(object sender, EventArgs e)
        {
            AllTable();
            if (IsVoid())
                SearchBox.Text =ADMIN;
        }

        private void radioButtonLogin_CheckedChanged(object sender, EventArgs e)
        {
            AllTable();
            if (IsVoid())
                SearchBox.Text = LOGIN;
        }

        private void radioButtonPassword_CheckedChanged(object sender, EventArgs e)
        {
            AllTable();
            if (IsVoid())
                SearchBox.Text = PASSWORD;
        }

        private void AdminUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            string path = "report.txt";
            File.WriteAllText(path, String.Empty);
            using (StreamWriter writer = new StreamWriter(path, true))
            {

                for (int i = 0; i < dataGridView1.Columns.Count - 2; i++)
                    writer.Write(dataGridView1.Columns[i].HeaderText + " ");
                writer.WriteLine();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count - 2; j++)
                    {
                        writer.Write(dataGridView1.Rows[i].Cells[j].Value + " ");
                    }
                    writer.WriteLine();
                }
            }
            var proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "report.txt";
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
        }
    }
}
