using System;
using System.Data;
using System.Windows.Forms;
using DBAutoShop.Controllers;

namespace DBAutoShop.ORM
{
    class Workers
    {
        private int _worker_id;
        private string _family;
        private string _name;
        private string _surname;
        private string _telephone;
        private int _workplace_id;
        private int _office_id;
        private string _address;

        public int Worker_ID
        {
            get { return _worker_id; }
            set { _worker_id = value; }
        }

        public string Family
        {
            get { return _family; }
            set { _family = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public string Telephone
        {
            get { return _telephone; }
            set { _telephone = value; }
        }

        public int Workplace_ID
        {
            get { return _workplace_id; }
            set { _workplace_id = value; }
        }

        public int Office_ID
        {
            get { return _office_id; }
            set { _office_id = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public void Reset()
        {
            Worker_ID = 0;
            Family = "";
            Name = "";
            Surname = "";
            Workplace_ID = 0;
            Office_ID = 0;
            Telephone = "";
            Address = "";
        }

        public void GetID()
        {
            string Query = "SELECT Worker_ID FROM Workers WHERE Telephone = ('" + Telephone + "') AND Address = ('" + Address + "') AND Workplace_ID = " + Workplace_ID + " AND Office_ID = " + Office_ID;
            Worker_ID = DatabaseControlService.GetElementID(Query, 0);
        }

        public bool CheckUse()
        {
            string Command = "SELECT Worker_ID FROM Sells WHERE Worker_ID = " + Worker_ID;

            DatabaseControlService.SQL = new SQLQueryService();
            DatabaseControlService.SQL.SqlProcduceCommand(Command);
            if (DatabaseControlService.SQL.DataTableHasValues()) return true;
            return false;
        }

        public bool CheckTelephone()
        {
            string Command = "SELECT Telephone FROM Workers WHERE Telephone = ('" + Telephone + "') AND Worker_ID != " + Worker_ID;

            DatabaseControlService.SQL = new SQLQueryService();
            DatabaseControlService.SQL.SqlProcduceCommand(Command);
            if (DatabaseControlService.SQL.DataTableHasValues()) return true;
            return false;
        }

        public bool CheckAll()
        {
            string Command = "SELECT Telephone FROM Workers WHERE Telephone = ('" + Telephone + "')";

            DatabaseControlService.SQL = new SQLQueryService();
            DatabaseControlService.SQL.SqlProcduceCommand(Command);
            if (DatabaseControlService.SQL.DataTableHasValues()) return true;
            return false;
        }

        public bool CheckAddress()
        {
            string Command = "SELECT Address FROM Workers WHERE Address = ('" + Address + "') AND Worker_ID != " + Worker_ID;

            DatabaseControlService.SQL.SqlProcduceCommand(Command);
            if (DatabaseControlService.SQL.DataTableHasValues()) return true;
            return false;
        }
        public void LoadData(DataGridView DG)
        {
            DatabaseControlService.SQL.SqlProcduceCommand(SelectAll());
            if (DatabaseControlService.SQL.DataTableHasValues())
                Worker_ID = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[DG.SelectedRows[0].Index][0]);
            LoadData();
        }

        public void LoadData()
        {
            string Command = "SELECT Family, Name, Surname, Workplace_ID, Office_ID, Telephone, Address  FROM Workers WHERE Worker_ID = " + Worker_ID;

            DatabaseControlService.SQL.SqlProcduceCommand(Command);
            if (DatabaseControlService.SQL.DataTableHasValues())
            {
                Family = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][0].ToString();
                Name = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][1].ToString();
                Surname = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][2].ToString();
                Workplace_ID = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][3]);
                Office_ID = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][4]);
                Telephone = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][5].ToString();
                Address = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][6].ToString();
            }
        }

        public void LoadData(DataSet DS, int RowNumber)
        {
            if (DatabaseControlService.SQL.DataTableHasValues(DS, "Table", RowNumber))
            {
                Worker_ID = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][0]);
                Family = DS.Tables["Table"].Rows[RowNumber][1].ToString();
                Name = DS.Tables["Table"].Rows[RowNumber][2].ToString();
                Surname = DS.Tables["Table"].Rows[RowNumber][3].ToString();
                Telephone = DS.Tables["Table"].Rows[RowNumber][4].ToString();
                Workplace_ID = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][5]);
                Office_ID = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][6]);
                Address = DS.Tables["Table"].Rows[RowNumber][7].ToString();
            }
        }

        public static string SelectAll()
        {
            return "SELECT * FROM Workers";
        }

        public string Insert()
        {
            return "INSERT INTO Workers(Family, Name, Surname, Workplace_ID, Office_ID, Telephone, Address) VALUES('" + Family + "','" + Name + "','" + Surname + "'," + Workplace_ID + "," + Office_ID + ",'" + Telephone + "','" + Address + "')";
        }

        public string Update()
        {
            return "UPDATE Workers SET Family = '" + Family + "', Name = '" + Name + "', Surname = '" + Surname + "', Workplace_ID = " + Workplace_ID + ", Office_ID = " + Office_ID + ", Telephone = '" + Telephone + "', Address = '" + Address + "' WHERE Worker_ID = " + Worker_ID;
        }

        public string Delete()
        {
            return "DELETE FROM Workers WHERE Family = '" + Family + "' AND Name = '" + Name + "' AND Surname = '" + Surname + "' AND Workplace_ID = " + Workplace_ID + " AND Office_ID = " + Office_ID + " AND Telephone = '" + Telephone + "' AND Address = '" + Address + "'";
        }

        public string ViewAll()
        {
            return "SELECT * FROM ViewWorkers";
        }

        public static void SaveToXML()
        {
            try
            {
                Workplaces.SaveToXML();
                Offices.SaveToXML();

                DatabaseControlService.SQL.SqlProcduceCommand(SelectAll());
                DatabaseControlService.SQL.SQLDS.WriteXml("XML\\Workers.XML");
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
                Workplaces.LoadFromXML();
                Offices.LoadFromXML();

                Workers DB = new Workers();
                DatabaseControlService.SQL.SQLDS = new DataSet();
                DatabaseControlService.SQL.SQLDS.ReadXml("XML\\Workers.XML");
                DataSet Base = new DataSet();
                Base.ReadXml("XML\\Workers.XML");
                if (Base.Tables.Count == 0) return;
                if (DatabaseControlService.SQL.DataTableHasValues())
                {
                    for (int i = 0; i < Base.Tables["Table"].Rows.Count; i++)
                    {
                        int OLD_ValueID = Convert.ToInt32(Base.Tables["Table"].Rows[i][5]);
                        DatabaseControlService.SQL.SQLDS = new DataSet();
                        DatabaseControlService.SQL.SQLDS.ReadXml("XML\\Workplaces.XML");
                        string OLD_Name = DatabaseControlService.SQL.GetValueByID(OLD_ValueID, 1, 0);
                        Base.Tables["Table"].Rows[i][5] = DatabaseControlService.DBECS.GetWorkplaceIDByWorkplaceName(OLD_Name);

                        OLD_ValueID = Convert.ToInt32(Base.Tables["Table"].Rows[i][6]);
                        DatabaseControlService.SQL.SQLDS = new DataSet();
                        DatabaseControlService.SQL.SQLDS.ReadXml("XML\\Offices.XML");
                        OLD_Name = DatabaseControlService.SQL.GetValueByID(OLD_ValueID, 1, 0);
                        Base.Tables["Table"].Rows[i][6] = DatabaseControlService.DBECS.GetOfficeIDByOfficeName(OLD_Name);

                        DB.Reset();
                        DB.LoadData(Base, i);
                        if (!DB.CheckAll())
                            DatabaseControlService.SQL.SqlProcduceTransactionCommand(DB.Insert());
                        else
                        {
                            DatabaseControlService.SQL.SqlProcduceCommand(SelectAll());
                            int ID = DatabaseControlService.SQL.GetIDByValue(DB.Telephone, 4, 0);
                            DB.Worker_ID = ID;
                            DatabaseControlService.SQL.SqlProcduceTransactionCommand(DB.Update());
                        }
                    }
                    DatabaseControlService.SQL.SQLDS = new DataSet();
                    DatabaseControlService.SQL.SQLDS.ReadXml("XML\\Workers.XML");
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("XML ERROR: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
