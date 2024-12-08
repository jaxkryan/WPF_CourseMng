CREATE DATABASE [Finally]
GO
USE [Finally]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 2024/08/20 19:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 2024/08/20 19:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
	[email] [nvarchar](30) NULL,
	[Role_ID] [int] NULL,
	[status] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 2024/08/20 19:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](50) NULL,
	[DateOfBirth] [date] NULL,
	[gender] [int] NULL,
	[PhoneNumber] [nvarchar](20) NULL,
	[address] [nvarchar](100) NULL,
	[Account_ID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Classes]    Script Date: 2024/08/20 19:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Classes](
	[ID] [int] NOT NULL,
	[name] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClassStu]    Script Date: 2024/08/20 19:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClassStu](
	[Class_ID] [int] NOT NULL,
	[Student_ID] [int] NOT NULL,
	[Course] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Class_ID] ASC,
	[Student_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 2024/08/20 19:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[ID] [int] NOT NULL,
	[name] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GradeDetail]    Script Date: 2024/08/20 19:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GradeDetail](
	[GradeID] [int] NOT NULL,
	[PresentScore] [decimal](5, 2) NULL,
	[LabScore] [decimal](5, 2) NULL,
	[PTScore] [decimal](5, 2) NULL,
	[FEScore] [decimal](5, 2) NULL,
	[OverallScore] [decimal](5, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[GradeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grades]    Script Date: 2024/08/20 19:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grades](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Student_ID] [int] NULL,
	[Class_ID] [int] NULL,
	[Teacher_ID] [int] NULL,
	[grade] [int] NOT NULL,
	[DayOfGrade] [date] NULL,
	[subject] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 2024/08/20 19:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[ID] [int] NOT NULL,
	[name] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Schedules]    Script Date: 2024/08/20 19:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Schedules](
	[DayOfWeeks] [nvarchar](50) NULL,
	[slot] [int] NULL,
	[Class_ID] [int] NULL,
	[Teacher_ID] [int] NULL,
	[SubjectID] [int] NULL,
	[ScheduleID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Schedules_ScheduleID] PRIMARY KEY CLUSTERED 
(
	[ScheduleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ScheduleStu]    Script Date: 2024/08/20 19:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ScheduleStu](
	[ScheduleStuID] [int] IDENTITY(1,1) NOT NULL,
	[ScheduleID] [int] NOT NULL,
	[StudentID] [int] NOT NULL,
	[Status] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ScheduleStuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 2024/08/20 19:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](50) NULL,
	[DateOfBirth] [date] NULL,
	[gender] [int] NULL,
	[PhoneNumber] [nvarchar](20) NULL,
	[address] [nvarchar](100) NULL,
	[Account_ID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 2024/08/20 19:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 2024/08/20 19:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](50) NULL,
	[DateOfBirth] [date] NULL,
	[gender] [int] NULL,
	[PhoneNumber] [nvarchar](20) NULL,
	[address] [nvarchar](100) NULL,
	[Department_ID] [int] NULL,
	[Account_ID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TeachSubject]    Script Date: 2024/08/20 19:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TeachSubject](
	[TeacherID] [int] NOT NULL,
	[SubjectID] [int] NOT NULL,
	[Course] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TeacherID] ASC,
	[SubjectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Accounts] ON 

