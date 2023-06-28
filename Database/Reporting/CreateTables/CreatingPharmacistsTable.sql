USE NuvemProjectExercise;
GO

IF EXISTS (SELECT name 
    FROM sys.tables
    WHERE name = 'Pharmacists')

    BEGIN
        DROP TABLE Pharmacists
    END

IF NOT EXISTS (SELECT name 
    FROM sys.tables
    WHERE name = 'Pharmacists')

    BEGIN
        CREATE TABLE Pharmacists (
            PharmacistID int NOT NULL PRIMARY KEY IDENTITY(1,1),
            PharmacyID int FOREIGN KEY REFERENCES Pharmacies(PharmacyID),
            PharmacistName nvarchar(MAX),
            Age int,
            PrimaryDrugSold nvarchar(MAX),
            HireDate DATETIME
        );    
    END   