using System;
using System.Windows.Forms;
using DBAutoShop.Controllers;
using DBAutoShop.ORM;
using DBAutoShop.EditForms;
using DBAutoShop.MainForms;

namespace DBAutoShop
{
    public partial class MainForm : Form
    {
        //Editor Forms
        AutomobilesEditor DBAutomobileEditor;
        ClientsEditor DBClientEditor;
        OfficesEditor DBOfficeEditor;
        OrdersEditor DBOrderEditor;
        PresenceCarsEditor DBPresenceCarEditor;
        SellsEditor DBSellEditor;
        WorkersEditor DBWorkerEditor;

        //Main Forms
        AboutForm About;
        FullTextSearchForm DBFullTextSearchForm;

        //Tables
        AutomobilesData DBAutomobilesData;
        BodyTypes DBBodyTypes;
        Clients DBClients;
        Colors DBColors;
        Countries DBCountries;
        Languages DBLanguages;
        Manafacturers DBManafacturers;
        Offices DBOffices;
        Orders DBOrders;
        PresenceCars DBPresenceCars;
        SelledCars DBSelledCars;
        Sells DBSells;
        Workers DBWorkers;
        Workplaces DBWorkplaces;
        int PageID = 0;
        string TableName = "";

        public MainForm()
        {
            InitializeComponent();

            // ConnectionWizard ConWiz = new ConnectionWizard();
            // ConWiz.StartPosition = FormStartPosition.CenterScreen;
            // ConWiz.ShowDialog();
            PageID = DatabaseControlService.LastPage;

            About = new AboutForm();

            //Editor Forms
            DBAutomobileEditor = new AutomobilesEditor();
            DBClientEditor = new ClientsEditor();
            DBOfficeEditor = new OfficesEditor();
            DBOrderEditor = new OrdersEditor();
            DBPresenceCarEditor = new PresenceCarsEditor();
            DBSellEditor = new SellsEditor();
            DBWorkerEditor = new WorkersEditor();

            //Tables
            DBAutomobilesData = new AutomobilesData();
            DBBodyTypes = new BodyTypes();
            DBClients = new Clients();
            DBColors = new Colors();
            DBCountries = new Countries();
            DBLanguages = new Languages();
            DBManafacturers = new Manafacturers();
            DBOffices = new Offices();
            DBOrders = new Orders();
            DBPresenceCars = new PresenceCars();
            DBSelledCars = new SelledCars();
            DBSells = new Sells();
            DBWorkers = new Workers();
            DBWorkplaces = new Workplaces();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            buttonInsert.Enabled = false;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;

            ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateData(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateData(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateData(3);
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            UpdateData(4);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            UpdateData(5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateData(6);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpdateData(7);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            UpdateData(8);
        }

        public void UpdateButtons()
        {
            if ((dataGridView1.Rows.Count > 0) && (PageID != 6))
            {
                buttonInsert.Enabled = true;
                if (PageID != 7)
                {
                    buttonUpdate.Enabled = true;
                    buttonDelete.Enabled = true;
                }
                else
                {
                    buttonUpdate.Enabled = false;
                    buttonDelete.Enabled = false;
                }
            }
            else
            {
                if (PageID != 6) buttonInsert.Enabled = true;
                else buttonInsert.Enabled = false;
                buttonUpdate.Enabled = false;
                buttonDelete.Enabled = false;
            }
        }

        public void UpdateData(int TableID)
        {
            switch (TableID)
            {
                case 1:
                    {
                        DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBAutomobilesData.ViewAll());

                        PageID = 1;
                        TableName = "Автомобили";

                        DatabaseControlService.DataGridSelectLast(dataGridView1);
                        UpdateButtons();

                        InfoString.Text = "База автомобилей загружена!";
                        break;
                    }
                case 2:
                    {
                        DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBClients.ViewAll());

                        PageID = 2;
                        TableName = "Клиенты";

                        DatabaseControlService.DataGridSelectLast(dataGridView1);
                        UpdateButtons();

                        InfoString.Text = "База клиентов загружена!";
                        break;
                    }
                case 3:
                    {
                        DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBOffices.ViewAll());

                        PageID = 3;
                        TableName = "Офисы продаж";

                        DatabaseControlService.DataGridSelectLast(dataGridView1);
                        UpdateButtons();

                        InfoString.Text = "База офисов продаж загружена!";
                        break;
                    }
                case 4:
                    {
                        DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBOrders.ViewAll());

                        PageID = 4;
                        TableName = "Заказы";

                        DatabaseControlService.DataGridSelectLast(dataGridView1);
                        UpdateButtons();


                        InfoString.Text = "База заказов загружена!";
                        break;
                    }
                case 5:
                    {
                        DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBPresenceCars.ViewAll());

                        PageID = 5;
                        TableName = "Автомобили в наличие";

                        DatabaseControlService.DataGridSelectLast(dataGridView1);
                        UpdateButtons();


                        InfoString.Text = "База автомобилей в наличии загружена!";
                        break;
                    }
                case 6:
                    {
                        DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBSelledCars.ViewAll());

