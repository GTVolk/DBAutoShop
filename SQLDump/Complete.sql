CREATE DATABASE [AutoShop]
GO

USE [AutoShop]
GO

CREATE TABLE [Colors](
	[Color_ID] int identity(1,1) primary key not null,
	[ColorName] varchar(50) unique not null check([ColorName]!='')
)
CREATE TABLE [Manafacturers](
	[Manafacturer_ID] int identity(1,1) primary key not null,
	[ManafacturerName] varchar(50) unique not null check([ManafacturerName]!='')
)
CREATE TABLE [Countries](
	[Country_ID] int identity(1,1) primary key not null,
	[CountryName] varchar(50) unique not null check([CountryName]!=''),
	[Language_ID] int not null
)
CREATE TABLE [Languages](
	[Language_ID] int identity(1,1) primary key not null,
	[LanguageName] varchar(50) unique not null check([LanguageName]!='')
)
CREATE TABLE [Classes](
	[Class_ID] int identity(1,1) primary key not null,
	[ClassName] varchar(50) unique not null check([ClassName]!='')
)
CREATE TABLE [BodyTypes](
	[Body_ID] int identity(1,1) primary key not null,
	[BodyName] varchar(50) unique not null check([BodyName]!='')
)
CREATE TABLE [GearTypes](
	[Gear_ID] int identity(1,1) primary key not null,
	[GearName] varchar(50) unique not null check([GearName]!='')
)
CREATE TABLE [Workplaces](
	[Workplace_ID] int identity(1,1) primary key not null,
	[WorkplaceName] varchar(50) unique not null check([WorkplaceName]!='')
)
CREATE TABLE [Orders](
	[Order_ID] int identity(1,1) primary key not null,
	[Auto_ID] int not null,
	[Client_ID] int not null,
	[Order_Date] date not null,
	[Order_Condition] varchar(50) not null default('В рассмотрении...'),
)
CREATE TABLE [Offices](
	[Office_ID] int identity(1,1) primary key not null,
	[Office_Name] varchar(50) unique not null,
	[Address] varchar(150) unique not null check([Address]!=''),
	[Telephone] varchar(11) unique not null check([Telephone]!=''),
	[Auto_Count] int not null default(0),
	[Workers_Count] int not null default(0)
)
CREATE TABLE [Sells](
	[Sell_ID] int identity(1,1) primary key not null,
	[Auto_ID] int not null,
	[Color_ID] int not null,
	[Client_ID] int,
	[Worker_ID] int,
	[Office_ID] int not null,
	[No_body] varchar(15) unique not null check([No_body]!=''),
	[No_engine] varchar(15) unique not null check([No_engine]!=''),
	[No_PTC] varchar(17) unique not null check([No_PTC]!=''),
	[Complectation] varchar(25),
	[Sell_Discount] int not null default(0),
	[Sell_Cost] decimal(12,2) not null default(0),
	[Receipt_Date] date not null default(getdate()),
	[Sell_Date] date default(getdate()),
	[Dissapear_Date] date default(getdate()),
	[Selled_Check] tinyint not null default(0)
)
CREATE TABLE [Workers](
	[Worker_ID] int identity(1,1) primary key not null,
	[Family] varchar(50) not null check([Family]!=''),
	[Name] varchar(50) not null check([Name]!=''),
	[Surname] varchar(50) not null check([Surname]!=''),
	[Telephone] varchar(11) unique not null check([Telephone]!=''),
	[Workplace_ID] int not null,
	[Office_ID] int not null,
	[Address] varchar(150) unique not null check([Address]!='')
)
CREATE TABLE [Clients](
	[Client_ID] int identity(1,1) primary key not null,
	[Family] varchar(50) not null check([Family]!=''),
	[Name] varchar(50) not null check([Name]!=''),
	[Surname] varchar(50) not null check([Surname]!=''),
	[Discount] int not null default(0),
	[Purchases] int not null default(0),
	[Orders_Count] int not null default(0),
	[Telephone] varchar(11) unique not null check([Telephone]!=''),
	[Address] varchar(150) unique not null check([Address]!=''),
	[Total_Spended] decimal(14,2) not null default(0)
)
CREATE TABLE [AutomobilesData](
	[Auto_ID] int identity(1,1) primary key not null,
	[Release_Date] date not null,
	[Manafacturer_ID] int not null,
	[Model] varchar(75) unique not null check([Model]!=''),
	[Class_ID] int not null,
	[Country_ID] int not null,
	[Warranty] decimal(5,1) not null check([Warranty]>=0),
	[Body_ID] int not null,
	[DoorsNumber] int not null check([DoorsNumber]>0),
	[PlacesNumber] int not null check([PlacesNumber]>0),
	[MaxSpeed] int not null check([MaxSpeed]>0),
	[MotorVolume] int not null check([MotorVolume]>0),
	[HP] int not null check([HP]>0),
	[RPM] int not null check([RPM]>0),
	[Torque] varchar(25) not null,
	[CylindersAligment] varchar(25) not null,
	[CylindersNumber] int not null check([CylindersNumber]>0),
	[CylinderValves] int,
	[Acceleration] decimal(5,1),
	[Braking] decimal(5,1),
	[TransmissionNumberM] int,
	[TransmissionNumberA] int,
	[EnginePosition] varchar(50),
	[Gear_ID] int not null,
	[GDM] varchar(25),
	[FuelTank] int not null check([FuelTank]>0),
	[FuelMethod] varchar(50),
	[FuelType] varchar(25) not null,
	[StMass] int not null check([StMass]>0),
	[GVW] int not null check([GVW]>0),
	[Size] varchar(100),
	[WheelsBase] int,
	[GroundClearance] int,
	[MaxAmountTrunk] int,
	[MinAmountTrunk] int,
	[FrontBrakes] varchar(50),
	[RearBrakes] varchar(50),
	[FuelCity] decimal(5,1),
	[FuelHighway] decimal(5,1),
	[FuelCombined] decimal(5,1),
	[Turbo] bit default(0),
	[ABS] bit not null default(0),
	[SteeringPowerer] bit not null default(0),
	[Spoiler] bit not null default(0),
	[Cost] decimal(12,2) not null check([Cost]>0),
)
GO

