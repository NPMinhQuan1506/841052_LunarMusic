CREATE TABLE [dbo].[MusLunar_National]
(
	[ID] INT NOT NULL IDENTITY, 
    [Name] NVARCHAR(500) NOT NULL, 
    [Note] NVARCHAR(MAX) NULL, 
    [Created] DATETIME NOT NULL, 
    [CreatedBy] INT NOT NULL, 
    [Modified] DATETIME NOT NULL, 
    [ModifiedBy] INT NOT NULL, 
    [State] INT NULL DEFAULT 1, 
    CONSTRAINT [PK_MusLunar_National] PRIMARY KEY ([ID]) 
)
