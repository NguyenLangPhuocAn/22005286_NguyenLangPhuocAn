create database QuanLyBanHangNoiThat
go
use QuanLyBanHangNoiThat
go
create table ChucVu
(
MaCV int primary key IDENTITY not null,
TenCV nvarchar(36) not null,
Luong int not null,
)
go
create table NhanVien
(
MaNV nvarchar(16) not null primary key,
TenNV nchar(36) not null,
Ngaysinh Date,
MaCV int not null,
FOREIGN KEY (MaCV) REFERENCES ChucVu(MaCV)
)
go
create table NhaCC
(
MaNCC varchar(5) primary key not null,
TenNCC nvarchar(36) not null,
Diachi nvarchar(50) not null,
SDT varchar(11) not null,
)
go
create table VatTu
(
MaVT varchar(10) primary key  not null,
TenVT nvarchar(36) not null,
MaNCC varchar(5) not null,
Soluong int not null,
Dongia int not null,
FOREIGN KEY (MaNCC) REFERENCES NhaCC(MaNCC)
)
go
create table KhachHang
(
MaKH int primary key IDENTITY not null,
TenKH nvarchar(36) not null,
Diachi nvarchar(50) not null,
SDT varchar(11) not null,
)
go
create table HoaDon
(
MaHD int primary key IDENTITY not null,
Ngay date not null,
MaKH int not null,
TongTien int not null,
foreign key (MaKH) references KhachHang(MaKH),
)
create table ChiTietHoaDon
(
MaCTHD int primary key IDENTITY not null,
MaHD int not null,
Soluong int not null,
MaVT varchar(10) not null,
Dongia int not null,
foreign key (MaHD) references HoaDon(MaHD),
foreign key (MaVT) references VatTu(MaVT)
)
go
create table Users
(
MaNV nvarchar(16) not null,
Passwords varchar(32) not null,
GhiChu nvarchar(36),
primary key (MaNV),
foreign key(MaNV) references NhanVien(MaNV)
)


insert into ChucVu (TenCV,Luong) values (N'Nhân Viên',12000)
insert into ChucVu (TenCV,Luong) values (N'Quản Lý',1800)
insert into ChucVu (TenCV,Luong) values (N'Nhân Viên Kho',13000)

insert into NhanVien values ('10000',N'Nguyễn Văn A','2004-11-14','01')
insert into NhanVien values ('10001',N'Nguyễn Văn B','2004-12-14','02')
insert into NhanVien values ('10002',N'Nguyễn Văn C','2004-10-14','03')
insert into NhanVien values ('10003',N'Nguyễn Văn D','2004-09-14','01')
insert into NhanVien values ('10004',N'Nguyễn Văn E','2004-08-14','01')
insert into NhanVien values ('10005',N'Nguyễn Văn F','2004-07-14','01')
insert into NhanVien values ('10006',N'Nguyễn Văn G','2004-06-14','01')
insert into NhanVien values ('10007',N'Nguyễn Văn H','2004-08-15','01')

insert into NhaCC values('JG01',N'Cty TNHH Nội Thất','12/78 Phan Đình Phùng Q.7','01597536842')
insert into NhaCC values('SP01',N'Cty TNHH Vật Liệu','12/77 Phan Đình Phùng Q.7','01597536843')
insert into NhaCC values('AD01',N'Cty TNHH Điện Lực','12/76 Phan Đình Phùng Q.7','01597536464')

insert into VatTu values('MID01',N'Bàn Gỗ','JG01',10,29000)
insert into VatTu values('MID02',N'Ghế Gỗ','JG01',10,35000)
insert into VatTu values('TOP01',N'Thép','SP01',10,45000)
insert into VatTu values('TOP02',N'Gỗ','SP01',10,35000)
insert into VatTu values('BOT01',N'Bóng Đèn','AD01',10,1000)

insert into KhachHang values(N'Nguyễn Văn A',N'12/34 Phan Đình Phùng Q.PN','0123456785')
insert into KhachHang values(N'Nguyễn Văn B',N'12/35 Phan Đình Phùng Q.PN','0124456784')
insert into KhachHang values(N'Nguyễn Văn T',N'12/36 Phan Đình Phùng Q.PN','0125456783')
insert into KhachHang values(N'Nguyễn Văn Q',N'12/37 Phan Đình Phùng Q.PN','0126456782')
insert into KhachHang values(N'Nguyễn Văn E',N'12/38 Phan Đình Phùng Q.PN','0127456781')
insert into KhachHang values(N'Nguyễn Văn R',N'12/39 Phan Đình Phùng Q.PN','0128456780')

insert into HoaDon values(CURRENT_TIMESTAMP,'1',0)
insert into HoaDon values(CURRENT_TIMESTAMP,'2',0)
insert into HoaDon values(CURRENT_TIMESTAMP,'3',0)
insert into HoaDon values(CURRENT_TIMESTAMP,'4',0)

insert into ChiTietHoaDon values(1,1,'MID01','29000')
insert into ChiTietHoaDon values(2,2,'MID02','35000')
insert into ChiTietHoaDon values(3,3,'TOP01','45000')
insert into ChiTietHoaDon values(4,3,'BOT01','1000')

update HOADON Set TongTien='29000'Where MaHD=1
update HOADON Set TongTien='70000'Where MaHD=2
update HOADON Set TongTien='135000'Where MaHD=3
update HOADON Set TongTien='3000'Where MaHD=4

insert into Users values('10000','123','')
insert into Users values('10001','123','')
insert into Users values('10002','123','')