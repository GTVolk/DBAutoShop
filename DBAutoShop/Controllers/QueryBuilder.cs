using System;
using System.Collections.Generic;
using System.Text;

namespace DBAutoShop.Controllers
{
    class QueryBuilder
    {
        private List<string> _params;
        private List<string> _condstates;
        private List<string> _values;

        public QueryBuilder()
        {
            _params = new List<string>();
            _condstates = new List<string>();
            _values = new List<string>();
        }

        private string GetParameters()
        {
            string str = "";
            for (int i = 0; i < _params.Count; i++)
                if (i == 0) str = str + _params[i];
                else str = str + " " + _params[i];
            return str;
        }

        private string GetValues()
        {
            string str = "";
            for (int i = 0; i < _values.Count; i++)
                if (i == 0) str = str + _values[i];
                else str = str + " " + _values[i];
            return str;
        }

        private string GetConditions()
        {
            string str = "";
            for (int i = 0; i < _condstates.Count; i++)
                if (i == 0) str = str + _condstates[i];
                else str = str + " " + _condstates[i];
            return str;
        }

        public string Parameters
        {
            get { return GetParameters(); }
            set { _params.Add(value); }
        }

        public string Values
        {
            get { return GetValues(); }
            set { _values.Add(value); }
        }

        public string Conditions
        {
            get { return GetConditions(); }
            set { _condstates.Add(value); }
        }

        public bool SizeEquals
        {
            get { return (_params.Count == _values.Count) && (_values.Count == _condstates.Count); }
        }

        public void ClearParameters()
        {
            _params.Clear();
        }

        public void ClearValues()
        {
            _values.Clear();
        }

        public void ClearConditions()
        {
            _condstates.Clear();
        }

        public void ClearAll()
        {
            ClearParameters();
            ClearConditions();
            ClearValues();
        }

        public string ConvertParameter(int Param)
        {
            return "" + Param;
        }

        public string ConvertParameter(decimal Param)
        {
            return "" + ConvertDecimal(Param.ToString());
        }

        public string ConvertParameter(string Param)
        {
            return "('" + Param + "')";
        }

        public string ConvertParameter(DateTime Param)
        {
            return "('" + Param.ToString() + "')";
        }

        public string ConvertParameter(bool Param)
        {
            return "" + true.CompareTo(!Param);
        }

        public string ConvertParameterNULL(int Param)
        {
            if (Param == 0)
                return "NULL";
            else
                return "" + Param;
        }

        public string ConvertParameterNULL(DateTime Param)
        {
            if (Param.ToString() == "")
                return "NULL";
            else
                return "('" + Param.ToString() + "')";
        }

        public string BuildCondition()
        {
            return BuildCondition(_params, _condstates, _values);
        }



        public string BuildCondition(List<string> Params, List<string> ConditionStates, List<string> Values)
        {
            if (Params.Count != Values.Count) { throw new Exception("Values and Parameters lists are not equal sized!"); }
            string Condition = "";
            for (int i = 0; i < Params.Count; i++)
            {
                if (i == 0) Condition = Condition + Params[i] + " " + ConditionStates[i] + " " + Values[i];
                else Condition = Condition + " AND " + Params[i] + ConditionStates[i] + " " + Values[i];
            }
            return Condition;
        }

        public string BuildParameters()
        {
            return BuildParameters(_params, _values);
        }

        public string BuildParameters(List<string> Params, List<string> Values)
        {
            if (Params.Count != Values.Count) { throw new Exception("Values and Parameters lists are not equal sized!"); }
            string Param = "";
            for (int i = 0; i < Params.Count; i++)
            {
                if (i == 0) Param = Param + Params[i] + " = " + Values[i];
                else Param = Param + " , " + Params[i] + " = " + Values[i];
            }
            return Param;
        }

        public string BuildInsertQuery(string TableName, string Parameters, string Values)
        {
            return "INSERT INTO " + TableName + "(" + Parameters + ")" + " VALUES(" + Values + ")";
        }

        public string BuildUpdateQuery(string TableName, string Parameters, string Condition)
        {
            return "UPDATE " + TableName + " SET " + Parameters + " WHERE " + Condition;
        }

        public string BuildDeleteQuery(string TableName, string Condition)
        {
            return "DELETE FROM " + TableName + " WHERE " + Condition;
        }

        public string BuildSelectQuery( string TableName, string ColumnNames = "*")
        {
            return "SELECT " + ColumnNames + " FROM " + TableName;
        }

        public string BuildSelectQuery(string TableName, string ColumnNames, string Condition)
        {
            return BuildSelectQuery(TableName,ColumnNames) + " WHERE " + Condition;
        }

        public static string ConvertDecimal(string Dec)
        {
            return Dec.Replace(",", ".");
        }
    }
}
