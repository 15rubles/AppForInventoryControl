using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Shop
{
    public partial class AdminMain : Form
    {
        const string PRODUCT = "Название товара"; 
        const string QUANTITY = "Минимальное кол-во товара";
        const string NAME = "ФИО";
        const string NOT_FOUNT = "Товары не найдены";
        const string NOT_INT = "В поле ввода должно быть число";
        const string UPDATE = "Изменить";
        const string DELETE = "Удалить";
        const string MAX_PRICE = "Макс. цена";
        const string MIN_PRICE = "Мин. цена";
        const string X = "X";
        const string Y = "Y";

        private void FillTable(DataTable table)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                dataGridView1.Rows.Add();
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    string str = table.Rows[i][j].ToString();
                    if(j==4)
                    {
                        str = str.Substring(0, str.IndexOf(" ")+1);
                    }
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

            MySqlCommand command = new MySqlCommand("SELECT * FROM `storage`", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            FillTable(table);
        }
        public AdminMain()
        {

            InitializeComponent();
            AllTable();
            SearchBox.ForeColor = ColorTranslator.FromHtml("#D9D9E2");
            SearchBox.Text = PRODUCT;
            XBox.ForeColor = ColorTranslator.FromHtml("#D9D9E2");
            XBox.Text = X;
            YBox.ForeColor = ColorTranslator.FromHtml("#D9D9E2");
            YBox.Text = Y;
        }
        private bool IsVoid()
        {
            if (SearchBox.Text == PRODUCT || SearchBox.Text == QUANTITY || SearchBox.Text == NAME) return true;
            return false;
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form = new LoginForm();
            form.Show();
        }

        private void radioButtonProduct_CheckedChanged(object sender, EventArgs e)
        {
            AllTable();
            if (IsVoid())
                SearchBox.Text = PRODUCT;
        }

        private void radioButtonPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPrice.Checked)
            {
                AllTable();
                MinPriceBox.Text = MIN_PRICE;
                MaxPriceBox.Text = MAX_PRICE;
                MinPriceBox.ForeColor = ColorTranslator.FromHtml("#D9D9E2");
                MaxPriceBox.ForeColor = ColorTranslator.FromHtml("#D9D9E2");
                MinPriceBox.Visible = true;
                MaxPriceBox.Visible = true;
                SearchBox.Visible = false;
            }
            else
            {
                MinPriceBox.Visible = false;
                MaxPriceBox.Visible = false;
                SearchBox.Visible = true;
            }
        }

        private void radioButtonQuantity_CheckedChanged(object sender, EventArgs e)
        {
            AllTable();
            if (IsVoid())
                SearchBox.Text = QUANTITY;
        }

        private void radioButtonName_CheckedChanged(object sender, EventArgs e)
        {
            AllTable();
            if (IsVoid())
                SearchBox.Text = NAME;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            if (radioButtonProduct.Checked)
            {
                String search = SearchBox.Text;
                search += "%";

                MySqlCommand command = new MySqlCommand("SELECT * FROM `storage` WHERE `product` LIKE @s ", db.GetConnection());
                command.Parameters.Add("@s", MySqlDbType.VarChar).Value = search;

                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                    FillTable(table);
                else MessageBox.Show(NOT_FOUNT);
                return;
            }
            if (radioButtonPrice.Checked)
            {
                int minPrice, maxPrice;
                bool isXInt = Int32.TryParse(MinPriceBox.Text, out minPrice);
                bool isYInt = Int32.TryParse(MaxPriceBox.Text, out maxPrice);
                if (isXInt)
                {
                    MySqlCommand command = new MySqlCommand("SELECT * FROM `storage` WHERE `price` >= @min AND `price` <= @max", db.GetConnection());
                    command.Parameters.Add("@min", MySqlDbType.VarChar).Value = minPrice;
                    command.Parameters.Add("@max", MySqlDbType.VarChar).Value = maxPrice;

                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                        FillTable(table);
                    else MessageBox.Show(NOT_FOUNT);
                    return;
                }
                else
                {
                    MessageBox.Show(NOT_INT);
                    return;
                }
            }
            if (radioButtonQuantity.Checked)
            {
                int quantity;
                bool isXInt = Int32.TryParse(SearchBox.Text, out quantity);
                if (isXInt)
                {
                    MySqlCommand command = new MySqlCommand("SELECT * FROM `storage` WHERE `quantity` >= @q ", db.GetConnection());
                    command.Parameters.Add("@q", MySqlDbType.VarChar).Value = quantity;

                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                        FillTable(table);
                    else MessageBox.Show(NOT_FOUNT);
                    return;
                }
                else
                {
                    MessageBox.Show(NOT_INT);
                    return;
                }
            }
            if (radioButtonName.Checked)
            {
                String search = SearchBox.Text;
                search += "%";

                MySqlCommand command = new MySqlCommand("SELECT * FROM `storage` WHERE `registrants_name` LIKE @s ", db.GetConnection());
                command.Parameters.Add("@s", MySqlDbType.VarChar).Value = search;

                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                    FillTable(table);
                else MessageBox.Show(NOT_FOUNT);
                return;
            }
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
                if (radioButtonName.Checked) SearchBox.Text = NAME;
                else if (radioButtonQuantity.Checked) SearchBox.Text = QUANTITY;
                else SearchBox.Text = PRODUCT;
                SearchBox.ForeColor = ColorTranslator.FromHtml("#D9D9E2");
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 6 && e.ColumnIndex != 7) return;
            if(e.ColumnIndex == 6)
            {
                UpdateForm form = new UpdateForm(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), false);
                form.Show();
            }
            if(e.ColumnIndex == 7)
            {
                DialogResult result = MessageBox.Show( "Хотите продолжить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.Yes)
                {
                    DataBase db = new DataBase();
                    DataTable table = new DataTable();
                    MySqlCommand command = new MySqlCommand();
                    command.CommandText = "DELETE FROM `storage` WHERE `storage`.`id` = @id";
                    command.Connection = db.GetConnection();
                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    command.ExecuteNonQuery();
                    AllTable();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) //new row button
        {
            UpdateForm form = new UpdateForm("NULL", true);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e) //update table button
        {
            AllTable();
        }

        private void AnotherTableButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminUsers form = new AdminUsers();
            form.Show();
        }

        private void AdminMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinPriceBox_Enter(object sender, EventArgs e)
        {
            if (MinPriceBox.Text == MIN_PRICE)
            {
                MinPriceBox.Text = "";
                MinPriceBox.ForeColor = ColorTranslator.FromHtml("#080708");
            }
        }

        private void MaxPriceBox_Leave(object sender, EventArgs e)
        {
            if (MaxPriceBox.Text == "")
            {
                AllTable();
                MaxPriceBox.Text = MAX_PRICE;
                MaxPriceBox.ForeColor = ColorTranslator.FromHtml("#D9D9E2");
            }
        }

        private void MaxPriceBox_Enter(object sender, EventArgs e)
        {
            if (MaxPriceBox.Text == MAX_PRICE)
            {
                MaxPriceBox.Text = "";
                MaxPriceBox.ForeColor = ColorTranslator.FromHtml("#080708");
            }
        }

        private void MinPriceBox_Leave(object sender, EventArgs e)
        {
            if (MinPriceBox.Text == "")
            {
                AllTable();
                MinPriceBox.Text = MIN_PRICE;
                MinPriceBox.ForeColor = ColorTranslator.FromHtml("#D9D9E2");
            }
        }
        
        //make a report
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

        private void TaskButton_Click(object sender, EventArgs e)
        {

        }
        //personal task
        private void TaskButton_Click_1(object sender, EventArgs e)
        {
            if (XBox.Text != X && YBox.Text != Y)
            {
                int x, y;
                bool isXInt = Int32.TryParse(XBox.Text, out x);
                bool isYInt = Int32.TryParse(YBox.Text, out y);
                if (isXInt && isYInt)
                {
                    DataBase db = new DataBase();
                    DataTable table = new DataTable();

                    MySqlDataAdapter adapter = new MySqlDataAdapter();

                    MySqlCommand command = new MySqlCommand("SELECT * FROM `storage` WHERE `price` > @y  AND TIMESTAMPDIFF(MONTH,`date_of_registration`,CURDATE()) > @x  ", db.GetConnection());
                    command.Parameters.Add("@x", MySqlDbType.VarChar).Value = x;
                    command.Parameters.Add("@y", MySqlDbType.VarChar).Value = y;
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        FillTable(table);
                        dataGridView1.Sort(dataGridView1.Columns["Prod"], ListSortDirection.Ascending);
                    }
                    else MessageBox.Show(NOT_FOUNT);
                    
                }
                else
                {
                    XBox.Text = X;
                    XBox.ForeColor = ColorTranslator.FromHtml("#D9D9E2");
                    YBox.Text = Y;
                    YBox.ForeColor = ColorTranslator.FromHtml("#D9D9E2");
                    MessageBox.Show("X и Y должны быть числами");
                }
            }
        }

        private void XBox_Enter(object sender, EventArgs e)
        {
            if (XBox.Text == X)
            {
                XBox.Text = "";
                XBox.ForeColor = ColorTranslator.FromHtml("#080708");
            }
        }

        private void XBox_Leave(object sender, EventArgs e)
        {
            if (XBox.Text == "")
            {
                AllTable();
                XBox.Text = X;
                XBox.ForeColor = ColorTranslator.FromHtml("#D9D9E2");
            }
        }

        private void YBox_Enter(object sender, EventArgs e)
        {
            if (YBox.Text == Y)
            {
                YBox.Text = "";
                YBox.ForeColor = ColorTranslator.FromHtml("#080708");
            }
        }

        private void YBox_Leave(object sender, EventArgs e)
        {
            if (YBox.Text == "")
            {
                AllTable();
                YBox.Text = Y;
                YBox.ForeColor = ColorTranslator.FromHtml("#D9D9E2");
            }
        }
    }
}
