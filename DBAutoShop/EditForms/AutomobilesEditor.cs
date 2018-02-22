using System;
using System.Windows.Forms;
using DBAutoShop.Controllers;
using DBAutoShop.ORM;
using DBAutoShop.MainForms;

namespace DBAutoShop.EditForms
{
    public partial class AutomobilesEditor : Form
    {
        int EditorMode = 0;

        AutomobilesData DB;

        public AutomobilesEditor()
        {
            InitializeComponent();

            DB = new AutomobilesData();
        }

        public void LoadData()
        {
            if (EditorMode == 0) DB.Auto_ID = 0;
            DB.Release_Date = ReleaseDatePicker.Value;
            DB.Manafacturer_ID = DatabaseControlService.DBECS.GetManafacturerIDByManafacturerName(ManafacturerCombo.Text);
            DB.Model = ModelEdit.Text;
            DB.Class_ID = DatabaseControlService.DBECS.GetClassIDByClassName(ClassCombo.Text);
            DB.Country_ID = DatabaseControlService.DBECS.GetCountryIDByCountryName(CountryCombo.Text);
            DB.Warranty = WarrantyEdit.Value;
            DB.Body_ID = DatabaseControlService.DBECS.GetBodyIDByBodyName(BodyCombo.Text);
            DB.DoorsNumber = Convert.ToInt32(DoorsNumberEdit.Value);
            DB.PlacesNumber = Convert.ToInt32(PlacesNumberEdit.Value);
            DB.MaxSpeed = Convert.ToInt32(MaxSpeedEdit.Value);
            DB.MotorVolume = Convert.ToInt32(MotorVolumeEdit.Value);
            DB.HP = Convert.ToInt32(HPEdit.Value);
            DB.RPM = Convert.ToInt32(RPMEdit.Value);
            DB.Torque = TorqueEdit.Text;
            DB.CylindersAligment = CylindersAligmentEdit.Text;
            DB.CylindersNumber = Convert.ToInt32(CylindersNumberEdit.Value);
            DB.CylinderValves = Convert.ToInt32(CylinderValvesEdit.Value);
            DB.Acceleration = AccelerationEdit.Value;
            DB.Braking = BrakingEdit.Value;
            DB.TransmissionNumberM = Convert.ToInt32(TransmissionNumberMEdit.Value);
            DB.TransmissionNumberA = Convert.ToInt32(TransmissionNumberAEdit.Value);
            DB.EnginePosition = EnginePositionEdit.Text;
            DB.Gear_ID = DatabaseControlService.DBECS.GetGearIDByGearName(GearCombo.Text);
            DB.GDM = GDMEdit.Text;
            DB.FuelTank = Convert.ToInt32(FuelTankEdit.Value);
            DB.FuelMethod = FuelMethodEdit.Text;
            DB.FuelType = FuelTypeEdit.Text;
            DB.StMass = Convert.ToInt32(StMassEdit.Value);
            DB.GVW = Convert.ToInt32(GVWEdit.Value);
            DB.Size = SizeEdit.Text;
            DB.WheelsBase = Convert.ToInt32(WheelsBaseEdit.Value);
            DB.GroundClearance = Convert.ToInt32(GroundClearanceEdit.Value);
            DB.MaxAmountTrunk = Convert.ToInt32(MaxAmountTrunkEdit.Value);
            DB.MinAmountTrunk = Convert.ToInt32(MinAmountTrunkEdit.Value);
            DB.FrontBrakes = FrontBrakesEdit.Text;
            DB.RearBrakes = RearBrakesEdit.Text;
            DB.FuelCity = FuelCityEdit.Value;
            DB.FuelHighway = FuelHighwayEdit.Value;
            DB.FuelCombined = FuelCombinedEdit.Value;
            DB.Turbo = TurboCheck.Checked;
            DB.ABS = ABSCheck.Checked;
            DB.SteeringPowerer = SteeringPowererCheck.Checked;
            DB.Spoiler = SpoilerCheck.Checked;
            DB.Cost = CostEdit.Value;
        }