ALTER TABLE [dbo].[Countries]  WITH CHECK ADD  CONSTRAINT [FK_Countries_Languages] FOREIGN KEY([Language_ID])
REFERENCES [dbo].[Languages] ([Language_ID])

ALTER TABLE [dbo].[AutomobilesData]  WITH CHECK ADD  CONSTRAINT [FK_AutomobilesData_Manafacturers] FOREIGN KEY([Manafacturer_ID])
REFERENCES [dbo].[Manafacturers] ([Manafacturer_ID])

ALTER TABLE [dbo].[AutomobilesData]  WITH CHECK ADD  CONSTRAINT [FK_AutomobilesData_Classes] FOREIGN KEY([Class_ID])
REFERENCES [dbo].[Classes] ([Class_ID])

ALTER TABLE [dbo].[AutomobilesData]  WITH CHECK ADD  CONSTRAINT [FK_AutomobilesData_Countries] FOREIGN KEY([Country_ID])
REFERENCES [dbo].[Countries] ([Country_ID])

ALTER TABLE [dbo].[AutomobilesData]  WITH CHECK ADD  CONSTRAINT [FK_AutomobilesData_BodyTypes] FOREIGN KEY([Body_ID])
REFERENCES [dbo].[BodyTypes] ([Body_ID])

ALTER TABLE [dbo].[AutomobilesData]  WITH CHECK ADD  CONSTRAINT [FK_AutomobilesData_GearTypes] FOREIGN KEY([Gear_ID])
REFERENCES [dbo].[GearTypes] ([Gear_ID])

ALTER TABLE [dbo].[Sells]  WITH CHECK ADD  CONSTRAINT [FK_Sells_AutomobilesData] FOREIGN KEY([Auto_ID])
REFERENCES [dbo].[AutomobilesData] ([Auto_ID])

ALTER TABLE [dbo].[Sells]  WITH CHECK ADD  CONSTRAINT [FK_Sells_Colors] FOREIGN KEY([Color_ID])
REFERENCES [dbo].[Colors] ([Color_ID])

ALTER TABLE [dbo].[Sells]  WITH CHECK ADD  CONSTRAINT [FK_Sells_Offices] FOREIGN KEY([Office_ID])
REFERENCES [dbo].[Offices] ([Office_ID])

ALTER TABLE [dbo].[Sells]  WITH CHECK ADD  CONSTRAINT [FK_Sells_Workers] FOREIGN KEY([Worker_ID])
REFERENCES [dbo].[Workers] ([Worker_ID])

ALTER TABLE [dbo].[Sells]  WITH CHECK ADD  CONSTRAINT [FK_Sells_Clients] FOREIGN KEY([Client_ID])
REFERENCES [dbo].[Clients] ([Client_ID])

ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_AutomobilesData] FOREIGN KEY([Auto_ID])
REFERENCES [dbo].[AutomobilesData] ([Auto_ID])

ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Clients] FOREIGN KEY([Client_ID])
REFERENCES [dbo].[Clients] ([Client_ID])

ALTER TABLE [dbo].[Workers]  WITH CHECK ADD  CONSTRAINT [FK_Workers_Workplaces] FOREIGN KEY([Workplace_ID])
REFERENCES [dbo].[Workplaces] ([Workplace_ID])

GO

CREATE FUNCTION GetAllSpended(@Input int)
RETURNS int
AS
BEGIN
	DECLARE @TS int
	SELECT @TS = SUM(Sell_Cost) FROM Sells WHERE Client_ID = @Input
	RETURN(@TS)
END
GO

CREATE FUNCTION GetCost(@Inp int)
RETURNS int
AS
BEGIN
	DECLARE @TC int
	SELECT @TC = Cost FROM dbo.Sells INNER JOIN dbo.AutomobilesData ON dbo.Sells.Auto_ID = dbo.AutomobilesData.Auto_ID
	WHERE Sell_ID = @Inp
	RETURN(@TC)
END
GO

CREATE PROCEDURE CalculateSellCost
	@SID int,
	@CID int
AS
	DECLARE @cost int
	DECLARE @discount decimal(12,2)
	SET @cost = dbo.GetCost(@SID)
	SELECT  @discount = Discount FROM Clients WHERE Client_ID = @CID
	UPDATE Sells SET Sell_Discount = @discount WHERE Sell_ID = @SID
	UPDATE Sells SET Sell_Cost = @cost - @cost*(@discount/100) WHERE Sell_ID = @SID
GO

CREATE PROCEDURE UpdateParams
	@CID int,
	@Sum int
