using System;
using System.Data;
using System.Windows.Forms;
using DBAutoShop.Controllers;

namespace DBAutoShop.ORM
{
    class Orders
    {
        private int _order_id;
        private int _auto_id;
        private int _client_id;
        private DateTime _order_date;
        private string _order_condition;

        public int Order_ID
        {
            get { return _order_id; }
            set { _order_id = value; }
        }

        public int Auto_ID
        {
            get { return _auto_id; }
            set { _auto_id = value; }
        }

        public int Client_ID
        {
            get { return _client_id; }
            set { _client_id = value; }
        }

        public DateTime Order_Date
        {
            get { return _order_date; }
            set { _order_date = value; }
        }

        public string Order_Condition
        {
            get { return _order_condition; }
            set { _order_condition = value; }
        }


        public static string SelectAll()
        {
            return "SELECT * FROM Orders";
        }

        public void Reset()
        {
            Order_ID = 0;
            Auto_ID = 0;
            Client_ID = 0;
            Order_Date = DateTime.Now;
            Order_Condition = "";
        }

        public bool CheckUse()
        {
            return false;
        }

        public bool CheckAll()
        {
            string Command = "SELECT Auto_ID, Client_ID, Order_Date, Order_Condition FROM Orders WHERE Auto_ID = " + Auto_ID + " AND Client_ID = " + Client_ID + " AND Order_Date = ('" + Order_Date + "') AND Order_Condition = ('" + Order_Condition + "')";

            DatabaseControlService.SQL.SqlProcduceCommand(Command);
            if (DatabaseControlService.SQL.DataTableHasValues()) return true;
            return false;
        }

        public void GetID()
        {
            string Query = "SELECT Order_ID FROM Orders WHERE Auto_ID = " + Auto_ID + " AND Client_ID = " + Client_ID + " AND Order_Date = ('" + Order_Date + "') AND Order_Condition = ('" + Order_Condition + "')";
            Order_ID = DatabaseControlService.GetElementID(Query, 0);
        }

        public void LoadData(DataGridView DG)
        {
            DatabaseControlService.SQL.SqlProcduceCommand(SelectAll());
            if (DatabaseControlService.SQL.DataTableHasValues())
                Order_ID = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[DG.SelectedRows[0].Index][0]);
            LoadData();
        }

        public void LoadData()
        {
            string Command = "SELECT Auto_ID, Client_ID, Order_Date, Order_Condition FROM Orders WHERE Order_ID = " + Order_ID;

            DatabaseControlService.SQL.SqlProcduceCommand(Command);
            if (DatabaseControlService.SQL.DataTableHasValues())
            {
                Auto_ID = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][0]);
                Client_ID = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][1]);
                Order_Date = Convert.ToDateTime(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][2]);
                Order_Condition = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][3].ToString();
            }
        }

        public void LoadData(DataSet DS, int RowNumber)
        {
            if (DatabaseControlService.SQL.DataTableHasValues(DS, "Table", RowNumber))
            {
                Order_ID = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][0]);
                Auto_ID = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][1]);
                Client_ID = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][2]);
                Order_Date = Convert.ToDateTime(DS.Tables["Table"].Rows[RowNumber][3]);
                Order_Condition = DS.Tables["Table"].Rows[RowNumber][4].ToString();
            }
        }

        public string Insert()
        {
            return "INSERT INTO Orders(Auto_ID, Client_ID, Order_Date, Order_Condition) VALUES(" + Auto_ID + ", " + Client_ID + ", ('" + Order_Date + "') , '" + Order_Condition + "')";
        }

        public string Update()
        {
            return "UPDATE Orders SET Auto_ID = " + Auto_ID + ", Client_ID = " + Client_ID + ", Order_Date = ('" + Order_Date + "'), Order_Condition = ('" + Order_Condition + "')  WHERE Order_ID = " + Order_ID;
        }

        public string Delete()
        {
            return "DELETE FROM Orders WHERE Order_ID = " + Order_ID + " AND Auto_ID = " + Auto_ID + " AND Client_ID = " + Client_ID + " AND Order_Date = ('" + Order_Date + "') AND Order_Condition = ('" + Order_Condition + "')";
        }

        public string ViewAll()
        {
            return "SELECT * FROM ViewOrders";
        }

        public static void SaveToXML()
        {
            try
            {
                AutomobilesData.SaveToXML();
                Clients.SaveToXML();

                DatabaseControlService.SQL.SqlProcduceCommand(SelectAll());
                DatabaseControlService.SQL.SQLDS.WriteXml("XML\\Orders.XML");
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
                AutomobilesData.LoadFromXML();
                Clients.LoadFromXML();

                Orders DB = new Orders();
                DatabaseControlService.SQL.SQLDS = new DataSet();
                DatabaseControlService.SQL.SQLDS.ReadXml("XML\\Orders.XML");
                DataSet Base = new DataSet();
                Base.ReadXml("XML\\Orders.XML");
                if (Base.Tables.Count == 0) return;
                if (DatabaseControlService.SQL.DataTableHasValues())
                {
                    for (int i = 0; i < Base.Tables["Table"].Rows.Count; i++)
                    {
                        int OLD_ValueID = Convert.ToInt32(Base.Tables["Table"].Rows[i][1]);
                        DatabaseControlService.SQL.SQLDS = new DataSet();
                        DatabaseControlService.SQL.SQLDS.ReadXml("XML\\AutomobilesData.XML");
                        string OLD_Name = DatabaseControlService.SQL.GetValueByID(OLD_ValueID, 3, 0);
                        Base.Tables["Table"].Rows[i][1] = DatabaseControlService.DBECS.GetAutoIDByModel(OLD_Name);

                        OLD_ValueID = Convert.ToInt32(Base.Tables["Table"].Rows[i][2]);
                        DatabaseControlService.SQL.SQLDS = new DataSet();
                        DatabaseControlService.SQL.SQLDS.ReadXml("XML\\Clients.XML");
                        OLD_Name = DatabaseControlService.SQL.GetValueByID(OLD_ValueID, 7, 0);
                        Base.Tables["Table"].Rows[i][2] = DatabaseControlService.DBECS.GetClientIDByTelephone(OLD_Name);

                        DB.Reset();
                        DB.LoadData(Base, i);
                        if (!DB.CheckAll())
                            DatabaseControlService.SQL.SqlProcduceTransactionCommand(DB.Insert());
                        else
                        {
                            DatabaseControlService.SQL.SqlProcduceCommand(SelectAll());
                            int ID = DatabaseControlService.SQL.GetIDByAllString(DB.Auto_ID + " " + DB.Client_ID + " " + DB.Order_Date + " " + DB.Order_Condition, 0);
                            DB.Order_ID = ID;
                            DatabaseControlService.SQL.SqlProcduceTransactionCommand(DB.Update());
                        }
                    }
                    DatabaseControlService.SQL.SQLDS = new DataSet();
                    DatabaseControlService.SQL.SQLDS.ReadXml("XML\\Orders.XML");
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("XML ERROR: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
