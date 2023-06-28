USE NuvemProjectExercise;
GO

-- Needs to be related to the Deliveries table
IF EXISTS (SELECT name 
    FROM sys.tables
    WHERE name = 'Warehouses')

    BEGIN
        DROP TABLE Warehouses
    END

IF NOT EXISTS (SELECT name 
    FROM sys.tables
    WHERE name = 'Warehouses')

    BEGIN
        CREATE TABLE Warehouses (
            WarehouseID int NOT NULL PRIMARY KEY IDENTITY(1,1),
            WarehouseName nvarchar(50),
            Address nvarchar(500)
        );    
    END   