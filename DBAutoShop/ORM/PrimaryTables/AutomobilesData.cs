using System;
using System.Data;
using System.Windows.Forms;
using DBAutoShop.Controllers;

namespace DBAutoShop.ORM
{
    class AutomobilesData
    {
        private int _auto_id;
        private DateTime _release_date;
        private int _manafacturer_id;
        private string _model;
        private int _class_id;
        private int _country_id;
        private decimal _warranty;
        private int _body_id;
        private int _doorsnumber;
        private int _placesnumber;
        private int _maxspeed;
        private int _motorvolume;
        private int _hp;
        private int _rpm;
        private string _torque;
        private string _cylindersaligment;
        private int _cylindersnumber;
        private int _cylindervalves;
        private decimal _acceleration;
        private decimal _braking;
        private int _transmissionnumberm;
        private int _transmissionnumbera;
        private string _engineposition;
        private int _gear_id;
        private string _gdm;
        private int _fueltank;
        private string _fuelmethod;
        private string _fueltype;
        private int _stmass;
        private int _gvw;
        private string _size;
        private int _wheelsbase;
        private int _groundclearance;
        private int _maxamounttrunk;
        private int _minamounttrunk;
        private string _frontbrakes;
        private string _rearbrakes;
        private decimal _fuelcity;
        private decimal _fuelhighway;
        private decimal _fuelcombined;
        private bool _turbo;
        private bool _abs;
        private bool _steeringpowerer;
        private bool _spoiler;
        private decimal _cost;

        public int Auto_ID
        {
            get {return _auto_id;}
            set {_auto_id = value;}
        }

        public DateTime Release_Date
        {
            get { return _release_date; }
            set { _release_date = value; }
        }


