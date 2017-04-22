CREATE DATABASE [hqt-yes]

GO 

USE [hqt-yes]

GO

CREATE TABLE [Subject]
( 
	Id UNIQUEIDENTIFIER PRIMARY KEY,
	SubjectCode NVARCHAR(10),
	SubjectName NVARCHAR(100),
	[Status] NVARCHAR(20)
) 

GO 

CREATE TABLE Project 
(
	Id UNIQUEIDENTIFIER PRIMARY KEY,	 
    ProjectCode NVARCHAR(10),
    ProjectType NVARCHAR(30),
    StartRegister  DATETIME, 
    EndRegister DATETIME, 
    EndSubmit DATETIME, 
    Capacity   INT, 
    Minimum   INT, 
    SubjectId    UNIQUEIDENTIFIER,
    FOREIGN KEY (SubjectId) REFERENCES [Subject](Id) 
) 

GO  

CREATE TABLE [User]
( 
	Id UNIQUEIDENTIFIER PRIMARY KEY ,
    UserName   NVARCHAR(50), 
    [Password]     VARCHAR(100), 
    [Role]    NVARCHAR(20), 
) 

GO  

CREATE TABLE Teacher_Subject 
( 
    TeacherId UNIQUEIDENTIFIER,
    SubjectId  UNIQUEIDENTIFIER,
    PRIMARY KEY(TeacherId, SubjectId), 
    FOREIGN KEY (TeacherId) REFERENCES [User](Id), 
    FOREIGN KEY (SubjectId) REFERENCES [Subject](Id) 
) 

GO  

CREATE TABLE Practice 
( 
    Id UNIQUEIDENTIFIER PRIMARY KEY ,
    Content NVARCHAR(MAX), 
    Capacity INT, 
    ProjectId UNIQUEIDENTIFIER,
    FOREIGN KEY (ProjectId) REFERENCES Project(Id) 
) 

GO 

CREATE TABLE [Group]
  ( 
     Id UNIQUEIDENTIFIER PRIMARY KEY, 
     GroupName NVARCHAR(50), 
     Capacity INT, 
     PracticeId UNIQUEIDENTIFIER,
     FOREIGN KEY (PracticeId) REFERENCES Practice(Id),
  ) 

GO 

CREATE TABLE [GroupDetail] 
( 
    GroupId   UNIQUEIDENTIFIER ,
    StudentId UNIQUEIDENTIFIER ,
	IsLeader NVARCHAR(5),
    PRIMARY KEY (GroupId, StudentId), 
    FOREIGN KEY (GroupId) REFERENCES [Group](Id), 
    FOREIGN KEY (StudentId) REFERENCES [User](Id) 
) 

GO  

CREATE TABLE Student_Practice 
( 
    StudentId UNIQUEIDENTIFIER,
    PracticeId UNIQUEIDENTIFIER,
    PRIMARY KEY (StudentId, PracticeId), 
    FOREIGN KEY (PracticeId) REFERENCES Practice(Id), 
    FOREIGN KEY (StudentId) REFERENCES [User](Id) 
) 

GO 

CREATE TABLE Student_Subject 
( 
    StudentId UNIQUEIDENTIFIER,
    SubjectId UNIQUEIDENTIFIER, 
    PRIMARY KEY (StudentId, SubjectId), 
    FOREIGN KEY (SubjectId) REFERENCES [Subject](Id), 
    FOREIGN KEY (StudentId) REFERENCES [User](Id) 
) 