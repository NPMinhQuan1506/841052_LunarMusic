CREATE TABLE [dbo].[MusLunar_Music_Genres]
(
	[ID] INT NOT NULL IDENTITY, 
    [Name] NVARCHAR(500) NOT NULL, 
    [Note] NVARCHAR(MAX) NULL, 
    [Created] DATETIME NOT NULL, 
    [CreatedBy] INT NOT NULL, 
    [Modified] DATETIME NOT NULL, 
    [ModifiedBy] INT NOT NULL, 
    [State] INT NULL DEFAULT 1, 
    CONSTRAINT [PK_MusLunar_Music_Genres] PRIMARY KEY ([ID]) 
)
