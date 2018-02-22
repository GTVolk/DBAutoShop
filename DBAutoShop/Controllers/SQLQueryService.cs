using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace DBAutoShop.Controllers
{
    class SQLQueryService
    {
        public string ConnectString;
        public DataSet SQLDS;
        public SQLQueryService()
        {
            string ProgramPath = Application.StartupPath;
            ConnectString = "Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog=AutoShop;";
            SQLDS = new DataSet();
        }

        public bool CheckConnection(string ConnectionStr)
        {
            using (SqlConnection SQLCon = new SqlConnection())
            {
                try
                {
                    SQLCon.ConnectionString = ConnectionStr;
                    SQLCon.Open();

                    if (SQLCon.State == ConnectionState.Open) return true;
                    else return false;
                }
                catch
                {
                }
            }
            return false;
        }

        public bool CheckConnection()
        {
            using (SqlConnection SQLCon = new SqlConnection())
            {
                try
                {
                    SQLCon.ConnectionString = ConnectString;
                    SQLCon.Open();

                    if (SQLCon.State == ConnectionState.Open) return true;
                    else return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SQL ERROR: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
        }

        public string GetValueByID(int ID, int ItemIndex, int IndexesColumn)
        {
            if (DataTableHasValues())
            {
                for (int i = 0; i < SQLDS.Tables["Table"].Rows.Count; i++)
                {
                    int _id = Convert.ToInt32(SQLDS.Tables["Table"].Rows[i][IndexesColumn]);
                    if (_id == ID) return SQLDS.Tables["Table"].Rows[i][ItemIndex].ToString();
                }
            }
            return "";
        }

        public int GetIDByValue(string UniqueString, int ItemIndex, int IndexesColumn)
        {
            if (DataTableHasValues())
            {
                for (int i = 0; i < SQLDS.Tables["Table"].Rows.Count; i++)
                {
                    string _str = SQLDS.Tables["Table"].Rows[i][ItemIndex].ToString();
                    if (_str == UniqueString) return Convert.ToInt32(SQLDS.Tables["Table"].Rows[i][IndexesColumn]);
                }
            }
            return 0;
        }

        public int GetIDByAllString(string SearchString, int IndexesColumn)
        {
            if (DataTableHasValues())
            {
                for (int i = 0; i < SQLDS.Tables["Table"].Rows.Count; i++)
                {
                    string str = "";
                    for (int j = 1; j < SQLDS.Tables["Table"].Columns.Count; j++)
                        if (j == 1) str = str + SQLDS.Tables["Table"].Rows[i][j].ToString();
                        else str = str + " " + SQLDS.Tables["Table"].Rows[i][j].ToString();
                    if (str == SearchString) return Convert.ToInt32(SQLDS.Tables["Table"].Rows[i][IndexesColumn]);
                }
            }
            return 0;
        }

        public string GetValueByID(DataSet _ds, int ID, int ItemIndex, int TableID, int IndexesColumn)
        {
            if (DataTableHasValues(_ds, TableID))
            {
                for (int i = 0; i < _ds.Tables[TableID].Rows.Count; i++)
                {
                    int _id = Convert.ToInt32(_ds.Tables[TableID].Rows[i][IndexesColumn]);
                    if (_id == ID) return _ds.Tables[TableID].Rows[i][ItemIndex].ToString();
                }
            }
            return "";
        }

        public string GetValueByID(DataSet _ds, int ID, int ItemIndex, string TableID, int IndexesColumn)
        {
            if (DataTableHasValues(_ds, TableID))
            {
                for (int i = 0; i < _ds.Tables[TableID].Rows.Count; i++)
                {
                    int _id = Convert.ToInt32(_ds.Tables[TableID].Rows[i][IndexesColumn]);
                    if (_id == ID) return _ds.Tables[TableID].Rows[i][ItemIndex].ToString();
                }
            }
            return "";
        }

        public int GetIDByValue(DataSet _ds, string UniqueString, int ItemIndex, int TableID, int IndexesColumn)
        {
            if (DataTableHasValues(_ds, "Table"))
            {
                for (int i = 0; i < _ds.Tables[TableID].Rows.Count; i++)
                {
                    string _str = _ds.Tables["Table"].Rows[i][ItemIndex].ToString();
                    if (_str == UniqueString) return Convert.ToInt32(_ds.Tables[TableID].Rows[i][IndexesColumn]);
                }
            }
            return 0;
        }

        public int GetIDByValue(DataSet _ds, string UniqueString, int ItemIndex, string TableID, int IndexesColumn)
        {
            if (DataTableHasValues(_ds, "Table"))
            {
                for (int i = 0; i < _ds.Tables[TableID].Rows.Count; i++)
                {
                    string _str = _ds.Tables["Table"].Rows[i][ItemIndex].ToString();
                    if (_str == UniqueString) return Convert.ToInt32(_ds.Tables[TableID].Rows[i][IndexesColumn]);
                }
            }
            return 0;
        }

        public bool DataTableHasValues(DataSet _ds, int TableID)
        {
            if (SQLDS.Tables[TableID].Columns.Count > 0)
                if (SQLDS.Tables[TableID].Rows.Count > 0)
                    return true;
            return false;
        }

        public bool DataTableHasValues(DataSet _ds, string TableID)
        {
            if (_ds.Tables[TableID].Columns.Count > 0)
                if (_ds.Tables[TableID].Rows.Count > 0)
                    return true;
            return false;
        }

        public bool DataTableHasValues(DataSet _ds, int TableID, int RowsNumber)
        {
            if (SQLDS.Tables[TableID].Columns.Count > 0)
                if (SQLDS.Tables[TableID].Rows.Count >= RowsNumber)
                    return true;
            return false;
        }

        public bool DataTableHasValues(DataSet _ds, string TableID, int RowsNumber)
        {
            if (_ds.Tables[TableID].Columns.Count > 0)
                if (_ds.Tables[TableID].Rows.Count >= RowsNumber)
                    return true;
            return false;
        }

        public bool DataTableHasValues()
        {
            if (SQLDS.Tables["Table"].Columns.Count > 0)
                if (SQLDS.Tables["Table"].Rows.Count > 0)
                    return true;
            return false;
        }

        public void SqlProcduceCommand(DataGridView DG, string CommandText)
        {
            SQLDS = new DataSet();
            using (SqlConnection SQLCon = new SqlConnection())
            {
                try
                {
                    SQLCon.ConnectionString = ConnectString;
                    SQLCon.Open();

                    SqlCommand SQLCommand = new SqlCommand();
                    SqlDataAdapter SQLData = new SqlDataAdapter();
                    SQLDS = new DataSet();

                    SQLCommand.Connection = SQLCon;
                    SQLCommand.CommandText = CommandText;
                    SQLData.SelectCommand = SQLCommand;

                    SQLData.Fill(SQLDS, "Table");
                    if (SQLDS.Tables.Count > 0)
                        DG.DataSource = SQLDS.Tables["Table"].DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SQL ERROR: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void SqlProcduceCommand(string CommandText)
        {
            SQLDS = new DataSet();
            using (SqlConnection SQLCon = new SqlConnection())
            {
                try
                {
                    SQLCon.ConnectionString = ConnectString;
                    SQLCon.Open();

                    SqlCommand SQLCommand = new SqlCommand();
                    SqlDataAdapter SQLData = new SqlDataAdapter();

                    SQLCommand.Connection = SQLCon;
                    SQLCommand.CommandText = CommandText;
                    SQLData.SelectCommand = SQLCommand;

                    SQLData.Fill(SQLDS, "Table");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SQL ERROR: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void SqlProcduceTransactionCommand(string CommandText)
        {
            using (SqlConnection SQLCon = new SqlConnection())
            {
                try
                {
                    SQLCon.ConnectionString = ConnectString;
                    SQLCon.Open();

                    SqlCommand SQLCommand = SQLCon.CreateCommand();
                    SQLCommand.Transaction = SQLCon.BeginTransaction(System.Data.IsolationLevel.Serializable);
                    try
                    {
                        SQLCommand.CommandText = CommandText;
                        SQLCommand.ExecuteNonQuery();
                        SQLCommand.Transaction.Commit();
                    }
                    catch (System.Exception ex)
                    {
                        SQLCommand.Transaction.Rollback();
                        MessageBox.Show("SQL TRANSACTION ERROR: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SQL ERROR: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
