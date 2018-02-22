using System;

namespace DBAutoShop.Controllers
{
    class FullTextSearchService
    {
        private int _table_id;
        private string _search_string;
        private int _count_records;

        public int Table_ID
        {
            get { return _table_id; }
            set { _table_id = value; }
        }

        public string Search_String
        {
            get { return _search_string; }
            set { _search_string = value; }
        }

        public int Count_Records
        {
            get { return _count_records; }
            set { _count_records = value; }
        }

        private string TableName()
        {
            string TableName = "";
            switch (Table_ID)
            {
                case 1: { TableName = "AutomobilesData"; break; }
                case 2: { TableName = "Clients"; break; }
                case 3: { TableName = "Offices"; break; }
                case 4: { TableName = "Orders"; break; }
                case 5: { TableName = "PresenceCars"; break; }
                case 6: { TableName = "SelledCars"; break; }
                case 7: { TableName = "Sells"; break; }
                case 8: { TableName = "Workers"; break; }
                default: { break; }
            }
            return TableName;
        }

        public string Query()
        {
            return "SELECT * FROM [dbo].[fn_Get" + TableName() + "ByFullText]('" + Search_String + "'," + Count_Records + ")";
        }

    }
}
