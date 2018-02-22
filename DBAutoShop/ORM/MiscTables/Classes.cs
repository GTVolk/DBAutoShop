using System;
using System.Data;
using System.Windows.Forms;
using DBAutoShop.Controllers;

namespace DBAutoShop.ORM
{
    class Classes : AdditionalCommonClass
    {
        private int _main_id;
        private string _mainname;

        public override int MainID
        {
            get { return _main_id; }
            set { _main_id = value; }
        }

        public override string MainValue
        {
            get { return _mainname; }
            set { _mainname = value; }
        }

        public override string TableName
        {
            get { return "Classes"; }
        }

        public override string TableIDName
        {
            get { return "Class_ID"; }
        }

        public override string TableValueName
        {
            get { return "ClassName"; }
        }

        public static void SaveToXML()
        {
            DatabaseControlService.XMLSave("Classes");
        }

        public static void LoadFromXML()
        {
            DatabaseControlService.XMLLoad("Classes");
        }
    }
}
