CREATE TABLE [dbo].[MusLunar_User]
(
	[ID] INT NOT NULL IDENTITY, 
    [Name] NVARCHAR(200) NULL, 
    [Email] NVARCHAR(200) NULL, 
    [Username] NVARCHAR(200) NULL, 
    [Password] NVARCHAR(2000) NULL, 
    [Role] INT NULL, 
    [Created] DATETIME NULL, 
    [CreatedBy] INT NULL, 
    [Modified] DATETIME NULL, 
    [ModifiedBy] INT NULL, 
    [State] INT NULL DEFAULT 1, 
    CONSTRAINT [PK_MusLunar_User] PRIMARY KEY ([ID]) 
)
