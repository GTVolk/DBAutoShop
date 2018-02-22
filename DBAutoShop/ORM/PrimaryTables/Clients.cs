using System;
using System.Data;
using System.Windows.Forms;
using DBAutoShop.Controllers;

namespace DBAutoShop.ORM
{
    class Clients
    {
        private int _client_id;
        private string _family;
        private string _name;
        private string _surname;
        private string _telephone;
        private string _address;
        private int _discount;
        private int _purchases;
        private int _orders_count;
        private decimal _total_spended;

        public int Client_ID
        {
            get { return _client_id; }
            set { _client_id = value; }
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

        public int Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }

        public int Purchases
        {
            get { return _purchases; }
            set { _purchases = value; }
        }

        public int Orders_Count
        {
            get { return _orders_count; }
            set { _orders_count = value; }
        }

        public string Telephone
        {
            get { return _telephone; }
            set { _telephone = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public decimal Total_Spended
        {
            get { return _total_spended; }
            set { _total_spended = value; }
        }

        public void Reset()
        {
            Client_ID = 0;
            Family = "";
            Name = "";
            Surname = "";
            Telephone = "";
            Address = "";
            Discount = 0;
            Purchases = 0;
            Orders_Count = 0;
            Total_Spended = 0;
        }

        public void GetID()
        {
            string Query = "SELECT Client_ID FROM Clients WHERE Telephone = ('" + Telephone + "') AND Address = ('" + Address + "')";
            Client_ID = DatabaseControlService.GetElementID(Query, 0);
        }

        public bool CheckUse()
        {
            string Command = "SELECT Client_ID FROM Orders WHERE Client_ID = " + Client_ID;

            DatabaseControlService.SQL = new SQLQueryService();
            DatabaseControlService.SQL.SqlProcduceCommand(Command);
            if (DatabaseControlService.SQL.DataTableHasValues()) return true;

            Command = "SELECT Client_ID FROM Sells WHERE Client_ID = " + Client_ID;

            DatabaseControlService.SQL = new SQLQueryService();
            DatabaseControlService.SQL.SqlProcduceCommand(Command);
            if (DatabaseControlService.SQL.DataTableHasValues()) return true;
            return false;
        }

        public bool CheckTelephone()
        {
            string Command = "SELECT Telephone FROM Clients WHERE Telephone = ('" + Telephone + "') AND Client_ID != " + Client_ID;

            DatabaseControlService.SQL.SqlProcduceCommand(Command);
            if (DatabaseControlService.SQL.DataTableHasValues()) return true;
            return false;
        }

        public bool CheckAll()
        {
            string Command = "SELECT Telephone FROM Clients WHERE Telephone = ('" + Telephone + "')";

            DatabaseControlService.SQL.SqlProcduceCommand(Command);
            if (DatabaseControlService.SQL.DataTableHasValues()) return true;
            return false;
        }

        public bool CheckAddress()
        {
            string Command = "SELECT Address FROM Clients WHERE Address = ('" + Address + "') AND Client_ID != " + Client_ID;

            DatabaseControlService.SQL.SqlProcduceCommand(Command);
            if (DatabaseControlService.SQL.DataTableHasValues()) return true;
            return false;
        }

        public void LoadData(DataGridView DG)
        {
            DatabaseControlService.SQL.SqlProcduceCommand(SelectAll());
            if (DatabaseControlService.SQL.DataTableHasValues())
                Client_ID = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[DG.SelectedRows[0].Index][0]);
            LoadData();
        }

        public void LoadData()
        {
            string Command = "SELECT Family, Name, Surname, Telephone, Address  FROM Clients WHERE Client_ID = " + Client_ID;

            DatabaseControlService.SQL.SqlProcduceCommand(Command);
            if (DatabaseControlService.SQL.DataTableHasValues())
            {
                Family = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][0].ToString();
                Name = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][1].ToString();
                Surname = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][2].ToString();
                Telephone = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][3].ToString();
                Address = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][4].ToString();
            }
        }

        public void LoadData(DataSet DS, int RowNumber)
        {
            if (DatabaseControlService.SQL.DataTableHasValues(DS, "Table", RowNumber))
            {
                Client_ID = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][0]);
                Family = DS.Tables["Table"].Rows[RowNumber][1].ToString();
                Name = DS.Tables["Table"].Rows[RowNumber][2].ToString();
                Surname = DS.Tables["Table"].Rows[RowNumber][3].ToString();
                Discount = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][4]);
                Purchases = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][5]);
                Orders_Count = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][6]);
                Telephone = DS.Tables["Table"].Rows[RowNumber][7].ToString();
                Address = DS.Tables["Table"].Rows[RowNumber][8].ToString();
                Total_Spended = Convert.ToDecimal(DatabaseControlService.ConvertDecimal(DS.Tables["Table"].Rows[RowNumber][9].ToString()));
            }
        }

        public static string SelectAll()
        {
            return "SELECT * FROM Clients";
        }

        public string Insert() 
        {
            return "INSERT INTO Clients(Family, Name, Surname, Telephone, Address) VALUES('" + Family + "','" + Name + "','" + Surname + "','" + Telephone + "','" + Address + "')";
        }

        public string Update()
        {
            return "UPDATE Clients SET Family = '" + Family + "', Name = '" + Name + "', Surname = '" + Surname + "', Telephone = '" + Telephone + "', Address = '" + Address + "' WHERE Client_ID = " + Client_ID;
        }

        public string Delete()
        {
            return "DELETE FROM Clients WHERE Family = '" + Family + "' AND Name = '" + Name + "' AND Surname = '" + Surname + "' AND Telephone = '" + Telephone + "' AND Address = '" + Address + "'";
        }

        public string ViewAll()
        {
            return "SELECT * FROM ViewClients";
        }

        public static void SaveToXML()
        {
            try
            {
                DatabaseControlService.SQL.SqlProcduceCommand(SelectAll());
                DatabaseControlService.SQL.SQLDS.WriteXml("XML\\Clients.XML");
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
                Clients DB = new Clients();
                DatabaseControlService.SQL.SQLDS = new DataSet();
                DatabaseControlService.SQL.SQLDS.ReadXml("XML\\Clients.XML");
                DataSet Base = new DataSet();
                Base.ReadXml("XML\\Clients.XML");
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
                            int ID = DatabaseControlService.SQL.GetIDByValue(DB.Telephone, 7, 0);
                            DB.Client_ID = ID;
                            DatabaseControlService.SQL.SqlProcduceTransactionCommand(DB.Update());
                        }
                    }
                    DatabaseControlService.SQL.SQLDS = new DataSet();
                    DatabaseControlService.SQL.SQLDS.ReadXml("XML\\Clients.XML");
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("XML ERROR: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
