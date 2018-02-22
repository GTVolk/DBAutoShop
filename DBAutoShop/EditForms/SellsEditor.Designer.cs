namespace DBAutoShop.EditForms
{
    partial class SellsEditor
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
            this.AutoCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NoBody = new System.Windows.Forms.TextBox();
            this.NoEngine = new System.Windows.Forms.TextBox();
            this.NoPTC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ClientCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AutoCost = new System.Windows.Forms.TextBox();
            this.Discount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SellCost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Warranty = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SellDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.WorkerCombo = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Office = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Автомобиль: *";
            // 
            // AutoCombo
            // 
            this.AutoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AutoCombo.FormattingEnabled = true;
            this.AutoCombo.Location = new System.Drawing.Point(98, 31);
            this.AutoCombo.Name = "AutoCombo";
            this.AutoCombo.Size = new System.Drawing.Size(175, 21);
            this.AutoCombo.TabIndex = 1;
            this.AutoCombo.SelectedIndexChanged += new System.EventHandler(this.AutoCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "№ кузова:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "№ двигателя:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(513, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "№ ПТС:";
            // 
            // NoBody
            // 
            this.NoBody.Location = new System.Drawing.Point(279, 31);
            this.NoBody.Name = "NoBody";
            this.NoBody.ReadOnly = true;
            this.NoBody.Size = new System.Drawing.Size(100, 20);
            this.NoBody.TabIndex = 5;
            // 
            // NoEngine
            // 
            this.NoEngine.Location = new System.Drawing.Point(385, 31);
            this.NoEngine.Name = "NoEngine";
            this.NoEngine.ReadOnly = true;
            this.NoEngine.Size = new System.Drawing.Size(100, 20);
            this.NoEngine.TabIndex = 6;
            // 
            // NoPTC
            // 
            this.NoPTC.Location = new System.Drawing.Point(491, 31);
            this.NoPTC.Name = "NoPTC";
            this.NoPTC.ReadOnly = true;
            this.NoPTC.Size = new System.Drawing.Size(100, 20);
            this.NoPTC.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Покупатель: *";
            // 
            // ClientCombo
            // 
            this.ClientCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClientCombo.FormattingEnabled = true;
            this.ClientCombo.Location = new System.Drawing.Point(98, 58);
            this.ClientCombo.Name = "ClientCombo";
            this.ClientCombo.Size = new System.Drawing.Size(175, 21);
            this.ClientCombo.TabIndex = 9;
            this.ClientCombo.SelectedIndexChanged += new System.EventHandler(this.ClientCombo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Цена автомобиля:";
            // 
            // AutoCost
            // 
            this.AutoCost.Location = new System.Drawing.Point(381, 67);
            this.AutoCost.Name = "AutoCost";
            this.AutoCost.ReadOnly = true;
            this.AutoCost.Size = new System.Drawing.Size(162, 20);
            this.AutoCost.TabIndex = 11;
            // 
            // Discount
            // 
            this.Discount.Location = new System.Drawing.Point(639, 67);
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            this.Discount.Size = new System.Drawing.Size(58, 20);
            this.Discount.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(586, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Скидка:";
            // 
            // SellCost
            // 
            this.SellCost.Location = new System.Drawing.Point(381, 93);
            this.SellCost.Name = "SellCost";
            this.SellCost.ReadOnly = true;
            this.SellCost.Size = new System.Drawing.Size(162, 20);
            this.SellCost.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(290, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Итоговая цена:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(703, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(549, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "руб.  -";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(553, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "руб.";
            // 
            // Warranty
            // 
            this.Warranty.Location = new System.Drawing.Point(597, 31);
            this.Warranty.Name = "Warranty";
            this.Warranty.ReadOnly = true;
            this.Warranty.Size = new System.Drawing.Size(74, 20);
            this.Warranty.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(577, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Гарантия на автомобиль:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(677, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "лет";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 46);
            this.button1.TabIndex = 22;
            this.button1.Text = "Принять";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(562, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 46);
            this.button2.TabIndex = 23;
            this.button2.Text = "Отменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SellDatePicker
            // 
            this.SellDatePicker.Location = new System.Drawing.Point(381, 145);
            this.SellDatePicker.Name = "SellDatePicker";
            this.SellDatePicker.Size = new System.Drawing.Size(162, 20);
            this.SellDatePicker.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(288, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Дата покупки: *";
            // 
            // WorkerCombo
            // 
            this.WorkerCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WorkerCombo.FormattingEnabled = true;
            this.WorkerCombo.Location = new System.Drawing.Point(98, 85);
            this.WorkerCombo.Name = "WorkerCombo";
            this.WorkerCombo.Size = new System.Drawing.Size(175, 21);
            this.WorkerCombo.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 88);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Продавец: *";
            // 
            // Office
            // 
            this.Office.Location = new System.Drawing.Point(381, 119);
            this.Office.Name = "Office";
            this.Office.ReadOnly = true;
            this.Office.Size = new System.Drawing.Size(162, 20);
            this.Office.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(290, 120);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Офис продажи:";
            // 
            // SellsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 181);
            this.Controls.Add(this.Office);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.WorkerCombo);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.SellDatePicker);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Warranty);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SellCost);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AutoCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ClientCombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NoPTC);
            this.Controls.Add(this.NoEngine);
            this.Controls.Add(this.NoBody);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AutoCombo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SellsEditor";
            this.ShowIcon = false;
            this.Text = "Добавление покупки...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AutoCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NoBody;
        private System.Windows.Forms.TextBox NoEngine;
        private System.Windows.Forms.TextBox NoPTC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ClientCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AutoCost;
        private System.Windows.Forms.TextBox Discount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SellCost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Warranty;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker SellDatePicker;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox WorkerCombo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Office;
        private System.Windows.Forms.Label label16;
    }
}