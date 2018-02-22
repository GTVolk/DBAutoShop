using System;
using System.Reflection;
using System.Windows.Forms;
using DBAutoShop.Controllers;
using DBAutoShop.ORM;

namespace DBAutoShop.EditForms
{
    public partial class SmallEditor : Form
    {
        int PageID = 0;
        int EditorMode = 0;

        BodyTypes DBBodyTypes;
        Classes DBClasses;
        Colors DBColors;
        GearTypes DBGearTypes;
        Languages DBLanguages;
        Manafacturers DBManafacturers;
        Workplaces DBWorkplaces;

        public SmallEditor()
        {
            InitializeComponent();

            DBBodyTypes = new BodyTypes();
            DBClasses = new Classes();
            DBColors = new Colors();
            DBGearTypes = new GearTypes();
            DBLanguages = new Languages();
            DBManafacturers = new Manafacturers();
            DBWorkplaces = new Workplaces();
        }

        public void CallInsert(int TableID)
        {
            PageID = TableID;
            switch (TableID)
            {
                case 1:
                    {
                        EditorMode = 0;

                        DBBodyTypes.Reset();
                        ValueEdit.Text = "";

                        this.Text = "Добавить тип кузова...";
                        this.ShowDialog();

                        break;
                    }
                case 2:
                    {
                        EditorMode = 0;

                        DBClasses.Reset();
                        ValueEdit.Text = "";

                        this.Text = "Добавить класс...";
                        this.ShowDialog();

                        break;
                    }
                case 3:
                    {
                        EditorMode = 0;

                        DBColors.Reset();
                        ValueEdit.Text = "";

                        this.Text = "Добавить цвет...";
                        this.ShowDialog();

                        break;
                    }
                case 5:
                    {
                        EditorMode = 0;

                        DBGearTypes.Reset();
                        ValueEdit.Text = "";

                        this.Text = "Добавить тип привода...";
                        this.ShowDialog();

                        break;
                    }
                case 6:
                    {
                        EditorMode = 0;

                        DBLanguages.Reset();
                        ValueEdit.Text = "";

                        this.Text = "Добавить язык...";
                        this.ShowDialog();

                        break;
                    }
                case 7:
                    {
                        EditorMode = 0;

                        DBManafacturers.Reset();
                        ValueEdit.Text = "";

                        this.Text = "Добавить производителя...";
                        this.ShowDialog();

                        break;
                    }
                case 8:
                    {
                        EditorMode = 0;

                        DBWorkplaces.Reset();
                        ValueEdit.Text = "";

                        this.Text = "Добавить место работы...";
                        this.ShowDialog();

                        break;
                    }
                default:
                    {
                        MessageBox.Show("О неееееееет!!!!!!!", "Гипер-пупер ошибка века!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
            }
        }

        public void CallEdit(int TableID, DataGridView DG)
        {
            switch (TableID)
            {
                case 1:
                    {
                        EditorMode = 1;

                        DBBodyTypes.LoadData(DG);
                        ValueEdit.Text = DBBodyTypes.MainValue;

                        this.Text = "Изменить тип кузова...";
                        this.ShowDialog();

                        break;
                    }
                case 2:
                    {
                        EditorMode = 1;

                        DBClasses.LoadData(DG);
                        ValueEdit.Text = DBClasses.MainValue;

                        this.Text = "Изменить класс...";
                        this.ShowDialog();

                        break;
                    }
                case 3:
                    {
                        EditorMode = 1;

                        DBColors.LoadData(DG);
                        ValueEdit.Text = DBColors.MainValue;

                        this.Text = "Изменить цвет...";
                        this.ShowDialog();

                        break;
                    }
                case 5:
                    {
                        EditorMode = 1;

                        DBGearTypes.LoadData(DG);
                        ValueEdit.Text = DBGearTypes.MainValue;

                        this.Text = "Изменить тип привода...";
                        this.ShowDialog();

                        break;
                    }
                case 6:
                    {
                        EditorMode = 1;

                        DBWorkplaces.LoadData(DG);
                        ValueEdit.Text = DBLanguages.MainValue;

                        this.Text = "Изменить язык...";
                        this.ShowDialog();

                        break;
                    }
                case 7:
                    {
                        EditorMode = 1;

                        DBManafacturers.LoadData(DG);
                        ValueEdit.Text = DBManafacturers.MainValue;

                        this.Text = "Изменить производителя...";
                        this.ShowDialog();

                        break;
                    }
                case 8:
                    {
                        EditorMode = 1;

                        DBWorkplaces.LoadData(DG);
                        ValueEdit.Text = DBWorkplaces.MainValue;

                        this.Text = "Изменить место работы...";
                        this.ShowDialog();

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

        public bool CheckData()
        {
            if (ValueEdit.Text == "") { MessageBox.Show("Заполните поле Значение!"); return false; }
            switch (PageID)
            {
                case 1:
                    {
                        if (EditorMode == 0) DBBodyTypes.MainID = 0;
                        DBBodyTypes.MainValue = ValueEdit.Text;
                        if (DBBodyTypes.Check()) { MessageBox.Show("Такой тип кузова уже существует в таблице!"); return false; }
                        break;
                    }
                case 2:
                    {
                        if (EditorMode == 0) DBClasses.MainID = 0;
                        DBClasses.MainValue = ValueEdit.Text;
                        if (DBClasses.Check()) { MessageBox.Show("Такой класс уже существует в таблице!"); return false; }
                        break;
                    }
                case 3:
                    {
                        if (EditorMode == 0) DBColors.MainID = 0;
                        DBColors.MainValue = ValueEdit.Text;
                        if (DBColors.Check()) { MessageBox.Show("Такой цвет уже существует в таблице!"); return false; }
                        break;
                    }
                case 5:
                    {
                        if (EditorMode == 0) DBGearTypes.MainID = 0;
                        DBGearTypes.MainValue = ValueEdit.Text;
                        if (DBGearTypes.Check()) { MessageBox.Show("Такой тип привода уже существует в таблице!"); return false; }
                        break;
                    }
                case 6:
                    {
                        if (EditorMode == 0) DBLanguages.MainID = 0;
                        DBLanguages.MainValue = ValueEdit.Text;
                        if (DBLanguages.Check()) { MessageBox.Show("Такой язык уже существует в таблице!"); return false; }
                        break;
                    }
                case 7:
                    {
                        if (EditorMode == 0) DBManafacturers.MainID = 0;
                        DBManafacturers.MainValue = ValueEdit.Text;
                        if (DBManafacturers.Check()) { MessageBox.Show("Такой производитель уже существует в таблице!"); return false; }
                        break;
                    }
                case 8:
                    {
                        if (EditorMode == 0) DBWorkplaces.MainID = 0;
                        DBWorkplaces.MainValue = ValueEdit.Text;
                        if (DBWorkplaces.Check()) { MessageBox.Show("Такое место работы уже существует в таблице!"); return false; }
                        break;
                    }
                default:
                    {
                        MessageBox.Show("О неееееееет!!!!!!!", "Гипер-пупер ошибка века!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (PageID)
            {
                case 1:
                    {
                        DBBodyTypes.MainValue = ValueEdit.Text;
                        Execute("BodyTypes", DBBodyTypes.MainID, DBBodyTypes.MainValue);
                        break;
                    }
                case 2:
                    {
                        DBClasses.MainValue = ValueEdit.Text;
                        Execute("Classes", DBClasses.MainID, DBClasses.MainValue);
                        break;
                    }
                case 3:
                    {
                        DBColors.MainValue = ValueEdit.Text;
                        Execute("Colors", DBColors.MainID, DBColors.MainValue);
                        break;
                    }
                case 5:
                    {
                        DBGearTypes.MainValue = ValueEdit.Text;
                        Execute("GearTypes", DBGearTypes.MainID, DBGearTypes.MainValue);
                        break;
                    }
                case 6:
                    {
                        DBLanguages.MainValue = ValueEdit.Text;
                        Execute("Languages", DBLanguages.MainID, DBLanguages.MainValue);
                        break;
                    }
                case 7:
                    {
                        DBManafacturers.MainValue = ValueEdit.Text;
                        Execute("Manafacturers", DBManafacturers.MainID, DBManafacturers.MainValue);
                        break;
                    }
                case 8:
                    {
                        DBWorkplaces.MainValue = ValueEdit.Text;
                        Execute("Workplaces", DBWorkplaces.MainID, DBWorkplaces.MainValue);
                        break;
                    }
                default:
                    {
                        MessageBox.Show("О неееееееет!!!!!!!", "Гипер-пупер ошибка века!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Execute(string TableName, int ID, string Names)
        {
            if (EditorMode == 1)
            {
                if (CheckData())
                {
                    DatabaseControlService.ExecuteUpdate(TableName, ID, Names);
                    EditorMode = 0;
                    this.Close();
                }
            }
            else
            {
                if (CheckData())
                {
                    DatabaseControlService.ExecuteInsert(TableName, Names);
                    this.Close();
                }
            }

        }
    }
}
