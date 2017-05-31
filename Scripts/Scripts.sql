
CREATE DATABASE [hqt-yes]

GO

USE [hqt-yes]

GO

CREATE TABLE Course (
  CourseId uniqueidentifier PRIMARY KEY,
  CourseName nvarchar(100),
  CourseStatus int -- 0: open, 1: closed
)

GO

CREATE TABLE Project (
  ProjectId uniqueidentifier PRIMARY KEY,
  ProjectTypeId nvarchar(30),
  ProjectName nvarchar(100),
  StartRegister datetime,
  EndRegister datetime,
  EndSubmit datetime,
  StudentMax int,
  -- StudentMin   INT,
  CourseId uniqueidentifier,
  GroupCapacity int,
  FOREIGN KEY (CourseId) REFERENCES Course (CourseId)
)

GO

CREATE TABLE ProjectType (
  ProjectTypeId uniqueidentifier PRIMARY KEY,
  ProjectTypeName nvarchar(30)
)

GO

CREATE TABLE [User] (
  UserId uniqueidentifier PRIMARY KEY,
  FullName nvarchar(50),
  UserName nvarchar(50),
  [Password] varchar(100),
  UserType nvarchar(20),
  Status int, -- -1: delete; 0: active; 1: locked
  Email nvarchar(100),
  Phone varchar(15),
  Address nvarchar(max)
)

GO

CREATE TABLE User_Course (
  UserId uniqueidentifier,
  CourseId uniqueidentifier,
  PRIMARY KEY (UserId, CourseId),
  FOREIGN KEY (UserId) REFERENCES [User] (UserId),
  FOREIGN KEY (CourseId) REFERENCES Course (CourseId)
)

GO

CREATE TABLE Topic (
  TopicId uniqueidentifier PRIMARY KEY,
  Title nvarchar(100),
  Content nvarchar(max)
)

GO

CREATE TABLE Topic_Project (
  TopicId uniqueidentifier,
  ProjectId uniqueidentifier,
  PRIMARY KEY (TopicId, ProjectId),
  FOREIGN KEY (TopicId) REFERENCES Topic (TopicId),
  FOREIGN KEY (ProjectId) REFERENCES Project (ProjectId)
)

GO

CREATE TABLE Teacher_Topic_Project (
  TeacherId uniqueidentifier,
  TopicId uniqueidentifier,
  ProjectId uniqueidentifier,
  PRIMARY KEY (TeacherId, TopicId, ProjectId),
  FOREIGN KEY (TeacherId) REFERENCES [User] (UserId),
  FOREIGN KEY (TopicId, ProjectId) REFERENCES Topic_Project (TopicId, ProjectId)
)

GO

CREATE TABLE [Group] (
  GroupId uniqueidentifier PRIMARY KEY,
  GroupName nvarchar(50),
  Leader uniqueidentifier,
  TopicId uniqueidentifier,
  ProjectId uniqueidentifier,
  FOREIGN KEY (Leader) REFERENCES [User] (UserId),
  FOREIGN KEY (TopicId, ProjectId) REFERENCES Topic_Project (TopicId, ProjectId)
)

GO

CREATE TABLE Group_Student (
  GroupId uniqueidentifier,
  StudentId uniqueidentifier,
  PRIMARY KEY (GroupId, StudentId),
  FOREIGN KEY (GroupId) REFERENCES [Group] (GroupId),
  FOREIGN KEY (StudentId) REFERENCES [User] (UserId)
)

GO

CREATE TABLE Student_Topic_Project (
  StudentId uniqueidentifier,
  ProjectId uniqueidentifier,
  TopicId uniqueidentifier,
  PRIMARY KEY (StudentId, ProjectId),
  FOREIGN KEY (StudentId) REFERENCES [User] (UserId),
  FOREIGN KEY (TopicId, ProjectId) REFERENCES Topic_Project (TopicId, ProjectId)
)