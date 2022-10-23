CREATE TABLE [dbo].[MusLunar_CustomerUser]
(
	[ID] INT NOT NULL IDENTITY, 
    [Username] NVARCHAR(200) NOT NULL, 
    [Password] NVARCHAR(2000) NOT NULL, 
    [CustomerID] INT NOT NULL, 
    [LastSignin] DATETIME NOT NULL, 
    [IsBlock] INT NULL DEFAULT 0, 
    [BlockTime] DATETIME NULL, 
    [Note] NVARCHAR(MAX) NULL, 
    [Created] DATETIME NOT NULL, 
    [CreatedBy] INT NOT NULL, 
    [Modified] DATETIME NOT NULL, 
    [ModifiedBy] INT NOT NULL, 
    [State] INT NULL DEFAULT 1, 
    CONSTRAINT [PK_MusLunar_CustomerUser] PRIMARY KEY ([ID]) 
)
