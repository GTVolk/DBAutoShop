using System;
using System.Xml;
using System.IO;
using System.Windows.Forms;
using DBAutoShop.ORM;

namespace DBAutoShop.Controllers
{
    class XMLService
    {

        public void CheckFolderExists()
        {
            if (Directory.Exists("XML")) return;
            Directory.CreateDirectory("XML");
        }

        public void XML_SaveDATABASE()
        {
            CheckFolderExists();
            XML_SaveTABLE(1);
            XML_SaveTABLE(2);
            XML_SaveTABLE(3);
            XML_SaveTABLE(4);
            XML_SaveTABLE(5);
            XML_SaveTABLE(8);
        }

        public void XML_SaveTABLE(int TableID)
        {
            switch (TableID)
            {
                case 1:
                    {
                        AutomobilesData.SaveToXML();
                        break;
                    }
                case 2:
                    {
                        Clients.SaveToXML();
                        break;
                    }
                case 3:
                    {
                        Offices.SaveToXML();
                        break;
                    }
                case 4:
                    {
                        Orders.SaveToXML();
                        break;
                    }
                case 5:
                    {
                        Sells.SaveToXML();
                        break;
                    }
                case 6:
                    {
                        Sells.SaveToXML();
                        break;
                    }
                case 7:
                    {
                        Sells.SaveToXML();
                        break;
                    }
                case 8:
                    {
                        Workers.SaveToXML();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        public void XML_LoadDATABASE()
        {
            CheckFolderExists();
            XML_LoadTABLE(1);
            XML_LoadTABLE(2);
            XML_LoadTABLE(3);
            XML_LoadTABLE(4);
            XML_LoadTABLE(5);
            XML_LoadTABLE(8);
        }

        public void XML_LoadTABLE(int TableID)
        {
            CheckFolderExists();
            switch (TableID)
            {
                case 1:
                    {
                        if (File.Exists("XML\\AutomobilesData.XML") && File.Exists("XML\\Manafacturers.XML") && File.Exists("XML\\Countries.XML") && File.Exists("XML\\Languages.XML") && File.Exists("XML\\Classes.XML") && File.Exists("XML\\BodyTypes.XML") && File.Exists("XML\\GearTypes.XML"))
                            AutomobilesData.LoadFromXML();
                        else MessageBox.Show("Не найдены файлы XML!");
                        break;
                    }
                case 2:
                    {
                        if (File.Exists("XML\\Clients.XML"))
                            Clients.LoadFromXML();
                        else MessageBox.Show("Не найдены файлы XML!");
                        break;
                    }
                case 3:
                    {
                        if (File.Exists("XML\\Offices.XML"))
                            Offices.LoadFromXML();
                        else MessageBox.Show("Не найдены файлы XML!");
                        
                        break;
                    }
                case 4:
                    {
                        if (File.Exists("XML\\Orders.XML") && File.Exists("XML\\AutomobilesData.XML") && File.Exists("XML\\Clients.XML"))
                            Orders.LoadFromXML();
                        else MessageBox.Show("Не найдены файлы XML!");
                        
                        break;
                    }
                case 5:
                    {
                        if (File.Exists("XML\\Sells.XML") && File.Exists("XML\\AutomobilesData.XML") && File.Exists("XML\\Colors.XML") && File.Exists("XML\\Clients.XML") && File.Exists("XML\\Workers.XML") && File.Exists("XML\\Offices.XML"))
                            Sells.LoadFromXML();
                        else MessageBox.Show("Не найдены файлы XML!");
                        
                        break;
                    }
                case 6:
                    {
                        XML_LoadTABLE(5);
                        break;
                    }
                case 7:
                    {
                        XML_LoadTABLE(5);
                        break;
                    }
                case 8:
                    {
                        if (File.Exists("XML\\Workers.XML") && File.Exists("XML\\Workplaces.XML") && File.Exists("XML\\Offices.XML"))
                            Workers.LoadFromXML();
                        else MessageBox.Show("Не найдены файлы XML!");
                        
                        break;
                    }
                default:
                    {
                        MessageBox.Show("О неееееееет!!!!!!!", "Гипер-пупер ошибка века!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
            }
        }


    }
}
