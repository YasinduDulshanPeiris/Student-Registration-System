-- Create the Database if it doesn't exist
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'Student')
BEGIN
    CREATE DATABASE Student;
END
GO

-- Switch to the Student Database
USE Student;
GO

-- Create the Logins Table
CREATE TABLE Logins (
    username VARCHAR(50) NOT NULL PRIMARY KEY,
    password VARCHAR(50) NOT NULL
);
GO

-- Insert the compulsory initial user required by your project brief
INSERT INTO Logins (username, password)
VALUES ('Admin', 'Campusone@123');
GO