        private bool CheckData()
        {
            LoadData();
            if (ManafacturerCombo.SelectedIndex == -1) { MessageBox.Show("Выберите Производителя из списка производителей!"); return false; }
            if (ModelEdit.Text == "") { MessageBox.Show("Заполните поле Модель!"); return false; }
            if (ClassCombo.SelectedIndex == -1) { MessageBox.Show("Выберите Класс из списка классов!"); return false; }
            if (CountryCombo.SelectedIndex == -1) { MessageBox.Show("Выберите Страну из списка стран!"); return false; }
            if (WarrantyEdit.Value < 0) { MessageBox.Show("Гарантия должна быть не меньше 0!"); return false; }
            if (CostEdit.Value <= 0) { MessageBox.Show("Цена должна быть больше 0!"); return false; }
            if (BodyCombo.SelectedIndex == -1) { MessageBox.Show("Выберите Тип кузова из списка типов кузовов!"); return false; }
            if (DoorsNumberEdit.Value <= 0) { MessageBox.Show("Дверей должно быть больше 0!"); return false; }
            if (PlacesNumberEdit.Value <= 0) { MessageBox.Show("Мест должно быть больше 0!"); return false; }
            if (MotorVolumeEdit.Value <= 0) { MessageBox.Show("Объем двигателя должен быть больше 0!"); return false; }
            if (MaxSpeedEdit.Value <= 0) { MessageBox.Show("Максимальная скорость должна быть больше 0!"); return false; }
            if (RPMEdit.Value <= 0) { MessageBox.Show("Максимальные обороты должны быть больше 0!"); return false; }
            if (HPEdit.Value <= 0) { MessageBox.Show("Мощность должна быть больше 0!"); return false; }
            if (TorqueEdit.Text == "") { MessageBox.Show("Заполните поле Крутящий момент!"); return false; }
            if (CylindersAligmentEdit.Text == "") { MessageBox.Show("Заполните поле Расположение цилиндров!"); return false; }
            if (CylindersNumberEdit.Value <= 0) { MessageBox.Show("Количество цилиндров должна быть больше 0!"); return false; }
            if (GearCombo.SelectedIndex == -1) { MessageBox.Show("Выберите Тип привода из типов привода!"); return false; }
            if (FuelTankEdit.Value <= 0) { MessageBox.Show("Объем бака должен быть больше 0!"); return false; }
            if (FuelTypeEdit.Text == "") { MessageBox.Show("Заполните поле Тип топлива!"); return false; }
            if (StMassEdit.Value <= 0) { MessageBox.Show("Снаряженная масса должна быть больше 0!"); return false; }
            if (GVWEdit.Value <= 0) { MessageBox.Show("Допустимая полная масса должна быть больше 0!"); return false; }
            return true;
        }

        public void FormReset()
        {
            ReleaseDatePicker.Value = DateTime.Now;
            ManafacturerCombo.Text = "";
            ModelEdit.Text = "";
            ClassCombo.Text = "";
            CountryCombo.Text = "";
            WarrantyEdit.Value = 0;
            BodyCombo.Text = "";
            DoorsNumberEdit.Value = 0;
            PlacesNumberEdit.Value = 0;
            MaxSpeedEdit.Value = 0;
            MotorVolumeEdit.Value = 0;
            HPEdit.Value = 0;
            RPMEdit.Value = 0;
            TorqueEdit.Text = "";
            CylindersAligmentEdit.Text = "";
            CylindersNumberEdit.Value = 0;
            CylinderValvesEdit.Value = 0;
            AccelerationEdit.Value = 0;
            BrakingEdit.Value = 0;
            TransmissionNumberMEdit.Value = 0;
            TransmissionNumberAEdit.Value = 0;
            EnginePositionEdit.Text = "";
            GearCombo.Text = "";
            GDMEdit.Text = "";
            FuelTankEdit.Value = 0;
            FuelMethodEdit.Text = "";
            FuelTypeEdit.Text = "";
            StMassEdit.Value = 0;
            GVWEdit.Value = 0;
            SizeEdit.Text = "";
            WheelsBaseEdit.Value = 0;
            GroundClearanceEdit.Value = 0;
            MaxAmountTrunkEdit.Value = 0;
            MinAmountTrunkEdit.Value = 0;
            FrontBrakesEdit.Text = "";
            RearBrakesEdit.Text = "";
            FuelCityEdit.Value = 0;
            FuelHighwayEdit.Value = 0;
            FuelCombinedEdit.Value = 0;
            TurboCheck.Checked = false;
            ABSCheck.Checked = false;
            SteeringPowererCheck.Checked = false;
            SpoilerCheck.Checked = false;
            CostEdit.Value = 0;
        }

