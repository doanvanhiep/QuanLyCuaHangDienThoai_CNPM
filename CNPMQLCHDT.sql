
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
	giaban	money,
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
	gianhap	MONEY ,
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
	tongtien MONEY,
	ngayxuat datetime
)
Go

--tạo bảng hóa đơn chi tiết
create table HoaDonChiTiet(
	idHDCC int primary key identity,
	idHoaDon int foreign key references HoaDon(idHD),
	idSP int foreign key references SanPham(idSP),
	soluong	int,
	dongia MONEY
)
Go

--tạo bảng hóa đơn chi tiết
create table BaoHanh(
	idBH int primary key identity,
	idSP int foreign key references SanPham(idSP),
	idHoaDon int foreign key references HoaDon(idHD),
	idKH int foreign key references KhachHang(idKH),
	hanbaohanh	datetime
)
Go

--Thêm cơ sở dữ liệu


--Bảng nhân viên
insert into NhanVien(tenNV,diachi,email,sochungminh,sdt) values (N'Hiệp',N'Bình Định',N'doanvanhiepebn951@gmail.com','123123123','0123123123')
insert into NhanVien(tenNV,diachi,email,sochungminh,sdt) values (N'Vinh Master',N'Tây Ninh',N'huynhvinhrikin@gmail.com','123123123','0123123123')
insert into NhanVien(tenNV,diachi,email,sochungminh,sdt) values (N'Dinh',N'DakLak',N'mynamelenhhoxung@gmail.com','123123123','0123123123')
insert into NhanVien(tenNV,diachi,email,sochungminh,sdt) values (N'Long',N'DakNong',N'phiminhlong@gmail.com','123123123','0123123123')
go

--Bảng tài khoản.

insert into TaiKhoan(idNV,tenTK,matKhau,quyen) values (1,N'hiep',N'123123',1)
insert into TaiKhoan(idNV,tenTK,matKhau,quyen) values (2,N'vinh',N'123123',1)
insert into TaiKhoan(idNV,tenTK,matKhau,quyen) values (3,N'dinh',N'123123',2)
insert into TaiKhoan(idNV,tenTK,matKhau,quyen) values (4,N'long',N'123123',2)
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

--Thêm bảng khách hàng
insert into KhachHang(tenKH,diachi,sdt) values (N'Nguyễn Công Phượng',N'Nghệ An','0987654321')
insert into KhachHang(tenKH,diachi,sdt) values (N'Nguyễn Lê Công',N'TP.HCM','0123456789')
Go

-- Viết các procedure

--procedure đăng nhập

GO
create PROCEDURE [dbo].[spDangNhap]
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
@GiaBan MONEY,
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
@GiaBan MONEY,
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
@GiaNhap MONEY,
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

-----------------------------
--procedure Thêm Hóa Đơn
GO
create PROCEDURE [dbo].[spThemHoaDon]
@IDKH int,
@IDNV int,
@TongTien MONEY,
@NgayXuat datetime
AS
BEGIN
 insert into HoaDon(idKH,idNV,tongtien,ngayxuat)
  values (@IDKH,@IDNV,@TongTien,@NgayXuat)
END
go


--procedure Thêm Hóa Đơn chi tiết
GO
create PROCEDURE [dbo].[spThemHoaDonChiTiet]
@IDSP int,
@SoLuong int,
@DonGia MONEY
AS
BEGIN
declare @IDHD int
select @IDHD= max(idHD) from HoaDon
 insert into HoaDonChiTiet(idHoaDon,idSP,soluong,dongia)
  values (@IDHD,@IDSP,@SoLuong,@DonGia)
END
go

--procedure Tìm sp theo id
GO
create PROCEDURE [dbo].[spTimSPtheoID]
@IDSP int
AS
BEGIN
select * from SanPham where idSP=@IDSP
END
go

--procedure Tìm khách hàng theo sdt
GO
create PROCEDURE [dbo].[spTimKHangtheoSDT]
@SDT nvarchar(100)
AS
BEGIN
select * from KhachHang where sdt=@SDT
end
go

--procedure thêm khách hàng
GO
create PROCEDURE [dbo].[spThemKhachHang]
@SDT nvarchar(100),
@DiaChi nvarchar(100),
@TenKH nvarchar(100)
AS
BEGIN
insert into KhachHang(sdt,diachi,tenKH) values (@SDT,@DiaChi,@TenKH)
end
go