AS
	UPDATE Clients SET Total_Spended = @Sum WHERE Client_ID = @CID
	UPDATE Clients SET Purchases = Purchases + 1 WHERE Client_ID = @CID
	IF (@sum >= 1000000 AND @sum < 3000000) UPDATE Clients SET Discount = 5 WHERE Client_ID = @CID
	IF (@sum >= 3000000 AND @sum < 6000000) UPDATE Clients SET Discount = 10 WHERE Client_ID = @CID
	IF (@sum >= 6000000 AND @sum < 10000000) UPDATE Clients SET Discount = 15 WHERE Client_ID = @CID
	IF (@sum >= 10000000 AND @sum < 15000000) UPDATE Clients SET Discount = 25 WHERE Client_ID = @CID
	IF (@sum >= 15000000 AND @sum < 21000000) UPDATE Clients SET Discount = 33 WHERE Client_ID = @CID
	IF (@sum >= 21000000 AND @sum < 30000000) UPDATE Clients SET Discount = 50 WHERE Client_ID = @CID
	IF (@sum >= 30000000) UPDATE Clients SET Discount = 66 WHERE Client_ID = @CID
GO

CREATE TRIGGER SelectingAction
ON [Sells]
AFTER INSERT, UPDATE
AS
BEGIN
	DECLARE @SID int
	DECLARE @CID int
	DECLARE @AIDOLD int
	DECLARE @Checked tinyint
	DECLARE @sum decimal(12,2)
	SELECT @SID = Sell_ID FROM inserted
	SELECT @CID = Client_ID FROM inserted
	SELECT @AIDOLD = Auto_ID FROM deleted
	SELECT @Checked = Selled_Check FROM inserted
	IF (NOT (@CID is NULL) AND (@Checked = 1))
	BEGIN
		EXEC CalculateSellCost @SID, @CID
		SET @sum = dbo.GetAllSpended(@CID)
		EXEC UpdateParams @CID, @sum
		UPDATE Offices SET Auto_Count  = Auto_Count - 1 WHERE Office_ID = (SELECT Office_ID FROM inserted)
	END
	IF (@AIDOLD is NULL)
		UPDATE Offices SET Auto_Count  = Auto_Count + 1 WHERE Office_ID = (SELECT Office_ID FROM inserted)		
END
GO

CREATE TRIGGER RemovedStorage
ON [Sells]
AFTER DELETE
AS
BEGIN
	UPDATE Offices SET Auto_Count  = Auto_Count - 1 WHERE Office_ID = (SELECT Office_ID FROM deleted)
END
GO


CREATE TRIGGER OrderInsert
ON [Orders]
AFTER INSERT
AS
BEGIN
	UPDATE Clients SET Orders_Count = Orders_Count + 1 WHERE Client_ID = (SELECT Client_ID FROM inserted) 
END
GO

CREATE TRIGGER OrderDelete
ON [Orders]
AFTER DELETE
AS
BEGIN
	UPDATE Clients SET Orders_Count = Orders_Count - 1 WHERE Client_ID = (SELECT Client_ID FROM inserted) 
END
GO

CREATE TRIGGER WorkerInsert
ON [Workers]
AFTER INSERT
AS
BEGIN
	UPDATE Offices SET Workers_Count = Workers_Count + 1 WHERE Office_ID = (SELECT Office_ID FROM inserted) 
END
GO

CREATE TRIGGER WorkerDelete
ON [Workers]
AFTER DELETE
AS
BEGIN
	UPDATE Offices SET Workers_Count = Workers_Count - 1 WHERE Office_ID = (SELECT Office_ID FROM inserted) 
END
GO

CREATE VIEW [dbo].[ViewAutomobilesData]
WITH SCHEMABINDING
AS
SELECT     dbo.AutomobilesData.Release_Date AS [Дата выпуска], dbo.Manafacturers.ManafacturerName AS Производитель, dbo.AutomobilesData.Model AS Модель, 
                      dbo.Classes.ClassName AS Класс, dbo.Countries.CountryName AS [Страна производитель], dbo.BodyTypes.BodyName AS [Тип кузова], 
                      dbo.GearTypes.GearName AS [Тип привода], dbo.AutomobilesData.DoorsNumber AS [Количество дверей], dbo.AutomobilesData.PlacesNumber AS [Количество мест], 
                      dbo.AutomobilesData.MaxSpeed AS [Максимальная скорость, км/ч], dbo.AutomobilesData.MotorVolume AS [Объем двигателя, м3], 
                      dbo.AutomobilesData.HP AS [Мощность двигателя. л.с.], dbo.AutomobilesData.RPM AS [Максимальные обороты, об/м], 
                      dbo.AutomobilesData.Torque AS [Крутящий момент. н*м], dbo.AutomobilesData.CylindersAligment AS [Расположение цилиндров], 
                      dbo.AutomobilesData.CylindersNumber AS [Количество цилиндров], dbo.AutomobilesData.CylinderValves AS [Количество клапанов на цилиндр], 
                      dbo.AutomobilesData.Acceleration AS [Время разгона (0-100 км/ч), с.], dbo.AutomobilesData.Braking AS [Время торможения (100-0 км/ч). с.], 
                      dbo.AutomobilesData.TransmissionNumberM AS [Количество передач (мех)], dbo.AutomobilesData.TransmissionNumberA AS [Количество передач (авто)], 
                      dbo.AutomobilesData.EnginePosition AS [Расположение двигателя], dbo.AutomobilesData.GDM AS [Газораспределительный механизм], 
                      dbo.AutomobilesData.FuelTank AS [Объем бака. л], dbo.AutomobilesData.FuelMethod AS [Система питания], dbo.AutomobilesData.FuelType AS [Тип топлива], 
                      dbo.AutomobilesData.StMass AS [Снаряженная масса автомобиля], dbo.AutomobilesData.GVW AS [Допустимая полная масса], 
                      dbo.AutomobilesData.Size AS Размеры, dbo.AutomobilesData.WheelsBase AS [Колесная база, мм], 
                      dbo.AutomobilesData.GroundClearance AS [Дорожный просвет. мм], dbo.AutomobilesData.MaxAmountTrunk AS [Объем багажника максимальный. л], 
                      dbo.AutomobilesData.MinAmountTrunk AS [Объем багажника минимальный. л], dbo.AutomobilesData.FrontBrakes AS [Передние тормоза], 
                      dbo.AutomobilesData.RearBrakes AS [Задние тормоза], dbo.AutomobilesData.FuelCity AS [Расход топлива в городе. л/100 км], 
                      dbo.AutomobilesData.FuelHighway AS [Расход топлива на шоссе. л/100 км], dbo.AutomobilesData.FuelCombined AS [Расход топлива смешанный цикл, л/100км], 
                      dbo.AutomobilesData.Turbo AS [Наличие турбонадува], dbo.AutomobilesData.ABS AS [Наличие АБС], 
                      dbo.AutomobilesData.SteeringPowerer AS [Наличие усилителя руля],dbo.AutomobilesData.Spoiler AS [Наличие спойлера], dbo.AutomobilesData.Warranty AS [Гарантия, лет], dbo.AutomobilesData.Cost AS Цена
