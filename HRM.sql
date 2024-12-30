USE Master
GO
CREATE DATABASE [HRM_05092023]
GO
USE [HRM_05092023]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 5/9/2023 8:55:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmpID] [int] IDENTITY(1,1) NOT NULL,
	[EmpName] [nvarchar](50) NULL,
	[EmpAddress] [nvarchar](500) NULL,
	[EmpEmail] [varchar](50) NULL,
	[EmpAge] [int] NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmpID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HR_Users]    Script Date: 5/9/2023 8:55:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HR_Users](
	[HR_Email] [varchar](50) NOT NULL,
	[HR_Password] [varchar](50) NULL,
 CONSTRAINT [PK_HR_Users] PRIMARY KEY CLUSTERED 
(
	[HR_Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 
GO
INSERT [dbo].[Employees] ([EmpID], [EmpName], [EmpAddress], [EmpEmail], [EmpAge]) VALUES (1, N'Peter Pham', N'56 Nguyen Chi Thanh Street, Ha Noi', N'peter@aptech.vn', 30)
GO
INSERT [dbo].[Employees] ([EmpID], [EmpName], [EmpAddress], [EmpEmail], [EmpAge]) VALUES (2, N'Alex Truong', N'19 Nguyen Trai Road, Ha Noi', N'alex@aptech.vn', 40)
GO
INSERT [dbo].[Employees] ([EmpID], [EmpName], [EmpAddress], [EmpEmail], [EmpAge]) VALUES (3, N'Micheal Tran', N'19 Nguyen Trai Road, Ha Noi', N'micheal@aptech.vn', 30)
GO
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
INSERT [dbo].[HR_Users] ([HR_Email], [HR_Password]) VALUES (N'admin@aptech.vn', N'123456')
GO
