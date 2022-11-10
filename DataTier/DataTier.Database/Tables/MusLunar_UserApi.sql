CREATE TABLE [dbo].[MusLunar_UserApi]
(
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](200) NOT NULL,
	[Password] [nvarchar](2000) NOT NULL,
	[EmailAddress] [nvarchar](500) NULL,
	[Role] [nvarchar](100) NULL,
	[SurName] [nvarchar](200) NULL,
	[GivenName] [nvarchar](200) NULL,
	[Created] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[Modified] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[State] [int] NULL DEFAULT 1,
    CONSTRAINT [PK_MusLunar_UserApi] PRIMARY KEY ([ID]) 
)
