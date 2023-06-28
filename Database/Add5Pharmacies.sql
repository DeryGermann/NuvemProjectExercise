USE NuvemProjectExercise;
GO

IF EXISTS (SELECT name 
    FROM sys.tables
    WHERE name = 'Pharmacies')

    BEGIN
        DELETE FROM dbo.Pharmacies;

        -- First Pharmacy
        INSERT INTO dbo.Pharmacies
        (
            PharmacyName,
            Address,
            City,
            State,
            Zip,
            FilledPrescriptions,
            CreatedDate,
            UpdatedDate
        )
        VALUES
        (
            'Meds ''n More',
            '555 Wellness Road',
            'Riverside',
            'CA',
            '92504',
            MONTH(GETDATE()),
            GETDATE(),
            null
        );

        -- Second Pharmacy
        INSERT INTO dbo.Pharmacies
        (
            PharmacyName,
            Address,
            City,
            State,
            Zip,
            FilledPrescriptions,
            CreatedDate,
            UpdatedDate
        )
        VALUES
        (
            'Remedy Retreat',
            '999 Care Street',
            'Dallas',
            'TX',
            '75254',
            MONTH(GETDATE()),
            GETDATE(),
            null
        );

        -- Third Pharmacy
        INSERT INTO dbo.Pharmacies
        (
            PharmacyName,
            Address,
            City,
            State,
            Zip,
            FilledPrescriptions,
            CreatedDate,
            UpdatedDate
        )
        VALUES
        (
            'Nature''s Cure Pharmacy',
            '456 Forest Ave',
            'Memphis',
            'TN',
            '38088',
            MONTH(GETDATE()),
            GETDATE(),
            null
        );

        -- Fourth Pharmacy
        INSERT INTO dbo.Pharmacies
        (
            PharmacyName,
            Address,
            City,
            State,
            Zip,
            FilledPrescriptions,
            CreatedDate,
            UpdatedDate
        )
        VALUES
        (
            'Prime Care Pharmacy',
            '789 Care Ave',
            'New York',
            'NY',
            '10005',
            MONTH(GETDATE()),
            GETDATE(),
            null
        );

        -- Fifth Pharmacy
        INSERT INTO dbo.Pharmacies
        (
            PharmacyName,
            Address,
            City,
            State,
            Zip,
            FilledPrescriptions,
            CreatedDate,
            UpdatedDate
        )
        VALUES
        (
            'Joyful Remedies',
            '456 Health St',
            'Seattle',
            'WA',
            '98101',
            MONTH(GETDATE()),
            GETDATE(),
            null
        );

        SELECT * FROM dbo.Pharmacies;
    END