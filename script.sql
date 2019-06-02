/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2017 (14.0.1000)
    Source Database Engine Edition : Microsoft SQL Server Enterprise Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [master]
GO
/****** Object:  Database [MyAcademy]    Script Date: 6/2/2019 10:03:08 PM ******/
CREATE DATABASE [MyAcademy]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MyAcademy', FILENAME = N'C:\Users\code\Desktop\MSSQL14.MSSQLSERVER\MSSQL\DATA\MyAcademy.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MyAcademy_log', FILENAME = N'C:\Users\code\Desktop\MSSQL14.MSSQLSERVER\MSSQL\DATA\MyAcademy_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [MyAcademy] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MyAcademy].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MyAcademy] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MyAcademy] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MyAcademy] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MyAcademy] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MyAcademy] SET ARITHABORT OFF 
GO
ALTER DATABASE [MyAcademy] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MyAcademy] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MyAcademy] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MyAcademy] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MyAcademy] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MyAcademy] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MyAcademy] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MyAcademy] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MyAcademy] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MyAcademy] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MyAcademy] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MyAcademy] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MyAcademy] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MyAcademy] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MyAcademy] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MyAcademy] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MyAcademy] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MyAcademy] SET RECOVERY FULL 
GO
ALTER DATABASE [MyAcademy] SET  MULTI_USER 
GO
ALTER DATABASE [MyAcademy] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MyAcademy] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MyAcademy] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MyAcademy] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MyAcademy] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MyAcademy', N'ON'
GO
ALTER DATABASE [MyAcademy] SET QUERY_STORE = OFF
GO
USE [MyAcademy]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [MyAcademy]
GO
/****** Object:  Table [dbo].[Academy]    Script Date: 6/2/2019 10:03:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Academy](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Street] [varchar](255) NOT NULL,
	[Phone] [varchar](255) NOT NULL,
 CONSTRAINT [PK_ACADEMY] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Classrooms]    Script Date: 6/2/2019 10:03:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Classrooms](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_CLASSROOMS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Educations]    Script Date: 6/2/2019 10:03:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Educations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Price] [float] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_EDUCATIONS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 6/2/2019 10:03:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Surname] [varchar](100) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Phone] [varchar](100) NOT NULL,
	[Mentor] [varchar](100) NOT NULL,
	[PositionId] [int] NOT NULL,
	[StartTime] [datetime] NOT NULL,
	[Salary] [float] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_EMPLOYEES] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Groups]    Script Date: 6/2/2019 10:03:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Groups](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[ClassroomId] [int] NOT NULL,
	[TeacherId] [int] NOT NULL,
	[MentorId] [int] NOT NULL,
	[Capacity] [int] NOT NULL,
	[EducationProgramId] [int] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_GROUPS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Positions]    Script Date: 6/2/2019 10:03:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Positions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_POSITIONS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 6/2/2019 10:03:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Surname] [varchar](100) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Phone] [varchar](100) NOT NULL,
	[Fee] [varchar](100) NOT NULL,
	[GroupId] [int] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_STUDENTS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentsMarks]    Script Date: 6/2/2019 10:03:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentsMarks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StudentId] [int] NOT NULL,
	[TaskId] [int] NOT NULL,
	[Mark] [int] NOT NULL,
 CONSTRAINT [PK_STUDENTSMARKS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tasks]    Script Date: 6/2/2019 10:03:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tasks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Deadline] [datetime] NOT NULL,
	[GroupId] [int] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_TASKS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 6/2/2019 10:03:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Surname] [varchar](50) NOT NULL,
	[Speciality] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Phone] [varchar](50) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_TEACHERS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Academy] ON 

INSERT [dbo].[Academy] ([Id], [Name], [Street], [Phone]) VALUES (1, N'Code Academy', N'Nizami kucesi64', N'3494949')
SET IDENTITY_INSERT [dbo].[Academy] OFF
SET IDENTITY_INSERT [dbo].[Classrooms] ON 

INSERT [dbo].[Classrooms] ([Id], [Name], [Status]) VALUES (1, N'Titan', 1)
INSERT [dbo].[Classrooms] ([Id], [Name], [Status]) VALUES (2, N'Merkuri', 1)
INSERT [dbo].[Classrooms] ([Id], [Name], [Status]) VALUES (3, N'Venera', 1)
INSERT [dbo].[Classrooms] ([Id], [Name], [Status]) VALUES (4, N'Yupiter', 1)
INSERT [dbo].[Classrooms] ([Id], [Name], [Status]) VALUES (5, N'Mars', 1)
SET IDENTITY_INSERT [dbo].[Classrooms] OFF
SET IDENTITY_INSERT [dbo].[Educations] ON 

INSERT [dbo].[Educations] ([Id], [Name], [Price], [Status]) VALUES (1, N'Proqramlasdirma', 4900, 1)
INSERT [dbo].[Educations] ([Id], [Name], [Price], [Status]) VALUES (2, N'Web-Dizayn', 4300, 1)
INSERT [dbo].[Educations] ([Id], [Name], [Price], [Status]) VALUES (3, N'Qrafik-Dizayn', 4000, 1)
INSERT [dbo].[Educations] ([Id], [Name], [Price], [Status]) VALUES (4, N'Sistem-Administratoru', 3500, 1)
INSERT [dbo].[Educations] ([Id], [Name], [Price], [Status]) VALUES (5, N'Shebeke', 3000, 1)
SET IDENTITY_INSERT [dbo].[Educations] OFF
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([Id], [Name], [Surname], [Email], [Phone], [Mentor], [PositionId], [StartTime], [Salary], [Status]) VALUES (1, N'Sattar', N'Emrahov', N'amrahov@code.edu.az', N'502111101', N'Nicat Abdullayev', 6, CAST(N'2019-05-28T18:27:58.927' AS DateTime), 3550, 1)
INSERT [dbo].[Employees] ([Id], [Name], [Surname], [Email], [Phone], [Mentor], [PositionId], [StartTime], [Salary], [Status]) VALUES (2, N'Vuqar', N'Sadiqov', N'vuqar@code.edu.az', N'502231401', N'Behruz Semenderov', 6, CAST(N'2019-05-28T18:27:58.927' AS DateTime), 3550, 1)
INSERT [dbo].[Employees] ([Id], [Name], [Surname], [Email], [Phone], [Mentor], [PositionId], [StartTime], [Salary], [Status]) VALUES (3, N'Nermine', N'Abdullayeva', N'nermin@code.edu.az', N'Toghrul Rzayev', N'Toghrul Rzayev', 2, CAST(N'2019-05-28T18:27:58.000' AS DateTime), 1500, 1)
INSERT [dbo].[Employees] ([Id], [Name], [Surname], [Email], [Phone], [Mentor], [PositionId], [StartTime], [Salary], [Status]) VALUES (4, N'Aide', N'Kerimova', N'aida@code.edu.az', N'779901920', N'Murad Bababzade', 3, CAST(N'2019-05-28T18:27:58.927' AS DateTime), 850, 1)
INSERT [dbo].[Employees] ([Id], [Name], [Surname], [Email], [Phone], [Mentor], [PositionId], [StartTime], [Salary], [Status]) VALUES (5, N'Shamil', N'Balaxanov', N'shamil@code.edu.az', N'514443322', N'Ekber Emenov', 1, CAST(N'2019-05-28T18:27:58.927' AS DateTime), 2200, 1)
INSERT [dbo].[Employees] ([Id], [Name], [Surname], [Email], [Phone], [Mentor], [PositionId], [StartTime], [Salary], [Status]) VALUES (6, N'ergfdg', N'thgrth', N'sdfghjgyh@gtdh.dt', N'1234567', N'wsdfgh', 5, CAST(N'2019-11-05T00:00:00.000' AS DateTime), 1234, 0)
SET IDENTITY_INSERT [dbo].[Employees] OFF
SET IDENTITY_INSERT [dbo].[Groups] ON 

INSERT [dbo].[Groups] ([Id], [Name], [ClassroomId], [TeacherId], [MentorId], [Capacity], [EducationProgramId], [Status]) VALUES (1, N'P210', 1, 1, 1, 18, 1, 1)
INSERT [dbo].[Groups] ([Id], [Name], [ClassroomId], [TeacherId], [MentorId], [Capacity], [EducationProgramId], [Status]) VALUES (2, N'P640', 3, 2, 3, 20, 1, 1)
INSERT [dbo].[Groups] ([Id], [Name], [ClassroomId], [TeacherId], [MentorId], [Capacity], [EducationProgramId], [Status]) VALUES (3, N'D433', 2, 5, 5, 16, 2, 1)
INSERT [dbo].[Groups] ([Id], [Name], [ClassroomId], [TeacherId], [MentorId], [Capacity], [EducationProgramId], [Status]) VALUES (4, N'QD231', 4, 2, 2, 20, 3, 0)
INSERT [dbo].[Groups] ([Id], [Name], [ClassroomId], [TeacherId], [MentorId], [Capacity], [EducationProgramId], [Status]) VALUES (7, N'P211', 3, 3, 2, 22, 2, 0)
SET IDENTITY_INSERT [dbo].[Groups] OFF
SET IDENTITY_INSERT [dbo].[Positions] ON 

INSERT [dbo].[Positions] ([Id], [Name], [Status]) VALUES (1, N'CEO', 1)
INSERT [dbo].[Positions] ([Id], [Name], [Status]) VALUES (2, N'Receptionist', 1)
INSERT [dbo].[Positions] ([Id], [Name], [Status]) VALUES (3, N'Cleaner', 1)
INSERT [dbo].[Positions] ([Id], [Name], [Status]) VALUES (4, N'Consultant', 1)
INSERT [dbo].[Positions] ([Id], [Name], [Status]) VALUES (5, N'Mentor', 1)
INSERT [dbo].[Positions] ([Id], [Name], [Status]) VALUES (6, N'IT Tech', 1)
SET IDENTITY_INSERT [dbo].[Positions] OFF
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([Id], [Name], [Surname], [Email], [Phone], [Fee], [GroupId], [Status]) VALUES (1, N'Toghrul', N'Rzayev', N'toghrul@code.edu.az', N'-930', N'3200', 1, 1)
INSERT [dbo].[Students] ([Id], [Name], [Surname], [Email], [Phone], [Fee], [GroupId], [Status]) VALUES (2, N'Ekber', N'Emenov', N'ekber@code.edu.az', N'-444', N'3200', 1, 1)
INSERT [dbo].[Students] ([Id], [Name], [Surname], [Email], [Phone], [Fee], [GroupId], [Status]) VALUES (3, N'Hesen', N'Aliyev', N'hasan@code.edu.az', N'-215', N'4300', 3, 1)
INSERT [dbo].[Students] ([Id], [Name], [Surname], [Email], [Phone], [Fee], [GroupId], [Status]) VALUES (4, N'Shamil', N'Qocayev', N'qocayev@code.edu.az', N'-429', N'4000', 4, 1)
INSERT [dbo].[Students] ([Id], [Name], [Surname], [Email], [Phone], [Fee], [GroupId], [Status]) VALUES (5, N'Lale', N'Hummetova', N'lale@code.edu.az', N'-545', N'3200', 2, 1)
SET IDENTITY_INSERT [dbo].[Students] OFF
SET IDENTITY_INSERT [dbo].[StudentsMarks] ON 

INSERT [dbo].[StudentsMarks] ([Id], [StudentId], [TaskId], [Mark]) VALUES (1, 1, 2, 100)
INSERT [dbo].[StudentsMarks] ([Id], [StudentId], [TaskId], [Mark]) VALUES (3, 5, 1, 90)
INSERT [dbo].[StudentsMarks] ([Id], [StudentId], [TaskId], [Mark]) VALUES (4, 2, 5, 100)
INSERT [dbo].[StudentsMarks] ([Id], [StudentId], [TaskId], [Mark]) VALUES (5, 4, 4, 65)
SET IDENTITY_INSERT [dbo].[StudentsMarks] OFF
SET IDENTITY_INSERT [dbo].[Tasks] ON 

INSERT [dbo].[Tasks] ([Id], [Name], [Deadline], [GroupId], [Status]) VALUES (1, N'Musa Template', CAST(N'2019-05-28T18:27:58.930' AS DateTime), 2, 1)
INSERT [dbo].[Tasks] ([Id], [Name], [Deadline], [GroupId], [Status]) VALUES (2, N'C# Entity', CAST(N'2019-05-28T18:27:58.930' AS DateTime), 1, 1)
INSERT [dbo].[Tasks] ([Id], [Name], [Deadline], [GroupId], [Status]) VALUES (3, N'Nyu-York', CAST(N'2019-05-28T18:27:58.930' AS DateTime), 3, 1)
INSERT [dbo].[Tasks] ([Id], [Name], [Deadline], [GroupId], [Status]) VALUES (4, N'Ev', CAST(N'2019-05-28T18:27:58.930' AS DateTime), 4, 1)
INSERT [dbo].[Tasks] ([Id], [Name], [Deadline], [GroupId], [Status]) VALUES (5, N'Backend Task', CAST(N'2019-05-28T18:27:58.930' AS DateTime), 1, 1)
SET IDENTITY_INSERT [dbo].[Tasks] OFF
SET IDENTITY_INSERT [dbo].[Teachers] ON 

INSERT [dbo].[Teachers] ([Id], [Name], [Surname], [Speciality], [Email], [Phone], [Status]) VALUES (1, N'Sattar', N'Amrahov', N'Komputer Elmleri', N'amrahov@code.edu.az', N'552111101', 1)
INSERT [dbo].[Teachers] ([Id], [Name], [Surname], [Speciality], [Email], [Phone], [Status]) VALUES (2, N'Samir', N'Dadashzade', N'Informasiya texnologiyalari', N'samir@code.edu.az', N'554444312', 1)
INSERT [dbo].[Teachers] ([Id], [Name], [Surname], [Speciality], [Email], [Phone], [Status]) VALUES (3, N'Vuqar', N'Babazade', N'Dizayn', N'vuqarb@code.edu.az', N'516454545', 1)
INSERT [dbo].[Teachers] ([Id], [Name], [Surname], [Speciality], [Email], [Phone], [Status]) VALUES (4, N'Samir', N'Rzazede', N'Qrafik-dizayn', N'rzazede@code.edu.az', N'554312321', 1)
INSERT [dbo].[Teachers] ([Id], [Name], [Surname], [Speciality], [Email], [Phone], [Status]) VALUES (5, N'Yusif', N'Sefirliii', N'Sistem muhendisliyi', N'yusif@code.edu.az', N'777771777', 1)
INSERT [dbo].[Teachers] ([Id], [Name], [Surname], [Speciality], [Email], [Phone], [Status]) VALUES (6, N'Elekber', N'Yasamalli', N'Komputer elmleri', N'elekber@code.edu.az', N'559444455', 0)
SET IDENTITY_INSERT [dbo].[Teachers] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Classroo__737584F63581F21C]    Script Date: 6/2/2019 10:03:09 PM ******/
ALTER TABLE [dbo].[Classrooms] ADD UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Groups__737584F631331E43]    Script Date: 6/2/2019 10:03:09 PM ******/
ALTER TABLE [dbo].[Groups] ADD UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Students__5C7E359E4A9B1BFE]    Script Date: 6/2/2019 10:03:09 PM ******/
ALTER TABLE [dbo].[Students] ADD UNIQUE NONCLUSTERED 
(
	[Phone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Students__A9D1053453999DC0]    Script Date: 6/2/2019 10:03:09 PM ******/
ALTER TABLE [dbo].[Students] ADD UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Teachers__5C7E359EB8A1D40F]    Script Date: 6/2/2019 10:03:09 PM ******/
ALTER TABLE [dbo].[Teachers] ADD UNIQUE NONCLUSTERED 
(
	[Phone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Teachers__A9D105346CF2F4CF]    Script Date: 6/2/2019 10:03:09 PM ******/
ALTER TABLE [dbo].[Teachers] ADD UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Classrooms] ADD  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Educations] ADD  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Employees] ADD  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Groups] ADD  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Positions] ADD  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Students] ADD  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Tasks] ADD  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Teachers] ADD  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [Employees_fk0] FOREIGN KEY([PositionId])
REFERENCES [dbo].[Positions] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [Employees_fk0]
GO
ALTER TABLE [dbo].[Groups]  WITH CHECK ADD  CONSTRAINT [FK_Groups_Classrooms] FOREIGN KEY([ClassroomId])
REFERENCES [dbo].[Classrooms] ([Id])
GO
ALTER TABLE [dbo].[Groups] CHECK CONSTRAINT [FK_Groups_Classrooms]
GO
ALTER TABLE [dbo].[Groups]  WITH CHECK ADD  CONSTRAINT [FK_Groups_Educations] FOREIGN KEY([EducationProgramId])
REFERENCES [dbo].[Educations] ([Id])
GO
ALTER TABLE [dbo].[Groups] CHECK CONSTRAINT [FK_Groups_Educations]
GO
ALTER TABLE [dbo].[Groups]  WITH CHECK ADD  CONSTRAINT [FK_Groups_Employees] FOREIGN KEY([MentorId])
REFERENCES [dbo].[Employees] ([Id])
GO
ALTER TABLE [dbo].[Groups] CHECK CONSTRAINT [FK_Groups_Employees]
GO
ALTER TABLE [dbo].[Groups]  WITH CHECK ADD  CONSTRAINT [FK_Groups_Teachers] FOREIGN KEY([TeacherId])
REFERENCES [dbo].[Teachers] ([Id])
GO
ALTER TABLE [dbo].[Groups] CHECK CONSTRAINT [FK_Groups_Teachers]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Groups] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Groups] ([Id])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Groups]
GO
ALTER TABLE [dbo].[StudentsMarks]  WITH CHECK ADD  CONSTRAINT [StudentsMarks_fk0] FOREIGN KEY([TaskId])
REFERENCES [dbo].[Tasks] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[StudentsMarks] CHECK CONSTRAINT [StudentsMarks_fk0]
GO
ALTER TABLE [dbo].[Tasks]  WITH CHECK ADD  CONSTRAINT [FK_Tasks_Groups] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Groups] ([Id])
GO
ALTER TABLE [dbo].[Tasks] CHECK CONSTRAINT [FK_Tasks_Groups]
GO
USE [master]
GO
ALTER DATABASE [MyAcademy] SET  READ_WRITE 
GO
