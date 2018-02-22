using System;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using DBAutoShop.Controllers;

namespace DBAutoShop.ORM
{
    class BodyTypes : AdditionalCommonClass
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
            get{ return "BodyTypes"; }
        }

        public override string TableIDName
        {
            get { return "Body_ID"; }
        }

        public override string TableValueName
        {
            get { return "BodyName"; }
        }

        public static void SaveToXML()
        {
            DatabaseControlService.XMLSave("BodyTypes");
        }

        public static void LoadFromXML()
        {
            DatabaseControlService.XMLLoad("BodyTypes");
        }
    }
}
