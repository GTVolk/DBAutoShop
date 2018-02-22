using System;
using System.Data;
using System.Windows.Forms;
using DBAutoShop.Controllers;

namespace DBAutoShop.ORM
{
    class PresenceCars : Sells
    {
        public string ViewAll()
        {
            return "SELECT * FROM ViewPresenceCars ORDER BY [Дата приема]";
        }
    }
}
