namespace DBAutoShop.EditForms
{
    partial class ClientsEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.FamilyEdit = new System.Windows.Forms.TextBox();
            this.NameEdit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SurnameEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TelephoneEdit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddressEdit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия: *";
            // 
            // FamilyEdit
            // 
            this.FamilyEdit.Location = new System.Drawing.Point(79, 12);
            this.FamilyEdit.MaxLength = 50;
            this.FamilyEdit.Name = "FamilyEdit";
            this.FamilyEdit.Size = new System.Drawing.Size(130, 20);
            this.FamilyEdit.TabIndex = 1;
            // 
            // NameEdit
            // 
            this.NameEdit.Location = new System.Drawing.Point(79, 38);
            this.NameEdit.MaxLength = 50;
            this.NameEdit.Name = "NameEdit";
            this.NameEdit.Size = new System.Drawing.Size(130, 20);
            this.NameEdit.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя: *";
            // 
            // SurnameEdit
            // 
            this.SurnameEdit.Location = new System.Drawing.Point(79, 64);
            this.SurnameEdit.MaxLength = 50;
            this.SurnameEdit.Name = "SurnameEdit";
            this.SurnameEdit.Size = new System.Drawing.Size(130, 20);
            this.SurnameEdit.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчество: *";
            // 
            // TelephoneEdit
            // 
            this.TelephoneEdit.Location = new System.Drawing.Point(79, 90);
            this.TelephoneEdit.MaxLength = 11;
            this.TelephoneEdit.Name = "TelephoneEdit";
            this.TelephoneEdit.Size = new System.Drawing.Size(130, 20);
            this.TelephoneEdit.TabIndex = 9;
            this.TelephoneEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelephoneEdit_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Телефон: *";
            // 
            // AddressEdit
            // 
            this.AddressEdit.Location = new System.Drawing.Point(79, 116);
            this.AddressEdit.MaxLength = 150;
            this.AddressEdit.Name = "AddressEdit";
            this.AddressEdit.Size = new System.Drawing.Size(269, 20);
            this.AddressEdit.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Адрес: *";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Принять";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(238, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 34);
            this.button2.TabIndex = 13;
            this.button2.Text = "Отменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ClientsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 192);
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
            this.Name = "ClientsEditor";
            this.ShowIcon = false;
            this.Text = "Добавление клиента...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FamilyEdit;
        private System.Windows.Forms.TextBox NameEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SurnameEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TelephoneEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AddressEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}