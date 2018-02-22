using System;
using System.Data;
using System.Windows.Forms;
using DBAutoShop.Controllers;

namespace DBAutoShop.ORM
{
    abstract class AdditionalCommonClass
    {
        public abstract string TableName { get; }
        public abstract string TableIDName { get; }
        public abstract string TableValueName { get; }
        public abstract int MainID {get; set;}
        public abstract string MainValue {get; set;}

        public int GetID()
        {
            DatabaseControlService.StandartSelectQuery(TableName, TableIDName, TableValueName, MainValue);
            MainID = DatabaseControlService.GetElementID();
            return MainID;
        }

        public bool CheckUse()
        {
            DatabaseControlService.StandartSelectQuery(TableName, TableIDName, TableIDName, MainID);
            if (DatabaseControlService.SQL.DataTableHasValues()) return true;
            return false;
        }

        public bool Check()
        {
            DatabaseControlService.StandartSelectQuery(TableName, TableValueName, TableValueName, MainValue, MainID);
            if (DatabaseControlService.SQL.DataTableHasValues()) return true;
            return false;
        }

        public bool CheckAll()
        {
            DatabaseControlService.StandartSelectQuery(TableName, TableValueName, TableValueName, MainValue);
            if (DatabaseControlService.SQL.DataTableHasValues()) return true;
            return false;
        }

        public void LoadData(DataGridView DG)
        {
            DatabaseControlService.SQL.SqlProcduceCommand(SelectAll());
            if (DatabaseControlService.SQL.DataTableHasValues())
                MainID = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[DG.SelectedRows[0].Index][0]);
            LoadData();
        }

        public void LoadData()
        {
            DatabaseControlService.StandartSelectQuery(TableName, TableValueName, TableIDName, MainID);
            if (DatabaseControlService.SQL.DataTableHasValues())
                MainValue = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][0].ToString();
        }

        public void LoadData(DataSet DS, int RowNumber)
        {
            if (DatabaseControlService.SQL.DataTableHasValues(DS, "Table", RowNumber))
                MainValue = DS.Tables["Table"].Rows[RowNumber][1].ToString();
        }

        public void Reset()
        {
            MainID = 0;
            MainValue = "";
        }

        public string Insert()
        {
            return DatabaseControlService.StandartInsertQuery(TableName, TableValueName, MainValue);
        }

        public string Update()
        {
            return DatabaseControlService.StandartUpdateQuery(TableName, TableValueName, MainValue, TableIDName, MainID);
        }

        public string Delete()
        {
            return DatabaseControlService.StandartDeleteQuery(TableName, TableIDName, MainID, TableValueName, MainValue);
        }

        public string ViewAll()
        {
            return DatabaseControlService.QBuilder.BuildSelectQuery("View" + TableName);
        }

        public string SelectAll()
        {
            return DatabaseControlService.QBuilder.BuildSelectQuery(TableName);
        }
    }
}
