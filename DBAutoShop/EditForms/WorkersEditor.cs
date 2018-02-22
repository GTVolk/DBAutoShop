using System;
using System.Windows.Forms;
using DBAutoShop.ORM;
using DBAutoShop.Controllers;

namespace DBAutoShop.EditForms
{
    public partial class WorkersEditor : Form
    {
        Workers DB;
        int EditorMode = 0;
        public WorkersEditor()
        {
            InitializeComponent();

            DB = new Workers();
        }

        public void LoadData()
        {
            if (EditorMode == 0) DB.Worker_ID = 0;
            DB.Family = FamilyEdit.Text;
            DB.Name = NameEdit.Text;
            DB.Surname = SurnameEdit.Text;
            DB.Workplace_ID = DatabaseControlService.DBECS.GetWorkplaceIDByWorkplaceName(WorkplaceCombo.Text.ToString());
            DB.Office_ID = DatabaseControlService.DBECS.GetOfficeIDByOfficeName(OfficeCombo.Text.ToString());
            DB.Telephone = TelephoneEdit.Text;
            DB.Address = AddressEdit.Text;
        }

        public bool CheckData()
        {
            LoadData();
            if (FamilyEdit.Text == "") { MessageBox.Show("Заполните поле Фамилия!"); return false; }
            if (NameEdit.Text == "") { MessageBox.Show("Заполните поле Имя!"); return false; }
            if (SurnameEdit.Text == "") { MessageBox.Show("Заполните поле Отчество!"); return false; }
            if (WorkplaceCombo.SelectedIndex == -1) { MessageBox.Show("Выберите Должность из списка должностей!"); return false; }
            if (OfficeCombo.SelectedIndex == -1) { MessageBox.Show("Выберите Офис из таблицы офисов!"); return false; }
            if (TelephoneEdit.Text == "") { MessageBox.Show("Заполните поле Телефон!"); return false; }
            if (DB.CheckTelephone()) { MessageBox.Show("Такой телефонный номер уже существует в таблице!"); return false; }
            if (AddressEdit.Text == "") { MessageBox.Show("Заполните поле Адрес!"); return false; }
            if (DB.CheckAddress()) { MessageBox.Show("Такой адрес уже существует в таблице!"); return false; }
            return true;
        }

        public void FormLoad()
        {
            FamilyEdit.Text = DB.Family;
            NameEdit.Text = DB.Name;
            SurnameEdit.Text = DB.Surname;
            WorkplaceCombo.SelectedItem = DatabaseControlService.DBECS.GetWorkplaceNameByWorkplaceID(DB.Workplace_ID);
            OfficeCombo.SelectedItem = DatabaseControlService.DBECS.GetOfficeNameByOfficeID(DB.Office_ID);
            TelephoneEdit.Text = DB.Telephone;
            AddressEdit.Text = DB.Address;
        }

        public void FormReset()
        {
            FamilyEdit.Text = "";
            NameEdit.Text = "";
            SurnameEdit.Text = "";
            WorkplaceCombo.Text = "";
            OfficeCombo.Text = "";
            TelephoneEdit.Text = "";
            AddressEdit.Text = "";
        }

        public void FormStart()
        {
            WorkplaceCombo.Items.Clear();
            OfficeCombo.Items.Clear();
            DatabaseControlService.LoadComboData("SELECT WorkplaceName FROM Workplaces",WorkplaceCombo);
            DatabaseControlService.LoadComboData("SELECT Office_Name FROM Offices", OfficeCombo);
        }

        public void CallEdit(DataGridView DG)
        {
            EditorMode = 1;

            FormStart();
            DB.LoadData(DG);
            FormReset();
            FormLoad();

            this.Text = "Редактирование работника...";
            this.ShowDialog();
        }

        public void CallInsert()
        {
            EditorMode = 0;

            FormStart();
            DB.Reset();
            FormReset();

            this.Text = "Добавление работника...";
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
            DatabaseControlService.DBSmallSelector.Call(8);
            WorkplaceCombo.Items.Clear();
            DatabaseControlService.LoadComboData("SELECT WorkplaceName FROM Workplaces", WorkplaceCombo);
        }

        private void TelephoneEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
