-- Ensure we are using the correct database
USE Student;
GO

-- Create the Registration Table
CREATE TABLE Registration (
    regNo INT NOT NULL,                  -- Primary Key
    firstName VARCHAR(50) NOT NULL,
    lastName VARCHAR(50) NOT NULL,
    dateOfBirth DATETIME NOT NULL,
    gender VARCHAR(50) NOT NULL,
    address VARCHAR(50) NOT NULL,
    email VARCHAR(50) NOT NULL,
    mobilePhone INT,
    homePhone INT,
    parentName VARCHAR(50) NOT NULL,
    nic VARCHAR(50) NOT NULL,
    contactNo INT,
    
    CONSTRAINT PK_Registration PRIMARY KEY (regNo)
);
GO