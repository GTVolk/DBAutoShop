using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DBAutoShop.Controllers;
using DBAutoShop.ORM;

namespace DBAutoShop.EditForms
{
    public partial class OrdersEditor : Form
    {
        int EditorMode = 0;

        Orders DB;
        List<int> IndexMassiveAuto;
        List<int> IndexMassiveClients;

        public OrdersEditor()
        {
            InitializeComponent();

            DB = new Orders();
            IndexMassiveAuto = new List<int>();
            IndexMassiveClients = new List<int>();
        }

        public void LoadData()
        {
            if (EditorMode == 0) DB.Order_ID = 0;
            DB.Order_Date = OrderDatePicker.Value;
            DB.Auto_ID = IndexMassiveAuto[AutoCombo.SelectedIndex];
            DB.Client_ID = IndexMassiveClients[ClientCombo.SelectedIndex];
            DB.Order_Condition = OrderConditionEdit.Text;
        }

        public bool CheckData()
        {
            LoadData();
            if (AutoCombo.SelectedIndex == -1) { MessageBox.Show("Выберите Автомобиль из таблицы автомобилей!"); return false; }
            if (ClientCombo.SelectedIndex == -1) { MessageBox.Show("Выберите Клиента из таблицы клиентов!"); return false; }
            if (OrderConditionEdit.Text == "") { MessageBox.Show("Заполните поле Состояние заказа!"); return false; }
            return true;
        }

        public void FormLoad()
        {
            OrderDatePicker.Value = DB.Order_Date;
            AutoCombo.SelectedItem = DatabaseControlService.DBECS.GetComplexStringByAutoID(DB.Auto_ID);
            ClientCombo.SelectedItem = DatabaseControlService.DBECS.GetComplexStringByClientID(DB.Client_ID);
            OrderConditionEdit.Text = DB.Order_Condition;
        }

        public void FormReset()
        {
            OrderDatePicker.Value = DateTime.Now;
            AutoCombo.Text = "";
            ClientCombo.Text = "";
            OrderConditionEdit.Text = "";
        }

        public void FormStart()
        {
            AutoCombo.Items.Clear();
            ClientCombo.Items.Clear();
            DatabaseControlService.LoadComboData("SELECT Auto_ID,ManafacturerName,Model FROM dbo.AutomobilesData INNER JOIN dbo.Manafacturers ON dbo.AutomobilesData.Manafacturer_ID = dbo.Manafacturers.Manafacturer_ID", AutoCombo, IndexMassiveAuto);
            DatabaseControlService.LoadComboData("SELECT Client_ID, Family, Name, Surname FROM Clients", ClientCombo, IndexMassiveClients);
        }

        public void CallEdit(DataGridView DG)
        {
            EditorMode = 1;

            FormStart();
            DB.LoadData(DG);
            FormReset();
            FormLoad();

            this.Text = "Редактирование заказа...";
            this.ShowDialog();
        }

        public void CallInsert()
        {
            EditorMode = 0;

            FormStart();
            DB.Reset();
            FormReset();

            this.Text = "Добавление заказа...";
            this.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (EditorMode == 1)
            {
                if (CheckData())
                {
                    DatabaseControlService.SQL.SqlProcduceTransactionCommand(DB.Update());
                    EditorMode = 0;
                    this.Close();
                }
            }
            else
            {
                if (CheckData())
                {
                    DatabaseControlService.SQL.SqlProcduceTransactionCommand(DB.Insert());
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
