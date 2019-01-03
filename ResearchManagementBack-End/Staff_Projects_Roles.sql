CREATE TABLE [dbo].[Staff_Projects_Roles]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [StaffId] INT NULL, 
    [ProjectId] INT NULL, 
    [RoleId] INT NULL, 
    CONSTRAINT [StaffId] FOREIGN KEY ([StaffId]) REFERENCES StaffMembersContacts(Id), 
    CONSTRAINT [ProjectId] FOREIGN KEY ([ProjectId]) REFERENCES Projects(id), 
    CONSTRAINT [RoleID] FOREIGN KEY ([RoleId]) REFERENCES StaffRoles(id)
)
