using System;
using System.Data;
using System.Windows.Forms;
using DBAutoShop.Controllers;

namespace DBAutoShop.ORM
{
    class Sells
    {
        private int _sell_id;
        private int _auto_id;
        private int _color_id;
        private int _client_id;
        private int _worker_id;
        private int _office_id;
        private string _no_body;
        private string _no_engine;
        private string _no_PTC;
        private string _complectation;
        private int _sell_discount;
        private decimal _sell_cost;
        private DateTime _receipt_date;
        private DateTime _sell_date;
        private DateTime _dissapear_date;
        private byte _selled_check;

        public int Sell_ID
        {
            get { return _sell_id; }
            set { _sell_id = value; }
        }

        public int Auto_ID
        {
            get { return _auto_id; }
            set { _auto_id = value; }
        }

        public int Color_ID
        {
            get { return _color_id; }
            set { _color_id = value; }
        }

        public int Client_ID
        {
            get { return _client_id; }
            set { _client_id = value; }
        }

        public int Worker_ID
        {
            get { return _worker_id; }
            set { _worker_id = value; }
        }

        public int Office_ID
        {
            get { return _office_id; }
            set { _office_id = value; }
        }

        public string No_body
        {
            get { return _no_body; }
            set { _no_body = value; }
        }

        public string No_engine
        {
            get { return _no_engine; }
            set { _no_engine = value; }
        }

        public string No_PTC
        {
            get { return _no_PTC; }
            set { _no_PTC = value; }
        }

        public string Complectation
        {
            get { return _complectation; }
            set { _complectation = value; }
        }

        public int Sell_Discount
        {
            get { return _sell_discount; }
            set { _sell_discount = value; }
        }

        public decimal Sell_Cost
        {
            get { return _sell_cost; }
            set { _sell_cost = value; }
        }

        public DateTime Receipt_date
        {
            get { return _receipt_date; }
            set { _receipt_date = value; }
        }

        public DateTime Sell_Date
        {
            get { return _sell_date; }
            set { _sell_date = value; }
        }

        public DateTime Dissapear_Date
        {
            get { return _dissapear_date; }
            set { _dissapear_date = value; }
        }

        public byte Selled_Check
        {
            get { return _selled_check; }
            set { _selled_check = value; }
        }

        public void Reset()
        {
            Sell_ID = 0;
            Auto_ID = 0;
            Color_ID = 0;
            Client_ID = 0;
            Worker_ID = 0;
            Office_ID = 0;
            No_body = "";
            No_engine = "";
            No_PTC = "";
            Complectation = "";
            Sell_Discount = 0;
            Sell_Cost = 0;
            Receipt_date = DateTime.Now;
            Sell_Date = DateTime.Now;
            Dissapear_Date = DateTime.Now;
            Selled_Check = 0;
        }

        public void GetID()
        {
            string Query = "SELECT Sell_ID FROM Sells WHERE Auto_ID = " + Auto_ID + " AND Color_ID = " + Color_ID + " AND Client_ID = " + Client_ID + " AND Worker_ID = " + Worker_ID + " AND Office_ID = " + Office_ID + " AND No_body = " + No_body + " AND No_engine = " + No_engine + " AND No_PTC = " + No_PTC + " AND Complectation = '" + Complectation + "' AND Sell_Discount = " + Sell_Discount + " AND Sell_Cost = " + DatabaseControlService.QBuilder.ConvertParameter(Sell_Cost) + " AND Receipt_Date = '" + Receipt_date + "' AND Sell_Date = '" + Sell_Date + "' AND Dissapear_Date = '" + Dissapear_Date + "' AND Selled_Check = " + Selled_Check;
            Sell_ID = DatabaseControlService.GetElementID(Query, 0);
        }

        public bool CheckUse()
        {
            return false;
        }

        public bool CheckAll()
        {
            string Command = "SELECT * FROM Sells WHERE No_PTC = ('" + No_PTC + "')";

            DatabaseControlService.SQL.SqlProcduceCommand(Command);
            if (DatabaseControlService.SQL.DataTableHasValues()) return true;
            return false;
        }

        public bool CheckNoBody()
        {
            string Command = "SELECT * FROM Sells WHERE No_body = ('" + No_body + "') AND Sell_ID != " + Sell_ID;

            DatabaseControlService.SQL.SqlProcduceCommand(Command);
            if (DatabaseControlService.SQL.DataTableHasValues()) return true;
            return false;
        }

