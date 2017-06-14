USE [master]
GO
/****** Object:  Database [hqt-yes]    Script Date: 6/14/2017 10:46:32 PM ******/
CREATE DATABASE [hqt-yes]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'hqt-yes', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\hqt-yes.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'hqt-yes_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\hqt-yes_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
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
/****** Object:  Table [dbo].[Course]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  Table [dbo].[Group]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  Table [dbo].[Group_Student]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  Table [dbo].[Project]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  Table [dbo].[ProjectType]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  Table [dbo].[Student_Topic_Project]    Script Date: 6/14/2017 10:46:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student_Topic_Project](
	[StudentId] [uniqueidentifier] NOT NULL,
	[ProjectId] [uniqueidentifier] NOT NULL,
	[TopicId] [uniqueidentifier] NULL,
PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC,
	[ProjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Teacher_Topic_Project]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  Table [dbo].[Topic]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  Table [dbo].[Topic_Project]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  Table [dbo].[User]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  Table [dbo].[User_Course]    Script Date: 6/14/2017 10:46:33 PM ******/
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
ALTER TABLE [dbo].[Student_Topic_Project]  WITH CHECK ADD FOREIGN KEY([StudentId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[Student_Topic_Project]  WITH CHECK ADD FOREIGN KEY([TopicId], [ProjectId])
REFERENCES [dbo].[Topic_Project] ([TopicId], [ProjectId])
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
/****** Object:  StoredProcedure [dbo].[sp_Course_Add]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Course_AddUser]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Course_Change]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Course_GetAll]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Course_GetListByUser]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Course_Lock]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Group_Add]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Group_Student_Add]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Group_Student_Delete]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Project_Add]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Project_Change]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Project_ExtendEndRegister]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Project_ExtendEndSubmit]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Project_GetCannotRegister]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Project_GetCanRegister]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Project_GetDetail]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Project_GetListByCourseId]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Project_GetListPractice]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Project_IsRegister]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ProjectType_GetList]    Script Date: 6/14/2017 10:46:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ProjectType_GetList]
AS 
	SELECT *
	FROM ProjectType
GO
/****** Object:  StoredProcedure [dbo].[sp_Student_Topic_Project_Add]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Topic_Add]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Topic_Delete]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Topic_GetDetail]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Topic_GetDetailByProject]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Topic_GetFullTopic]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Topic_GetList]    Script Date: 6/14/2017 10:46:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Topic_GetList]
AS 
SELECT *
FROM Topic
GO
/****** Object:  StoredProcedure [dbo].[sp_Topic_GetListByProjectId]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Topic_GetNotFullTopic]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Topic_Project_Add]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Topic_Project_Delete]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_User_Add]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_User_GetAll]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_User_GetDetail]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_User_GetListBySubject]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_User_GetListStudents]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_User_GetListStudentsBySubject]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_User_GetListTeachers]    Script Date: 6/14/2017 10:46:33 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_User_Login]    Script Date: 6/14/2017 10:46:33 PM ******/
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
