create database QuanLiStudio4
go
use QuanLiStudio4
go

create table ThoChup
(
	ID int identity not null,
	SoLuongThoChup int default 0,
	SoTienThue float default 0
);
go

create table DichVu
(
	ID int identity not null,
	TenGoiQuay nvarchar(1000) not null,
	LoaiGoiQuay int not null default 1,
	DonGia float not null check (DonGia >=0),
	SoNguoiQuay int default 1 not null check ( SoNguoiQuay >0),
	MoTa nvarchar(1000),
	enable int default 1
)
go

create table KhachHang
(
	Id int identity  not null,
	TenKH nvarchar(1000) not null,
	SoDienThoai char(11) ,
	Email nvarchar(500) ,
	enable int default 1
)
go
create table KhachHang_Detail
(
	ID int identity not null,
	MaKH int not null,
	IDQuocGia bigint not null
)
go

create table Picture_OF_Customer
(
	ID int identity not null,
	PictureName nvarchar(100) not null,
	PictureFIleName nvarchar(100),
	PictureData varbinary(max),
	IDKhachHang int not null
)
go

create table NhanVien
(
	ID int identity not null,
	TenNV nvarchar(1000) not null,
	SDT char(11) not null,
	NgaySinh Date not null,
	Email nvarchar(100) not null,
	SoCCCD char(30) not null,
	enable int default 1
)
go
create table Picture_OF_NhanVien
(
	ID int identity not null,
	PictureName nvarchar(100) not null,
	PictureFIleName nvarchar(100),
	PictureData varbinary(max),
	IDNhanVien int not null
)
go
create table HoaDon
(
	ID int identity not null,
	NgayLap datetime not null,
	NgayTra dateTime not null,
	TienCoc float not null,
	SoTienConLai float not null,
	TongTien float not null check (TongTien >=0),
	GiamGia int default 0 check (GiamGia >=0),
	Enable int default 1
)
go

create table CT_HoaDon
(
	ID int identity not null,
	MaHD int  not null,
	MaGoiQuay int  not null,
	MaThoChup int not null,
	MaKH int not null,
	MaNV int not null
)
go
create table tbl_user
( 
	ID int identity  not null,
	MaNV int ,
	TenTaiKhoan nvarchar(50) not null,
	pass varchar(50) default 123
)
go

create table tbl_permission
(
	ID int identity not null,
	TenQuyenHan nvarchar(100),
	MoTaTenQuyenHan nvarchar(100)
)
go

create table tbl_permission_detail
(
	ID int identity not null,
	name_action nvarchar(100),
	code_action nvarchar(50),
	id_per int not null
)
go

create table tbl_per_relationship
(
	ID int identity not null,
	id_user_rel int not null,
	id_per_rel int not null,
	suspended bit not null
)
go

CREATE TABLE QuocGia(
	ID bigint identity not null,
	tenQuocGia nvarchar(200) NOT NULL,
)
GO

CREATE TABLE TinhThanhPho(
	ID bigint identity not null,
	tenTinhThanhPho nvarchar(200) NOT NULL,
	quocGiaId bigint  NOT NULL,

)
GO
CREATE TABLE QuanHuyen(
	ID bigint identity not null,
	tenQuanHuyen nvarchar(200) NOT NULL,
	tinhThanhPhoId bigint not null,
)
GO
CREATE TABLE XaPhuong(
	ID bigint identity  not null,
	tenXaPhuong nvarchar(200) NOT NULL,
	quanHuyenId bigint not null,
)
GO
-- Primary key: Đảm bảo tính toàn vẹn của dữ liệu
-- PK sẽ được đặt trên cột/ tập cột mang giá trị là duy nhất
-- Cột/ Tập cột phải là non null 
-- 1 bảng chỉ có duy nhất 1 PK/ PK có thể được đặt trên nhiều cột

alter table XaPhuong add constraint pk_ID_XaPhuong primary key (ID)
alter table QuanHuyen add constraint pk_ID_QuanHuyen primary key (ID)
alter table QuocGia add constraint pk_ID_QuocGia primary key (ID)
alter table TinhThanhPho add constraint pk_ID_TinhThanhPho primary key(ID)
alter table tbl_per_relationship add constraint pk_ID_tbl_per_rel primary key (ID)
alter table tbl_permission_detail add constraint pk_ID_tbl_per_detail primary key (ID)
alter table tbl_permission add constraint pk_ID_tbl_per primary key (ID)
alter table tbl_user add constraint pk_ID_tbl_User primary key (ID)
alter table CT_HoaDon add constraint pk_ID_CT_HD primary key (ID)
alter table HoaDon add constraint pk_ID_HD primary key (ID)
alter table NhanVien add constraint pk_ID_NV primary key (ID)
alter table khachHang add constraint pk_ID_KH primary key (ID)
alter table ThoChup add constraint pk_ID primary key (ID)
alter table DichVu add constraint pk_ID_DV primary key(ID)
alter table KhachHang_Detail add constraint pk_ID_KH_Detail primary key(ID)
alter table NhanVien_Detail add constraint pk_ID_NV_Detail primary key(ID)
alter table Picture_Of_Customer add constraint pk_ID_Pic_Cus primary key(ID)
alter table Picture_Of_NhanVien add constraint pk_ID_Pic_NV primary key(ID)


