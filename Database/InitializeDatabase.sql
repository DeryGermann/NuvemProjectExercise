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

-- Command used to create the database models using database first method
-- dotnet ef dbcontext scaffold "Server=localhost; Database=NuvemProjectExercise; User Id=sa; Password=340BasicTestProject; Trusted_Connection=false; TrustServerCertificate=true;" Microsoft.EntityFrameworkCore.SqlServer -o Models   