create database QuanLyTaiKhoan
use QuanLyTaiKhoan

create table ChiNhanh (
	MaCN char(5) not null,
	TenCN nvarchar(50) unique,
	DiaChi nvarchar(80) not null,
	primary key (MaCN)
)

create table DichVu (
	MaDV char(5) not null,
	KyHan int not null check (KyHan >= 0),
	TenDV nvarchar(30) not null,
	primary key (MaDV)
)

create table LaiSuat (
	MaDV char (5) not null,
	NgayAD date,
	LaiSuat real not null,
	primary key (MaDV, NgayAD)
)
alter table LaiSuat add constraint fk_LaiSuat_DichVu foreign key (MaDV) references DichVu

create table KhachHang (
	CMND char(9) not null,
	HoTen nvarchar(50) not null,
	DiaChi nvarchar(100) not null,
	NgayCap date not null,
	MaCN char(5) not null,
	primary key (CMND)
)
alter table KhachHang add constraint fk_KhachHang_ChiNhanh foreign key (MaCN) references ChiNhanh

create table GiaoDichVien (
	MaGDV char(9) not null,
	HoTen nvarchar(50) not null,
	DiaChi nvarchar(100) not null,
	MaCN char(5) not null,
	primary key (MaGDV)
)
alter table GiaoDichVien add constraint fk_GiaoDichVien_ChiNhanh foreign key (MaCN) references ChiNhanh

create table Phieu (
	MaPhieu char(9) not null,
	CMND char(9) not null,
	MaDV char(5) not null,
	NgayGui datetime not null default GetDate(),
	LaiSuat real not null,
	SoTienGui money not null default 100000 check (SoTienGui >= 100000),
	NgayDeNhan datetime not null,
	MaGDV_LPG char(9) not null,
	NgayRut datetime,
	TienLai money default 0,
	MaGDV_LPR char(9) not null,
	primary key (MaPhieu)
)
alter table Phieu add constraint fk_Phieu_KhachHang foreign key (CMND) references KhachHang
alter table Phieu add constraint fk_Phieu_DichVu foreign key (MaDV) references DichVu
alter table Phieu add constraint fk_Phieu_MaGDV_LPG_GiaoDichVien foreign key (MaGDV_LPG) references GiaoDichVien(MaGDV)
alter table Phieu add constraint fk_Phieu_MaGDV_LPR_GiaoDichVien foreign key (MaGDV_LPR) references GiaoDichVien(MaGDV)

insert into ChiNhanh values 
	('CN1', N'Chi Nhánh 1', N'19 Nguyễn Hữu Thọ, F.Tân Phong, Q7'),
	('CN2', N'Chi Nhánh 2', N'98 Ngô Tất Tố, F19, Q.Bình Thạnh')

insert into DichVu values
	('DV1', 3, 'Dịch vụ có kì hạn 3 tháng'),
	('DV2', 6, 'Dịch vụ có kì hạn 6 tháng'),
	('DV3', 12, 'Dịch vụ có kì hạn 1 năm'),
	('DV4', 24, 'Dịch vụ có kì hạn 2 năm'),
	('DV5', 36, 'Dịch vụ có kì hạn 3 năm')

insert into LaiSuat values 
	('DV1', '2020/01/01', 0.005),
	('DV2', '2020/01/01', 0.010),
	('DV3', '2020/01/01', 0.020),
	('DV4', '2020/01/01', 0.030),
	('DV5', '2020/01/01', 0.050),

	('DV1', '2021/01/01', 0.003),
	('DV2', '2021/01/01', 0.006),
	('DV3', '2021/01/01', 0.012),
	('DV4', '2021/01/01', 0.020),
	('DV5', '2021/01/01', 0.040)

insert into KhachHang values 
	('129081999', N'Nguyễn Phú An', N'20 Nguyễn Hữu Thọ, F.Tân Phong, Q7', '2020/08/29', 'CN1'),
	('105111999', N'Nguyễn Hoàng Dũng', N'21 Nguyễn Hữu Thọ, F.Tân Phong, Q7', '2020/05/11', 'CN1'),
	('114061999', N'Viên Vĩnh Phát', N'22 Nguyễn Hữu Thọ, F.Tân Phong, Q7', '2020/06/14', 'CN1'),
	('219091999', N'Nguyễn Vũ Khoa', N'99 Ngô Tất Tố, F19, Q.Bình Thạnh', '2020/09/19', 'CN2'),
	('220102002', N'Bùi Hồng Liên', N'100 Ngô Tất Tố, F19, Q.Bình Thạnh', '2020/10/20', 'CN2'),
	('205121999', N'Trác Anh Thư', N'101 Ngô Tất Tố, F19, Q.Bình Thạnh', '2020/12/05', 'CN2')

insert into GiaoDichVien values 
	('GDV1', N'Trịnh Thanh Hoài', N'18 Nguyễn Hữu Thọ, F.Tân Phong, Q7', 'CN1'),
	('GDV2', N'Vưu Thanh Tùng', N'17 Nguyễn Hữu Thọ, F.Tân Phong, Q7', 'CN1'),
	('GDV3', N'Trương Dương Mỹ Hằng', N'97 Ngô Tất Tố, F19, Q.Bình Thạnh', 'CN2'),
	('GDV4', N'Trần Thị Tuyết Mai', N'96 Ngô Tất Tố, F19, Q.Bình Thạnh', 'CN2')