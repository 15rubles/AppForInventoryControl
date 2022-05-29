namespace Shop
{
    partial class UpdateUserForm
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
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.TopLable = new System.Windows.Forms.Label();
            this.Productlabel = new System.Windows.Forms.Label();
            this.Errorlabel = new System.Windows.Forms.Label();
            this.ErrorPanel = new System.Windows.Forms.Panel();
            this.toAdminMain = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AdminCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ErrorPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PasswordBox
            // 
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordBox.Font = new System.Drawing.Font("PP Neue Machina", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.PasswordBox.Location = new System.Drawing.Point(23, 188);
            this.PasswordBox.Multiline = true;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(286, 25);
            this.PasswordBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(237)))));
            this.label3.Font = new System.Drawing.Font("PP Neue Machina", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(237)))));
            this.label2.Font = new System.Drawing.Font("PP Neue Machina", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Логин";
            // 
            // LoginBox
            // 
            this.LoginBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginBox.Font = new System.Drawing.Font("PP Neue Machina", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.LoginBox.Location = new System.Drawing.Point(87, 194);
            this.LoginBox.Multiline = true;
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(286, 25);
            this.LoginBox.TabIndex = 8;
            // 
            // TopLable
            // 
            this.TopLable.AutoSize = true;
            this.TopLable.Font = new System.Drawing.Font("PP Neue Machina Ultrabold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.TopLable.Location = new System.Drawing.Point(58, 18);
            this.TopLable.Name = "TopLable";
            this.TopLable.Size = new System.Drawing.Size(277, 35);
            this.TopLable.TabIndex = 7;
            this.TopLable.Text = "Изменить строку ";
            // 
            // Productlabel
            // 
            this.Productlabel.AutoSize = true;
            this.Productlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(237)))));
            this.Productlabel.Font = new System.Drawing.Font("PP Neue Machina", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productlabel.Location = new System.Drawing.Point(19, 65);
            this.Productlabel.Name = "Productlabel";
            this.Productlabel.Size = new System.Drawing.Size(52, 17);
            this.Productlabel.TabIndex = 6;
            this.Productlabel.Text = "Админ";
            // 
            // Errorlabel
            // 
            this.Errorlabel.AutoSize = true;
            this.Errorlabel.Font = new System.Drawing.Font("PP Neue Machina", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Errorlabel.Location = new System.Drawing.Point(6, 8);
            this.Errorlabel.Name = "Errorlabel";
            this.Errorlabel.Size = new System.Drawing.Size(321, 17);
            this.Errorlabel.TabIndex = 17;
            this.Errorlabel.Text = "Пользователь с таким логином уже существует";
            this.Errorlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ErrorPanel
            // 
            this.ErrorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ErrorPanel.Controls.Add(this.Errorlabel);
            this.ErrorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ErrorPanel.Location = new System.Drawing.Point(0, 0);
            this.ErrorPanel.Name = "ErrorPanel";
            this.ErrorPanel.Size = new System.Drawing.Size(330, 33);
            this.ErrorPanel.TabIndex = 0;
            // 
            // toAdminMain
            // 
            this.toAdminMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(237)))));
            this.toAdminMain.FlatAppearance.BorderSize = 0;
            this.toAdminMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.toAdminMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.toAdminMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toAdminMain.Font = new System.Drawing.Font("PP Neue Machina", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toAdminMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.toAdminMain.Location = new System.Drawing.Point(231, 326);
            this.toAdminMain.Name = "toAdminMain";
            this.toAdminMain.Size = new System.Drawing.Size(93, 37);
            this.toAdminMain.TabIndex = 5;
            this.toAdminMain.Text = "Отмена";
            this.toAdminMain.UseVisualStyleBackColor = false;
            this.toAdminMain.Click += new System.EventHandler(this.toAdminMain_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(197)))));
            this.UpdateButton.FlatAppearance.BorderSize = 0;
            this.UpdateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(197)))));
            this.UpdateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("PP Neue Machina", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(226)))));
            this.UpdateButton.Location = new System.Drawing.Point(120, 322);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(105, 44);
            this.UpdateButton.TabIndex = 4;
            this.UpdateButton.Text = "Изменить";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(237)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.AdminCheckBox);
            this.panel2.Controls.Add(this.ErrorPanel);
            this.panel2.Controls.Add(this.PasswordBox);
            this.panel2.Controls.Add(this.Productlabel);
            this.panel2.Location = new System.Drawing.Point(64, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 330);
            this.panel2.TabIndex = 16;
            // 
            // AdminCheckBox
            // 
            this.AdminCheckBox.AutoSize = true;
            this.AdminCheckBox.Location = new System.Drawing.Point(77, 68);
            this.AdminCheckBox.Name = "AdminCheckBox";
            this.AdminCheckBox.Size = new System.Drawing.Size(15, 14);
            this.AdminCheckBox.TabIndex = 15;
            this.AdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LoginBox);
            this.panel1.Controls.Add(this.TopLable);
            this.panel1.Controls.Add(this.toAdminMain);
            this.panel1.Controls.Add(this.UpdateButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(451, 570);
            this.panel1.MinimumSize = new System.Drawing.Size(451, 570);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 570);
            this.panel1.TabIndex = 2;
            // 
            // UpdateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 453);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(467, 492);
            this.MinimumSize = new System.Drawing.Size(467, 492);
            this.Name = "UpdateUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateUserForm";
            this.ErrorPanel.ResumeLayout(false);
            this.ErrorPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.Label TopLable;
        private System.Windows.Forms.Label Productlabel;
        private System.Windows.Forms.Label Errorlabel;
        private System.Windows.Forms.Panel ErrorPanel;
        private System.Windows.Forms.Button toAdminMain;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox AdminCheckBox;
    }
}