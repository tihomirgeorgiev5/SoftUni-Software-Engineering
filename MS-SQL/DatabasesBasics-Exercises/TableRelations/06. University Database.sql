CREATE DATABASE [UniversityDatabase]
USE [UniversityDatabase]

CREATE TABLE [Majors] (
[MajorID] INT PRIMARY KEY NOT NULL,
[Name] VARCHAR(50) NOT NULL)

CREATE TABLE [Subjects] (
[SubjectID] INT PRIMARY KEY IDENTITY NOT NULL,
[SubjectName] VARCHAR(50) NOT NULL)

CREATE TABLE [Students] (
[StudentID] INT PRIMARY KEY IDENTITY NOT NULL,
[StudentNumber] INT NOT NULL,
[StudentName] VARCHAR(50) NOT NULL,
[MajorID] INT FOREIGN KEY REFERENCES [Majors] ([MajorID]))

CREATE TABLE [Payments] (
[PaymentID] INT PRIMARY KEY IDENTITY NOT NULL,
[PaymentDate] DATE NOT NULL,
[PaymentAmount] DECIMAL(7,2) NOT NULL,
[StudentID] INT FOREIGN KEY REFERENCES [Students] ([StudentID]))

CREATE TABLE [Agenda] (
[StudentID] INT FOREIGN KEY REFERENCES [Students] ([StudentID]),
[SubjectID] INT FOREIGN KEY REFERENCES [Subjects] ([SubjectID]),
PRIMARY KEY ([StudentID],[SubjectID]))


