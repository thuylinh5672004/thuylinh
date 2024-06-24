USE [DtlK22CNT1Lesson10]
GO
/****** Object:  Table [dbo].[KetQua]    Script Date: 24/06/2024 9:08:02 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KetQua](
	[DtlMaSV] [nchar](10) NOT NULL PRIMARY KEY,
	[DtlMaMH] [nchar](10) NULL PRIMARY KEY,
	[DtlDiem] [int] NULL,
 CONSTRAINT [PK_KetQua] PRIMARY KEY CLUSTERED 
(
	[DtlMaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[khoa]    Script Date: 24/06/2024 9:08:02 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khoa](
	[DtlMaKH] [nchar](10) NOT NULL,
	[DtlTenKH] [nvarchar](50) NULL,
 CONSTRAINT [PK_khoa] PRIMARY KEY CLUSTERED 
(
	[DtlMaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 24/06/2024 9:08:02 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[DtlMaMH] [nchar](10) NOT NULL,
	[DtlTenMH] [nvarchar](50) NULL,
	[DtlSoTiet] [nchar](10) NULL,
 CONSTRAINT [PK_MonHoc] PRIMARY KEY CLUSTERED 
(
	[DtlMaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sinhvien]    Script Date: 24/06/2024 9:08:02 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sinhvien](
	[DtlMaSV] [nchar](10) NOT NULL,
	[DtlHoSV] [nvarchar](50) NULL,
	[DtlTenSV] [nvarchar](50) NULL,
	[DtlPhai] [bit] NULL,
	[DtlNgaysinh] [date] NULL,
	[DtlNoisinh] [nvarchar](50) NULL,
	[DtlMaKH] [nchar](10) NULL,
	[DtlHocBong] [nvarchar](50) NULL,
	[DtlDiemTB] [int] NULL,
 CONSTRAINT [PK_Sinhvien] PRIMARY KEY CLUSTERED 
(
	[DtlMaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[KetQua] ([DtlMaSV], [DtlMaMH], [DtlDiem]) VALUES (N'H01       ', N'K01       ', 7)
INSERT [dbo].[KetQua] ([DtlMaSV], [DtlMaMH], [DtlDiem]) VALUES (N'H02       ', N'K02       ', 8)
GO
INSERT [dbo].[khoa] ([DtlMaKH], [DtlTenKH]) VALUES (N'AS        ', N'QTKD')
INSERT [dbo].[khoa] ([DtlMaKH], [DtlTenKH]) VALUES (N'AU        ', N'QHCC')
GO
INSERT [dbo].[Sinhvien] ([DtlMaSV], [DtlHoSV], [DtlTenSV], [DtlPhai], [DtlNgaysinh], [DtlNoisinh], [DtlMaKH], [DtlHocBong], [DtlDiemTB]) VALUES (N'H01       ', N'Nguyễn ', N'Thảo', 1, CAST(N'2004-07-04' AS Date), N'Đống Đa,Hà Nội', N'AS        ', N'Đạt', 7)
INSERT [dbo].[Sinhvien] ([DtlMaSV], [DtlHoSV], [DtlTenSV], [DtlPhai], [DtlNgaysinh], [DtlNoisinh], [DtlMaKH], [DtlHocBong], [DtlDiemTB]) VALUES (N'H02       ', N'Lê', N'LY', 1, CAST(N'2004-07-06' AS Date), N'Thanh Xuân,Hà Nội', N'AU        ', N'Đạt', 8)
GO
ALTER TABLE [dbo].[MonHoc]  WITH CHECK ADD  CONSTRAINT [FK_MonHoc_KetQua] FOREIGN KEY([DtlMaMH])
REFERENCES [dbo].[KetQua] ([DtlMaSV])
GO
ALTER TABLE [dbo].[MonHoc] CHECK CONSTRAINT [FK_MonHoc_KetQua]
GO
ALTER TABLE [dbo].[Sinhvien]  WITH CHECK ADD  CONSTRAINT [FK_Sinhvien_KetQua] FOREIGN KEY([DtlMaSV])
REFERENCES [dbo].[KetQua] ([DtlMaSV])
GO
ALTER TABLE [dbo].[Sinhvien] CHECK CONSTRAINT [FK_Sinhvien_KetQua]
GO
ALTER TABLE [dbo].[Sinhvien]  WITH CHECK ADD  CONSTRAINT [FK_Sinhvien_khoa] FOREIGN KEY([DtlMaKH])
REFERENCES [dbo].[khoa] ([DtlMaKH])
GO
ALTER TABLE [dbo].[Sinhvien] CHECK CONSTRAINT [FK_Sinhvien_khoa]
GO
