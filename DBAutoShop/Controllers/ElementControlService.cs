using System;
using DBAutoShop.ORM;

namespace DBAutoShop.Controllers
{
    class ElementControlService
    {
        AutomobilesData DBAutomobilesData;
        Clients DBClients;
        Offices DBOffices;
        SelledCars DBSelledCars;
        Workers DBWorkers;

        BodyTypes DBBodyTypes;
        Classes DBClasses;
        Colors DBColors;
        Countries DBCountries;
        GearTypes DBGearTypes;
        Languages DBLanguages;
        Manafacturers DBManafacturers;
        Workplaces DBWorkplaces;

        public ElementControlService()
        {
            DBAutomobilesData = new AutomobilesData();
            DBClients = new Clients();
            DBOffices = new Offices();
            DBSelledCars = new SelledCars();
            DBWorkers = new Workers();

            DBBodyTypes = new BodyTypes();
            DBClasses = new Classes();
            DBColors = new Colors();
            DBCountries = new Countries();
            DBGearTypes = new GearTypes();
            DBLanguages = new Languages();
            DBManafacturers = new Manafacturers();
            DBWorkplaces = new Workplaces();
        }

        public string GetComplexStringByAutoID(int AutoID)
        {
            string Query = "SELECT Auto_ID,ManafacturerName,Model FROM dbo.AutomobilesData INNER JOIN dbo.Manafacturers ON dbo.AutomobilesData.Manafacturer_ID = dbo.Manafacturers.Manafacturer_ID WHERE Auto_ID = " + AutoID;
            DatabaseControlService.SQL.SqlProcduceCommand(Query);
            if (DatabaseControlService.SQL.DataTableHasValues())
                 return DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][1].ToString() + " " + DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][2].ToString();
            return "";
        }

        public int GetAutoIDByComplexString(string ComplexString)
        {
            string Query = "SELECT Auto_ID,ManafacturerName,Model FROM dbo.AutomobilesData INNER JOIN dbo.Manafacturers ON dbo.AutomobilesData.Manafacturer_ID = dbo.Manafacturers.Manafacturer_ID";
            DatabaseControlService.SQL.SqlProcduceCommand(Query);
            if (DatabaseControlService.SQL.DataTableHasValues())
                for (int i = 0; i < DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows.Count; i++)
                    if ((DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[i][1].ToString() + " " + DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[i][2].ToString()) == ComplexString) return Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[i][0]);
            return 0;
        }

        public string GetComplexStringByClientID(int ClientID)
        {
            string Query = "SELECT Client_ID,Family,Name,Surname FROM Clients";
            DatabaseControlService.SQL.SqlProcduceCommand(Query);
            if (DatabaseControlService.SQL.DataTableHasValues())
                for (int i = 0; i < DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows.Count; i++)
                    if (Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[i][0]) == ClientID) return DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[i][1].ToString() + " " + DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[i][2].ToString() + " " + DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[i][3].ToString();
            return "";
        }

        public int GetClientIDByComplexString(string ComplexString)
        {
            string Query = "SELECT Client_ID,Family,Name,Surname,Telephone FROM Clients";
            DatabaseControlService.SQL.SqlProcduceCommand(Query);
            if (DatabaseControlService.SQL.DataTableHasValues())
                for (int i = 0; i < DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows.Count; i++)
                    if ((DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[i][1].ToString() + " " + DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[i][2].ToString() + " " + DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[i][3].ToString() + " " + DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[i][4].ToString()) == ComplexString) return Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[i][0]);
            return 0;
        }

        public string GetModelByAutoID(int AutoID)
        {
            DBAutomobilesData.Auto_ID = AutoID;
            DBAutomobilesData.LoadData();

            return DBAutomobilesData.Model;
        }

        public int GetAutoIDByModel(string Model)
        {
            string Query = "SELECT Auto_ID FROM AutomobilesData WHERE Model = '" + Model + "'";

            return DatabaseControlService.GetElementID(Query, 0);
        }

        public string GetNoPTCByAutoID(int AutoID)
        {
            DBSelledCars.Auto_ID = AutoID;
            DBSelledCars.LoadData();

            return DBSelledCars.No_PTC;
        }

        public int GetWorkerIDByTelephone(string Telephone)
        {
            string Query = "SELECT Worker_ID FROM Workers WHERE Telephone = '" + Telephone + "'";

            return DatabaseControlService.GetElementID(Query, 0);
        }

        public string GetTelephoneByWorkerID(int WorkerID)
        {
            DBWorkers.Worker_ID = WorkerID;
            DBWorkers.LoadData();

            return DBWorkers.Telephone;
        }

        public int GetSellIDByNoPTC(string NoPTC)
        {
            string Query = "SELECT Sell_ID FROM Sells WHERE No_PTC = '" + NoPTC + "'";

            return DatabaseControlService.GetElementID(Query, 0);
        }

        public string GetTelephoneByClientID(int ClientID)
        {
            DBClients.Client_ID = ClientID;
            DBClients.LoadData();

            return DBClients.Telephone;
        }

        public int GetClientIDByTelephone(string Telephone)
        {
            string Query = "SELECT Client_ID FROM Clients WHERE Telephone = '" + Telephone + "'";

            return DatabaseControlService.GetElementID(Query, 0);
        }

        public string GetOfficeNameByOfficeID(int OfficeID)
        {
            DBOffices.Office_ID = OfficeID;
            DBOffices.LoadData();

            return DBOffices.Office_Name;
        }

        public int GetOfficeIDByOfficeName(string OfficeName)
        {
            string Query = "SELECT Office_ID FROM Offices WHERE Office_Name = '" + OfficeName + "'";

            return DatabaseControlService.GetElementID(Query, 0);
        }

        public string GetBodyNameByBodyID(int BodyID)
        {
            DBBodyTypes.MainID = BodyID;
            DBBodyTypes.LoadData();

            return DBBodyTypes.MainValue;
        }

        public int GetBodyIDByBodyName(string BodyName)
        {
            string Query = "SELECT Body_ID FROM BodyTypes WHERE BodyName = '" + BodyName + "'";

            return DatabaseControlService.GetElementID(Query, 0);
        }

        public string GetClassNameByClassID(int ClassID)
        {
            DBClasses.MainID = ClassID;
            DBClasses.LoadData();

            return DBClasses.MainValue;
        }

        public int GetClassIDByClassName(string ClassName)
        {
            string Query = "SELECT Class_ID FROM Classes WHERE ClassName = '" + ClassName + "'";

            return DatabaseControlService.GetElementID(Query, 0);
        }

        public string GetColorNameByColorID(int ColorID)
        {
            DBColors.MainID = ColorID;
            DBColors.LoadData();

            return DBColors.MainValue;
        }

        public int GetColorIDByColorName(string ColorName)
        {
            string Query = "SELECT Color_ID FROM Colors WHERE ColorName = '" + ColorName + "'";

            return DatabaseControlService.GetElementID(Query, 0);
        }

        public string GetCountryNameByCountryID(int CountryID)
        {
            DBCountries.Country_ID = CountryID;
            DBCountries.LoadData();

            return DBCountries.CountryName;
        }

        public int GetCountryIDByCountryName(string CountryName)
        {
            string Query = "SELECT Country_ID FROM Countries WHERE CountryName = '" + CountryName + "'";

            return DatabaseControlService.GetElementID(Query, 0);
        }

        public string GetGearNameByGearID(int GearID)
        {
            DBGearTypes.MainID = GearID;
            DBGearTypes.LoadData();

            return DBGearTypes.MainValue;
        }

        public int GetGearIDByGearName(string GearName)
        {
            string Query = "SELECT Gear_ID FROM GearTypes WHERE GearName = '" + GearName + "'";

            return DatabaseControlService.GetElementID(Query, 0);
        }

        public string GetLanguageNameByLanguageID(int LanguageID)
        {
            DBLanguages.MainID = LanguageID;
            DBLanguages.LoadData();

            return DBLanguages.MainValue;
        }

        public int GetLanguageIDByLanguageName(string LanguageName)
        {
            string Query = "SELECT Language_ID FROM Languages WHERE LanguageName = '" + LanguageName + "'";

            return DatabaseControlService.GetElementID(Query, 0);
        }

        public string GetManafacturerNameByManafacturerID(int ManafacturerID)
        {
            DBManafacturers.MainID = ManafacturerID;
            DBManafacturers.LoadData();

            return DBManafacturers.MainValue;
        }

        public int GetManafacturerIDByManafacturerName(string ManafacturerName)
        {
            string Query = "SELECT Manafacturer_ID FROM Manafacturers WHERE ManafacturerName = '" + ManafacturerName + "'";

            return DatabaseControlService.GetElementID(Query, 0);
        }

        public string GetWorkplaceNameByWorkplaceID(int WorkplaceID)
        {
            DBWorkplaces.MainID = WorkplaceID;
            DBWorkplaces.LoadData();

            return DBWorkplaces.MainValue;
        }

        public int GetWorkplaceIDByWorkplaceName(string WorkplaceName)
        {
            string Query = "SELECT Workplace_ID FROM Workplaces WHERE WorkplaceName = '" + WorkplaceName + "'";

            return DatabaseControlService.GetElementID(Query, 0);
        }
    }
}