INSERT [dbo].[Accounts] ([ID], [username], [password], [email], [Role_ID], [status]) VALUES (1, N'teacher1', N'mLEzt$no', N'chungcqkhe170745@fpt.edu.vn', 1, 1)
INSERT [dbo].[Accounts] ([ID], [username], [password], [email], [Role_ID], [status]) VALUES (2, N'teacher2', N'123', N'lethibao@example.com', 1, 1)
INSERT [dbo].[Accounts] ([ID], [username], [password], [email], [Role_ID], [status]) VALUES (3, N'm', N'1', N'tranvancuong@example.com', 4, 1)
INSERT [dbo].[Accounts] ([ID], [username], [password], [email], [Role_ID], [status]) VALUES (4, N't', N'1', N'phamthidung@example.com', 1, 1)
INSERT [dbo].[Accounts] ([ID], [username], [password], [email], [Role_ID], [status]) VALUES (5, N'teacher5', N'password5', N'hoangminhduc@example.com', 1, 1)
INSERT [dbo].[Accounts] ([ID], [username], [password], [email], [Role_ID], [status]) VALUES (6, N'teacher6', N'password6', N'dothilan@example.com', 1, 1)
INSERT [dbo].[Accounts] ([ID], [username], [password], [email], [Role_ID], [status]) VALUES (7, N'teacher7', N'password7', N'ngovankhoa@example.com', 1, 1)
INSERT [dbo].[Accounts] ([ID], [username], [password], [email], [Role_ID], [status]) VALUES (8, N'teacher8', N'password8', N'buithimai@example.com', 1, 1)
INSERT [dbo].[Accounts] ([ID], [username], [password], [email], [Role_ID], [status]) VALUES (9, N'teacher9', N'password9', N'vuducnhat@example.com', 1, 1)
INSERT [dbo].[Accounts] ([ID], [username], [password], [email], [Role_ID], [status]) VALUES (10, N'teacher10', N'password10', N'phamvanquan@example.com', 1, 1)
INSERT [dbo].[Accounts] ([ID], [username], [password], [email], [Role_ID], [status]) VALUES (11, N's1', N'1', N'nguyenvanan@example.com', 2, 1)
INSERT [dbo].[Accounts] ([ID], [username], [password], [email], [Role_ID], [status]) VALUES (12, N'student2', N'password12', N'lethibao@example.com', 2, 1)
INSERT [dbo].[Accounts] ([ID], [username], [password], [email], [Role_ID], [status]) VALUES (13, N'student3', N'password13', N'tranvancuong@example.com', 2, 1)
INSERT [dbo].[Accounts] ([ID], [username], [password], [email], [Role_ID], [status]) VALUES (14, N'student4', N'password14', N'phamthidung@example.com', 2, 1)
INSERT [dbo].[Accounts] ([ID], [username], [password], [email], [Role_ID], [status]) VALUES (15, N'student5', N'password15', N'hoangminhduc@example.com', 2, 1)
INSERT [dbo].[Accounts] ([ID], [username], [password], [email], [Role_ID], [status]) VALUES (16, N'student6', N'password16', N'dothilan@example.com', 2, 1)
INSERT [dbo].[Accounts] ([ID], [username], [password], [email], [Role_ID], [status]) VALUES (17, N'student7', N'password17', N'ngovankhoa@example.com', 2, 1)
INSERT [dbo].[Accounts] ([ID], [username], [password], [email], [Role_ID], [status]) VALUES (18, N'student8', N'password18', N'buithimai@example.com', 2, 1)
INSERT [dbo].[Accounts] ([ID], [username], [password], [email], [Role_ID], [status]) VALUES (19, N'student9', N'password19', N'vuducnhat@example.com', 2, 1)
INSERT [dbo].[Accounts] ([ID], [username], [password], [email], [Role_ID], [status]) VALUES (20, N'student10', N'password20', N'phamvanquan@example.com', 2, 1)
INSERT [dbo].[Accounts] ([ID], [username], [password], [email], [Role_ID], [status]) VALUES (21, N'student11', N'password21', N'nguyenthihuong@example.com', 2, 1)
INSERT [dbo].[Accounts] ([ID], [username], [password], [email], [Role_ID], [status]) VALUES (22, N'student12', N'password22', N'tranvanthang@example.com', 2, 1)
INSERT [dbo].[Accounts] ([ID], [username], [password], [email], [Role_ID], [status]) VALUES (23, N'student13', N'password23', N'lethithao@example.com', 2, 1)
INSERT [dbo].[Accounts] ([ID], [username], [password], [email], [Role_ID], [status]) VALUES (24, N'student14', N'password24', N'phamvanquyen@example.com', 2, 1)
INSERT [dbo].[Accounts] ([ID], [username], [password], [email], [Role_ID], [status]) VALUES (25, N'student15', N'password25', N'dovananh@example.com', 2, 1)
INSERT [dbo].[Accounts] ([ID], [username], [password], [email], [Role_ID], [status]) VALUES (26, N'student16', N'password26', N'nguyenvanbinh@example.com', 2, 1)
INSERT [dbo].[Accounts] ([ID], [username], [password], [email], [Role_ID], [status]) VALUES (27, N'student17', N'password27', N'tranthihong@example.com', 2, 1)
INSERT [dbo].[Accounts] ([ID], [username], [password], [email], [Role_ID], [status]) VALUES (28, N'student18', N'password28', N'levanhieu@example.com', 2, 1)
INSERT [dbo].[Accounts] ([ID], [username], [password], [email], [Role_ID], [status]) VALUES (29, N'student19', N'password29', N'phamminhhieu@example.com', 2, 1)
INSERT [dbo].[Accounts] ([ID], [username], [password], [email], [Role_ID], [status]) VALUES (30, N'student20', N'password30', N'dothilananh@example.com', 2, 0)
INSERT [dbo].[Accounts] ([ID], [username], [password], [email], [Role_ID], [status]) VALUES (31, N'h', N'1', N'nguyenvanhaivghy@gmail.com', 3, 1)
INSERT [dbo].[Accounts] ([ID], [username], [password], [email], [Role_ID], [status]) VALUES (32, N'chuchung13', N'12345', NULL, 2, 0)
INSERT [dbo].[Accounts] ([ID], [username], [password], [email], [Role_ID], [status]) VALUES (33, N'chuchung111', N'12345', N'chuquockhanhchung@gmail.com', 2, 1)
INSERT [dbo].[Accounts] ([ID], [username], [password], [email], [Role_ID], [status]) VALUES (34, N'hoaiiu', N'12345', N'chuquockhanhchung@gmail.com', 2, 1)
INSERT [dbo].[Accounts] ([ID], [username], [password], [email], [Role_ID], [status]) VALUES (35, N'a', N'1', N'chuquokhanhchung@gmail.com', 2, 0)
SET IDENTITY_INSERT [dbo].[Accounts] OFF
GO
SET IDENTITY_INSERT [dbo].[Admin] ON 

