USE [daothithuylinh_2210900036]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 11/07/2024 2:31:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[DtlMaSach] [nchar](5) NOT NULL,
	[DtlTenSach] [nvarchar](50) NULL,
	[DtlSoTrang] [int] NULL,
	[DtlNamXB] [int] NULL,
	[DtlMaTG] [nchar](5) NULL,
	[DtlTrangThai] [bit] NOT NULL,
 CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED 
(
	[DtlMaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tacgia]    Script Date: 11/07/2024 2:31:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tacgia](
	[DtlMaTG] [nchar](5) NOT NULL,
	[DtlTenTG] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tacgia] PRIMARY KEY CLUSTERED 
(
	[DtlMaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Sach] ([DtlMaSach], [DtlTenSach], [DtlSoTrang], [DtlNamXB], [DtlMaTG], [DtlTrangThai]) VALUES (N'S001 ', N'Truyện Nguh Ngôn', 34, 2018, N'TG001', 1)
INSERT [dbo].[Sach] ([DtlMaSach], [DtlTenSach], [DtlSoTrang], [DtlNamXB], [DtlMaTG], [DtlTrangThai]) VALUES (N'S002 ', N'Từ điển TV', 56, 2008, N'TG002', 1)
INSERT [dbo].[Sach] ([DtlMaSach], [DtlTenSach], [DtlSoTrang], [DtlNamXB], [DtlMaTG], [DtlTrangThai]) VALUES (N'S003 ', N'Sách KH', 34, 2014, N'TG003', 1)
GO
INSERT [dbo].[Tacgia] ([DtlMaTG], [DtlTenTG]) VALUES (N'TG001', N'Vũ Trọng Huy')
INSERT [dbo].[Tacgia] ([DtlMaTG], [DtlTenTG]) VALUES (N'TG002', N'NGuyên Thái Ngọc')
INSERT [dbo].[Tacgia] ([DtlMaTG], [DtlTenTG]) VALUES (N'TG003', N'Lệ Thúy Hiền')
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_Tacgia] FOREIGN KEY([DtlMaTG])
REFERENCES [dbo].[Tacgia] ([DtlMaTG])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_Tacgia]
GO
