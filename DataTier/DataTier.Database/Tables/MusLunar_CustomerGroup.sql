CREATE TABLE [dbo].[MusLunar_CustomerGroup]
(
	[ID] INT NOT NULL IDENTITY, 
    [Name] NVARCHAR(200) NOT NULL, 
    [Image] NVARCHAR(MAX) NULL, 
    [Note] NVARCHAR(MAX) NULL, 
    [Created] DATETIME NOT NULL, 
    [CreatedBy] INT NOT NULL, 
    [Modified] DATETIME NOT NULL, 
    [ModifiedBy] INT NOT NULL, 
    [State] INT NULL DEFAULT 1, 
    CONSTRAINT [PK_MusLunar_CustomerGroup] PRIMARY KEY ([ID]) 
)
