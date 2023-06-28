USE NuvemProjectExercise;
GO

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
            WarehouseName nvarchar(MAX),
            Address nvarchar(MAX)
        );    
    END   