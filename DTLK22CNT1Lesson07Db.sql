USE [DtlK22CNT1Lesson07Db]
GO
/****** Object:  Table [dbo].[dtlKhoa]    Script Date: 17/06/2024 8:52:22 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dtlKhoa](
	[DtlMaKH] [nchar](10) NOT NULL PRIMARY KEY,
	[DtlTenKH] [nvarchar](50) NULL,
	[DtlTrangThai] [bit] NULL,
 CONSTRAINT [PK_dtlKhoa] PRIMARY KEY CLUSTERED 
(
	[DtlMaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dtlSinhVien]    Script Date: 17/06/2024 8:52:22 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dtlSinhVien](
	[DtlMaSV] [nvarchar](50) NOT NULL,
	[DtlHoSV] [nvarchar](50) NULL,
	[DtlTenSv] [nvarchar](50) NULL,
	[DtlNgaySinh] [date] NULL,
	[DtlPhai] [bit] NULL,
	[DtlPhone] [nchar](10) NULL,
	[DtlEmail] [nvarchar](50) NULL,
	[DtlMaKH] [nchar](10) NULL,
 CONSTRAINT [PK_dtlSinhVien] PRIMARY KEY CLUSTERED 
(
	[DtlMaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[dtlKhoa] ([DtlMaKH], [DtlTenKH], [DtlTrangThai]) VALUES (N'K22CNT1   ', N'THANH THẢO', 1)
GO
INSERT [dbo].[dtlSinhVien] ([DtlMaSV], [DtlHoSV], [DtlTenSv], [DtlNgaySinh], [DtlPhai], [DtlPhone], [DtlEmail], [DtlMaKH]) VALUES (N'2210900036', N'NGUYỄN THỊ', N'THẢO', CAST(N'2004-08-06' AS Date), 1, N'0975375735', N'thanhthao@gmail.com', N'K22CNT1   ')
GO
