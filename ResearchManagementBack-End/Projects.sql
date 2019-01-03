CREATE TABLE [dbo].[Projects]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Prj_Name] NVARCHAR(500) NULL, 
    [Prj_Desc] NVARCHAR(1000) NULL, 
    [Prj_StageId] INT NULL, 
    [Prj_LevelId] INT NULL
)
