USE [LunarMusic]
GO
SET IDENTITY_INSERT [dbo].[MusLunar_Music_Genres] ON 

INSERT [dbo].[MusLunar_Music_Genres] ([ID], [Name], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (1, N'Pop ', NULL, CAST(N'2022-11-06T00:00:00.000' AS DateTime), 1, CAST(N'2022-11-06T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[MusLunar_Music_Genres] ([ID], [Name], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (2, N'Country ', N'đồng quê', CAST(N'2022-11-06T00:00:00.000' AS DateTime), 1, CAST(N'2022-11-06T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[MusLunar_Music_Genres] ([ID], [Name], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (3, N'Rock', N'Rock’N’ Roll', CAST(N'2022-11-06T00:00:00.000' AS DateTime), 1, CAST(N'2022-11-06T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[MusLunar_Music_Genres] ([ID], [Name], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (4, N'R&B', N'Rhythm & Blues', CAST(N'2022-11-06T00:00:00.000' AS DateTime), 1, CAST(N'2022-11-06T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[MusLunar_Music_Genres] ([ID], [Name], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (5, N'Jazz', NULL, CAST(N'2022-11-06T00:00:00.000' AS DateTime), 1, CAST(N'2022-11-06T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[MusLunar_Music_Genres] ([ID], [Name], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (6, N'Blues', NULL, CAST(N'2022-11-06T00:00:00.000' AS DateTime), 1, CAST(N'2022-11-06T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[MusLunar_Music_Genres] ([ID], [Name], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (7, N'Acoustic', NULL, CAST(N'2022-11-06T00:00:00.000' AS DateTime), 1, CAST(N'2022-11-06T00:00:00.000' AS DateTime), 1, 1)
SET IDENTITY_INSERT [dbo].[MusLunar_Music_Genres] OFF
GO
SET IDENTITY_INSERT [dbo].[MusLunar_Author] ON 

INSERT [dbo].[MusLunar_Author] ([ID], [Name], [NameNoSign], [Avartar], [NickName], [LastName], [GenderID], [BirthDay], [Phone], [Email], [Description], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (1, N'Haydn Hubers', N'Haydn Hubers', N'', N'Hayd', N'Hubers', 1, CAST(N'2022-09-09T00:00:00.000' AS DateTime), N'', N'', NULL, N'', CAST(N'2022-09-09T00:00:00.000' AS DateTime), 1, CAST(N'2022-09-09T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[MusLunar_Author] ([ID], [Name], [NameNoSign], [Avartar], [NickName], [LastName], [GenderID], [BirthDay], [Phone], [Email], [Description], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (2, N'test', N'test', N'', N'test', N'test', 1, CAST(N'2022-09-09T00:00:00.000' AS DateTime), N'test', N'test', NULL, N'test', CAST(N'2022-09-09T00:00:00.000' AS DateTime), 1, CAST(N'2022-09-09T00:00:00.000' AS DateTime), 1, 1)
SET IDENTITY_INSERT [dbo].[MusLunar_Author] OFF
GO
SET IDENTITY_INSERT [dbo].[MusLunar_Parameter_Type] ON 

INSERT [dbo].[MusLunar_Parameter_Type] ([ID], [Name], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (1, N'Gender', NULL, CAST(N'2022-10-23T00:00:00.000' AS DateTime), 1, CAST(N'2022-10-23T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[MusLunar_Parameter_Type] ([ID], [Name], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (2, N'PaymentMethod', NULL, CAST(N'2022-10-23T00:00:00.000' AS DateTime), 1, CAST(N'2022-10-23T00:00:00.000' AS DateTime), 1, 1)
SET IDENTITY_INSERT [dbo].[MusLunar_Parameter_Type] OFF
GO
SET IDENTITY_INSERT [dbo].[MusLunar_Parameter] ON 

INSERT [dbo].[MusLunar_Parameter] ([ID], [Name], [Value], [ParaTypeID], [Description], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (1, N'Nam', N'Nam', 1, NULL, NULL, CAST(N'2022-10-23T00:00:00.000' AS DateTime), 1, CAST(N'2022-10-23T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[MusLunar_Parameter] ([ID], [Name], [Value], [ParaTypeID], [Description], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (2, N'Nữ', N'Nữ', 1, NULL, NULL, CAST(N'2022-10-23T00:00:00.000' AS DateTime), 1, CAST(N'2022-10-23T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[MusLunar_Parameter] ([ID], [Name], [Value], [ParaTypeID], [Description], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (3, N'Khác', N'Khác', 1, NULL, NULL, CAST(N'2022-10-23T00:00:00.000' AS DateTime), 1, CAST(N'2022-10-23T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[MusLunar_Parameter] ([ID], [Name], [Value], [ParaTypeID], [Description], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (4, N'Banking', N'BIDV', 2, NULL, NULL, CAST(N'2022-10-23T00:00:00.000' AS DateTime), 1, CAST(N'2022-10-23T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[MusLunar_Parameter] ([ID], [Name], [Value], [ParaTypeID], [Description], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (5, N'Banking', N'TPBank', 2, NULL, NULL, CAST(N'2022-10-23T00:00:00.000' AS DateTime), 1, CAST(N'2022-10-23T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[MusLunar_Parameter] ([ID], [Name], [Value], [ParaTypeID], [Description], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (6, N'Momo', N'Momo', 2, NULL, NULL, CAST(N'2022-10-23T00:00:00.000' AS DateTime), 1, CAST(N'2022-10-23T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[MusLunar_Parameter] ([ID], [Name], [Value], [ParaTypeID], [Description], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (7, N'Crypto', N'Bitcoin', 2, NULL, NULL, CAST(N'2022-10-23T00:00:00.000' AS DateTime), 1, CAST(N'2022-10-23T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[MusLunar_Parameter] ([ID], [Name], [Value], [ParaTypeID], [Description], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (8, N'Crypto', N'Ethereum ETH', 2, NULL, NULL, CAST(N'2022-10-23T00:00:00.000' AS DateTime), 1, CAST(N'2022-10-23T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[MusLunar_Parameter] ([ID], [Name], [Value], [ParaTypeID], [Description], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (9, N'Tiền mặt', N'VND', 2, NULL, NULL, CAST(N'2022-10-23T00:00:00.000' AS DateTime), 1, CAST(N'2022-10-23T00:00:00.000' AS DateTime), 1, 0)
INSERT [dbo].[MusLunar_Parameter] ([ID], [Name], [Value], [ParaTypeID], [Description], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (10, N'Tiền mặt', N'Ngoại tệ', 2, NULL, NULL, CAST(N'2022-10-23T00:00:00.000' AS DateTime), 1, CAST(N'2022-10-23T00:00:00.000' AS DateTime), 1, 0)
INSERT [dbo].[MusLunar_Parameter] ([ID], [Name], [Value], [ParaTypeID], [Description], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (11, N'Crypto', N'Bitcoin', 2, NULL, NULL, CAST(N'2022-10-23T00:00:00.000' AS DateTime), 1, CAST(N'2022-10-23T00:00:00.000' AS DateTime), 1, 0)
INSERT [dbo].[MusLunar_Parameter] ([ID], [Name], [Value], [ParaTypeID], [Description], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (13, N'Crypto', N'Ethereum ETH', 2, NULL, NULL, CAST(N'2022-10-23T00:00:00.000' AS DateTime), 1, CAST(N'2022-10-23T00:00:00.000' AS DateTime), 1, 0)
SET IDENTITY_INSERT [dbo].[MusLunar_Parameter] OFF
GO
SET IDENTITY_INSERT [dbo].[MusLunar_Singer] ON 

INSERT [dbo].[MusLunar_Singer] ([ID], [Name], [NameNoSign], [NickName], [LastName], [GenderID], [BirthDay], [Avartar], [Phone], [Email], [Description], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (1, N'Haydn Hubers', N'Haydn Hubers', N'', N'Hayd', 1, CAST(N'2021-01-01T00:00:00.000' AS DateTime), N'2022-09-09 00:00:00.000', N'', N'', NULL, N'', CAST(N'2022-09-09T00:00:00.000' AS DateTime), 1, CAST(N'2022-09-09T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[MusLunar_Singer] ([ID], [Name], [NameNoSign], [NickName], [LastName], [GenderID], [BirthDay], [Avartar], [Phone], [Email], [Description], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (2, N'Nguyễn Thị Lệ Mai', N'Nguyen Thi Le Mai', N'Khánh Ly', N'Nguyễn', 1, CAST(N'1945-03-06T00:00:00.000' AS DateTime), NULL, NULL, NULL, N'She performed many songs written by Vietnamese composer Trịnh Công Sơn and rose to fame in the 1960s. She married South Vietnam journalist Nguyễn Hoàng Đoan in 1975.', NULL, CAST(N'2022-09-09T00:00:00.000' AS DateTime), 1, CAST(N'2022-09-09T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[MusLunar_Singer] ([ID], [Name], [NameNoSign], [NickName], [LastName], [GenderID], [BirthDay], [Avartar], [Phone], [Email], [Description], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (3, N'Justin Drew Bieber', N'Justin Drew Bieber', NULL, N'Justion', 1, CAST(N'1994-03-01T00:00:00.000' AS DateTime), NULL, NULL, NULL, NULL, NULL, CAST(N'2022-09-09T00:00:00.000' AS DateTime), 1, CAST(N'2022-09-09T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[MusLunar_Singer] ([ID], [Name], [NameNoSign], [NickName], [LastName], [GenderID], [BirthDay], [Avartar], [Phone], [Email], [Description], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (4, N'Selena Marie Gomez', N'Selena Marie Gomez', NULL, N'Selena Gomez', 1, CAST(N'1992-07-22T00:00:00.000' AS DateTime), NULL, NULL, NULL, NULL, NULL, CAST(N'2022-09-09T00:00:00.000' AS DateTime), 1, CAST(N'2022-09-09T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[MusLunar_Singer] ([ID], [Name], [NameNoSign], [NickName], [LastName], [GenderID], [BirthDay], [Avartar], [Phone], [Email], [Description], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (5, N'Nguyễn Thị Lệ Mai', N'Nguyen Thi Le Mai', N'Khánh Ly', N'Nguyễn', 1, CAST(N'1945-03-06T00:00:00.000' AS DateTime), NULL, NULL, NULL, N'She performed many songs written by Vietnamese composer Trịnh Công Sơn and rose to fame in the 1960s. She married South Vietnam journalist Nguyễn Hoàng Đoan in 1975.', NULL, CAST(N'2022-09-09T00:00:00.000' AS DateTime), 1, CAST(N'2022-09-09T00:00:00.000' AS DateTime), 1, 1)
SET IDENTITY_INSERT [dbo].[MusLunar_Singer] OFF
GO
SET IDENTITY_INSERT [dbo].[MusLunar_SongGroup] ON 

INSERT [dbo].[MusLunar_SongGroup] ([ID], [Name], [Image], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (1, N'Nhạc vàng', NULL, NULL, CAST(N'2023-11-06T00:00:00.000' AS DateTime), 1, CAST(N'2023-11-06T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[MusLunar_SongGroup] ([ID], [Name], [Image], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (2, N'Nhạc trẻ', NULL, NULL, CAST(N'2023-11-06T00:00:00.000' AS DateTime), 1, CAST(N'2023-11-06T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[MusLunar_SongGroup] ([ID], [Name], [Image], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (3, N'US-UK', NULL, NULL, CAST(N'2023-11-06T00:00:00.000' AS DateTime), 1, CAST(N'2023-11-06T00:00:00.000' AS DateTime), 1, 1)
SET IDENTITY_INSERT [dbo].[MusLunar_SongGroup] OFF
GO
SET IDENTITY_INSERT [dbo].[MusLunar_Song] ON 

INSERT [dbo].[MusLunar_Song] ([ID], [Name], [Source], [PlayTimeInt], [Image], [IsPro], [UnitPrice], [GenresID], [AuthorID], [SingerID], [GroupID], [NationalID], [IsDisabled], [Lyrics], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (1, N'Changes', N'1', 187, N'1', 1, CAST(150000 AS Decimal(18, 0)), 1, 1, 1, 1, 1, 0, N'I'' changes''', N'1', CAST(N'2023-11-06T00:00:00.000' AS DateTime), 1, CAST(N'2023-11-06T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[MusLunar_Song] ([ID], [Name], [Source], [PlayTimeInt], [Image], [IsPro], [UnitPrice], [GenresID], [AuthorID], [SingerID], [GroupID], [NationalID], [IsDisabled], [Lyrics], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (2, N'Changes', N'1', 187, N'1', 1, CAST(150000 AS Decimal(18, 0)), 2, 2, 2, 2, 2, 0, N'I'' changes''', N'1', CAST(N'2023-11-06T00:00:00.000' AS DateTime), 1, CAST(N'2023-11-06T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[MusLunar_Song] ([ID], [Name], [Source], [PlayTimeInt], [Image], [IsPro], [UnitPrice], [GenresID], [AuthorID], [SingerID], [GroupID], [NationalID], [IsDisabled], [Lyrics], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (3, N'Changes', N'1', 187, N'1', 0, CAST(0 AS Decimal(18, 0)), 3, 1, 3, 3, 2, 0, N'I'' changes''', N'1', CAST(N'2023-11-06T00:00:00.000' AS DateTime), 1, CAST(N'2023-11-06T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[MusLunar_Song] ([ID], [Name], [Source], [PlayTimeInt], [Image], [IsPro], [UnitPrice], [GenresID], [AuthorID], [SingerID], [GroupID], [NationalID], [IsDisabled], [Lyrics], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (4, N'Changes', N'1', 187, N'1', 1, CAST(150000 AS Decimal(18, 0)), 4, 1, 4, 1, 2, 0, N'I'' changes''', N'1', CAST(N'2023-11-06T00:00:00.000' AS DateTime), 1, CAST(N'2023-11-06T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[MusLunar_Song] ([ID], [Name], [Source], [PlayTimeInt], [Image], [IsPro], [UnitPrice], [GenresID], [AuthorID], [SingerID], [GroupID], [NationalID], [IsDisabled], [Lyrics], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (5, N'Changes', N'1', 187, N'1', 0, CAST(0 AS Decimal(18, 0)), 5, 1, 5, 2, 1, 0, N'I'' changes''', N'1', CAST(N'2023-11-06T00:00:00.000' AS DateTime), 1, CAST(N'2023-11-06T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[MusLunar_Song] ([ID], [Name], [Source], [PlayTimeInt], [Image], [IsPro], [UnitPrice], [GenresID], [AuthorID], [SingerID], [GroupID], [NationalID], [IsDisabled], [Lyrics], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (6, N'Changes', N'1', 187, N'1', 1, CAST(150000 AS Decimal(18, 0)), 6, 1, 1, 3, 1, 0, N'I'' changes''', N'1', CAST(N'2023-11-06T00:00:00.000' AS DateTime), 1, CAST(N'2023-11-06T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[MusLunar_Song] ([ID], [Name], [Source], [PlayTimeInt], [Image], [IsPro], [UnitPrice], [GenresID], [AuthorID], [SingerID], [GroupID], [NationalID], [IsDisabled], [Lyrics], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (7, N'Changes', N'1', 187, N'1', 0, CAST(0 AS Decimal(18, 0)), 7, 1, 1, 1, 1, 0, N'I''ve been going through the motions
Learning how to pretend
That everything is perfect

And I''ve been sinking in an ocean
Drowning but I''m silent
Yet everyone thinks I''m afloat

I''m running through mazes, mazes
Maybe it''s just a phase but regardless
I''m flipping the pages, pages

I''m going through changes
But I swear I''m the same
Could you show me some patience
Along the way?

I''m going through changes
But I swear I''m the same
Could you show me some mercy
If I start to stray?

I''ve been chasing after feelings
Most of which are fleeting
I still feel empty

And I''ve been trying hard to fit in
But how come I''m so different
From everyone I see?

I''m running through mazes, mazes
Maybe it''s just a phase but regardless
I''m flipping the pages, pages

I''m going through changes
But I swear I''m the same
Could you show me some patience
Along the way?

I''m going through changes
But I swear I am the same
Could you show me some mercy
If I start to stray?

Trying to fight the seasons
Trying to find my meaning
Maybe there''s a reason
Why I''m going through these changes', N'1', CAST(N'2023-11-06T00:00:00.000' AS DateTime), 1, CAST(N'2023-11-06T00:00:00.000' AS DateTime), 1, 1)
SET IDENTITY_INSERT [dbo].[MusLunar_Song] OFF
GO
SET IDENTITY_INSERT [dbo].[MusLunar_National] ON 

INSERT [dbo].[MusLunar_National] ([ID], [Name], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (1, N'American', N'1', CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[MusLunar_National] ([ID], [Name], [Note], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (2, N'Vietnam', NULL, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1)
SET IDENTITY_INSERT [dbo].[MusLunar_National] OFF
GO


SET IDENTITY_INSERT [dbo].[MusLunar_Customer] ON 

INSERT [dbo].[MusLunar_Customer]([ID],[Name],[NameNoSign],[NickName],[LastName],[GenderID],[BirthDay],[Phone],[Email],[AssistantEmail],[Address],[Avartar],[BackgroundImage],[Note],[Created],[CreatedBy],[Modified],[ModifiedBy],[State]) VALUES (1,N'Nguyễn Văn A',N'VanA',N'Nguyễn Văn',N'A',1,CAST(N'1990-11-06T00:00:00.000' AS DateTime),N'0367422267',N'vana@gmail.com', null,N'59B Hai Bà Trưng, Phường Võ Thị Sáu, Quận 3, Thành phố Hồ Chí Minh' ,null,null,null,CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1)

INSERT into [dbo].[MusLunar_Customer]([ID],[Name],[NameNoSign],[NickName],[LastName],[GenderID],[BirthDay],[Phone],[Email],[AssistantEmail],[Address],[Avartar],[BackgroundImage],[Note],[Created],[CreatedBy],[Modified],[ModifiedBy],[State]) VALUES (2,N'Nguyễn Thị Huỳnh',N'ThiHuynh',N'Nguyễn Thị',N'huỳnh',0,CAST(N'1992-12-09T00:00:00.000' AS DateTime),N'0367432267',N'thihuynh@gmail.com', null,N'145 Truong Định, Phường 1, Quận 3, Thành phố Hồ Chí Minh' ,null,null,null,CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1)

INSERT into [dbo].[MusLunar_Customer]([ID],[Name],[NameNoSign],[NickName],[LastName],[GenderID],[BirthDay],[Phone],[Email],[AssistantEmail],[Address],[Avartar],[BackgroundImage],[Note],[Created],[CreatedBy],[Modified],[ModifiedBy],[State]) VALUES (3,N'Trần Thắng Huy',N'ThangHuy',N'Trần Thắng',N'Huy',1,CAST(N'1985-12-07T00:00:00.000' AS DateTime),N'0787422267',N'thanghuy@gmail.com', null,N'159 Paster, Phường 3, Quận 1, Thành phố Hồ Chí Minh' ,null,null,null,CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1)

INSERT into [dbo].[MusLunar_Customer]([ID],[Name],[NameNoSign],[NickName],[LastName],[GenderID],[BirthDay],[Phone],[Email],[AssistantEmail],[Address],[Avartar],[BackgroundImage],[Note],[Created],[CreatedBy],[Modified],[ModifiedBy],[State]) VALUES (4,N'Hoàng Văn Thắng',N'VanThang',N'Hoàng Văn',N'Thắng',1,CAST(N'1985-11-16T00:00:00.000' AS DateTime),N'0367424067',N'vanthang@gmail.com', null,N'Đoàn Văn Bơ, Phường 10, Quận 4, Thành phố Hồ Chí Minh' ,null,null,null,CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1)

INSERT into [dbo].[MusLunar_Customer]([ID],[Name],[NameNoSign],[NickName],[LastName],[GenderID],[BirthDay],[Phone],[Email],[AssistantEmail],[Address],[Avartar],[BackgroundImage],[Note],[Created],[CreatedBy],[Modified],[ModifiedBy],[State]) VALUES (5,N'Huỳnh Thị Nở',N'ThiNo',N'Huỳnh Thị',N'Nở',0,CAST(N'1988-12-11T00:00:00.000' AS DateTime),N'036927227',N'thino@gmail.com', null,N'135 Nguyễn Văn Cừ, Phường 1, Quận 5, Thành phố Hồ Chí Minh' ,null,null,null,CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1)

SET IDENTITY_INSERT [dbo].[MusLunar_Customer] OFF
GO

SET IDENTITY_INSERT [dbo].[MusLunar_CustomerGroup] ON 

INSERT INTO [dbo].[MusLunar_CustomerGroup] ([ID],[Name],[Image],[Note],[Created],[CreatedBy],[Modified],[ModifiedBy],[State])VALUES(1,'Người dùng',null,1 ,CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1)
INSERT INTO [dbo].[MusLunar_CustomerGroup] ([ID],[Name],[Image],[Note],[Created],[CreatedBy],[Modified],[ModifiedBy],[State])VALUES(2,'Khách Hàng mua gói sinh viên',null,1 ,CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1)
INSERT INTO [dbo].[MusLunar_CustomerGroup] ([ID],[Name],[Image],[Note],[Created],[CreatedBy],[Modified],[ModifiedBy],[State])VALUES(3,'Khách Hàng mua gói vip',null,1 ,CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1)

SET IDENTITY_INSERT [dbo].[MusLunar_CustomerGroup] OFF
GO

SET IDENTITY_INSERT [dbo].[MusLunar_CustomerPlaylist] ON 

INSERT INTO [dbo].[MusLunar_CustomerPlaylist]
([ID],[CustomerID],[SongID],[ListeningTimes],[LastListeningTime],[Note],[Created],[CreatedBy],[Modified],[ModifiedBy],[State]) VALUES (1,1,3,2,4,null,CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1
)

INSERT INTO [dbo].[MusLunar_CustomerPlaylist]
([ID],[CustomerID],[SongID],[ListeningTimes],[LastListeningTime],[Note],[Created],[CreatedBy],[Modified],[ModifiedBy],[State]) VALUES (2,2,4,3,2,null,CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1
)

INSERT INTO [dbo].[MusLunar_CustomerPlaylist]
([ID],[CustomerID],[SongID],[ListeningTimes],[LastListeningTime],[Note],[Created],[CreatedBy],[Modified],[ModifiedBy],[State]) VALUES (3,2,2,2,4,null,CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1
)

INSERT INTO [dbo].[MusLunar_CustomerPlaylist]
([ID],[CustomerID],[SongID],[ListeningTimes],[LastListeningTime],[Note],[Created],[CreatedBy],[Modified],[ModifiedBy],[State]) VALUES (4,3,1,2,1,null,CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1
)

SET IDENTITY_INSERT [dbo].[MusLunar_CustomerPlaylist] OFF
GO

SET IDENTITY_INSERT [dbo].[MusLunar_CustomerUser] ON

INSERT [dbo].[MusLunar_CustomerUser]([ID] ,[Username],[Password],[CustomerID],[LastSignin],[IsBlock],[BlockTime],[Note],[Created],[CreatedBy],[Modified],[ModifiedBy],[State])
VALUES (1,'nguyenvana22','vana123',1,CAST(N'2022-11-06T12:00:00.000' AS DateTime),0,null ,1,CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1)

INSERT [dbo].[MusLunar_CustomerUser]([ID] ,[Username],[Password],[CustomerID],[LastSignin],[IsBlock],[BlockTime],[Note],[Created],[CreatedBy],[Modified],[ModifiedBy],[State])
VALUES (2,'NguyenThiHuynh27','thihuynh23',2,CAST(N'2022-11-06T12:00:00.000' AS DateTime),0,null ,1,CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1)

INSERT [dbo].[MusLunar_CustomerUser]([ID] ,[Username],[Password],[CustomerID],[LastSignin],[IsBlock],[BlockTime],[Note],[Created],[CreatedBy],[Modified],[ModifiedBy],[State])
VALUES (3,'tranthanghuy123','thanghuy43',3,CAST(N'2022-11-06T12:00:00.000' AS DateTime),0,null ,1,CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1)

INSERT[dbo].[MusLunar_CustomerUser]([ID] ,[Username],[Password],[CustomerID],[LastSignin],[IsBlock],[BlockTime],[Note],[Created],[CreatedBy],[Modified],[ModifiedBy],[State])
VALUES (4,'vanthang22','vanthang03',4,CAST(N'2022-11-06T12:00:00.000' AS DateTime),0,null ,1,CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1)

INSERT [dbo].[MusLunar_CustomerUser]([ID] ,[Username],[Password],[CustomerID],[LastSignin],[IsBlock],[BlockTime],[Note],[Created],[CreatedBy],[Modified],[ModifiedBy],[State])
VALUES (5,'thino14','thino23',5,CAST(N'2022-11-06T12:00:00.000' AS DateTime),0,null ,1,CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1)

SET IDENTITY_INSERT [dbo].[MusLunar_CustomerUser] OFF

Go

USE [LunarMusic]
GO
SET IDENTITY_INSERT [dbo].[MusLunar_Employee] ON
INSERT [dbo].[MusLunar_Employee]([ID],[Name],[NameNoSign],[NickName],[LastName],[GenderID],[BirthDay],[Phone],[Email],[AssistantEmail],[Address],[Avartar],[BackgroundImage],[Note],[Created],[CreatedBy],[Modified],[ModifiedBy],[State]) VALUES
(1, N'MusLunar',N'QCTEST',N'MusLunar',N'MusLunar',1,CAST(N'1987-11-13T00:00:00.000' AS DateTime),'036923067','MusLunar@gmail.com',null,N'245 Nguyễn Văn Cừ, Quận 5',null,null,1,CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1
)
INSERT [dbo].[MusLunar_Employee]([ID],[Name],[NameNoSign],[NickName],[LastName],[GenderID],[BirthDay],[Phone],[Email],[AssistantEmail],[Address],[Avartar],[BackgroundImage],[Note],[Created],[CreatedBy],[Modified],[ModifiedBy],[State]) VALUES
(2,N'Huỳnh Thị Hoa','ThiHoa',N'Huỳnh Thị','Hoa',2,CAST(N'1993-12-16T00:00:00.000' AS DateTime),'07632717','thihoa@gmail.com',null,N'34 Tôn Đức Thắng, Quận 1',null,null,1,CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1
)
INSERT [dbo].[MusLunar_Employee]([ID],[Name],[NameNoSign],[NickName],[LastName],[GenderID],[BirthDay],[Phone],[Email],[AssistantEmail],[Address],[Avartar],[BackgroundImage],[Note],[Created],[CreatedBy],[Modified],[ModifiedBy],[State]) VALUES
(3,N'Trần Tiến Đạt','TienDat',N'Trần Tiến',N'Đạt',1,CAST(N'1987-11-13T00:00:00.000' AS DateTime),'03592961','tiendat@gmail.com',null,N'34 Đoàn Văn Bơ Quận 4',null,null,1,CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1
)
INSERT [dbo].[MusLunar_Employee]([ID],[Name],[NameNoSign],[NickName],[LastName],[GenderID],[BirthDay],[Phone],[Email],[AssistantEmail],[Address],[Avartar],[BackgroundImage],[Note],[Created],[CreatedBy],[Modified],[ModifiedBy],[State]) VALUES
(4,N'Trịnh Trâm Ngân',N'TramNgan',N'Trịnh Trâm',N'Ngân',2,CAST(N'1982-10-16T00:00:00.000' AS DateTime),'03699037','tramanh@gmail.com',null,N'34 Lê Hòng Phomg, Quận 5',null,null,1,CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1
)
INSERT [dbo].[MusLunar_Employee]([ID],[Name],[NameNoSign],[NickName],[LastName],[GenderID],[BirthDay],[Phone],[Email],[AssistantEmail],[Address],[Avartar],[BackgroundImage],[Note],[Created],[CreatedBy],[Modified],[ModifiedBy],[State]) VALUES
(5,N'Huỳnh Võ Quốc','VoQuoc',N'Huỳnh Võ',N'Quốc',1,CAST(N'1987-11-13T00:00:00.000' AS DateTime),'03692791','voquoc@gmail.com',null,N'34 Trần Đình Xu, Quận 1',null,null,1,CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[MusLunar_Employee]([ID],[Name],[NameNoSign],[NickName],[LastName],[GenderID],[BirthDay],[Phone],[Email],[AssistantEmail],[Address],[Avartar],[BackgroundImage],[Note],[Created],[CreatedBy],[Modified],[ModifiedBy],[State]) VALUES
(6,N'Đinh Văn Phố ',N'VanPho',N'Đinh Văn',N'Phố',1,CAST(N'1987-11-13T00:00:00.000' AS DateTime),'036923067','vanpho@gmail.com',null,N'245 Nguyễn Văn Cừ, Quận 5',null,null,1,CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1
)

SET IDENTITY_INSERT [dbo].[MusLunar_Employee] OFF
Go


SET IDENTITY_INSERT [dbo].[MusLunar_Order] ON

INSERT INTO [dbo].[MusLunar_Order] ([ID],[OrderCode],[CustomerID],[TotalPrice],[TotalQuantity],[Note],[Created],[CreatedBy],[Modified],[ModifiedBy],[State]) VALUES
(1,'CD1',1,120000,120000,'1',CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1)

INSERT INTO [dbo].[MusLunar_Order] ([ID],[OrderCode],[CustomerID],[TotalPrice],[TotalQuantity],[Note],[Created],[CreatedBy],[Modified],[ModifiedBy],[State]) VALUES
(2,'CD2',2,220000,520000,'1',CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1)

INSERT INTO [dbo].[MusLunar_Order] ([ID],[OrderCode],[CustomerID],[TotalPrice],[TotalQuantity],[Note],[Created],[CreatedBy],[Modified],[ModifiedBy],[State]) VALUES
(3,'CD3',3,320000,620000,'1',CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1)

INSERT INTO [dbo].[MusLunar_Order] ([ID],[OrderCode],[CustomerID],[TotalPrice],[TotalQuantity],[Note],[Created],[CreatedBy],[Modified],[ModifiedBy],[State]) VALUES
(4,'CD6',4,420000,520000,'1',CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1)

INSERT INTO [dbo].[MusLunar_Order] ([ID],[OrderCode],[CustomerID],[TotalPrice],[TotalQuantity],[Note],[Created],[CreatedBy],[Modified],[ModifiedBy],[State]) VALUES
(5,'CD5',5,520000,720000,'1',CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1)


SET IDENTITY_INSERT [dbo].[MusLunar_Order] OFF
GO

SET IDENTITY_INSERT [dbo].[MusLunar_OrderDetail] ON

INSERT INTO [dbo].[MusLunar_OrderDetail]([ID],[OrderID] ,[SongID],[Price],[DiscountPrice],[DiscountedPrice],[PaymentMethodID],[Created],[CreatedBy],[Modified],[ModifiedBy],[State])
VALUES (1,1,2,1873230,6486615,1407128, 9,CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1)
GO

INSERT INTO [dbo].[MusLunar_OrderDetail]([ID],[OrderID] ,[SongID],[Price],[DiscountPrice],[DiscountedPrice],[PaymentMethodID],[Created],[CreatedBy],[Modified],[ModifiedBy],[State])
VALUES (2,3,1,2574330,4689921,1407128,9,CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1)
GO

INSERT INTO [dbo].[MusLunar_OrderDetail]([ID],[OrderID] ,[SongID],[Price],[DiscountPrice],[DiscountedPrice],[PaymentMethodID],[Created],[CreatedBy],[Modified],[ModifiedBy],[State])
VALUES (3,2,3,1873230,5586643,1508912,9,CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1)
GO

INSERT INTO [dbo].[MusLunar_OrderDetail]([ID],[OrderID] ,[SongID],[Price],[DiscountPrice],[DiscountedPrice],[PaymentMethodID],[Created],[CreatedBy],[Modified],[ModifiedBy],[State])
VALUES (4,5,5,1873230,1387210,1107132,9,CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1)
GO

INSERT INTO [dbo].[MusLunar_OrderDetail]([ID],[OrderID] ,[SongID],[Price],[DiscountPrice],[DiscountedPrice],[PaymentMethodID],[Created],[CreatedBy],[Modified],[ModifiedBy],[State])
VALUES (5,4,6,1873230,2287915,1407522,9,CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1)
GO

SET IDENTITY_INSERT [dbo].[MusLunar_OrderDetail] OFF
GO

SET IDENTITY_INSERT [dbo].[MusLunar_User] ON

INSERT INTO [dbo].[MusLunar_User]([ID],[Username],[Password],[EmployeeID],[LastSignin],[Note],[Created],[CreatedBy],[Modified],[ModifiedBy],[State])
VALUES (1,'Muslunar','Ml123456',CAST(N'2022-11-06T00:00:00.000' AS DateTime),1,CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1)
GO

INSERT INTO [dbo].[MusLunar_User]([ID],[Username],[Password],[EmployeeID],[LastSignin],[Note],[Created],[CreatedBy],[Modified],[ModifiedBy],[State])
VALUES (2,'TrinhTramNgan','TramNgan123',4,CAST(N'2022-11-01T00:00:00.000' AS DateTime),1,CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1)
GO

INSERT INTO [dbo].[MusLunar_User]([ID],[Username],[Password],[EmployeeID],[LastSignin],[Note],[Created],[CreatedBy],[Modified],[ModifiedBy],[State])
VALUES (3,'DinhVanPho','VanPho123',6,CAST(N'2022-11-06T00:00:00.000' AS DateTime),1,CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1)
GO

INSERT INTO [dbo].[MusLunar_User]([ID],[Username],[Password],[EmployeeID],[LastSignin],[Note],[Created],[CreatedBy],[Modified],[ModifiedBy],[State])
VALUES (4,'TranTienDat','TienDat123',3,CAST(N'2022-11-06T00:00:00.000' AS DateTime),1,CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1)
GO

INSERT INTO [dbo].[MusLunar_User]([ID],[Username],[Password],[EmployeeID],[LastSignin],[Note],[Created],[CreatedBy],[Modified],[ModifiedBy],[State])
VALUES (5,'HuynhThiHoa','ThiHoa123',2,CAST(N'2022-11-06T00:00:00.000' AS DateTime),1,CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, CAST(N'2023-01-01T00:00:00.000' AS DateTime), 1, 1)
GO

SET IDENTITY_INSERT [dbo].[MusLunar_User] OFF
GO

USE [LunarMusic]
GO
SET IDENTITY_INSERT [dbo].[MusLunar_UserApi] ON 

INSERT [dbo].[MusLunar_UserApi] ([ID], [Username], [Password], [EmailAddress], [Role], [SurName], [GivenName], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (1, N'MusLunarAdmin', N'Ml123456', N'MusLunarAdmin@gmail.com', N'Administrator', N'Mus', N'Lunar', CAST(N'2022-11-10T00:00:00.000' AS DateTime), NULL, NULL, NULL, 1)
INSERT [dbo].[MusLunar_UserApi] ([ID], [Username], [Password], [EmailAddress], [Role], [SurName], [GivenName], [Created], [CreatedBy], [Modified], [ModifiedBy], [State]) VALUES (2, N'MusLunarTest', N'Ml123456', N'MusLunarAdmin@gmail.com', N'Tester', N'Mus', N'Lunar', CAST(N'2022-11-10T00:00:00.000' AS DateTime), NULL, NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[MusLunar_UserApi] OFF
GO


USE [LunarMusic]
GO
/****** Object:  StoredProcedure [dbo].[YYY_sp_v1_CustomerPlaylist_LoadList]    Script Date: 11/25/2022 9:22:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[YYY_sp_v1_rp_favouritemusic_general]
	@datefrom datetime = '2019-11-25',
	@dateto datetime = '2022-11-25'
AS
BEGIN
	SELECT ID=S.GenresID
		, Genres=ISNULL(G.Name, '')
		, FavNum = COUNT(P.SongID)
		, ListenTimes = SUM(P.ListeningTimes)
	FROM MusLunar_CustomerPlaylist P
	INNER JOIN MusLunar_Song S ON S.ID = P.SongID AND S.State=1
	INNER JOIN MusLunar_Music_Genres G ON G.ID = S.GenresID
	WHERE P.Created BETWEEN @datefrom AND @dateto AND P.State=1
	GROUP BY S.GenresID, G.Name

END

/****** Object:  StoredProcedure [dbo].[YYY_sp_v1_CustomerPlaylist_LoadList]    Script Date: 11/25/2022 9:22:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[YYY_sp_v1_rp_favouritemusic_detail]
	@datefrom datetime = '2019-11-25',
	@dateto datetime = '2022-11-25',
	@genresID int = 2
AS
BEGIN
	SELECT PL.ID
		  ,Genres = ISNULL(G.Name, '')
		  ,CustID = ISNULL(C.ID, 0)
		  ,CustName = ISNULL(C.Name, '')
		  ,SongName = ISNULL(S.Name, '')
		  ,PL.ListeningTimes
		  ,PL.LastListeningTime
		  ,PL.Created
		  ,PL.CreatedBy
		  ,PL.Modified
		  ,PL.ModifiedBy
	FROM MusLunar_CustomerPlaylist PL
	INNER JOIN MusLunar_Customer C ON C.ID = PL.CustomerID AND PL.State = 1
	INNER JOIN MusLunar_Song S ON S.ID = PL.SongID AND S.State = 1
	INNER JOIN MusLunar_Music_Genres G ON G.ID = S.GenresID
	WHERE PL.Created BETWEEN @datefrom AND @dateto AND PL.State=1
	 AND (S.GenresID = 0 OR S.GenresID = @genresID)
END