                        PageID = 6;
                        TableName = "Проданные автомобили";

                        DatabaseControlService.DataGridSelectLast(dataGridView1);
                        UpdateButtons();


                        InfoString.Text = "База проданных автомобилей загружена!";
                        break;
                    }
                case 7:
                    {
                        DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBSells.ViewAll());

                        PageID = 7;
                        TableName = "Продажи";

                        DatabaseControlService.DataGridSelectLast(dataGridView1);
                        UpdateButtons();


                        InfoString.Text = "База продаж загружена!";
                        break;
                    }
                case 8:
                    {
                        DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBWorkers.ViewAll());

                        PageID = 8;
                        TableName = "Работники";

                        DatabaseControlService.DataGridSelectLast(dataGridView1);
                        UpdateButtons();


                        InfoString.Text = "База работников загружена!";
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            switch (PageID)
            {
                case 1:
                    {
                        DBAutomobileEditor.CallInsert();
                        DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBAutomobilesData.ViewAll());
                        DatabaseControlService.DataGridSelectLast(dataGridView1);
                        UpdateButtons();
                        break;
                    }
                case 2:
                    {
                        DBClientEditor.CallInsert();
                        DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBClients.ViewAll());
                        DatabaseControlService.DataGridSelectLast(dataGridView1);
                        UpdateButtons();
                        break;
                    }
                case 3:
                    {
                        DBOfficeEditor.CallInsert();
                        DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBOffices.ViewAll());
                        DatabaseControlService.DataGridSelectLast(dataGridView1);
                        UpdateButtons();
                        break;
                    }
                case 4:
                    {
                        DBOrderEditor.CallInsert();
                        DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBOrders.ViewAll());
                        DatabaseControlService.DataGridSelectLast(dataGridView1);
                        UpdateButtons();
                        break;
                    }
                case 5:
                    {
                        DBPresenceCarEditor.CallInsert();
                        DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBPresenceCars.ViewAll());
                        DatabaseControlService.DataGridSelectLast(dataGridView1);
                        UpdateButtons();
                        break;
                    }
                case 7:
                    {
                        DBSellEditor.CallInsert();
                        DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBSells.ViewAll());
                        DatabaseControlService.DataGridSelectLast(dataGridView1);
                        UpdateButtons();
                        break;
                    }
                case 8:
                    {
                        DBWorkerEditor.CallInsert();
                        DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBWorkers.ViewAll());
                        DatabaseControlService.DataGridSelectLast(dataGridView1);
                        UpdateButtons();
                        break;
                    }
                default:
                    {
                        MessageBox.Show("О неееееееет!!!!!!!", "Гипер-пупер ошибка века!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            switch (PageID)
            {
                case 1:
                    {
                        DBAutomobileEditor.CallEdit(dataGridView1);
                        DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBAutomobilesData.ViewAll());
                        DatabaseControlService.DataGridSelectLast(dataGridView1);
                        break;
                    }
                case 2:
                    {
                        DBClientEditor.CallEdit(dataGridView1);
                        DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBClients.ViewAll());
                        DatabaseControlService.DataGridSelectLast(dataGridView1);
                        break;
                    }
                case 3:
                    {
                        DBOfficeEditor.CallEdit(dataGridView1);
                        DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBOffices.ViewAll());
                        DatabaseControlService.DataGridSelectLast(dataGridView1);
                        break;
                    }
                case 4:
                    {
                        DBOrderEditor.CallEdit(dataGridView1);
                        DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBOrders.ViewAll());
                        DatabaseControlService.DataGridSelectLast(dataGridView1);
                        break;
                    }
                case 5:
                    {
                        DBPresenceCarEditor.CallEdit(dataGridView1);
                        DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBPresenceCars.ViewAll());
                        DatabaseControlService.DataGridSelectLast(dataGridView1);
                        break;
                    }
                case 8:
                    {
                        DBWorkerEditor.CallEdit(dataGridView1);
                        DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBWorkers.ViewAll());
                        DatabaseControlService.DataGridSelectLast(dataGridView1);
                        break;
                    }
                default:
                    {
                        MessageBox.Show("О неееееееет!!!!!!!", "Гипер-пупер ошибка века!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            switch (PageID)
            {
                case 1:
                    {
                        DBAutomobilesData.LoadData(dataGridView1);
                        if (!DBAutomobilesData.CheckUse())
                        {
                            DatabaseControlService.SQL.SqlProcduceTransactionCommand(DBAutomobilesData.Delete());
                            DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBAutomobilesData.ViewAll());
                            DatabaseControlService.DataGridSelectLast(dataGridView1);
                            UpdateButtons();
                        }
                        else
                        {
                            MessageBox.Show("Элемент используется! Удаление невозможно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
                case 2:
                    {
                        DBClients.LoadData(dataGridView1);
                        if (!DBClients.CheckUse())
                        {
                            DatabaseControlService.SQL.SqlProcduceTransactionCommand(DBClients.Delete());
                            DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBClients.ViewAll());
                            DatabaseControlService.DataGridSelectLast(dataGridView1);
                            UpdateButtons();
                        }
                        else
                        {
                            MessageBox.Show("Элемент используется! Удаление невозможно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
                case 3:
                    {
                        DBOffices.LoadData(dataGridView1);
                        if (!DBOffices.CheckUse())
                        {
                            DatabaseControlService.SQL.SqlProcduceTransactionCommand(DBOffices.Delete());
                            DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBOffices.ViewAll());
                            DatabaseControlService.DataGridSelectLast(dataGridView1);
                            UpdateButtons();
                        }
                        else
                        {
                            MessageBox.Show("Элемент используется! Удаление невозможно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
                case 4:
                    {
                        DBOrders.LoadData(dataGridView1);
                        if (!DBOrders.CheckUse())
                        {
                            DatabaseControlService.SQL.SqlProcduceTransactionCommand(DBOrders.Delete());
                            DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBOrders.ViewAll());
                            DatabaseControlService.DataGridSelectLast(dataGridView1);
                            UpdateButtons();
                        }
                        else
                        {
                            MessageBox.Show("Элемент используется! Удаление невозможно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
                case 5:
                    {
                        DBPresenceCars.LoadData(dataGridView1);
                        if (!DBPresenceCars.CheckUse())
                        {
                            DatabaseControlService.SQL.SqlProcduceTransactionCommand(DBPresenceCars.Delete());
                            DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBPresenceCars.ViewAll());
                            DatabaseControlService.DataGridSelectLast(dataGridView1);
                            UpdateButtons();
                        }
                        else
                        {
                            MessageBox.Show("Элемент используется! Удаление невозможно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
                case 7:
                    {
                        DBSells.LoadData(dataGridView1);
                        if (!DBSells.CheckUse())
                        {
                            DatabaseControlService.SQL.SqlProcduceTransactionCommand(DBSells.Delete());
                            DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBSells.ViewAll());
                            DatabaseControlService.DataGridSelectLast(dataGridView1);
                            UpdateButtons();
                        }
                        else
                        {
                            MessageBox.Show("Элемент используется! Удаление невозможно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
                case 8:
                    {
                        DBWorkers.LoadData(dataGridView1);
                        if (!DBWorkers.CheckUse())
                        {
                            DatabaseControlService.SQL.SqlProcduceTransactionCommand(DBWorkers.Delete());
                            DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBWorkers.ViewAll());
                            DatabaseControlService.DataGridSelectLast(dataGridView1);
                            UpdateButtons();
                        }
                        else
                        {
                            MessageBox.Show("Элемент используется! Удаление невозможно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
                default:
                    {
                        MessageBox.Show("О неееееееет!!!!!!!", "Гипер-пупер ошибка века!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
            }
        }

        public static void FullTextSearchResult(DataGridView DG, int TableID, string SearchString, int CountRecords)
        {
            DatabaseControlService.DBFullTextSearch.Table_ID = TableID;
            DatabaseControlService.DBFullTextSearch.Search_String = SearchString;
            DatabaseControlService.DBFullTextSearch.Count_Records = CountRecords;

            DatabaseControlService.SQL.SqlProcduceCommand(DG, DatabaseControlService.DBFullTextSearch.Query());
        }

        private void FullTextSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PageID > 0)
            {
                DBFullTextSearchForm = new FullTextSearchForm();
                DBFullTextSearchForm.Call(dataGridView1, PageID);

                buttonInsert.Enabled = false;
                buttonUpdate.Enabled = false;
                buttonDelete.Enabled = false;
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About = new AboutForm();

            About.Show();
        }

        private void XMLExportDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseControlService.XML.XML_SaveDATABASE();
            UpdateData(PageID);
            MessageBox.Show("Экспорт базы завершен успешно!", "Поздравляем", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void XMLImportDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseControlService.XML.XML_LoadDATABASE();
            UpdateData(PageID);
            MessageBox.Show("Импорт базы завершен успешно!", "Поздравляем", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void XMLExportTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseControlService.XML.XML_SaveTABLE(PageID);
            UpdateData(PageID);
            MessageBox.Show("Экспорт таблицы завершен успешно!", "Поздравляем", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void XMLImportTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseControlService.XML.XML_LoadTABLE(PageID);
            UpdateData(PageID);
            MessageBox.Show("Импорт таблицы завершен успешно!", "Поздравляем", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExportReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (PageID != 0)
            {
                saveFileDialog1.FileName = TableName;
                saveFileDialog1.Filter = "Документ Microsoft Office Excel 2003|*.xls";
                saveFileDialog1.InitialDirectory = Application.ExecutablePath;
                saveFileDialog1.Title = "Сохранить отчет как...";
                if ((saveFileDialog1.ShowDialog() == DialogResult.OK) && (saveFileDialog1.FileName != ""))
                    DatabaseControlService.Report.ToXLS(dataGridView1, saveFileDialog1.FileName);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DatabaseControlService.LastPage = PageID;
            DatabaseControlService.WriteINI();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (PageID != 0)
                UpdateData(PageID);
        }
    }
}
