using System;
using System.Data;
using System.Windows.Forms;
using DBAutoShop.Controllers;

namespace DBAutoShop.ORM
{
    class Countries
    {
        private int _country_id;
        private string _countryname;
        private int _language_id;

        public int Country_ID
        {
            get { return _country_id; }
            set { _country_id = value; }
        }

        public string CountryName
        {
            get { return _countryname; }
            set { _countryname = value; }
        }

        public int Language_ID
        {
            get { return _language_id; }
            set { _language_id = value; }
        }

        public static string SelectAll()
        {
            return "SELECT * FROM Countries";
        }

        public void Reset()
        {
            Country_ID = 0;
            CountryName = "";
            Language_ID = 0;
        }


        public bool CheckUse()
        {
            string Command = "SELECT Country_ID FROM AutomobilesData WHERE Country_ID = " + Country_ID;

            DatabaseControlService.SQL = new SQLQueryService();
            DatabaseControlService.SQL.SqlProcduceCommand(Command);
            if (DatabaseControlService.SQL.DataTableHasValues()) return true;
            return false;
        }

        public bool CheckCountryName()
        {
            string Command = "SELECT CountryName FROM Countries WHERE CountryName = ('" + CountryName + "') AND Language_ID = " + Language_ID + " AND Country_ID != " + Country_ID;

            DatabaseControlService.SQL.SqlProcduceCommand(Command);
            if (DatabaseControlService.SQL.DataTableHasValues()) return true;
            return false;
        }

        public bool CheckCountryNameAll()
        {
            string Command = "SELECT CountryName FROM Countries WHERE CountryName = ('" + CountryName + "') AND Language_ID = " + Language_ID;

            DatabaseControlService.SQL.SqlProcduceCommand(Command);
            if (DatabaseControlService.SQL.DataTableHasValues()) return true;
            return false;
        }

        public void GetID()
        {
            string Query = "SELECT Country_ID FROM Countries WHERE CountryName = ('" + CountryName + "') AND Language_ID = " + Language_ID;
            Country_ID = DatabaseControlService.GetElementID(Query, 0);
        }

        public void LoadData(DataGridView DG)
        {
            DatabaseControlService.SQL.SqlProcduceCommand(SelectAll());
            if (DatabaseControlService.SQL.DataTableHasValues())
                Country_ID = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[DG.SelectedRows[0].Index][0]);
            LoadData();
        }

        public void LoadData(DataSet DS, int RowNumber)
        {
            if (DatabaseControlService.SQL.DataTableHasValues(DS, "Table", RowNumber))
            {
                CountryName = DS.Tables["Table"].Rows[RowNumber][1].ToString();
                Language_ID = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][2]);
            }
        }

        public void LoadData()
        {
            string Command = "SELECT CountryName, Language_ID FROM Countries WHERE Country_ID = " + Country_ID;

            DatabaseControlService.SQL.SqlProcduceCommand(Command);
            if (DatabaseControlService.SQL.DataTableHasValues())
            {
                CountryName = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][0].ToString();
                Language_ID = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][1]);
            }
        }

        public string Insert()
        {
            return "INSERT INTO Countries(CountryName, Language_ID) VALUES('" + CountryName + "', " + Language_ID + ")";
        }

        public string Update()
        {
            return "UPDATE Countries SET CountryName = ('" + CountryName + "'), Language_ID = " + Language_ID + " WHERE Country_ID = " + Country_ID;
        }

        public string Delete()
        {
            return "DELETE FROM Countries WHERE Country_ID = " + Country_ID + " AND CountryName = ('" + CountryName + "') AND Language_ID = " + Language_ID;
        }

        public string ViewAll()
        {
            return "SELECT * FROM ViewCountries";
        }

        public static void SaveToXML()
        {
            try
            {
                Languages.SaveToXML();

                DatabaseControlService.SQL.SqlProcduceCommand(SelectAll());
                DatabaseControlService.SQL.SQLDS.WriteXml("XML\\Countries.XML");
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
                Languages.LoadFromXML();

                Countries DB = new Countries();
                DataSet Base = new DataSet();
                DatabaseControlService.SQL.SQLDS = new DataSet();
                DatabaseControlService.SQL.SQLDS.ReadXml("XML\\Countries.XML");
                Base.ReadXml("XML\\Countries.XML");
                if (DatabaseControlService.SQL.DataTableHasValues())
                {
                    for (int i = 0; i < Base.Tables["Table"].Rows.Count; i++)
                    {
                        int OLD_ValueID = Convert.ToInt32(Base.Tables["Table"].Rows[i][2]);
                        DatabaseControlService.SQL.SQLDS = new DataSet();
                        DatabaseControlService.SQL.SQLDS.ReadXml("XML\\Languages.XML");
                        string OLD_Name = DatabaseControlService.SQL.GetValueByID(OLD_ValueID, 1, 0);
                        Base.Tables["Table"].Rows[i][2] = DatabaseControlService.DBECS.GetLanguageIDByLanguageName(OLD_Name);

                        DB.LoadData(Base, i);
                        if (!DB.CheckCountryNameAll())
                            DatabaseControlService.SQL.SqlProcduceTransactionCommand(DB.Insert());
                        else
                        {
                            DatabaseControlService.SQL.SqlProcduceCommand(SelectAll());
                            int ID = DatabaseControlService.SQL.GetIDByValue(DB.CountryName, 1, 0);
                            DB.Country_ID = ID;
                            DatabaseControlService.SQL.SqlProcduceTransactionCommand(DB.Update());
                        }
                    }
                    DatabaseControlService.SQL.SQLDS = new DataSet();
                    DatabaseControlService.SQL.SQLDS.ReadXml("XML\\Countries.XML");
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("XML ERROR: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
