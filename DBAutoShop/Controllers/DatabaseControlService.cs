using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;
using DBAutoShop.MainForms;
using DBAutoShop.IniWorkers;

namespace DBAutoShop.Controllers
{
    class DatabaseControlService
    {
        public static ElementControlService DBECS = new ElementControlService();
        public static SQLQueryService SQL = new SQLQueryService();
        public static FullTextSearchService DBFullTextSearch = new FullTextSearchService();
        public static XMLService XML = new XMLService();
        public static QueryBuilder QBuilder = new QueryBuilder();
        public static ExportAssistant Report = new ExportAssistant();
        public static bool SavePassword = false;
        public static int LastPage = 0;
        public static string UserName = "";
        public static string DataSource = "";
        public static string ConnectString = "";

        public static SmallSelector DBSmallSelector = new SmallSelector();

        private static void _StandartSelectQuery(string TableName, string ColumnName, string ConditionName, string Condition, string ConditionValue, int TableID = 0)
        {
            QBuilder.ClearAll();
            QBuilder.Parameters = ConditionName; QBuilder.Conditions = Condition; QBuilder.Values = ConditionValue;
            if (TableID != 0) { QBuilder.Parameters = ConditionName; QBuilder.Conditions = "!="; QBuilder.Values = ConditionValue; }
            string Command = DatabaseControlService.QBuilder.BuildSelectQuery(TableName, ColumnName, DatabaseControlService.QBuilder.BuildCondition());
            SQL = new SQLQueryService();
            SQL.SqlProcduceCommand(Command);
        }

        public static void PasswordSave(string PassWord)
        {
            Byte[] Key = { 3, 1, 3, 4, 7, 6, 4, 5 };
            Byte[] IV = { 2, 0, 3, 1, 5, 2, 7, 5, 9, 24, 43, 12, 11, 3, 15, 10 };

            using (FileStream destFl = File.Open("Security.dat", FileMode.OpenOrCreate, FileAccess.Write))
            {
                Rijndael alg = Rijndael.Create();
                using (CryptoStream cs = new CryptoStream(destFl, alg.CreateEncryptor(Key, IV), CryptoStreamMode.Write))
                {
                    using (StreamWriter sw = new StreamWriter(cs, Encoding.GetEncoding(1251)))
                    {
                        try
                        {
                            sw.WriteLine(PassWord);
                        }
                        catch
                        {
                            MessageBox.Show("Не удалось сохранить пароль!");
                        }
                    }
                }

            }

        }

        public static void PasswordLoad(ref string PassWord)
        {
            Byte[] Key = { 3, 1, 3, 4, 7, 6, 4, 5 };
            Byte[] IV = { 2, 0, 3, 1, 5, 2, 7, 5, 9, 24, 43, 12, 11, 3, 15, 10 };

            using (FileStream fs = File.Open("Security.dat", FileMode.OpenOrCreate))
            {
                Rijndael alg = Rijndael.Create();
                using (CryptoStream cs = new CryptoStream(fs, alg.CreateDecryptor(Key, IV), CryptoStreamMode.Read))
                {
                    using (StreamReader sr = new StreamReader(cs, Encoding.GetEncoding(1251)))
                    {
                        try
                        {
                            PassWord = sr.ReadLine();
                        }
                        catch
                        {
                            MessageBox.Show("Не удалось найти пароль!");
                        }
                        
                    }
                }
            }
        }