INSERT [dbo].[Admin] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Account_ID]) VALUES (1, N'Nguyen Van Hai', CAST(N'2003-11-20' AS Date), 1, N'0977423805', N'Hung Yen', 31)
SET IDENTITY_INSERT [dbo].[Admin] OFF
GO
INSERT [dbo].[Classes] ([ID], [name]) VALUES (1, N'A1')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (2, N'A2')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (3, N'Class 1')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (4, N'Class 2')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (5, N'Class 3')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (6, N'Class 4')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (7, N'Class 5')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (8, N'Class 6')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (9, N'Class 7')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (10, N'Class 8')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (11, N'Class 9')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (12, N'Class 10')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (13, N'Class 11')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (14, N'Class 12')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (15, N'Class 13')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (16, N'Class 14')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (17, N'Class 15')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (18, N'Class 16')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (19, N'Class 17')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (20, N'Class 18')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (21, N'Class 19')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (22, N'Class 20')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (23, N'Class 21')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (24, N'Class 22')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (25, N'Class 23')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (26, N'Class 24')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (27, N'Class 25')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (28, N'Class 26')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (29, N'Class 27')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (30, N'Class 28')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (31, N'Class 29')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (32, N'Class 30')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (33, N'Class 31')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (34, N'Class 32')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (35, N'Class 33')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (36, N'Class 34')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (37, N'Class 35')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (38, N'Class 36')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (39, N'Class 37')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (40, N'Class 38')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (41, N'Class 39')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (42, N'Class 40')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (43, N'Class 41')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (44, N'Class 42')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (45, N'Class 43')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (46, N'Class 44')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (47, N'Class 45')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (48, N'Class 46')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (49, N'Class 47')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (50, N'Class 48')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (51, N'Class 49')
INSERT [dbo].[Classes] ([ID], [name]) VALUES (52, N'Class 50')
GO
INSERT [dbo].[ClassStu] ([Class_ID], [Student_ID], [Course]) VALUES (2, 1, 1)
INSERT [dbo].[ClassStu] ([Class_ID], [Student_ID], [Course]) VALUES (4, 1, 1)
INSERT [dbo].[ClassStu] ([Class_ID], [Student_ID], [Course]) VALUES (15, 1, 1)
GO
INSERT [dbo].[Departments] ([ID], [name]) VALUES (1, N'Natural sciences')
INSERT [dbo].[Departments] ([ID], [name]) VALUES (2, N'Social science')
GO
INSERT [dbo].[GradeDetail] ([GradeID], [PresentScore], [LabScore], [PTScore], [FEScore], [OverallScore]) VALUES (0, CAST(8.50 AS Decimal(5, 2)), CAST(9.00 AS Decimal(5, 2)), CAST(7.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)))
INSERT [dbo].[GradeDetail] ([GradeID], [PresentScore], [LabScore], [PTScore], [FEScore], [OverallScore]) VALUES (1, CAST(8.50 AS Decimal(5, 2)), CAST(9.00 AS Decimal(5, 2)), CAST(7.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)))
INSERT [dbo].[GradeDetail] ([GradeID], [PresentScore], [LabScore], [PTScore], [FEScore], [OverallScore]) VALUES (2, CAST(8.25 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)), CAST(4.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)))
INSERT [dbo].[GradeDetail] ([GradeID], [PresentScore], [LabScore], [PTScore], [FEScore], [OverallScore]) VALUES (3, CAST(9.00 AS Decimal(5, 2)), CAST(9.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)), CAST(9.00 AS Decimal(5, 2)), CAST(9.25 AS Decimal(5, 2)))
INSERT [dbo].[GradeDetail] ([GradeID], [PresentScore], [LabScore], [PTScore], [FEScore], [OverallScore]) VALUES (4, CAST(6.50 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)), CAST(2.50 AS Decimal(5, 2)), CAST(7.00 AS Decimal(5, 2)), CAST(7.00 AS Decimal(5, 2)))
INSERT [dbo].[GradeDetail] ([GradeID], [PresentScore], [LabScore], [PTScore], [FEScore], [OverallScore]) VALUES (5, CAST(8.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)))
INSERT [dbo].[GradeDetail] ([GradeID], [PresentScore], [LabScore], [PTScore], [FEScore], [OverallScore]) VALUES (6, CAST(9.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)), CAST(7.00 AS Decimal(5, 2)), CAST(7.00 AS Decimal(5, 2)), CAST(7.25 AS Decimal(5, 2)))
INSERT [dbo].[GradeDetail] ([GradeID], [PresentScore], [LabScore], [PTScore], [FEScore], [OverallScore]) VALUES (7, CAST(9.00 AS Decimal(5, 2)), CAST(9.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)), CAST(9.00 AS Decimal(5, 2)), CAST(9.00 AS Decimal(5, 2)))
INSERT [dbo].[GradeDetail] ([GradeID], [PresentScore], [LabScore], [PTScore], [FEScore], [OverallScore]) VALUES (8, CAST(8.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)))
INSERT [dbo].[GradeDetail] ([GradeID], [PresentScore], [LabScore], [PTScore], [FEScore], [OverallScore]) VALUES (9, CAST(7.00 AS Decimal(5, 2)), CAST(9.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)))
INSERT [dbo].[GradeDetail] ([GradeID], [PresentScore], [LabScore], [PTScore], [FEScore], [OverallScore]) VALUES (10, CAST(8.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)), CAST(7.00 AS Decimal(5, 2)), CAST(7.00 AS Decimal(5, 2)), CAST(7.50 AS Decimal(5, 2)))
INSERT [dbo].[GradeDetail] ([GradeID], [PresentScore], [LabScore], [PTScore], [FEScore], [OverallScore]) VALUES (11, CAST(8.50 AS Decimal(5, 2)), CAST(9.00 AS Decimal(5, 2)), CAST(7.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)))
INSERT [dbo].[GradeDetail] ([GradeID], [PresentScore], [LabScore], [PTScore], [FEScore], [OverallScore]) VALUES (12, CAST(8.25 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)), CAST(4.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)))
INSERT [dbo].[GradeDetail] ([GradeID], [PresentScore], [LabScore], [PTScore], [FEScore], [OverallScore]) VALUES (13, CAST(9.00 AS Decimal(5, 2)), CAST(9.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)), CAST(9.00 AS Decimal(5, 2)), CAST(9.25 AS Decimal(5, 2)))
INSERT [dbo].[GradeDetail] ([GradeID], [PresentScore], [LabScore], [PTScore], [FEScore], [OverallScore]) VALUES (14, CAST(6.50 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)), CAST(2.50 AS Decimal(5, 2)), CAST(7.00 AS Decimal(5, 2)), CAST(7.00 AS Decimal(5, 2)))
INSERT [dbo].[GradeDetail] ([GradeID], [PresentScore], [LabScore], [PTScore], [FEScore], [OverallScore]) VALUES (15, CAST(8.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)))
INSERT [dbo].[GradeDetail] ([GradeID], [PresentScore], [LabScore], [PTScore], [FEScore], [OverallScore]) VALUES (16, CAST(9.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)), CAST(7.00 AS Decimal(5, 2)), CAST(7.00 AS Decimal(5, 2)), CAST(7.25 AS Decimal(5, 2)))
INSERT [dbo].[GradeDetail] ([GradeID], [PresentScore], [LabScore], [PTScore], [FEScore], [OverallScore]) VALUES (17, CAST(9.00 AS Decimal(5, 2)), CAST(9.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)), CAST(9.00 AS Decimal(5, 2)), CAST(9.00 AS Decimal(5, 2)))
INSERT [dbo].[GradeDetail] ([GradeID], [PresentScore], [LabScore], [PTScore], [FEScore], [OverallScore]) VALUES (18, CAST(8.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)))
INSERT [dbo].[GradeDetail] ([GradeID], [PresentScore], [LabScore], [PTScore], [FEScore], [OverallScore]) VALUES (19, CAST(7.00 AS Decimal(5, 2)), CAST(9.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)))
INSERT [dbo].[GradeDetail] ([GradeID], [PresentScore], [LabScore], [PTScore], [FEScore], [OverallScore]) VALUES (20, CAST(8.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(5, 2)), CAST(7.00 AS Decimal(5, 2)), CAST(7.00 AS Decimal(5, 2)), CAST(7.50 AS Decimal(5, 2)))
GO
SET IDENTITY_INSERT [dbo].[Grades] ON 

