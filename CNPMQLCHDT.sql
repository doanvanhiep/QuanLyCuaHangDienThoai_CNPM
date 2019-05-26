
-- tạo database
create database CNPMQLCHDT
go

--sử dụng database
use CNPMQLCHDT
go


Go
-- tạo bảng nhân viên
create table NhanVien(
	idNV int primary key identity,
	tenNV Nvarchar(50),
	diachi	nVARCHAR(100),
	email nvarchar(100),
	sochungminh int,
	sdt	NVARCHAR(50),
	trangthai nvarchar(50)
)
Go
 -- tạo bảng tài khảon
create table TaiKhoan(
	id int primary key identity,
	idNV int foreign key references NhanVien(idNV),
	tenTK	nVARCHAR(100),
	matKhau	nVARCHAR(100),
	quyen	int
)
Go

--tạo bảng sản phẩm
create table SanPham(
	idSP int primary key identity,
	tenSP Nvarchar(50),
	mota	nVARCHAR(100),
	giaban	real,
	hinh nvarchar(100),
	tongsoluong int,
	hanbaohanh int
)
Go
--tạo bảng khách hàng
create table KhachHang(
	idKH int primary key identity,
	tenKH Nvarchar(50),
	diachi	nVARCHAR(100),
	sdt	nVARCHAR(100)
)
Go

--tạo bảng kho hàng
create table KhoHang(
	idKH int identity,
	idSP int foreign key references SanPham(idSP),
	idNV int foreign key references NhanVien(idNV),
	gianhap	real,
	ngaynhap datetime,
	soluong int
	CONSTRAINT khoachinhbangKhoHang PRIMARY KEY (idKH,idSP)
)
Go

--tạo bảng hóa đơn
create table HoaDon(
	idHD int primary key identity,
	idKH int foreign key references KhachHang(idKH),
	idNV int foreign key references NhanVien(idNV),
	tongtien	real,
	ngayxuat datetime
)
Go

--tạo bảng hóa đơn chi tiết
create table HoaDonChiTiet(
	idHDCC int primary key identity,
	idHoaDon int foreign key references HoaDon(idHD),
	idSP int foreign key references SanPham(idSP),
	soluong	int,
	dongia real
)
Go

--tạo bảng hóa đơn chi tiết
create table BaoHanh(
	idBH int primary key identity,
	idSP int foreign key references SanPham(idSP),
	idHoaDon int foreign key references HoaDon(idHD),
	idKH int foreign key references KhachHang(idKH),
	hanbaohanh	int
)
Go

--Thêm cơ sở dữ liệu


--Bảng nhân viên
insert into NhanVien(tenNV,diachi,email,sochungminh,sdt,trangthai) values (N'Hiep',N'Tây Ninh',N'huynhvinhrikin@gmail.com','123123123','0123123123',N'đang làm')
insert into NhanVien(tenNV,diachi,email,sochungminh,sdt,trangthai) values (N'Vinh Master',N'Tây Ninh',N'huynhvinhrikin@gmail.com','123123123','0123123123',N'đang làm')
insert into NhanVien(tenNV,diachi,email,sochungminh,sdt,trangthai) values (N'Dinh',N'Dak Lak',N'lenhhoxung@gmail.com','123123123','0123123123',N'đang làm')
insert into NhanVien(tenNV,diachi,email,sochungminh,sdt,trangthai) values (N'Long',N'Dak Lak',N'lenhhoxung@gmail.com','123123123','0123123123',N'đang làm')
go

--Bảng tài khoản.

insert into TaiKhoan(idNV,tenTK,matKhau,quyen) values (1,N'hiep',N'123123',1)
insert into TaiKhoan(idNV,tenTK,matKhau,quyen) values (1,N'vinh',N'123123',1)
insert into TaiKhoan(idNV,tenTK,matKhau,quyen) values (1,N'dinh',N'123123',2)
insert into TaiKhoan(idNV,tenTK,matKhau,quyen) values (1,N'long',N'123123',2)
Go

--Thêm bảng sản phẩm
insert into SanPham(tenSP,mota,giaban,hinh,tongsoluong,hanbaohanh) values 
(N'Samsung Galaxy A6 Plus 2018',N'Đây là mô tả của chiếc điện thoại này',6000000,
N'E:\CNPM\DACuoiKi\HinhAnh\samsunggalaxya6plus2018.jpg',5,3)

insert into SanPham(tenSP,mota,giaban,hinh,tongsoluong,hanbaohanh) values 
(N'Samsung Galaxy M20',N'Đây là mô tả của chiếc điện thoại này',8000000,
N'E:\CNPM\DACuoiKi\HinhAnh\samsunggalaxym20.jpg',5,3)

go
--Thêm bảng kho hàng

insert into KhoHang(idSP,idNV,gianhap,ngaynhap,soluong) values (1,1,5000000,25/05/2019,5)
insert into KhoHang(idSP,idNV,gianhap,ngaynhap,soluong) values (2,2,7000000,25/05/2019,5)
Go




-- Viết các procedure

--procedure đăng nhập

GO
alter PROCEDURE [dbo].[spDangNhap]
@userID nvarchar(50),
@password nvarchar(50)
AS
BEGIN
 select * from TaiKhoan where tenTK=@userID and matKhau=@password
END


--procedure DS sp
GO
create PROCEDURE [dbo].[spDSSP]
AS
BEGIN
 select *  from SanPham
END

go

--procedure Thêm SP
GO
create PROCEDURE [dbo].[spThemSP]
@TenSP nvarchar(50),
@MoTa nvarchar(100),
@GiaBan real,
@Hinh nvarchar(100),
@HanBaoHanh int
AS
BEGIN
 insert into SanPham(tenSP,mota,giaban,hinh,tongsoluong,hanbaohanh)
  values (@TenSP,@MoTa,@GiaBan,@Hinh,0,@HanBaoHanh)
END

go

--procedure Sửa SP
GO
create PROCEDURE [dbo].[spSuaSP]
@IDSP int,
@TenSP nvarchar(50),
@MoTa nvarchar(100),
@GiaBan real,
@HanBaoHanh int
AS
BEGIN
 update SanPham
  set tenSP=@TenSP,mota=@MoTa,giaban=@GiaBan,hanbaohanh=@HanBaoHanh where idSP=@IDSP
END

go


--procedure Thêm Kho Hàng
GO
create PROCEDURE [dbo].[spThemKhoHang]
@IDSP int,
@IDNV int,
@GiaNhap real,
@NgayNhap datetime,
@SoLuong int
AS
BEGIN
 insert into KhoHang(idSP,idNV,gianhap,ngaynhap,soluong)
  values (@IDSP,@IDNV,@GiaNhap,@NgayNhap,@SoLuong)
END

go


--procedure Sửa SLSP
GO
create PROCEDURE [dbo].[spSuaSLSP]
@IDSP int,
@SoLuong int
AS
BEGIN
 update SanPham
  set tongsoluong=tongsoluong+@SoLuong where idSP=@IDSP
END

go


select * from KhoHang



