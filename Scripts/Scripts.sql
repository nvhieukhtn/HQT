USE [master]
GO
/****** Object:  Database [hqt-yes]    Script Date: 6/16/2017 1:18:35 AM ******/
CREATE DATABASE [hqt-yes]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'hqt-yes', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\hqt-yes.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'hqt-yes_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\hqt-yes_log.ldf' , SIZE = 1088KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [hqt-yes] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [hqt-yes].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [hqt-yes] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [hqt-yes] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [hqt-yes] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [hqt-yes] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [hqt-yes] SET ARITHABORT OFF 
GO
ALTER DATABASE [hqt-yes] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [hqt-yes] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [hqt-yes] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [hqt-yes] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [hqt-yes] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [hqt-yes] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [hqt-yes] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [hqt-yes] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [hqt-yes] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [hqt-yes] SET  ENABLE_BROKER 
GO
ALTER DATABASE [hqt-yes] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [hqt-yes] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [hqt-yes] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [hqt-yes] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [hqt-yes] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [hqt-yes] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [hqt-yes] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [hqt-yes] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [hqt-yes] SET  MULTI_USER 
GO
ALTER DATABASE [hqt-yes] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [hqt-yes] SET DB_CHAINING OFF 
GO
ALTER DATABASE [hqt-yes] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [hqt-yes] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [hqt-yes] SET DELAYED_DURABILITY = DISABLED 
GO
USE [hqt-yes]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[CourseId] [uniqueidentifier] NOT NULL,
	[CourseName] [nvarchar](100) NULL,
	[CourseStatus] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Group]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Group](
	[GroupId] [uniqueidentifier] NOT NULL,
	[GroupName] [nvarchar](50) NULL,
	[Leader] [uniqueidentifier] NULL,
	[TopicId] [uniqueidentifier] NULL,
	[ProjectId] [uniqueidentifier] NULL,
	[Capacity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[GroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Group_Student]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Group_Student](
	[GroupId] [uniqueidentifier] NOT NULL,
	[StudentId] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[GroupId] ASC,
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Project]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Project](
	[ProjectId] [uniqueidentifier] NOT NULL,
	[ProjectTypeId] [uniqueidentifier] NULL,
	[ProjectName] [nvarchar](100) NULL,
	[StartRegister] [datetime] NULL,
	[EndRegister] [datetime] NULL,
	[EndSubmit] [datetime] NULL,
	[StudentMax] [int] NULL,
	[CourseId] [uniqueidentifier] NULL,
	[GroupCapacity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProjectType]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectType](
	[ProjectTypeId] [uniqueidentifier] NOT NULL,
	[ProjectTypeName] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[ProjectTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Student_Topic_Project]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student_Topic_Project](
	[StudentId] [uniqueidentifier] NOT NULL,
	[TopicId] [uniqueidentifier] NULL,
	[ProjectId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK__Student___25A48076E1263AB0] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC,
	[ProjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Teacher_Topic_Project]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher_Topic_Project](
	[TeacherId] [uniqueidentifier] NOT NULL,
	[TopicId] [uniqueidentifier] NOT NULL,
	[ProjectId] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TeacherId] ASC,
	[TopicId] ASC,
	[ProjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Topic]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Topic](
	[TopicId] [uniqueidentifier] NOT NULL,
	[Title] [nvarchar](100) NULL,
	[Content] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[TopicId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Topic_Project]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Topic_Project](
	[TopicId] [uniqueidentifier] NOT NULL,
	[ProjectId] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TopicId] ASC,
	[ProjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [uniqueidentifier] NOT NULL,
	[FullName] [nvarchar](50) NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [varchar](100) NULL,
	[UserType] [nvarchar](20) NULL,
	[Status] [int] NULL,
	[Email] [nvarchar](100) NULL,
	[Phone] [varchar](15) NULL,
	[Address] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User_Course]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_Course](
	[UserId] [uniqueidentifier] NOT NULL,
	[CourseId] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Course] ([CourseId], [CourseName], [CourseStatus]) VALUES (N'5e473ade-405f-4e3c-82dc-0394388d88e1', N'Nhập môn Lập trình', 0)