        public static void ReadINI()
        {
            using (FileStream FS = new FileStream("Settings.INI", FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (IniReader IR = new IniReader(FS))
                {
                    try
                    {
                        IR.Read();
                        if (IR.Name != "ProgramSettings") return;
                        IR.Read();
                        if (IR.Value != "")
                            SavePassword = Convert.ToBoolean(IR.Value);
                        IR.Read();
                        UserName = IR.Value;
                        IR.Read();
                        DataSource = IR.Value;
                        IR.Read();
                        ConnectString = IR.Value;
                        IR.Read();
                        if (IR.Value != "")
                            LastPage = Convert.ToInt32(IR.Value);
                    }
                    catch
                    {
                        MessageBox.Show("INI Файл поврежден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        public static void WriteINI()
        {
            using (FileStream FS = new FileStream("Settings.INI", FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (IniWriter IW = new IniWriter(FS))
                {
                    IW.WriteSection("ProgramSettings");
                    IW.WriteKey("SavePassword", "" + SavePassword);
                    IW.WriteKey("UserName", "\"" + UserName + "\"");
                    IW.WriteKey("DataSource", "\"" + DataSource + "\"");
                    IW.WriteKey("ConnectionString", "\"" + DatabaseControlService.ConnectString + "\"");
                    IW.WriteKey("LastPage", "" + LastPage);
                }
            }

        }

        public static void StandartSelectQuery(string TableName, string ColumnName, string ConditionName,  int ConditionValue, string Condition = "=")
        {
            _StandartSelectQuery(TableName, ColumnName, ConditionName, Condition, QBuilder.ConvertParameter(ConditionValue));
        }

        public static void StandartSelectQuery(string TableName, string ColumnName, string ConditionName, string ConditionValue, string Condition = "=")
        {
            _StandartSelectQuery(TableName, ColumnName, ConditionName, Condition, QBuilder.ConvertParameter(ConditionValue));
        }

        public static void StandartSelectQuery(string TableName, string ColumnName, string ConditionName, string ConditionValue, int TableID, string Condition = "=")
        {
            _StandartSelectQuery(TableName, ColumnName, ConditionName, Condition, QBuilder.ConvertParameter(ConditionValue), TableID);
        }

        public static string StandartInsertQuery(string TableName, string ColumnName, string ValueName)
        {
            return QBuilder.BuildInsertQuery(TableName, ColumnName, QBuilder.ConvertParameter(ValueName));
        }

        public static string StandartUpdateQuery(string TableName, string ColumnName, string ValueName, string IDName, int IDValue)
        {
            return QBuilder.BuildUpdateQuery(TableName, ColumnName + " = " + QBuilder.ConvertParameter(ValueName), IDName + " = " + QBuilder.ConvertParameter(IDValue)); 
        }

        public static string StandartDeleteQuery(string TableName, string IDName, int IDValue, string ColumnName, string ValueName)
        {
            return QBuilder.BuildDeleteQuery(TableName, IDName + " = " + QBuilder.ConvertParameter(IDValue) + " AND " + ColumnName + " = " + QBuilder.ConvertParameter(ValueName)); 
        }

        public static int GetElementID(string IDQuery, int IndexesColumn)
        {
            SQL.SqlProcduceCommand(IDQuery);
            if (SQL.DataTableHasValues())
                return Convert.ToInt32(SQL.SQLDS.Tables["Table"].Rows[0][IndexesColumn]);
            return 0;
        }

        public static int GetElementID()
        {
            if (SQL.DataTableHasValues())
                return Convert.ToInt32(SQL.SQLDS.Tables["Table"].Rows[0][0]);
            return 0;
        }

        public static void DataGridSelectLast(DataGridView DG)
        {
            if (DG.RowCount > 0) DG[0, DG.Rows.Count - 1].Selected = true;
        }

        public static void LoadComboData(string Query, ComboBox Combo)
        {
            DatabaseControlService.SQL.SqlProcduceCommand(Query);
            if (DatabaseControlService.SQL.DataTableHasValues())
            {
                for (int i = 0; i < DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows.Count; i++)
                {
                    if (DatabaseControlService.SQL.SQLDS.Tables["Table"].Columns.Count > 1)
                    {
                        string str = "";
                        for (int j = 0; j < DatabaseControlService.SQL.SQLDS.Tables["Table"].Columns.Count; j++)
                        {
                            if (j == 0) str = str + DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[i][j];
                            else str = str + " " + DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[i][j];
                        }
                        Combo.Items.Add(str);
                    }
                    else
                        Combo.Items.Add(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[i][0]);
                }
            }
        }

        public static void LoadComboData(string Query, ComboBox Combo, List<int> IndexMassive)
        {
            DatabaseControlService.SQL.SqlProcduceCommand(Query);
            if (DatabaseControlService.SQL.DataTableHasValues())
            {
                for (int i = 0; i < DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows.Count; i++)
                {
                    if (DatabaseControlService.SQL.SQLDS.Tables["Table"].Columns.Count > 1)
                    {
                        string str = "";
                        for (int j = 1; j < DatabaseControlService.SQL.SQLDS.Tables["Table"].Columns.Count; j++)
                        {
                            if (j == 1) str = str + DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[i][j];
                            else str = str + " " + DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[i][j];
                        }
                        Combo.Items.Add(str);
                        IndexMassive.Add(Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[i][0].ToString()));
                    }
                    else
                        Combo.Items.Add(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[i][0]);
                }
            }
        }

        public static void XMLSave(string Name)
        {
            TypeUtils.XMLSaveWorker(Name, Name );
        }

        public static void XMLLoad(string Name)
        {
            TypeUtils.XMLLoadWorker( Name, Name );
        }

        public static string ExecuteAction(string TableName, string ActionName)
        {
            return TypeUtils.InvokeMethod<string>(TableName, ActionName, null);
        }

        public static string ExecuteAction(string TableName, string ActionName, string stringParam)
        {
            return TypeUtils.InvokeMethod<string>("DBAutoShop.ORM", TableName, ActionName, new Object[] { stringParam });
        }

        public static string ExecuteAction(string TableName, string ActionName, int intParam, string stringParam)
        {
            return TypeUtils.InvokeMethod<string>("DBAutoShop.ORM", TableName, ActionName, new Object[] { intParam, stringParam });
        }

        public static void ExecuteInsert(string TableName, string Value)
        {
            TypeUtils.InvokeTableInstance("DBAutoShop.ORM", TableName, Value);
        }

        public static void ExecuteUpdate(string TableName, int ID, string Value)
        {
            TypeUtils.InvokeTableInstance("DBAutoShop.ORM", TableName, ID, Value);
        }

        public static string ConvertDecimal(string Dec)
        {
            return Dec.Replace(".", ",");
        }
    }
}
