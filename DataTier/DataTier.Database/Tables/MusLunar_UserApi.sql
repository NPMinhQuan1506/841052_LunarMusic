CREATE TABLE [dbo].[MusLunar_UserApi]
(
	[ID] INT NOT NULL IDENTITY, 
    [Username] NVARCHAR(200) NOT NULL, 
    [Password] NVARCHAR(2000) NOT NULL, 
    [EmployeeID] INT NOT NULL, 
    [LastSignin] DATETIME NOT NULL, 
    [Note] NVARCHAR(MAX) NULL, 
    [Created] DATETIME NOT NULL, 
    [CreatedBy] INT NOT NULL, 
    [Modified] DATETIME NOT NULL, 
    [ModifiedBy] INT NOT NULL, 
    [State] INT NULL DEFAULT 1, 
    CONSTRAINT [PK_MusLunar_UserApi] PRIMARY KEY ([ID]) 
)
