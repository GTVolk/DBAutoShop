namespace DBAutoShop.EditForms
{
    partial class CountriesEditor
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
            this.CountryNameEdit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LanguageCombo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CountryNameEdit
            // 
            this.CountryNameEdit.Location = new System.Drawing.Point(83, 12);
            this.CountryNameEdit.MaxLength = 50;
            this.CountryNameEdit.Name = "CountryNameEdit";
            this.CountryNameEdit.Size = new System.Drawing.Size(189, 20);
            this.CountryNameEdit.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название: *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Язык: *";
            // 
            // LanguageCombo
            // 
            this.LanguageCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageCombo.FormattingEnabled = true;
            this.LanguageCombo.Location = new System.Drawing.Point(83, 38);
            this.LanguageCombo.Name = "LanguageCombo";
            this.LanguageCombo.Size = new System.Drawing.Size(153, 21);
            this.LanguageCombo.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "Принять";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(150, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 44);
            this.button2.TabIndex = 9;
            this.button2.Text = "Отменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(242, 38);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CountriesEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 117);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LanguageCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CountryNameEdit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CountriesEditor";
            this.ShowIcon = false;
            this.Text = "Добавить страну...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CountryNameEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox LanguageCombo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}