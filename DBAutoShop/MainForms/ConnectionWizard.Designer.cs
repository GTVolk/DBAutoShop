namespace DBAutoShop.MainForms
{
    partial class ConnectionWizard
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
            this.ConnectByWindows = new System.Windows.Forms.RadioButton();
            this.ConnectBySQL = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.MaskedTextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.DataSource = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ConnectionString = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PasswordCheck = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectByWindows
            // 
            this.ConnectByWindows.AutoSize = true;
            this.ConnectByWindows.Checked = true;
            this.ConnectByWindows.Location = new System.Drawing.Point(22, 19);
            this.ConnectByWindows.Name = "ConnectByWindows";
            this.ConnectByWindows.Size = new System.Drawing.Size(150, 17);
            this.ConnectByWindows.TabIndex = 0;
            this.ConnectByWindows.TabStop = true;
            this.ConnectByWindows.Text = "Авторизация WINDOWS";
            this.ConnectByWindows.UseVisualStyleBackColor = true;
            this.ConnectByWindows.CheckedChanged += new System.EventHandler(this.ConnectByWindows_CheckedChanged);
            // 
            // ConnectBySQL
            // 
            this.ConnectBySQL.AutoSize = true;
            this.ConnectBySQL.Location = new System.Drawing.Point(22, 42);
            this.ConnectBySQL.Name = "ConnectBySQL";
            this.ConnectBySQL.Size = new System.Drawing.Size(134, 17);
            this.ConnectBySQL.TabIndex = 1;
            this.ConnectBySQL.Text = "Авторизация MS SQL";
            this.ConnectBySQL.UseVisualStyleBackColor = true;
            this.ConnectBySQL.CheckedChanged += new System.EventHandler(this.ConnectBySQL_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя пользователя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль:";
            // 
            // Password
            // 
            this.Password.Enabled = false;
            this.Password.Location = new System.Drawing.Point(121, 36);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(135, 20);
            this.Password.TabIndex = 4;
            this.Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_KeyPress);
            // 
            // UserName
            // 
            this.UserName.Enabled = false;
            this.UserName.Location = new System.Drawing.Point(121, 13);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(135, 20);
            this.UserName.TabIndex = 5;
            this.UserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DataSource_KeyPress);
            // 
            // DataSource
            // 
            this.DataSource.Location = new System.Drawing.Point(121, 58);
            this.DataSource.Name = "DataSource";
            this.DataSource.Size = new System.Drawing.Size(135, 20);
            this.DataSource.TabIndex = 7;
            this.DataSource.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DataSource_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Источник данных:";
            // 
            // ConnectionString
            // 
            this.ConnectionString.Location = new System.Drawing.Point(128, 115);
            this.ConnectionString.Name = "ConnectionString";
            this.ConnectionString.Size = new System.Drawing.Size(351, 20);
            this.ConnectionString.TabIndex = 9;
            this.ConnectionString.TextChanged += new System.EventHandler(this.ConnectionString_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Строка подключения:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ConnectBySQL);
            this.groupBox1.Controls.Add(this.ConnectByWindows);
            this.groupBox1.Location = new System.Drawing.Point(9, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 66);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите тип аутентифифакции";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PasswordCheck);
            this.groupBox2.Controls.Add(this.DataSource);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Password);
            this.groupBox2.Controls.Add(this.UserName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(206, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 106);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Введите данные:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "Проверить и подключиться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(291, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 37);
            this.button2.TabIndex = 13;
            this.button2.Text = "Выйти из программы";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PasswordCheck
            // 
            this.PasswordCheck.AutoSize = true;
            this.PasswordCheck.Location = new System.Drawing.Point(121, 83);
            this.PasswordCheck.Name = "PasswordCheck";
            this.PasswordCheck.Size = new System.Drawing.Size(118, 17);
            this.PasswordCheck.TabIndex = 14;
            this.PasswordCheck.Text = "Сохранять пароль";
            this.PasswordCheck.UseVisualStyleBackColor = true;
            // 
            // ConnectionWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 189);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ConnectionString);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConnectionWizard";
            this.ShowIcon = false;
            this.Text = "Мастер подключения";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConnectionWizard_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton ConnectByWindows;
        private System.Windows.Forms.RadioButton ConnectBySQL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox Password;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox DataSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ConnectionString;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox PasswordCheck;
    }
}