        public int Manafacturer_ID
        {
            get { return _manafacturer_id; }
            set { _manafacturer_id = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int Class_ID
        {
            get { return _class_id; }
            set { _class_id = value; }
        }

        public int Country_ID
        {
            get { return _country_id; }
            set { _country_id = value; }
        }

        public decimal Warranty
        {
            get { return _warranty; }
            set { _warranty = value; }
        }

        public int Body_ID
        {
            get { return _body_id; }
            set { _body_id = value; }
        }

        public int DoorsNumber
        {
            get { return _doorsnumber; }
            set { _doorsnumber = value; }
        }

        public int PlacesNumber
        {
            get { return _placesnumber; }
            set { _placesnumber = value; }
        }

        public int MaxSpeed
        {
            get { return _maxspeed; }
            set { _maxspeed = value; }
        }

        public int MotorVolume
        {
            get { return _motorvolume; }
            set { _motorvolume = value; }
        }

        public int HP
        {
            get { return _hp; }
            set { _hp = value; }
        }

        public int RPM
        {
            get { return _rpm; }
            set { _rpm = value; }
        }

        public string Torque
        {
            get { return _torque; }
            set { _torque = value; }
        }

        public string CylindersAligment
        {
            get { return _cylindersaligment; }
            set { _cylindersaligment = value; }
        }

        public int CylindersNumber
        {
            get { return _cylindersnumber; }
            set { _cylindersnumber = value; }
        }

        public int CylinderValves
        {
            get { return _cylindervalves; }
            set { _cylindervalves = value; }
        }

        public decimal Acceleration
        {
            get { return _acceleration; }
            set { _acceleration = value; }
        }

        public decimal Braking
        {
            get { return _braking; }
            set { _braking = value; }
        }

        public int TransmissionNumberM
        {
            get { return _transmissionnumberm; }
            set { _transmissionnumberm = value; }
        }

        public int TransmissionNumberA
        {
            get { return _transmissionnumbera; }
            set { _transmissionnumbera = value; }
        }

        public string EnginePosition
        {
            get { return _engineposition; }
            set { _engineposition = value; }
        }

        public int Gear_ID
        {
            get { return _gear_id; }
            set { _gear_id = value; }
        }

        public string GDM
        {
            get { return _gdm; }
            set { _gdm = value; }
        }

        public int FuelTank
        {
            get { return _fueltank; }
            set { _fueltank = value; }
        }

        public string FuelMethod
        {
            get { return _fuelmethod; }
            set { _fuelmethod = value; }
        }

        public string FuelType
        {
            get { return _fueltype; }
            set { _fueltype = value; }
        }

        public int StMass
        {
            get { return _stmass; }
            set { _stmass = value; }
        }

        public int GVW
        {
            get { return _gvw; }
            set { _gvw = value; }
        }

        public string Size
        {
            get { return _size; }
            set { _size = value; }
        }

        public int WheelsBase
        {
            get { return _wheelsbase; }
            set { _wheelsbase = value; }
        }

        public int GroundClearance
        {
            get { return _groundclearance; }
            set { _groundclearance = value; }
        }

        public int MaxAmountTrunk
        {
            get { return _maxamounttrunk; }
            set { _maxamounttrunk = value; }
        }

        public int MinAmountTrunk
        {
            get { return _minamounttrunk; }
            set { _minamounttrunk = value; }
        }

        public string FrontBrakes
        {
            get { return _frontbrakes; }
            set { _frontbrakes = value; }
        }

        public string RearBrakes
        {
            get { return _rearbrakes; }
            set { _rearbrakes = value; }
        }

        public decimal FuelCity
        {
            get { return _fuelcity; }
            set { _fuelcity = value; }
        }

        public decimal FuelHighway
        {
            get { return _fuelhighway; }
            set { _fuelhighway = value; }
        }

        public decimal FuelCombined
        {
            get { return _fuelcombined; }
            set { _fuelcombined = value; }
        }

        public bool Turbo
        {
            get { return _turbo; }
            set { _turbo = value; }
        }

        public bool ABS
        {
            get { return _abs; }
            set { _abs = value; }
        }

        public bool SteeringPowerer
        {
            get { return _steeringpowerer; }
            set { _steeringpowerer = value; }
        }

        public bool Spoiler
        {
            get { return _spoiler; }
            set { _spoiler = value; }
        }

        public decimal Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        public void Reset()
        {
            Release_Date = DateTime.Now;
            Manafacturer_ID = 0;
            Model = "";
            Class_ID = 0;
            Country_ID = 0;
            Warranty = 0;
            Body_ID = 0;
            DoorsNumber = 0;
            PlacesNumber = 0;
            MaxSpeed = 0;
            MotorVolume = 0;
            HP = 0;
            RPM = 0;
            Torque = "";
            CylindersAligment = "";
            CylindersNumber = 0;
            CylinderValves = 0;
            Acceleration = 0;
            Braking = 0;
            TransmissionNumberM = 0;
            TransmissionNumberA = 0;
            EnginePosition = "";
            Gear_ID = 0;
            GDM = "";
            FuelTank = 0;
            FuelMethod = "";
            FuelType = "";
            StMass = 0;
            GVW = 0;
            Size = "";
            WheelsBase = 0;
            GroundClearance = 0;
            MaxAmountTrunk = 0;
            MinAmountTrunk = 0;
            FrontBrakes = "";
            RearBrakes = "";
            FuelCity = 0;
            FuelHighway = 0;
            FuelCombined = 0;
            Turbo = false;
            ABS = false;
            SteeringPowerer = false;
            Spoiler = false;
            Cost = 0;
        }

        public bool CheckUse()
        {
            string Command = "SELECT Auto_ID FROM Orders WHERE Auto_ID = " + Auto_ID;

            DatabaseControlService.SQL = new SQLQueryService();
            DatabaseControlService.SQL.SqlProcduceCommand(Command);
            if (DatabaseControlService.SQL.DataTableHasValues()) return true;

            Command = "SELECT Auto_ID FROM Sells WHERE Auto_ID = " + Auto_ID;

            DatabaseControlService.SQL = new SQLQueryService();
            DatabaseControlService.SQL.SqlProcduceCommand(Command);
            if (DatabaseControlService.SQL.DataTableHasValues()) return true;

            return false;
        }

        public bool CheckModel()
        {
            string Command = "SELECT Model FROM AutomobilesData WHERE  Model = ('" + Model + "') AND Auto_ID != " + Auto_ID;

            DatabaseControlService.SQL.SqlProcduceCommand(Command);
            if (DatabaseControlService.SQL.DataTableHasValues()) return true;
            return false;
        }

        public bool CheckAll()
        {
            string Command = "SELECT Model FROM AutomobilesData WHERE  Model = ('" + Model + "')";

            DatabaseControlService.SQL.SqlProcduceCommand(Command);
            if (DatabaseControlService.SQL.DataTableHasValues()) return true;
            return false;
        }

        public void GetID()
        {
            string Query = "SELECT Auto_ID FROM AutomobilesData WHERE Release_Date = " + Release_Date + " AND Manafacturer_ID = " + Manafacturer_ID + " AND Model = '" + Model + "' AND Class_ID = '" + Class_ID + "' AND Country_ID = " + Country_ID + " AND Warranty = " + Warranty + " AND Body_ID = " + Body_ID + " AND DoorsNumber = " + DoorsNumber + " AND PlacesNumber = " + PlacesNumber + " AND MaxSpeed = " + MaxSpeed + " AND MotorVolume = " + MotorVolume + " AND HP = " + HP + " AND RPM = " + RPM + " AND Torque = '" + Torque + "' AND CylindersAligment = '" + CylindersAligment + "' AND CylindersNumber = " + CylindersNumber + " AND  CylinderValves = " + CylinderValves + " AND Acceleration = " + Acceleration + " AND Braking =" + Braking + " AND TransmissionNumberM = " + TransmissionNumberM + " AND TransmissionNumberA = " + TransmissionNumberA + " AND EnginePosition = '" + EnginePosition + "' AND Gear_ID = " + Gear_ID + " AND GDM = '" + GDM + "' AND FuelTank = " + FuelTank + " AND FuelMethod = '" + FuelMethod + "' AND FuelType = '" + FuelType + "' AND StMass = " + StMass + " AND GVW = " + GVW + " AND Size = '" + Size + "' AND WheelsBase = " + WheelsBase + " AND GroundClearance = " + GroundClearance + " AND MaxAmountTrunk = " + MaxAmountTrunk + " AND MinAmountTrunk = " + MinAmountTrunk + " AND FrontBrakes = '" + FrontBrakes + "' AND RearBrakes = '" + RearBrakes + "' AND FuelCity = " + FuelCity + " AND FuelHighway = " + FuelHighway + " AND FuelCombined = " + FuelCombined + " AND Turbo = " + Turbo + " AND ABS = " + ABS + " AND SteeringPowerer = " + SteeringPowerer + " AND Spoiler = " + Spoiler + " AND Cost = " + Cost;
            Auto_ID = DatabaseControlService.GetElementID(Query, 0);
        }

        public void LoadData(DataGridView DG)
        {
            DatabaseControlService.SQL.SqlProcduceCommand(SelectAll());
            if (DatabaseControlService.SQL.DataTableHasValues())
                Auto_ID = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[DG.SelectedRows[0].Index][0]);
            LoadData();
        }

        public void LoadData(DataSet DS, int RowNumber)
        {
            if (DatabaseControlService.SQL.DataTableHasValues(DS, "Table", RowNumber))
            {
                Auto_ID = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][0]);
                Release_Date = Convert.ToDateTime(DS.Tables["Table"].Rows[RowNumber][1]);
                Manafacturer_ID = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][2]);
                Model = DS.Tables["Table"].Rows[RowNumber][3].ToString();
                Class_ID = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][4]);
                Country_ID = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][5]);
                Warranty = Convert.ToDecimal(DatabaseControlService.ConvertDecimal(DS.Tables["Table"].Rows[RowNumber][6].ToString()));
                Body_ID = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][7]);
                DoorsNumber = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][8]);
                PlacesNumber = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][9]);
                MaxSpeed = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][10]);
                MotorVolume = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][11]);
                HP = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][12]);
                RPM = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][13]);
                Torque = DS.Tables["Table"].Rows[RowNumber][14].ToString();
                CylindersAligment = DS.Tables["Table"].Rows[RowNumber][15].ToString();
                CylindersNumber = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][16]);
                CylinderValves = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][17]);
                Acceleration = Convert.ToDecimal(DatabaseControlService.ConvertDecimal(DS.Tables["Table"].Rows[RowNumber][18].ToString()));
                Braking = Convert.ToDecimal(DatabaseControlService.ConvertDecimal(DS.Tables["Table"].Rows[RowNumber][19].ToString()));
                TransmissionNumberM = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][20]);
                TransmissionNumberA = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][21]);
                EnginePosition = DS.Tables["Table"].Rows[RowNumber][22].ToString();
                Gear_ID = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][23]);
                GDM = DS.Tables["Table"].Rows[RowNumber][24].ToString();
                FuelTank = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][25]);
                FuelMethod = DS.Tables["Table"].Rows[RowNumber][26].ToString();
                FuelType = DS.Tables["Table"].Rows[RowNumber][27].ToString();
                StMass = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][28]);
                GVW = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][29]);
                Size = DS.Tables["Table"].Rows[RowNumber][30].ToString();
                WheelsBase = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][31]);
                GroundClearance = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][32]);
                MaxAmountTrunk = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][33]);
                MinAmountTrunk = Convert.ToInt32(DS.Tables["Table"].Rows[RowNumber][34]);
                FrontBrakes = DS.Tables["Table"].Rows[RowNumber][35].ToString();
                RearBrakes = DS.Tables["Table"].Rows[RowNumber][36].ToString();
                FuelCity = Convert.ToDecimal(DatabaseControlService.ConvertDecimal(DS.Tables["Table"].Rows[RowNumber][37].ToString()));
                FuelHighway = Convert.ToDecimal(DatabaseControlService.ConvertDecimal(DS.Tables["Table"].Rows[RowNumber][38].ToString()));
                FuelCombined = Convert.ToDecimal(DatabaseControlService.ConvertDecimal(DS.Tables["Table"].Rows[RowNumber][39].ToString()));
                Turbo = Convert.ToBoolean(DS.Tables["Table"].Rows[RowNumber][40]);
                ABS = Convert.ToBoolean(DS.Tables["Table"].Rows[RowNumber][41]);
                SteeringPowerer = Convert.ToBoolean(DS.Tables["Table"].Rows[RowNumber][42]);
                Spoiler = Convert.ToBoolean(DS.Tables["Table"].Rows[RowNumber][43]);
                Cost = Convert.ToDecimal(DatabaseControlService.ConvertDecimal(DS.Tables["Table"].Rows[RowNumber][44].ToString()));
            }
        }

        public void LoadData()
        {
            string Command = "SELECT Release_Date, Manafacturer_ID, Model, Class_ID, Country_ID, Warranty, Body_ID, DoorsNumber, PlacesNumber, MaxSpeed, MotorVolume, HP, RPM, Torque, CylindersAligment, CylindersNumber, CylinderValves, Acceleration, Braking, TransmissionNumberM, TransmissionNumberA, EnginePosition, Gear_ID, GDM, FuelTank, FuelMethod, FuelType, StMass, GVW, Size, WheelsBase, GroundClearance, MaxAmountTrunk, MinAmountTrunk, FrontBrakes, RearBrakes, FuelCity, FuelHighway, FuelCombined, Turbo, ABS, SteeringPowerer, Spoiler, Cost FROM AutomobilesData WHERE Auto_ID = " + Auto_ID;

            DatabaseControlService.SQL.SqlProcduceCommand(Command);
            if (DatabaseControlService.SQL.DataTableHasValues())
            {
                Release_Date = Convert.ToDateTime(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][0]);
                Manafacturer_ID = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][1]);
                Model = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][2].ToString();
                Class_ID = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][3]);
                Country_ID = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][4]);
                Warranty = Convert.ToDecimal(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][5]);
                Body_ID = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][6]);
                DoorsNumber = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][7]);
                PlacesNumber = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][8]);
                MaxSpeed = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][9]);
                MotorVolume = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][10]);
                HP = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][11]);
                RPM = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][12]);
                Torque = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][13].ToString();
                CylindersAligment = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][14].ToString();
                CylindersNumber = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][15]);
                CylinderValves = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][16]);
                Acceleration = Convert.ToDecimal(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][17]);
                Braking = Convert.ToDecimal(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][18]);
                TransmissionNumberM = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][19]);
                TransmissionNumberA = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][20]);
                EnginePosition = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][21].ToString();
                Gear_ID = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][22]);
                GDM = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][23].ToString();
                FuelTank = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][24]);
                FuelMethod = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][25].ToString();
                FuelType = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][26].ToString();
                StMass = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][27]);
                GVW = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][28]);
                Size = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][29].ToString();
                WheelsBase = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][30]);
                GroundClearance = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][31]);
                MaxAmountTrunk = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][32]);
                MinAmountTrunk = Convert.ToInt32(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][33]);
                FrontBrakes = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][34].ToString();
                RearBrakes = DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][35].ToString();
                FuelCity = Convert.ToDecimal(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][36]);
                FuelHighway = Convert.ToDecimal(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][37]);
                FuelCombined = Convert.ToDecimal(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][38]);
                Turbo = Convert.ToBoolean(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][39]);
                ABS = Convert.ToBoolean(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][40]);
                SteeringPowerer = Convert.ToBoolean(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][41]);
                Spoiler = Convert.ToBoolean(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][42]);
                Cost = Convert.ToDecimal(DatabaseControlService.SQL.SQLDS.Tables["Table"].Rows[0][43]);
            }
        }

        public static string SelectAll()
        {
            return "SELECT * FROM AutomobilesData";
        }

        public string Insert()
        {
            return "INSERT INTO AutomobilesData(Release_Date, Manafacturer_ID, Model, Class_ID, Country_ID, Warranty, Body_ID, DoorsNumber, PlacesNumber, MaxSpeed, MotorVolume, HP, RPM, Torque, CylindersAligment, CylindersNumber, CylinderValves, Acceleration, Braking, TransmissionNumberM, TransmissionNumberA, EnginePosition, Gear_ID, GDM, FuelTank, FuelMethod, FuelType, StMass, GVW, Size, WheelsBase, GroundClearance, MaxAmountTrunk, MinAmountTrunk, FrontBrakes, RearBrakes, FuelCity, FuelHighway, FuelCombined, Turbo, ABS, SteeringPowerer, Spoiler, Cost) VALUES('" + Release_Date + "', " + Manafacturer_ID + " , '" + Model + "' , " + Class_ID + " , " + Country_ID + " , " + DatabaseControlService.QBuilder.ConvertParameter(Warranty) + " , " + Body_ID + " , " + DoorsNumber + " , " + PlacesNumber + " , " + MaxSpeed + " , " + MotorVolume + ", " + HP + " , " + RPM + " , '" + Torque + "' , '" + CylindersAligment + "' , " + CylindersNumber + " , " + CylinderValves + " , " + DatabaseControlService.QBuilder.ConvertParameter(Acceleration) + " , " + DatabaseControlService.QBuilder.ConvertParameter(Braking) + " , " + TransmissionNumberM + " , " + TransmissionNumberA + " , '" + EnginePosition + "' , " + Gear_ID + " , '" + GDM + "' , " + FuelTank + " , '" + FuelMethod + "' , '" + FuelType + "' , " + StMass + " , " + GVW + " , '" + Size + "' , " + WheelsBase + " , " + GroundClearance + " , " + MaxAmountTrunk + " , " + MinAmountTrunk + " , '" + FrontBrakes + "' , '" + RearBrakes + "' , " + DatabaseControlService.QBuilder.ConvertParameter(FuelCity) + " , " + DatabaseControlService.QBuilder.ConvertParameter(FuelHighway) + " , " + DatabaseControlService.QBuilder.ConvertParameter(FuelCombined) + " , " + DatabaseControlService.QBuilder.ConvertParameter(Turbo) + " , " + DatabaseControlService.QBuilder.ConvertParameter(ABS) + " , " + DatabaseControlService.QBuilder.ConvertParameter(SteeringPowerer) + " , " + DatabaseControlService.QBuilder.ConvertParameter(Spoiler) + " , " + DatabaseControlService.QBuilder.ConvertParameter(Cost) + ")";
        }

        public string Update()
        {
            return "UPDATE AutomobilesData SET Release_Date = ('" + Release_Date + "') , Manafacturer_ID = " + Manafacturer_ID + " , Model = '" + Model + "' , Class_ID = '" + Class_ID + "' , Country_ID = " + Country_ID + " , Warranty = " + DatabaseControlService.QBuilder.ConvertParameter(Warranty) + " , Body_ID = " + Body_ID + " , DoorsNumber = " + DoorsNumber + " , PlacesNumber = " + PlacesNumber + " , MaxSpeed = " + MaxSpeed + " , MotorVolume = " + MotorVolume + " , HP = " + HP + " , RPM = " + RPM + " , Torque = '" + Torque + "' , CylindersAligment = '" + CylindersAligment + "' , CylindersNumber = " + CylindersNumber + " ,  CylinderValves = " + CylinderValves + " , Acceleration = " + DatabaseControlService.QBuilder.ConvertParameter(Acceleration) + " , Braking =" + DatabaseControlService.QBuilder.ConvertParameter(Braking) + " , TransmissionNumberM = " + TransmissionNumberM + " , TransmissionNumberA = " + TransmissionNumberA + " , EnginePosition = '" + EnginePosition + "' , Gear_ID = " + Gear_ID + ", GDM = '" + GDM + "' , FuelTank = " + FuelTank + " , FuelMethod = '" + FuelMethod + "' , FuelType = '" + FuelType + "' , StMass = " + StMass + " , GVW = " + GVW + " , Size = '" + Size + "' , WheelsBase = " + WheelsBase + " , GroundClearance = " + GroundClearance + " , MaxAmountTrunk = " + MaxAmountTrunk + " , MinAmountTrunk = " + MinAmountTrunk + " , FrontBrakes = '" + FrontBrakes + "' , RearBrakes = '" + RearBrakes + "' , FuelCity = " + DatabaseControlService.QBuilder.ConvertParameter(FuelCity) + " , FuelHighway = " + DatabaseControlService.QBuilder.ConvertParameter(FuelHighway) + " , FuelCombined = " + DatabaseControlService.QBuilder.ConvertParameter(FuelCombined) + " , Turbo = " + DatabaseControlService.QBuilder.ConvertParameter(Turbo) + " , ABS = " + DatabaseControlService.QBuilder.ConvertParameter(ABS) + " , SteeringPowerer = " + DatabaseControlService.QBuilder.ConvertParameter(SteeringPowerer) + " , Spoiler = " + DatabaseControlService.QBuilder.ConvertParameter(Spoiler) + " , Cost = " + DatabaseControlService.QBuilder.ConvertParameter(Cost) + " WHERE Auto_ID = " + Auto_ID;
        }

        public string Delete()
        {
            return "DELETE FROM AutomobilesData WHERE Release_Date = ('" + Release_Date + "') AND Manafacturer_ID = " + Manafacturer_ID + " AND Model = '" + Model + "' AND Class_ID = '" + Class_ID + "' AND Country_ID = " + Country_ID + " AND Warranty = " + DatabaseControlService.QBuilder.ConvertParameter(Warranty) + " AND Body_ID = " + Body_ID + " AND DoorsNumber = " + DoorsNumber + " AND PlacesNumber = " + PlacesNumber + " AND MaxSpeed = " + MaxSpeed + " AND MotorVolume = " + MotorVolume + " AND HP = " + HP + " AND RPM = " + RPM + " AND Torque = '" + Torque + "' AND CylindersAligment = '" + CylindersAligment + "' AND CylindersNumber = " + CylindersNumber + " AND  CylinderValves = " + CylinderValves + " AND Acceleration = " + DatabaseControlService.QBuilder.ConvertParameter(Acceleration) + " AND Braking =" + DatabaseControlService.QBuilder.ConvertParameter(Braking) + " AND TransmissionNumberM = " + TransmissionNumberM + " AND TransmissionNumberA = " + TransmissionNumberA + " AND EnginePosition = '" + EnginePosition + "' AND Gear_ID = " + Gear_ID + " AND GDM = '" + GDM + "' AND FuelTank = " + FuelTank + " AND FuelMethod = '" + FuelMethod + "' AND FuelType = '" + FuelType + "' AND StMass = " + StMass + " AND GVW = " + GVW + " AND Size = '" + Size + "' AND WheelsBase = " + WheelsBase + " AND GroundClearance = " + GroundClearance + " AND MaxAmountTrunk = " + MaxAmountTrunk + " AND MinAmountTrunk = " + MinAmountTrunk + " AND FrontBrakes = '" + FrontBrakes + "' AND RearBrakes = '" + RearBrakes + "' AND FuelCity = " + DatabaseControlService.QBuilder.ConvertParameter(FuelCity) + " AND FuelHighway = " + DatabaseControlService.QBuilder.ConvertParameter(FuelHighway) + " AND FuelCombined = " + DatabaseControlService.QBuilder.ConvertParameter(FuelCombined) + " AND Turbo = " + DatabaseControlService.QBuilder.ConvertParameter(Turbo) + " AND ABS = " + DatabaseControlService.QBuilder.ConvertParameter(ABS) + " AND SteeringPowerer = " + DatabaseControlService.QBuilder.ConvertParameter(SteeringPowerer) + " AND Spoiler = " + DatabaseControlService.QBuilder.ConvertParameter(Spoiler) + " AND Cost = " + DatabaseControlService.QBuilder.ConvertParameter(Cost);
        }

        public string ViewAll()
        {
            return "SELECT * FROM ViewAutomobilesData";
        }

        public static void SaveToXML()
        {
            try
            {
                Manafacturers.SaveToXML();
                Classes.SaveToXML();
                Countries.SaveToXML();
                BodyTypes.SaveToXML();
                GearTypes.SaveToXML();

                DatabaseControlService.SQL.SqlProcduceCommand(SelectAll());
                DatabaseControlService.SQL.SQLDS.WriteXml("XML\\AutomobilesData.XML");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("XML ERROR: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void LoadFromXML()
        {
            try
            {
                Manafacturers.LoadFromXML();
                Classes.LoadFromXML();
                Countries.LoadFromXML();
                BodyTypes.LoadFromXML();
                GearTypes.LoadFromXML();

                AutomobilesData DB = new AutomobilesData();
                DatabaseControlService.SQL.SQLDS = new DataSet();
                DatabaseControlService.SQL.SQLDS.ReadXml("XML\\AutomobilesData.XML");
                DataSet Base = new DataSet();
                Base.ReadXml("XML\\AutomobilesData.XML");
                if (Base.Tables.Count == 0) return;
                if (DatabaseControlService.SQL.DataTableHasValues())
                {
                    for (int i = 0; i < Base.Tables["Table"].Rows.Count; i++)
                    {
                        int OLD_ValueID = Convert.ToInt32(Base.Tables["Table"].Rows[i][2]);
                        DatabaseControlService.SQL.SQLDS = new DataSet();
                        DatabaseControlService.SQL.SQLDS.ReadXml("XML\\Manafacturers.XML");
                        string OLD_Name = DatabaseControlService.SQL.GetValueByID(OLD_ValueID, 1, 0);
                        Base.Tables["Table"].Rows[i][2] = DatabaseControlService.DBECS.GetManafacturerIDByManafacturerName(OLD_Name);

                        OLD_ValueID = Convert.ToInt32(Base.Tables["Table"].Rows[i][4]);
                        DatabaseControlService.SQL.SQLDS = new DataSet();
                        DatabaseControlService.SQL.SQLDS.ReadXml("XML\\Classes.XML");
                        OLD_Name = DatabaseControlService.SQL.GetValueByID(OLD_ValueID, 1, 0);
                        Base.Tables["Table"].Rows[i][4] = DatabaseControlService.DBECS.GetClassIDByClassName(OLD_Name);

                        OLD_ValueID = Convert.ToInt32(Base.Tables["Table"].Rows[i][5]);
                        DatabaseControlService.SQL.SQLDS = new DataSet();
                        DatabaseControlService.SQL.SQLDS.ReadXml("XML\\Countries.XML");
                        OLD_Name = DatabaseControlService.SQL.GetValueByID(OLD_ValueID, 1, 0);
                        Base.Tables["Table"].Rows[i][5] = DatabaseControlService.DBECS.GetCountryIDByCountryName(OLD_Name);

                        OLD_ValueID = Convert.ToInt32(Base.Tables["Table"].Rows[i][7]);
                        DatabaseControlService.SQL.SQLDS = new DataSet();
                        DatabaseControlService.SQL.SQLDS.ReadXml("XML\\BodyTypes.XML");
                        OLD_Name = DatabaseControlService.SQL.GetValueByID(OLD_ValueID, 1, 0);
                        Base.Tables["Table"].Rows[i][7] = DatabaseControlService.DBECS.GetBodyIDByBodyName(OLD_Name);

                        OLD_ValueID = Convert.ToInt32(Base.Tables["Table"].Rows[i][23]);
                        DatabaseControlService.SQL.SQLDS = new DataSet();
                        DatabaseControlService.SQL.SQLDS.ReadXml("XML\\GearTypes.XML");
                        OLD_Name = DatabaseControlService.SQL.GetValueByID(OLD_ValueID, 1, 0);
                        Base.Tables["Table"].Rows[i][22] = DatabaseControlService.DBECS.GetGearIDByGearName(OLD_Name);

                        DB.Reset();
                        DB.LoadData(Base, i);
                        if (!DB.CheckAll())
                            DatabaseControlService.SQL.SqlProcduceTransactionCommand(DB.Insert());
                        else
                        {
                            DatabaseControlService.SQL.SqlProcduceCommand(SelectAll());
                            int ID = DatabaseControlService.SQL.GetIDByValue(DB.Model, 3, 0);
                            DB.Auto_ID = ID;
                            DatabaseControlService.SQL.SqlProcduceTransactionCommand(DB.Update());
                        }
                    }
                    DatabaseControlService.SQL.SQLDS = new DataSet();
                    DatabaseControlService.SQL.SQLDS.ReadXml("XML\\AutomobilesData.XML");
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("XML ERROR: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
