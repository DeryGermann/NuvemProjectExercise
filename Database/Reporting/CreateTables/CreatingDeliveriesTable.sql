USE NuvemProjectExercise;
GO

IF EXISTS (SELECT name 
    FROM sys.tables
    WHERE name = 'Deliveries')

    BEGIN
        DROP TABLE Deliveries
    END

IF NOT EXISTS (SELECT name 
    FROM sys.tables
    WHERE name = 'Deliveries')

    BEGIN
        CREATE TABLE Deliveries (
            DeliveryID int NOT NULL PRIMARY KEY IDENTITY(1,1),
            WarehouseID int FOREIGN KEY REFERENCES Warehouses(WarehouseID),
            PharmacyID int FOREIGN KEY REFERENCES Pharmacies(PharmacyID),
            DrugName nvarchar(MAX),
            UnitCount int,
            UnitPrice money,
            TotalPrice money,
            DeliveryDate DATETIME
        );    
    END   