        public bool CheckNoEngine()
        {
            string Command = "SELECT * FROM Sells WHERE No_engine = ('" + No_engine + "') AND Sell_ID != " + Sell_ID;

            DatabaseControlService.SQL.SqlProcduceCommand(Command);
            if (DatabaseControlService.SQL.DataTableHasValues()) return true;
            return false;
        }

        public bool CheckNoPTC()
        {
            string Command = "SELECT * FROM Sells WHERE No_PTC = ('" + No_PTC + "') AND Sell_ID != " + Sell_ID;

            DatabaseControlService.SQL.SqlProcduceCommand(Command);
            if (DatabaseControlService.SQL.DataTableHasValues()) return true;
            return false;
        }

        public void LoadData(DataGridView DG)
        {
            DatabaseControlService.SQL.SqlProcduceCommand(SelectAll());
            if (DatabaseControlService.SQL.DataTableHasValues())
                Sell_ID = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[DG.SelectedRows[0].Index][0]);
            LoadData();
        }

        public void LoadData()
        {
            string Command = "SELECT Auto_ID, Color_ID, Client_ID, Worker_ID, Office_ID, No_body, No_engine, No_PTC, Complectation, Sell_Discount, Sell_Cost, Receipt_Date, Sell_Date, Dissapear_Date, Selled_Check FROM Sells WHERE Sell_ID = " + Sell_ID;

            DatabaseControlService.SQL.SqlProcduceCommand(Command);
            if (DatabaseControlService.SQL.DataTableHasValues())
            {
                Auto_ID = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][0]);
                Color_ID = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][1]);
                if (DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][2].ToString() != "")
                    Client_ID = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][2]);
                if (DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][3].ToString() != "")
                    Worker_ID = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][3]);
                Office_ID = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][4]);
                No_body = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][5].ToString();
                No_engine = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][6].ToString();
                No_PTC = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][7].ToString();
                Complectation = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][8].ToString();
                Sell_Discount = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][9]);
                Sell_Cost = Convert.ToDecimal(DatabaseControlService.ConvertDecimal(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][10].ToString()));
                Receipt_date = Convert.ToDateTime(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][11]);
                if (DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][12].ToString() != "")
                    Sell_Date = Convert.ToDateTime(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][12]);
                if (DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][13].ToString() != "")
                    Dissapear_Date = Convert.ToDateTime(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][13]);
                Selled_Check = Convert.ToByte(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][14]);
            }
        }

        public void LoadData(DataSet DS, int RowNumber)
        {
            if (DatabaseControlService.SQL.DataTableHasValues(DS, "Table", RowNumber))
            {
                int MethodID = 0;
                Sell_ID = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][0]);
                Auto_ID = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][1]);
                Color_ID = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][2]);
                if (DS.Tables["Table"].Rows[0][3].ToString() != "" && DS.Tables["Table"].Columns[3].ColumnName == "Client_ID")
                    Client_ID = Convert.ToInt32(DS.Tables["Table"].Rows[0][3]);
                if (DS.Tables["Table"].Rows[0][4].ToString() != "" && DS.Tables["Table"].Columns[4].ColumnName == "Worker_ID")
                    Worker_ID = Convert.ToInt32(DS.Tables["Table"].Rows[0][4]);
                if (DS.Tables["Table"].Rows[0][3].ToString() != "" && DS.Tables["Table"].Columns[3].ColumnName == "Worker_ID")
                    Worker_ID = Convert.ToInt32(DS.Tables["Table"].Rows[0][4]);
                if (DS.Tables["Table"].Columns[5].ColumnName == "Office_ID") MethodID = 1;
                if (DS.Tables["Table"].Columns[4].ColumnName == "Office_ID") MethodID = 2;
                if (DS.Tables["Table"].Columns[3].ColumnName == "Office_ID") MethodID = 3;
                switch (MethodID)
                {
                    case 1:
                        {
                            Office_ID = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][5]);
                            No_body = DS.Tables["Table"].Rows[RowNumber][6].ToString();
                            No_engine = DS.Tables["Table"].Rows[RowNumber][7].ToString();
                            No_PTC = DS.Tables["Table"].Rows[RowNumber][8].ToString();
                            Complectation = DS.Tables["Table"].Rows[RowNumber][9].ToString();
                            Sell_Discount = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][10]);
                            Sell_Cost = Convert.ToDecimal(DatabaseControlService.ConvertDecimal(DS.Tables["Table"].Rows[RowNumber][11].ToString()));
                            Receipt_date = Convert.ToDateTime(DS.Tables["Table"].Rows[RowNumber][12]);
                            if (DS.Tables["Table"].Rows[0][13].ToString() != "")
                                Sell_Date = Convert.ToDateTime(DS.Tables["Table"].Rows[0][13]);
                            if (DS.Tables["Table"].Rows[0][14].ToString() != "")
                                Dissapear_Date = Convert.ToDateTime(DS.Tables["Table"].Rows[0][14]);
                            Selled_Check = Convert.ToByte(DS.Tables["Table"].Rows[RowNumber][15]);
                            break;
                        }
                    case 2:
                        {
                            Office_ID = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][4]);
                            No_body = DS.Tables["Table"].Rows[RowNumber][5].ToString();
                            No_engine = DS.Tables["Table"].Rows[RowNumber][6].ToString();
                            No_PTC = DS.Tables["Table"].Rows[RowNumber][7].ToString();
                            Complectation = DS.Tables["Table"].Rows[RowNumber][8].ToString();
                            Sell_Discount = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][9]);
                            Sell_Cost = Convert.ToDecimal(DatabaseControlService.ConvertDecimal(DS.Tables["Table"].Rows[RowNumber][10].ToString()));
                            Receipt_date = Convert.ToDateTime(DS.Tables["Table"].Rows[RowNumber][11]);
                            if (DS.Tables["Table"].Rows[0][12].ToString() != "")
                                Sell_Date = Convert.ToDateTime(DS.Tables["Table"].Rows[0][12]);
                            if (DS.Tables["Table"].Rows[0][13].ToString() != "")
                                Dissapear_Date = Convert.ToDateTime(DS.Tables["Table"].Rows[0][13]);
                            Selled_Check = Convert.ToByte(DS.Tables["Table"].Rows[RowNumber][14]);
                            break;
                        }
                    case 3:
                        {
                            Office_ID = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][3]);
                            No_body = DS.Tables["Table"].Rows[RowNumber][4].ToString();
                            No_engine = DS.Tables["Table"].Rows[RowNumber][5].ToString();
                            No_PTC = DS.Tables["Table"].Rows[RowNumber][6].ToString();
                            Complectation = DS.Tables["Table"].Rows[RowNumber][7].ToString();
                            Sell_Discount = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][8]);
                            Sell_Cost = Convert.ToDecimal(DatabaseControlService.ConvertDecimal(DS.Tables["Table"].Rows[RowNumber][9].ToString()));
                            Receipt_date = Convert.ToDateTime(DS.Tables["Table"].Rows[RowNumber][10]);
                            if (DS.Tables["Table"].Rows[0][11].ToString() != "")
                                Sell_Date = Convert.ToDateTime(DS.Tables["Table"].Rows[0][11]);
                            if (DS.Tables["Table"].Rows[0][12].ToString() != "")
                                Dissapear_Date = Convert.ToDateTime(DS.Tables["Table"].Rows[0][12]);
                            Selled_Check = Convert.ToByte(DS.Tables["Table"].Rows[RowNumber][13]);
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("ERROR!!!");
                            break;
                        }
                }

            }
        }

        public string Insert()
        {
            return "INSERT INTO Sells(Auto_ID, Color_ID, Client_ID, Worker_ID, Office_ID, No_body, No_engine, No_PTC, Complectation, Sell_Discount, Sell_Cost, Receipt_Date, Sell_Date, Dissapear_Date, Selled_Check) VALUES(" + Auto_ID + "," + Color_ID + "," +  DatabaseControlService.QBuilder.ConvertParameterNULL(Client_ID) + ", " +  DatabaseControlService.QBuilder.ConvertParameterNULL(Worker_ID) + ", " + Office_ID + ", '" + No_body + "', '" + No_engine + "', '" + No_PTC + "', '" + Complectation + "', "  + Sell_Discount + " , " + DatabaseControlService.QBuilder.ConvertParameter(Sell_Cost) + ", '" + Receipt_date + "', " + DatabaseControlService.QBuilder.ConvertParameterNULL(Sell_Date) + ", " + DatabaseControlService.QBuilder.ConvertParameterNULL(Dissapear_Date) + ", " + Selled_Check + ")";
        }

        public string Update()
        {
            return "UPDATE Sells SET Auto_ID = " + Auto_ID + " , Color_ID = " + Color_ID + " , Client_ID = " + DatabaseControlService.QBuilder.ConvertParameterNULL(Client_ID) + " , Worker_ID = " + DatabaseControlService.QBuilder.ConvertParameterNULL(Worker_ID) + " , No_body = '" + No_body + "' , No_engine = '" + No_engine + "' , No_PTC = '" + No_PTC + "' , Complectation = '" + Complectation + "' , Sell_Discount = " + Sell_Discount + " , Sell_Cost = " + DatabaseControlService.QBuilder.ConvertParameter(Sell_Cost) + " , Receipt_Date = '" + Receipt_date + "' , Sell_Date = " + DatabaseControlService.QBuilder.ConvertParameterNULL(Sell_Date) + " , Dissapear_Date = " + DatabaseControlService.QBuilder.ConvertParameterNULL(Dissapear_Date) + " , Selled_Check = " + Selled_Check + " WHERE Sell_ID = " + Sell_ID;
        }

        public string Delete()
        {
            return "DELETE FROM Sells WHERE Sell_ID = " + Sell_ID + " AND Auto_ID = " + Auto_ID + " AND Color_ID = " + Color_ID + " AND Office_ID = " + Office_ID + " AND No_body = '" + No_body + "' AND No_engine = '" + No_engine + "' AND No_PTC = '" + No_PTC + "' AND Complectation = '" + Complectation + "' AND Sell_Discount = " + Sell_Discount + " AND Sell_Cost = " + DatabaseControlService.QBuilder.ConvertParameter(Sell_Cost) + " AND Receipt_Date = '" + Receipt_date + "' AND Sell_Date = " + DatabaseControlService.QBuilder.ConvertParameterNULL(Sell_Date) + " AND Dissapear_Date = " + DatabaseControlService.QBuilder.ConvertParameterNULL(Dissapear_Date) + " AND Selled_Check = " + Selled_Check;
        }

        public static string SelectAll()
        {
            return "SELECT * FROM Sells";
        }

        public string ViewAll()
        {
            return "SELECT * FROM ViewSells";
        }

        public static void SaveToXML()
        {
            try
            {
                AutomobilesData.SaveToXML();
                Colors.SaveToXML();
                Clients.SaveToXML();
                Workers.SaveToXML();
                Offices.SaveToXML();

                DatabaseControlService.SQL.SqlProcduceCommand(SelectAll());
                DatabaseControlService.SQL.SQLDS.WriteXml("XML\\Sells.XML");
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
                Colors.LoadFromXML();
                Clients.LoadFromXML();
                Workers.LoadFromXML();
                Offices.LoadFromXML();

                Sells DB = new Sells();
                DatabaseControlService.SQL.SQLDS = new DataSet();
                DatabaseControlService.SQL.SQLDS.ReadXml("XML\\Sells.XML");
                DataSet Base = new DataSet();
                Base.ReadXml("XML\\Sells.XML");
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
                        DatabaseControlService.SQL.SQLDS.ReadXml("XML\\Colors.XML");
                        OLD_Name = DatabaseControlService.SQL.GetValueByID(OLD_ValueID, 1, 0);
                        Base.Tables["Table"].Rows[i][2] = DatabaseControlService.DBECS.GetColorIDByColorName(OLD_Name);

                        if (Base.Tables["Table"].Rows[i][3].ToString() != "" && Base.Tables["Table"].Columns[3].ColumnName == "Client_ID")
                        {
                            OLD_ValueID = Convert.ToInt32(Base.Tables["Table"].Rows[i][3]);
                            DatabaseControlService.SQL.SQLDS = new DataSet();
                            DatabaseControlService.SQL.SQLDS.ReadXml("XML\\Clients.XML");
                            OLD_Name = DatabaseControlService.SQL.GetValueByID(OLD_ValueID, 7, 0);
                            Base.Tables["Table"].Rows[i][3] = DatabaseControlService.DBECS.GetClientIDByTelephone(OLD_Name);
                        }

                        if (Base.Tables["Table"].Rows[i][4].ToString() != "" && Base.Tables["Table"].Columns[4].ColumnName == "Worker_ID")
                        {
                            OLD_ValueID = Convert.ToInt32(Base.Tables["Table"].Rows[i][4]);
                            DatabaseControlService.SQL.SQLDS = new DataSet();
                            DatabaseControlService.SQL.SQLDS.ReadXml("XML\\Workers.XML");
                            OLD_Name = DatabaseControlService.SQL.GetValueByID(OLD_ValueID, 4, 0);
                            Base.Tables["Table"].Rows[i][4] = DatabaseControlService.DBECS.GetWorkerIDByTelephone(OLD_Name);
                        }

                        if (Base.Tables["Table"].Rows[i][3].ToString() != "" && Base.Tables["Table"].Columns[3].ColumnName == "Worker_ID")
                        {
                            OLD_ValueID = Convert.ToInt32(Base.Tables["Table"].Rows[i][3]);
                            DatabaseControlService.SQL.SQLDS = new DataSet();
                            DatabaseControlService.SQL.SQLDS.ReadXml("XML\\Workers.XML");
                            OLD_Name = DatabaseControlService.SQL.GetValueByID(OLD_ValueID, 4, 0);
                            Base.Tables["Table"].Rows[i][3] = DatabaseControlService.DBECS.GetWorkerIDByTelephone(OLD_Name);
                        }

                        if (Base.Tables["Table"].Rows[i][5].ToString() != "" && Base.Tables["Table"].Columns[5].ColumnName == "Office_ID")
                        {
                            OLD_ValueID = Convert.ToInt32(Base.Tables["Table"].Rows[i][5]);
                            DatabaseControlService.SQL.SQLDS = new DataSet();
                            DatabaseControlService.SQL.SQLDS.ReadXml("XML\\Offices.XML");
                            OLD_Name = DatabaseControlService.SQL.GetValueByID(OLD_ValueID, 1, 0);
                            Base.Tables["Table"].Rows[i][5] = DatabaseControlService.DBECS.GetOfficeIDByOfficeName(OLD_Name);
                        }

                        if (Base.Tables["Table"].Rows[i][4].ToString() != "" && Base.Tables["Table"].Columns[4].ColumnName == "Office_ID")
                        {
                            OLD_ValueID = Convert.ToInt32(Base.Tables["Table"].Rows[i][4]);
                            DatabaseControlService.SQL.SQLDS = new DataSet();
                            DatabaseControlService.SQL.SQLDS.ReadXml("XML\\Offices.XML");
                            OLD_Name = DatabaseControlService.SQL.GetValueByID(OLD_ValueID, 1, 0);
                            Base.Tables["Table"].Rows[i][4] = DatabaseControlService.DBECS.GetOfficeIDByOfficeName(OLD_Name);
                        }

                        if (Base.Tables["Table"].Rows[i][3].ToString() != "" && Base.Tables["Table"].Columns[3].ColumnName == "Office_ID")
                        {
                            OLD_ValueID = Convert.ToInt32(Base.Tables["Table"].Rows[i][3]);
                            DatabaseControlService.SQL.SQLDS = new DataSet();
                            DatabaseControlService.SQL.SQLDS.ReadXml("XML\\Offices.XML");
                            OLD_Name = DatabaseControlService.SQL.GetValueByID(OLD_ValueID, 1, 0);
                            Base.Tables["Table"].Rows[i][3] = DatabaseControlService.DBECS.GetOfficeIDByOfficeName(OLD_Name);
                        }

                        DB.Reset();
                        DB.LoadData(Base, i);
                        if (!DB.CheckAll())
                            DatabaseControlService.SQL.SqlProcduceTransactionCommand(DB.Insert());
                        else
                        {
                            DatabaseControlService.SQL.SqlProcduceCommand(SelectAll());
                            int ID = DatabaseControlService.SQL.GetIDByValue(DB.No_PTC, 8, 0);
                            DB.Sell_ID = ID;
                            DatabaseControlService.SQL.SqlProcduceTransactionCommand(DB.Update());
                        }
                    }
                    DatabaseControlService.SQL.SQLDS = new DataSet();
                    DatabaseControlService.SQL.SQLDS.ReadXml("XML\\Sells.XML");
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("XML ERROR: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
