namespace DBAutoShop.EditForms
{
    partial class WorkersEditor
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AddressEdit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TelephoneEdit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SurnameEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NameEdit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FamilyEdit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.WorkplaceCombo = new System.Windows.Forms.ComboBox();
            this.OfficeCombo = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(282, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 34);
            this.button2.TabIndex = 25;
            this.button2.Text = "Отменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 24;
            this.button1.Text = "Принять";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddressEdit
            // 
            this.AddressEdit.Location = new System.Drawing.Point(120, 176);
            this.AddressEdit.MaxLength = 150;
            this.AddressEdit.Name = "AddressEdit";
            this.AddressEdit.Size = new System.Drawing.Size(269, 20);
            this.AddressEdit.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Адрес: *";
            // 
            // TelephoneEdit
            // 
            this.TelephoneEdit.Location = new System.Drawing.Point(120, 149);
            this.TelephoneEdit.MaxLength = 11;
            this.TelephoneEdit.Name = "TelephoneEdit";
            this.TelephoneEdit.Size = new System.Drawing.Size(130, 20);
            this.TelephoneEdit.TabIndex = 21;
            this.TelephoneEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelephoneEdit_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Телефон: *";
            // 
            // SurnameEdit
            // 
            this.SurnameEdit.Location = new System.Drawing.Point(120, 66);
            this.SurnameEdit.MaxLength = 50;
            this.SurnameEdit.Name = "SurnameEdit";
            this.SurnameEdit.Size = new System.Drawing.Size(149, 20);
            this.SurnameEdit.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Отчество: *";
            // 
            // NameEdit
            // 
            this.NameEdit.Location = new System.Drawing.Point(120, 39);
            this.NameEdit.MaxLength = 50;
            this.NameEdit.Name = "NameEdit";
            this.NameEdit.Size = new System.Drawing.Size(149, 20);
            this.NameEdit.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Имя: *";
            // 
            // FamilyEdit
            // 
            this.FamilyEdit.Location = new System.Drawing.Point(120, 12);
            this.FamilyEdit.MaxLength = 50;
            this.FamilyEdit.Name = "FamilyEdit";
            this.FamilyEdit.Size = new System.Drawing.Size(149, 20);
            this.FamilyEdit.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Фамилия: *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Должность: *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Название офиса: *";
            // 
            // WorkplaceCombo
            // 
            this.WorkplaceCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WorkplaceCombo.FormattingEnabled = true;
            this.WorkplaceCombo.Location = new System.Drawing.Point(120, 93);
            this.WorkplaceCombo.Name = "WorkplaceCombo";
            this.WorkplaceCombo.Size = new System.Drawing.Size(228, 21);
            this.WorkplaceCombo.TabIndex = 28;
            // 
            // OfficeCombo
            // 
            this.OfficeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OfficeCombo.FormattingEnabled = true;
            this.OfficeCombo.Location = new System.Drawing.Point(120, 121);
            this.OfficeCombo.Name = "OfficeCombo";
            this.OfficeCombo.Size = new System.Drawing.Size(228, 21);
            this.OfficeCombo.TabIndex = 29;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(354, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // WorkersEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 253);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.OfficeCombo);
            this.Controls.Add(this.WorkplaceCombo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddressEdit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TelephoneEdit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SurnameEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FamilyEdit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WorkersEditor";
            this.ShowIcon = false;
            this.Text = "Добавление работника...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox AddressEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TelephoneEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SurnameEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FamilyEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox WorkplaceCombo;
        private System.Windows.Forms.ComboBox OfficeCombo;
        private System.Windows.Forms.Button button3;
    }
}