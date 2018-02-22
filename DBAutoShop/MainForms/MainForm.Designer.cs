namespace DBAutoShop
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonWorkers = new System.Windows.Forms.Button();
            this.buttonPresenceCars = new System.Windows.Forms.Button();
            this.buttonAutomobilesData = new System.Windows.Forms.Button();
            this.buttonSells = new System.Windows.Forms.Button();
            this.buttonSelledCars = new System.Windows.Forms.Button();
            this.buttonOffices = new System.Windows.Forms.Button();
            this.buttonClients = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выводВXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.импортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.импортТаблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортТаблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FullTextSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.InfoString = new System.Windows.Forms.TextBox();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(835, 461);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonWorkers);
            this.groupBox1.Controls.Add(this.buttonPresenceCars);
            this.groupBox1.Controls.Add(this.buttonAutomobilesData);
            this.groupBox1.Controls.Add(this.buttonSells);
            this.groupBox1.Controls.Add(this.buttonSelledCars);
            this.groupBox1.Controls.Add(this.buttonOffices);
            this.groupBox1.Controls.Add(this.buttonClients);
            this.groupBox1.Location = new System.Drawing.Point(853, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 321);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Категория";
            // 
            // buttonWorkers
            // 
            this.buttonWorkers.Location = new System.Drawing.Point(7, 247);
            this.buttonWorkers.Name = "buttonWorkers";
            this.buttonWorkers.Size = new System.Drawing.Size(158, 32);
            this.buttonWorkers.TabIndex = 6;
            this.buttonWorkers.Text = "Работники";
            this.buttonWorkers.UseVisualStyleBackColor = true;
            this.buttonWorkers.Click += new System.EventHandler(this.button10_Click);
            // 
            // buttonPresenceCars
            // 
            this.buttonPresenceCars.Location = new System.Drawing.Point(6, 133);
            this.buttonPresenceCars.Name = "buttonPresenceCars";
            this.buttonPresenceCars.Size = new System.Drawing.Size(158, 32);
            this.buttonPresenceCars.TabIndex = 5;
            this.buttonPresenceCars.Text = "Автомобили в наличие";
            this.buttonPresenceCars.UseVisualStyleBackColor = true;
            this.buttonPresenceCars.Click += new System.EventHandler(this.button9_Click);
            // 
            // buttonAutomobilesData
            // 
            this.buttonAutomobilesData.Location = new System.Drawing.Point(6, 19);
            this.buttonAutomobilesData.Name = "buttonAutomobilesData";
            this.buttonAutomobilesData.Size = new System.Drawing.Size(158, 32);
            this.buttonAutomobilesData.TabIndex = 0;
            this.buttonAutomobilesData.Text = "Автомобили";
            this.buttonAutomobilesData.UseVisualStyleBackColor = true;
            this.buttonAutomobilesData.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSells
            // 
            this.buttonSells.Location = new System.Drawing.Point(6, 209);
            this.buttonSells.Name = "buttonSells";
            this.buttonSells.Size = new System.Drawing.Size(158, 32);
            this.buttonSells.TabIndex = 4;
            this.buttonSells.Text = "Продажи";
            this.buttonSells.UseVisualStyleBackColor = true;
            this.buttonSells.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonSelledCars
            // 
            this.buttonSelledCars.Location = new System.Drawing.Point(6, 171);
            this.buttonSelledCars.Name = "buttonSelledCars";
            this.buttonSelledCars.Size = new System.Drawing.Size(158, 32);
            this.buttonSelledCars.TabIndex = 3;
            this.buttonSelledCars.Text = "Проданные автомобили";
            this.buttonSelledCars.UseVisualStyleBackColor = true;
            this.buttonSelledCars.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonOffices
            // 
            this.buttonOffices.Location = new System.Drawing.Point(6, 95);
            this.buttonOffices.Name = "buttonOffices";
            this.buttonOffices.Size = new System.Drawing.Size(158, 32);
            this.buttonOffices.TabIndex = 2;
            this.buttonOffices.Text = "Офисы продаж";
            this.buttonOffices.UseVisualStyleBackColor = true;
            this.buttonOffices.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonClients
            // 
            this.buttonClients.Location = new System.Drawing.Point(6, 57);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(158, 32);
            this.buttonClients.TabIndex = 1;
            this.buttonClients.Text = "Клиенты";
            this.buttonClients.UseVisualStyleBackColor = true;
            this.buttonClients.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1030, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выводВXMLToolStripMenuItem,
            this.отчетToolStripMenuItem,
            this.toolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выводВXMLToolStripMenuItem
            // 
            this.выводВXMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.импортToolStripMenuItem,
            this.экспортToolStripMenuItem,
            this.импортТаблицыToolStripMenuItem,
            this.экспортТаблицыToolStripMenuItem});
            this.выводВXMLToolStripMenuItem.Name = "выводВXMLToolStripMenuItem";
            this.выводВXMLToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.выводВXMLToolStripMenuItem.Text = "XML";
            // 
            // импортToolStripMenuItem
            // 
            this.импортToolStripMenuItem.Name = "импортToolStripMenuItem";
            this.импортToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.импортToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.импортToolStripMenuItem.Text = "Импорт базы";
            this.импортToolStripMenuItem.Click += new System.EventHandler(this.XMLImportDatabaseToolStripMenuItem_Click);
            // 
            // экспортToolStripMenuItem
            // 
            this.экспортToolStripMenuItem.Name = "экспортToolStripMenuItem";
            this.экспортToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.экспортToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.экспортToolStripMenuItem.Text = "Экспорт базы";
            this.экспортToolStripMenuItem.Click += new System.EventHandler(this.XMLExportDatabaseToolStripMenuItem_Click);
            // 
            // импортТаблицыToolStripMenuItem
            // 
            this.импортТаблицыToolStripMenuItem.Name = "импортТаблицыToolStripMenuItem";
            this.импортТаблицыToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.импортТаблицыToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.импортТаблицыToolStripMenuItem.Text = "Импорт таблицы";
            this.импортТаблицыToolStripMenuItem.Click += new System.EventHandler(this.XMLImportTableToolStripMenuItem_Click);
            // 
            // экспортТаблицыToolStripMenuItem
            // 
            this.экспортТаблицыToolStripMenuItem.Name = "экспортТаблицыToolStripMenuItem";
            this.экспортТаблицыToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.экспортТаблицыToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.экспортТаблицыToolStripMenuItem.Text = "Экспорт таблицы";
            this.экспортТаблицыToolStripMenuItem.Click += new System.EventHandler(this.XMLExportTableToolStripMenuItem_Click);
            // 
            // отчетToolStripMenuItem
            // 
            this.отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            this.отчетToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.отчетToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.отчетToolStripMenuItem.Text = "Отчет";
            this.отчетToolStripMenuItem.Click += new System.EventHandler(this.ExportReportToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(146, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FullTextSearchToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // FullTextSearchToolStripMenuItem
            // 
            this.FullTextSearchToolStripMenuItem.Name = "FullTextSearchToolStripMenuItem";
            this.FullTextSearchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.FullTextSearchToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.FullTextSearchToolStripMenuItem.Text = "Полнотекстовый поиск";
            this.FullTextSearchToolStripMenuItem.Click += new System.EventHandler(this.FullTextSearchToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.информацияToolStripMenuItem.Text = "Информация";
            this.информацияToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.buttonUpdate);
            this.groupBox2.Controls.Add(this.buttonInsert);
            this.groupBox2.Location = new System.Drawing.Point(853, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 152);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Действия";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(6, 105);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(158, 37);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(6, 62);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(158, 37);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Изменить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(6, 19);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(158, 37);
            this.buttonInsert.TabIndex = 0;
            this.buttonInsert.Text = "Добавить";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // InfoString
            // 
            this.InfoString.Location = new System.Drawing.Point(12, 494);
            this.InfoString.Name = "InfoString";
            this.InfoString.ReadOnly = true;
            this.InfoString.Size = new System.Drawing.Size(835, 20);
            this.InfoString.TabIndex = 4;
            // 
            // buttonOrders
            // 
            this.buttonOrders.Location = new System.Drawing.Point(860, 324);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(158, 32);
            this.buttonOrders.TabIndex = 7;
            this.buttonOrders.Text = "Заказы";
            this.buttonOrders.UseVisualStyleBackColor = true;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 518);
            this.Controls.Add(this.buttonOrders);
            this.Controls.Add(this.InfoString);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Авто-фирма М-АВТО";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSells;
        private System.Windows.Forms.Button buttonSelledCars;
        private System.Windows.Forms.Button buttonOffices;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonAutomobilesData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выводВXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem импортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem импортТаблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортТаблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox InfoString;
        private System.Windows.Forms.Button buttonWorkers;
        private System.Windows.Forms.Button buttonPresenceCars;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FullTextSearchToolStripMenuItem;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

