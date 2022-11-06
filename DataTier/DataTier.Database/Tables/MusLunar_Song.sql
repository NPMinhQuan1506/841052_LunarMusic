CREATE TABLE [dbo].[MusLunar_Song]
(
	[ID] INT NOT NULL IDENTITY, 
    [Name] NVARCHAR(2000) NOT NULL, 
    [Source] NVARCHAR(2000) NOT NULL, 
    [PlayTimeInt] INT NOT NULL, 
    [Image] NVARCHAR(MAX) NULL, 
    [IsPro] INT NULL DEFAULT 1, 
    [UnitPrice] DECIMAL NOT NULL, 
    [GenresID] INT NOT NULL, 
    [AuthorID] INT NOT NULL, 
    [SingerID] INT NOT NULL, 
    [GroupID] INT NOT NULL, 
    [NationalID] INT NOT NULL, 
    [IsDisabled] INT NOT NULL DEFAULT 0, 
    [Lyrics] NVARCHAR(MAX) NULL, 
    [Note] NVARCHAR(MAX) NULL, 
    [Created] DATETIME NOT NULL, 
    [CreatedBy] INT NOT NULL, 
    [Modified] DATETIME NOT NULL, 
    [ModifiedBy] INT NOT NULL, 
    [State] INT NULL DEFAULT 1, 
    CONSTRAINT [PK_MusLunar_Song] PRIMARY KEY ([ID]) 
)