INSERT [dbo].[Grades] ([ID], [Student_ID], [Class_ID], [Teacher_ID], [grade], [DayOfGrade], [subject]) VALUES (191, 1, 32, 1, 1, CAST(N'2024-07-21' AS Date), 1)
INSERT [dbo].[Grades] ([ID], [Student_ID], [Class_ID], [Teacher_ID], [grade], [DayOfGrade], [subject]) VALUES (192, 1, 32, 1, 2, CAST(N'2024-07-21' AS Date), 2)
INSERT [dbo].[Grades] ([ID], [Student_ID], [Class_ID], [Teacher_ID], [grade], [DayOfGrade], [subject]) VALUES (193, 1, 32, 1, 3, CAST(N'2024-07-21' AS Date), 3)
INSERT [dbo].[Grades] ([ID], [Student_ID], [Class_ID], [Teacher_ID], [grade], [DayOfGrade], [subject]) VALUES (194, 1, 32, 1, 4, CAST(N'2024-07-21' AS Date), 4)
INSERT [dbo].[Grades] ([ID], [Student_ID], [Class_ID], [Teacher_ID], [grade], [DayOfGrade], [subject]) VALUES (195, 1, 32, 1, 5, CAST(N'2024-07-21' AS Date), 5)
INSERT [dbo].[Grades] ([ID], [Student_ID], [Class_ID], [Teacher_ID], [grade], [DayOfGrade], [subject]) VALUES (196, 1, 32, 1, 6, CAST(N'2024-07-21' AS Date), 6)
INSERT [dbo].[Grades] ([ID], [Student_ID], [Class_ID], [Teacher_ID], [grade], [DayOfGrade], [subject]) VALUES (197, 1, 32, 1, 7, CAST(N'2024-07-21' AS Date), 7)
INSERT [dbo].[Grades] ([ID], [Student_ID], [Class_ID], [Teacher_ID], [grade], [DayOfGrade], [subject]) VALUES (198, 1, 32, 1, 8, CAST(N'2024-07-21' AS Date), 8)
INSERT [dbo].[Grades] ([ID], [Student_ID], [Class_ID], [Teacher_ID], [grade], [DayOfGrade], [subject]) VALUES (199, 1, 32, 1, 9, CAST(N'2024-07-21' AS Date), 9)
INSERT [dbo].[Grades] ([ID], [Student_ID], [Class_ID], [Teacher_ID], [grade], [DayOfGrade], [subject]) VALUES (200, 2, 32, 1, 1, CAST(N'2024-07-21' AS Date), 1)
INSERT [dbo].[Grades] ([ID], [Student_ID], [Class_ID], [Teacher_ID], [grade], [DayOfGrade], [subject]) VALUES (201, 2, 32, 1, 2, CAST(N'2024-07-21' AS Date), 2)
INSERT [dbo].[Grades] ([ID], [Student_ID], [Class_ID], [Teacher_ID], [grade], [DayOfGrade], [subject]) VALUES (202, 2, 32, 1, 3, CAST(N'2024-07-21' AS Date), 3)
INSERT [dbo].[Grades] ([ID], [Student_ID], [Class_ID], [Teacher_ID], [grade], [DayOfGrade], [subject]) VALUES (203, 2, 32, 1, 4, CAST(N'2024-07-21' AS Date), 4)
INSERT [dbo].[Grades] ([ID], [Student_ID], [Class_ID], [Teacher_ID], [grade], [DayOfGrade], [subject]) VALUES (204, 2, 32, 1, 5, CAST(N'2024-07-21' AS Date), 5)
INSERT [dbo].[Grades] ([ID], [Student_ID], [Class_ID], [Teacher_ID], [grade], [DayOfGrade], [subject]) VALUES (205, 2, 32, 1, 6, CAST(N'2024-07-21' AS Date), 6)
INSERT [dbo].[Grades] ([ID], [Student_ID], [Class_ID], [Teacher_ID], [grade], [DayOfGrade], [subject]) VALUES (206, 1, 3, 4, 10, CAST(N'2024-07-22' AS Date), 2)
INSERT [dbo].[Grades] ([ID], [Student_ID], [Class_ID], [Teacher_ID], [grade], [DayOfGrade], [subject]) VALUES (207, 1, 3, 4, 11, CAST(N'2024-07-22' AS Date), 2)
INSERT [dbo].[Grades] ([ID], [Student_ID], [Class_ID], [Teacher_ID], [grade], [DayOfGrade], [subject]) VALUES (208, 2, 3, 4, 12, CAST(N'2024-07-22' AS Date), 2)
INSERT [dbo].[Grades] ([ID], [Student_ID], [Class_ID], [Teacher_ID], [grade], [DayOfGrade], [subject]) VALUES (209, 3, 3, 4, 13, CAST(N'2024-07-22' AS Date), 2)
INSERT [dbo].[Grades] ([ID], [Student_ID], [Class_ID], [Teacher_ID], [grade], [DayOfGrade], [subject]) VALUES (210, 4, 3, 4, 14, CAST(N'2024-07-22' AS Date), 2)
INSERT [dbo].[Grades] ([ID], [Student_ID], [Class_ID], [Teacher_ID], [grade], [DayOfGrade], [subject]) VALUES (211, 5, 3, 4, 15, CAST(N'2024-07-22' AS Date), 2)
INSERT [dbo].[Grades] ([ID], [Student_ID], [Class_ID], [Teacher_ID], [grade], [DayOfGrade], [subject]) VALUES (212, 6, 3, 4, 16, CAST(N'2024-07-22' AS Date), 2)
INSERT [dbo].[Grades] ([ID], [Student_ID], [Class_ID], [Teacher_ID], [grade], [DayOfGrade], [subject]) VALUES (213, 7, 3, 4, 17, CAST(N'2024-07-22' AS Date), 2)
INSERT [dbo].[Grades] ([ID], [Student_ID], [Class_ID], [Teacher_ID], [grade], [DayOfGrade], [subject]) VALUES (214, 8, 3, 4, 18, CAST(N'2024-07-22' AS Date), 2)
INSERT [dbo].[Grades] ([ID], [Student_ID], [Class_ID], [Teacher_ID], [grade], [DayOfGrade], [subject]) VALUES (215, 9, 3, 4, 19, CAST(N'2024-07-22' AS Date), 2)
INSERT [dbo].[Grades] ([ID], [Student_ID], [Class_ID], [Teacher_ID], [grade], [DayOfGrade], [subject]) VALUES (216, 10, 3, 4, 20, CAST(N'2024-07-22' AS Date), 2)
SET IDENTITY_INSERT [dbo].[Grades] OFF
GO
INSERT [dbo].[Roles] ([ID], [name]) VALUES (1, N'Teachers')
INSERT [dbo].[Roles] ([ID], [name]) VALUES (2, N'Students')
INSERT [dbo].[Roles] ([ID], [name]) VALUES (3, N'Admin')
INSERT [dbo].[Roles] ([ID], [name]) VALUES (4, N'Manager')
GO
SET IDENTITY_INSERT [dbo].[Schedules] ON 

INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-21', 1, 1, 1, 1, 640)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-21', 2, 1, 1, 1, 641)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-21', 3, 2, 2, 1, 642)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-21', 4, 2, 2, 1, 643)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-22', 1, 3, 3, 2, 644)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-22', 2, 3, 3, 2, 645)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-22', 3, 4, 4, 2, 646)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-22', 4, 4, 4, 2, 647)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-23', 1, 5, 5, 3, 648)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-23', 2, 5, 5, 3, 649)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-23', 3, 1, 1, 4, 650)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-23', 4, 1, 1, 4, 651)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-24', 1, 2, 2, 5, 652)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-24', 2, 2, 2, 5, 653)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-24', 3, 3, 3, 5, 654)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-24', 4, 3, 3, 5, 655)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-25', 1, 4, 4, 6, 656)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-25', 2, 4, 4, 6, 657)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-25', 3, 5, 5, 6, 658)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-25', 4, 5, 5, 6, 659)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-26', 1, 1, 1, 7, 660)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-26', 2, 1, 1, 7, 661)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-26', 3, 2, 2, 7, 662)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-26', 4, 2, 2, 7, 663)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-27', 1, 3, 3, 8, 664)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-27', 2, 3, 3, 8, 665)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-27', 3, 4, 4, 8, 666)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-27', 4, 4, 4, 8, 667)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-28', 1, 5, 5, 9, 668)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-28', 2, 5, 5, 9, 669)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-28', 3, 1, 1, 9, 670)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-28', 4, 1, 1, 9, 671)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-29', 1, 2, 2, 9, 672)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-29', 2, 2, 2, 9, 673)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-29', 3, 3, 3, 9, 674)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-29', 4, 3, 3, 9, 675)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-30', 1, 4, 4, 9, 676)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-30', 2, 4, 4, 9, 677)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-30', 3, 5, 5, 9, 678)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-30', 4, 5, 5, 9, 679)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-31', 1, 1, 1, 1, 680)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-31', 2, 1, 1, 1, 681)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-31', 3, 2, 2, 1, 682)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-31', 4, 2, 2, 1, 683)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-09-23', 1, 15, 10, 9, 684)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-09-24', 1, 15, 10, 9, 685)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-09-25', 1, 15, 10, 9, 686)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-09-26', 1, 15, 10, 9, 687)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-09-27', 1, 15, 10, 9, 688)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-09-30', 1, 15, 10, 9, 689)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-10-01', 1, 15, 10, 9, 690)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-10-02', 1, 15, 10, 9, 691)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-10-03', 1, 15, 10, 9, 692)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-10-04', 1, 15, 10, 9, 693)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-10-07', 1, 15, 10, 9, 694)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-10-08', 1, 15, 10, 9, 695)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-10-09', 1, 15, 10, 9, 696)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-10-10', 1, 15, 10, 9, 697)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-10-11', 1, 15, 10, 9, 698)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-10-14', 1, 15, 10, 9, 699)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-10-15', 1, 15, 10, 9, 700)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-10-16', 1, 15, 10, 9, 701)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-10-17', 1, 15, 10, 9, 702)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-10-18', 1, 15, 10, 9, 703)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-10-21', 1, 15, 10, 9, 704)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-10-22', 1, 15, 10, 9, 705)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-10-23', 1, 15, 10, 9, 706)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-10-24', 1, 15, 10, 9, 707)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-10-25', 1, 15, 10, 9, 708)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-10-28', 1, 15, 10, 9, 709)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-10-29', 1, 15, 10, 9, 710)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-10-30', 1, 15, 10, 9, 711)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-10-31', 1, 15, 10, 9, 712)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-11-01', 1, 15, 10, 9, 713)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-11-04', 1, 15, 10, 9, 714)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-11-05', 1, 15, 10, 9, 715)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-11-06', 1, 15, 10, 9, 716)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-11-07', 1, 15, 10, 9, 717)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-11-08', 1, 15, 10, 9, 718)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-11-11', 1, 15, 10, 9, 719)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-11-12', 1, 15, 10, 9, 720)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-11-13', 1, 15, 10, 9, 721)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-11-14', 1, 15, 10, 9, 722)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-11-15', 1, 15, 10, 9, 723)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-11-18', 1, 15, 10, 9, 724)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-11-19', 1, 15, 10, 9, 725)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-11-20', 1, 15, 10, 9, 726)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-11-21', 1, 15, 10, 9, 727)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-22', 1, 26, 4, 8, 728)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-23', 1, 26, 4, 8, 729)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-24', 1, 26, 4, 8, 730)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-25', 1, 26, 4, 8, 731)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-26', 1, 26, 4, 8, 732)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-29', 1, 26, 4, 8, 733)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-30', 1, 26, 4, 8, 734)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-31', 1, 26, 4, 8, 735)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-01', 1, 26, 4, 8, 736)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-02', 1, 26, 4, 8, 737)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-05', 1, 26, 4, 8, 738)
GO
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-06', 1, 26, 4, 8, 739)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-07', 1, 26, 4, 8, 740)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-08', 1, 26, 4, 8, 741)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-09', 1, 26, 4, 8, 742)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-12', 1, 26, 4, 8, 743)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-13', 1, 26, 4, 8, 744)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-14', 1, 26, 4, 8, 745)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-15', 1, 26, 4, 8, 746)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-16', 1, 26, 4, 8, 747)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-19', 1, 26, 4, 8, 748)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-20', 1, 26, 4, 8, 749)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-21', 1, 26, 4, 8, 750)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-22', 1, 26, 4, 8, 751)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-23', 1, 26, 4, 8, 752)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-26', 1, 26, 4, 8, 753)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-27', 1, 26, 4, 8, 754)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-28', 1, 26, 4, 8, 755)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-29', 1, 26, 4, 8, 756)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-30', 1, 26, 4, 8, 757)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-09-02', 1, 26, 4, 8, 758)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-09-03', 1, 26, 4, 8, 759)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-09-04', 1, 26, 4, 8, 760)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-09-05', 1, 26, 4, 8, 761)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-09-06', 1, 26, 4, 8, 762)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-09-09', 1, 26, 4, 8, 763)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-09-10', 1, 26, 4, 8, 764)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-09-11', 1, 26, 4, 8, 765)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-09-12', 1, 26, 4, 8, 766)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-09-13', 1, 26, 4, 8, 767)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-09-16', 1, 26, 4, 8, 768)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-09-17', 1, 26, 4, 8, 769)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-09-18', 1, 26, 4, 8, 770)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-09-19', 1, 26, 4, 8, 771)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-09-20', 1, 26, 4, 8, 772)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-22', 4, 29, 4, 9, 773)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-23', 4, 29, 4, 9, 774)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-24', 4, 29, 4, 9, 775)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-25', 4, 29, 4, 9, 776)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-26', 4, 29, 4, 9, 777)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-29', 4, 29, 4, 9, 778)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-30', 4, 29, 4, 9, 779)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-31', 4, 29, 4, 9, 780)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-01', 4, 29, 4, 9, 781)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-02', 4, 29, 4, 9, 782)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-05', 4, 29, 4, 9, 783)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-06', 4, 29, 4, 9, 784)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-07', 4, 29, 4, 9, 785)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-08', 4, 29, 4, 9, 786)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-09', 4, 29, 4, 9, 787)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-12', 4, 29, 4, 9, 788)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-13', 4, 29, 4, 9, 789)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-14', 4, 29, 4, 9, 790)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-15', 4, 29, 4, 9, 791)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-16', 4, 29, 4, 9, 792)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-19', 4, 29, 4, 9, 793)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-20', 4, 29, 4, 9, 794)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-21', 4, 29, 4, 9, 795)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-22', 4, 29, 4, 9, 796)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-23', 4, 29, 4, 9, 797)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-26', 4, 29, 4, 9, 798)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-27', 4, 29, 4, 9, 799)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-28', 4, 29, 4, 9, 800)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-29', 4, 29, 4, 9, 801)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-08-30', 4, 29, 4, 9, 802)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-09-02', 4, 29, 4, 9, 803)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-09-03', 4, 29, 4, 9, 804)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-09-04', 4, 29, 4, 9, 805)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-09-05', 4, 29, 4, 9, 806)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-09-06', 4, 29, 4, 9, 807)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-09-09', 4, 29, 4, 9, 808)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-09-10', 4, 29, 4, 9, 809)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-09-11', 4, 29, 4, 9, 810)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-09-12', 4, 29, 4, 9, 811)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-09-13', 4, 29, 4, 9, 812)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-09-16', 4, 29, 4, 9, 813)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-09-17', 4, 29, 4, 9, 814)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-09-18', 4, 29, 4, 9, 815)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-09-19', 4, 29, 4, 9, 816)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-09-20', 4, 29, 4, 9, 817)
INSERT [dbo].[Schedules] ([DayOfWeeks], [slot], [Class_ID], [Teacher_ID], [SubjectID], [ScheduleID]) VALUES (N'2024-07-22', 2, 7, 5, 5, 818)
SET IDENTITY_INSERT [dbo].[Schedules] OFF
GO
SET IDENTITY_INSERT [dbo].[ScheduleStu] ON 

INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1830, 652, 1, 1)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1831, 653, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1832, 684, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1833, 685, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1834, 686, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1835, 687, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1836, 688, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1837, 689, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1838, 690, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1839, 691, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1840, 692, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1841, 693, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1842, 694, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1843, 695, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1844, 696, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1845, 697, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1846, 698, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1847, 699, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1848, 700, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1849, 701, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1850, 702, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1851, 703, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1852, 704, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1853, 705, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1854, 706, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1855, 707, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1856, 708, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1857, 709, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1858, 710, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1859, 711, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1860, 712, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1861, 713, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1862, 714, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1863, 715, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1864, 716, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1865, 717, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1866, 718, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1867, 719, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1868, 720, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1869, 721, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1870, 722, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1871, 723, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1872, 724, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1873, 725, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1874, 726, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1875, 727, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1876, 656, 1, 3)
INSERT [dbo].[ScheduleStu] ([ScheduleStuID], [ScheduleID], [StudentID], [Status]) VALUES (1877, 657, 1, 1)
SET IDENTITY_INSERT [dbo].[ScheduleStu] OFF
GO
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Account_ID]) VALUES (1, N'Nguyen Van An', CAST(N'2005-01-01' AS Date), 1, N'0912345601', N'Ha Noi', 11)
INSERT [dbo].[Students] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Account_ID]) VALUES (2, N'Le Thi Bao', CAST(N'2005-02-02' AS Date), 0, N'0912345602', N'Ha Noi', 12)
INSERT [dbo].[Students] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Account_ID]) VALUES (3, N'Tran Van Cuong', CAST(N'2005-03-03' AS Date), 1, N'0912345603', N'Ha Noi', 13)
INSERT [dbo].[Students] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Account_ID]) VALUES (4, N'Pham Thi Dung', CAST(N'2005-04-04' AS Date), 0, N'0912345604', N'Ha Noi', 14)
INSERT [dbo].[Students] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Account_ID]) VALUES (5, N'Hoang Minh Duc', CAST(N'2005-05-05' AS Date), 1, N'0912345605', N'Ha Noi', 15)
INSERT [dbo].[Students] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Account_ID]) VALUES (6, N'Do Thi Lan', CAST(N'2005-06-06' AS Date), 0, N'0912345606', N'Hung Yen', 16)
INSERT [dbo].[Students] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Account_ID]) VALUES (7, N'Ngo Van Khoa', CAST(N'2005-07-07' AS Date), 1, N'0912345607', N'Hung Yen', 17)
INSERT [dbo].[Students] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Account_ID]) VALUES (8, N'Bui Thi Mai', CAST(N'2005-08-08' AS Date), 0, N'0912345608', N'Hung Yen', 18)
INSERT [dbo].[Students] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Account_ID]) VALUES (9, N'Vu Duc Nhat', CAST(N'2005-09-09' AS Date), 1, N'0912345609', N'Hung Yen', 19)
INSERT [dbo].[Students] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Account_ID]) VALUES (10, N'Pham Van Quan', CAST(N'2005-10-10' AS Date), 1, N'0912345610', N'Hung Yen', 20)
INSERT [dbo].[Students] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Account_ID]) VALUES (11, N'Nguyen Thi Huong', CAST(N'2005-11-11' AS Date), 0, N'0912345611', N'Hai Phong', 21)
INSERT [dbo].[Students] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Account_ID]) VALUES (12, N'Tran Van Thang', CAST(N'2005-12-12' AS Date), 1, N'0912345612', N'Hai Phong', 22)
INSERT [dbo].[Students] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Account_ID]) VALUES (13, N'Le Thi Thao', CAST(N'2005-01-13' AS Date), 0, N'0912345613', N'Hai Phong', 23)
INSERT [dbo].[Students] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Account_ID]) VALUES (14, N'Pham Van Quyen', CAST(N'2005-02-14' AS Date), 1, N'0912345614', N'Hai Phong', 24)
INSERT [dbo].[Students] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Account_ID]) VALUES (15, N'Do Van Anh', CAST(N'2005-03-15' AS Date), 0, N'0912345615', N'Hai Phong', 25)
INSERT [dbo].[Students] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Account_ID]) VALUES (16, N'Nguyen Van Binh', CAST(N'2005-04-16' AS Date), 1, N'0912345616', N'Hai Duong', 26)
INSERT [dbo].[Students] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Account_ID]) VALUES (17, N'Tran Thi Hong', CAST(N'2005-05-17' AS Date), 0, N'0912345617', N'Hai Duong', 27)
INSERT [dbo].[Students] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Account_ID]) VALUES (18, N'Le Van Hieu', CAST(N'2005-06-18' AS Date), 1, N'0912345618', N'Hai Duong', 28)
INSERT [dbo].[Students] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Account_ID]) VALUES (19, N'Pham Minh Hieu', CAST(N'2005-07-19' AS Date), 1, N'0912345619', N'Hai Duong', 29)
INSERT [dbo].[Students] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Account_ID]) VALUES (20, N'Do Thi Lan Anh', CAST(N'2005-08-20' AS Date), 0, N'0912345620', N'Hai Duong', 30)
INSERT [dbo].[Students] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Account_ID]) VALUES (21, N'chu chung', CAST(N'2024-07-25' AS Date), 1, N'0358890872', N'Thái Bình', 32)
INSERT [dbo].[Students] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Account_ID]) VALUES (22, N'Chu quoc khanh chung', NULL, NULL, NULL, NULL, 33)
INSERT [dbo].[Students] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Account_ID]) VALUES (23, N'Do Thi Thu Hoai', NULL, NULL, NULL, NULL, 34)
INSERT [dbo].[Students] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Account_ID]) VALUES (24, N'chuchung', NULL, NULL, NULL, NULL, 35)
SET IDENTITY_INSERT [dbo].[Students] OFF
GO
SET IDENTITY_INSERT [dbo].[Subject] ON 

