CREATE TABLE [dbo].[MusLunar_CustomerPlaylist]
(
	[ID] INT NOT NULL IDENTITY , 
    [CustomerID] INT NOT NULL, 
    [SongID] INT NOT NULL, 
    [ListeningTimes] INT NOT NULL, 
    [LastListeningTime] DATETIME NOT NULL, 
    [Note] NVARCHAR(MAX) NULL, 
    [Created] DATETIME NOT NULL, 
    [CreatedBy] INT NOT NULL, 
    [Modified] DATETIME NOT NULL, 
    [ModifiedBy] INT NOT NULL, 
    [State] INT NULL DEFAULT 1, 
    CONSTRAINT [PK_MusLunar_CustomerPlaylist] PRIMARY KEY ([ID])
)
