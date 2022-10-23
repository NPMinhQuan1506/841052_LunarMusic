CREATE TABLE [dbo].[MusLunar_OrderDetail]
(
	[ID] INT NOT NULL IDENTITY, 
    [OrderID] INT NOT NULL, 
    [SongID] INT NOT NULL, 
    [Price] DECIMAL NOT NULL, 
    [DiscountPrice] DECIMAL NOT NULL, 
    [DiscountedPrice] DECIMAL NOT NULL, 
    [PaymentMethodID] INT NOT NULL, 
    [Created] DATETIME NOT NULL, 
    [CreatedBy] INT NOT NULL, 
    [Modified] DATE NOT NULL, 
    [ModifiedBy] INT NOT NULL, 
    [State] INT NULL DEFAULT 1, 
    CONSTRAINT [PK_MusLunar_OrderDetail] PRIMARY KEY ([ID]) 
)