-- Foreign Key( Khóa ngoại - FK) Đảm bảo tính toàn vẹn cho tham chiếu cho bảng
alter table XaPhuong add constraint fk_quanHuyenID foreign key (quanHuyenID) references QuanHuyen(ID)
alter table QuanHuyen add constraint fk_tinhThanhPhoID foreign key (tinhThanhPhoID) references TinhThanhPho(ID)
alter table TinhThanhPho add constraint fk_QuocGiaID foreign key (QuocGiaID) references QuocGia(ID)
alter table KhachHang add constraint fk_IDQuocGia foreign key (IDQuocGia) references QuocGia(ID)
alter table NhanVien add constraint fk_IDQuocGia2 foreign key (IDQuocGia) references QuocGia(ID)
alter table CT_HoaDon add constraint fk_MaHD foreign key (MaHD) references HoaDon(ID)
alter table CT_HoaDon add constraint fk_MaGoiQuay foreign key (MaGoiQuay) references DichVu(ID)
alter table CT_HoaDon add constraint fk_MaThoChup foreign key (MaThoChup) references ThoChup(ID)
alter table CT_HoaDon add constraint fk_MaKH2 foreign key (MaKH) references KhachHang(ID)
alter table CT_HoaDon add constraint fk_MaNV3 foreign key (MaNV) references NhanVien(ID)
alter table HoaDon add constraint fk_MaNV foreign key (MaNV) references NhanVien(ID)-- Đã xóa
alter table HoaDon add constraint fk_MaKH2 foreign key (MaKH) references KhachHang(ID)-- đã xóa
alter table tbl_user add constraint fk_MaNV2 foreign key (MaNV) references NhanVien(ID)
alter table tbl_permission_detail add constraint fk_id_per foreign key(id_per) references tbl_permission(ID)
alter table tbl_per_relationship add constraint fk_id_user_rel foreign key (id_user_rel) references tbl_user(ID)
alter table tbl_per_relationship add constraint fk_id_per_rel foreign key (id_per_rel) references tbl_permission(ID)
alter table KhachHang_Detail add constraint fk_KhachHangID foreign key (MaKH) references khachHang(ID)
alter table KhachHang_Detail add constraint fk_QuocGiaID2 foreign key (IDQuocGia) references QuocGia(ID)
alter table NhanVien_Detail add constraint fk_NhanVienID foreign key (MaNV) references NhanVien(ID)
alter table NhanVien_Detail add constraint fk_QuocGiaID3 foreign key (IDQuocGia) references QuocGia(ID)
alter table Picture_Of_NhanVien add constraint fk_ID_Pic_NV foreign key(IDNhanVien) references NhanVien(ID)
alter table Picture_Of_Customer add constraint fk_ID_Pic_KH foreign key(IDKhachHang) references KhachHang(ID)


-- Thêm các thuộc tính mới
alter table CT_HoaDon add MaNV int
alter table CT_HoaDon add MaKH int
alter table CT_HoaDon add DonGia float
alter table CT_HoaDon add DonGiaThoChup float

alter table NhanVien add Xa nvarchar(1000)
alter table NhanVien add Huyen nvarchar(1000)
alter table NhanVien add Tinh nvarchar(1000)
alter table NhanVien add Hinh varbinary(max) 
alter table NhanVien add GioiTinh nvarchar(20)
alter table NhanVien add Luong float
alter table NhanVien add LoaiMucLuong nvarchar(100)
alter table NhanVien add TinhTrangLamViec nvarchar(100)
alter table NhanVien add NgayThoiViec datetime 
alter table NhanVien add NgayVaolam datetime
alter table NhanVien add ThongTinHopDong nvarchar
alter table NhanVien add LyDoThoiViec nvarchar

alter table KhachHang add Xa nvarchar(1000)
alter table KhachHang add Huyen nvarchar(1000)
alter table KhachHang add Tinh nvarchar(1000)
alter table KhachHang add Hinh varbinary(max) 
alter table KhachHang add GioiTinh nvarchar(10)

-- Xóa các thứ không cần thiết
alter table HoaDon drop column taikhoan
alter table HoaDon drop column MaNV
alter table HoaDon drop constraint fk_MaNV
alter table HoaDon drop constraint fk_MaKH2
alter table HoaDon drop column MaKH

alter table KhachHang drop column GioiTinh
alter table CT_hoaDon drop column DonGia
alter table NhanVien drop column IDQuocGia

drop table KhachHang_Detail
drop table NhanVien_Detail
drop table Picture_OF_Customer
drop table Picture_OF_NhanVien

-- insert thông tin vào bảng :))) 
insert NhanVien values (N'Ngô Thành Tâm','0329245971','07/02/1995','ngothanhtam@gmail@gmail.com','0123456789123',1)
insert tbl_user values (1,N'admin',N'123')
insert tbl_permission values (N'admin',N'Chức vụ cao nhất')
insert tbl_permission_detail values (N'Thêm',N'Add',1),(N'Sửa',N'UPDATE',1),(N'Xóa',N'Delete',1),(N'Tổng quan',N'Statistical',1),
(N'Hóa đơn',N'BILL',1),(N'Nhân viên',N'STAFF',1),(N'Khách hàng',N'Customer',1),(N'Dịch vụ',N'Service',1),(N'Khôi phục dữ liệu',N'BACKUP',1),(N'Ẩn',N'DISABLE',1)
delete tbl_permission_detail
insert tbl_permission_relationship values (1,1,'true')



