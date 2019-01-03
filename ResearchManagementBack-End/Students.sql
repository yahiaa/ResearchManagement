CREATE TABLE [dbo].[Students]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Std_FirstName] NVARCHAR(50) NULL, 
    [Std_LastName] NVARCHAR(50) NULL, 
    [Std_MajorId] INT NOT NULL FOREIGN KEY REFERENCES dbo.Majors(Id), 
    [Std_Phone] NVARCHAR(20) NULL, 
    [Std_Email] NVARCHAR(40) NULL
)
