USE NuvemProjectExercise;
GO

IF EXISTS (SELECT name 
    FROM sys.tables
    WHERE name = 'Warehouses')

    BEGIN
        DELETE FROM dbo.Warehouses;

        -- First Pharmacy
        INSERT INTO dbo.Warehouses
        (
            WarehouseName,
            Address
        )
        VALUES
        (
            'Meds ''n More Warehouse',
            '123 Well Road'
        );

        -- Second Pharmacy
        INSERT INTO dbo.Warehouses
        (
            WarehouseName,
            Address
        )
        VALUES
        (
            'Remedy Retreat Warehouse',
            '972 Something Street'
        );

        -- Third Pharmacy
        INSERT INTO dbo.Warehouses
        (
            WarehouseName,
            Address
        )
        VALUES
        (
            'Nature''s Cure Pharmacy Warehouse',
            '456 Washington Ave'
        );

        SELECT * FROM dbo.Warehouses;
    END