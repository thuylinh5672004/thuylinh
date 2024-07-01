USE [DtlLesson11Dbs]
GO
/****** Object:  Table [dbo].[DtlTaiKhoan]    Script Date: 01/07/2024 3:46:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DtlTaiKhoan](
	[DtlId] [int] NOT NULL,
	[DtlUserName] [nvarchar](50) NULL,
	[DtlPassword] [nvarchar](50) NULL,
	[DtlFullName] [nvarchar](50) NULL,
	[DtlAge] [int] NULL,
	[DtlEmail] [nvarchar](50) NULL,
	[DtlPhone] [nvarchar](50) NULL,
	[DtlStatus] [bit] NULL,
 CONSTRAINT [PK_DtlTaiKhoan] PRIMARY KEY CLUSTERED 
(
	[DtlId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DtlTaiKhoan] ([DtlId], [DtlUserName], [DtlPassword], [DtlFullName], [DtlAge], [DtlEmail], [DtlPhone], [DtlStatus]) VALUES (1, N'Daothithuylinh', N'123456', N'Đào Thị Thùy Linh', 30, N'thuylinh@gmail.com', N'0956808080', 1)
GO
