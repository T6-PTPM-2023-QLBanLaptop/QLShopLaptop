USE [QLShoplaptop]
GO
/****** Object:  Table [dbo].[QUYEN]    Script Date: 11/7/2023 5:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUYEN](
	[MaQuyen] [int] NOT NULL,
	[TenQuyen] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 11/7/2023 5:03:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[MaTaiKhoan] [nvarchar](50) NOT NULL,
	[TenTaiKhoan] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](100) NULL,
	[MaQuyen] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[QUYEN] ([MaQuyen], [TenQuyen]) VALUES (1, N'Admin')
INSERT [dbo].[QUYEN] ([MaQuyen], [TenQuyen]) VALUES (2, N'User')
GO
INSERT [dbo].[TAIKHOAN] ([MaTaiKhoan], [TenTaiKhoan], [MatKhau], [MaQuyen]) VALUES (N'1', N'admin', N'123', 1)
INSERT [dbo].[TAIKHOAN] ([MaTaiKhoan], [TenTaiKhoan], [MatKhau], [MaQuyen]) VALUES (N'2', N'user', N'123', 2)
GO
/****** Object:  StoredProcedure [dbo].[proc_login]    Script Date: 11/7/2023 5:03:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_login]
@user nvarchar(50),
@pass nvarchar(50)
as
BEGIN
	SELECT * FROM TAIKHOAN WHERE TenTaiKhoan = @user AND MatKhau = @pass
END

GO
