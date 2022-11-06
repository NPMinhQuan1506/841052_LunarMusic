CREATE TABLE [dbo].[MusLunar_Singer]
(
	[ID] INT NOT NULL IDENTITY , 
    [Name] NVARCHAR(200) NOT NULL, 
    [NameNoSign] NVARCHAR(200) NULL, 
    [NickName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [GenderID] INT NOT NULL, 
    [BirthDay] DATETIME NOT NULL, 
    [Avartar] NVARCHAR(MAX) NULL, 
    [Phone] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(300) NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    [Note] NVARCHAR(MAX) NULL, 
    [Created] DATETIME NOT NULL, 
    [CreatedBy] INT NOT NULL, 
    [Modified] DATETIME NOT NULL, 
    [ModifiedBy] INT NOT NULL, 
    [State] INT NULL DEFAULT 1, 
    CONSTRAINT [PK_MusLunar_Singer] PRIMARY KEY ([ID]) 
)
