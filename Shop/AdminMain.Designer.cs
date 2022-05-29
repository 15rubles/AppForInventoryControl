namespace Shop
{
    partial class AdminMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SearchButton = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AnotherTableButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReportButton = new System.Windows.Forms.Button();
            this.MaxPriceBox = new System.Windows.Forms.TextBox();
            this.MinPriceBox = new System.Windows.Forms.TextBox();
            this.RadioPanel = new System.Windows.Forms.Panel();
            this.radioButtonName = new System.Windows.Forms.RadioButton();
            this.radioButtonPrice = new System.Windows.Forms.RadioButton();
            this.radioButtonQuantity = new System.Windows.Forms.RadioButton();
            this.radioButtonProduct = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceOfProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Of_Registrant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TaskButton = new System.Windows.Forms.PictureBox();
            this.YBox = new System.Windows.Forms.TextBox();
            this.XBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SearchButton)).BeginInit();
            this.panel1.SuspendLayout();
            this.RadioPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskButton)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Image = global::Shop.Properties.Resources.search;
            this.SearchButton.Location = new System.Drawing.Point(592, 98);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(25, 25);
            this.SearchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchButton.TabIndex = 4;
            this.SearchButton.TabStop = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(197)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(197)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("PP Neue Machina", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(226)))));
            this.button1.Location = new System.Drawing.Point(65, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 44);
            this.button1.TabIndex = 19;
            this.button1.Text = "Добавить элемент";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(197)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(197)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("PP Neue Machina", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(226)))));
            this.button2.Location = new System.Drawing.Point(254, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 44);
            this.button2.TabIndex = 20;
            this.button2.Text = "Обновить таблицу";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AnotherTableButton
            // 
            this.AnotherTableButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(197)))));
            this.AnotherTableButton.FlatAppearance.BorderSize = 0;
            this.AnotherTableButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(197)))));
            this.AnotherTableButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.AnotherTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnotherTableButton.Font = new System.Drawing.Font("PP Neue Machina", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnotherTableButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(226)))));
            this.AnotherTableButton.Location = new System.Drawing.Point(709, 192);
            this.AnotherTableButton.Name = "AnotherTableButton";
            this.AnotherTableButton.Size = new System.Drawing.Size(216, 44);
            this.AnotherTableButton.TabIndex = 21;
            this.AnotherTableButton.Text = "Таблица пользователей";
            this.AnotherTableButton.UseVisualStyleBackColor = false;
            this.AnotherTableButton.Click += new System.EventHandler(this.AnotherTableButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(237)))));
            this.panel1.Controls.Add(this.TaskButton);
            this.panel1.Controls.Add(this.ReportButton);
            this.panel1.Controls.Add(this.YBox);
            this.panel1.Controls.Add(this.MaxPriceBox);
            this.panel1.Controls.Add(this.XBox);
            this.panel1.Controls.Add(this.MinPriceBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AnotherTableButton);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.RadioPanel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.LoginButton);
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.SearchBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 675);
            this.panel1.TabIndex = 3;
            // 
            // ReportButton
            // 
            this.ReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(197)))));
            this.ReportButton.FlatAppearance.BorderSize = 0;
            this.ReportButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(197)))));
            this.ReportButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.ReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportButton.Font = new System.Drawing.Font("PP Neue Machina", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(226)))));
            this.ReportButton.Location = new System.Drawing.Point(443, 192);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(165, 44);
            this.ReportButton.TabIndex = 24;
            this.ReportButton.Text = "Сделать отчет";
            this.ReportButton.UseVisualStyleBackColor = false;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // MaxPriceBox
            // 
            this.MaxPriceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxPriceBox.Font = new System.Drawing.Font("PP Neue Machina", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxPriceBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.MaxPriceBox.Location = new System.Drawing.Point(456, 93);
            this.MaxPriceBox.Multiline = true;
            this.MaxPriceBox.Name = "MaxPriceBox";
            this.MaxPriceBox.Size = new System.Drawing.Size(130, 36);
            this.MaxPriceBox.TabIndex = 23;
            this.MaxPriceBox.Visible = false;
            this.MaxPriceBox.Enter += new System.EventHandler(this.MaxPriceBox_Enter);
            this.MaxPriceBox.Leave += new System.EventHandler(this.MaxPriceBox_Leave);
            // 
            // MinPriceBox
            // 
            this.MinPriceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MinPriceBox.Font = new System.Drawing.Font("PP Neue Machina", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinPriceBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.MinPriceBox.Location = new System.Drawing.Point(311, 93);
            this.MinPriceBox.Multiline = true;
            this.MinPriceBox.Name = "MinPriceBox";
            this.MinPriceBox.Size = new System.Drawing.Size(130, 36);
            this.MinPriceBox.TabIndex = 22;
            this.MinPriceBox.Visible = false;
            this.MinPriceBox.Enter += new System.EventHandler(this.MinPriceBox_Enter);
            this.MinPriceBox.Leave += new System.EventHandler(this.MinPriceBox_Leave);
            // 
            // RadioPanel
            // 
            this.RadioPanel.Controls.Add(this.radioButtonName);
            this.RadioPanel.Controls.Add(this.radioButtonPrice);
            this.RadioPanel.Controls.Add(this.radioButtonQuantity);
            this.RadioPanel.Controls.Add(this.radioButtonProduct);
            this.RadioPanel.Location = new System.Drawing.Point(65, 67);
            this.RadioPanel.Name = "RadioPanel";
            this.RadioPanel.Size = new System.Drawing.Size(223, 107);
            this.RadioPanel.TabIndex = 18;
            // 
            // radioButtonName
            // 
            this.radioButtonName.AutoSize = true;
            this.radioButtonName.Font = new System.Drawing.Font("PP Neue Machina", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonName.Location = new System.Drawing.Point(3, 79);
            this.radioButtonName.Name = "radioButtonName";
            this.radioButtonName.Size = new System.Drawing.Size(216, 18);
            this.radioButtonName.TabIndex = 4;
            this.radioButtonName.Text = "ФИО зарегистрировавшего товар";
            this.radioButtonName.UseVisualStyleBackColor = true;
            this.radioButtonName.CheckedChanged += new System.EventHandler(this.radioButtonName_CheckedChanged);
            // 
            // radioButtonPrice
            // 
            this.radioButtonPrice.AutoSize = true;
            this.radioButtonPrice.Font = new System.Drawing.Font("PP Neue Machina", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonPrice.Location = new System.Drawing.Point(3, 55);
            this.radioButtonPrice.Name = "radioButtonPrice";
            this.radioButtonPrice.Size = new System.Drawing.Size(54, 18);
            this.radioButtonPrice.TabIndex = 2;
            this.radioButtonPrice.Text = "Цена";
            this.radioButtonPrice.UseVisualStyleBackColor = true;
            this.radioButtonPrice.CheckedChanged += new System.EventHandler(this.radioButtonPrice_CheckedChanged);
            // 
            // radioButtonQuantity
            // 
            this.radioButtonQuantity.AutoSize = true;
            this.radioButtonQuantity.Font = new System.Drawing.Font("PP Neue Machina", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonQuantity.Location = new System.Drawing.Point(3, 31);
            this.radioButtonQuantity.Name = "radioButtonQuantity";
            this.radioButtonQuantity.Size = new System.Drawing.Size(89, 18);
            this.radioButtonQuantity.TabIndex = 1;
            this.radioButtonQuantity.Text = "Количество";
            this.radioButtonQuantity.UseVisualStyleBackColor = true;
            this.radioButtonQuantity.CheckedChanged += new System.EventHandler(this.radioButtonQuantity_CheckedChanged);
            // 
            // radioButtonProduct
            // 
            this.radioButtonProduct.AutoSize = true;
            this.radioButtonProduct.Checked = true;
            this.radioButtonProduct.Font = new System.Drawing.Font("PP Neue Machina", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonProduct.Location = new System.Drawing.Point(3, 7);
            this.radioButtonProduct.Name = "radioButtonProduct";
            this.radioButtonProduct.Size = new System.Drawing.Size(72, 18);
            this.radioButtonProduct.TabIndex = 0;
            this.radioButtonProduct.TabStop = true;
            this.radioButtonProduct.Text = "Продукт";
            this.radioButtonProduct.UseVisualStyleBackColor = true;
            this.radioButtonProduct.CheckedChanged += new System.EventHandler(this.radioButtonProduct_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PP Neue Machina", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.label3.Location = new System.Drawing.Point(61, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Найти товары по параметру:";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(197)))));
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(197)))));
            this.LoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("PP Neue Machina", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(226)))));
            this.LoginButton.Location = new System.Drawing.Point(887, 9);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(88, 44);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Выйти";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBox.Font = new System.Drawing.Font("PP Neue Machina", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.SearchBox.Location = new System.Drawing.Point(311, 93);
            this.SearchBox.Multiline = true;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(275, 36);
            this.SearchBox.TabIndex = 3;
            this.SearchBox.Enter += new System.EventHandler(this.SearchBox_Enter);
            this.SearchBox.Leave += new System.EventHandler(this.SearchBox_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(65, 256);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 390);
            this.panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(237)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Prod,
            this.Quant,
            this.PriceOfProduct,
            this.Date,
            this.Name_Of_Registrant,
            this.Edit,
            this.Del});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("PP Neue Machina", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(860, 390);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.FillWeight = 30F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Prod
            // 
            this.Prod.FillWeight = 150F;
            this.Prod.HeaderText = "PRODUCT";
            this.Prod.Name = "Prod";
            this.Prod.ReadOnly = true;
            // 
            // Quant
            // 
            this.Quant.HeaderText = "QUANTITY";
            this.Quant.Name = "Quant";
            this.Quant.ReadOnly = true;
            // 
            // PriceOfProduct
            // 
            this.PriceOfProduct.HeaderText = "PRICE";
            this.PriceOfProduct.Name = "PriceOfProduct";
            this.PriceOfProduct.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "DATE";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Name_Of_Registrant
            // 
            this.Name_Of_Registrant.FillWeight = 200F;
            this.Name_Of_Registrant.HeaderText = "NAME";
            this.Name_Of_Registrant.Name = "Name_Of_Registrant";
            this.Name_Of_Registrant.ReadOnly = true;
            // 
            // Edit
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.Edit.DefaultCellStyle = dataGridViewCellStyle16;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.Text = "Изменить";
            // 
            // Del
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(55)))), ((int)(((byte)(68)))));
            this.Del.DefaultCellStyle = dataGridViewCellStyle17;
            this.Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Del.HeaderText = "";
            this.Del.Name = "Del";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PP Neue Machina Ultrabold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.label1.Location = new System.Drawing.Point(275, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Панель администратира";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TaskButton
            // 
            this.TaskButton.Image = global::Shop.Properties.Resources.search;
            this.TaskButton.Location = new System.Drawing.Point(885, 143);
            this.TaskButton.Name = "TaskButton";
            this.TaskButton.Size = new System.Drawing.Size(25, 25);
            this.TaskButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TaskButton.TabIndex = 12;
            this.TaskButton.TabStop = false;
            this.TaskButton.Click += new System.EventHandler(this.TaskButton_Click_1);
            // 
            // YBox
            // 
            this.YBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YBox.Font = new System.Drawing.Font("PP Neue Machina", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.YBox.Location = new System.Drawing.Point(779, 138);
            this.YBox.Multiline = true;
            this.YBox.Name = "YBox";
            this.YBox.Size = new System.Drawing.Size(87, 36);
            this.YBox.TabIndex = 11;
            this.YBox.Enter += new System.EventHandler(this.YBox_Enter);
            this.YBox.Leave += new System.EventHandler(this.YBox_Leave);
            // 
            // XBox
            // 
            this.XBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.XBox.Font = new System.Drawing.Font("PP Neue Machina", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.XBox.Location = new System.Drawing.Point(661, 138);
            this.XBox.Multiline = true;
            this.XBox.Name = "XBox";
            this.XBox.Size = new System.Drawing.Size(87, 36);
            this.XBox.TabIndex = 10;
            this.XBox.Enter += new System.EventHandler(this.XBox_Enter);
            this.XBox.Leave += new System.EventHandler(this.XBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PP Neue Machina", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.label2.Location = new System.Drawing.Point(657, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 60);
            this.label2.TabIndex = 9;
            this.label2.Text = "Найти товары, хранящиеся более \r\nX месяцев,стоимость которых\r\nпревышает Y рублей:" +
    "";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 675);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1003, 714);
            this.MinimumSize = new System.Drawing.Size(1003, 714);
            this.Name = "AdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.SearchButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.RadioPanel.ResumeLayout(false);
            this.RadioPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SearchButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AnotherTableButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel RadioPanel;
        private System.Windows.Forms.RadioButton radioButtonName;
        private System.Windows.Forms.RadioButton radioButtonPrice;
        private System.Windows.Forms.RadioButton radioButtonQuantity;
        private System.Windows.Forms.RadioButton radioButtonProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quant;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceOfProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Of_Registrant;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Del;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox MinPriceBox;
        private System.Windows.Forms.TextBox MaxPriceBox;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.PictureBox TaskButton;
        private System.Windows.Forms.TextBox YBox;
        private System.Windows.Forms.TextBox XBox;
        private System.Windows.Forms.Label label2;
    }
}