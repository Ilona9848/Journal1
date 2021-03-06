USE [master]
GO
/****** Object:  Database [JournalData]    Script Date: 25.05.2020 0:44:06 ******/
CREATE DATABASE [JournalData]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'JournalData', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLSEXPRESS\MSSQL\DATA\JournalData.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'JournalData_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLSEXPRESS\MSSQL\DATA\JournalData_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [JournalData] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [JournalData].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [JournalData] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [JournalData] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [JournalData] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [JournalData] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [JournalData] SET ARITHABORT OFF 
GO
ALTER DATABASE [JournalData] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [JournalData] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [JournalData] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [JournalData] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [JournalData] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [JournalData] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [JournalData] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [JournalData] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [JournalData] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [JournalData] SET  DISABLE_BROKER 
GO
ALTER DATABASE [JournalData] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [JournalData] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [JournalData] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [JournalData] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [JournalData] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [JournalData] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [JournalData] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [JournalData] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [JournalData] SET  MULTI_USER 
GO
ALTER DATABASE [JournalData] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [JournalData] SET DB_CHAINING OFF 
GO
ALTER DATABASE [JournalData] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [JournalData] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [JournalData] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [JournalData] SET QUERY_STORE = OFF
GO
USE [JournalData]
GO
/****** Object:  Table [dbo].[Attendance]    Script Date: 25.05.2020 0:44:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attendance](
	[Id] [uniqueidentifier] NOT NULL,
	[Студент] [uniqueidentifier] NOT NULL,
	[Пара] [int] NOT NULL,
	[Дата] [datetime] NOT NULL,
	[Был] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Classes]    Script Date: 25.05.2020 0:44:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Classes](
	[Пара] [int] NOT NULL,
	[Время начала] [time](7) NOT NULL,
	[Время окончания] [time](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Пара] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Faculties]    Script Date: 25.05.2020 0:44:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Faculties](
	[Id] [uniqueidentifier] NOT NULL,
	[Факультет] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Faculties] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Groups]    Script Date: 25.05.2020 0:44:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Groups](
	[Id] [uniqueidentifier] NOT NULL,
	[Факультет] [uniqueidentifier] NOT NULL,
	[Группа] [int] NOT NULL,
 CONSTRAINT [PK_Groups] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Schedule]    Script Date: 25.05.2020 0:44:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Schedule](
	[Id] [uniqueidentifier] NOT NULL,
	[Неделя] [int] NOT NULL,
	[День_недели] [int] NOT NULL,
	[Пара] [int] NOT NULL,
	[Группа] [uniqueidentifier] NOT NULL,
	[Предмет] [uniqueidentifier] NOT NULL,
	[Тип_занятия] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 25.05.2020 0:44:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Id] [uniqueidentifier] NOT NULL,
	[Факультет] [uniqueidentifier] NOT NULL,
	[Группа] [uniqueidentifier] NOT NULL,
	[Фамилия] [nvarchar](50) NOT NULL,
	[Имя] [nvarchar](50) NOT NULL,
	[Отчество] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 25.05.2020 0:44:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subjects](
	[Id] [uniqueidentifier] NOT NULL,
	[Предмет] [nvarchar](max) NOT NULL,
	[Факультет] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeOfClass]    Script Date: 25.05.2020 0:44:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeOfClass](
	[Id] [int] NOT NULL,
	[Тип занятия] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Week]    Script Date: 25.05.2020 0:44:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Week](
	[Неделя] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Неделя] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Weekday]    Script Date: 25.05.2020 0:44:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Weekday](
	[Id] [int] NOT NULL,
	[День недели] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Attendance] ([Id], [Студент], [Пара], [Дата], [Был]) VALUES (N'd4c36e51-e4c1-472e-9272-27615da0a09a', N'0a30585f-2a0e-45ed-ac5d-13d9d487cf35', 1, CAST(N'2020-05-19T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Attendance] ([Id], [Студент], [Пара], [Дата], [Был]) VALUES (N'63615d81-ef21-439f-ab0f-434c2d32e579', N'0a30585f-2a0e-45ed-ac5d-13d9d487cf35', 1, CAST(N'2020-05-18T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Attendance] ([Id], [Студент], [Пара], [Дата], [Был]) VALUES (N'3ee8d668-f9a5-4405-b6d1-722475321a50', N'10602028-6786-437b-9c12-55e05522179c', 1, CAST(N'2020-05-18T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Attendance] ([Id], [Студент], [Пара], [Дата], [Был]) VALUES (N'2fc6328a-aff6-4fef-b35c-a755b3030eb8', N'0a30585f-2a0e-45ed-ac5d-13d9d487cf35', 2, CAST(N'2020-05-18T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Attendance] ([Id], [Студент], [Пара], [Дата], [Был]) VALUES (N'e3f3d864-1efa-43da-ab34-a9b328f6731f', N'0a30585f-2a0e-45ed-ac5d-13d9d487cf35', 1, CAST(N'2020-05-11T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Attendance] ([Id], [Студент], [Пара], [Дата], [Был]) VALUES (N'9161fea0-20f9-485c-b9fb-b4fd05096378', N'10602028-6786-437b-9c12-55e05522179c', 1, CAST(N'2020-05-11T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Attendance] ([Id], [Студент], [Пара], [Дата], [Был]) VALUES (N'8d838335-faf8-43f3-a203-eca8906835f5', N'10602028-6786-437b-9c12-55e05522179c', 1, CAST(N'2020-05-19T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Attendance] ([Id], [Студент], [Пара], [Дата], [Был]) VALUES (N'7a7f3e54-0047-4ef8-a6f1-f8033cf634b2', N'10602028-6786-437b-9c12-55e05522179c', 3, CAST(N'2020-05-18T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[Classes] ([Пара], [Время начала], [Время окончания]) VALUES (1, CAST(N'09:00:00' AS Time), CAST(N'10:30:00' AS Time))
INSERT [dbo].[Classes] ([Пара], [Время начала], [Время окончания]) VALUES (2, CAST(N'10:40:00' AS Time), CAST(N'12:10:00' AS Time))
INSERT [dbo].[Classes] ([Пара], [Время начала], [Время окончания]) VALUES (3, CAST(N'12:50:00' AS Time), CAST(N'14:20:00' AS Time))
INSERT [dbo].[Classes] ([Пара], [Время начала], [Время окончания]) VALUES (4, CAST(N'14:30:00' AS Time), CAST(N'16:00:00' AS Time))
GO
INSERT [dbo].[Faculties] ([Id], [Факультет]) VALUES (N'1af39104-541e-4b75-a7b7-1266eea1e2eb', N'Физико-технический факультет')
INSERT [dbo].[Faculties] ([Id], [Факультет]) VALUES (N'0d2e1207-2458-48d2-a231-2c3e2e621a61', N'Факультет стоматологии и фармации')
INSERT [dbo].[Faculties] ([Id], [Факультет]) VALUES (N'3fbe644f-9629-4a53-9fff-415063290091', N'Факультет осетинской филологии')
INSERT [dbo].[Faculties] ([Id], [Факультет]) VALUES (N'5cc2f748-6955-494d-bdb7-4a877dde17a7', N'Факультет иностранных языков')
INSERT [dbo].[Faculties] ([Id], [Факультет]) VALUES (N'133882fa-1f33-4d59-942b-9d4c2caa1edd', N'Исторический факультет')
INSERT [dbo].[Faculties] ([Id], [Факультет]) VALUES (N'5712c6ee-72be-4854-84d9-aa0ffa63d02c', N'Юридический факультет')
INSERT [dbo].[Faculties] ([Id], [Факультет]) VALUES (N'f5175e6f-367d-4861-b46f-be6327c246d5', N'Психолого-педагогический факультет')
INSERT [dbo].[Faculties] ([Id], [Факультет]) VALUES (N'4f67ee80-d282-49b2-9839-dd5e384e446f', N'Факультет русской филологии')
INSERT [dbo].[Faculties] ([Id], [Факультет]) VALUES (N'2f6c224f-7586-483c-a935-ebbeaaf80c07', N'Факультет искусств')
INSERT [dbo].[Faculties] ([Id], [Факультет]) VALUES (N'0bd7321e-b2d3-4e1e-8d03-edbca49aa2fd', N'Факультет математики и информационных технологий')
GO
INSERT [dbo].[Groups] ([Id], [Факультет], [Группа]) VALUES (N'b2a2613c-2fa4-4aa8-b7c8-2d11636249fe', N'0d2e1207-2458-48d2-a231-2c3e2e621a61', 201)
INSERT [dbo].[Groups] ([Id], [Факультет], [Группа]) VALUES (N'4e8e2de9-0f2d-46d3-b94e-33f627b81727', N'5cc2f748-6955-494d-bdb7-4a877dde17a7', 11)
INSERT [dbo].[Groups] ([Id], [Факультет], [Группа]) VALUES (N'c78b5478-597d-4517-b07b-890ef850bea0', N'0bd7321e-b2d3-4e1e-8d03-edbca49aa2fd', 12)
INSERT [dbo].[Groups] ([Id], [Факультет], [Группа]) VALUES (N'a8a0fb95-2cb1-44f5-8465-ddf9769e89c1', N'0bd7321e-b2d3-4e1e-8d03-edbca49aa2fd', 11)
INSERT [dbo].[Groups] ([Id], [Факультет], [Группа]) VALUES (N'861843bd-22c5-452f-a32f-f11faabd1cab', N'0bd7321e-b2d3-4e1e-8d03-edbca49aa2fd', 14)
INSERT [dbo].[Groups] ([Id], [Факультет], [Группа]) VALUES (N'8167dc10-64e5-40d3-8e7e-f7681702f711', N'0bd7321e-b2d3-4e1e-8d03-edbca49aa2fd', 13)
GO
INSERT [dbo].[Schedule] ([Id], [Неделя], [День_недели], [Пара], [Группа], [Предмет], [Тип_занятия]) VALUES (N'c0736490-7d59-43dc-9ae9-0ac8c370f57a', 1, 2, 4, N'a8a0fb95-2cb1-44f5-8465-ddf9769e89c1', N'b73b34db-1aa7-4622-8d39-e3578c6ff99d', 1)
INSERT [dbo].[Schedule] ([Id], [Неделя], [День_недели], [Пара], [Группа], [Предмет], [Тип_занятия]) VALUES (N'd406a8e0-960f-4d84-8879-1e3a49ed8179', 1, 1, 1, N'a8a0fb95-2cb1-44f5-8465-ddf9769e89c1', N'16f71db8-88a9-4e2b-9140-ec83ae3d115a', 1)
INSERT [dbo].[Schedule] ([Id], [Неделя], [День_недели], [Пара], [Группа], [Предмет], [Тип_занятия]) VALUES (N'fcd33a6f-f5cd-439a-94ca-96e441643c24', 1, 1, 2, N'a8a0fb95-2cb1-44f5-8465-ddf9769e89c1', N'f5ee79e8-2292-4076-9db2-a380e5f61e21', 3)
INSERT [dbo].[Schedule] ([Id], [Неделя], [День_недели], [Пара], [Группа], [Предмет], [Тип_занятия]) VALUES (N'3ece0f3e-9720-4114-9b98-9ffd2e9ffa1c', 1, 2, 3, N'a8a0fb95-2cb1-44f5-8465-ddf9769e89c1', N'ea900ce6-fd6f-4b6b-b8d6-f4f214bfb8c8', 1)
INSERT [dbo].[Schedule] ([Id], [Неделя], [День_недели], [Пара], [Группа], [Предмет], [Тип_занятия]) VALUES (N'213d875f-93ad-4c8c-9615-a07e3abdfd90', 1, 2, 1, N'a8a0fb95-2cb1-44f5-8465-ddf9769e89c1', N'2d033c10-abd6-4ca8-b36d-87a89de95974', 1)
INSERT [dbo].[Schedule] ([Id], [Неделя], [День_недели], [Пара], [Группа], [Предмет], [Тип_занятия]) VALUES (N'3ab372bb-dd5a-4bb2-9972-c0c9284f1994', 1, 2, 2, N'a8a0fb95-2cb1-44f5-8465-ddf9769e89c1', N'2d033c10-abd6-4ca8-b36d-87a89de95974', 3)
INSERT [dbo].[Schedule] ([Id], [Неделя], [День_недели], [Пара], [Группа], [Предмет], [Тип_занятия]) VALUES (N'577a8e98-ab8d-476a-8b36-da3076c8aaae', 1, 1, 3, N'a8a0fb95-2cb1-44f5-8465-ddf9769e89c1', N'cbdbcc35-7446-438d-8a9c-3e716e37129b', 3)
GO
INSERT [dbo].[Students] ([Id], [Факультет], [Группа], [Фамилия], [Имя], [Отчество]) VALUES (N'0a30585f-2a0e-45ed-ac5d-13d9d487cf35', N'0bd7321e-b2d3-4e1e-8d03-edbca49aa2fd', N'a8a0fb95-2cb1-44f5-8465-ddf9769e89c1', N'Бирагова', N'Людмила', N'Казбековна')
INSERT [dbo].[Students] ([Id], [Факультет], [Группа], [Фамилия], [Имя], [Отчество]) VALUES (N'10602028-6786-437b-9c12-55e05522179c', N'0bd7321e-b2d3-4e1e-8d03-edbca49aa2fd', N'a8a0fb95-2cb1-44f5-8465-ddf9769e89c1', N'Батаев', N'Хетаг', N'Леонидович')
GO
INSERT [dbo].[Subjects] ([Id], [Предмет], [Факультет]) VALUES (N'cbdbcc35-7446-438d-8a9c-3e716e37129b', N'Элективные курсы по физической культуре и спорту', N'0bd7321e-b2d3-4e1e-8d03-edbca49aa2fd')
INSERT [dbo].[Subjects] ([Id], [Предмет], [Факультет]) VALUES (N'2d033c10-abd6-4ca8-b36d-87a89de95974', N'Математический анализ', N'0bd7321e-b2d3-4e1e-8d03-edbca49aa2fd')
INSERT [dbo].[Subjects] ([Id], [Предмет], [Факультет]) VALUES (N'63dd8c31-67c8-4f93-8835-8866222a9dad', N'Математический анализ', N'9849b3d5-568d-40c1-ae75-20140478471d')
INSERT [dbo].[Subjects] ([Id], [Предмет], [Факультет]) VALUES (N'f5ee79e8-2292-4076-9db2-a380e5f61e21', N'Практикум на ПК', N'0bd7321e-b2d3-4e1e-8d03-edbca49aa2fd')
INSERT [dbo].[Subjects] ([Id], [Предмет], [Факультет]) VALUES (N'b73b34db-1aa7-4622-8d39-e3578c6ff99d', N'Физическая культура и спорт', N'0bd7321e-b2d3-4e1e-8d03-edbca49aa2fd')
INSERT [dbo].[Subjects] ([Id], [Предмет], [Факультет]) VALUES (N'1b9a2c79-12c4-442f-a3ec-e8deb4925ac3', N'Алгебра и геометрия', N'9849b3d5-568d-40c1-ae75-20140478471d')
INSERT [dbo].[Subjects] ([Id], [Предмет], [Факультет]) VALUES (N'16f71db8-88a9-4e2b-9140-ec83ae3d115a', N'Основы информатики', N'0bd7321e-b2d3-4e1e-8d03-edbca49aa2fd')
INSERT [dbo].[Subjects] ([Id], [Предмет], [Факультет]) VALUES (N'ea900ce6-fd6f-4b6b-b8d6-f4f214bfb8c8', N'Алгебра и геометрия', N'0bd7321e-b2d3-4e1e-8d03-edbca49aa2fd')
INSERT [dbo].[Subjects] ([Id], [Предмет], [Факультет]) VALUES (N'447de1d6-2dc3-471e-a4ec-fccd607e3a08', N'История России', N'133882fa-1f33-4d59-942b-9d4c2caa1edd')
GO
INSERT [dbo].[TypeOfClass] ([Id], [Тип занятия]) VALUES (1, N'Лекция')
INSERT [dbo].[TypeOfClass] ([Id], [Тип занятия]) VALUES (2, N'Лабороторная')
INSERT [dbo].[TypeOfClass] ([Id], [Тип занятия]) VALUES (3, N'Практическое занятие')
INSERT [dbo].[TypeOfClass] ([Id], [Тип занятия]) VALUES (4, N'Семинар')
GO
INSERT [dbo].[Week] ([Неделя]) VALUES (1)
INSERT [dbo].[Week] ([Неделя]) VALUES (2)
GO
INSERT [dbo].[Weekday] ([Id], [День недели]) VALUES (1, N'Понедельник')
INSERT [dbo].[Weekday] ([Id], [День недели]) VALUES (2, N'Вторник')
INSERT [dbo].[Weekday] ([Id], [День недели]) VALUES (3, N'Среда')
INSERT [dbo].[Weekday] ([Id], [День недели]) VALUES (4, N'Четверг')
INSERT [dbo].[Weekday] ([Id], [День недели]) VALUES (5, N'Пятница')
INSERT [dbo].[Weekday] ([Id], [День недели]) VALUES (6, N'Суббота')
INSERT [dbo].[Weekday] ([Id], [День недели]) VALUES (7, N'Воскресенье')
GO
ALTER TABLE [dbo].[Attendance] ADD  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[Attendance] ADD  DEFAULT ((1)) FOR [Был]
GO
ALTER TABLE [dbo].[Faculties] ADD  CONSTRAINT [DF_Faculties_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[Groups] ADD  CONSTRAINT [DF_Groups_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[Schedule] ADD  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[Students] ADD  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[Subjects] ADD  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[Attendance]  WITH CHECK ADD  CONSTRAINT [FK_Attendance_ToClasses] FOREIGN KEY([Пара])
REFERENCES [dbo].[Classes] ([Пара])
GO
ALTER TABLE [dbo].[Attendance] CHECK CONSTRAINT [FK_Attendance_ToClasses]
GO
ALTER TABLE [dbo].[Attendance]  WITH CHECK ADD  CONSTRAINT [FK_Attendance_ToStudents] FOREIGN KEY([Студент])
REFERENCES [dbo].[Students] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Attendance] CHECK CONSTRAINT [FK_Attendance_ToStudents]
GO
ALTER TABLE [dbo].[Groups]  WITH CHECK ADD  CONSTRAINT [FK_Groups_Faculties] FOREIGN KEY([Факультет])
REFERENCES [dbo].[Faculties] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Groups] CHECK CONSTRAINT [FK_Groups_Faculties]
GO
ALTER TABLE [dbo].[Schedule]  WITH CHECK ADD  CONSTRAINT [FK_Schedule_ToClasses] FOREIGN KEY([Пара])
REFERENCES [dbo].[Classes] ([Пара])
GO
ALTER TABLE [dbo].[Schedule] CHECK CONSTRAINT [FK_Schedule_ToClasses]
GO
ALTER TABLE [dbo].[Schedule]  WITH CHECK ADD  CONSTRAINT [FK_Schedule_ToGroups] FOREIGN KEY([Группа])
REFERENCES [dbo].[Groups] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Schedule] CHECK CONSTRAINT [FK_Schedule_ToGroups]
GO
ALTER TABLE [dbo].[Schedule]  WITH CHECK ADD  CONSTRAINT [FK_Schedule_ToSubjects] FOREIGN KEY([Предмет])
REFERENCES [dbo].[Subjects] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Schedule] CHECK CONSTRAINT [FK_Schedule_ToSubjects]
GO
ALTER TABLE [dbo].[Schedule]  WITH CHECK ADD  CONSTRAINT [FK_Schedule_ToTypeOfClass] FOREIGN KEY([Тип_занятия])
REFERENCES [dbo].[TypeOfClass] ([Id])
GO
ALTER TABLE [dbo].[Schedule] CHECK CONSTRAINT [FK_Schedule_ToTypeOfClass]
GO
ALTER TABLE [dbo].[Schedule]  WITH CHECK ADD  CONSTRAINT [FK_Schedule_ToWeek] FOREIGN KEY([Неделя])
REFERENCES [dbo].[Week] ([Неделя])
GO
ALTER TABLE [dbo].[Schedule] CHECK CONSTRAINT [FK_Schedule_ToWeek]
GO
ALTER TABLE [dbo].[Schedule]  WITH CHECK ADD  CONSTRAINT [FK_Schedule_ToWeekday] FOREIGN KEY([День_недели])
REFERENCES [dbo].[Weekday] ([Id])
GO
ALTER TABLE [dbo].[Schedule] CHECK CONSTRAINT [FK_Schedule_ToWeekday]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_ToFaculties] FOREIGN KEY([Факультет])
REFERENCES [dbo].[Faculties] ([Id])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_ToFaculties]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_ToGroups] FOREIGN KEY([Группа])
REFERENCES [dbo].[Groups] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_ToGroups]
GO
USE [master]
GO
ALTER DATABASE [JournalData] SET  READ_WRITE 
GO
