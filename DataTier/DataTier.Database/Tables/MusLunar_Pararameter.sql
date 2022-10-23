CREATE TABLE [dbo].[MusLunar_Pararameter]
(
	[ID] INT NOT NULL IDENTITY, 
    [Name] NVARCHAR(200) NOT NULL, 
    [Value] NVARCHAR(200) NOT NULL, 
    [ParaTypeID] INT NOT NULL, 
    [Note] NVARCHAR(MAX) NULL, 
    [Created] DATETIME NOT NULL, 
    [CreatedBy] INT NOT NULL, 
    [Modified] DATETIME NOT NULL, 
    [ModifiedBy] INT NOT NULL, 
    [State] INT NULL DEFAULT 1, 
    CONSTRAINT [PK_MusLunar_Pararameter] PRIMARY KEY ([ID]) 
)
