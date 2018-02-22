using System;
using System.Windows.Forms;
using DBAutoShop.Controllers;
using DBAutoShop.ORM;
using DBAutoShop.MainForms;

namespace DBAutoShop.EditForms
{
    public partial class CountriesEditor : Form
    {
        int EditorMode = 0;

        Countries DB;

        public CountriesEditor()
        {
            InitializeComponent();

            DB = new Countries();
        }

        public void LoadData()
        {
            if (EditorMode == 0) DB.Country_ID = 0;
            DB.CountryName = CountryNameEdit.Text;
            DB.Language_ID = DatabaseControlService.DBECS.GetLanguageIDByLanguageName(LanguageCombo.Text);
        }

        public bool CheckData()
        {
            LoadData();
            if (CountryNameEdit.Text == "") { MessageBox.Show("Заполните поле Название!"); return false; }
            if (DB.CheckCountryName()) { MessageBox.Show("Такая страна уже существует в таблице!"); return false; }
            return true;
        }

        public void FormStart()
        {
            LanguageCombo.Items.Clear();
            DatabaseControlService.LoadComboData("SELECT LanguageName FROM Languages", LanguageCombo);
        }

        public void FormLoad()
        {
            FormStart();
            CountryNameEdit.Text = DB.CountryName;
            LanguageCombo.SelectedItem = DatabaseControlService.DBECS.GetLanguageNameByLanguageID(DB.Language_ID);
        }

        public void FormReset()
        {
            FormStart();
            CountryNameEdit.Text = "";
            LanguageCombo.Text = "";
        }

        public void CallInsert()
        {
            EditorMode = 0;

            DB.Reset();
            FormReset();

            this.Text = "Добавление страны...";
            this.ShowDialog();
        }

        public void CallEdit(DataGridView DG)
        {
            EditorMode = 1;

            DB.LoadData(DG);
            FormReset();
            FormLoad();

            this.Text = "Изменение страны...";
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
            SmallSelector DBSmallSelector = new SmallSelector();
            DBSmallSelector.Call(6);
            DBSmallSelector.Dispose();
            LanguageCombo.Items.Clear();
            DatabaseControlService.LoadComboData("SELECT LanguageName FROM Languages", LanguageCombo);
        }
    }
}