FROM         dbo.AutomobilesData INNER JOIN
                      dbo.Manafacturers ON dbo.AutomobilesData.Manafacturer_ID = dbo.Manafacturers.Manafacturer_ID INNER JOIN
                      dbo.Countries ON dbo.AutomobilesData.Country_ID = dbo.Countries.Country_ID INNER JOIN
                      dbo.BodyTypes ON dbo.AutomobilesData.Body_ID = dbo.BodyTypes.Body_ID INNER JOIN
					  dbo.Classes ON dbo.AutomobilesData.Class_ID = dbo.Classes.Class_ID INNER JOIN
					  dbo.GearTypes ON dbo.AutomobilesData.Gear_ID = dbo.GearTypes.Gear_ID

GO

CREATE VIEW [dbo].[ViewBodyTypes]
AS
SELECT     BodyName AS [Наименование кузова]
FROM         dbo.BodyTypes
GO

CREATE VIEW [dbo].[ViewGearTypes]
AS
SELECT     GearName AS [Название типа привода]
FROM         dbo.GearTypes
GO

CREATE VIEW [dbo].[ViewClasses]
WITH SCHEMABINDING
AS
SELECT     ClassName AS [Название класса]
FROM         dbo.Classes

GO

CREATE VIEW [dbo].[ViewClients]
WITH SCHEMABINDING
AS
SELECT     Family AS Фамилия, Name AS Имя, Surname AS Отчество, Telephone AS Телефон, Address AS Адрес, Purchases AS Покупок, 
                      Orders_Count AS [Количество заказов], Discount AS [Скидка. %], Total_Spended AS [Всего потрачено]
FROM         dbo.Clients

GO

CREATE VIEW [dbo].[ViewColors]
AS
SELECT     ColorName AS [Название цвета]
FROM         dbo.Colors

GO

CREATE VIEW [dbo].[ViewCountries]
AS
SELECT     dbo.Countries.CountryName AS [Название страны], dbo.Languages.LanguageName AS [Язык страны]
FROM         dbo.Countries INNER JOIN
                      dbo.Languages ON dbo.Countries.Language_ID = dbo.Languages.Language_ID

GO

CREATE VIEW [dbo].[ViewLanguages]
AS
SELECT     LanguageName AS [Название языка]
FROM         dbo.Languages

GO

CREATE VIEW [dbo].[ViewManafacturers]
AS
SELECT     ManafacturerName AS [Название производителя]
FROM         dbo.Manafacturers

GO

CREATE VIEW [dbo].[ViewOffices]
WITH SCHEMABINDING
AS
SELECT     Office_Name AS [Название офиса], Address AS [Адрес офиса], Telephone AS [Телефон офиса], Auto_Count AS [Количество автомобилей], 
                      Workers_Count AS [Количество работников]
FROM         dbo.Offices

GO

CREATE VIEW [dbo].[ViewOrders]
WITH SCHEMABINDING
AS
SELECT     dbo.Orders.Order_Date AS [Дата заказа], dbo.Manafacturers.ManafacturerName AS Производитель, dbo.AutomobilesData.Model AS Модель, 
                      dbo.Clients.Family AS [Фамилия заказчика], dbo.Clients.Name AS [Имя заказчика], dbo.Clients.Surname AS [Отчество заказчика], 
                      dbo.Orders.Order_Condition AS [Состояние заказа], dbo.Orders.Order_ID AS [ИД Заказа]
FROM         dbo.Orders INNER JOIN
                      dbo.Clients ON dbo.Orders.Client_ID = dbo.Clients.Client_ID INNER JOIN
                      dbo.AutomobilesData ON dbo.Orders.Auto_ID = dbo.AutomobilesData.Auto_ID INNER JOIN
                      dbo.Manafacturers ON dbo.AutomobilesData.Manafacturer_ID = dbo.Manafacturers.Manafacturer_ID

GO

CREATE VIEW [dbo].[ViewPresenceCars]
WITH SCHEMABINDING
AS
SELECT     dbo.Sells.Receipt_Date AS [Дата приема], dbo.Manafacturers.ManafacturerName AS Производитель, dbo.AutomobilesData.Model AS Модель, 
                      dbo.Colors.ColorName AS [Цвет автомобиля], dbo.Sells.Complectation AS Комплектация, dbo.Offices.Office_Name AS [Название офиса], 
                      dbo.Sells.No_body AS [№ кузова], dbo.Sells.No_engine AS [№ двигателя], dbo.Sells.No_PTC AS [№ ПТС], 
                      dbo.AutomobilesData.Cost AS Цена
