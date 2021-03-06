/*יש להריץ 2 שורות ראשונות בנפרד,ואח"כ את כל הסקריפט מלבד שורות אלו*/
USE [master]
create database [PRESENCE]
/*יש להריץ 2 שורות ראשונות בנפרד,ואח"כ את כל הסקריפט מלבד שורות אלו*/
USE [PRESENCE]
GO
/****** Object:  Table [dbo].[ActingTeacher]    Script Date: 03/05/2022 09:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ActingTeacher](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[KindergartenId] [int] NOT NULL,
	[DayByWeek] [int] NULL,
	[Date] [date] NULL,
 CONSTRAINT [PK_ActingTeacher] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Birthdays]    Script Date: 03/05/2022 09:21:32 ******/
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
/****** Object:  Table [dbo].[Connection]    Script Date: 03/05/2022 09:21:32 ******/
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
/****** Object:  Table [dbo].[DelaySchoolBusses]    Script Date: 03/05/2022 09:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DelaySchoolBusses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SchoolBusId] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[DelayTime] [time](7) NOT NULL,
	[EscortId] [int] NOT NULL,
 CONSTRAINT [PK_DelaySchoolBusses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kindergarten]    Script Date: 03/05/2022 09:21:32 ******/
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
/****** Object:  Table [dbo].[KindergartenPresence]    Script Date: 03/05/2022 09:21:32 ******/
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
/****** Object:  Table [dbo].[Parents]    Script Date: 03/05/2022 09:21:32 ******/
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
/****** Object:  Table [dbo].[PresenceType]    Script Date: 03/05/2022 09:21:32 ******/
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
/****** Object:  Table [dbo].[Reminders]    Script Date: 03/05/2022 09:21:32 ******/
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
/****** Object:  Table [dbo].[SchoolBusses]    Script Date: 03/05/2022 09:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SchoolBusses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ArrivalTime] [time](7) NOT NULL,
	[EscortId] [int] NOT NULL,
 CONSTRAINT [PK_SchoolBusses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 03/05/2022 09:21:32 ******/
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
/****** Object:  Table [dbo].[StudentsPresence]    Script Date: 03/05/2022 09:21:32 ******/
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
/****** Object:  Table [dbo].[Users]    Script Date: 03/05/2022 09:21:32 ******/
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
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsersTypes]    Script Date: 03/05/2022 09:21:32 ******/
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
ALTER TABLE [dbo].[DelaySchoolBusses]  WITH CHECK ADD  CONSTRAINT [FK_DelaySchoolBusses_SchoolBusses] FOREIGN KEY([SchoolBusId])
REFERENCES [dbo].[SchoolBusses] ([Id])
GO
ALTER TABLE [dbo].[DelaySchoolBusses] CHECK CONSTRAINT [FK_DelaySchoolBusses_SchoolBusses]
GO
ALTER TABLE [dbo].[DelaySchoolBusses]  WITH CHECK ADD  CONSTRAINT [FK_DelaySchoolBusses_Users] FOREIGN KEY([EscortId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[DelaySchoolBusses] CHECK CONSTRAINT [FK_DelaySchoolBusses_Users]
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
ALTER TABLE [dbo].[SchoolBusses]  WITH CHECK ADD  CONSTRAINT [FK_SchoolBusses_Users] FOREIGN KEY([EscortId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[SchoolBusses] CHECK CONSTRAINT [FK_SchoolBusses_Users]
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
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_SchoolBusses] FOREIGN KEY([SchoolBusId])
REFERENCES [dbo].[SchoolBusses] ([Id])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_SchoolBusses]
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
