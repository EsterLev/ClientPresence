use [master]
create database [PRESENCE] 
USE [PRESENCE]
GO
/****** Object:  Table [dbo].[ActingTeacher]    Script Date: 31/05/2022 15:47:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ActingTeacher](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[KindergartenId] [int] NOT NULL,
	[DayByWeek] [int] NULL,
 CONSTRAINT [PK_ActingTeacher] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Birthdays]    Script Date: 31/05/2022 15:47:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Birthdays](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IsPossible] [bit] NOT NULL,
	[KindergartenId] [int] NOT NULL,
	[HebrewDate] [bit] NULL,
	[BirthdayPerMonth] [bit] NULL,
	[DayByMonth] [int] NULL,
	[DayByWeek] [int] NULL,
	[NumDaysBefore] [int] NULL,
 CONSTRAINT [PK_Birthdays] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Connection]    Script Date: 31/05/2022 15:47:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Connection](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Phone] [bit] NOT NULL,
	[Email] [bit] NOT NULL,
	[SMS] [bit] NOT NULL,
 CONSTRAINT [PK_Connection] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DelaySchoolBuses]    Script Date: 31/05/2022 15:47:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DelaySchoolBuses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SchoolBusId] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[DelayTime] [time](7) NOT NULL,
	[EscortId] [int] NOT NULL,
 CONSTRAINT [PK_DelaySchoolBuses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kindergarten]    Script Date: 31/05/2022 15:47:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kindergarten](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[Phone] [nvarchar](10) NOT NULL,
	[TeacherId] [int] NOT NULL,
 CONSTRAINT [PK_Kindergarten] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KindergartenPresence]    Script Date: 31/05/2022 15:47:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KindergartenPresence](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KindergartenId] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_KindergartenPresence] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Parents]    Script Date: 31/05/2022 15:47:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parents](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[ConnectionId] [int] NOT NULL,
 CONSTRAINT [PK_Parents] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PresenceType]    Script Date: 31/05/2022 15:47:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PresenceType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Type] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_PresenceType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reminders]    Script Date: 31/05/2022 15:47:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reminders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Hour] [time](7) NOT NULL,
	[SnoozeDuration] [int] NOT NULL,
	[Daily] [int] NULL,
	[Weekly] [int] NULL,
	[Monthly] [int] NULL,
	[KindergartenId] [int] NOT NULL,
 CONSTRAINT [PK_Reminders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SchoolBuses]    Script Date: 31/05/2022 15:47:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SchoolBuses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ArrivalTime] [time](7) NOT NULL,
	[EscortId] [int] NOT NULL,
 CONSTRAINT [PK_SchoolBuses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 31/05/2022 15:47:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](20) NOT NULL,
	[FirstName] [nvarchar](20) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[Picture] [nvarchar](max) NULL,
	[Gender] [bit] NOT NULL,
	[FatherId] [int] NULL,
	[MotherId] [int] NULL,
	[KindergartenId] [int] NOT NULL,
	[SchoolBusId] [int] NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentsPresence]    Script Date: 31/05/2022 15:47:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentsPresence](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StudentId] [int] NOT NULL,
	[KindergartenPresenceId] [int] NOT NULL,
	[TypePresence] [int] NOT NULL,
 CONSTRAINT [PK_StudentsPresence] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 31/05/2022 15:47:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](20) NOT NULL,
	[FirstName] [nvarchar](20) NOT NULL,
	[Phone] [nvarchar](10) NOT NULL,
	[Email] [nvarchar](30) NULL,
	[Password] [nvarchar](15) NOT NULL,
	[UserType] [int] NOT NULL,
	[UserName] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsersTypes]    Script Date: 31/05/2022 15:47:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Type] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_UsersTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ActingTeacher] ON 

INSERT [dbo].[ActingTeacher] ([Id], [UserId], [KindergartenId], [DayByWeek]) VALUES (1, 7, 1, 3)
SET IDENTITY_INSERT [dbo].[ActingTeacher] OFF
GO
SET IDENTITY_INSERT [dbo].[Birthdays] ON 

INSERT [dbo].[Birthdays] ([Id], [IsPossible], [KindergartenId], [HebrewDate], [BirthdayPerMonth], [DayByMonth], [DayByWeek], [NumDaysBefore]) VALUES (1, 1, 1, 1, 0, NULL, NULL, 3)
SET IDENTITY_INSERT [dbo].[Birthdays] OFF
GO
SET IDENTITY_INSERT [dbo].[Connection] ON 

INSERT [dbo].[Connection] ([Id], [Phone], [Email], [SMS]) VALUES (1, 0, 0, 0)
INSERT [dbo].[Connection] ([Id], [Phone], [Email], [SMS]) VALUES (2, 0, 0, 1)
INSERT [dbo].[Connection] ([Id], [Phone], [Email], [SMS]) VALUES (3, 0, 1, 0)
INSERT [dbo].[Connection] ([Id], [Phone], [Email], [SMS]) VALUES (5, 0, 1, 1)
INSERT [dbo].[Connection] ([Id], [Phone], [Email], [SMS]) VALUES (6, 1, 0, 0)
INSERT [dbo].[Connection] ([Id], [Phone], [Email], [SMS]) VALUES (7, 1, 0, 1)
INSERT [dbo].[Connection] ([Id], [Phone], [Email], [SMS]) VALUES (8, 1, 1, 0)
INSERT [dbo].[Connection] ([Id], [Phone], [Email], [SMS]) VALUES (10, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[Connection] OFF
GO
SET IDENTITY_INSERT [dbo].[DelaySchoolBuses] ON 

INSERT [dbo].[DelaySchoolBuses] ([Id], [SchoolBusId], [Date], [DelayTime], [EscortId]) VALUES (1, 1, CAST(N'2020-10-10' AS Date), CAST(N'00:30:00' AS Time), 7)
INSERT [dbo].[DelaySchoolBuses] ([Id], [SchoolBusId], [Date], [DelayTime], [EscortId]) VALUES (3, 2, CAST(N'2022-01-03' AS Date), CAST(N'00:15:00' AS Time), 8)
SET IDENTITY_INSERT [dbo].[DelaySchoolBuses] OFF
GO
SET IDENTITY_INSERT [dbo].[Kindergarten] ON 

INSERT [dbo].[Kindergarten] ([Id], [Name], [Address], [Phone], [TeacherId]) VALUES (1, N'גן גפן', N'חשמונאים', N'058974545', 4)
SET IDENTITY_INSERT [dbo].[Kindergarten] OFF
GO
SET IDENTITY_INSERT [dbo].[KindergartenPresence] ON 

INSERT [dbo].[KindergartenPresence] ([Id], [KindergartenId], [Date], [UserId]) VALUES (1, 1, CAST(N'2022-05-17' AS Date), 7)
INSERT [dbo].[KindergartenPresence] ([Id], [KindergartenId], [Date], [UserId]) VALUES (2, 1, CAST(N'2022-05-14' AS Date), 7)
SET IDENTITY_INSERT [dbo].[KindergartenPresence] OFF
GO
SET IDENTITY_INSERT [dbo].[Parents] ON 

INSERT [dbo].[Parents] ([Id], [UserId], [ConnectionId]) VALUES (2, 8, 6)
INSERT [dbo].[Parents] ([Id], [UserId], [ConnectionId]) VALUES (5, 11, 10)
SET IDENTITY_INSERT [dbo].[Parents] OFF
GO
SET IDENTITY_INSERT [dbo].[PresenceType] ON 

INSERT [dbo].[PresenceType] ([Id], [Type]) VALUES (1, N'איחור מראש')
INSERT [dbo].[PresenceType] ([Id], [Type]) VALUES (2, N'חיסור מראש')
INSERT [dbo].[PresenceType] ([Id], [Type]) VALUES (3, N'איחור')
INSERT [dbo].[PresenceType] ([Id], [Type]) VALUES (4, N'חיסור')
INSERT [dbo].[PresenceType] ([Id], [Type]) VALUES (5, N'נוכח')
SET IDENTITY_INSERT [dbo].[PresenceType] OFF
GO
SET IDENTITY_INSERT [dbo].[Reminders] ON 

INSERT [dbo].[Reminders] ([Id], [Hour], [SnoozeDuration], [Daily], [Weekly], [Monthly], [KindergartenId]) VALUES (1, CAST(N'09:30:00' AS Time), 5, 1, 0, 0, 1)
SET IDENTITY_INSERT [dbo].[Reminders] OFF
GO
SET IDENTITY_INSERT [dbo].[SchoolBuses] ON 

INSERT [dbo].[SchoolBuses] ([Id], [ArrivalTime], [EscortId]) VALUES (1, CAST(N'08:00:00' AS Time), 7)
INSERT [dbo].[SchoolBuses] ([Id], [ArrivalTime], [EscortId]) VALUES (2, CAST(N'09:00:00' AS Time), 8)
SET IDENTITY_INSERT [dbo].[SchoolBuses] OFF
GO
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([Id], [LastName], [FirstName], [Address], [DateOfBirth], [Picture], [Gender], [FatherId], [MotherId], [KindergartenId], [SchoolBusId]) VALUES (10, N'בסר', N'מירי', N'חתם סופר', CAST(N'2002-05-01' AS Date), NULL, 0, 2, 5, 1, 2)
SET IDENTITY_INSERT [dbo].[Students] OFF
GO
SET IDENTITY_INSERT [dbo].[StudentsPresence] ON 

INSERT [dbo].[StudentsPresence] ([Id], [StudentId], [KindergartenPresenceId], [TypePresence]) VALUES (1, 10, 1, 2)
SET IDENTITY_INSERT [dbo].[StudentsPresence] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [LastName], [FirstName], [Phone], [Email], [Password], [UserType], [UserName]) VALUES (4, N'פסטרנק', N'רעות', N'0556708858', N'reut08858@gmail.com', N'1234', 1, N'רעות')
INSERT [dbo].[Users] ([Id], [LastName], [FirstName], [Phone], [Email], [Password], [UserType], [UserName]) VALUES (5, N'לב', N'אסתי', N'0583281357', N'st3281357@gmail.com', N'4321', 2, N'אסתי')
INSERT [dbo].[Users] ([Id], [LastName], [FirstName], [Phone], [Email], [Password], [UserType], [UserName]) VALUES (7, N'שושן', N'שושנה', N'0582557455', N'455@gmail.com', N'7455', 5, N'שושנה')
INSERT [dbo].[Users] ([Id], [LastName], [FirstName], [Phone], [Email], [Password], [UserType], [UserName]) VALUES (8, N'קרמר', N'ריבי', N'0583211001', N'rivi@gmail.com', N'9632', 4, N'ריבי')
INSERT [dbo].[Users] ([Id], [LastName], [FirstName], [Phone], [Email], [Password], [UserType], [UserName]) VALUES (11, N'שטרנפלד', N'רותי', N'0533189961', N'r0533189961@gmail.com', N'5948', 4, N'רותי')
INSERT [dbo].[Users] ([Id], [LastName], [FirstName], [Phone], [Email], [Password], [UserType], [UserName]) VALUES (12, N'נחמני', N'חיים', N'0527689536', N'536@gmail.com', N'8956', 5, N'חיים')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[UsersTypes] ON 

INSERT [dbo].[UsersTypes] ([Id], [Type]) VALUES (1, N'מנהלת גן')
INSERT [dbo].[UsersTypes] ([Id], [Type]) VALUES (2, N'גננת משלימה')
INSERT [dbo].[UsersTypes] ([Id], [Type]) VALUES (3, N'גננת ממלאת מקום')
INSERT [dbo].[UsersTypes] ([Id], [Type]) VALUES (4, N'הורה')
INSERT [dbo].[UsersTypes] ([Id], [Type]) VALUES (5, N'מלווה הסעה')
INSERT [dbo].[UsersTypes] ([Id], [Type]) VALUES (6, N'מלווה ממלא מקום')
SET IDENTITY_INSERT [dbo].[UsersTypes] OFF
GO
ALTER TABLE [dbo].[ActingTeacher]  WITH CHECK ADD  CONSTRAINT [FK_ActingTeacher_Kindergarten] FOREIGN KEY([KindergartenId])
REFERENCES [dbo].[Kindergarten] ([Id])
GO
ALTER TABLE [dbo].[ActingTeacher] CHECK CONSTRAINT [FK_ActingTeacher_Kindergarten]
GO
ALTER TABLE [dbo].[ActingTeacher]  WITH CHECK ADD  CONSTRAINT [FK_ActingTeacher_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[ActingTeacher] CHECK CONSTRAINT [FK_ActingTeacher_Users]
GO
ALTER TABLE [dbo].[Birthdays]  WITH CHECK ADD  CONSTRAINT [FK_Birthdays_Kindergarten] FOREIGN KEY([KindergartenId])
REFERENCES [dbo].[Kindergarten] ([Id])
GO
ALTER TABLE [dbo].[Birthdays] CHECK CONSTRAINT [FK_Birthdays_Kindergarten]
GO
ALTER TABLE [dbo].[DelaySchoolBuses]  WITH CHECK ADD  CONSTRAINT [FK_DelaySchoolBuses_SchoolBuses] FOREIGN KEY([SchoolBusId])
REFERENCES [dbo].[SchoolBuses] ([Id])
GO
ALTER TABLE [dbo].[DelaySchoolBuses] CHECK CONSTRAINT [FK_DelaySchoolBuses_SchoolBuses]
GO
ALTER TABLE [dbo].[DelaySchoolBuses]  WITH CHECK ADD  CONSTRAINT [FK_DelaySchoolBuses_Users] FOREIGN KEY([EscortId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[DelaySchoolBuses] CHECK CONSTRAINT [FK_DelaySchoolBuses_Users]
GO
ALTER TABLE [dbo].[Kindergarten]  WITH CHECK ADD  CONSTRAINT [FK_Kindergarten_Users] FOREIGN KEY([TeacherId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Kindergarten] CHECK CONSTRAINT [FK_Kindergarten_Users]
GO
ALTER TABLE [dbo].[KindergartenPresence]  WITH CHECK ADD  CONSTRAINT [FK_KindergartenPresence_Kindergarten] FOREIGN KEY([KindergartenId])
REFERENCES [dbo].[Kindergarten] ([Id])
GO
ALTER TABLE [dbo].[KindergartenPresence] CHECK CONSTRAINT [FK_KindergartenPresence_Kindergarten]
GO
ALTER TABLE [dbo].[KindergartenPresence]  WITH CHECK ADD  CONSTRAINT [FK_KindergartenPresence_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[KindergartenPresence] CHECK CONSTRAINT [FK_KindergartenPresence_Users]
GO
ALTER TABLE [dbo].[Parents]  WITH CHECK ADD FOREIGN KEY([ConnectionId])
REFERENCES [dbo].[Connection] ([Id])
GO
ALTER TABLE [dbo].[Parents]  WITH CHECK ADD  CONSTRAINT [FK_Parents_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Parents] CHECK CONSTRAINT [FK_Parents_Users]
GO
ALTER TABLE [dbo].[Reminders]  WITH CHECK ADD  CONSTRAINT [FK_Reminders_Kindergarten] FOREIGN KEY([KindergartenId])
REFERENCES [dbo].[Kindergarten] ([Id])
GO
ALTER TABLE [dbo].[Reminders] CHECK CONSTRAINT [FK_Reminders_Kindergarten]
GO
ALTER TABLE [dbo].[SchoolBuses]  WITH CHECK ADD  CONSTRAINT [FK_SchoolBuses_Users] FOREIGN KEY([EscortId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[SchoolBuses] CHECK CONSTRAINT [FK_SchoolBuses_Users]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Kindergarten] FOREIGN KEY([KindergartenId])
REFERENCES [dbo].[Kindergarten] ([Id])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Kindergarten]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Parents_Father] FOREIGN KEY([FatherId])
REFERENCES [dbo].[Parents] ([Id])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Parents_Father]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Parents_Mother] FOREIGN KEY([MotherId])
REFERENCES [dbo].[Parents] ([Id])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Parents_Mother]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_SchoolBuses] FOREIGN KEY([SchoolBusId])
REFERENCES [dbo].[SchoolBuses] ([Id])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_SchoolBuses]
GO
ALTER TABLE [dbo].[StudentsPresence]  WITH CHECK ADD  CONSTRAINT [FK_StudentsPresence_KindergartenPresence] FOREIGN KEY([KindergartenPresenceId])
REFERENCES [dbo].[KindergartenPresence] ([Id])
GO
ALTER TABLE [dbo].[StudentsPresence] CHECK CONSTRAINT [FK_StudentsPresence_KindergartenPresence]
GO
ALTER TABLE [dbo].[StudentsPresence]  WITH CHECK ADD  CONSTRAINT [FK_StudentsPresence_PresenceType] FOREIGN KEY([TypePresence])
REFERENCES [dbo].[PresenceType] ([Id])
GO
ALTER TABLE [dbo].[StudentsPresence] CHECK CONSTRAINT [FK_StudentsPresence_PresenceType]
GO
ALTER TABLE [dbo].[StudentsPresence]  WITH CHECK ADD  CONSTRAINT [FK_StudentsPresence_Students] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Students] ([Id])
GO
ALTER TABLE [dbo].[StudentsPresence] CHECK CONSTRAINT [FK_StudentsPresence_Students]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_UsersTypes] FOREIGN KEY([UserType])
REFERENCES [dbo].[UsersTypes] ([Id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_UsersTypes]
GO