FROM         dbo.Sells INNER JOIN
                      dbo.AutomobilesData ON dbo.Sells.Auto_ID = dbo.AutomobilesData.Auto_ID INNER JOIN
                      dbo.Manafacturers ON dbo.AutomobilesData.Manafacturer_ID = dbo.Manafacturers.Manafacturer_ID INNER JOIN
                      dbo.Colors ON dbo.Sells.Color_ID = dbo.Colors.Color_ID INNER JOIN
                      dbo.Offices ON dbo.Sells.Office_ID = dbo.Offices.Office_ID
WHERE		dbo.Sells.Selled_Check = 0
GO

CREATE VIEW [dbo].[ViewSelledCars]
WITH SCHEMABINDING
AS
SELECT     dbo.Sells.Sell_Date AS [Дата продажи], dbo.Manafacturers.ManafacturerName AS Производитель, dbo.AutomobilesData.Model AS Модель,
                      dbo.Colors.ColorName AS [Цвет автомобиля], dbo.Sells.Complectation AS Комплектация, dbo.Offices.Office_Name AS [Название офиса], 
                      dbo.Sells.No_body AS [№ кузова], dbo.Sells.No_engine AS [№ двигателя], dbo.Sells.No_PTC AS [№ ПТС], dbo.AutomobilesData.Cost AS Цена, dbo.Sells.Sell_Cost AS [Цена продажи]
FROM         dbo.Sells INNER JOIN
                      dbo.AutomobilesData ON dbo.Sells.Auto_ID = dbo.AutomobilesData.Auto_ID INNER JOIN
                      dbo.Manafacturers ON dbo.AutomobilesData.Manafacturer_ID = dbo.Manafacturers.Manafacturer_ID INNER JOIN
                      dbo.Colors ON dbo.Sells.Color_ID = dbo.Colors.Color_ID INNER JOIN
                      dbo.Offices ON dbo.Sells.Office_ID = dbo.Offices.Office_ID
WHERE		dbo.Sells.Selled_Check = 1
GO

CREATE VIEW [dbo].[ViewDissapearedCars]
WITH SCHEMABINDING
AS
SELECT     dbo.Sells.Dissapear_Date AS [Дата пропажи], dbo.Manafacturers.ManafacturerName AS Производитель, dbo.AutomobilesData.Model AS Модель,
                      dbo.Colors.ColorName AS [Цвет автомобиля], dbo.Sells.Complectation AS Комплектация, dbo.Offices.Office_Name AS [Название офиса], 
                      dbo.Sells.No_body AS [№ кузова], dbo.Sells.No_engine AS [№ двигателя], dbo.Sells.No_PTC AS [№ ПТС], dbo.AutomobilesData.Cost AS Цена
FROM         dbo.Sells INNER JOIN
                      dbo.AutomobilesData ON dbo.Sells.Auto_ID = dbo.AutomobilesData.Auto_ID INNER JOIN
                      dbo.Manafacturers ON dbo.AutomobilesData.Manafacturer_ID = dbo.Manafacturers.Manafacturer_ID INNER JOIN
                      dbo.Colors ON dbo.Sells.Color_ID = dbo.Colors.Color_ID INNER JOIN
                      dbo.Offices ON dbo.Sells.Office_ID = dbo.Offices.Office_ID
WHERE		dbo.Sells.Selled_Check = 2
GO

CREATE VIEW [dbo].[ViewSells]
WITH SCHEMABINDING
AS
SELECT     dbo.Sells.Sell_Date AS [Дата продажи], dbo.Manafacturers.ManafacturerName AS Производитель, dbo.AutomobilesData.Model AS Модель, dbo.Sells.No_PTC AS [№ ПТС], 
                      dbo.Clients.Family AS [Фамилия покупателя], dbo.Clients.Name AS [Имя покупателя], dbo.Clients.Surname AS [Отчество покупателя], 
                      dbo.Offices.Office_Name AS [Офис продажи], dbo.Workers.Family AS [Фамилия продавца], dbo.Workers.Name AS [Имя продавца], 
                      dbo.Workers.Surname AS [Отчество продавца], dbo.AutomobilesData.Cost AS [Цена автомобиля], dbo.Sells.Sell_Discount AS [Скидка. %], 
                      dbo.Sells.Sell_Cost AS [Цена продажи], dbo.AutomobilesData.Warranty AS [Гарантия, лет]
FROM         dbo.Sells INNER JOIN
                      dbo.Clients ON dbo.Sells.Client_ID = dbo.Clients.Client_ID INNER JOIN
                      dbo.AutomobilesData ON dbo.Sells.Auto_ID = dbo.AutomobilesData.Auto_ID INNER JOIN
                      dbo.Manafacturers ON dbo.AutomobilesData.Manafacturer_ID = dbo.Manafacturers.Manafacturer_ID INNER JOIN
                      dbo.Workers ON dbo.Sells.Worker_ID = dbo.Workers.Worker_ID INNER JOIN
                      dbo.Offices ON dbo.Sells.Office_ID = dbo.Offices.Office_ID

GO

CREATE VIEW [dbo].[ViewWorkers]
WITH SCHEMABINDING
AS
SELECT     dbo.Workers.Family AS [Фамилия], dbo.Workers.Name AS [Имя], dbo.Workers.Surname AS [Отчество], 
                      dbo.Workplaces.WorkplaceName AS Должность, dbo.Offices.Office_Name AS [Название офиса], dbo.Workers.Telephone AS Телефон, 
                      dbo.Workers.Address AS Адрес
FROM         dbo.Workers INNER JOIN
                      dbo.Workplaces ON dbo.Workers.Workplace_ID = dbo.Workplaces.Workplace_ID INNER JOIN
                      dbo.Offices ON dbo.Workers.Office_ID = dbo.Offices.Office_ID

