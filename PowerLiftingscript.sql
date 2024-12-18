USE [master]
GO
/****** Object:  Database [PowerliftingSchoolDb]    Script Date: 07.11.2024 19:39:02 ******/
CREATE DATABASE [PowerliftingSchoolDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PowerliftingSchoolDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\PowerliftingSchoolDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PowerliftingSchoolDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\PowerliftingSchoolDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [PowerliftingSchoolDb] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PowerliftingSchoolDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PowerliftingSchoolDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PowerliftingSchoolDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PowerliftingSchoolDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PowerliftingSchoolDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PowerliftingSchoolDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [PowerliftingSchoolDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PowerliftingSchoolDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PowerliftingSchoolDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PowerliftingSchoolDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PowerliftingSchoolDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PowerliftingSchoolDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PowerliftingSchoolDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PowerliftingSchoolDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PowerliftingSchoolDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PowerliftingSchoolDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PowerliftingSchoolDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PowerliftingSchoolDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PowerliftingSchoolDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PowerliftingSchoolDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PowerliftingSchoolDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PowerliftingSchoolDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PowerliftingSchoolDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PowerliftingSchoolDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PowerliftingSchoolDb] SET  MULTI_USER 
GO
ALTER DATABASE [PowerliftingSchoolDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PowerliftingSchoolDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PowerliftingSchoolDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PowerliftingSchoolDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PowerliftingSchoolDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PowerliftingSchoolDb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [PowerliftingSchoolDb] SET QUERY_STORE = ON
GO
ALTER DATABASE [PowerliftingSchoolDb] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [PowerliftingSchoolDb]
GO
/****** Object:  Table [dbo].[Group]    Script Date: 07.11.2024 19:39:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Group](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 07.11.2024 19:39:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Lastname] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Birthday] [date] NOT NULL,
	[GroupId] [int] NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Timetable]    Script Date: 07.11.2024 19:39:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Timetable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DateTime] [datetime] NOT NULL,
	[GroupId] [int] NOT NULL,
 CONSTRAINT [PK_Timetable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 07.11.2024 19:39:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Lastname] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Phonenumber] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](18) NOT NULL,
	[WorkoutsCount] [int] NOT NULL,
	[Rating] [float] NOT NULL,
	[Photo] [nvarchar](max) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Group] ON 

INSERT [dbo].[Group] ([Id], [Name], [UserId]) VALUES (3, N'Младшая группа 1', 3)
INSERT [dbo].[Group] ([Id], [Name], [UserId]) VALUES (4, N'Старшая группа 1', 4)
SET IDENTITY_INSERT [dbo].[Group] OFF
GO
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([Id], [Lastname], [Name], [Surname], [Birthday], [GroupId]) VALUES (4, N'Кошелев', N'Илья', N'Владимирович', CAST(N'2001-01-01' AS Date), 3)
INSERT [dbo].[Students] ([Id], [Lastname], [Name], [Surname], [Birthday], [GroupId]) VALUES (5, N'Выборноvvv', N'Александр', N'Александрович', CAST(N'2001-01-01' AS Date), 4)
INSERT [dbo].[Students] ([Id], [Lastname], [Name], [Surname], [Birthday], [GroupId]) VALUES (6, N'Гречаный', N'Федор', N'Юрьевич', CAST(N'2005-09-30' AS Date), 3)
SET IDENTITY_INSERT [dbo].[Students] OFF
GO
SET IDENTITY_INSERT [dbo].[Timetable] ON 

INSERT [dbo].[Timetable] ([Id], [DateTime], [GroupId]) VALUES (1, CAST(N'2024-01-01T23:59:59.000' AS DateTime), 3)
INSERT [dbo].[Timetable] ([Id], [DateTime], [GroupId]) VALUES (2, CAST(N'2024-10-01T23:59:59.000' AS DateTime), 4)
INSERT [dbo].[Timetable] ([Id], [DateTime], [GroupId]) VALUES (3, CAST(N'2024-10-05T00:00:00.000' AS DateTime), 3)
INSERT [dbo].[Timetable] ([Id], [DateTime], [GroupId]) VALUES (4, CAST(N'2024-10-10T00:00:00.000' AS DateTime), 3)
INSERT [dbo].[Timetable] ([Id], [DateTime], [GroupId]) VALUES (5, CAST(N'2024-10-15T00:00:00.000' AS DateTime), 4)
SET IDENTITY_INSERT [dbo].[Timetable] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [Lastname], [Name], [Surname], [Email], [Phonenumber], [Password], [WorkoutsCount], [Rating], [Photo]) VALUES (3, N'Расторгуев ', N'Олег', N'Викторович', N'testEmail1', N'testNumber1', N'test', 15, 5, N'C:\Users\user\source\repos\PowerliftingSchool\PowerliftingSchool\Resources\coach1.jpg')
INSERT [dbo].[User] ([Id], [Lastname], [Name], [Surname], [Email], [Phonenumber], [Password], [WorkoutsCount], [Rating], [Photo]) VALUES (4, N'Воронко ', N'Евгений ', N'Юрьевич', N'testEmail2', N'testNumber2', N'test1', 12, 4.5, N'C:\Users\user\source\repos\PowerliftingSchool\PowerliftingSchool\Resources\coach2.jpg')
INSERT [dbo].[User] ([Id], [Lastname], [Name], [Surname], [Email], [Phonenumber], [Password], [WorkoutsCount], [Rating], [Photo]) VALUES (5, N'Подколзин ', N'Александр ', N'Александрович', N'testEmail3', N'testEmail3', N'test2', 11, 4, N'C:\Users\user\source\repos\PowerliftingSchool\PowerliftingSchool\Resources\coach3.jpg')
INSERT [dbo].[User] ([Id], [Lastname], [Name], [Surname], [Email], [Phonenumber], [Password], [WorkoutsCount], [Rating], [Photo]) VALUES (8, N'asd', N'asd', N'asd', N'asd', N'asd', N'asd', 0, 0, NULL)
INSERT [dbo].[User] ([Id], [Lastname], [Name], [Surname], [Email], [Phonenumber], [Password], [WorkoutsCount], [Rating], [Photo]) VALUES (9, N'asd', N'asd', N'asd', N'asd', N'asd', N'asd', 0, 0, NULL)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Group]  WITH CHECK ADD  CONSTRAINT [FK_Group_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[Group] CHECK CONSTRAINT [FK_Group_User]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Group] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Group] ([Id])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Group]
GO
ALTER TABLE [dbo].[Timetable]  WITH CHECK ADD  CONSTRAINT [FK_Timetable_Group] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Group] ([Id])
GO
ALTER TABLE [dbo].[Timetable] CHECK CONSTRAINT [FK_Timetable_Group]
GO
USE [master]
GO
ALTER DATABASE [PowerliftingSchoolDb] SET  READ_WRITE 
GO
