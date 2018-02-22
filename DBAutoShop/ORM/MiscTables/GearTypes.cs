using System;
using System.Windows.Forms;
using DBAutoShop.Controllers;

namespace DBAutoShop.ORM
{
    class GearTypes : AdditionalCommonClass
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
            get { return "GearTypes"; }
        }

        public override string TableIDName
        {
            get { return "Gear_ID"; }
        }

        public override string TableValueName
        {
            get { return "GearName"; }
        }

        public static void SaveToXML()
        {
            DatabaseControlService.XMLSave("GearTypes");
        }

        public static void LoadFromXML()
        {
            DatabaseControlService.XMLLoad("GearTypes");
        }
    }
}