GO

CREATE VIEW [dbo].[ViewWorkplaces]
AS
SELECT     WorkplaceName AS Должность
FROM         dbo.Workplaces

GO

CREATE UNIQUE CLUSTERED INDEX [PK_ViewAuto] ON [dbo].[ViewAutomobilesData] ([Производитель] DESC)
GO

CREATE UNIQUE CLUSTERED INDEX [PK_ViewClients] ON [dbo].[ViewClients] ([Телефон] ASC)
GO

CREATE UNIQUE CLUSTERED INDEX [PK_ViewOffices] ON [dbo].[ViewOffices] ([Название офиса] ASC)
GO

CREATE UNIQUE CLUSTERED INDEX [PK_ViewOrders] ON [dbo].[ViewOrders] ([ИД заказа] DESC)
GO

CREATE UNIQUE CLUSTERED INDEX [PK_ViewPresence] ON [dbo].[ViewPresenceCars] ([№ ПТС] DESC)
GO

CREATE UNIQUE CLUSTERED INDEX [PK_ViewSelled] ON [dbo].[ViewSelledCars] ([№ ПТС] DESC)
GO

CREATE UNIQUE CLUSTERED INDEX [PK_ViewSells] ON [dbo].[ViewSells] ([№ ПТС] DESC)
GO

CREATE UNIQUE CLUSTERED INDEX [PK_ViewWorkers] ON [dbo].[ViewWorkers] ([Телефон] DESC)
GO

CREATE FULLTEXT CATALOG [AutomobilesDataCatalog]
GO

CREATE FULLTEXT CATALOG [ClientsCatalog]
GO

CREATE FULLTEXT CATALOG [OfficesCatalog]
GO

CREATE FULLTEXT CATALOG [OrdersCatalog]
GO

CREATE FULLTEXT CATALOG [PresenceCarsCatalog]
GO

CREATE FULLTEXT CATALOG [SelledCarsCatalog]
GO

CREATE FULLTEXT CATALOG [SellsCatalog]
GO

CREATE FULLTEXT CATALOG [WorkersCatalog]
GO

CREATE FULLTEXT INDEX ON [ViewAutomobilesData] (
	    [Газораспределительный механизм] 
	        Language 0,
	    [Задние тормоза]
	        Language 0,
		[Класс]
	        Language 0,
	    [Модель]
	        Language 0,
	    [Передние тормоза]
	        Language 0,
	    [Производитель]
	        Language 0,
	    [Расположение двигателя]
	        Language 0,
		[Расположение цилиндров] 
	        Language 0,
	    [Система питания]
	        Language 0,
	    [Страна производитель]
	        Language 0,
		[Тип кузова] 
	        Language 0,
		[Тип привода] 
	        Language 0,
	    [Тип топлива]
	        Language 0
)
KEY INDEX [PK_ViewAuto]
ON	[AutomobilesDataCatalog]
WITH CHANGE_TRACKING AUTO
GO

CREATE FULLTEXT INDEX ON [ViewClients] (
	    [Фамилия] 
	        Language 0,
	    [Имя]
	        Language 0,
	    [Отчество]
	        Language 0,
	    [Телефон]
	        Language 0,
		[Адрес] 
	        Language 0
)
KEY INDEX [PK_ViewClients]
ON	[ClientsCatalog]
WITH CHANGE_TRACKING AUTO
GO

CREATE FULLTEXT INDEX ON [ViewOffices] (
	    [Название офиса] 
	        Language 0,
	    [Адрес офиса]
	        Language 0,
	    [Телефон офиса]
	        Language 0
)
KEY INDEX [PK_ViewOffices]
ON	[OfficesCatalog]
WITH CHANGE_TRACKING AUTO
GO

CREATE FULLTEXT INDEX ON [ViewOrders] (
	    [Производитель]
	        Language 0,
	    [Модель]
	        Language 0,
	    [Фамилия заказчика]
	        Language 0,
		[Имя заказчика] 
	        Language 0,
	    [Отчество заказчика]
	        Language 0,
		[Состояние заказа] 
	        Language 0
)
KEY INDEX [PK_ViewOrders]
ON	[OrdersCatalog]
WITH CHANGE_TRACKING AUTO
GO

CREATE FULLTEXT INDEX ON [ViewPresenceCars] (
	    [Производитель]
	        Language 0,
	    [Модель]
	        Language 0,
	    [Цвет автомобиля]
	        Language 0,
		[Комплектация] 
	        Language 0,
	    [Название офиса]
	        Language 0
)
KEY INDEX [PK_ViewPresence]
ON	[SellsCatalog]
WITH CHANGE_TRACKING AUTO
GO

CREATE FULLTEXT INDEX ON [ViewSelledCars] (
	    [Производитель]
	        Language 0,
	    [Модель]
	        Language 0,
	    [Цвет автомобиля]
	        Language 0,
		[Комплектация] 
	        Language 0,
	    [Название офиса]
	        Language 0
)
KEY INDEX [PK_ViewSelled]
ON	[SellsCatalog]
WITH CHANGE_TRACKING AUTO
GO

CREATE FULLTEXT INDEX ON [ViewSells] (
	    [Производитель]
	        Language 0,
	    [Модель]
	        Language 0,
	    [Фамилия покупателя]
	        Language 0,
		[Имя покупателя] 
	        Language 0,
	    [Отчество покупателя]
	        Language 0,
		[Офис продажи] 
	        Language 0,
	    [Фамилия продавца]
	        Language 0,
	    [Имя продавца]
	        Language 0,
		[Отчество продавца] 
	        Language 0
)
KEY INDEX [PK_ViewSells]
ON	[SellsCatalog]
WITH CHANGE_TRACKING AUTO
GO

