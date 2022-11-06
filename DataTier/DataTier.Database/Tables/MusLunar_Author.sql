CREATE TABLE [dbo].[MusLunar_Author]
(
	[ID] INT NOT NULL IDENTITY, 
    [Name] NVARCHAR(200) NULL, 
    [NameNoSign] NVARCHAR(200) NULL, 
    [Avartar] NVARCHAR(MAX) NOT NULL, 
    [NickName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NULL, 
    [GenderID] INT NOT NULL, 
    [BirthDay] DATETIME NOT NULL, 
    [Phone] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(300) NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    [Note] NVARCHAR(MAX) NULL, 
    [Created] DATETIME NULL, 
    [CreatedBy] INT NULL, 
    [Modified] DATETIME NULL, 
    [ModifiedBy] INT NULL, 
    [State] INT NOT NULL DEFAULT 1, 
    CONSTRAINT [PK_MusLunar_Author] PRIMARY KEY ([ID]) 
)
