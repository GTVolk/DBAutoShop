using System;
using System.Windows.Forms;
using DBAutoShop.Controllers;
using DBAutoShop.ORM;

namespace DBAutoShop.EditForms
{
    public partial class OfficesEditor : Form
    {
        Offices DB;
        int EditorMode = 0;
        public OfficesEditor()
        {
            InitializeComponent();

            DB = new Offices();
        }

        public void LoadData()
        {
            if (EditorMode == 0) DB.Office_ID = 0;
            DB.Office_Name = OfficeNameEdit.Text;
            DB.Address = AddressEdit.Text;
            DB.Telephone = TelephoneEdit.Text;
        }

        public bool CheckData()
        {
            LoadData();
            if (OfficeNameEdit.Text == "") { MessageBox.Show("Заполните поле Назавание!"); return false; }
            if (DB.CheckOfficeName()) { MessageBox.Show("Такое название офиса уже существует в таблице!"); return false; }
            if (AddressEdit.Text == "") { MessageBox.Show("Заполните поле Адрес!"); return false; }
            if (DB.CheckAddress()) { MessageBox.Show("Такой адрес уже существует в таблице!"); return false; }
            if (TelephoneEdit.Text == "") { MessageBox.Show("Заполните поле Телефон!"); return false; }
            if (DB.CheckTelephone()) { MessageBox.Show("Такой телефонный номер уже существует в таблице!"); return false; }
            return true;
        }

        public void FormReset()
        {
            OfficeNameEdit.Text = "";
            AddressEdit.Text = "";
            TelephoneEdit.Text = "";
        }

        public void FormLoad()
        {
            OfficeNameEdit.Text = DB.Office_Name;
            AddressEdit.Text = DB.Address;
            TelephoneEdit.Text = DB.Telephone;
        }

        public void CallEdit(DataGridView DG)
        {
            EditorMode = 1;

            DB.LoadData(DG);
            FormReset();
            FormLoad();

            this.Text = "Редактирование офиса...";
            this.ShowDialog();
        }

        public void CallInsert()
        {
            EditorMode = 0;

            DB.Reset();
            FormReset();

            this.Text = "Добавление офиса...";
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

        private void TelephoneEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