CREATE FULLTEXT INDEX ON [ViewWorkers] (
	    [Фамилия] 
	        Language 0,
	    [Имя]
	        Language 0,
	    [Отчество]
	        Language 0,
		[Должность]
	        Language 0,
		[Название офиса]
	        Language 0,
	    [Телефон]
	        Language 0,
		[Адрес] 
	        Language 0
)
KEY INDEX [PK_ViewWorkers]
ON	[WorkersCatalog]
WITH CHANGE_TRACKING AUTO
GO

CREATE FUNCTION [dbo].[fn_GetAutomobilesDataByFullText] ( @search_string varchar(250), @search_count int )
RETURNS TABLE
AS
RETURN
(
    SELECT TOP (@search_count) [ViewAutomobilesData].* FROM
    FREETEXTTABLE([ViewAutomobilesData],([Газораспределительный механизм],[Задние тормоза],[Модель],[Передние тормоза],[Класс],[Производитель],[Расположение двигателя],[Расположение цилиндров],[Система питания],[Страна производитель],[Тип кузова],[Тип топлива]), @search_string) AS [SEARCH_RESULT]
    LEFT JOIN [ViewAutomobilesData] ON [ViewAutomobilesData].[Модель] = [SEARCH_RESULT].[KEY]
    ORDER BY [SEARCH_RESULT].[RANK] DESC   
)
GO

CREATE FUNCTION [dbo].[fn_GetClientsByFullText] ( @search_string varchar(250), @search_count int )
RETURNS TABLE
AS
RETURN
(
    SELECT TOP (@search_count) [ViewClients].* FROM
    FREETEXTTABLE([ViewClients],([Фамилия],[Имя],[Отчество],[Телефон],[Адрес]), @search_string) AS [SEARCH_RESULT]
    LEFT JOIN [ViewClients] ON [ViewClients].[Телефон] = [SEARCH_RESULT].[KEY]
    ORDER BY [SEARCH_RESULT].[RANK] DESC   
)
GO

CREATE FUNCTION [dbo].[fn_GetOfficesByFullText] ( @search_string varchar(250), @search_count int )
RETURNS TABLE
AS
RETURN
(
    SELECT TOP (@search_count) [ViewOffices].* FROM
    FREETEXTTABLE([ViewOffices],([Название офиса],[Адрес офиса],[Телефон офиса]), @search_string) AS [SEARCH_RESULT]
    LEFT JOIN [ViewOffices] ON [ViewOffices].[Название офиса] = [SEARCH_RESULT].[KEY]
    ORDER BY [SEARCH_RESULT].[RANK] DESC   
)
GO

CREATE FUNCTION [dbo].[fn_GetOrdersByFullText] ( @search_string varchar(250), @search_count int )
RETURNS TABLE
AS
RETURN
(
    SELECT TOP (@search_count) [ViewOrders].* FROM
    FREETEXTTABLE([ViewOrders],([Производитель],[Модель],[Фамилия заказчика],[Имя заказчика],[Отчество заказчика],[Состояние заказа]), @search_string) AS [SEARCH_RESULT]
    LEFT JOIN [ViewOrders] ON [ViewOrders].[ИД заказа] = [SEARCH_RESULT].[KEY]
    ORDER BY [SEARCH_RESULT].[RANK] DESC   
)
GO

CREATE FUNCTION [dbo].[fn_GetPresenceCarsByFullText] ( @search_string varchar(250), @search_count int )
RETURNS TABLE
AS
RETURN
(
    SELECT TOP (@search_count) [ViewPresenceCars].* FROM
    FREETEXTTABLE([ViewPresenceCars],([Производитель],[Модель],[Цвет автомобиля],[Комплектация],[Название офиса]), @search_string) AS [SEARCH_RESULT]
    LEFT JOIN [ViewPresenceCars] ON [ViewPresenceCars].[№ ПТС] = [SEARCH_RESULT].[KEY]
    ORDER BY [SEARCH_RESULT].[RANK] DESC   
)
GO

CREATE FUNCTION [dbo].[fn_GetSelledCarsByFullText] ( @search_string varchar(250), @search_count int )
RETURNS TABLE
AS
RETURN
(
    SELECT TOP (@search_count) [ViewSelledCars].* FROM
    FREETEXTTABLE([ViewSelledCars],([Производитель],[Модель],[Цвет автомобиля],[Комплектация],[Название офиса]), @search_string) AS [SEARCH_RESULT]
    LEFT JOIN [ViewSelledCars] ON [ViewSelledCars].[№ ПТС] = [SEARCH_RESULT].[KEY]
    ORDER BY [SEARCH_RESULT].[RANK] DESC   
)
GO

CREATE FUNCTION [dbo].[fn_GetSellsByFullText] ( @search_string varchar(250), @search_count int )
RETURNS TABLE
AS
RETURN
(
    SELECT TOP (@search_count) [ViewSells].* FROM
    FREETEXTTABLE([ViewSells],([Производитель],[Модель],[Фамилия покупателя],[Имя покупателя],[Отчество покупателя],[Офис продажи],[Фамилия продавца],[Имя продавца],[Отчество продавца]), @search_string) AS [SEARCH_RESULT]
    LEFT JOIN [ViewSells] ON [ViewSells].[№ ПТС] = [SEARCH_RESULT].[KEY]
    ORDER BY [SEARCH_RESULT].[RANK] DESC   
)
GO