--procedure thêm khách hành
GO
create PROCEDURE [dbo].[spThemBaoHanh]
@IDSP int,
@IDKH int,
@HanBaoHanh datetime
AS
BEGIN
declare @IDHD int
select @IDHD=Max(idHD) from HoaDon
insert into BaoHanh(idSP,idHoaDon,idKH,hanbaohanh) values (@IDSP,@IDHD,@IDKH,@HanBaoHanh)
end
go


--procedure Lấy danh sách khách hàng nhân viên
GO
create PROCEDURE [dbo].[spDSNhanVien]
AS
BEGIN
select NhanVien.idNV,NhanVien.tenNV,NhanVien.diachi,NhanVien.email,NhanVien.sochungminh,NhanVien.sdt
 from NhanVien,TaiKhoan where NhanVien.idNV=TaiKhoan.idNV and TaiKhoan.quyen>0
end
go


--procedure Sửa NhanVien
GO
create PROCEDURE [dbo].[spSuaNV]
@IDNV int,
@TenNV nvarchar(50),
@DiaChi nvarchar(100),
@Email nvarchar(100),
@SoChungMinh int,
@SDT nvarchar(50)
AS
BEGIN
 update NhanVien
  set tenNV=@TenNV,diachi=@DiaChi,email=@Email,sochungminh=@SoChungMinh,sdt=@SDT where idNV=@IDNV
END
go

--procedure Thêm NhanVien
GO
create PROCEDURE [dbo].[spThemNV]
@TenNV nvarchar(50),
@DiaChi nvarchar(100),
@Email nvarchar(100),
@SoChungMinh int,
@SDT nvarchar(50)
AS
BEGIN
 insert into NhanVien(tenNV,diachi,email,sochungminh,sdt) values(@TenNV,@DiaChi,@Email,@SoChungMinh,@SDT)
END
go


--exec spThemNV N'Hưng',N'Long AN','phimviet789@gmail.com',123123123,'0123123123'

--triggers thêm tài khoản 

create trigger [dbo].[themtk] on [dbo].[NhanVien] for insert 
as
begin 
declare @IDNV int
declare @TenNV nvarchar(100)
select @IDNV=idNV ,@TenNV=tenNV from inserted
insert into TaiKhoan(idNV,tenTK,matKhau,quyen) values (@IDNV,@TenNV,'123123',2)
end
go


--Xóa nhân viên

create PROCEDURE [dbo].[spXoaNV]
@IDNV int
AS
BEGIN
 update TaiKhoan
  set quyen=0 where idNV=@IDNV
END
go


--Đổi mật khẩu
create PROCEDURE [dbo].[spDoiMK]
@IDNV int,
@MatKhau nvarchar(100),
@MatKhauMoi nvarchar(100)
AS
BEGIN
 update TaiKhoan
  set matKhau=@MatKhauMoi where idNV=@IDNV and matKhau=@MatKhau
END
go


-- Danh sách Hóa Đơn
create PROCEDURE [dbo].[spDSHD]
AS
BEGIN
 select HD.idHD, HD.ngayxuat,NV.tenNV,HD.tongtien,KH.tenKH
  from HoaDon as HD,NhanVien as NV,KhachHang as KH
   where HD.idKH=KH.idKH and HD.idNV=NV.idNV
END
go



-- Danh sách Hóa Đơn
create PROCEDURE [dbo].[spHDCTbyID]
@IDHD int
AS
BEGIN
 select SP.tenSP,HDCT.soluong,HDCT.dongia
  from HoaDonChiTiet as HDCT,SanPham as SP
   where HDCT.idSP=SP.idSP and HDCT.idHoaDon=@IDHD
END
go

--tìm kiếm sản phẩm theo tên
create proc [dbo].[spTimKiemSPtheoTen]
@TenSP nvarchar(100)
AS
BEGIN
	SELECT * From SanPham
	where tenSP Like N'%'+@TenSP+'%' 
END

go
-- danh sách bảo hành
create proc [dbo].[spDSSPBH]
AS
BEGIN
	SELECT BH.idSP, SP.tenSP,KH.tenKH,BH.hanbaohanh From BaoHanh as BH,SanPham as SP,KhachHang as KH
	where BH.idSP=SP.idSP and BH.idKH=KH.idKH and BH.hanbaohanh> GETDATE()
END

