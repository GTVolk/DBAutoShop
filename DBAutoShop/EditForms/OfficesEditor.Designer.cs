namespace DBAutoShop.EditForms
{
    partial class OfficesEditor
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OfficeNameEdit = new System.Windows.Forms.TextBox();
            this.AddressEdit = new System.Windows.Forms.TextBox();
            this.TelephoneEdit = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название: *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Адрес: *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Телефон: *";
            // 
            // OfficeNameEdit
            // 
            this.OfficeNameEdit.Location = new System.Drawing.Point(85, 6);
            this.OfficeNameEdit.MaxLength = 50;
            this.OfficeNameEdit.Name = "OfficeNameEdit";
            this.OfficeNameEdit.Size = new System.Drawing.Size(189, 20);
            this.OfficeNameEdit.TabIndex = 3;
            // 
            // AddressEdit
            // 
            this.AddressEdit.Location = new System.Drawing.Point(85, 37);
            this.AddressEdit.MaxLength = 150;
            this.AddressEdit.Name = "AddressEdit";
            this.AddressEdit.Size = new System.Drawing.Size(283, 20);
            this.AddressEdit.TabIndex = 4;
            // 
            // TelephoneEdit
            // 
            this.TelephoneEdit.Location = new System.Drawing.Point(85, 63);
            this.TelephoneEdit.MaxLength = 11;
            this.TelephoneEdit.Name = "TelephoneEdit";
            this.TelephoneEdit.Size = new System.Drawing.Size(146, 20);
            this.TelephoneEdit.TabIndex = 5;
            this.TelephoneEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelephoneEdit_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Принять";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(258, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "Отменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // OfficesEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 132);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TelephoneEdit);
            this.Controls.Add(this.AddressEdit);
            this.Controls.Add(this.OfficeNameEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OfficesEditor";
            this.ShowIcon = false;
            this.Text = "Добавление офиса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OfficeNameEdit;
        private System.Windows.Forms.TextBox AddressEdit;
        private System.Windows.Forms.TextBox TelephoneEdit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}