CREATE FUNCTION [dbo].[fn_GetWorkersByFullText] ( @search_string varchar(250), @search_count int )
RETURNS TABLE
AS
RETURN
(
    SELECT TOP (@search_count) [ViewWorkers].* FROM
    FREETEXTTABLE([ViewWorkers],([Фамилия],[Имя],[Отчество],[Должность],[Название офиса],[Телефон],[Адрес]), @search_string) AS [SEARCH_RESULT]
    LEFT JOIN [ViewWorkers] ON [ViewWorkers].[Телефон] = [SEARCH_RESULT].[KEY]
    ORDER BY [SEARCH_RESULT].[RANK] DESC  
)
GO

INSERT INTO [dbo].[BodyTypes](BodyName) VALUES('Седан')
INSERT INTO [dbo].[BodyTypes](BodyName) VALUES('Хетчбек')
INSERT INTO [dbo].[BodyTypes](BodyName) VALUES('Универсал')
INSERT INTO [dbo].[BodyTypes](BodyName) VALUES('Внедорожник')
INSERT INTO [dbo].[BodyTypes](BodyName) VALUES('Купе')
INSERT INTO [dbo].[BodyTypes](BodyName) VALUES('Кабриолет')
INSERT INTO [dbo].[BodyTypes](BodyName) VALUES('Минивен')
INSERT INTO [dbo].[BodyTypes](BodyName) VALUES('Родстер')
INSERT INTO [dbo].[BodyTypes](BodyName) VALUES('Купе-Кабриолет')
GO

INSERT INTO [dbo].[Colors](ColorName) VALUES('Белый')
INSERT INTO [dbo].[Colors](ColorName) VALUES('Черный')
INSERT INTO [dbo].[Colors](ColorName) VALUES('Красный')
INSERT INTO [dbo].[Colors](ColorName) VALUES('Зеленый')
INSERT INTO [dbo].[Colors](ColorName) VALUES('Синий')
INSERT INTO [dbo].[Colors](ColorName) VALUES('Желтый')
INSERT INTO [dbo].[Colors](ColorName) VALUES('Оранжевый')
INSERT INTO [dbo].[Colors](ColorName) VALUES('Голубой')
INSERT INTO [dbo].[Colors](ColorName) VALUES('Пурпурный')
INSERT INTO [dbo].[Colors](ColorName) VALUES('Серебристый')
INSERT INTO [dbo].[Colors](ColorName) VALUES('Коричневый')
INSERT INTO [dbo].[Colors](ColorName) VALUES('Хаки')
INSERT INTO [dbo].[Colors](ColorName) VALUES('Розовый')
GO

INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('AC')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Acura')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Alfa Romeo')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Aston Martin')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Audi')

INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('БАЗ')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('БелАЗ')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Bentley')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('BMW')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Bugatti')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Buick')

INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Cadillac')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Caterham')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Chery')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Chevrolet')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Chrysler')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Citroen')

INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('DAC')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Daewoo')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('DAF')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Datsun')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Dodge')

INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Ferrari')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('FIAT')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Ford')

INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('ГАЗ')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Geely')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('GMC')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Great Wall')

INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Holden')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Honda')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Hyundai')

INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Infiniti')

INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Jaguar')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Jeep')

INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('КамАЗ')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Kia')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Koenigsegg')

INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Lamborghini')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Lancia')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Land Rover')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Lexus')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Lincoln')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Lotus')

INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('МАЗ')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Москвич')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('MAN')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Maserati')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Maybach')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Mazda')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('McLaren')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Mercedes-Benz')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('MINI')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Mitsubishi')

INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Nissan')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Noble')

INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Opel')

INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Pagani')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Peugeot')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Plymouth')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Pontiac')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Porsche')

INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Renault')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Rolls-Royce')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Rover')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('RUF')

INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('SAAB')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Saleen')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Scion')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('SEAT')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Skoda')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Spyker')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('SsangYong')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Subaru')

INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Toyota')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('TVR')

INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('УАЗ')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Урал')

INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('ВАЗ (LADA)')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Volkswagen')
INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('Volvo')

INSERT INTO [dbo].[Manafacturers](ManafacturerName) VALUES('ЗиЛ')
GO

INSERT INTO Workplaces(WorkplaceName) VALUES('Директор')
INSERT INTO Workplaces(WorkplaceName) VALUES('Зам. директора')
INSERT INTO Workplaces(WorkplaceName) VALUES('Бухгалтер')
INSERT INTO Workplaces(WorkplaceName) VALUES('Менеджер')
INSERT INTO Workplaces(WorkplaceName) VALUES('Продавец')
INSERT INTO Workplaces(WorkplaceName) VALUES('Консультант')
INSERT INTO Workplaces(WorkplaceName) VALUES('Охранник')
INSERT INTO Workplaces(WorkplaceName) VALUES('Уборщик')
INSERT INTO Workplaces(WorkplaceName) VALUES('Ремонтник')
INSERT INTO Workplaces(WorkplaceName) VALUES('Сантехник')
INSERT INTO Workplaces(WorkplaceName) VALUES('Электрик')
GO

INSERT INTO Classes(ClassName) VALUES('Класс A')
INSERT INTO Classes(ClassName) VALUES('Класс B')
INSERT INTO Classes(ClassName) VALUES('Класс C')
INSERT INTO Classes(ClassName) VALUES('Класс D')
INSERT INTO Classes(ClassName) VALUES('Класс E')
INSERT INTO Classes(ClassName) VALUES('Класс F')
INSERT INTO Classes(ClassName) VALUES('Класс SUV1')
INSERT INTO Classes(ClassName) VALUES('Класс SUV2')

GO