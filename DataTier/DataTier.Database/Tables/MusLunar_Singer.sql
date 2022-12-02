CREATE TABLE [dbo].[MusLunar_Singer]
(
	[ID] INT NOT NULL IDENTITY , 
    [Name] NVARCHAR(200) NULL, 
    [Avartar] NVARCHAR(MAX) NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    [Note] NVARCHAR(MAX) NULL, 
    [Created] DATETIME NULL, 
    [CreatedBy] INT NULL, 
    [Modified] DATETIME NULL, 
    [ModifiedBy] INT NULL, 
    [State] INT NULL DEFAULT 1, 
    CONSTRAINT [PK_MusLunar_Singer] PRIMARY KEY ([ID]) 
)
