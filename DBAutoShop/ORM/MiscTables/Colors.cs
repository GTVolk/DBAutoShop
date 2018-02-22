using System;
using System.Windows.Forms;
using DBAutoShop.Controllers;

namespace DBAutoShop.ORM
{
    class Colors : AdditionalCommonClass
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
            get { return "Colors"; }
        }

        public override string TableIDName
        {
            get { return "Color_ID"; }
        }

        public override string TableValueName
        {
            get { return "ColorName"; }
        }

        public static void SaveToXML()
        {
            DatabaseControlService.XMLSave("Colors");
        }

        public static void LoadFromXML()
        {
            DatabaseControlService.XMLLoad("Colors");
        }
    }
}
