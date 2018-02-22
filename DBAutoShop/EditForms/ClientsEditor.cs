using System;
using System.Windows.Forms;
using DBAutoShop.ORM;
using DBAutoShop.Controllers;

namespace DBAutoShop.EditForms
{
    public partial class ClientsEditor : Form
    {
        
        Clients DB;
        int EditorMode = 0;
        public ClientsEditor()
        {
            InitializeComponent();

            DB = new Clients();
        }

        public void LoadData()
        {
            if (EditorMode == 0) DB.Client_ID = 0;
            DB.Family = FamilyEdit.Text;
            DB.Name = NameEdit.Text;
            DB.Surname = SurnameEdit.Text;
            DB.Telephone = TelephoneEdit.Text;
            DB.Address = AddressEdit.Text;
        }

        public bool CheckData()
        {
            LoadData();
            if (FamilyEdit.Text == "") { MessageBox.Show("Заполните поле Фамилия!"); return false; }
            if (NameEdit.Text == "") { MessageBox.Show("Заполните поле Имя!"); return false; }
            if (SurnameEdit.Text == "") { MessageBox.Show("Заполните поле Отчество!"); return false; }
            if (TelephoneEdit.Text == "") { MessageBox.Show("Заполните поле Телефон!"); return false; }
            if (DB.CheckTelephone()) { MessageBox.Show("Такой телефонный номер уже существует в таблице!"); return false; }
            if (AddressEdit.Text == "") { MessageBox.Show("Заполните поле Адрес!"); return false; }
            if (DB.CheckAddress()) { MessageBox.Show("Такой адрес уже существует в таблице!"); return false; }
            return true;
        }

        public void FormReset()
        {
            FamilyEdit.Text = "";
            NameEdit.Text = "";
            SurnameEdit.Text = "";
            TelephoneEdit.Text = "";
            AddressEdit.Text = "";
        }

        public void FormLoad()
        {
            FamilyEdit.Text = DB.Family;
            NameEdit.Text = DB.Name;
            SurnameEdit.Text = DB.Surname;
            TelephoneEdit.Text = DB.Telephone;
            AddressEdit.Text = DB.Address;
        }

        public void CallEdit(DataGridView DG)
        {
            EditorMode = 1;

            DB.LoadData(DG);
            FormReset();
            FormLoad();

            this.Text = "Редактирование клиента...";
            this.ShowDialog();
        }

        public void CallInsert()
        {
            EditorMode = 0;

            DB.Reset();
            FormReset();

            this.Text = "Добавление клиента...";
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
