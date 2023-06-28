USE NuvemProjectExercise;
GO

USE NuvemProjectExercise;
GO

IF EXISTS (SELECT name 
    FROM sys.tables
    WHERE name = 'Deliveries')

    BEGIN
        DELETE FROM dbo.Deliveries;

        -- This was ChatGPT generated
        -- INSERT Script 1
        INSERT INTO Deliveries (WarehouseId, PharmacyId, DrugName, UnitCount, UnitPrice, TotalPrice, DeliveryDate)
        VALUES (1, 11, 'MedicineA', 55, 10.50, 577.50, DATEADD(day, FLOOR(RAND() * 35), '2023/06/27'));

        -- INSERT Script 2
        INSERT INTO Deliveries (WarehouseId, PharmacyId, DrugName, UnitCount, UnitPrice, TotalPrice, DeliveryDate)
        VALUES (3, 13, 'MedicineB', 29, 8.75, 253.75, DATEADD(day, FLOOR(RAND() * 35), '2023/06/27'));

        -- INSERT Script 3
        INSERT INTO Deliveries (WarehouseId, PharmacyId, DrugName, UnitCount, UnitPrice, TotalPrice, DeliveryDate)
        VALUES (2, 11, 'MedicineC', 84, 12.20, 1024.80, DATEADD(day, FLOOR(RAND() * 35), '2023/06/27'));

        -- INSERT Script 4
        INSERT INTO Deliveries (WarehouseId, PharmacyId, DrugName, UnitCount, UnitPrice, TotalPrice, DeliveryDate)
        VALUES (1, 14, 'MedicineD', 11, 15.00, 165.00, DATEADD(day, FLOOR(RAND() * 35), '2023/06/27'));

        -- INSERT Script 5
        INSERT INTO Deliveries (WarehouseId, PharmacyId, DrugName, UnitCount, UnitPrice, TotalPrice, DeliveryDate)
        VALUES (3, 15, 'MedicineE', 92, 6.80, 625.60, DATEADD(day, FLOOR(RAND() * 35), '2023/06/27'));

        -- INSERT Script 6
        INSERT INTO Deliveries (WarehouseId, PharmacyId, DrugName, UnitCount, UnitPrice, TotalPrice, DeliveryDate)
        VALUES (2, 11, 'MedicineF', 78, 9.40, 733.20, DATEADD(day, FLOOR(RAND() * 35), '2023/06/27'));

        -- INSERT Script 7
        INSERT INTO Deliveries (WarehouseId, PharmacyId, DrugName, UnitCount, UnitPrice, TotalPrice, DeliveryDate)
        VALUES (1, 13, 'MedicineG', 41, 13.25, 542.25, DATEADD(day, FLOOR(RAND() * 35), '2023/06/27'));

        -- INSERT Script 8
        INSERT INTO Deliveries (WarehouseId, PharmacyId, DrugName, UnitCount, UnitPrice, TotalPrice, DeliveryDate)
        VALUES (3, 12, 'MedicineH', 67, 11.50, 770.50, DATEADD(day, FLOOR(RAND() * 35), '2023/06/27'));

        -- INSERT Script 9
        INSERT INTO Deliveries (WarehouseId, PharmacyId, DrugName, UnitCount, UnitPrice, TotalPrice, DeliveryDate)
        VALUES (2, 11, 'MedicineI', 15, 18.75, 281.25, DATEADD(day, FLOOR(RAND() * 35), '2023/06/27'));

        -- INSERT Script 10
        INSERT INTO Deliveries (WarehouseId, PharmacyId, DrugName, UnitCount, UnitPrice, TotalPrice, DeliveryDate)
        VALUES (1, 15, 'MedicineJ', 63, 7.90, 498.70, DATEADD(day, FLOOR(RAND() * 35), '2023/06/27'));

        -- INSERT Script 11
        INSERT INTO Deliveries (WarehouseId, PharmacyId, DrugName, UnitCount, UnitPrice, TotalPrice, DeliveryDate)
        VALUES (3, 12, 'MedicineK', 39, 14.60, 569.40, DATEADD(day, FLOOR(RAND() * 35), '2023/06/27'));

        -- INSERT Script 12
        INSERT INTO Deliveries (WarehouseId, PharmacyId, DrugName, UnitCount, UnitPrice, TotalPrice, DeliveryDate)
        VALUES (2, 14, 'MedicineL', 21, 17.25, 362.25, DATEADD(day, FLOOR(RAND() * 35), '2023/06/27'));

        -- INSERT Script 13
        INSERT INTO Deliveries (WarehouseId, PharmacyId, DrugName, UnitCount, UnitPrice, TotalPrice, DeliveryDate)
        VALUES (1, 13, 'MedicineM', 87, 9.80, 853.60, DATEADD(day, FLOOR(RAND() * 35), '2023/06/27'));

        -- INSERT Script 14
        INSERT INTO Deliveries (WarehouseId, PharmacyId, DrugName, UnitCount, UnitPrice, TotalPrice, DeliveryDate)
        VALUES (3, 12, 'MedicineN', 72, 16.90, 1216.80, DATEADD(day, FLOOR(RAND() * 35), '2023/06/27'));

        -- INSERT Script 15
        INSERT INTO Deliveries (WarehouseId, PharmacyId, DrugName, UnitCount, UnitPrice, TotalPrice, DeliveryDate)
        VALUES (2, 11, 'MedicineO', 43, 11.20, 481.60, DATEADD(day, FLOOR(RAND() * 35), '2023/06/27'));

        -- INSERT Script 16
        INSERT INTO Deliveries (WarehouseId, PharmacyId, DrugName, UnitCount, UnitPrice, TotalPrice, DeliveryDate)
        VALUES (1, 14, 'MedicineP', 26, 13.50, 351.00, DATEADD(day, FLOOR(RAND() * 35), '2023/06/27'));

        -- INSERT Script 17
        INSERT INTO Deliveries (WarehouseId, PharmacyId, DrugName, UnitCount, UnitPrice, TotalPrice, DeliveryDate)
        VALUES (3, 15, 'MedicineQ', 58, 8.60, 498.80, DATEADD(day, FLOOR(RAND() * 35), '2023/06/27'));

        -- INSERT Script 18
        INSERT INTO Deliveries (WarehouseId, PharmacyId, DrugName, UnitCount, UnitPrice, TotalPrice, DeliveryDate)
        VALUES (2, 11, 'MedicineR', 14, 19.75, 276.50, DATEADD(day, FLOOR(RAND() * 35), '2023/06/27'));

        -- INSERT Script 19
        INSERT INTO Deliveries (WarehouseId, PharmacyId, DrugName, UnitCount, UnitPrice, TotalPrice, DeliveryDate)
        VALUES (1, 15, 'MedicineS', 67, 7.40, 494.80, DATEADD(day, FLOOR(RAND() * 35), '2023/06/27'));

        -- INSERT Script 20
        INSERT INTO Deliveries (WarehouseId, PharmacyId, DrugName, UnitCount, UnitPrice, TotalPrice, DeliveryDate)
        VALUES (3, 12, 'MedicineT', 32, 14.30, 457.60, DATEADD(day, FLOOR(RAND() * 35), '2023/06/27'));

        SELECT * FROM dbo.Deliveries;
    END