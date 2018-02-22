using System;
using System.Data;
using System.Windows.Forms;
using DBAutoShop.Controllers;

namespace DBAutoShop.ORM
{
    class Offices
    {
        private int _office_id;
        private string _office_name;
        private string _address;
        private string _telephone;
        private int _auto_count;
        private int _workers_count;

        public int Office_ID
        {
            get { return _office_id; }
            set { _office_id = value; }
        }

        public string Office_Name
        {
            get { return _office_name; }
            set { _office_name = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string Telephone
        {
            get { return _telephone; }
            set { _telephone = value; }
        }

        public int Auto_Count
        {
            get { return _auto_count; }
            set { _auto_count = value; }
        }

        public int Workers_Count
        {
            get { return _workers_count; }
            set { _workers_count = value; }
        }

        public void GetID()
        {
            string Query = "SELECT Office_ID FROM Offices WHERE Office_Name = ('" + Telephone + "') AND Address = ('" + Address + "') AND Telephone =  ('" + Telephone + "')";
            Office_ID = DatabaseControlService.GetElementID(Query, 0);
        }

        public void Reset()
        {
            Office_Name = "";
            Address = "";
            Telephone = "";
        }

        public bool CheckUse()
        {
            string Command = "SELECT Office_ID FROM Sells WHERE Office_ID = " + Office_ID;

            DatabaseControlService.SQL = new SQLQueryService();
            DatabaseControlService.SQL.SqlProcduceCommand(Command);
            if (DatabaseControlService.SQL.DataTableHasValues()) return true;

            Command = "SELECT Office_ID FROM Workers WHERE Office_ID = " + Office_ID;

            DatabaseControlService.SQL = new SQLQueryService();
            DatabaseControlService.SQL.SqlProcduceCommand(Command);
            if (DatabaseControlService.SQL.DataTableHasValues()) return true;
            return false;
        }

        public bool CheckOfficeName()
        {
            string Command = "SELECT Office_Name FROM Offices WHERE Office_Name = ('" + Office_Name + "') AND Office_ID != " + Office_ID;

            DatabaseControlService.SQL = new SQLQueryService();
            DatabaseControlService.SQL.SqlProcduceCommand(Command);
            if (DatabaseControlService.SQL.DataTableHasValues()) return true;
            return false;
        }

        public bool CheckAll()
        {
            string Command = "SELECT Office_Name FROM Offices WHERE Office_Name = ('" + Office_Name + "')";

            DatabaseControlService.SQL = new SQLQueryService();
            DatabaseControlService.SQL.SqlProcduceCommand(Command);
            if (DatabaseControlService.SQL.DataTableHasValues()) return true;
            return false;
        }

        public bool CheckAddress()
        {
            string Command = "SELECT Address FROM Offices WHERE Address = ('" + Address + "') AND Office_ID != " + Office_ID;

            DatabaseControlService.SQL.SqlProcduceCommand(Command);
            if (DatabaseControlService.SQL.DataTableHasValues()) return true;
            return false;
        }

        public bool CheckTelephone()
        {
            string Command = "SELECT Telephone FROM Offices WHERE Telephone = ('" + Telephone + "') AND Office_ID != " + Office_ID;

            DatabaseControlService.SQL = new SQLQueryService();
            DatabaseControlService.SQL.SqlProcduceCommand(Command);
            if (DatabaseControlService.SQL.DataTableHasValues()) return true;
            return false;
        }

        public void LoadData(DataGridView DG)
        {
            DatabaseControlService.SQL.SqlProcduceCommand(SelectAll());
            if (DatabaseControlService.SQL.DataTableHasValues())
                Office_ID = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[DG.SelectedRows[0].Index][0]);
            LoadData();
        }

        public void LoadData()
        {
            string Command = "SELECT Office_Name,Address,Telephone,Auto_Count,Workers_Count  FROM Offices WHERE Office_ID = " + Office_ID;

            DatabaseControlService.SQL.SqlProcduceCommand(Command);
            if (DatabaseControlService.SQL.DataTableHasValues())
            {
                Office_Name = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][0].ToString();
                Address = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][1].ToString();
                Telephone = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][2].ToString();
                Auto_Count = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][3]);
                Workers_Count = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][4]);
            }
        }

        public void LoadData(DataSet DS, int RowNumber)
        {
            if (DatabaseControlService.SQL.DataTableHasValues(DS, "Table", RowNumber))
            {
                Office_ID = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][0]);
                Office_Name = DS.Tables["Table"].Rows[RowNumber][1].ToString();
                Address = DS.Tables["Table"].Rows[RowNumber][2].ToString();
                Telephone = DS.Tables["Table"].Rows[RowNumber][3].ToString();
                Auto_Count = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][4]);
                Workers_Count = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][5]);
            }
        }

        public static string SelectAll()
        {
            return "SELECT * FROM Offices";
        }

        public string Insert()
        {
            return "INSERT INTO Offices(Office_Name, Address, Telephone) VALUES('" + Office_Name + "','" + Address + "','" + Telephone + "')";
        }

        public string Update()
        {
            return "UPDATE Offices SET Office_Name = '" + Office_Name + "', Address = '" + Address + "', Telephone = '" + Telephone + "' WHERE Office_ID = " + Office_ID;
        }

        public string Delete()
        {
            return "DELETE FROM Offices WHERE Office_Name = '" + Office_Name + "' AND Address = '" + Address + "' AND Telephone = '" + Telephone + "'";
        }

        public string ViewAll()
        {
            return "SELECT * FROM ViewOffices";
        }

        public static void SaveToXML()
        {
            try
            {
                DatabaseControlService.SQL.SqlProcduceCommand(SelectAll());
                DatabaseControlService.SQL.SQLDS.WriteXml("XML\\Offices.XML");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("XML ERROR: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void LoadFromXML()
        {
            try
            {
                Offices DB = new Offices();
                DatabaseControlService.SQL.SQLDS = new DataSet();
                DatabaseControlService.SQL.SQLDS.ReadXml("XML\\Offices.XML");
                DataSet Base = new DataSet();
                Base.ReadXml("XML\\Offices.XML");
                if (Base.Tables.Count == 0) return;
                if (DatabaseControlService.SQL.DataTableHasValues())
                {
                    for (int i = 0; i < Base.Tables["Table"].Rows.Count; i++)
                    {
                        DB.LoadData(Base, i);
                        if (!DB.CheckAll())
                            DatabaseControlService.SQL.SqlProcduceTransactionCommand(DB.Insert());
                        else
                        {
                            DatabaseControlService.SQL.SqlProcduceCommand(SelectAll());
                            int ID = DatabaseControlService.SQL.GetIDByValue(DB.Office_Name, 1, 0);
                            DB.Office_ID = ID;
                            DatabaseControlService.SQL.SqlProcduceTransactionCommand(DB.Update());
                        }
                    }
                    DatabaseControlService.SQL.SQLDS = new DataSet();
                    DatabaseControlService.SQL.SQLDS.ReadXml("XML\\Offices.XML");
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("XML ERROR: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
