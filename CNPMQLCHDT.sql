
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
	idSP Nvarchar(10) primary key ,
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
	idSP nvarchar(10) foreign key references SanPham(idSP),
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
	idSP nvarchar(10) foreign key references SanPham(idSP),
	soluong	int,
	dongia real
)
Go

--tạo bảng hóa đơn chi tiết
create table BaoHanh(
	idBH int primary key identity,
	idSP nvarchar(10) foreign key references SanPham(idSP),
	idHoaDon int foreign key references HoaDon(idHD),
	idKH int foreign key references KhachHang(idKH),
	hanbaohanh	int
)
Go



