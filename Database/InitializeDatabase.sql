USE master;
GO

-- Check if DB exists
IF EXISTS (
    SELECT name
    FROM sys.databases
    WHERE name = 'NuvemProjectExercise')
    
    BEGIN
        -- Set database to single_user to remove any lingering connection
        ALTER DATABASE NuvemProjectExercise SET SINGLE_USER;
        DROP DATABASE NuvemProjectExercise;
    END
GO

IF NOT EXISTS (
    SELECT name
    FROM sys.databases
    WHERE name = 'NuvemProjectExercise')

    BEGIN
        CREATE DATABASE [NuvemProjectExercise];
    END