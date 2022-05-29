namespace Shop
{
    partial class RegistrationForm
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
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PassBox2 = new System.Windows.Forms.TextBox();
            this.toRegistration = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(197)))));
            this.RegistrationButton.FlatAppearance.BorderSize = 0;
            this.RegistrationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(197)))));
            this.RegistrationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.RegistrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrationButton.Font = new System.Drawing.Font("PP Neue Machina", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(226)))));
            this.RegistrationButton.Location = new System.Drawing.Point(96, 437);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(97, 44);
            this.RegistrationButton.TabIndex = 4;
            this.RegistrationButton.Text = "Создать";
            this.RegistrationButton.UseVisualStyleBackColor = false;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // PassBox
            // 
            this.PassBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassBox.Font = new System.Drawing.Font("PP Neue Machina", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.PassBox.Location = new System.Drawing.Point(96, 298);
            this.PassBox.Multiline = true;
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(275, 61);
            this.PassBox.TabIndex = 3;
            this.PassBox.Enter += new System.EventHandler(this.PassBox_Enter);
            this.PassBox.Leave += new System.EventHandler(this.PassBox_Leave);
            // 
            // LoginBox
            // 
            this.LoginBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginBox.Font = new System.Drawing.Font("PP Neue Machina", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.LoginBox.Location = new System.Drawing.Point(96, 220);
            this.LoginBox.Multiline = true;
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(275, 61);
            this.LoginBox.TabIndex = 2;
            this.LoginBox.Enter += new System.EventHandler(this.LoginBox_Enter);
            this.LoginBox.Leave += new System.EventHandler(this.LoginBox_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Shop.Properties.Resources.finger;
            this.pictureBox1.Location = new System.Drawing.Point(86, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PP Neue Machina Ultrabold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.label1.Location = new System.Drawing.Point(182, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(237)))));
            this.panel1.Controls.Add(this.PassBox2);
            this.panel1.Controls.Add(this.toRegistration);
            this.panel1.Controls.Add(this.RegistrationButton);
            this.panel1.Controls.Add(this.PassBox);
            this.panel1.Controls.Add(this.LoginBox);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 560);
            this.panel1.TabIndex = 1;
            // 
            // PassBox2
            // 
            this.PassBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassBox2.Font = new System.Drawing.Font("PP Neue Machina", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.PassBox2.Location = new System.Drawing.Point(96, 358);
            this.PassBox2.Multiline = true;
            this.PassBox2.Name = "PassBox2";
            this.PassBox2.Size = new System.Drawing.Size(275, 61);
            this.PassBox2.TabIndex = 7;
            this.PassBox2.Enter += new System.EventHandler(this.PassBox2_Enter);
            this.PassBox2.Leave += new System.EventHandler(this.PassBox2_Leave);
            // 
            // toRegistration
            // 
            this.toRegistration.BackColor = System.Drawing.Color.Transparent;
            this.toRegistration.FlatAppearance.BorderSize = 0;
            this.toRegistration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.toRegistration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.toRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toRegistration.Font = new System.Drawing.Font("PP Neue Machina", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toRegistration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.toRegistration.Location = new System.Drawing.Point(199, 441);
            this.toRegistration.Name = "toRegistration";
            this.toRegistration.Size = new System.Drawing.Size(172, 37);
            this.toRegistration.TabIndex = 6;
            this.toRegistration.Text = "Уже есть аккаунт?";
            this.toRegistration.UseVisualStyleBackColor = false;
            this.toRegistration.Click += new System.EventHandler(this.toRegistration_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(458, 560);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(474, 599);
            this.MinimumSize = new System.Drawing.Size(474, 599);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrationForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button toRegistration;
        private System.Windows.Forms.TextBox PassBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}