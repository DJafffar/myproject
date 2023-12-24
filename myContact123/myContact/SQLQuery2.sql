CREATE TABLE [dbo].[ContactTbl]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ContactName] VARCHAR(50) NULL, 
    [ContactSurname] VARCHAR(50) NULL, 
    [ContactPhoneNumber] VARCHAR(50) NULL, 
    [ContactEmail] VARCHAR(50) NULL
)