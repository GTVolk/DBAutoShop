using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using DBAutoShop.Controllers;
using DBAutoShop.ORM;

public class TypeUtils
{

    public TypeUtils()
	{
	}

    public static T InvokeMethod<T>( string typeName, string methodName, Object[] Params)
    {
        Type calledType = Type.GetType(typeName);
        T s = (T)calledType.InvokeMember(methodName, BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Static, null, null, Params);
        return s;
    }

    public static T InvokeMethod<T>(string Namespace, string typeName, string methodName, Object[] Params)
    {
        Type calledType = Type.GetType(Namespace + "." + typeName);
        T s = (T)calledType.InvokeMember(methodName, BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Static, null, null, Params);
        return s;
    }

    public static T InvokeMethod<T>(string Namespace, string typeName, string AssemblyName, string methodName, Object[] Params)
    {
        Type calledType = Type.GetType(Namespace + "." + typeName + "," + AssemblyName);
        T s = (T)calledType.InvokeMember(methodName, BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Static, null, null, Params);
        return s;
    }

    public static void XMLLoadWorker( string XMLName, string ClassName )
    {
        try
        {
            Type calledType = Type.GetType("DBAutoShop.ORM." + ClassName);
            AdditionalCommonClass DB = (AdditionalCommonClass)Activator.CreateInstance(calledType);
            if (File.Exists("XML\\" + XMLName + ".XML"))
                DatabaseControlService.SQL.SQLDS.ReadXml("XML\\" + XMLName + ".XML");
            else return;
            DataSet Base = new DataSet();
            Base.ReadXml("XML\\" + XMLName + ".XML");
            if (DatabaseControlService.SQL.DataTableHasValues())
            {
                for (int i = 0; i < Base.Tables["Table"].Rows.Count; i++)
                {
                    DB.Reset();
                    DB.LoadData(Base, i);
                    if (!DB.CheckAll())
                        DatabaseControlService.SQL.SqlProcduceTransactionCommand(DB.Insert());
                    else
                    {
                        DatabaseControlService.SQL.SqlProcduceCommand(DB.SelectAll());
                        int ID = DatabaseControlService.SQL.GetIDByValue(DB.MainValue, 0, 1);
                        DB.MainID = ID;
                        DatabaseControlService.SQL.SqlProcduceTransactionCommand(DB.Update());
                    }
                }
                DatabaseControlService.SQL.SQLDS = new DataSet();
                DatabaseControlService.SQL.SQLDS.ReadXml("XML\\" + XMLName + ".XML");
            }

        }
        catch (System.Exception ex)
        {
            MessageBox.Show(ex.StackTrace);
            MessageBox.Show("XML ERROR: " + ex.Message, "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public static void XMLSaveWorker(string XMLName, string ClassName )
    {
        try
        {
            Type calledType = Type.GetType("DBAutoShop.ORM." + ClassName);
            AdditionalCommonClass DB = (AdditionalCommonClass)Activator.CreateInstance(calledType);
            DatabaseControlService.SQL.SqlProcduceCommand(DB.SelectAll());
            DatabaseControlService.SQL.SQLDS.WriteXml("XML\\" + XMLName + ".XML");
        }
        catch (System.Exception ex)
        {
            MessageBox.Show("XML ERROR: " + ex.Message, "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public static void InvokeTableInstance(string ClassName, string Value)
    {
        Type calledType = Type.GetType(ClassName);
        AdditionalCommonClass DB = (AdditionalCommonClass)Activator.CreateInstance(calledType);
        DB.MainValue = Value;
        DatabaseControlService.SQL.SqlProcduceTransactionCommand(DB.Insert());
    }

    public static void InvokeTableInstance(string ClassName, int ID, string Value)
    {
        Type calledType = Type.GetType(ClassName);
        AdditionalCommonClass DB = (AdditionalCommonClass)Activator.CreateInstance(calledType);
        DB.MainID = ID;
        DB.MainValue = Value;
        DatabaseControlService.SQL.SqlProcduceTransactionCommand(DB.Update());
    }

    public static void InvokeTableInstance(string Namespace, string ClassName, string Value)
    {
        Type calledType = Type.GetType(Namespace + "." + ClassName);
        AdditionalCommonClass DB = (AdditionalCommonClass)Activator.CreateInstance(calledType);
        DB.MainValue = Value;
        DatabaseControlService.SQL.SqlProcduceTransactionCommand(DB.Insert());
    }

    public static void InvokeTableInstance(string Namespace, string ClassName, int ID, string Value)
    {
        Type calledType = Type.GetType(Namespace + "." + ClassName);
        AdditionalCommonClass DB = (AdditionalCommonClass)Activator.CreateInstance(calledType);
        DB.MainID = ID;
        DB.MainValue = Value;
        DatabaseControlService.SQL.SqlProcduceTransactionCommand(DB.Update());
    }
}
