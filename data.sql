USE [master]
GO
/****** Object:  Database [CSDL_QLKS]    Script Date: 10/23/2020 2:25:34 PM ******/
CREATE DATABASE [CSDL_QLKS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CSDL_QLKS', FILENAME = N'D:\CSDL\CSDL_QLKS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CSDL_QLKS_log', FILENAME = N'D:\CSDL\CSDL_QLKS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CSDL_QLKS] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CSDL_QLKS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CSDL_QLKS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CSDL_QLKS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CSDL_QLKS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CSDL_QLKS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CSDL_QLKS] SET ARITHABORT OFF 
GO
ALTER DATABASE [CSDL_QLKS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CSDL_QLKS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CSDL_QLKS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CSDL_QLKS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CSDL_QLKS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CSDL_QLKS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CSDL_QLKS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CSDL_QLKS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CSDL_QLKS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CSDL_QLKS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CSDL_QLKS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CSDL_QLKS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CSDL_QLKS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CSDL_QLKS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CSDL_QLKS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CSDL_QLKS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CSDL_QLKS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CSDL_QLKS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CSDL_QLKS] SET  MULTI_USER 
GO
ALTER DATABASE [CSDL_QLKS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CSDL_QLKS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CSDL_QLKS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CSDL_QLKS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CSDL_QLKS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CSDL_QLKS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CSDL_QLKS] SET QUERY_STORE = OFF
GO
USE [CSDL_QLKS]
GO
/****** Object:  UserDefinedFunction [dbo].[SinhMA_table]    Script Date: 10/23/2020 2:25:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--sinh mã tự động cho khách hàng có truyền tham số
 create function [dbo].[SinhMA_table](@ma nchar(2), @NameTable nvarchar(1000)) 
 
 returns nchar(5)

As
Begin
	declare @MaxMA nchar(5)
	declare @NewMA varchar(5)
	declare @stt	int
	declare @i	int	
	declare @sokytu	int
	if (@NameTable ='KhachHang')
	begin
	if exists(select * from KhachHang )---Nếu bảng hóa đơn có dữ liệu
	 begin
		--Lấy mã giáo viên lớn nhất hiện có
		select @MaxMA = max(MaKH) 
		from KhachHang
		--Trích phần ký số của mã lớn nhất và chuyển thành số 
		set @stt=convert(int, right(@MaxMA,3)) + 1 --Số thứ tự của giáo viên mới
	 end
	else--Nếu bảng giáo viên đang rỗng (nghĩa là chưa có giáo viên nào được lưu trữ trong CSDL.
	 set @stt= 1 -- Số thứ tự của giáo viên trong trường hợp chưa có gv nào trong CSDL
	--Kiểm tra và bổ sung chữ số 0 để đủ 3 ký số trong mã gv.
	set @sokytu = len(convert(varchar(3), @stt))
	set @NewMA= @ma
	set @i = 0
	while @i < 3 -@sokytu
		begin
			set @NewMA = @NewMA + '0'
			set @i = @i + 1
		end	
	set @NewMA = @NewMA + convert(varchar(3), @stt)
	end


	if(@NameTable ='HoaDon')
	begin
	if exists(select * from HoaDon )---Nếu bảng hóa đơn có dữ liệu
	 begin
		--Lấy mã giáo viên lớn nhất hiện có
		select @MaxMA = max(MaHD) 
		from HoaDon
		--Trích phần ký số của mã lớn nhất và chuyển thành số 
		set @stt=convert(int, right(@MaxMA,3)) + 1 --Số thứ tự của giáo viên mới
	 end
	else--Nếu bảng giáo viên đang rỗng (nghĩa là chưa có giáo viên nào được lưu trữ trong CSDL.
	 set @stt= 1 -- Số thứ tự của giáo viên trong trường hợp chưa có gv nào trong CSDL
	--Kiểm tra và bổ sung chữ số 0 để đủ 3 ký số trong mã gv.
	set @sokytu = len(convert(varchar(3), @stt))
	set @NewMA= @ma
	set @i = 0
	while @i < 3 -@sokytu
		begin
			set @NewMA = @NewMA + '0'
			set @i = @i + 1
		end	
	set @NewMA = @NewMA + convert(varchar(3), @stt)
	end
return @NewMA
   
End
GO
/****** Object:  UserDefinedFunction [dbo].[SinhMA_table_kH]    Script Date: 10/23/2020 2:25:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create function [dbo].[SinhMA_table_kH](@ma nchar(2)) 
 
 returns nchar(5)

As
Begin
	declare @MaxMA nchar(5)
	declare @NewMA varchar(5)
	declare @stt	int
	declare @i	int	
	declare @sokytu	int

	if exists(select * from KhachHang )---Nếu bảng hóa đơn có dữ liệu
	 begin
		--Lấy mã giáo viên lớn nhất hiện có
		select @MaxMA = max(MaKH) 
		from KhachHang
		--Trích phần ký số của mã lớn nhất và chuyển thành số 
		set @stt=convert(int, right(@MaxMA,3)) + 1 --Số thứ tự của giáo viên mới
	 end
	else--Nếu bảng giáo viên đang rỗng (nghĩa là chưa có giáo viên nào được lưu trữ trong CSDL.
	 set @stt= 1 -- Số thứ tự của giáo viên trong trường hợp chưa có gv nào trong CSDL
	--Kiểm tra và bổ sung chữ số 0 để đủ 3 ký số trong mã gv.
	set @sokytu = len(convert(varchar(3), @stt))
	set @NewMA= @ma
	set @i = 0
	while @i < 3 -@sokytu
		begin
			set @NewMA = @NewMA + '0'
			set @i = @i + 1
		end	
	set @NewMA = @NewMA + convert(varchar(3), @stt)

return @NewMA
End
GO
/****** Object:  UserDefinedFunction [dbo].[SinhMAtheohaikiso]    Script Date: 10/23/2020 2:25:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[SinhMAtheohaikiso](@ma nchar (2)) 
 
 returns nchar(5)

As
Begin
	declare @MaxMAHD char(5)
	declare @NewMAHD varchar(5)
	declare @stt	int
	declare @i	int	
	declare @sokytu	int

	if exists(select * from KhachHang )---Nếu bảng hóa đơn có dữ liệu
	 begin
		--Lấy mã giáo viên lớn nhất hiện có
		select @MaxMAHD = max(MAHD) 
		from HOADON
		--Trích phần ký số của mã lớn nhất và chuyển thành số 
		set @stt=convert(int, right(@MaxMAHD,4)) + 1 --Số thứ tự của giáo viên mới
	 end
	else--Nếu bảng giáo viên đang rỗng (nghĩa là chưa có giáo viên nào được lưu trữ trong CSDL.
	 set @stt= 1 -- Số thứ tự của giáo viên trong trường hợp chưa có gv nào trong CSDL
	--Kiểm tra và bổ sung chữ số 0 để đủ 3 ký số trong mã gv.
	set @sokytu = len(convert(varchar(3), @stt))
	set @NewMAHD= @ma
	set @i = 0
	while @i < 5 -@sokytu
		begin
			set @NewMAHD = @NewMAHD + '0'
			set @i = @i + 1
		end	
	set @NewMAHD = @NewMAHD + convert(varchar(3), @stt)

return @NewMAHD
End
GO
/****** Object:  Table [dbo].[CT_DichVu]    Script Date: 10/23/2020 2:25:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_DichVu](
	[MaLoaiDV] [nchar](100) NOT NULL,
	[TenLoaiDv] [nvarchar](500) NOT NULL,
	[DonGia] [int] NOT NULL,
	[DonVi] [nvarchar](50) NOT NULL,
	[MaDV] [nchar](100) NOT NULL,
 CONSTRAINT [PK_CT_DichVu] PRIMARY KEY CLUSTERED 
(
	[MaLoaiDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CT_HoaDon]    Script Date: 10/23/2020 2:25:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_HoaDon](
	[MaHD] [nchar](100) NOT NULL,
	[MaThueDV] [nchar](100) NOT NULL,
 CONSTRAINT [PK_CT_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DatPhong]    Script Date: 10/23/2020 2:25:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatPhong](
	[MaPhong] [nchar](100) NOT NULL,
	[MaKH] [nchar](100) NOT NULL,
	[NgayNhan] [smalldatetime] NOT NULL,
	[NgayTra] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_DatPhong] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC,
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 10/23/2020 2:25:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[MaDV] [nchar](100) NOT NULL,
	[TenDV] [nvarchar](1000) NOT NULL,
 CONSTRAINT [PK_DichVu] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 10/23/2020 2:25:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [nchar](100) NOT NULL,
	[MaKH] [nchar](100) NOT NULL,
	[NgayXuatHD] [smalldatetime] NOT NULL,
	[ThanhTien] [int] NOT NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 10/23/2020 2:25:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nchar](100) NOT NULL,
	[TenKH] [nvarchar](1000) NOT NULL,
	[CMND] [nchar](10) NOT NULL,
	[QuocTich] [nvarchar](100) NOT NULL,
	[GioiTinh] [bit] NOT NULL,
	[Tuoi] [int] NOT NULL,
	[SDT] [int] NOT NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHangThueDichVu]    Script Date: 10/23/2020 2:25:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHangThueDichVu](
	[MaKH] [nchar](100) NOT NULL,
	[MaLoaiDV] [nchar](100) NOT NULL,
	[SoLuongDat] [int] NOT NULL,
	[TenDV] [nvarchar](500) NOT NULL,
	[MaThueDV] [nchar](100) NOT NULL,
 CONSTRAINT [PK_KhachHangThueDichVu] PRIMARY KEY CLUSTERED 
(
	[MaThueDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 10/23/2020 2:25:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[MaPhong] [nchar](100) NOT NULL,
	[TenPhong] [nvarchar](500) NOT NULL,
	[LoaiPhong] [nvarchar](100) NOT NULL,
	[Gia] [int] NOT NULL,
	[ChuTich] [nvarchar](1000) NULL,
	[TinhTrang] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Phong] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [NgayXuatHD], [ThanhTien]) VALUES (N'HD001                                                                                               ', N'KH001                                                                                               ', CAST(N'2020-12-02T00:00:00' AS SmallDateTime), 35000000)
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [NgayXuatHD], [ThanhTien]) VALUES (N'HD002                                                                                               ', N'KH002                                                                                               ', CAST(N'2020-12-02T00:00:00' AS SmallDateTime), 35000000)
GO
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [CMND], [QuocTich], [GioiTinh], [Tuoi], [SDT]) VALUES (N'KH001                                                                                               ', N'Nguyễn Mậu ', N'09090090  ', N'Việt Nam', 0, 20, 909190011)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [CMND], [QuocTich], [GioiTinh], [Tuoi], [SDT]) VALUES (N'KH002                                                                                               ', N'Nguyễn Mậu ', N'09090090  ', N'Việt Nam', 0, 20, 909190011)
GO
ALTER TABLE [dbo].[CT_HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_CT_HoaDon_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[CT_HoaDon] CHECK CONSTRAINT [FK_CT_HoaDon_HoaDon]
GO
/****** Object:  StoredProcedure [dbo].[usp_insert_HoaDon]    Script Date: 10/23/2020 2:25:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_insert_HoaDon]
@MaKH nchar(100),
@NgayXuatHD smalldatetime,
@ThanhTien int
as
	declare @MAHD nchar(100)
	set @MAHD = dbo.SinhMA_table('HD','HoaDon')
	begin
	if exists(select * from KhachHang where MaKH = @MaKH)
		if not exists(select * from dbo.HoaDon where MaHD = @MAHD)
		begin
			insert into  dbo.HoaDon values (@MAHD, @MaKH, @NgayXuatHD, @ThanhTien)
			print N'Thêm hoá đơn thành công'
		end
		else
		 print N'Đã có '+@MAHD+N' trong cơ sỏ dữ liệu'
	else print N'Không có '+@MaKH+N' trong cơ sỏ dữ liệu'
end
GO
/****** Object:  StoredProcedure [dbo].[usp_insert_khachhang]    Script Date: 10/23/2020 2:25:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_insert_khachhang]

@TenKH nvarchar(1000),
@CMND nchar(10),
@QuocTich nvarchar(100),
@GioiTinh bit,
@Tuoi int,
@SDT int
as
 begin
 declare  @MaKH nchar(5)
 set @MaKH = dbo.SinhMA_table('KH','KhachHang')
 if not exists(select * from KhachHang where MaKH = @MaKh)
 begin
    
	insert into KhachHang values(@MaKH ,@TenKH, @CMND,@QuocTich , @GioiTinh, @Tuoi, @SDT)
	print N'Thêm khách hàng thành công'
 end
 else
 print N'Đã có mã khách' + @MaKH + N' trong cơ sở dữ liệu'
end

GO
USE [master]
GO
ALTER DATABASE [CSDL_QLKS] SET  READ_WRITE 
GO