        public void FormLoad()
        {
            ReleaseDatePicker.Value = DB.Release_Date;
            ManafacturerCombo.SelectedItem = DatabaseControlService.DBECS.GetManafacturerNameByManafacturerID(DB.Manafacturer_ID);
            ModelEdit.Text = DB.Model;
            ClassCombo.SelectedItem = DatabaseControlService.DBECS.GetClassNameByClassID(DB.Class_ID);
            CountryCombo.SelectedItem = DatabaseControlService.DBECS.GetCountryNameByCountryID(DB.Country_ID);
            WarrantyEdit.Value = DB.Warranty;
            BodyCombo.SelectedItem = DatabaseControlService.DBECS.GetBodyNameByBodyID(DB.Body_ID);
            DoorsNumberEdit.Value = DB.DoorsNumber;
            PlacesNumberEdit.Value = DB.PlacesNumber;
            MaxSpeedEdit.Value = DB.MaxSpeed;
            MotorVolumeEdit.Value = DB.MotorVolume;
            HPEdit.Value = DB.HP;
            RPMEdit.Value = DB.RPM;
            TorqueEdit.Text = DB.Torque;
            CylindersAligmentEdit.Text = DB.CylindersAligment;
            CylindersNumberEdit.Value = DB.CylindersNumber;
            CylinderValvesEdit.Value = DB.CylinderValves;
            AccelerationEdit.Value = DB.Acceleration;
            BrakingEdit.Value = DB.Braking;
            TransmissionNumberMEdit.Value = DB.TransmissionNumberM;
            TransmissionNumberAEdit.Value = DB.TransmissionNumberA;
            EnginePositionEdit.Text = DB.EnginePosition;
            GearCombo.Text = DatabaseControlService.DBECS.GetGearNameByGearID(DB.Gear_ID);
            GDMEdit.Text = DB.GDM ;
            FuelTankEdit.Value = DB.FuelTank;
            FuelMethodEdit.Text = DB.FuelMethod;
            FuelTypeEdit.Text = DB.FuelType;
            StMassEdit.Value = DB.StMass;
            GVWEdit.Value = DB.GVW;
            SizeEdit.Text = DB.Size;
            WheelsBaseEdit.Value = DB.WheelsBase;
            GroundClearanceEdit.Value = DB.GroundClearance;
            MinAmountTrunkEdit.Value = DB.MinAmountTrunk;
            MaxAmountTrunkEdit.Value = DB.MaxAmountTrunk;
            FrontBrakesEdit.Text = DB.FrontBrakes;
            RearBrakesEdit.Text = DB.RearBrakes;
            FuelCityEdit.Value = DB.FuelCity;
            FuelHighwayEdit.Value = DB.FuelHighway;
            FuelCombinedEdit.Value = DB.FuelCombined;
            TurboCheck.Checked = DB.Turbo;
            ABSCheck.Checked = DB.ABS;
            SteeringPowererCheck.Checked = DB.SteeringPowerer;
            SpoilerCheck.Checked = DB.Spoiler;
            CostEdit.Value = DB.Cost;
        }

        public void FormStart()
        {
            ManafacturerCombo.Items.Clear();
            ClassCombo.Items.Clear();
            CountryCombo.Items.Clear();
            BodyCombo.Items.Clear();
            GearCombo.Items.Clear();
            DatabaseControlService.LoadComboData("SELECT ManafacturerName FROM Manafacturers", ManafacturerCombo);
            DatabaseControlService.LoadComboData("SELECT ClassName FROM Classes", ClassCombo);
            DatabaseControlService.LoadComboData("SELECT CountryName FROM Countries", CountryCombo);
            DatabaseControlService.LoadComboData("SELECT BodyName FROM BodyTypes", BodyCombo);
            DatabaseControlService.LoadComboData("SELECT GearName FROM GearTypes", GearCombo);
        }

        public void CallEdit(DataGridView DG)
        {
            EditorMode = 1;

            FormStart();
            DB.LoadData(DG);
            FormReset();
            FormLoad();

            this.Text = "Редактирование автомобиля...";
            this.ShowDialog();
        }

        public void CallInsert()
        {
            EditorMode = 0;

            FormStart();
            DB.Reset();
            FormReset();

            this.Text = "Добавление автомобиля...";
            this.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (EditorMode == 1)
            {
                if (CheckData())
                {
                    DatabaseControlService.SQL.SqlProcduceTransactionCommand(DB.Update());
                    EditorMode = 0;
                    this.Close();
                }
            }
            else
            {
                if (CheckData())
                {
                    DatabaseControlService.SQL.SqlProcduceTransactionCommand(DB.Insert());
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NumberEdit_ValueChanged(object sender, EventArgs e)
        {
            if ((sender as NumericUpDown).Value < 0)
            {
                (sender as NumericUpDown).Value = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DatabaseControlService.DBSmallSelector.Call(7);
            ManafacturerCombo.Items.Clear();
            DatabaseControlService.LoadComboData("SELECT ManafacturerName FROM Manafacturers", ManafacturerCombo);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DatabaseControlService.DBSmallSelector.Call(2);
            ClassCombo.Items.Clear();
            DatabaseControlService.LoadComboData("SELECT ClassName FROM Classes", ClassCombo);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DatabaseControlService.DBSmallSelector.Call(4);
            CountryCombo.Items.Clear();
            DatabaseControlService.LoadComboData("SELECT CountryName FROM Countries", CountryCombo);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DatabaseControlService.DBSmallSelector.Call(1);
            BodyCombo.Items.Clear();
            DatabaseControlService.LoadComboData("SELECT BodyName FROM BodyTypes", BodyCombo);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DatabaseControlService.DBSmallSelector.Call(5);
            GearCombo.Items.Clear();
            DatabaseControlService.LoadComboData("SELECT GearName FROM GearTypes", GearCombo);
        }
    }
}
