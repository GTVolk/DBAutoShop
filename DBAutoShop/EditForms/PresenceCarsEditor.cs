using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DBAutoShop.Controllers;
using DBAutoShop.ORM;

namespace DBAutoShop.EditForms
{
    public partial class PresenceCarsEditor : Form
    {
        int EditorMode = 1;

        PresenceCars DB;
        List<int> IndexesMassiveAuto;

        public PresenceCarsEditor()
        {
            InitializeComponent();

            DB = new PresenceCars();

            IndexesMassiveAuto = new List<int>();
        }

        public void LoadData()
        {
            if (EditorMode == 0) DB.Sell_ID = 0;
            DB.Receipt_date = ReceiptDatePicker.Value;
            DB.Auto_ID = IndexesMassiveAuto[AutoCombo.SelectedIndex];
            DB.Color_ID = DatabaseControlService.DBECS.GetColorIDByColorName(ColorCombo.Text);
            DB.Office_ID = DatabaseControlService.DBECS.GetOfficeIDByOfficeName(OfficeCombo.Text);
            DB.Complectation = ComplectationEdit.Text;
            DB.No_body = NoBodyEdit.Text;
            DB.No_engine = NoEngineEdit.Text;
            DB.No_PTC = NoPTCEdit.Text;
        }

        public bool CheckData()
        {
            LoadData();
            if (AutoCombo.SelectedIndex == -1) { MessageBox.Show("Выберите Автомобиль из таблицы автомобилей!"); return false; }
            if (ColorCombo.SelectedIndex == -1) { MessageBox.Show("Выберите Цвет из списка цветов!"); return false; }
            if (OfficeCombo.SelectedIndex == -1) { MessageBox.Show("Выберите Офис из таблицы офисов!"); return false; }
            if (NoBodyEdit.Text == "") { MessageBox.Show("Заполните поле Номер кузова!"); return false; }
            if (NoEngineEdit.Text == "") { MessageBox.Show("Заполните поле Номер двигателя!"); return false; }
            if (NoPTCEdit.Text == "") { MessageBox.Show("Заполните поле Номер ПТС!"); return false; }
            if (DB.CheckNoBody()) { MessageBox.Show("Такой номер кузова уже существует в таблице!"); return false; }
            if (DB.CheckNoEngine()) { MessageBox.Show("Такой номер двигателя уже существует в таблице!"); return false; }
            if (DB.CheckNoPTC()) { MessageBox.Show("Такой номер ПТС уже существует в таблице!"); return false; }
            return true;
        }

        public void FormLoad()
        {
            ReceiptDatePicker.Value = DB.Receipt_date;
            AutoCombo.SelectedItem = DatabaseControlService.DBECS.GetComplexStringByAutoID(DB.Auto_ID);
            ColorCombo.SelectedItem = DatabaseControlService.DBECS.GetColorNameByColorID(DB.Color_ID);
            OfficeCombo.SelectedItem = DatabaseControlService.DBECS.GetOfficeNameByOfficeID(DB.Office_ID);
            ComplectationEdit.Text = DB.Complectation;
            NoBodyEdit.Text = DB.No_body;
            NoEngineEdit.Text = DB.No_engine;
            NoPTCEdit.Text = DB.No_PTC;
        }

        public void FormReset()
        {
            ReceiptDatePicker.Value = DateTime.Now;
            AutoCombo.Text = "";
            ColorCombo.Text = "";
            OfficeCombo.Text = "";
            ComplectationEdit.Text = "";
            NoBodyEdit.Text = "";
            NoEngineEdit.Text = "";
            NoPTCEdit.Text = "";
        }

        public void FormStart()
        {
            AutoCombo.Items.Clear();
            ColorCombo.Items.Clear();
            OfficeCombo.Items.Clear();
            DatabaseControlService.LoadComboData("SELECT Auto_ID,ManafacturerName,Model FROM dbo.AutomobilesData INNER JOIN dbo.Manafacturers ON dbo.AutomobilesData.Manafacturer_ID = dbo.Manafacturers.Manafacturer_ID", AutoCombo, IndexesMassiveAuto);
            DatabaseControlService.LoadComboData("SELECT ColorName FROM Colors", ColorCombo);
            DatabaseControlService.LoadComboData("SELECT Office_Name FROM Offices", OfficeCombo);
        }

        public void CallEdit(DataGridView DG)
        {
            EditorMode = 1;

            FormStart();
            DB.LoadData(DG);
            FormReset();
            FormLoad();

            this.Text = "Редактирование автомобиля на продаже...";
            this.ShowDialog();
        }

        public void CallInsert()
        {
            EditorMode = 0;

            FormStart();
            DB.Reset();
            FormReset();

            this.Text = "Добавление автомобиля на продажу...";
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

        private void button3_Click(object sender, EventArgs e)
        {
            DatabaseControlService.DBSmallSelector.Call(3);
            ColorCombo.Items.Clear();
            DatabaseControlService.LoadComboData("SELECT ColorName FROM Colors", ColorCombo);
        }
    }
}
