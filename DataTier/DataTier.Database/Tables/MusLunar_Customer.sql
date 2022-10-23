CREATE TABLE [dbo].[MusLunar_Customer]
(
	[ID] INT NOT NULL IDENTITY, 
    [Name] NVARCHAR(200) NOT NULL, 
    [NameNoSign] NCHAR(10) NOT NULL, 
    [NickName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [GenderID] INT NOT NULL, 
    [BirthDay] DATETIME NOT NULL, 
    [Phone] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(300) NULL, 
    [AssistantEmail] NVARCHAR(300) NULL, 
    [Address] NVARCHAR(1000) NOT NULL, 
    [Avartar] NVARCHAR(MAX) NULL, 
    [BackgroundImage] NVARCHAR(MAX) NULL, 
    [Note] NVARCHAR(MAX) NULL, 
    [Created] DATETIME NULL, 
    [CreatedBy] INT NULL, 
    [Modified] DATETIME NULL, 
    [ModifiedBy] INT NULL, 
    [State] INT NOT NULL DEFAULT 1, 
    CONSTRAINT [PK_MusLunar_Customer] PRIMARY KEY ([ID]) 
)
