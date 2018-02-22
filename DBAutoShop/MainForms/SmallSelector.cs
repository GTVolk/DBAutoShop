using System;
using System.Windows.Forms;
using DBAutoShop.Controllers;
using DBAutoShop.ORM;
using DBAutoShop.EditForms;

namespace DBAutoShop.MainForms
{
    public partial class SmallSelector : Form
    {
        int PageID = 0;

        BodyTypes DBBodyTypes;
        Classes DBClasses;
        Colors DBColors;
        Countries DBCountries;
        GearTypes DBGearTypes;
        Languages DBLanguages;
        Manafacturers DBManafacturers;
        Workplaces DBWorkplaces;

        SmallEditor DBSmallEditor;
        CountriesEditor DBCountryEditor;

        public SmallSelector()
        {
            InitializeComponent();

            DBBodyTypes = new BodyTypes();
            DBClasses = new Classes();
            DBColors = new Colors();
            DBCountries = new Countries();
            DBGearTypes = new GearTypes();
            DBLanguages = new Languages();
            DBManafacturers = new Manafacturers();
            DBWorkplaces = new Workplaces();

            DBSmallEditor = new SmallEditor();
            DBCountryEditor = new CountriesEditor();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        public void UpdateButtons()
        {
            if (dataGridView1.Rows.Count > 0)
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

        public void Call(int TableID)
        {
            Update(TableID);

            this.ShowDialog();
        }

        public void Update(int TableID)
        {
            switch (TableID)
            {
                case 1:
                {
                    DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBBodyTypes.ViewAll());
                    DatabaseControlService.DataGridSelectLast(dataGridView1);
                    UpdateButtons();

                    this.Text = "Список типов кузова...";
                    break;
                }
                case 2:
                {
                    DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBClasses.ViewAll());
                    DatabaseControlService.DataGridSelectLast(dataGridView1);
                    UpdateButtons();

                    this.Text = "Список классов автомобилей...";
                    break;
                }
                case 3:
                {
                    DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBColors.ViewAll());
                    DatabaseControlService.DataGridSelectLast(dataGridView1);
                    UpdateButtons();

                    this.Text = "Список цветов...";
                    break;
                }
                case 4:
                {
                    DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBCountries.ViewAll());
                    DatabaseControlService.DataGridSelectLast(dataGridView1);
                    UpdateButtons();

                    this.Text = "Список стран...";
                    break;
                }
                case 5:
                {
                    DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBGearTypes.ViewAll());
                    DatabaseControlService.DataGridSelectLast(dataGridView1);
                    UpdateButtons();

                    this.Text = "Список типов привода...";
                    break;
                }
                case 6:
                {
                    DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBLanguages.ViewAll());
                    DatabaseControlService.DataGridSelectLast(dataGridView1);
                    UpdateButtons();

                    this.Text = "Список языков...";
                    break;
                }
                case 7:
                {
                    DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBManafacturers.ViewAll());
                    DatabaseControlService.DataGridSelectLast(dataGridView1);
                    UpdateButtons();

                    this.Text = "Список производителей...";
                    break;
                }
                case 8:
                {
                    DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBWorkplaces.ViewAll());
                    DatabaseControlService.DataGridSelectLast(dataGridView1);
                    UpdateButtons();

                    this.Text = "Список должностей...";
                    break;
                }
                default:
                {
                    MessageBox.Show("О неееееееет!!!!!!!", "Гипер-пупер ошибка века!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
            PageID = TableID;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (PageID != 4)
                DBSmallEditor.CallInsert(PageID);
            else
                DBCountryEditor.CallInsert();
            Update(PageID);
            DatabaseControlService.DataGridSelectLast(dataGridView1);
            UpdateButtons();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (PageID != 4)
                DBSmallEditor.CallEdit(PageID, dataGridView1);
            else
                DBCountryEditor.CallEdit(dataGridView1);
            Update(PageID);
            DatabaseControlService.DataGridSelectLast(dataGridView1);
            UpdateButtons();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            switch (PageID)
            {
                case 1:
                    {
                        DBBodyTypes.LoadData(dataGridView1);
                        if (!DBBodyTypes.CheckUse())
                        {
                            DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBBodyTypes.Delete());
                            Update(PageID);
                            DatabaseControlService.DataGridSelectLast(dataGridView1);
                            UpdateButtons();
                        }
                        break;
                    }
                case 2:
                    {
                        DBClasses.LoadData(dataGridView1);
                        if (!DBClasses.CheckUse())
                        {
                            DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBClasses.Delete());
                            Update(PageID);
                            DatabaseControlService.DataGridSelectLast(dataGridView1);
                            UpdateButtons();
                        }
                        break;
                    }
                case 3:
                    {
                        DBColors.LoadData(dataGridView1);
                        if (!DBColors.CheckUse())
                        {
                            DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBColors.Delete());
                            Update(PageID);
                            DatabaseControlService.DataGridSelectLast(dataGridView1);
                            UpdateButtons();
                        }
                        break;
                    }
                case 4:
                    {
                        DBCountries.LoadData(dataGridView1);
                        if (!DBCountries.CheckUse())
                        {
                            DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBCountries.Delete());
                            Update(PageID);
                            DatabaseControlService.DataGridSelectLast(dataGridView1);
                            UpdateButtons();
                        }
                        break;
                    }
                case 5:
                    {
                        DBGearTypes.LoadData(dataGridView1);
                        if (!DBGearTypes.CheckUse())
                        {
                            DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBGearTypes.Delete());
                            Update(PageID);
                            DatabaseControlService.DataGridSelectLast(dataGridView1);
                            UpdateButtons();
                        }
                        break;
                    }
                case 6:
                    {
                        DBLanguages.LoadData(dataGridView1);
                        if (!DBLanguages.CheckUse())
                        {
                            DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBLanguages.Delete());
                            Update(PageID);
                            DatabaseControlService.DataGridSelectLast(dataGridView1);
                            UpdateButtons();
                        }
                        UpdateButtons();
                        break;
                    }
                case 7:
                    {
                        DBManafacturers.LoadData(dataGridView1);
                        if (!DBManafacturers.CheckUse())
                        {
                            DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBManafacturers.Delete());
                            Update(PageID);
                            DatabaseControlService.DataGridSelectLast(dataGridView1);
                            UpdateButtons();
                        }
                        break;
                    }
                case 8:
                    {
                        DBWorkplaces.LoadData(dataGridView1);
                        if (!DBWorkplaces.CheckUse())
                        {
                            DatabaseControlService.SQL.SqlProcduceCommand(dataGridView1, DBWorkplaces.Delete());
                            Update(PageID);
                            DatabaseControlService.DataGridSelectLast(dataGridView1);
                            UpdateButtons();
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
    }
}