INSERT [dbo].[Course] ([CourseId], [CourseName], [CourseStatus]) VALUES (N'3cd0f5ad-575d-490a-8ab2-0adc2cd5bae2', N'Mạng máy tính', 1)
INSERT [dbo].[Course] ([CourseId], [CourseName], [CourseStatus]) VALUES (N'205b9b50-c670-4c71-8fc9-210d59173ae7', N'Cấu trúc dữ liệu và giải thuật', 0)
INSERT [dbo].[Course] ([CourseId], [CourseName], [CourseStatus]) VALUES (N'da017386-83d2-4451-8cf2-3474c6664c08', N'Lý thuyết đồ thị', 0)
INSERT [dbo].[Course] ([CourseId], [CourseName], [CourseStatus]) VALUES (N'ff42038a-2a2f-49f4-aa4f-556ff35adab4', N'Cơ sở dữ liệu', 0)
INSERT [dbo].[Course] ([CourseId], [CourseName], [CourseStatus]) VALUES (N'c1fb39e7-5e72-4bf8-bc82-88170a8f7ca8', N'Kĩ thuật Lập trình', 0)
INSERT [dbo].[Course] ([CourseId], [CourseName], [CourseStatus]) VALUES (N'1802c7e4-4b35-4383-bba5-8903470cd38c', N'Cơ sở trí tuệ nhân tạo', 0)
INSERT [dbo].[Course] ([CourseId], [CourseName], [CourseStatus]) VALUES (N'4ec02583-44c7-410d-8ec9-e393eaa1ff69', N'Lập trình Hướng đối tượng', 0)
INSERT [dbo].[Course] ([CourseId], [CourseName], [CourseStatus]) VALUES (N'5158f112-0110-4fbc-b0b6-fbda0ee50808', N'Hệ điều hành', 1)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'734006f5-5de6-4cb8-a99b-025fc9c26462', N'Group 34', N'ee07eb0b-3d2a-4547-8a84-5d44482be5cd', N'0328139e-0be2-4978-a189-e9f3f5b6d79d', N'a3029307-6c74-4e8c-991b-1a180e6f1972', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'4c288463-c626-4f2e-b2cd-065237f3f3fa', N'Group 6', N'0a9bae0d-68f7-405f-aa2f-5da3dbc351f8', N'4f6b9f30-e32e-4d52-be71-73d40a20038f', N'd66f509f-3737-4885-becb-3a3fcd7ab1e2', 3)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'1cf190fb-169e-4c8a-9d15-0a52dc38ce7a', N'Group 64', N'0a9bae0d-68f7-405f-aa2f-5da3dbc351f8', N'ef47f342-200b-47a4-9339-1fd8c3b69cd9', N'd66f509f-3737-4885-becb-3a3fcd7ab1e2', 3)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'787c9f5a-af95-4a05-b34b-0d806ea2e462', N'Group 36', N'509d04cb-23b4-4a06-ab6f-44f622d594cd', N'6c7aff62-4390-460c-a83c-acc182313e53', N'c3030f5d-85ab-4894-a675-e59c5acb0189', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'32975625-be97-4278-855d-163a7da3db6c', N'Group 25', N'58011439-e4ee-4016-b54e-899a195e9f1f', N'0856925b-5113-47f3-bf3b-aed86248a771', N'c6a753eb-a0c1-4ec6-9f37-dc21842c8d47', 3)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'998cdf4a-9f55-426c-aa8a-165245ac1a62', N'Group 62', N'eefd4ca5-7d02-4139-81f4-57855741cbb1', N'9a88c39d-af55-4fea-9ecd-608b01e9b5cb', N'10f263c6-ce61-440a-a284-75b625006088', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'5fd8c296-ce2c-4920-a581-16a1b818e50d', N'Group 57', N'ee558c4b-d220-4b0a-83f5-ff621df02800', N'd287bf09-4730-4b2c-be35-7a510b8f8cc7', N'aaf84c01-7826-47e7-a07e-a551092a5b10', 3)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'e1b90d2b-a05f-4e3f-88a1-17f62a2e8928', N'Group 9', N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03', N'bc2ea06d-7ae7-4c5a-9ff1-271592adfa57', N'10f263c6-ce61-440a-a284-75b625006088', 3)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'344f7fa4-1d2f-4ed5-994e-1ae1db7a0541', N'Group 51', N'ee558c4b-d220-4b0a-83f5-ff621df02800', N'bf45e19a-b88e-4344-a39a-fc07b7d3d771', N'6b640835-6fea-4012-8b49-8f9d6fd51b1d', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'ffb85e58-9e56-4b16-b299-1ff0c265ded5', N'Group 22', N'58011439-e4ee-4016-b54e-899a195e9f1f', N'4d221a1b-80bf-4443-918d-a6b5564cd738', N'6b640835-6fea-4012-8b49-8f9d6fd51b1d', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'6c813149-66f2-4c60-b1d3-235d7c442fc6', N'Group 5', N'58011439-e4ee-4016-b54e-899a195e9f1f', N'0328139e-0be2-4978-a189-e9f3f5b6d79d', N'c4fd860c-1365-48e6-a656-4eb1c1a15c19', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'd794d23a-3b8f-4faa-ad29-27ed8ea4f3cf', N'Group 30', N'0a9bae0d-68f7-405f-aa2f-5da3dbc351f8', N'5ab758b6-dd93-4e7b-9ab4-6e2e855b237d', N'0992679e-bef7-4577-b269-5f0267c6b649', 3)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'72bbae83-4fc3-4aa2-a10f-28691e18ef31', N'Group 26', N'58011439-e4ee-4016-b54e-899a195e9f1f', N'96e514c0-0e7c-4ffb-a34b-a670fd1d668f', N'46d80ed4-d8ae-4367-a4bd-1a05455a9dcb', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'6f819740-3fef-488d-b61b-2ac81ab823d6', N'Group 17', N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03', N'bf45e19a-b88e-4344-a39a-fc07b7d3d771', N'6b640835-6fea-4012-8b49-8f9d6fd51b1d', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'2a77ac1c-d147-49af-b02c-2eadc45fc6e0', N'Group 71', N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03', N'9eaf4207-feb9-47dd-b31e-9c269b1cc696', N'161b71d2-e75f-4187-955e-7cd129c5c12b', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'becbe57d-702e-445a-87a2-31659913b5d9', N'Group 18', N'0a9bae0d-68f7-405f-aa2f-5da3dbc351f8', N'89ada340-8131-43f6-bdb2-c43cfa9c6d09', N'ffb21f07-867d-4396-817a-c3b99d4b4b19', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'ada94d78-f505-41d6-9084-334dfa8009b6', N'Group 4', N'ee07eb0b-3d2a-4547-8a84-5d44482be5cd', N'44ad667e-2d11-4f97-a56f-c5ad562c142c', N'f8f92767-c7ab-480e-b9be-3f150e233646', 1)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'5056c160-5c4f-43af-a4b7-39e8f0778c18', N'Group 33', N'eefd4ca5-7d02-4139-81f4-57855741cbb1', N'9eaf4207-feb9-47dd-b31e-9c269b1cc696', N'161b71d2-e75f-4187-955e-7cd129c5c12b', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'03bde93f-f3d8-4ede-ad12-3b3056cbe1c7', N'Group 32', N'509d04cb-23b4-4a06-ab6f-44f622d594cd', N'4f6b9f30-e32e-4d52-be71-73d40a20038f', N'ffb21f07-867d-4396-817a-c3b99d4b4b19', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'6fb949e4-1d13-4e19-a21f-3b7090574573', N'Group 54', N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03', N'5090a2ce-f3b9-4473-9723-0c026c9d0ad0', N'785864a6-d569-4eb7-b67e-0d408f943815', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'aac4ec05-dd00-4f8b-8a98-3bbe13f8f6b4', N'Group 41', N'eefd4ca5-7d02-4139-81f4-57855741cbb1', N'8cb69bbf-e92a-43ea-bf26-d8b001075f98', N'0992679e-bef7-4577-b269-5f0267c6b649', 3)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'a45cc399-9b1c-4b6c-aa8b-3f2c89ea7118', N'Group 60', N'eefd4ca5-7d02-4139-81f4-57855741cbb1', N'84a0a214-f1ab-4941-a32d-07ab34427c39', N'48fd1b40-85f0-48dc-a213-0ffe57fd9261', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'500fb87a-453b-43d8-8d1e-3f69f07d50dc', N'Group 1', N'0a9bae0d-68f7-405f-aa2f-5da3dbc351f8', N'd578137f-343e-464d-8026-47fa46f3729e', N'f8f92767-c7ab-480e-b9be-3f150e233646', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'b325551d-8650-4520-9a20-459f93b06fc9', N'Group 27', N'509d04cb-23b4-4a06-ab6f-44f622d594cd', N'84a0a214-f1ab-4941-a32d-07ab34427c39', N'48fd1b40-85f0-48dc-a213-0ffe57fd9261', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'5e80d2f3-a284-4c88-8b11-49fe83965ac8', N'Group 35', N'eefd4ca5-7d02-4139-81f4-57855741cbb1', N'd578137f-343e-464d-8026-47fa46f3729e', N'f8f92767-c7ab-480e-b9be-3f150e233646', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'076a85c4-11c0-4892-843f-509b53c992ff', N'Group 50', N'eefd4ca5-7d02-4139-81f4-57855741cbb1', N'7cc4887b-35af-4461-b399-65cfcb05fbc5', N'785864a6-d569-4eb7-b67e-0d408f943815', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'8b8e72a8-2e61-4271-ba0c-5180d5731a78', N'Group 65', N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03', N'8e4d71cb-f8a4-46a1-b283-66574696b89a', N'cc3df196-a50c-4dc0-9139-2f1dbc4a531a', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'd840d8ba-ae6f-4f22-88ad-527401a5f951', N'Group 29', N'58011439-e4ee-4016-b54e-899a195e9f1f', N'9a88c39d-af55-4fea-9ecd-608b01e9b5cb', N'10f263c6-ce61-440a-a284-75b625006088', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'cfc7d121-8542-4bce-870f-5517c698f812', N'Group 21', N'ee07eb0b-3d2a-4547-8a84-5d44482be5cd', N'5090a2ce-f3b9-4473-9723-0c026c9d0ad0', N'785864a6-d569-4eb7-b67e-0d408f943815', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'4bbef44e-a061-4265-bc42-5850a6c546b2', N'Group 16', N'ee07eb0b-3d2a-4547-8a84-5d44482be5cd', N'7cc4887b-35af-4461-b399-65cfcb05fbc5', N'785864a6-d569-4eb7-b67e-0d408f943815', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'7f671b2d-d1f0-49b4-80f3-5a17e2487924', N'Group 45', N'509d04cb-23b4-4a06-ab6f-44f622d594cd', N'329af968-811c-4472-bafd-594c738a7419', N'48fd1b40-85f0-48dc-a213-0ffe57fd9261', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'aa7b069f-b33b-481e-843f-616febddb62e', N'Group 13', N'0a9bae0d-68f7-405f-aa2f-5da3dbc351f8', N'4bbb7c4b-e493-4b96-8da3-5680ee8c19c2', N'aaf84c01-7826-47e7-a07e-a551092a5b10', 3)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'056c5878-4d30-4dfa-a2cb-6192725f597e', N'Group 55', N'eefd4ca5-7d02-4139-81f4-57855741cbb1', N'4d221a1b-80bf-4443-918d-a6b5564cd738', N'6b640835-6fea-4012-8b49-8f9d6fd51b1d', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'09707087-74a0-4470-aae2-64851c63cebd', N'Group 43', N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03', N'89ada340-8131-43f6-bdb2-c43cfa9c6d09', N'ffb21f07-867d-4396-817a-c3b99d4b4b19', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'fe3a5888-cac2-4e67-9ef6-6abd918eee24', N'Group 63', N'ee558c4b-d220-4b0a-83f5-ff621df02800', N'5ab758b6-dd93-4e7b-9ab4-6e2e855b237d', N'0992679e-bef7-4577-b269-5f0267c6b649', 3)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'3583c30a-5551-4da0-b837-6c06eed298b5', N'Group 3', N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03', N'9eaf4207-feb9-47dd-b31e-9c269b1cc696', N'8e395894-8286-4452-99b0-e3ab36750c41', 1)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'4f3bd413-eb9d-4377-8f63-6d59ea6d1988', N'Group 2', N'ee558c4b-d220-4b0a-83f5-ff621df02800', N'6c7aff62-4390-460c-a83c-acc182313e53', N'c3030f5d-85ab-4894-a675-e59c5acb0189', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'62f5b813-98b7-46ec-9a70-73815d7b12fc', N'Group 67', N'eefd4ca5-7d02-4139-81f4-57855741cbb1', N'6142ae8d-c045-4d70-a425-72697352e540', N'8e395894-8286-4452-99b0-e3ab36750c41', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'fda566db-124d-4077-8faf-75a609a26630', N'Group 24', N'509d04cb-23b4-4a06-ab6f-44f622d594cd', N'd287bf09-4730-4b2c-be35-7a510b8f8cc7', N'aaf84c01-7826-47e7-a07e-a551092a5b10', 3)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'c402d42b-11b9-4911-876a-76a0ab4f95bc', N'Group 11', N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03', N'329af968-811c-4472-bafd-594c738a7419', N'48fd1b40-85f0-48dc-a213-0ffe57fd9261', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'4c4d1dff-c526-4bc6-a212-7c2a99cc94c2', N'Group 42', N'0a9bae0d-68f7-405f-aa2f-5da3dbc351f8', N'bc2ea06d-7ae7-4c5a-9ff1-271592adfa57', N'10f263c6-ce61-440a-a284-75b625006088', 3)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'e08eaa84-89e6-4c66-8f55-81f6313b7487', N'Group 69', N'eefd4ca5-7d02-4139-81f4-57855741cbb1', N'0328139e-0be2-4978-a189-e9f3f5b6d79d', N'48fd1b40-85f0-48dc-a213-0ffe57fd9261', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'aa0c5d68-dd4a-461d-93c7-834dbc84d060', N'Group 52', N'eefd4ca5-7d02-4139-81f4-57855741cbb1', N'b95c6303-cea2-4947-a753-768d6488eb25', N'ffb21f07-867d-4396-817a-c3b99d4b4b19', 1)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'97e56ee0-73a9-48a0-8722-8784f6f7d67a', N'Group 12', N'509d04cb-23b4-4a06-ab6f-44f622d594cd', N'84468b49-f319-4c4c-88b1-88f9d615ea84', N'46d80ed4-d8ae-4367-a4bd-1a05455a9dcb', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'6ea038d2-d075-4806-86b0-8d143ac71fc1', N'Group 49', N'eefd4ca5-7d02-4139-81f4-57855741cbb1', N'12737839-9abc-4913-b9c9-bc156a59977b', N'c6a753eb-a0c1-4ec6-9f37-dc21842c8d47', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'45bb2675-08f3-4b69-9d78-958af4502c1f', N'Group 53', N'509d04cb-23b4-4a06-ab6f-44f622d594cd', N'a124cc44-ac66-4af0-ab71-d95a48ecffd1', N'6b640835-6fea-4012-8b49-8f9d6fd51b1d', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'333a9f27-4f4c-41ec-ba2d-9962dc25c682', N'Group 37', N'eefd4ca5-7d02-4139-81f4-57855741cbb1', N'9eaf4207-feb9-47dd-b31e-9c269b1cc696', N'8e395894-8286-4452-99b0-e3ab36750c41', 1)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'dc348dd0-5cfe-4ba3-9b11-9a1649f545ad', N'Group 40', N'ee07eb0b-3d2a-4547-8a84-5d44482be5cd', N'cd56b99e-dce2-455e-9f30-c45bcdae5052', N'cc3df196-a50c-4dc0-9139-2f1dbc4a531a', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'8af9552b-7b00-48e5-9208-9abaeeaf3a10', N'Group 46', N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03', N'84468b49-f319-4c4c-88b1-88f9d615ea84', N'46d80ed4-d8ae-4367-a4bd-1a05455a9dcb', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'c6125a22-bea5-4515-ab74-a78e31674414', N'Group 70', N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03', N'4f6b9f30-e32e-4d52-be71-73d40a20038f', N'ffb21f07-867d-4396-817a-c3b99d4b4b19', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'328bf5ea-a46a-4ea5-9b6e-a941425cfc88', N'Group 66', N'ee558c4b-d220-4b0a-83f5-ff621df02800', N'96a2dbf4-e155-4bac-bd7b-3ec169cf31b8', N'c4fd860c-1365-48e6-a656-4eb1c1a15c19', 3)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'5b44a556-778c-4448-bb28-af4bf6520bfa', N'Group 68', N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0', N'd578137f-343e-464d-8026-47fa46f3729e', N'6b640835-6fea-4012-8b49-8f9d6fd51b1d', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'6ce1d804-1b13-469c-9f2b-b5400da8626c', N'Group 20', N'58011439-e4ee-4016-b54e-899a195e9f1f', N'a124cc44-ac66-4af0-ab71-d95a48ecffd1', N'6b640835-6fea-4012-8b49-8f9d6fd51b1d', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'd784ea88-5501-4acf-9cd9-bd21815c3afc', N'Group 39', N'eefd4ca5-7d02-4139-81f4-57855741cbb1', N'4f6b9f30-e32e-4d52-be71-73d40a20038f', N'd66f509f-3737-4885-becb-3a3fcd7ab1e2', 3)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'eb488edc-dbcd-47f3-8099-cac4404c256a', N'Group 58', N'eefd4ca5-7d02-4139-81f4-57855741cbb1', N'0856925b-5113-47f3-bf3b-aed86248a771', N'c6a753eb-a0c1-4ec6-9f37-dc21842c8d47', 3)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'0032a380-97a3-4172-83cc-cd0a1b243798', N'Group 8', N'58011439-e4ee-4016-b54e-899a195e9f1f', N'8cb69bbf-e92a-43ea-bf26-d8b001075f98', N'0992679e-bef7-4577-b269-5f0267c6b649', 3)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'a8f106ee-0ca3-4b9b-bf78-cd13c5d0dd98', N'Group 72', N'0a9bae0d-68f7-405f-aa2f-5da3dbc351f8', N'0328139e-0be2-4978-a189-e9f3f5b6d79d', N'a3029307-6c74-4e8c-991b-1a180e6f1972', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'cbd47523-555a-4c06-b5cc-d004e3542c0d', N'Group 10', N'ee07eb0b-3d2a-4547-8a84-5d44482be5cd', N'3fadb134-dc43-4b71-846d-fb700f938ef0', N'161b71d2-e75f-4187-955e-7cd129c5c12b', 1)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'84b267c3-3f58-4880-8fca-d4bad3c36ae2', N'Group 14', N'58011439-e4ee-4016-b54e-899a195e9f1f', N'80b7fc13-eed7-4d69-addf-bf47a7358c50', N'a3029307-6c74-4e8c-991b-1a180e6f1972', 3)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'e230ada5-289f-4081-a5ca-db7281283492', N'Group 56', N'eefd4ca5-7d02-4139-81f4-57855741cbb1', N'cdff93ee-ee9a-49c3-aafd-53596ec3324a', N'a3029307-6c74-4e8c-991b-1a180e6f1972', 3)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'26a6516e-dc73-4fd3-a3a3-dce4fa69af74', N'Group 47', N'ee07eb0b-3d2a-4547-8a84-5d44482be5cd', N'4bbb7c4b-e493-4b96-8da3-5680ee8c19c2', N'aaf84c01-7826-47e7-a07e-a551092a5b10', 3)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'ef53e83a-1503-46e0-b002-e35735b9b7d3', N'Group 61', N'ee558c4b-d220-4b0a-83f5-ff621df02800', N'ecb1e1a7-546c-4d88-a87d-127a9d57492a', N'161b71d2-e75f-4187-955e-7cd129c5c12b', 1)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'c26e41bd-7a28-4017-9d6b-e4d371460e54', N'Group 28', N'58011439-e4ee-4016-b54e-899a195e9f1f', N'ecb1e1a7-546c-4d88-a87d-127a9d57492a', N'161b71d2-e75f-4187-955e-7cd129c5c12b', 1)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'ce7dd1d8-3933-4223-af1b-eabc0334d56f', N'Group 59', N'0a9bae0d-68f7-405f-aa2f-5da3dbc351f8', N'96e514c0-0e7c-4ffb-a34b-a670fd1d668f', N'46d80ed4-d8ae-4367-a4bd-1a05455a9dcb', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'6996acca-f63b-426a-b92f-eec2131aa5d6', N'Group 44', N'eefd4ca5-7d02-4139-81f4-57855741cbb1', N'3fadb134-dc43-4b71-846d-fb700f938ef0', N'161b71d2-e75f-4187-955e-7cd129c5c12b', 1)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'2c66ddda-85ee-4c22-b248-efeec19dc633', N'Group 19', N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03', N'b95c6303-cea2-4947-a753-768d6488eb25', N'ffb21f07-867d-4396-817a-c3b99d4b4b19', 1)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'2963ed69-611b-4dd5-bcef-f0589b9b845e', N'Group 7', N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03', N'cd56b99e-dce2-455e-9f30-c45bcdae5052', N'cc3df196-a50c-4dc0-9139-2f1dbc4a531a', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'6d911804-b3bf-4e61-9187-f08b473346fd', N'Group 23', N'58011439-e4ee-4016-b54e-899a195e9f1f', N'cdff93ee-ee9a-49c3-aafd-53596ec3324a', N'a3029307-6c74-4e8c-991b-1a180e6f1972', 3)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'763799a3-c4b6-4c09-89cf-f3c70acd4f0a', N'Group 38', N'eefd4ca5-7d02-4139-81f4-57855741cbb1', N'0328139e-0be2-4978-a189-e9f3f5b6d79d', N'c4fd860c-1365-48e6-a656-4eb1c1a15c19', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'c4cfdb0b-a9c3-47eb-92c3-f867faf3215b', N'Group 15', N'ee558c4b-d220-4b0a-83f5-ff621df02800', N'12737839-9abc-4913-b9c9-bc156a59977b', N'c6a753eb-a0c1-4ec6-9f37-dc21842c8d47', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'2ac138d4-3228-4f78-ba85-f9df6bf5a6b1', N'Group 31', N'eefd4ca5-7d02-4139-81f4-57855741cbb1', N'0328139e-0be2-4978-a189-e9f3f5b6d79d', N'48fd1b40-85f0-48dc-a213-0ffe57fd9261', 2)
INSERT [dbo].[Group] ([GroupId], [GroupName], [Leader], [TopicId], [ProjectId], [Capacity]) VALUES (N'400de388-b6c1-4e5e-9034-ff417da12a5c', N'Group 48', N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03', N'80b7fc13-eed7-4d69-addf-bf47a7358c50', N'a3029307-6c74-4e8c-991b-1a180e6f1972', 3)
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'734006f5-5de6-4cb8-a99b-025fc9c26462', N'ee07eb0b-3d2a-4547-8a84-5d44482be5cd')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'734006f5-5de6-4cb8-a99b-025fc9c26462', N'701d350a-5313-4d0b-bf53-e6c089c6dbf2')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'4c288463-c626-4f2e-b2cd-065237f3f3fa', N'0a9bae0d-68f7-405f-aa2f-5da3dbc351f8')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'4c288463-c626-4f2e-b2cd-065237f3f3fa', N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'4c288463-c626-4f2e-b2cd-065237f3f3fa', N'701d350a-5313-4d0b-bf53-e6c089c6dbf2')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'1cf190fb-169e-4c8a-9d15-0a52dc38ce7a', N'0a9bae0d-68f7-405f-aa2f-5da3dbc351f8')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'1cf190fb-169e-4c8a-9d15-0a52dc38ce7a', N'701d350a-5313-4d0b-bf53-e6c089c6dbf2')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'1cf190fb-169e-4c8a-9d15-0a52dc38ce7a', N'677d5c43-2a99-42c0-b452-f651c86c997a')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'787c9f5a-af95-4a05-b34b-0d806ea2e462', N'509d04cb-23b4-4a06-ab6f-44f622d594cd')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'787c9f5a-af95-4a05-b34b-0d806ea2e462', N'677d5c43-2a99-42c0-b452-f651c86c997a')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'32975625-be97-4278-855d-163a7da3db6c', N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'32975625-be97-4278-855d-163a7da3db6c', N'58011439-e4ee-4016-b54e-899a195e9f1f')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'32975625-be97-4278-855d-163a7da3db6c', N'701d350a-5313-4d0b-bf53-e6c089c6dbf2')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'998cdf4a-9f55-426c-aa8a-165245ac1a62', N'eefd4ca5-7d02-4139-81f4-57855741cbb1')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'998cdf4a-9f55-426c-aa8a-165245ac1a62', N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'5fd8c296-ce2c-4920-a581-16a1b818e50d', N'701d350a-5313-4d0b-bf53-e6c089c6dbf2')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'5fd8c296-ce2c-4920-a581-16a1b818e50d', N'677d5c43-2a99-42c0-b452-f651c86c997a')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'5fd8c296-ce2c-4920-a581-16a1b818e50d', N'ee558c4b-d220-4b0a-83f5-ff621df02800')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'e1b90d2b-a05f-4e3f-88a1-17f62a2e8928', N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'e1b90d2b-a05f-4e3f-88a1-17f62a2e8928', N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'e1b90d2b-a05f-4e3f-88a1-17f62a2e8928', N'701d350a-5313-4d0b-bf53-e6c089c6dbf2')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'344f7fa4-1d2f-4ed5-994e-1ae1db7a0541', N'677d5c43-2a99-42c0-b452-f651c86c997a')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'344f7fa4-1d2f-4ed5-994e-1ae1db7a0541', N'ee558c4b-d220-4b0a-83f5-ff621df02800')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'ffb85e58-9e56-4b16-b299-1ff0c265ded5', N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'ffb85e58-9e56-4b16-b299-1ff0c265ded5', N'58011439-e4ee-4016-b54e-899a195e9f1f')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'6c813149-66f2-4c60-b1d3-235d7c442fc6', N'58011439-e4ee-4016-b54e-899a195e9f1f')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'6c813149-66f2-4c60-b1d3-235d7c442fc6', N'677d5c43-2a99-42c0-b452-f651c86c997a')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'd794d23a-3b8f-4faa-ad29-27ed8ea4f3cf', N'0a9bae0d-68f7-405f-aa2f-5da3dbc351f8')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'd794d23a-3b8f-4faa-ad29-27ed8ea4f3cf', N'701d350a-5313-4d0b-bf53-e6c089c6dbf2')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'd794d23a-3b8f-4faa-ad29-27ed8ea4f3cf', N'677d5c43-2a99-42c0-b452-f651c86c997a')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'72bbae83-4fc3-4aa2-a10f-28691e18ef31', N'58011439-e4ee-4016-b54e-899a195e9f1f')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'72bbae83-4fc3-4aa2-a10f-28691e18ef31', N'677d5c43-2a99-42c0-b452-f651c86c997a')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'6f819740-3fef-488d-b61b-2ac81ab823d6', N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'6f819740-3fef-488d-b61b-2ac81ab823d6', N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'2a77ac1c-d147-49af-b02c-2eadc45fc6e0', N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'2a77ac1c-d147-49af-b02c-2eadc45fc6e0', N'677d5c43-2a99-42c0-b452-f651c86c997a')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'becbe57d-702e-445a-87a2-31659913b5d9', N'0a9bae0d-68f7-405f-aa2f-5da3dbc351f8')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'becbe57d-702e-445a-87a2-31659913b5d9', N'677d5c43-2a99-42c0-b452-f651c86c997a')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'ada94d78-f505-41d6-9084-334dfa8009b6', N'ee07eb0b-3d2a-4547-8a84-5d44482be5cd')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'5056c160-5c4f-43af-a4b7-39e8f0778c18', N'eefd4ca5-7d02-4139-81f4-57855741cbb1')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'5056c160-5c4f-43af-a4b7-39e8f0778c18', N'677d5c43-2a99-42c0-b452-f651c86c997a')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'03bde93f-f3d8-4ede-ad12-3b3056cbe1c7', N'509d04cb-23b4-4a06-ab6f-44f622d594cd')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'03bde93f-f3d8-4ede-ad12-3b3056cbe1c7', N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'6fb949e4-1d13-4e19-a21f-3b7090574573', N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'6fb949e4-1d13-4e19-a21f-3b7090574573', N'701d350a-5313-4d0b-bf53-e6c089c6dbf2')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'aac4ec05-dd00-4f8b-8a98-3bbe13f8f6b4', N'eefd4ca5-7d02-4139-81f4-57855741cbb1')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'aac4ec05-dd00-4f8b-8a98-3bbe13f8f6b4', N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'aac4ec05-dd00-4f8b-8a98-3bbe13f8f6b4', N'701d350a-5313-4d0b-bf53-e6c089c6dbf2')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'a45cc399-9b1c-4b6c-aa8b-3f2c89ea7118', N'eefd4ca5-7d02-4139-81f4-57855741cbb1')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'a45cc399-9b1c-4b6c-aa8b-3f2c89ea7118', N'701d350a-5313-4d0b-bf53-e6c089c6dbf2')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'500fb87a-453b-43d8-8d1e-3f69f07d50dc', N'0a9bae0d-68f7-405f-aa2f-5da3dbc351f8')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'500fb87a-453b-43d8-8d1e-3f69f07d50dc', N'701d350a-5313-4d0b-bf53-e6c089c6dbf2')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'b325551d-8650-4520-9a20-459f93b06fc9', N'509d04cb-23b4-4a06-ab6f-44f622d594cd')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'b325551d-8650-4520-9a20-459f93b06fc9', N'701d350a-5313-4d0b-bf53-e6c089c6dbf2')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'5e80d2f3-a284-4c88-8b11-49fe83965ac8', N'eefd4ca5-7d02-4139-81f4-57855741cbb1')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'5e80d2f3-a284-4c88-8b11-49fe83965ac8', N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'076a85c4-11c0-4892-843f-509b53c992ff', N'eefd4ca5-7d02-4139-81f4-57855741cbb1')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'076a85c4-11c0-4892-843f-509b53c992ff', N'677d5c43-2a99-42c0-b452-f651c86c997a')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'8b8e72a8-2e61-4271-ba0c-5180d5731a78', N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'8b8e72a8-2e61-4271-ba0c-5180d5731a78', N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'd840d8ba-ae6f-4f22-88ad-527401a5f951', N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'd840d8ba-ae6f-4f22-88ad-527401a5f951', N'58011439-e4ee-4016-b54e-899a195e9f1f')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'cfc7d121-8542-4bce-870f-5517c698f812', N'ee07eb0b-3d2a-4547-8a84-5d44482be5cd')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'cfc7d121-8542-4bce-870f-5517c698f812', N'701d350a-5313-4d0b-bf53-e6c089c6dbf2')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'4bbef44e-a061-4265-bc42-5850a6c546b2', N'ee07eb0b-3d2a-4547-8a84-5d44482be5cd')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'4bbef44e-a061-4265-bc42-5850a6c546b2', N'701d350a-5313-4d0b-bf53-e6c089c6dbf2')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'7f671b2d-d1f0-49b4-80f3-5a17e2487924', N'509d04cb-23b4-4a06-ab6f-44f622d594cd')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'7f671b2d-d1f0-49b4-80f3-5a17e2487924', N'701d350a-5313-4d0b-bf53-e6c089c6dbf2')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'aa7b069f-b33b-481e-843f-616febddb62e', N'0a9bae0d-68f7-405f-aa2f-5da3dbc351f8')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'aa7b069f-b33b-481e-843f-616febddb62e', N'701d350a-5313-4d0b-bf53-e6c089c6dbf2')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'056c5878-4d30-4dfa-a2cb-6192725f597e', N'eefd4ca5-7d02-4139-81f4-57855741cbb1')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'056c5878-4d30-4dfa-a2cb-6192725f597e', N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'09707087-74a0-4470-aae2-64851c63cebd', N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'09707087-74a0-4470-aae2-64851c63cebd', N'677d5c43-2a99-42c0-b452-f651c86c997a')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'fe3a5888-cac2-4e67-9ef6-6abd918eee24', N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'fe3a5888-cac2-4e67-9ef6-6abd918eee24', N'677d5c43-2a99-42c0-b452-f651c86c997a')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'fe3a5888-cac2-4e67-9ef6-6abd918eee24', N'ee558c4b-d220-4b0a-83f5-ff621df02800')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'3583c30a-5551-4da0-b837-6c06eed298b5', N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'4f3bd413-eb9d-4377-8f63-6d59ea6d1988', N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'4f3bd413-eb9d-4377-8f63-6d59ea6d1988', N'ee558c4b-d220-4b0a-83f5-ff621df02800')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'62f5b813-98b7-46ec-9a70-73815d7b12fc', N'eefd4ca5-7d02-4139-81f4-57855741cbb1')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'62f5b813-98b7-46ec-9a70-73815d7b12fc', N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'fda566db-124d-4077-8faf-75a609a26630', N'509d04cb-23b4-4a06-ab6f-44f622d594cd')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'fda566db-124d-4077-8faf-75a609a26630', N'701d350a-5313-4d0b-bf53-e6c089c6dbf2')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'fda566db-124d-4077-8faf-75a609a26630', N'677d5c43-2a99-42c0-b452-f651c86c997a')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'c402d42b-11b9-4911-876a-76a0ab4f95bc', N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'c402d42b-11b9-4911-876a-76a0ab4f95bc', N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'4c4d1dff-c526-4bc6-a212-7c2a99cc94c2', N'0a9bae0d-68f7-405f-aa2f-5da3dbc351f8')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'4c4d1dff-c526-4bc6-a212-7c2a99cc94c2', N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'4c4d1dff-c526-4bc6-a212-7c2a99cc94c2', N'677d5c43-2a99-42c0-b452-f651c86c997a')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'e08eaa84-89e6-4c66-8f55-81f6313b7487', N'eefd4ca5-7d02-4139-81f4-57855741cbb1')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'e08eaa84-89e6-4c66-8f55-81f6313b7487', N'701d350a-5313-4d0b-bf53-e6c089c6dbf2')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'aa0c5d68-dd4a-461d-93c7-834dbc84d060', N'eefd4ca5-7d02-4139-81f4-57855741cbb1')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'97e56ee0-73a9-48a0-8722-8784f6f7d67a', N'509d04cb-23b4-4a06-ab6f-44f622d594cd')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'97e56ee0-73a9-48a0-8722-8784f6f7d67a', N'677d5c43-2a99-42c0-b452-f651c86c997a')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'6ea038d2-d075-4806-86b0-8d143ac71fc1', N'eefd4ca5-7d02-4139-81f4-57855741cbb1')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'6ea038d2-d075-4806-86b0-8d143ac71fc1', N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'45bb2675-08f3-4b69-9d78-958af4502c1f', N'509d04cb-23b4-4a06-ab6f-44f622d594cd')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'45bb2675-08f3-4b69-9d78-958af4502c1f', N'677d5c43-2a99-42c0-b452-f651c86c997a')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'333a9f27-4f4c-41ec-ba2d-9962dc25c682', N'eefd4ca5-7d02-4139-81f4-57855741cbb1')
GO
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'dc348dd0-5cfe-4ba3-9b11-9a1649f545ad', N'ee07eb0b-3d2a-4547-8a84-5d44482be5cd')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'dc348dd0-5cfe-4ba3-9b11-9a1649f545ad', N'677d5c43-2a99-42c0-b452-f651c86c997a')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'8af9552b-7b00-48e5-9208-9abaeeaf3a10', N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'8af9552b-7b00-48e5-9208-9abaeeaf3a10', N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'c6125a22-bea5-4515-ab74-a78e31674414', N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'c6125a22-bea5-4515-ab74-a78e31674414', N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'328bf5ea-a46a-4ea5-9b6e-a941425cfc88', N'701d350a-5313-4d0b-bf53-e6c089c6dbf2')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'328bf5ea-a46a-4ea5-9b6e-a941425cfc88', N'677d5c43-2a99-42c0-b452-f651c86c997a')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'328bf5ea-a46a-4ea5-9b6e-a941425cfc88', N'ee558c4b-d220-4b0a-83f5-ff621df02800')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'5b44a556-778c-4448-bb28-af4bf6520bfa', N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'5b44a556-778c-4448-bb28-af4bf6520bfa', N'677d5c43-2a99-42c0-b452-f651c86c997a')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'6ce1d804-1b13-469c-9f2b-b5400da8626c', N'58011439-e4ee-4016-b54e-899a195e9f1f')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'6ce1d804-1b13-469c-9f2b-b5400da8626c', N'677d5c43-2a99-42c0-b452-f651c86c997a')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'd784ea88-5501-4acf-9cd9-bd21815c3afc', N'eefd4ca5-7d02-4139-81f4-57855741cbb1')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'd784ea88-5501-4acf-9cd9-bd21815c3afc', N'701d350a-5313-4d0b-bf53-e6c089c6dbf2')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'd784ea88-5501-4acf-9cd9-bd21815c3afc', N'677d5c43-2a99-42c0-b452-f651c86c997a')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'eb488edc-dbcd-47f3-8099-cac4404c256a', N'eefd4ca5-7d02-4139-81f4-57855741cbb1')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'eb488edc-dbcd-47f3-8099-cac4404c256a', N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'eb488edc-dbcd-47f3-8099-cac4404c256a', N'701d350a-5313-4d0b-bf53-e6c089c6dbf2')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'0032a380-97a3-4172-83cc-cd0a1b243798', N'58011439-e4ee-4016-b54e-899a195e9f1f')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'0032a380-97a3-4172-83cc-cd0a1b243798', N'701d350a-5313-4d0b-bf53-e6c089c6dbf2')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'0032a380-97a3-4172-83cc-cd0a1b243798', N'677d5c43-2a99-42c0-b452-f651c86c997a')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'a8f106ee-0ca3-4b9b-bf78-cd13c5d0dd98', N'0a9bae0d-68f7-405f-aa2f-5da3dbc351f8')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'a8f106ee-0ca3-4b9b-bf78-cd13c5d0dd98', N'701d350a-5313-4d0b-bf53-e6c089c6dbf2')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'cbd47523-555a-4c06-b5cc-d004e3542c0d', N'ee07eb0b-3d2a-4547-8a84-5d44482be5cd')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'84b267c3-3f58-4880-8fca-d4bad3c36ae2', N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'84b267c3-3f58-4880-8fca-d4bad3c36ae2', N'58011439-e4ee-4016-b54e-899a195e9f1f')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'e230ada5-289f-4081-a5ca-db7281283492', N'eefd4ca5-7d02-4139-81f4-57855741cbb1')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'e230ada5-289f-4081-a5ca-db7281283492', N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'e230ada5-289f-4081-a5ca-db7281283492', N'677d5c43-2a99-42c0-b452-f651c86c997a')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'26a6516e-dc73-4fd3-a3a3-dce4fa69af74', N'ee07eb0b-3d2a-4547-8a84-5d44482be5cd')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'26a6516e-dc73-4fd3-a3a3-dce4fa69af74', N'701d350a-5313-4d0b-bf53-e6c089c6dbf2')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'26a6516e-dc73-4fd3-a3a3-dce4fa69af74', N'677d5c43-2a99-42c0-b452-f651c86c997a')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'ef53e83a-1503-46e0-b002-e35735b9b7d3', N'ee558c4b-d220-4b0a-83f5-ff621df02800')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'c26e41bd-7a28-4017-9d6b-e4d371460e54', N'58011439-e4ee-4016-b54e-899a195e9f1f')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'ce7dd1d8-3933-4223-af1b-eabc0334d56f', N'0a9bae0d-68f7-405f-aa2f-5da3dbc351f8')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'ce7dd1d8-3933-4223-af1b-eabc0334d56f', N'677d5c43-2a99-42c0-b452-f651c86c997a')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'6996acca-f63b-426a-b92f-eec2131aa5d6', N'eefd4ca5-7d02-4139-81f4-57855741cbb1')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'2c66ddda-85ee-4c22-b248-efeec19dc633', N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'2963ed69-611b-4dd5-bcef-f0589b9b845e', N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'2963ed69-611b-4dd5-bcef-f0589b9b845e', N'677d5c43-2a99-42c0-b452-f651c86c997a')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'6d911804-b3bf-4e61-9187-f08b473346fd', N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'6d911804-b3bf-4e61-9187-f08b473346fd', N'58011439-e4ee-4016-b54e-899a195e9f1f')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'6d911804-b3bf-4e61-9187-f08b473346fd', N'677d5c43-2a99-42c0-b452-f651c86c997a')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'763799a3-c4b6-4c09-89cf-f3c70acd4f0a', N'eefd4ca5-7d02-4139-81f4-57855741cbb1')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'763799a3-c4b6-4c09-89cf-f3c70acd4f0a', N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'c4cfdb0b-a9c3-47eb-92c3-f867faf3215b', N'677d5c43-2a99-42c0-b452-f651c86c997a')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'c4cfdb0b-a9c3-47eb-92c3-f867faf3215b', N'ee558c4b-d220-4b0a-83f5-ff621df02800')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'2ac138d4-3228-4f78-ba85-f9df6bf5a6b1', N'eefd4ca5-7d02-4139-81f4-57855741cbb1')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'2ac138d4-3228-4f78-ba85-f9df6bf5a6b1', N'701d350a-5313-4d0b-bf53-e6c089c6dbf2')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'400de388-b6c1-4e5e-9034-ff417da12a5c', N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'400de388-b6c1-4e5e-9034-ff417da12a5c', N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03')
INSERT [dbo].[Group_Student] ([GroupId], [StudentId]) VALUES (N'400de388-b6c1-4e5e-9034-ff417da12a5c', N'701d350a-5313-4d0b-bf53-e6c089c6dbf2')
INSERT [dbo].[Project] ([ProjectId], [ProjectTypeId], [ProjectName], [StartRegister], [EndRegister], [EndSubmit], [StudentMax], [CourseId], [GroupCapacity]) VALUES (N'785864a6-d569-4eb7-b67e-0d408f943815', N'e5debcf3-fbd1-4f9f-9f92-b50872a29c5f', N'Tank', CAST(N'2017-01-12 00:00:00.000' AS DateTime), CAST(N'2017-01-14 00:00:00.000' AS DateTime), CAST(N'2017-05-12 00:00:00.000' AS DateTime), 2, N'da017386-83d2-4451-8cf2-3474c6664c08', 20)
INSERT [dbo].[Project] ([ProjectId], [ProjectTypeId], [ProjectName], [StartRegister], [EndRegister], [EndSubmit], [StudentMax], [CourseId], [GroupCapacity]) VALUES (N'48fd1b40-85f0-48dc-a213-0ffe57fd9261', N'12594590-80f4-49bc-8b21-8ca098c7ef30', N'Lego', CAST(N'2017-01-02 00:00:00.000' AS DateTime), CAST(N'2017-01-04 00:00:00.000' AS DateTime), CAST(N'2017-05-02 00:00:00.000' AS DateTime), 2, N'1802c7e4-4b35-4383-bba5-8903470cd38c', 20)
INSERT [dbo].[Project] ([ProjectId], [ProjectTypeId], [ProjectName], [StartRegister], [EndRegister], [EndSubmit], [StudentMax], [CourseId], [GroupCapacity]) VALUES (N'4d907126-a309-4e9c-985e-13b3088b9800', N'79662735-c20d-43b1-8773-63c47f76e72d', N'Dijkstra', CAST(N'2017-01-08 00:00:00.000' AS DateTime), CAST(N'2017-01-10 00:00:00.000' AS DateTime), CAST(N'2017-05-08 00:00:00.000' AS DateTime), 1, N'da017386-83d2-4451-8cf2-3474c6664c08', 20)
INSERT [dbo].[Project] ([ProjectId], [ProjectTypeId], [ProjectName], [StartRegister], [EndRegister], [EndSubmit], [StudentMax], [CourseId], [GroupCapacity]) VALUES (N'46d80ed4-d8ae-4367-a4bd-1a05455a9dcb', N'e5debcf3-fbd1-4f9f-9f92-b50872a29c5f', N'Lọc thư spam', CAST(N'2017-01-03 00:00:00.000' AS DateTime), CAST(N'2017-01-05 00:00:00.000' AS DateTime), CAST(N'2017-05-03 00:00:00.000' AS DateTime), 3, N'1802c7e4-4b35-4383-bba5-8903470cd38c', 20)
INSERT [dbo].[Project] ([ProjectId], [ProjectTypeId], [ProjectName], [StartRegister], [EndRegister], [EndSubmit], [StudentMax], [CourseId], [GroupCapacity]) VALUES (N'a3029307-6c74-4e8c-991b-1a180e6f1972', N'e5debcf3-fbd1-4f9f-9f92-b50872a29c5f', N'Thuật toán nén Huffman', CAST(N'2017-01-07 00:00:00.000' AS DateTime), CAST(N'2017-01-09 00:00:00.000' AS DateTime), CAST(N'2017-05-07 00:00:00.000' AS DateTime), 3, N'205b9b50-c670-4c71-8fc9-210d59173ae7', 20)
INSERT [dbo].[Project] ([ProjectId], [ProjectTypeId], [ProjectName], [StartRegister], [EndRegister], [EndSubmit], [StudentMax], [CourseId], [GroupCapacity]) VALUES (N'cc3df196-a50c-4dc0-9139-2f1dbc4a531a', N'e5debcf3-fbd1-4f9f-9f92-b50872a29c5f', N'OOP - Game Cờ tỷ phú', CAST(N'2017-01-07 00:00:00.000' AS DateTime), CAST(N'2017-01-09 00:00:00.000' AS DateTime), CAST(N'2017-05-07 00:00:00.000' AS DateTime), 2, N'4ec02583-44c7-410d-8ec9-e393eaa1ff69', 20)
INSERT [dbo].[Project] ([ProjectId], [ProjectTypeId], [ProjectName], [StartRegister], [EndRegister], [EndSubmit], [StudentMax], [CourseId], [GroupCapacity]) VALUES (N'd66f509f-3737-4885-becb-3a3fcd7ab1e2', N'e5debcf3-fbd1-4f9f-9f92-b50872a29c5f', N'Quản lý thư viện', CAST(N'2017-01-08 00:00:00.000' AS DateTime), CAST(N'2017-01-10 00:00:00.000' AS DateTime), CAST(N'2017-05-08 00:00:00.000' AS DateTime), 4, N'ff42038a-2a2f-49f4-aa4f-556ff35adab4', 20)
INSERT [dbo].[Project] ([ProjectId], [ProjectTypeId], [ProjectName], [StartRegister], [EndRegister], [EndSubmit], [StudentMax], [CourseId], [GroupCapacity]) VALUES (N'f8f92767-c7ab-480e-b9be-3f150e233646', N'12594590-80f4-49bc-8b21-8ca098c7ef30', N'Giải phương trình bậc 2', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-03 00:00:00.000' AS DateTime), CAST(N'2017-05-01 00:00:00.000' AS DateTime), 2, N'5e473ade-405f-4e3c-82dc-0394388d88e1', 20)
INSERT [dbo].[Project] ([ProjectId], [ProjectTypeId], [ProjectName], [StartRegister], [EndRegister], [EndSubmit], [StudentMax], [CourseId], [GroupCapacity]) VALUES (N'c4fd860c-1365-48e6-a656-4eb1c1a15c19', N'e5debcf3-fbd1-4f9f-9f92-b50872a29c5f', N'Game Cờ tỷ phú nâng cao', CAST(N'2017-01-05 00:00:00.000' AS DateTime), CAST(N'2017-01-07 00:00:00.000' AS DateTime), CAST(N'2017-05-05 00:00:00.000' AS DateTime), 3, N'c1fb39e7-5e72-4bf8-bc82-88170a8f7ca8', 20)
INSERT [dbo].[Project] ([ProjectId], [ProjectTypeId], [ProjectName], [StartRegister], [EndRegister], [EndSubmit], [StudentMax], [CourseId], [GroupCapacity]) VALUES (N'0992679e-bef7-4577-b269-5f0267c6b649', N'12594590-80f4-49bc-8b21-8ca098c7ef30', N'Lập trình socket', CAST(N'2017-01-10 00:00:00.000' AS DateTime), CAST(N'2017-01-12 00:00:00.000' AS DateTime), CAST(N'2017-05-10 00:00:00.000' AS DateTime), 3, N'3cd0f5ad-575d-490a-8ab2-0adc2cd5bae2', 20)
INSERT [dbo].[Project] ([ProjectId], [ProjectTypeId], [ProjectName], [StartRegister], [EndRegister], [EndSubmit], [StudentMax], [CourseId], [GroupCapacity]) VALUES (N'10f263c6-ce61-440a-a284-75b625006088', N'e5debcf3-fbd1-4f9f-9f92-b50872a29c5f', N'Lập trình socket 2', CAST(N'2017-01-11 00:00:00.000' AS DateTime), CAST(N'2017-01-13 00:00:00.000' AS DateTime), CAST(N'2017-05-11 00:00:00.000' AS DateTime), 3, N'3cd0f5ad-575d-490a-8ab2-0adc2cd5bae2', 20)
INSERT [dbo].[Project] ([ProjectId], [ProjectTypeId], [ProjectName], [StartRegister], [EndRegister], [EndSubmit], [StudentMax], [CourseId], [GroupCapacity]) VALUES (N'161b71d2-e75f-4187-955e-7cd129c5c12b', N'e5debcf3-fbd1-4f9f-9f92-b50872a29c5f', N'Nachos Nâng cao', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-03 00:00:00.000' AS DateTime), CAST(N'2017-05-01 00:00:00.000' AS DateTime), 2, N'5158f112-0110-4fbc-b0b6-fbda0ee50808', 20)
INSERT [dbo].[Project] ([ProjectId], [ProjectTypeId], [ProjectName], [StartRegister], [EndRegister], [EndSubmit], [StudentMax], [CourseId], [GroupCapacity]) VALUES (N'5c53f74f-e090-4b65-bc40-7dc4a6bb07c6', N'12594590-80f4-49bc-8b21-8ca098c7ef30', N'Nachos', CAST(N'2017-01-12 00:00:00.000' AS DateTime), CAST(N'2017-01-14 00:00:00.000' AS DateTime), CAST(N'2017-05-12 00:00:00.000' AS DateTime), 1, N'5158f112-0110-4fbc-b0b6-fbda0ee50808', 20)
INSERT [dbo].[Project] ([ProjectId], [ProjectTypeId], [ProjectName], [StartRegister], [EndRegister], [EndSubmit], [StudentMax], [CourseId], [GroupCapacity]) VALUES (N'97e42478-a574-4589-9394-8d41ec756b1d', N'79662735-c20d-43b1-8773-63c47f76e72d', N'Wireshark', CAST(N'2017-01-09 00:00:00.000' AS DateTime), CAST(N'2017-01-11 00:00:00.000' AS DateTime), CAST(N'2017-05-09 00:00:00.000' AS DateTime), 1, N'3cd0f5ad-575d-490a-8ab2-0adc2cd5bae2', 20)
INSERT [dbo].[Project] ([ProjectId], [ProjectTypeId], [ProjectName], [StartRegister], [EndRegister], [EndSubmit], [StudentMax], [CourseId], [GroupCapacity]) VALUES (N'6b640835-6fea-4012-8b49-8f9d6fd51b1d', N'79662735-c20d-43b1-8773-63c47f76e72d', N'Bài toán tô màu', CAST(N'2017-01-09 00:00:00.000' AS DateTime), CAST(N'2017-01-11 00:00:00.000' AS DateTime), CAST(N'2017-05-09 00:00:00.000' AS DateTime), 2, N'da017386-83d2-4451-8cf2-3474c6664c08', 20)
INSERT [dbo].[Project] ([ProjectId], [ProjectTypeId], [ProjectName], [StartRegister], [EndRegister], [EndSubmit], [StudentMax], [CourseId], [GroupCapacity]) VALUES (N'aaf84c01-7826-47e7-a07e-a551092a5b10', N'79662735-c20d-43b1-8773-63c47f76e72d', N'Cây', CAST(N'2017-01-06 00:00:00.000' AS DateTime), CAST(N'2017-01-08 00:00:00.000' AS DateTime), CAST(N'2017-05-06 00:00:00.000' AS DateTime), 3, N'205b9b50-c670-4c71-8fc9-210d59173ae7', 20)
INSERT [dbo].[Project] ([ProjectId], [ProjectTypeId], [ProjectName], [StartRegister], [EndRegister], [EndSubmit], [StudentMax], [CourseId], [GroupCapacity]) VALUES (N'5dbd1b7e-741a-487d-a013-a6a45cf39ba2', N'12594590-80f4-49bc-8b21-8ca098c7ef30', N'Dijkstra Heap', CAST(N'2017-01-10 00:00:00.000' AS DateTime), CAST(N'2017-01-12 00:00:00.000' AS DateTime), CAST(N'2017-05-10 00:00:00.000' AS DateTime), 1, N'da017386-83d2-4451-8cf2-3474c6664c08', 20)
INSERT [dbo].[Project] ([ProjectId], [ProjectTypeId], [ProjectName], [StartRegister], [EndRegister], [EndSubmit], [StudentMax], [CourseId], [GroupCapacity]) VALUES (N'ffb21f07-867d-4396-817a-c3b99d4b4b19', N'79662735-c20d-43b1-8773-63c47f76e72d', N'Cây khung', CAST(N'2017-01-11 00:00:00.000' AS DateTime), CAST(N'2017-01-13 00:00:00.000' AS DateTime), CAST(N'2017-05-11 00:00:00.000' AS DateTime), 2, N'da017386-83d2-4451-8cf2-3474c6664c08', 20)
INSERT [dbo].[Project] ([ProjectId], [ProjectTypeId], [ProjectName], [StartRegister], [EndRegister], [EndSubmit], [StudentMax], [CourseId], [GroupCapacity]) VALUES (N'7d7f957e-2c01-41fa-98d1-c59ba342ad45', N'79662735-c20d-43b1-8773-63c47f76e72d', N'Thực hành con trỏ 2', CAST(N'2017-01-04 00:00:00.000' AS DateTime), CAST(N'2017-01-06 00:00:00.000' AS DateTime), CAST(N'2017-05-04 00:00:00.000' AS DateTime), 1, N'c1fb39e7-5e72-4bf8-bc82-88170a8f7ca8', 20)
INSERT [dbo].[Project] ([ProjectId], [ProjectTypeId], [ProjectName], [StartRegister], [EndRegister], [EndSubmit], [StudentMax], [CourseId], [GroupCapacity]) VALUES (N'c6a753eb-a0c1-4ec6-9f37-dc21842c8d47', N'12594590-80f4-49bc-8b21-8ca098c7ef30', N'Các thuật toán tìm kiếm', CAST(N'2017-01-05 00:00:00.000' AS DateTime), CAST(N'2017-01-07 00:00:00.000' AS DateTime), CAST(N'2017-05-05 00:00:00.000' AS DateTime), 3, N'205b9b50-c670-4c71-8fc9-210d59173ae7', 20)
INSERT [dbo].[Project] ([ProjectId], [ProjectTypeId], [ProjectName], [StartRegister], [EndRegister], [EndSubmit], [StudentMax], [CourseId], [GroupCapacity]) VALUES (N'8e395894-8286-4452-99b0-e3ab36750c41', N'12594590-80f4-49bc-8b21-8ca098c7ef30', N'Thực hành con trỏ', CAST(N'2017-01-03 00:00:00.000' AS DateTime), CAST(N'2017-01-05 00:00:00.000' AS DateTime), CAST(N'2017-05-03 00:00:00.000' AS DateTime), 2, N'c1fb39e7-5e72-4bf8-bc82-88170a8f7ca8', 20)
INSERT [dbo].[Project] ([ProjectId], [ProjectTypeId], [ProjectName], [StartRegister], [EndRegister], [EndSubmit], [StudentMax], [CourseId], [GroupCapacity]) VALUES (N'1a3d48b9-9c79-482e-908d-e597c10dbf67', N'12594590-80f4-49bc-8b21-8ca098c7ef30', N'Đồ án giữa kì', CAST(N'2017-01-06 00:00:00.000' AS DateTime), CAST(N'2017-01-08 00:00:00.000' AS DateTime), CAST(N'2017-05-06 00:00:00.000' AS DateTime), 1, N'4ec02583-44c7-410d-8ec9-e393eaa1ff69', 20)
INSERT [dbo].[Project] ([ProjectId], [ProjectTypeId], [ProjectName], [StartRegister], [EndRegister], [EndSubmit], [StudentMax], [CourseId], [GroupCapacity]) VALUES (N'c3030f5d-85ab-4894-a675-e59c5acb0189', N'e5debcf3-fbd1-4f9f-9f92-b50872a29c5f', N'Game Cờ tỷ phú', CAST(N'2017-01-02 00:00:00.000' AS DateTime), CAST(N'2017-01-04 00:00:00.000' AS DateTime), CAST(N'2017-05-02 00:00:00.000' AS DateTime), 2, N'5e473ade-405f-4e3c-82dc-0394388d88e1', 20)
INSERT [dbo].[Project] ([ProjectId], [ProjectTypeId], [ProjectName], [StartRegister], [EndRegister], [EndSubmit], [StudentMax], [CourseId], [GroupCapacity]) VALUES (N'2e64f8b1-6940-4b54-824f-eff685668ccc', N'79662735-c20d-43b1-8773-63c47f76e72d', N'Các thuật toán sắp xếp', CAST(N'2017-01-04 00:00:00.000' AS DateTime), CAST(N'2017-01-06 00:00:00.000' AS DateTime), CAST(N'2017-05-04 00:00:00.000' AS DateTime), 1, N'205b9b50-c670-4c71-8fc9-210d59173ae7', 20)
INSERT [dbo].[ProjectType] ([ProjectTypeId], [ProjectTypeName]) VALUES (N'79662735-c20d-43b1-8773-63c47f76e72d', N'Pratice')
INSERT [dbo].[ProjectType] ([ProjectTypeId], [ProjectTypeName]) VALUES (N'12594590-80f4-49bc-8b21-8ca098c7ef30', N'Midterm')
INSERT [dbo].[ProjectType] ([ProjectTypeId], [ProjectTypeName]) VALUES (N'e5debcf3-fbd1-4f9f-9f92-b50872a29c5f', N'Final')
INSERT [dbo].[Student_Topic_Project] ([StudentId], [TopicId], [ProjectId]) VALUES (N'509d04cb-23b4-4a06-ab6f-44f622d594cd', N'cd9fbeb4-0fc7-4611-ab7d-c9568991072a', N'4d907126-a309-4e9c-985e-13b3088b9800')
INSERT [dbo].[Student_Topic_Project] ([StudentId], [TopicId], [ProjectId]) VALUES (N'509d04cb-23b4-4a06-ab6f-44f622d594cd', N'bb641f3e-263c-4505-9a15-f46014b48718', N'7d7f957e-2c01-41fa-98d1-c59ba342ad45')
INSERT [dbo].[Student_Topic_Project] ([StudentId], [TopicId], [ProjectId]) VALUES (N'509d04cb-23b4-4a06-ab6f-44f622d594cd', N'0e883bad-c433-4512-a7e2-16eb47138da7', N'1a3d48b9-9c79-482e-908d-e597c10dbf67')
INSERT [dbo].[Student_Topic_Project] ([StudentId], [TopicId], [ProjectId]) VALUES (N'509d04cb-23b4-4a06-ab6f-44f622d594cd', N'5cbed0cb-968e-45fc-bbdb-3d2056cf66e5', N'2e64f8b1-6940-4b54-824f-eff685668ccc')
INSERT [dbo].[Student_Topic_Project] ([StudentId], [TopicId], [ProjectId]) VALUES (N'eefd4ca5-7d02-4139-81f4-57855741cbb1', N'3b336210-4264-4f8a-9e7e-46d7a57d916f', N'7d7f957e-2c01-41fa-98d1-c59ba342ad45')
INSERT [dbo].[Student_Topic_Project] ([StudentId], [TopicId], [ProjectId]) VALUES (N'eefd4ca5-7d02-4139-81f4-57855741cbb1', N'13705123-fd43-4a0a-9fff-506aa3d13483', N'2e64f8b1-6940-4b54-824f-eff685668ccc')
INSERT [dbo].[Student_Topic_Project] ([StudentId], [TopicId], [ProjectId]) VALUES (N'ee07eb0b-3d2a-4547-8a84-5d44482be5cd', N'4fd409e9-1947-49b7-92c6-59baaf42f3d6', N'4d907126-a309-4e9c-985e-13b3088b9800')
INSERT [dbo].[Student_Topic_Project] ([StudentId], [TopicId], [ProjectId]) VALUES (N'ee07eb0b-3d2a-4547-8a84-5d44482be5cd', N'556194ea-3bb6-4ae6-919a-36e6b68384db', N'5c53f74f-e090-4b65-bc40-7dc4a6bb07c6')
INSERT [dbo].[Student_Topic_Project] ([StudentId], [TopicId], [ProjectId]) VALUES (N'ee07eb0b-3d2a-4547-8a84-5d44482be5cd', N'67a10994-262b-4943-96c8-61c364fe7b75', N'97e42478-a574-4589-9394-8d41ec756b1d')
INSERT [dbo].[Student_Topic_Project] ([StudentId], [TopicId], [ProjectId]) VALUES (N'ee07eb0b-3d2a-4547-8a84-5d44482be5cd', N'79a14100-51f9-4a0f-af06-c5bd61aeda70', N'5dbd1b7e-741a-487d-a013-a6a45cf39ba2')
INSERT [dbo].[Student_Topic_Project] ([StudentId], [TopicId], [ProjectId]) VALUES (N'0a9bae0d-68f7-405f-aa2f-5da3dbc351f8', N'0e883bad-c433-4512-a7e2-16eb47138da7', N'1a3d48b9-9c79-482e-908d-e597c10dbf67')
INSERT [dbo].[Student_Topic_Project] ([StudentId], [TopicId], [ProjectId]) VALUES (N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0', N'f83f93fe-db12-43c1-82da-f1f4542fc846', N'1a3d48b9-9c79-482e-908d-e597c10dbf67')
INSERT [dbo].[Student_Topic_Project] ([StudentId], [TopicId], [ProjectId]) VALUES (N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03', N'cd9fbeb4-0fc7-4611-ab7d-c9568991072a', N'4d907126-a309-4e9c-985e-13b3088b9800')
INSERT [dbo].[Student_Topic_Project] ([StudentId], [TopicId], [ProjectId]) VALUES (N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03', N'44ad667e-2d11-4f97-a56f-c5ad562c142c', N'f8f92767-c7ab-480e-b9be-3f150e233646')
INSERT [dbo].[Student_Topic_Project] ([StudentId], [TopicId], [ProjectId]) VALUES (N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03', N'556194ea-3bb6-4ae6-919a-36e6b68384db', N'5c53f74f-e090-4b65-bc40-7dc4a6bb07c6')
INSERT [dbo].[Student_Topic_Project] ([StudentId], [TopicId], [ProjectId]) VALUES (N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03', N'b5d25143-71f2-459b-a617-34dd81763bfa', N'97e42478-a574-4589-9394-8d41ec756b1d')
INSERT [dbo].[Student_Topic_Project] ([StudentId], [TopicId], [ProjectId]) VALUES (N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03', N'd57526a9-9da5-4fa5-a33d-2090ec76d68a', N'7d7f957e-2c01-41fa-98d1-c59ba342ad45')
INSERT [dbo].[Student_Topic_Project] ([StudentId], [TopicId], [ProjectId]) VALUES (N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03', N'f83f93fe-db12-43c1-82da-f1f4542fc846', N'1a3d48b9-9c79-482e-908d-e597c10dbf67')
INSERT [dbo].[Student_Topic_Project] ([StudentId], [TopicId], [ProjectId]) VALUES (N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03', N'5cbed0cb-968e-45fc-bbdb-3d2056cf66e5', N'2e64f8b1-6940-4b54-824f-eff685668ccc')
INSERT [dbo].[Student_Topic_Project] ([StudentId], [TopicId], [ProjectId]) VALUES (N'58011439-e4ee-4016-b54e-899a195e9f1f', N'79a14100-51f9-4a0f-af06-c5bd61aeda70', N'5dbd1b7e-741a-487d-a013-a6a45cf39ba2')
INSERT [dbo].[Student_Topic_Project] ([StudentId], [TopicId], [ProjectId]) VALUES (N'58011439-e4ee-4016-b54e-899a195e9f1f', N'3b336210-4264-4f8a-9e7e-46d7a57d916f', N'7d7f957e-2c01-41fa-98d1-c59ba342ad45')
INSERT [dbo].[Student_Topic_Project] ([StudentId], [TopicId], [ProjectId]) VALUES (N'58011439-e4ee-4016-b54e-899a195e9f1f', N'13705123-fd43-4a0a-9fff-506aa3d13483', N'2e64f8b1-6940-4b54-824f-eff685668ccc')
INSERT [dbo].[Student_Topic_Project] ([StudentId], [TopicId], [ProjectId]) VALUES (N'ee558c4b-d220-4b0a-83f5-ff621df02800', N'4fd409e9-1947-49b7-92c6-59baaf42f3d6', N'4d907126-a309-4e9c-985e-13b3088b9800')
INSERT [dbo].[Student_Topic_Project] ([StudentId], [TopicId], [ProjectId]) VALUES (N'ee558c4b-d220-4b0a-83f5-ff621df02800', N'636c66c9-eff8-4038-8f01-479876b04039', N'5c53f74f-e090-4b65-bc40-7dc4a6bb07c6')
INSERT [dbo].[Student_Topic_Project] ([StudentId], [TopicId], [ProjectId]) VALUES (N'ee558c4b-d220-4b0a-83f5-ff621df02800', N'67a10994-262b-4943-96c8-61c364fe7b75', N'97e42478-a574-4589-9394-8d41ec756b1d')
INSERT [dbo].[Student_Topic_Project] ([StudentId], [TopicId], [ProjectId]) VALUES (N'ee558c4b-d220-4b0a-83f5-ff621df02800', N'd57526a9-9da5-4fa5-a33d-2090ec76d68a', N'7d7f957e-2c01-41fa-98d1-c59ba342ad45')
INSERT [dbo].[Student_Topic_Project] ([StudentId], [TopicId], [ProjectId]) VALUES (N'ee558c4b-d220-4b0a-83f5-ff621df02800', N'5b68f551-5f8e-4e4c-ab55-1f1e3c84aadb', N'1a3d48b9-9c79-482e-908d-e597c10dbf67')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'612d19e7-41ee-49a8-b4f0-03a06caf76bb', N'b5d25143-71f2-459b-a617-34dd81763bfa', N'97e42478-a574-4589-9394-8d41ec756b1d')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'612d19e7-41ee-49a8-b4f0-03a06caf76bb', N'9a88c39d-af55-4fea-9ecd-608b01e9b5cb', N'10f263c6-ce61-440a-a284-75b625006088')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'612d19e7-41ee-49a8-b4f0-03a06caf76bb', N'5ab758b6-dd93-4e7b-9ab4-6e2e855b237d', N'0992679e-bef7-4577-b269-5f0267c6b649')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'5d7a3a1d-2175-465a-99f0-29d04b00ba45', N'bc2ea06d-7ae7-4c5a-9ff1-271592adfa57', N'10f263c6-ce61-440a-a284-75b625006088')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'5d7a3a1d-2175-465a-99f0-29d04b00ba45', N'67a10994-262b-4943-96c8-61c364fe7b75', N'97e42478-a574-4589-9394-8d41ec756b1d')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'5d7a3a1d-2175-465a-99f0-29d04b00ba45', N'8cb69bbf-e92a-43ea-bf26-d8b001075f98', N'0992679e-bef7-4577-b269-5f0267c6b649')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'6004d392-5384-42c2-9d3a-32690d7187c1', N'ecb1e1a7-546c-4d88-a87d-127a9d57492a', N'161b71d2-e75f-4187-955e-7cd129c5c12b')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'6004d392-5384-42c2-9d3a-32690d7187c1', N'556194ea-3bb6-4ae6-919a-36e6b68384db', N'5c53f74f-e090-4b65-bc40-7dc4a6bb07c6')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'6004d392-5384-42c2-9d3a-32690d7187c1', N'636c66c9-eff8-4038-8f01-479876b04039', N'5c53f74f-e090-4b65-bc40-7dc4a6bb07c6')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'6004d392-5384-42c2-9d3a-32690d7187c1', N'9eaf4207-feb9-47dd-b31e-9c269b1cc696', N'161b71d2-e75f-4187-955e-7cd129c5c12b')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'6004d392-5384-42c2-9d3a-32690d7187c1', N'b2a006fc-7426-44b3-994f-b89a816fe072', N'5c53f74f-e090-4b65-bc40-7dc4a6bb07c6')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'6004d392-5384-42c2-9d3a-32690d7187c1', N'3fadb134-dc43-4b71-846d-fb700f938ef0', N'161b71d2-e75f-4187-955e-7cd129c5c12b')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'd9d3e777-cad5-461f-8c33-56b07f260691', N'84a0a214-f1ab-4941-a32d-07ab34427c39', N'48fd1b40-85f0-48dc-a213-0ffe57fd9261')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'd9d3e777-cad5-461f-8c33-56b07f260691', N'329af968-811c-4472-bafd-594c738a7419', N'48fd1b40-85f0-48dc-a213-0ffe57fd9261')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'd9d3e777-cad5-461f-8c33-56b07f260691', N'84468b49-f319-4c4c-88b1-88f9d615ea84', N'46d80ed4-d8ae-4367-a4bd-1a05455a9dcb')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'd9d3e777-cad5-461f-8c33-56b07f260691', N'96e514c0-0e7c-4ffb-a34b-a670fd1d668f', N'46d80ed4-d8ae-4367-a4bd-1a05455a9dcb')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'd9d3e777-cad5-461f-8c33-56b07f260691', N'0328139e-0be2-4978-a189-e9f3f5b6d79d', N'48fd1b40-85f0-48dc-a213-0ffe57fd9261')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'44bb852e-a0dd-49be-9dce-6cbc20fae0e6', N'4bbb7c4b-e493-4b96-8da3-5680ee8c19c2', N'aaf84c01-7826-47e7-a07e-a551092a5b10')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'44bb852e-a0dd-49be-9dce-6cbc20fae0e6', N'd287bf09-4730-4b2c-be35-7a510b8f8cc7', N'aaf84c01-7826-47e7-a07e-a551092a5b10')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'44bb852e-a0dd-49be-9dce-6cbc20fae0e6', N'0856925b-5113-47f3-bf3b-aed86248a771', N'c6a753eb-a0c1-4ec6-9f37-dc21842c8d47')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'44bb852e-a0dd-49be-9dce-6cbc20fae0e6', N'12737839-9abc-4913-b9c9-bc156a59977b', N'c6a753eb-a0c1-4ec6-9f37-dc21842c8d47')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'44bb852e-a0dd-49be-9dce-6cbc20fae0e6', N'0328139e-0be2-4978-a189-e9f3f5b6d79d', N'a3029307-6c74-4e8c-991b-1a180e6f1972')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'07771bed-a35b-4cd7-9d63-6d52e4c6f704', N'5b68f551-5f8e-4e4c-ab55-1f1e3c84aadb', N'1a3d48b9-9c79-482e-908d-e597c10dbf67')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'07771bed-a35b-4cd7-9d63-6d52e4c6f704', N'd57526a9-9da5-4fa5-a33d-2090ec76d68a', N'7d7f957e-2c01-41fa-98d1-c59ba342ad45')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'07771bed-a35b-4cd7-9d63-6d52e4c6f704', N'8e4d71cb-f8a4-46a1-b283-66574696b89a', N'cc3df196-a50c-4dc0-9139-2f1dbc4a531a')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'07771bed-a35b-4cd7-9d63-6d52e4c6f704', N'6c7aff62-4390-460c-a83c-acc182313e53', N'c3030f5d-85ab-4894-a675-e59c5acb0189')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'07771bed-a35b-4cd7-9d63-6d52e4c6f704', N'44ad667e-2d11-4f97-a56f-c5ad562c142c', N'f8f92767-c7ab-480e-b9be-3f150e233646')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'c302648d-fc5e-447b-a8eb-a2cadb69c529', N'ef47f342-200b-47a4-9339-1fd8c3b69cd9', N'd66f509f-3737-4885-becb-3a3fcd7ab1e2')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'c302648d-fc5e-447b-a8eb-a2cadb69c529', N'4f6b9f30-e32e-4d52-be71-73d40a20038f', N'd66f509f-3737-4885-becb-3a3fcd7ab1e2')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'2049669c-1539-4c03-8434-b4070e4d3711', N'5090a2ce-f3b9-4473-9723-0c026c9d0ad0', N'785864a6-d569-4eb7-b67e-0d408f943815')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'2049669c-1539-4c03-8434-b4070e4d3711', N'd578137f-343e-464d-8026-47fa46f3729e', N'4d907126-a309-4e9c-985e-13b3088b9800')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'2049669c-1539-4c03-8434-b4070e4d3711', N'd578137f-343e-464d-8026-47fa46f3729e', N'6b640835-6fea-4012-8b49-8f9d6fd51b1d')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'2049669c-1539-4c03-8434-b4070e4d3711', N'b95c6303-cea2-4947-a753-768d6488eb25', N'ffb21f07-867d-4396-817a-c3b99d4b4b19')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'2049669c-1539-4c03-8434-b4070e4d3711', N'4d221a1b-80bf-4443-918d-a6b5564cd738', N'6b640835-6fea-4012-8b49-8f9d6fd51b1d')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'2049669c-1539-4c03-8434-b4070e4d3711', N'79a14100-51f9-4a0f-af06-c5bd61aeda70', N'5dbd1b7e-741a-487d-a013-a6a45cf39ba2')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'2049669c-1539-4c03-8434-b4070e4d3711', N'cd9fbeb4-0fc7-4611-ab7d-c9568991072a', N'4d907126-a309-4e9c-985e-13b3088b9800')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'2049669c-1539-4c03-8434-b4070e4d3711', N'a124cc44-ac66-4af0-ab71-d95a48ecffd1', N'6b640835-6fea-4012-8b49-8f9d6fd51b1d')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'd3483d03-73aa-4a34-8885-b9c39a4f2659', N'0e883bad-c433-4512-a7e2-16eb47138da7', N'1a3d48b9-9c79-482e-908d-e597c10dbf67')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'd3483d03-73aa-4a34-8885-b9c39a4f2659', N'96a2dbf4-e155-4bac-bd7b-3ec169cf31b8', N'c4fd860c-1365-48e6-a656-4eb1c1a15c19')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'd3483d03-73aa-4a34-8885-b9c39a4f2659', N'3b336210-4264-4f8a-9e7e-46d7a57d916f', N'7d7f957e-2c01-41fa-98d1-c59ba342ad45')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'd3483d03-73aa-4a34-8885-b9c39a4f2659', N'd578137f-343e-464d-8026-47fa46f3729e', N'f8f92767-c7ab-480e-b9be-3f150e233646')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'd3483d03-73aa-4a34-8885-b9c39a4f2659', N'4fd409e9-1947-49b7-92c6-59baaf42f3d6', N'4d907126-a309-4e9c-985e-13b3088b9800')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'd3483d03-73aa-4a34-8885-b9c39a4f2659', N'7cc4887b-35af-4461-b399-65cfcb05fbc5', N'785864a6-d569-4eb7-b67e-0d408f943815')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'd3483d03-73aa-4a34-8885-b9c39a4f2659', N'6142ae8d-c045-4d70-a425-72697352e540', N'8e395894-8286-4452-99b0-e3ab36750c41')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'd3483d03-73aa-4a34-8885-b9c39a4f2659', N'4f6b9f30-e32e-4d52-be71-73d40a20038f', N'ffb21f07-867d-4396-817a-c3b99d4b4b19')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'd3483d03-73aa-4a34-8885-b9c39a4f2659', N'9eaf4207-feb9-47dd-b31e-9c269b1cc696', N'8e395894-8286-4452-99b0-e3ab36750c41')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'd3483d03-73aa-4a34-8885-b9c39a4f2659', N'89ada340-8131-43f6-bdb2-c43cfa9c6d09', N'ffb21f07-867d-4396-817a-c3b99d4b4b19')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'd3483d03-73aa-4a34-8885-b9c39a4f2659', N'cd56b99e-dce2-455e-9f30-c45bcdae5052', N'cc3df196-a50c-4dc0-9139-2f1dbc4a531a')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'd3483d03-73aa-4a34-8885-b9c39a4f2659', N'0328139e-0be2-4978-a189-e9f3f5b6d79d', N'c4fd860c-1365-48e6-a656-4eb1c1a15c19')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'd3483d03-73aa-4a34-8885-b9c39a4f2659', N'f83f93fe-db12-43c1-82da-f1f4542fc846', N'1a3d48b9-9c79-482e-908d-e597c10dbf67')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'd3483d03-73aa-4a34-8885-b9c39a4f2659', N'bb641f3e-263c-4505-9a15-f46014b48718', N'7d7f957e-2c01-41fa-98d1-c59ba342ad45')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'd3483d03-73aa-4a34-8885-b9c39a4f2659', N'bf45e19a-b88e-4344-a39a-fc07b7d3d771', N'6b640835-6fea-4012-8b49-8f9d6fd51b1d')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'ad7ba3c0-acf5-4f1c-8b0d-e0e6dc84979d', N'5cbed0cb-968e-45fc-bbdb-3d2056cf66e5', N'2e64f8b1-6940-4b54-824f-eff685668ccc')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'ad7ba3c0-acf5-4f1c-8b0d-e0e6dc84979d', N'13705123-fd43-4a0a-9fff-506aa3d13483', N'2e64f8b1-6940-4b54-824f-eff685668ccc')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'ad7ba3c0-acf5-4f1c-8b0d-e0e6dc84979d', N'cdff93ee-ee9a-49c3-aafd-53596ec3324a', N'a3029307-6c74-4e8c-991b-1a180e6f1972')
INSERT [dbo].[Teacher_Topic_Project] ([TeacherId], [TopicId], [ProjectId]) VALUES (N'ad7ba3c0-acf5-4f1c-8b0d-e0e6dc84979d', N'80b7fc13-eed7-4d69-addf-bf47a7358c50', N'a3029307-6c74-4e8c-991b-1a180e6f1972')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'84a0a214-f1ab-4941-a32d-07ab34427c39', N'Topic 39', N'Random 39')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'5090a2ce-f3b9-4473-9723-0c026c9d0ad0', N'Topic 31', N'Random 31')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'ecb1e1a7-546c-4d88-a87d-127a9d57492a', N'Topic 40', N'Random 40')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'0e883bad-c433-4512-a7e2-16eb47138da7', N'Topic 12', N'Random 12')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'5b68f551-5f8e-4e4c-ab55-1f1e3c84aadb', N'Topic 6', N'Random 6')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'ef47f342-200b-47a4-9339-1fd8c3b69cd9', N'Topic 45', N'Random 45')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'd57526a9-9da5-4fa5-a33d-2090ec76d68a', N'Topic 10', N'Random 10')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'bc2ea06d-7ae7-4c5a-9ff1-271592adfa57', N'Topic 14', N'Random 14')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'b5d25143-71f2-459b-a617-34dd81763bfa', N'Topic 44', N'Random 44')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'556194ea-3bb6-4ae6-919a-36e6b68384db', N'Topic 15', N'Random 15')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'5cbed0cb-968e-45fc-bbdb-3d2056cf66e5', N'Topic 37', N'Random 37')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'96a2dbf4-e155-4bac-bd7b-3ec169cf31b8', N'Topic 48', N'Random 48')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'3b336210-4264-4f8a-9e7e-46d7a57d916f', N'Topic 9', N'Random 9')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'636c66c9-eff8-4038-8f01-479876b04039', N'Topic 41', N'Random 41')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'd578137f-343e-464d-8026-47fa46f3729e', N'Topic 1', N'Random 1')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'13705123-fd43-4a0a-9fff-506aa3d13483', N'Topic 19', N'Random 19')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'cdff93ee-ee9a-49c3-aafd-53596ec3324a', N'Topic 34', N'Random 34')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'4bbb7c4b-e493-4b96-8da3-5680ee8c19c2', N'Topic 21', N'Random 21')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'329af968-811c-4472-bafd-594c738a7419', N'Topic 17', N'Random 17')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'4fd409e9-1947-49b7-92c6-59baaf42f3d6', N'Topic 33', N'Random 33')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'9a88c39d-af55-4fea-9ecd-608b01e9b5cb', N'Topic 42', N'Random 42')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'67a10994-262b-4943-96c8-61c364fe7b75', N'Topic 8', N'Random 8')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'7cc4887b-35af-4461-b399-65cfcb05fbc5', N'Topic 25', N'Random 25')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'8e4d71cb-f8a4-46a1-b283-66574696b89a', N'Topic 46', N'Random 46')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'5ab758b6-dd93-4e7b-9ab4-6e2e855b237d', N'Topic 43', N'Random 43')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'6142ae8d-c045-4d70-a425-72697352e540', N'Topic 50', N'Random 50')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'4f6b9f30-e32e-4d52-be71-73d40a20038f', N'Topic 7', N'Random 7')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'b95c6303-cea2-4947-a753-768d6488eb25', N'Topic 29', N'Random 29')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'd287bf09-4730-4b2c-be35-7a510b8f8cc7', N'Topic 35', N'Random 35')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'84468b49-f319-4c4c-88b1-88f9d615ea84', N'Topic 18', N'Random 18')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'9eaf4207-feb9-47dd-b31e-9c269b1cc696', N'Topic 3', N'Random 3')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'96e514c0-0e7c-4ffb-a34b-a670fd1d668f', N'Topic 38', N'Random 38')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'4d221a1b-80bf-4443-918d-a6b5564cd738', N'Topic 32', N'Random 32')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'6c7aff62-4390-460c-a83c-acc182313e53', N'Topic 2', N'Random 2')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'0856925b-5113-47f3-bf3b-aed86248a771', N'Topic 36', N'Random 36')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'b2a006fc-7426-44b3-994f-b89a816fe072', N'Topic 20', N'Random 20')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'12737839-9abc-4913-b9c9-bc156a59977b', N'Topic 23', N'Random 23')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'80b7fc13-eed7-4d69-addf-bf47a7358c50', N'Topic 22', N'Random 22')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'89ada340-8131-43f6-bdb2-c43cfa9c6d09', N'Topic 28', N'Random 28')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'cd56b99e-dce2-455e-9f30-c45bcdae5052', N'Topic 11', N'Random 11')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'44ad667e-2d11-4f97-a56f-c5ad562c142c', N'Topic 4', N'Random 4')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'79a14100-51f9-4a0f-af06-c5bd61aeda70', N'Topic 27', N'Random 27')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'cd9fbeb4-0fc7-4611-ab7d-c9568991072a', N'Topic 24', N'Random 24')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'8cb69bbf-e92a-43ea-bf26-d8b001075f98', N'Topic 13', N'Random 13')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'a124cc44-ac66-4af0-ab71-d95a48ecffd1', N'Topic 30', N'Random 30')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'0328139e-0be2-4978-a189-e9f3f5b6d79d', N'Topic 5', N'Random 5')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'f83f93fe-db12-43c1-82da-f1f4542fc846', N'Topic 47', N'Random 47')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'bb641f3e-263c-4505-9a15-f46014b48718', N'Topic 49', N'Random 49')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'3fadb134-dc43-4b71-846d-fb700f938ef0', N'Topic 16', N'Random 16')
INSERT [dbo].[Topic] ([TopicId], [Title], [Content]) VALUES (N'bf45e19a-b88e-4344-a39a-fc07b7d3d771', N'Topic 26', N'Random 26')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'84a0a214-f1ab-4941-a32d-07ab34427c39', N'48fd1b40-85f0-48dc-a213-0ffe57fd9261')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'5090a2ce-f3b9-4473-9723-0c026c9d0ad0', N'785864a6-d569-4eb7-b67e-0d408f943815')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'ecb1e1a7-546c-4d88-a87d-127a9d57492a', N'161b71d2-e75f-4187-955e-7cd129c5c12b')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'0e883bad-c433-4512-a7e2-16eb47138da7', N'1a3d48b9-9c79-482e-908d-e597c10dbf67')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'5b68f551-5f8e-4e4c-ab55-1f1e3c84aadb', N'1a3d48b9-9c79-482e-908d-e597c10dbf67')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'ef47f342-200b-47a4-9339-1fd8c3b69cd9', N'd66f509f-3737-4885-becb-3a3fcd7ab1e2')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'd57526a9-9da5-4fa5-a33d-2090ec76d68a', N'7d7f957e-2c01-41fa-98d1-c59ba342ad45')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'bc2ea06d-7ae7-4c5a-9ff1-271592adfa57', N'10f263c6-ce61-440a-a284-75b625006088')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'b5d25143-71f2-459b-a617-34dd81763bfa', N'97e42478-a574-4589-9394-8d41ec756b1d')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'556194ea-3bb6-4ae6-919a-36e6b68384db', N'5c53f74f-e090-4b65-bc40-7dc4a6bb07c6')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'5cbed0cb-968e-45fc-bbdb-3d2056cf66e5', N'2e64f8b1-6940-4b54-824f-eff685668ccc')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'96a2dbf4-e155-4bac-bd7b-3ec169cf31b8', N'c4fd860c-1365-48e6-a656-4eb1c1a15c19')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'3b336210-4264-4f8a-9e7e-46d7a57d916f', N'7d7f957e-2c01-41fa-98d1-c59ba342ad45')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'636c66c9-eff8-4038-8f01-479876b04039', N'5c53f74f-e090-4b65-bc40-7dc4a6bb07c6')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'd578137f-343e-464d-8026-47fa46f3729e', N'4d907126-a309-4e9c-985e-13b3088b9800')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'd578137f-343e-464d-8026-47fa46f3729e', N'f8f92767-c7ab-480e-b9be-3f150e233646')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'd578137f-343e-464d-8026-47fa46f3729e', N'6b640835-6fea-4012-8b49-8f9d6fd51b1d')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'13705123-fd43-4a0a-9fff-506aa3d13483', N'2e64f8b1-6940-4b54-824f-eff685668ccc')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'cdff93ee-ee9a-49c3-aafd-53596ec3324a', N'a3029307-6c74-4e8c-991b-1a180e6f1972')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'4bbb7c4b-e493-4b96-8da3-5680ee8c19c2', N'aaf84c01-7826-47e7-a07e-a551092a5b10')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'329af968-811c-4472-bafd-594c738a7419', N'48fd1b40-85f0-48dc-a213-0ffe57fd9261')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'4fd409e9-1947-49b7-92c6-59baaf42f3d6', N'4d907126-a309-4e9c-985e-13b3088b9800')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'9a88c39d-af55-4fea-9ecd-608b01e9b5cb', N'10f263c6-ce61-440a-a284-75b625006088')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'67a10994-262b-4943-96c8-61c364fe7b75', N'97e42478-a574-4589-9394-8d41ec756b1d')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'7cc4887b-35af-4461-b399-65cfcb05fbc5', N'785864a6-d569-4eb7-b67e-0d408f943815')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'8e4d71cb-f8a4-46a1-b283-66574696b89a', N'cc3df196-a50c-4dc0-9139-2f1dbc4a531a')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'5ab758b6-dd93-4e7b-9ab4-6e2e855b237d', N'0992679e-bef7-4577-b269-5f0267c6b649')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'6142ae8d-c045-4d70-a425-72697352e540', N'8e395894-8286-4452-99b0-e3ab36750c41')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'4f6b9f30-e32e-4d52-be71-73d40a20038f', N'd66f509f-3737-4885-becb-3a3fcd7ab1e2')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'4f6b9f30-e32e-4d52-be71-73d40a20038f', N'ffb21f07-867d-4396-817a-c3b99d4b4b19')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'b95c6303-cea2-4947-a753-768d6488eb25', N'ffb21f07-867d-4396-817a-c3b99d4b4b19')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'd287bf09-4730-4b2c-be35-7a510b8f8cc7', N'aaf84c01-7826-47e7-a07e-a551092a5b10')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'84468b49-f319-4c4c-88b1-88f9d615ea84', N'46d80ed4-d8ae-4367-a4bd-1a05455a9dcb')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'9eaf4207-feb9-47dd-b31e-9c269b1cc696', N'161b71d2-e75f-4187-955e-7cd129c5c12b')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'9eaf4207-feb9-47dd-b31e-9c269b1cc696', N'8e395894-8286-4452-99b0-e3ab36750c41')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'96e514c0-0e7c-4ffb-a34b-a670fd1d668f', N'46d80ed4-d8ae-4367-a4bd-1a05455a9dcb')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'4d221a1b-80bf-4443-918d-a6b5564cd738', N'6b640835-6fea-4012-8b49-8f9d6fd51b1d')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'6c7aff62-4390-460c-a83c-acc182313e53', N'c3030f5d-85ab-4894-a675-e59c5acb0189')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'0856925b-5113-47f3-bf3b-aed86248a771', N'c6a753eb-a0c1-4ec6-9f37-dc21842c8d47')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'b2a006fc-7426-44b3-994f-b89a816fe072', N'5c53f74f-e090-4b65-bc40-7dc4a6bb07c6')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'12737839-9abc-4913-b9c9-bc156a59977b', N'c6a753eb-a0c1-4ec6-9f37-dc21842c8d47')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'80b7fc13-eed7-4d69-addf-bf47a7358c50', N'a3029307-6c74-4e8c-991b-1a180e6f1972')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'89ada340-8131-43f6-bdb2-c43cfa9c6d09', N'ffb21f07-867d-4396-817a-c3b99d4b4b19')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'cd56b99e-dce2-455e-9f30-c45bcdae5052', N'cc3df196-a50c-4dc0-9139-2f1dbc4a531a')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'44ad667e-2d11-4f97-a56f-c5ad562c142c', N'f8f92767-c7ab-480e-b9be-3f150e233646')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'79a14100-51f9-4a0f-af06-c5bd61aeda70', N'5dbd1b7e-741a-487d-a013-a6a45cf39ba2')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'cd9fbeb4-0fc7-4611-ab7d-c9568991072a', N'4d907126-a309-4e9c-985e-13b3088b9800')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'8cb69bbf-e92a-43ea-bf26-d8b001075f98', N'0992679e-bef7-4577-b269-5f0267c6b649')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'a124cc44-ac66-4af0-ab71-d95a48ecffd1', N'6b640835-6fea-4012-8b49-8f9d6fd51b1d')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'0328139e-0be2-4978-a189-e9f3f5b6d79d', N'48fd1b40-85f0-48dc-a213-0ffe57fd9261')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'0328139e-0be2-4978-a189-e9f3f5b6d79d', N'a3029307-6c74-4e8c-991b-1a180e6f1972')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'0328139e-0be2-4978-a189-e9f3f5b6d79d', N'c4fd860c-1365-48e6-a656-4eb1c1a15c19')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'f83f93fe-db12-43c1-82da-f1f4542fc846', N'1a3d48b9-9c79-482e-908d-e597c10dbf67')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'bb641f3e-263c-4505-9a15-f46014b48718', N'7d7f957e-2c01-41fa-98d1-c59ba342ad45')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'3fadb134-dc43-4b71-846d-fb700f938ef0', N'161b71d2-e75f-4187-955e-7cd129c5c12b')
INSERT [dbo].[Topic_Project] ([TopicId], [ProjectId]) VALUES (N'bf45e19a-b88e-4344-a39a-fc07b7d3d771', N'6b640835-6fea-4012-8b49-8f9d6fd51b1d')
INSERT [dbo].[User] ([UserId], [FullName], [UserName], [Password], [UserType], [Status], [Email], [Phone], [Address]) VALUES (N'612d19e7-41ee-49a8-b4f0-03a06caf76bb', N'Trần Trung Dũng', N'ttdung', N'123', N'Teacher', 1, N'email@email.com', N'1000000001', N'229 NVC')
INSERT [dbo].[User] ([UserId], [FullName], [UserName], [Password], [UserType], [Status], [Email], [Phone], [Address]) VALUES (N'5d7a3a1d-2175-465a-99f0-29d04b00ba45', N'Nguyễn Thành Long', N'ntlong', N'123', N'Teacher', 0, N'email@email.com', N'1000000008', N'236 NVC')
INSERT [dbo].[User] ([UserId], [FullName], [UserName], [Password], [UserType], [Status], [Email], [Phone], [Address]) VALUES (N'6004d392-5384-42c2-9d3a-32690d7187c1', N'Đỗ Hoàng Cường', N'dhcuong', N'123', N'Teacher', 0, N'email@email.com', N'1000000002', N'230 NVC')
INSERT [dbo].[User] ([UserId], [FullName], [UserName], [Password], [UserType], [Status], [Email], [Phone], [Address]) VALUES (N'509d04cb-23b4-4a06-ab6f-44f622d594cd', N'Nguyễn Thị Thu Hiền', N'ntthien', N'123', N'Student', 0, N'email@email.com', N'1000000011', N'239 NVC')
INSERT [dbo].[User] ([UserId], [FullName], [UserName], [Password], [UserType], [Status], [Email], [Phone], [Address]) VALUES (N'd9d3e777-cad5-461f-8c33-56b07f260691', N'Trần Thanh Phương', N'ttphuong', N'123', N'Teacher', 1, N'email@email.com', N'1000000003', N'231 NVC')
INSERT [dbo].[User] ([UserId], [FullName], [UserName], [Password], [UserType], [Status], [Email], [Phone], [Address]) VALUES (N'eefd4ca5-7d02-4139-81f4-57855741cbb1', N'Đỗ Trọng Lễ', N'dtle', N'123', N'Student', 1, N'email@email.com', N'1000000017', N'245 NVC')
INSERT [dbo].[User] ([UserId], [FullName], [UserName], [Password], [UserType], [Status], [Email], [Phone], [Address]) VALUES (N'ee07eb0b-3d2a-4547-8a84-5d44482be5cd', N'Nguyễn Văn Hiếu', N'nvhieu', N'123', N'Student', 0, N'email@email.com', N'1000000010', N'238 NVC')
INSERT [dbo].[User] ([UserId], [FullName], [UserName], [Password], [UserType], [Status], [Email], [Phone], [Address]) VALUES (N'0a9bae0d-68f7-405f-aa2f-5da3dbc351f8', N'Lê Bá Quý', N'lbquy', N'123', N'Student', 0, N'email@email.com', N'1000000009', N'237 NVC')
INSERT [dbo].[User] ([UserId], [FullName], [UserName], [Password], [UserType], [Status], [Email], [Phone], [Address]) VALUES (N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0', N'Nguyễn Văn Quang', N'nvquang', N'123', N'Student', 0, N'email@email.com', N'1000000014', N'242 NVC')
INSERT [dbo].[User] ([UserId], [FullName], [UserName], [Password], [UserType], [Status], [Email], [Phone], [Address]) VALUES (N'1e3ecf47-4f83-4823-8e58-6ab6cdb743d2', N'Admin', N'admin', N'123', N'Administrator', 0, N'email@email.com', N'1000000019', N'247 NVC')
INSERT [dbo].[User] ([UserId], [FullName], [UserName], [Password], [UserType], [Status], [Email], [Phone], [Address]) VALUES (N'44bb852e-a0dd-49be-9dce-6cbc20fae0e6', N'Nguyễn Minh Tiệp', N'nmtiep', N'123', N'Teacher', 1, N'email@email.com', N'1000000006', N'234 NVC')
INSERT [dbo].[User] ([UserId], [FullName], [UserName], [Password], [UserType], [Status], [Email], [Phone], [Address]) VALUES (N'07771bed-a35b-4cd7-9d63-6d52e4c6f704', N'Nguyễn Minh Huy', N'nmhuy', N'123', N'Teacher', 0, N'email@email.com', N'0999999999', N'227 NVC')
INSERT [dbo].[User] ([UserId], [FullName], [UserName], [Password], [UserType], [Status], [Email], [Phone], [Address]) VALUES (N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03', N'Bùi Ngọc Minh', N'bnminh', N'123', N'Student', 1, N'email@email.com', N'1000000018', N'246 NVC')
INSERT [dbo].[User] ([UserId], [FullName], [UserName], [Password], [UserType], [Status], [Email], [Phone], [Address]) VALUES (N'58011439-e4ee-4016-b54e-899a195e9f1f', N'Huỳnh Hanh Thông', N'hhthong', N'123', N'Student', -1, N'email@email.com', N'1000000016', N'244 NVC')
INSERT [dbo].[User] ([UserId], [FullName], [UserName], [Password], [UserType], [Status], [Email], [Phone], [Address]) VALUES (N'c302648d-fc5e-447b-a8eb-a2cadb69c529', N'Hồ Bảo Quốc', N'hbquoc', N'123', N'Teacher', 0, N'email@email.com', N'1000000000', N'228 NVC')
INSERT [dbo].[User] ([UserId], [FullName], [UserName], [Password], [UserType], [Status], [Email], [Phone], [Address]) VALUES (N'2049669c-1539-4c03-8434-b4070e4d3711', N'Đinh Bá Tiến', N'dbtien', N'123', N'Teacher', 0, N'email@email.com', N'1000000005', N'233 NVC')
INSERT [dbo].[User] ([UserId], [FullName], [UserName], [Password], [UserType], [Status], [Email], [Phone], [Address]) VALUES (N'd3483d03-73aa-4a34-8885-b9c39a4f2659', N'Đỗ Nguyên Kha', N'dnkha', N'123', N'Teacher', 0, N'email@email.com', N'1000000007', N'235 NVC')
INSERT [dbo].[User] ([UserId], [FullName], [UserName], [Password], [UserType], [Status], [Email], [Phone], [Address]) VALUES (N'ad7ba3c0-acf5-4f1c-8b0d-e0e6dc84979d', N'Lê Hoài Bắc', N'lhbac', N'123', N'Teacher', 0, N'email@email.com', N'1000000004', N'232 NVC')
INSERT [dbo].[User] ([UserId], [FullName], [UserName], [Password], [UserType], [Status], [Email], [Phone], [Address]) VALUES (N'701d350a-5313-4d0b-bf53-e6c089c6dbf2', N'Nguyễn Thủy Tiên', N'nttien', N'123', N'Student', 0, N'email@email.com', N'1000000013', N'241 NVC')
INSERT [dbo].[User] ([UserId], [FullName], [UserName], [Password], [UserType], [Status], [Email], [Phone], [Address]) VALUES (N'677d5c43-2a99-42c0-b452-f651c86c997a', N'Lê Hoàng Nam', N'lhnam', N'123', N'Student', 0, N'email@email.com', N'1000000015', N'243 NVC')
INSERT [dbo].[User] ([UserId], [FullName], [UserName], [Password], [UserType], [Status], [Email], [Phone], [Address]) VALUES (N'ee558c4b-d220-4b0a-83f5-ff621df02800', N'Nguyễn Quốc Thảo', N'nqthao', N'123', N'Student', 0, N'email@email.com', N'1000000012', N'240 NVC')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'612d19e7-41ee-49a8-b4f0-03a06caf76bb', N'3cd0f5ad-575d-490a-8ab2-0adc2cd5bae2')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'5d7a3a1d-2175-465a-99f0-29d04b00ba45', N'3cd0f5ad-575d-490a-8ab2-0adc2cd5bae2')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'6004d392-5384-42c2-9d3a-32690d7187c1', N'5158f112-0110-4fbc-b0b6-fbda0ee50808')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'509d04cb-23b4-4a06-ab6f-44f622d594cd', N'5e473ade-405f-4e3c-82dc-0394388d88e1')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'509d04cb-23b4-4a06-ab6f-44f622d594cd', N'3cd0f5ad-575d-490a-8ab2-0adc2cd5bae2')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'509d04cb-23b4-4a06-ab6f-44f622d594cd', N'205b9b50-c670-4c71-8fc9-210d59173ae7')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'509d04cb-23b4-4a06-ab6f-44f622d594cd', N'da017386-83d2-4451-8cf2-3474c6664c08')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'509d04cb-23b4-4a06-ab6f-44f622d594cd', N'ff42038a-2a2f-49f4-aa4f-556ff35adab4')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'509d04cb-23b4-4a06-ab6f-44f622d594cd', N'c1fb39e7-5e72-4bf8-bc82-88170a8f7ca8')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'509d04cb-23b4-4a06-ab6f-44f622d594cd', N'1802c7e4-4b35-4383-bba5-8903470cd38c')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'509d04cb-23b4-4a06-ab6f-44f622d594cd', N'4ec02583-44c7-410d-8ec9-e393eaa1ff69')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'509d04cb-23b4-4a06-ab6f-44f622d594cd', N'5158f112-0110-4fbc-b0b6-fbda0ee50808')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'd9d3e777-cad5-461f-8c33-56b07f260691', N'1802c7e4-4b35-4383-bba5-8903470cd38c')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'eefd4ca5-7d02-4139-81f4-57855741cbb1', N'5e473ade-405f-4e3c-82dc-0394388d88e1')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'eefd4ca5-7d02-4139-81f4-57855741cbb1', N'3cd0f5ad-575d-490a-8ab2-0adc2cd5bae2')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'eefd4ca5-7d02-4139-81f4-57855741cbb1', N'205b9b50-c670-4c71-8fc9-210d59173ae7')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'eefd4ca5-7d02-4139-81f4-57855741cbb1', N'da017386-83d2-4451-8cf2-3474c6664c08')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'eefd4ca5-7d02-4139-81f4-57855741cbb1', N'ff42038a-2a2f-49f4-aa4f-556ff35adab4')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'eefd4ca5-7d02-4139-81f4-57855741cbb1', N'c1fb39e7-5e72-4bf8-bc82-88170a8f7ca8')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'eefd4ca5-7d02-4139-81f4-57855741cbb1', N'1802c7e4-4b35-4383-bba5-8903470cd38c')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'eefd4ca5-7d02-4139-81f4-57855741cbb1', N'4ec02583-44c7-410d-8ec9-e393eaa1ff69')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'eefd4ca5-7d02-4139-81f4-57855741cbb1', N'5158f112-0110-4fbc-b0b6-fbda0ee50808')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'ee07eb0b-3d2a-4547-8a84-5d44482be5cd', N'5e473ade-405f-4e3c-82dc-0394388d88e1')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'ee07eb0b-3d2a-4547-8a84-5d44482be5cd', N'3cd0f5ad-575d-490a-8ab2-0adc2cd5bae2')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'ee07eb0b-3d2a-4547-8a84-5d44482be5cd', N'205b9b50-c670-4c71-8fc9-210d59173ae7')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'ee07eb0b-3d2a-4547-8a84-5d44482be5cd', N'da017386-83d2-4451-8cf2-3474c6664c08')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'ee07eb0b-3d2a-4547-8a84-5d44482be5cd', N'ff42038a-2a2f-49f4-aa4f-556ff35adab4')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'ee07eb0b-3d2a-4547-8a84-5d44482be5cd', N'c1fb39e7-5e72-4bf8-bc82-88170a8f7ca8')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'ee07eb0b-3d2a-4547-8a84-5d44482be5cd', N'1802c7e4-4b35-4383-bba5-8903470cd38c')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'ee07eb0b-3d2a-4547-8a84-5d44482be5cd', N'4ec02583-44c7-410d-8ec9-e393eaa1ff69')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'ee07eb0b-3d2a-4547-8a84-5d44482be5cd', N'5158f112-0110-4fbc-b0b6-fbda0ee50808')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'0a9bae0d-68f7-405f-aa2f-5da3dbc351f8', N'5e473ade-405f-4e3c-82dc-0394388d88e1')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'0a9bae0d-68f7-405f-aa2f-5da3dbc351f8', N'3cd0f5ad-575d-490a-8ab2-0adc2cd5bae2')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'0a9bae0d-68f7-405f-aa2f-5da3dbc351f8', N'205b9b50-c670-4c71-8fc9-210d59173ae7')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'0a9bae0d-68f7-405f-aa2f-5da3dbc351f8', N'da017386-83d2-4451-8cf2-3474c6664c08')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'0a9bae0d-68f7-405f-aa2f-5da3dbc351f8', N'ff42038a-2a2f-49f4-aa4f-556ff35adab4')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'0a9bae0d-68f7-405f-aa2f-5da3dbc351f8', N'c1fb39e7-5e72-4bf8-bc82-88170a8f7ca8')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'0a9bae0d-68f7-405f-aa2f-5da3dbc351f8', N'1802c7e4-4b35-4383-bba5-8903470cd38c')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'0a9bae0d-68f7-405f-aa2f-5da3dbc351f8', N'4ec02583-44c7-410d-8ec9-e393eaa1ff69')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'0a9bae0d-68f7-405f-aa2f-5da3dbc351f8', N'5158f112-0110-4fbc-b0b6-fbda0ee50808')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0', N'5e473ade-405f-4e3c-82dc-0394388d88e1')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0', N'3cd0f5ad-575d-490a-8ab2-0adc2cd5bae2')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0', N'205b9b50-c670-4c71-8fc9-210d59173ae7')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0', N'da017386-83d2-4451-8cf2-3474c6664c08')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0', N'ff42038a-2a2f-49f4-aa4f-556ff35adab4')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0', N'c1fb39e7-5e72-4bf8-bc82-88170a8f7ca8')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0', N'1802c7e4-4b35-4383-bba5-8903470cd38c')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0', N'4ec02583-44c7-410d-8ec9-e393eaa1ff69')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'6b49cf1b-8b4f-499c-b6a0-657c5c53aba0', N'5158f112-0110-4fbc-b0b6-fbda0ee50808')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'44bb852e-a0dd-49be-9dce-6cbc20fae0e6', N'205b9b50-c670-4c71-8fc9-210d59173ae7')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'07771bed-a35b-4cd7-9d63-6d52e4c6f704', N'5e473ade-405f-4e3c-82dc-0394388d88e1')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'07771bed-a35b-4cd7-9d63-6d52e4c6f704', N'c1fb39e7-5e72-4bf8-bc82-88170a8f7ca8')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'07771bed-a35b-4cd7-9d63-6d52e4c6f704', N'4ec02583-44c7-410d-8ec9-e393eaa1ff69')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03', N'5e473ade-405f-4e3c-82dc-0394388d88e1')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03', N'3cd0f5ad-575d-490a-8ab2-0adc2cd5bae2')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03', N'205b9b50-c670-4c71-8fc9-210d59173ae7')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03', N'da017386-83d2-4451-8cf2-3474c6664c08')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03', N'ff42038a-2a2f-49f4-aa4f-556ff35adab4')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03', N'c1fb39e7-5e72-4bf8-bc82-88170a8f7ca8')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03', N'1802c7e4-4b35-4383-bba5-8903470cd38c')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03', N'4ec02583-44c7-410d-8ec9-e393eaa1ff69')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'4ce1bcb8-f879-4c5d-8f15-77bed3bfdd03', N'5158f112-0110-4fbc-b0b6-fbda0ee50808')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'58011439-e4ee-4016-b54e-899a195e9f1f', N'5e473ade-405f-4e3c-82dc-0394388d88e1')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'58011439-e4ee-4016-b54e-899a195e9f1f', N'3cd0f5ad-575d-490a-8ab2-0adc2cd5bae2')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'58011439-e4ee-4016-b54e-899a195e9f1f', N'205b9b50-c670-4c71-8fc9-210d59173ae7')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'58011439-e4ee-4016-b54e-899a195e9f1f', N'da017386-83d2-4451-8cf2-3474c6664c08')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'58011439-e4ee-4016-b54e-899a195e9f1f', N'ff42038a-2a2f-49f4-aa4f-556ff35adab4')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'58011439-e4ee-4016-b54e-899a195e9f1f', N'c1fb39e7-5e72-4bf8-bc82-88170a8f7ca8')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'58011439-e4ee-4016-b54e-899a195e9f1f', N'1802c7e4-4b35-4383-bba5-8903470cd38c')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'58011439-e4ee-4016-b54e-899a195e9f1f', N'4ec02583-44c7-410d-8ec9-e393eaa1ff69')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'58011439-e4ee-4016-b54e-899a195e9f1f', N'5158f112-0110-4fbc-b0b6-fbda0ee50808')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'c302648d-fc5e-447b-a8eb-a2cadb69c529', N'ff42038a-2a2f-49f4-aa4f-556ff35adab4')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'2049669c-1539-4c03-8434-b4070e4d3711', N'da017386-83d2-4451-8cf2-3474c6664c08')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'd3483d03-73aa-4a34-8885-b9c39a4f2659', N'5e473ade-405f-4e3c-82dc-0394388d88e1')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'd3483d03-73aa-4a34-8885-b9c39a4f2659', N'da017386-83d2-4451-8cf2-3474c6664c08')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'd3483d03-73aa-4a34-8885-b9c39a4f2659', N'c1fb39e7-5e72-4bf8-bc82-88170a8f7ca8')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'd3483d03-73aa-4a34-8885-b9c39a4f2659', N'4ec02583-44c7-410d-8ec9-e393eaa1ff69')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'ad7ba3c0-acf5-4f1c-8b0d-e0e6dc84979d', N'205b9b50-c670-4c71-8fc9-210d59173ae7')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'701d350a-5313-4d0b-bf53-e6c089c6dbf2', N'5e473ade-405f-4e3c-82dc-0394388d88e1')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'701d350a-5313-4d0b-bf53-e6c089c6dbf2', N'3cd0f5ad-575d-490a-8ab2-0adc2cd5bae2')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'701d350a-5313-4d0b-bf53-e6c089c6dbf2', N'205b9b50-c670-4c71-8fc9-210d59173ae7')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'701d350a-5313-4d0b-bf53-e6c089c6dbf2', N'da017386-83d2-4451-8cf2-3474c6664c08')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'701d350a-5313-4d0b-bf53-e6c089c6dbf2', N'ff42038a-2a2f-49f4-aa4f-556ff35adab4')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'701d350a-5313-4d0b-bf53-e6c089c6dbf2', N'c1fb39e7-5e72-4bf8-bc82-88170a8f7ca8')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'701d350a-5313-4d0b-bf53-e6c089c6dbf2', N'1802c7e4-4b35-4383-bba5-8903470cd38c')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'701d350a-5313-4d0b-bf53-e6c089c6dbf2', N'4ec02583-44c7-410d-8ec9-e393eaa1ff69')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'701d350a-5313-4d0b-bf53-e6c089c6dbf2', N'5158f112-0110-4fbc-b0b6-fbda0ee50808')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'677d5c43-2a99-42c0-b452-f651c86c997a', N'5e473ade-405f-4e3c-82dc-0394388d88e1')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'677d5c43-2a99-42c0-b452-f651c86c997a', N'3cd0f5ad-575d-490a-8ab2-0adc2cd5bae2')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'677d5c43-2a99-42c0-b452-f651c86c997a', N'205b9b50-c670-4c71-8fc9-210d59173ae7')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'677d5c43-2a99-42c0-b452-f651c86c997a', N'da017386-83d2-4451-8cf2-3474c6664c08')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'677d5c43-2a99-42c0-b452-f651c86c997a', N'ff42038a-2a2f-49f4-aa4f-556ff35adab4')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'677d5c43-2a99-42c0-b452-f651c86c997a', N'c1fb39e7-5e72-4bf8-bc82-88170a8f7ca8')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'677d5c43-2a99-42c0-b452-f651c86c997a', N'1802c7e4-4b35-4383-bba5-8903470cd38c')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'677d5c43-2a99-42c0-b452-f651c86c997a', N'4ec02583-44c7-410d-8ec9-e393eaa1ff69')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'677d5c43-2a99-42c0-b452-f651c86c997a', N'5158f112-0110-4fbc-b0b6-fbda0ee50808')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'ee558c4b-d220-4b0a-83f5-ff621df02800', N'5e473ade-405f-4e3c-82dc-0394388d88e1')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'ee558c4b-d220-4b0a-83f5-ff621df02800', N'3cd0f5ad-575d-490a-8ab2-0adc2cd5bae2')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'ee558c4b-d220-4b0a-83f5-ff621df02800', N'205b9b50-c670-4c71-8fc9-210d59173ae7')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'ee558c4b-d220-4b0a-83f5-ff621df02800', N'da017386-83d2-4451-8cf2-3474c6664c08')
GO
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'ee558c4b-d220-4b0a-83f5-ff621df02800', N'ff42038a-2a2f-49f4-aa4f-556ff35adab4')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'ee558c4b-d220-4b0a-83f5-ff621df02800', N'c1fb39e7-5e72-4bf8-bc82-88170a8f7ca8')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'ee558c4b-d220-4b0a-83f5-ff621df02800', N'1802c7e4-4b35-4383-bba5-8903470cd38c')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'ee558c4b-d220-4b0a-83f5-ff621df02800', N'4ec02583-44c7-410d-8ec9-e393eaa1ff69')
INSERT [dbo].[User_Course] ([UserId], [CourseId]) VALUES (N'ee558c4b-d220-4b0a-83f5-ff621df02800', N'5158f112-0110-4fbc-b0b6-fbda0ee50808')
ALTER TABLE [dbo].[Group]  WITH CHECK ADD FOREIGN KEY([TopicId], [ProjectId])
REFERENCES [dbo].[Topic_Project] ([TopicId], [ProjectId])
GO
ALTER TABLE [dbo].[Group]  WITH CHECK ADD FOREIGN KEY([Leader])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[Group_Student]  WITH CHECK ADD FOREIGN KEY([GroupId])
REFERENCES [dbo].[Group] ([GroupId])
GO
ALTER TABLE [dbo].[Group_Student]  WITH CHECK ADD FOREIGN KEY([StudentId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[Project]  WITH CHECK ADD FOREIGN KEY([CourseId])
REFERENCES [dbo].[Course] ([CourseId])
GO
ALTER TABLE [dbo].[Student_Topic_Project]  WITH CHECK ADD  CONSTRAINT [FK__Student_T__Stude__286302EC] FOREIGN KEY([StudentId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[Student_Topic_Project] CHECK CONSTRAINT [FK__Student_T__Stude__286302EC]
GO
ALTER TABLE [dbo].[Student_Topic_Project]  WITH CHECK ADD  CONSTRAINT [FK__Student_Topic_Pr__29572725] FOREIGN KEY([TopicId], [ProjectId])
REFERENCES [dbo].[Topic_Project] ([TopicId], [ProjectId])
GO
ALTER TABLE [dbo].[Student_Topic_Project] CHECK CONSTRAINT [FK__Student_Topic_Pr__29572725]
GO
ALTER TABLE [dbo].[Teacher_Topic_Project]  WITH CHECK ADD FOREIGN KEY([TeacherId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[Teacher_Topic_Project]  WITH CHECK ADD FOREIGN KEY([TopicId], [ProjectId])
REFERENCES [dbo].[Topic_Project] ([TopicId], [ProjectId])
GO
ALTER TABLE [dbo].[Topic_Project]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[Topic_Project]  WITH CHECK ADD FOREIGN KEY([TopicId])
REFERENCES [dbo].[Topic] ([TopicId])
GO
ALTER TABLE [dbo].[User_Course]  WITH CHECK ADD FOREIGN KEY([CourseId])
REFERENCES [dbo].[Course] ([CourseId])
GO
ALTER TABLE [dbo].[User_Course]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([UserId])
GO
/****** Object:  StoredProcedure [dbo].[sp_Course_Add]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Course_Add] @CourseId uniqueidentifier,
@CourseName nvarchar(100)
AS
  BEGIN TRAN
    BEGIN TRY
      INSERT INTO [Course] (CourseId, CourseName, CourseStatus)
        VALUES (@CourseId, @CourseName, 0)
    END TRY
    BEGIN CATCH
      RAISERROR ('Error', 16, 1)
      ROLLBACK TRAN
      RETURN
    END CATCH
  COMMIT TRAN



GO
/****** Object:  StoredProcedure [dbo].[sp_Course_AddUser]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Course_AddUser]
	@userId uniqueidentifier,
	@courseId uniqueidentifier
AS 
BEGIN
	BEGIN TRAN
	BEGIN TRY
		INSERT INTO User_Course(CourseId, UserId)
		VALUES (@courseId, @userId)
		COMMIT 
	END TRY
	BEGIN CATCH
		ROLLBACK 
	END CATCH
END

GO
/****** Object:  StoredProcedure [dbo].[sp_Course_Change]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Course_Change] @CourseId uniqueidentifier,
@CourseName nvarchar(100),
@CourseStatus nvarchar(20)
AS
  BEGIN TRAN
    BEGIN TRY
      UPDATE Course
      SET CourseName = @CourseName,
          CourseStatus = @CourseStatus
      WHERE CourseId = @CourseId
    END TRY
    BEGIN CATCH
      RAISERROR ('Error', 16, 1)
      ROLLBACK TRAN
      RETURN
    END CATCH
  COMMIT TRAN



GO
/****** Object:  StoredProcedure [dbo].[sp_Course_GetAll]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Course_GetAll]
AS
  BEGIN TRAN
    BEGIN TRY
      SELECT
        COUNT(*)
      FROM Course
      SELECT
        *
      FROM Course
	  WHERE dbo.Course.CourseStatus	 = 0
    END TRY
    BEGIN CATCH
      RAISERROR ('Error', 16, 1)
      ROLLBACK TRAN
      RETURN
    END CATCH
  COMMIT TRAN



GO
/****** Object:  StoredProcedure [dbo].[sp_Course_GetListByUser]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Course_GetListByUser]
	@userId uniqueidentifier
AS 
	SELECT c.*
	FROM Course c 
		INNER JOIN User_Course uc ON c.CourseId	 = uc.CourseId	
	WHERE uc.UserId	= @userId AND c.CourseStatus = 0

GO
/****** Object:  StoredProcedure [dbo].[sp_Course_Lock]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Course_Lock] 
	@courseId uniqueidentifier 
AS 
BEGIN 
	UPDATE dbo.Course
	SET dbo.Course.CourseStatus	= 1
	WHERE dbo.Course.CourseId	 = @courseId
END 

GO
/****** Object:  StoredProcedure [dbo].[sp_Group_Add]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Group_Add]
	@groupId uniqueidentifier, 
	@groupName nvarchar(100),
	@leader uniqueidentifier , 
	@topicId uniqueidentifier ,
	@projectId uniqueidentifier,
	@capacity int
AS
BEGIN 
	BEGIN TRAN
	BEGIN TRY
		INSERT INTO dbo.[Group]
		(
		    GroupId,
		    GroupName,
		    Leader,
		    TopicId,
		    ProjectId,
		    Capacity
		)
		VALUES
		(
		    @groupId	, -- GroupId - uniqueidentifier
		    @groupName	, -- GroupName - nvarchar
		    @leader, -- Leader - uniqueidentifier
		    @topicId	, -- TopicId - uniqueidentifier
		    @projectId	, -- ProjectId - uniqueidentifier
		    @capacity	 -- Capacity - int
		)
		COMMIT	
	END TRY
	BEGIN CATCH
		ROLLBACK 
	END CATCH
END


GO
/****** Object:  StoredProcedure [dbo].[sp_Group_Student_Add]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Group_Student_Add] @GroupId uniqueidentifier,
@StudentId uniqueidentifier
AS
  BEGIN TRAN
    BEGIN TRY
      DECLARE @Capacity int,
              @ProjectId uniqueidentifier
      SELECT
        @ProjectId = ProjectId,
        @Capacity = Capacity
      FROM [Group]
      WHERE GroupId = @GroupId
      DECLARE @CourseId uniqueidentifier = (SELECT
        CourseId
      FROM Project
      WHERE ProjectId = @ProjectId)

      -- In register time?
      IF NOT EXISTS (SELECT
          *
        FROM Project
        WHERE ProjectId = @ProjectId
        AND StartRegister <= GETDATE()
        AND GETDATE() <= EndRegister)
      BEGIN
        RAISERROR ('Error', 16, 1)
        ROLLBACK TRAN
        RETURN
      END

      -- Student is active
      IF NOT EXISTS (SELECT
          *
        FROM [User]
        WHERE UserId = @StudentId
        AND Status = 0)
      BEGIN
        RAISERROR ('Error', 16, 1)
        ROLLBACK TRAN
        RETURN
      END

      -- Student learn the course
      IF NOT EXISTS (SELECT
          *
        FROM User_Course
        WHERE CourseId = @CourseId
        AND UserId = @StudentId)
      BEGIN
        RAISERROR ('Error', 16, 1)
        ROLLBACK TRAN
        RETURN
      END

      -- Student haven't in project?
      IF EXISTS (SELECT
          *
        FROM [Group] g
        JOIN Group_Student gs
          ON g.GroupId = gs.GroupId
        WHERE g.ProjectId = @ProjectId
        AND StudentId = @StudentId)
      BEGIN
        RAISERROR ('Error', 16, 1)
        ROLLBACK TRAN
        RETURN
      END

      -- Available slot for a new member?
      IF NOT EXISTS (SELECT
          *
        FROM Project
        WHERE ProjectId = @ProjectId
        AND StudentMax > @Capacity)
      BEGIN
        RAISERROR ('Error', 16, 1)
        ROLLBACK TRAN
        RETURN
      END

      UPDATE [Group]
      SET Capacity = @Capacity + 1
      WHERE GroupId = @GroupId

      INSERT INTO Group_Student (GroupId, StudentId)
        VALUES (@GroupId, @StudentId)
    END TRY
    BEGIN CATCH
      RAISERROR ('Error', 16, 1)
      ROLLBACK TRAN
      RETURN
    END CATCH
  COMMIT TRAN



GO
/****** Object:  StoredProcedure [dbo].[sp_Group_Student_Delete]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Group_Student_Delete] @GroupId uniqueidentifier,
@StudentId uniqueidentifier
AS
  BEGIN TRAN
    BEGIN TRY
      DECLARE @Capacity int,
              @ProjectId uniqueidentifier
      SELECT
        @ProjectId = ProjectId,
        @Capacity = Capacity
      FROM [Group]
      WHERE GroupId = @GroupId

      -- In register time?
      IF NOT EXISTS (SELECT
          *
        FROM Project
        WHERE ProjectId = @ProjectId
        AND StartRegister <= GETDATE()
        AND GETDATE() <= EndRegister)
      BEGIN
        RAISERROR ('Error', 16, 1)
        ROLLBACK TRAN
        RETURN
      END

      -- Delete member
      DELETE FROM Group_Student
      WHERE GroupId = @GroupId
        AND StudentId = @StudentId

      IF @Capacity = 1
        DELETE FROM [Group]
        WHERE GroupId = @GroupId
      ELSE
      BEGIN
        -- update Capacity
        UPDATE [Group]
        SET Capacity = @Capacity - 1
        WHERE GroupId = @GroupId
        -- Leader leaves group ?
        IF EXISTS (SELECT
            *
          FROM [Group]
          WHERE GroupId = @GroupId
          AND Leader = @StudentId)
          UPDATE [Group]
          SET Leader = (SELECT TOP (1)
            StudentId
          FROM Group_Student
          WHERE GroupId = @GroupId)
          WHERE GroupId = @GroupId
      END
    END TRY
    BEGIN CATCH
      RAISERROR ('Error', 16, 1)
      ROLLBACK TRAN
      RETURN
    END CATCH
  COMMIT TRAN



GO
/****** Object:  StoredProcedure [dbo].[sp_Project_Add]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Project_Add] @Id uniqueidentifier,
@ProjectTypeName nvarchar(30),
@ProjectName nvarchar(100),
@RegisterFrom datetime,
@RegisterTo datetime,
@Deadline datetime,
@StudentMax int = 1,
@SubjectId uniqueidentifier,
@Limit int
AS
  BEGIN TRAN
    BEGIN TRY
		DECLARE	 @projectTypeId uniqueidentifier	
		SELECT @projectTypeId = pt.ProjectTypeId
		FROM dbo.ProjectType pt	
		WHERE pt.ProjectTypeName = @ProjectTypeName	

		INSERT INTO Project (ProjectId, ProjectTypeId, ProjectName, StartRegister, EndRegister, EndSubmit, StudentMax, CourseId, GroupCapacity)
        VALUES (@Id, @projectTypeId, @ProjectName, @RegisterFrom, @RegisterTo, @Deadline, @StudentMax, @subjectId, @limit)
    END TRY
    BEGIN CATCH
      RAISERROR ('Error', 16, 1)
      ROLLBACK TRAN
      RETURN
    END CATCH
  COMMIT TRAN



GO
/****** Object:  StoredProcedure [dbo].[sp_Project_Change]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Project_Change] @ProjectId uniqueidentifier,
@StartRegister datetime,
@EndRegister datetime,
@EndSubmit datetime,
@StudentMax int,
@GroupCapacity int,
@ProjectType nvarchar(30)
AS
  BEGIN TRAN
    BEGIN TRY
		DECLARE @projectTypeID uniqueidentifier
		SELECT @projectTypeID = ProjectTypeID
		FROM ProjectType
		WHERE ProjectTypeName = @ProjectType

      UPDATE Project
      SET StartRegister = @StartRegister,
          EndRegister = @EndRegister,
          EndSubmit = @EndSubmit,
          StudentMax = @StudentMax,
          GroupCapacity = @GroupCapacity,
		  ProjectTypeId = @projectTypeID
      WHERE ProjectId = @ProjectId
    END TRY
    BEGIN CATCH
      RAISERROR ('Error', 16, 1)
      ROLLBACK TRAN
      RETURN
    END CATCH
  COMMIT TRAN



GO
/****** Object:  StoredProcedure [dbo].[sp_Project_ExtendEndRegister]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Project_ExtendEndRegister]
	@ProjectId UNIQUEIDENTIFIER,
    @Day int
as
begin tran
	begin try
		declare @EndRegister datetime = (select EndRegister from Project where ProjectId = @ProjectId)
		update Project set EndRegister = dateadd(day, @Day, @EndRegister) where ProjectId = @ProjectId
	end try
	begin catch
		raiserror('Error', 16, 1)
		rollback tran
		return
	end catch
	commit tran



GO
/****** Object:  StoredProcedure [dbo].[sp_Project_ExtendEndSubmit]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Project_ExtendEndSubmit]
	@ProjectId UNIQUEIDENTIFIER,
    @Day int
as
begin tran
	begin try
		declare @EndSubmit datetime = (select EndSubmit from Project where ProjectId = @ProjectId)
		update Project set EndSubmit = dateadd(day, @Day, @EndSubmit) where ProjectId = @ProjectId
	end try
	begin catch
		raiserror('Error', 16, 1)
		rollback tran
		return
	end catch
	commit tran



GO
/****** Object:  StoredProcedure [dbo].[sp_Project_GetCannotRegister]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Project_GetCannotRegister] @CourseId uniqueidentifier
AS
  BEGIN TRAN
    BEGIN TRY
      SELECT
        COUNT(ProjectId)
      FROM Project p
      JOIN ProjectType pt
        ON p.ProjectTypeId = pt.ProjectTypeId
      WHERE p.CourseId = @CourseId
      AND NOT (StartRegister <= GETDATE()
      AND GETDATE() <= EndRegister)
      SELECT
        p.ProjectId,
		p.ProjectName,
		p.StartRegister as 'RegisterFrom',
		p.EndRegister as 'RegisterTo',
		p.EndSubmit as 'Deadline',
		c.CourseName,
		p.GroupCapacity,
		p.StudentMax,
		pt.ProjectTypeName
      FROM Project p
			INNER JOIN ProjectType pt ON p.ProjectTypeId = pt.ProjectTypeId
			INNER JOIN Course c ON p.CourseId = c.CourseId
      WHERE p.CourseId = @CourseId
      AND NOT (StartRegister <= GETDATE()
      AND GETDATE() <= EndRegister)
    END TRY
    BEGIN CATCH
      RAISERROR ('Error', 16, 1)
      ROLLBACK TRAN
      RETURN
    END CATCH
  COMMIT TRAN



GO
/****** Object:  StoredProcedure [dbo].[sp_Project_GetCanRegister]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Project_GetCanRegister] @CourseId uniqueidentifier
AS
  BEGIN TRAN
    BEGIN TRY
      SELECT
        COUNT(ProjectId)
      FROM Project p
      JOIN ProjectType pt
        ON p.ProjectTypeId = pt.ProjectTypeId
      WHERE p.CourseId = @CourseId
      AND StartRegister <= GETDATE()
      AND GETDATE() <= EndRegister
      SELECT
        p.ProjectId,
		p.ProjectName,
		p.StartRegister as 'RegisterFrom',
		p.EndRegister as 'RegisterTo',
		p.EndSubmit as 'Deadline',
		c.CourseName,
		p.GroupCapacity,
		p.StudentMax,
		pt.ProjectTypeName
      FROM Project p
			INNER JOIN ProjectType pt ON p.ProjectTypeId = pt.ProjectTypeId
			INNER JOIN Course c ON p.CourseId = c.CourseId
      WHERE p.CourseId = @CourseId
      AND StartRegister <= GETDATE()
      AND GETDATE() <= EndRegister
    END TRY
    BEGIN CATCH
      RAISERROR ('Error', 16, 1)
      ROLLBACK TRAN
      RETURN
    END CATCH
  COMMIT TRAN



GO
/****** Object:  StoredProcedure [dbo].[sp_Project_GetDetail]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Project_GetDetail]
	@projectId uniqueidentifier
AS
	SELECT
        p.ProjectId,
		p.ProjectName,
		p.StartRegister as 'RegisterFrom',
		p.EndRegister as 'RegisterTo',
		p.EndSubmit as 'Deadline',
		p.GroupCapacity,
		p.StudentMax,
		pt.ProjectTypeName
      FROM Project p
		INNER JOIN ProjectType pt ON p.ProjectTypeId = pt.ProjectTypeId
	  WHERE p.ProjectId = @projectId

GO
/****** Object:  StoredProcedure [dbo].[sp_Project_GetListByCourseId]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Project_GetListByCourseId] @CourseId uniqueidentifier
AS
  BEGIN TRAN
    BEGIN TRY
      SELECT
        COUNT(ProjectId)
      FROM Project p
      JOIN ProjectType pt
        ON p.ProjectTypeId = pt.ProjectTypeId
      WHERE p.CourseId = @CourseId
      SELECT
        p.ProjectId,
		p.ProjectName,
		p.StartRegister as 'RegisterFrom',
		p.EndRegister as 'RegisterTo',
		p.EndSubmit as 'Deadline',
		c.CourseName,
		p.GroupCapacity,
		p.StudentMax,
		pt.ProjectTypeName
      FROM Project p
			INNER JOIN ProjectType pt ON p.ProjectTypeId = pt.ProjectTypeId
			INNER JOIN Course c ON p.CourseId = c.CourseId
      WHERE p.CourseId = @CourseId
    END TRY
    BEGIN CATCH
      RAISERROR ('Error', 16, 1)
      ROLLBACK TRAN
      RETURN
    END CATCH
  COMMIT TRAN



GO
/****** Object:  StoredProcedure [dbo].[sp_Project_GetListPractice]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Project_GetListPractice]
AS
BEGIN
	SELECT COUNT(*)
	FROM Project p 
	INNER JOIN ProjectType pt ON p.ProjectTypeId = pt.ProjectTypeId
	INNER JOIN dbo.Course c ON p.CourseId = c.CourseId	AND c.CourseStatus	= 0
	WHERE pt.ProjectTypeName = 'Practice'
	SELECT p.*, pt.ProjectTypeName,c.CourseName
	FROM Project p 
	INNER JOIN ProjectType pt ON p.ProjectTypeId = pt.ProjectTypeId
	INNER JOIN dbo.Course c ON p.CourseId = c.CourseId	AND c.CourseStatus	= 0
	WHERE pt.ProjectTypeName = 'Practice'
END

GO
/****** Object:  StoredProcedure [dbo].[sp_Project_IsRegister]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Project_IsRegister]
	@projectId uniqueidentifier ,
	@userId uniqueidentifier 
AS
	SELECT 1 
	FROM dbo.Student_Topic_Project stp	
	WHERE stp.StudentId	 = @userId AND stp.ProjectId = @projectId	
	UNION ALL 
	SELECT 1 
	FROM [Group] g
	WHERE g.Leader	 = @userId AND g.ProjectId	 = @projectId
	UNION ALL 
	SELECT 1 
	FROM dbo.Group_Student gs	
		INNER JOIN dbo.[Group] g ON gs.GroupId = g.GroupId	
	WHERE gs.StudentId	 = @userId AND g.ProjectId	 = @projectId	

GO
/****** Object:  StoredProcedure [dbo].[sp_ProjectType_GetList]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ProjectType_GetList]
AS 
	SELECT *
	FROM ProjectType

GO
/****** Object:  StoredProcedure [dbo].[sp_Student_Topic_Project_Add]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Student_Topic_Project_Add] @StudentId uniqueidentifier,
@TopicId uniqueidentifier,
@ProjectId uniqueidentifier
AS
  BEGIN TRAN
    BEGIN TRY
      DECLARE @CourseId uniqueidentifier = (SELECT
        CourseId
      FROM Project
      WHERE ProjectId = @ProjectId)

      -- In register time?
      IF NOT EXISTS (SELECT
          *
        FROM Project
        WHERE ProjectId = @ProjectId
        AND StartRegister < GETDATE()
        AND GETDATE() < EndRegister)
      BEGIN
        RAISERROR ('Error', 16, 1)
        ROLLBACK TRAN
        RETURN
      END

      -- Course is open
      IF NOT EXISTS (SELECT
          *
        FROM Course
        WHERE CourseId = @CourseId
        AND CourseStatus = 0)
      BEGIN
        RAISERROR ('Error', 16, 1)
        ROLLBACK TRAN
        RETURN
      END

      -- Topic is in project because of foreign key

      -- Student is active
      IF NOT EXISTS (SELECT
          *
        FROM [User]
        WHERE UserId = @StudentId
        AND Status = 0)
      BEGIN
        RAISERROR ('Error', 16, 1)
        ROLLBACK TRAN
        RETURN
      END

      -- Student learn the course
      IF NOT EXISTS (SELECT
          *
        FROM User_Course
        WHERE CourseId = @CourseId
        AND UserId = @StudentId)
      BEGIN
        RAISERROR ('Error', 16, 1)
        ROLLBACK TRAN
        RETURN
      END

      -- Personal Project?
      --IF NOT EXISTS (SELECT
      --    *
      --  FROM Project	
      --  WHERE ProjectId = @ProjectId
      --  AND StudentMax > 1)
      --BEGIN
      --  RAISERROR ('Error', 16, 1)
      --  ROLLBACK TRAN
      --  RETURN
      --END

      -- Available slot?
      DECLARE @Capacity int,
              @Quantity int
      SELECT
        @Capacity = GroupCapacity
      FROM Project
      WHERE ProjectId = @ProjectId
      SELECT
        @Quantity = COUNT(*)
      FROM Student_Topic_Project
      WHERE ProjectId = @ProjectId
      AND TopicId = @TopicId
      IF @Capacity <= @Quantity
      BEGIN
        RAISERROR ('Error', 16, 1)
        ROLLBACK TRAN
        RETURN
      END

      INSERT INTO Student_Topic_Project (StudentId, TopicId, ProjectId)
        VALUES (@StudentId, @TopicId, @ProjectId)
    END TRY
    BEGIN CATCH
      RAISERROR ('Error', 16, 1)
      ROLLBACK TRAN
      RETURN
    END CATCH
  COMMIT TRAN



GO
/****** Object:  StoredProcedure [dbo].[sp_Topic_Add]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Topic_Add] @TopicId uniqueidentifier,
@Title nvarchar(100),
@Content nvarchar(max),
@projectId uniqueidentifier
AS
  BEGIN TRAN
    BEGIN TRY
      IF NOT EXISTS (SELECT 1 FROM Topic WHERE TopicId  = @TopicId)
	  BEGIN
		INSERT INTO Topic (TopicID, Title, Content)
		VALUES (@TopicId, @title, @content)
	  END 
	  INSERT INTO Topic_Project (TopicId, ProjectId)
	  VALUES (@TopicId , @projectId)
	  COMMIT TRAN
    END TRY
    BEGIN CATCH
      RAISERROR ('Error', 16, 1)
      ROLLBACK TRAN
      RETURN
    END CATCH
  


GO
/****** Object:  StoredProcedure [dbo].[sp_Topic_Delete]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Topic_Delete] @TopicId uniqueidentifier
AS
  BEGIN TRAN
    BEGIN TRY
      DELETE FROM Topic
      WHERE TopicId = @TopicId
    END TRY
    BEGIN CATCH
      RAISERROR ('Error', 16, 1)
      ROLLBACK TRAN
      RETURN
    END CATCH
  COMMIT TRAN



GO
/****** Object:  StoredProcedure [dbo].[sp_Topic_GetDetail]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Topic_GetDetail]
	@topicId uniqueidentifier
AS
	SELECT *
	FROM Topic
	WHERE TopicId = @topicId

GO
/****** Object:  StoredProcedure [dbo].[sp_Topic_GetDetailByProject]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Topic_GetDetailByProject]
	@projectId uniqueidentifier ,
	@userId uniqueidentifier 
AS
BEGIN
	SELECT TOP 1 *
	FROM dbo.Topic t	
	WHERE t.TopicId	 IN
	(
		SELECT stp.TopicId
		FROM dbo.Student_Topic_Project stp	
		WHERE stp.StudentId	 = @userId AND stp.ProjectId = @projectId	
		UNION ALL 
		SELECT g.TopicId
		FROM [Group] g
		WHERE g.Leader	 = @userId AND g.ProjectId	 = @projectId
		UNION ALL 
		SELECT g.TopicId
		FROM dbo.Group_Student gs	
			INNER JOIN dbo.[Group] g ON gs.GroupId = g.GroupId	
		WHERE gs.StudentId	 = @userId AND g.ProjectId	 = @projectId	
	)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_Topic_GetFullTopic]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Topic_GetFullTopic] @ProjectId uniqueidentifier
AS
  BEGIN TRAN
    BEGIN TRY
      -- Individual project
      IF (SELECT
          StudentMax
        FROM Project
        WHERE ProjectId = @ProjectId)
        = 1
      BEGIN
        SELECT
          COUNT(*)
        FROM Topic t
        WHERE (SELECT
          GroupCapacity
        FROM Project
        WHERE ProjectId = @ProjectId)
        = (SELECT
          COUNT(stp.StudentId)
        FROM Student_Topic_Project stp
        WHERE stp.TopicId = t.TopicId
        AND stp.ProjectId = @ProjectId)
        SELECT
          *
        FROM Topic t
        WHERE (SELECT
          GroupCapacity
        FROM Project
        WHERE ProjectId = @ProjectId)
        = (SELECT
          COUNT(stp.StudentId)
        FROM Student_Topic_Project stp
        WHERE stp.TopicId = t.TopicId
        AND stp.ProjectId = @ProjectId)
      END
      -- Group project
      ELSE
      BEGIN
        SELECT
          COUNT(*)
        FROM Topic t
        WHERE (SELECT
          GroupCapacity
        FROM Project
        WHERE ProjectId = @ProjectId)
        = (SELECT
          COUNT(g.GroupId)
        FROM [Group] g
        WHERE g.TopicId = t.TopicId
        AND g.ProjectId = @ProjectId)
        SELECT
          *
        FROM Topic t
        WHERE (SELECT
          GroupCapacity
        FROM Project
        WHERE ProjectId = @ProjectId)
        = (SELECT
          COUNT(g.GroupId)
        FROM [Group] g
        WHERE g.TopicId = t.TopicId
        AND g.ProjectId = @ProjectId)
      END
    END TRY
    BEGIN CATCH
      RAISERROR ('Error', 16, 1)
      ROLLBACK TRAN
      RETURN
    END CATCH
  COMMIT TRAN



GO
/****** Object:  StoredProcedure [dbo].[sp_Topic_GetList]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Topic_GetList]
AS 
SELECT *
FROM Topic

GO
/****** Object:  StoredProcedure [dbo].[sp_Topic_GetListByProjectId]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Topic_GetListByProjectId] @ProjectId uniqueidentifier
AS
  BEGIN TRAN
    BEGIN TRY
      SELECT
        COUNT(*)
      FROM Topic t 
		INNER JOIN Topic_Project tp ON t.TopicId = tp.TopicId
	  WHERE tp.ProjectId = @ProjectId
      
      SELECT
        t.*
      FROM Topic t 
		INNER JOIN Topic_Project tp ON t.TopicId = tp.TopicId
	  WHERE tp.ProjectId = @ProjectId
    END TRY
    BEGIN CATCH
      RAISERROR ('Error', 16, 1)
      ROLLBACK TRAN
      RETURN
    END CATCH
  COMMIT TRAN



GO
/****** Object:  StoredProcedure [dbo].[sp_Topic_GetNotFullTopic]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Topic_GetNotFullTopic] @ProjectId uniqueidentifier
AS
  BEGIN TRAN
    BEGIN TRY
      -- individual project
      IF (SELECT
          StudentMax
        FROM Project
        WHERE ProjectId = @ProjectId)
        = 1
      BEGIN
        SELECT
          COUNT(*)
        FROM Topic t
        WHERE EXISTS (SELECT
          *
        FROM Topic_Project tp
        WHERE tp.TopicId = t.TopicId
        AND tp.ProjectId = @ProjectId)
        AND (SELECT
          GroupCapacity
        FROM Project
        WHERE ProjectId = @ProjectId)
        > (SELECT
          COUNT(stp.StudentId)
        FROM Student_Topic_Project stp
        WHERE stp.TopicId = t.TopicId
        AND stp.ProjectId = @ProjectId)
        SELECT
          *
        FROM Topic t
        WHERE EXISTS (SELECT
          *
        FROM Topic_Project tp
        WHERE tp.TopicId = t.TopicId
        AND tp.ProjectId = @ProjectId)
        AND (SELECT
          GroupCapacity
        FROM Project
        WHERE ProjectId = @ProjectId)
        > (SELECT
          COUNT(stp.StudentId)
        FROM Student_Topic_Project stp
        WHERE stp.TopicId = t.TopicId
        AND stp.ProjectId = @ProjectId)
      END
      -- Group project
      ELSE
      BEGIN
        SELECT
          COUNT(*)
        FROM Topic t
        WHERE EXISTS (SELECT
          *
        FROM Topic_Project tp
        WHERE tp.TopicId = t.TopicId
        AND tp.ProjectId = @ProjectId)
        AND (SELECT
          GroupCapacity
        FROM Project
        WHERE ProjectId = @ProjectId)
        > (SELECT
          COUNT(g.GroupId)
        FROM [Group] g
        WHERE g.TopicId = t.TopicId
        AND g.ProjectId = @ProjectId)
        SELECT
          COUNT(*)
        FROM Topic t
        WHERE EXISTS (SELECT
          *
        FROM Topic_Project tp
        WHERE tp.TopicId = t.TopicId
        AND tp.ProjectId = @ProjectId)
        AND (SELECT
          GroupCapacity
        FROM Project
        WHERE ProjectId = @ProjectId)
        > (SELECT
          COUNT(g.GroupId)
        FROM [Group] g
        WHERE g.TopicId = t.TopicId
        AND g.ProjectId = @ProjectId)
      END
    END TRY
    BEGIN CATCH
      RAISERROR ('Error', 16, 1)
      ROLLBACK TRAN
      RETURN
    END CATCH
  COMMIT TRAN



GO
/****** Object:  StoredProcedure [dbo].[sp_Topic_Project_Add]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Topic_Project_Add] @TopicId uniqueidentifier,
@ProjectId uniqueidentifier
AS
  BEGIN TRAN
    BEGIN TRY
      INSERT INTO Topic_Project (TopicId, ProjectId)
        VALUES (@TopicId, @ProjectId)
    END TRY
    BEGIN CATCH
      RAISERROR ('Error', 16, 1)
      ROLLBACK TRAN
      RETURN
    END CATCH
  COMMIT TRAN



GO
/****** Object:  StoredProcedure [dbo].[sp_Topic_Project_Delete]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Topic_Project_Delete] @TopicId uniqueidentifier,
@ProjectId uniqueidentifier
AS
  BEGIN TRAN
    BEGIN TRY
      DELETE FROM Topic_Project
      WHERE TopicId = @TopicId
        AND ProjectId = @ProjectId
    END TRY
    BEGIN CATCH
      RAISERROR ('Error', 16, 1)
      ROLLBACK TRAN
      RETURN
    END CATCH
  COMMIT TRAN



GO
/****** Object:  StoredProcedure [dbo].[sp_User_Add]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_User_Add] @UserId uniqueidentifier,
@FullName nvarchar(50),
@UserName nvarchar(50),
@Password varchar(100),
@UserType nvarchar(20),
@Email nvarchar(100) = '',
@Phone varchar(15) = '',
@Address nvarchar(max) = ''
AS
  BEGIN TRAN
    BEGIN TRY
      IF EXISTS (SELECT
          *
        FROM [User]
        WHERE UserName = @UserName)
      BEGIN
        RAISERROR ('Username already exists', 16, 1)
        ROLLBACK TRAN
        RETURN
      END
      INSERT INTO [User] (UserId, FullName, UserName, [Password], UserType, Status, Email, Phone, Address)
        VALUES (@UserId, @FullName, @UserName, @Password, @UserType, 0, @Email, @Phone, @Address)
    END TRY
    BEGIN CATCH
      RAISERROR ('Error', 16, 1)
      ROLLBACK TRAN
      RETURN
    END CATCH
  COMMIT TRAN



GO
/****** Object:  StoredProcedure [dbo].[sp_User_GetAll]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_User_GetAll]
AS
  BEGIN TRAN
    BEGIN TRY
      SELECT
        COUNT(*)
      FROM [User]
      WHERE Status > -1
      SELECT
        UserId,
        FullName,
        UserName,
        UserType,
        Status,
        Email,
        Phone,
        Address
      FROM [User]
      WHERE Status > -1
    END TRY
    BEGIN CATCH
      RAISERROR ('Error', 16, 1)
      ROLLBACK TRAN
      RETURN
    END CATCH
  COMMIT TRAN



GO
/****** Object:  StoredProcedure [dbo].[sp_User_GetDetail]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_User_GetDetail]
	@userId uniqueidentifier
AS 
	SELECT *
	FROM [User] u
	WHERE u.UserId	 = @userId	

GO
/****** Object:  StoredProcedure [dbo].[sp_User_GetListBySubject]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_User_GetListBySubject]
	@subjectId uniqueidentifier
AS 
	SELECT u.* 
	FROM [User] u 
		INNER JOIN dbo.User_Course uc ON u.UserId = uc.UserId
	WHERE u.Status = 0 AND uc.CourseId	= @subjectId AND u.UserType	= 'Teacher'



GO
/****** Object:  StoredProcedure [dbo].[sp_User_GetListStudents]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_User_GetListStudents]
AS 
BEGIN
	SELECT u.*
	FROM [User] u
	WHERE u.UserType = 'Student'
END

GO
/****** Object:  StoredProcedure [dbo].[sp_User_GetListStudentsBySubject]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_User_GetListStudentsBySubject]
	@subjectId uniqueidentifier	
AS
BEGIN
	SELECT u.*
	FROM [User] u 
		INNER JOIN dbo.User_Course uc ON u.UserId = uc.UserId
		INNER JOIN dbo.Course c ON uc.CourseId = c.CourseId	AND c.CourseStatus = 0
	WHERE u.Status = 0 AND uc.CourseId	 = @subjectId AND u.UserType = 'Student'
END

GO
/****** Object:  StoredProcedure [dbo].[sp_User_GetListTeachers]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_User_GetListTeachers]
AS 
BEGIN
	SELECT u.*
	FROM [User] u
	WHERE u.UserType = 'Teacher'
END

GO
/****** Object:  StoredProcedure [dbo].[sp_User_Login]    Script Date: 6/16/2017 1:18:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_User_Login]
	@username nvarchar(100),
	@password nvarchar(100)
AS 
	SELECT * 
	FROM [User] u 
	WHERE u.UserName = @username AND u.Password = @password AND u.Status = 0

GO
USE [master]
GO
ALTER DATABASE [hqt-yes] SET  READ_WRITE 
GO