INSERT [dbo].[Subject] ([ID], [Name]) VALUES (1, N'Biology')
INSERT [dbo].[Subject] ([ID], [Name]) VALUES (2, N'Chemistry')
INSERT [dbo].[Subject] ([ID], [Name]) VALUES (3, N'Mathematics')
INSERT [dbo].[Subject] ([ID], [Name]) VALUES (4, N'Physics')
INSERT [dbo].[Subject] ([ID], [Name]) VALUES (5, N'English')
INSERT [dbo].[Subject] ([ID], [Name]) VALUES (6, N'Civic education')
INSERT [dbo].[Subject] ([ID], [Name]) VALUES (7, N'Literature')
INSERT [dbo].[Subject] ([ID], [Name]) VALUES (8, N'Geography')
INSERT [dbo].[Subject] ([ID], [Name]) VALUES (9, N'History')
SET IDENTITY_INSERT [dbo].[Subject] OFF
GO
SET IDENTITY_INSERT [dbo].[Teachers] ON 

INSERT [dbo].[Teachers] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Department_ID], [Account_ID]) VALUES (1, N'Nguyen Van An', CAST(N'1980-01-01' AS Date), 1, N'0912345678', N'Ha Noi', 1, 1)
INSERT [dbo].[Teachers] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Department_ID], [Account_ID]) VALUES (2, N'Le Thi Bao', CAST(N'1981-02-02' AS Date), 0, N'0912345679', N'Ha Noi', 1, 2)
INSERT [dbo].[Teachers] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Department_ID], [Account_ID]) VALUES (3, N'Tran Van Cuong', CAST(N'1982-03-03' AS Date), 1, N'0912345680', N'Ha Noi', 1, 3)
INSERT [dbo].[Teachers] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Department_ID], [Account_ID]) VALUES (4, N'Pham Thi Dung', CAST(N'1983-04-04' AS Date), 0, N'0912345681', N'Ha Noi', 1, 4)
INSERT [dbo].[Teachers] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Department_ID], [Account_ID]) VALUES (5, N'Hoang Minh Duc', CAST(N'1984-05-05' AS Date), 1, N'0912345682', N'Hung Yen', 1, 5)
INSERT [dbo].[Teachers] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Department_ID], [Account_ID]) VALUES (6, N'Do Thi Lan', CAST(N'1980-06-06' AS Date), 0, N'0912345683', N'Hung Yen', 2, 6)
INSERT [dbo].[Teachers] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Department_ID], [Account_ID]) VALUES (7, N'Ngo Van Khoa', CAST(N'1981-07-07' AS Date), 1, N'0912345684', N'Hai Duong', 2, 7)
INSERT [dbo].[Teachers] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Department_ID], [Account_ID]) VALUES (8, N'Bui Thi Mai', CAST(N'1982-08-08' AS Date), 0, N'0912345685', N'Hai Duong', 2, 8)
INSERT [dbo].[Teachers] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Department_ID], [Account_ID]) VALUES (9, N'Vu Duc Nhat', CAST(N'1983-09-09' AS Date), 1, N'0912345686', N'Hai Phong', 2, 9)
INSERT [dbo].[Teachers] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Department_ID], [Account_ID]) VALUES (10, N'Pham Van Quan', CAST(N'1984-10-10' AS Date), 0, N'0912345687', N'Hai Phong', 2, 10)
INSERT [dbo].[Teachers] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Department_ID], [Account_ID]) VALUES (11, N'Nguyen Van An', CAST(N'1980-01-01' AS Date), 1, N'0912345678', N'Ha Noi', NULL, 1)
INSERT [dbo].[Teachers] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Department_ID], [Account_ID]) VALUES (12, N'Le Thi Bao', CAST(N'1981-02-02' AS Date), 0, N'0912345679', N'Ha Noi', NULL, 2)
INSERT [dbo].[Teachers] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Department_ID], [Account_ID]) VALUES (13, N'Tran Van Cuong', CAST(N'1982-03-03' AS Date), 1, N'0912345680', N'Ha Noi', NULL, 3)
INSERT [dbo].[Teachers] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Department_ID], [Account_ID]) VALUES (14, N'Pham Thi Dung', CAST(N'1983-04-04' AS Date), 0, N'0912345681', N'Ha Noi', NULL, 4)
INSERT [dbo].[Teachers] ([ID], [FullName], [DateOfBirth], [gender], [PhoneNumber], [address], [Department_ID], [Account_ID]) VALUES (15, N'Hoang Minh Duc', CAST(N'1984-05-05' AS Date), 1, N'0912345682', N'Hung Yen', NULL, 5)
SET IDENTITY_INSERT [dbo].[Teachers] OFF
GO
ALTER TABLE [dbo].[Accounts]  WITH CHECK ADD FOREIGN KEY([Role_ID])
REFERENCES [dbo].[Roles] ([ID])
GO
ALTER TABLE [dbo].[Admin]  WITH CHECK ADD FOREIGN KEY([Account_ID])
REFERENCES [dbo].[Accounts] ([ID])
GO
ALTER TABLE [dbo].[ClassStu]  WITH CHECK ADD FOREIGN KEY([Class_ID])
REFERENCES [dbo].[Classes] ([ID])
GO
ALTER TABLE [dbo].[ClassStu]  WITH CHECK ADD FOREIGN KEY([Student_ID])
REFERENCES [dbo].[Students] ([ID])
GO
ALTER TABLE [dbo].[Grades]  WITH CHECK ADD FOREIGN KEY([Class_ID])
REFERENCES [dbo].[Classes] ([ID])
GO
ALTER TABLE [dbo].[Grades]  WITH CHECK ADD FOREIGN KEY([Student_ID])
REFERENCES [dbo].[Students] ([ID])
GO
ALTER TABLE [dbo].[Grades]  WITH CHECK ADD FOREIGN KEY([Teacher_ID])
REFERENCES [dbo].[Teachers] ([ID])
GO
ALTER TABLE [dbo].[Grades]  WITH CHECK ADD  CONSTRAINT [FK_Grades_GradeDetail] FOREIGN KEY([grade])
REFERENCES [dbo].[GradeDetail] ([GradeID])
GO
ALTER TABLE [dbo].[Grades] CHECK CONSTRAINT [FK_Grades_GradeDetail]
GO
ALTER TABLE [dbo].[Grades]  WITH CHECK ADD  CONSTRAINT [FK_Grades_Subject] FOREIGN KEY([subject])
REFERENCES [dbo].[Subject] ([ID])
GO
ALTER TABLE [dbo].[Grades] CHECK CONSTRAINT [FK_Grades_Subject]
GO
ALTER TABLE [dbo].[Schedules]  WITH CHECK ADD FOREIGN KEY([Class_ID])
REFERENCES [dbo].[Classes] ([ID])
GO
ALTER TABLE [dbo].[Schedules]  WITH CHECK ADD FOREIGN KEY([Teacher_ID])
REFERENCES [dbo].[Teachers] ([ID])
GO
ALTER TABLE [dbo].[Schedules]  WITH CHECK ADD  CONSTRAINT [FK_Schedules_SubjectID] FOREIGN KEY([SubjectID])
REFERENCES [dbo].[Subject] ([ID])
GO
ALTER TABLE [dbo].[Schedules] CHECK CONSTRAINT [FK_Schedules_SubjectID]
GO
ALTER TABLE [dbo].[ScheduleStu]  WITH CHECK ADD  CONSTRAINT [FK_ScheduleStu_Schedules] FOREIGN KEY([ScheduleID])
REFERENCES [dbo].[Schedules] ([ScheduleID])
GO
ALTER TABLE [dbo].[ScheduleStu] CHECK CONSTRAINT [FK_ScheduleStu_Schedules]
GO
ALTER TABLE [dbo].[ScheduleStu]  WITH CHECK ADD  CONSTRAINT [FK_ScheduleStu_Students] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Students] ([ID])
GO
ALTER TABLE [dbo].[ScheduleStu] CHECK CONSTRAINT [FK_ScheduleStu_Students]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD FOREIGN KEY([Account_ID])
REFERENCES [dbo].[Accounts] ([ID])
GO
ALTER TABLE [dbo].[Teachers]  WITH CHECK ADD FOREIGN KEY([Account_ID])
REFERENCES [dbo].[Accounts] ([ID])
GO
ALTER TABLE [dbo].[Teachers]  WITH CHECK ADD FOREIGN KEY([Department_ID])
REFERENCES [dbo].[Departments] ([ID])
GO
ALTER TABLE [dbo].[TeachSubject]  WITH CHECK ADD FOREIGN KEY([SubjectID])
REFERENCES [dbo].[Subject] ([ID])
GO
ALTER TABLE [dbo].[TeachSubject]  WITH CHECK ADD FOREIGN KEY([TeacherID])
REFERENCES [dbo].[Teachers] ([ID])
GO
