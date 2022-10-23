CREATE TABLE [dbo].[MusLunar_Pararameter_Type]
(
	[ID] INT NOT NULL  IDENTITY, 
    [Name] NVARCHAR(200) NOT NULL, 
    [Note] NCHAR(10) NULL, 
    [Created] DATETIME NOT NULL, 
    [CreatedBy] INT NOT NULL, 
    [Modified] DATETIME NOT NULL, 
    [ModifiedBy] INT NOT NULL, 
    [State] INT NULL DEFAULT 1, 
    CONSTRAINT [PK_MusLunar_Pararameter_Type] PRIMARY KEY ([ID]) 
)
