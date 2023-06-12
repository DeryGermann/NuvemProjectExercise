USE master;
GO

IF EXISTS (
      SELECT name
      FROM sys.databases
      WHERE name = N'NuvemProjectExercise'
      )
    BEGIN
        ALTER DATABASE NuvemProjectExercise SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
        DROP DATABASE NuvemProjectExercise;
    END
GO

IF NOT EXISTS (
      SELECT name
      FROM sys.databases
      WHERE name = N'NuvemProjectExercise'
      )
   CREATE DATABASE [NuvemProjectExercise];
GO

IF SERVERPROPERTY('ProductVersion') > '12'
   ALTER DATABASE [NuvemProjectExercise] SET QUERY_STORE = ON;
GO