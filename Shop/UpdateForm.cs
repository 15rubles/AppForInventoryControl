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
    public partial class UpdateForm : Form
    {
        const string FOR_ALL = "Ошибка формата: ";
        const string PRICE = "цена";
        const string QUANTITY = "кол-во товара";
        const string ADD = "Добавить элемент";
        const string ADD_BUTTON = "Добавить";
        string idPush;
        bool isAddPush;
        public UpdateForm(string id,bool isAdd)
        {
            InitializeComponent();
            Errorlabel.Text = "";
            ErrorPanel.Visible = false;
            idPush = id;
            TopLable.Text += id;
            isAddPush = isAdd;
            if(isAdd)
            {
                TopLable.Text = ADD;
                UpdateButton.Text = ADD_BUTTON;
            }
        }

        private void toRegistration_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        //update information about product
        private void UpdateButton_Click(object sender, EventArgs e)
        {

            int conwert, month;
            bool isXInt = Int32.TryParse(QuantityBox.Text, out conwert);
            if (!isXInt)
            {
                Errorlabel.Text = FOR_ALL + QUANTITY;
                ErrorPanel.Visible = true;
                return;
            }
            isXInt = Int32.TryParse(PriceBox.Text, out conwert);
            if (!isXInt)
            {
                Errorlabel.Text = FOR_ALL + PRICE;
                ErrorPanel.Visible = true;
                return;
            }
            DialogResult result = MessageBox.Show("Хотите продолжить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                string date = dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day;
                DataBase db = new DataBase();
                DataTable table = new DataTable();
                MySqlCommand command = new MySqlCommand();
                if (isAddPush) command.CommandText = "INSERT INTO `storage` (`id`, `product`, `quantity`, `price`, `date_of_registration`, `registrants_name`) VALUES (NULL, @prod, @quant, @price, @date, @name);";
                else command.CommandText = "UPDATE `storage` SET `product` = @prod, `quantity` = @quant, `price` = @price, `date_of_registration` = @date, `registrants_name` = @name WHERE `storage`.`id` = @id";
                command.Connection = db.GetConnection();
                command.Parameters.Add("@prod", MySqlDbType.VarChar).Value = ProductBox.Text;
                command.Parameters.Add("@quant", MySqlDbType.VarChar).Value = QuantityBox.Text;
                command.Parameters.Add("@price", MySqlDbType.VarChar).Value = PriceBox.Text;
                command.Parameters.Add("@date", MySqlDbType.VarChar).Value = date;
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = NameBox.Text;
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
