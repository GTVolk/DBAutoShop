using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DBAutoShop.Controllers;
using DBAutoShop.ORM;

namespace DBAutoShop.EditForms
{
    public partial class SellsEditor : Form
    {
        int EditorMode = 1;
        int AutoIndex = 0;

        Sells DB;
        SelledCars DBSelledCars;
        PresenceCars DBPresenceCars;
        AutomobilesData DBAutomobilesData;
        List<int> IndexMassiveAuto;
        List<int> IndexMassiveClients;
        List<int> IndexMassiveWorkers;

        public SellsEditor()
        {
            InitializeComponent();

            IndexMassiveAuto = new List<int>();
            IndexMassiveClients = new List<int>();
            IndexMassiveWorkers = new List<int>();

            DB = new Sells();
            DBAutomobilesData = new AutomobilesData();
            DBPresenceCars = new PresenceCars();
            DBSelledCars = new SelledCars();
        }

        public void LoadData()
        {
            if (EditorMode == 0) DB.Sell_ID = 0;
            DB.Sell_ID = AutoIndex;
            DB.LoadData();
            DB.Client_ID = IndexMassiveClients[ClientCombo.SelectedIndex];
            DB.Worker_ID = IndexMassiveWorkers[WorkerCombo.SelectedIndex];
            DB.Sell_Date = SellDatePicker.Value;
            DB.Selled_Check = 1; 
        }

        public bool CheckData()
        {
            LoadData();
            if (AutoCombo.SelectedIndex == -1) { MessageBox.Show("Выберите Автомобиль из таблицы присутствующих автомобилей!"); return false; }
            if (ClientCombo.SelectedIndex == -1) { MessageBox.Show("Выберите Клиента из таблицы клиентов!"); return false; }
            if (WorkerCombo.SelectedIndex == -1) { MessageBox.Show("Выберите Продавца из таблицы работников!"); return false; }
            return true;
        }

        public void FormReset()
        {
            SellDatePicker.Value = DateTime.Now;
            Office.Text = "";
            Discount.Text = "";
            AutoCost.Text = "";
            SellCost.Text = "";
            NoBody.Text = "";
            NoEngine.Text = "";
            NoPTC.Text = "";

        }

        public void FormStart()
        {
            AutoCombo.Items.Clear();
            ClientCombo.Items.Clear();
            WorkerCombo.Items.Clear();
            DatabaseControlService.LoadComboData("SELECT Sell_ID,ManafacturerName,Model,ColorName FROM dbo.Sells INNER JOIN dbo.AutomobilesData ON dbo.Sells.Auto_ID = dbo.AutomobilesData.Auto_ID INNER JOIN dbo.Colors ON dbo.Sells.Color_ID = dbo.Colors.Color_ID INNER JOIN dbo.Manafacturers ON dbo.AutomobilesData.Manafacturer_ID = dbo.Manafacturers.Manafacturer_ID", AutoCombo, IndexMassiveAuto);
            DatabaseControlService.LoadComboData("SELECT Client_ID,Family,Name,Surname FROM Clients", ClientCombo, IndexMassiveClients);
        }

        public void CallInsert()
        {
            EditorMode = 0;

            FormStart();
            DB.Reset();
            FormReset();

            this.Text = "Оформление продажи...";
            this.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                DatabaseControlService.SQL.SqlProcduceTransactionCommand(DB.Update());
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AutoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AutoCombo.SelectedIndex != -1)
            {
                string No_PTC = "";
                string Query = "SELECT No_PTC FROM Sells WHERE Sell_ID = " + IndexMassiveAuto[AutoCombo.SelectedIndex];
                DatabaseControlService.SQL.SqlProcduceCommand(Query);
                if (DatabaseControlService.SQL.DataTableHasValues())
                    No_PTC = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][0].ToString();
                Query = "SELECT Sell_ID,No_body, No_engine, No_PTC, Warranty, Cost, Office_Name FROM dbo.Sells INNER JOIN dbo.AutomobilesData ON dbo.Sells.Auto_ID = dbo.AutomobilesData.Auto_ID INNER JOIN dbo.Offices ON dbo.Sells.Office_ID = dbo.Offices.Office_ID WHERE No_PTC = '" + No_PTC + "'";
                DatabaseControlService.SQL.SqlProcduceCommand(Query);

                if (DatabaseControlService.SQL.DataTableHasValues())
                {
                    AutoIndex = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][0].ToString());
                    NoBody.Text = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][1].ToString();
                    NoEngine.Text = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][2].ToString();
                    NoPTC.Text = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][3].ToString();
                    Warranty.Text = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][4].ToString();
                    AutoCost.Text = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][5].ToString();
                    Office.Text = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][6].ToString();

                    WorkerCombo.Items.Clear();
                    DatabaseControlService.LoadComboData("SELECT Worker_ID, Family, Name, Surname FROM Workers WHERE Office_ID = " + DatabaseControlService.DBECS.GetOfficeIDByOfficeName(Office.Text), WorkerCombo, IndexMassiveWorkers);
                }
            }
            else
            {
                Discount.Text = "";
                SellCost.Text = "";
            }
        }

        private void ClientCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClientCombo.SelectedIndex != -1)
            {
                string Query = "SELECT Discount FROM Clients WHERE Client_ID = " + IndexMassiveClients[ClientCombo.SelectedIndex];
                DatabaseControlService.SQL.SqlProcduceCommand(Query);
                if (DatabaseControlService.SQL.DataTableHasValues())
                {
                    double _disc = Convert.ToDouble(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][0].ToString());
                    Discount.Text = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][0].ToString();

                    if (AutoCost.Text != "")
                    {
                        double _cost = Convert.ToDouble(AutoCost.Text);
                        double _sellcost = _cost - (_cost * (_disc / 100));
                        SellCost.Text = _sellcost.ToString();
                    }
                }
            }
            else
            {
                Office.Text = "";
                AutoCost.Text = "";
                SellCost.Text = "";
                NoBody.Text = "";
                NoEngine.Text = "";
                NoPTC.Text = "";
                WorkerCombo.Items.Clear();
            }
        }
    }
}
