CREATE TABLE [dbo].[MusLunar_Order]
(
	[ID] INT NOT NULL IDENTITY, 
    [OrderCode] NVARCHAR(MAX) NOT NULL, 
    [CustomerID] INT NOT NULL, 
    [TotalPrice] DECIMAL NOT NULL, 
    [TotalQuantity] INT NOT NULL, 
    [Note] NVARCHAR(MAX) NULL, 
    [Created] DATETIME NOT NULL, 
    [CreatedBy] INT NOT NULL, 
    [Modified] DATETIME NOT NULL, 
    [ModifiedBy] INT NOT NULL, 
    [State] INT NULL DEFAULT 1, 
    CONSTRAINT [PK_MusLunar_Order] PRIMARY KEY ([ID]) 
)
