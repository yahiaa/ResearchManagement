CREATE TABLE [dbo].[Student_Projects]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [StudentId] INT NULL, 
    [ProjectId] INT NULL, 
    CONSTRAINT [ProjectStudentId] FOREIGN KEY ([StudentId]) REFERENCES Students(id), 
    CONSTRAINT [StudentProjectId] FOREIGN KEY ([ProjectId]) REFERENCES Projects(Id) 
)
