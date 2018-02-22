using System;
using System.Data;
using System.Windows.Forms;
using DBAutoShop.Controllers;

namespace DBAutoShop.ORM
{
    class SelledCars : Sells
    {

        public string ViewAll()
        {
            return "SELECT * FROM ViewSelledCars ORDER BY [Дата продажи]";
        }
    }
}
