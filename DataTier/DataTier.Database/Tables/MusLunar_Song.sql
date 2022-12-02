CREATE TABLE [dbo].[MusLunar_Song]
(
	[ID] INT NOT NULL IDENTITY, 
    [Name] NVARCHAR(2000) NULL, 
    [Source] NVARCHAR(2000) NULL, 
    [PlayTimeInt] INT NULL, 
    [Image] NVARCHAR(MAX) NULL, 
    [GenresID] INT NULL, 
    [SingerID] INT NULL, 
    [GroupID] INT NULL, 
    [Created] DATETIME NULL, 
    [CreatedBy] INT NULL, 
    [Modified] DATETIME NULL, 
    [ModifiedBy] INT NULL, 
    [State] INT NULL DEFAULT 1, 
    CONSTRAINT [PK_MusLunar_Song] PRIMARY KEY ([ID]) 
)
