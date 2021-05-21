create database QUANLYNHAHANG
go 
use QUANLYNHAHANG
go

create table BANAN
(
   MABAN int  Primary key,
   TRANGTHAI nvarchar(20) not null default N'Trống',
   TENBAN nvarchar(30) unique,
)
go

create table TAIKHOAN
(

	UserName varchar(100)  primary key,
	PassWord varchar(100) not null,	
)
create table NHANVIEN
(	
    MANHANVIEN int  primary key,
	HOTEN nvarchar(100) not null,
	CHUCVU nvarchar(100) not null,
	GIOITINH nvarchar(10) not null,
	NGAYSINH smalldatetime
)
go
create table LOAITHUCAN
(
	 MALOAI int  primary key,
	 TENLOAI  nvarchar(100) unique,
)
go
create table THUCAN
(
   MATHUCAN int  primary key,
   GIA int not null,
   TENTHUCAN nvarchar(100) unique not null,
   MALOAI int not null
   foreign key(MALOAI) references LOAITHUCAN(MALOAI)
)
go
create table HOADON
(
	MAHOADON int identity(1,1)  primary key,
	MABAN int,
	NGAYTHANHTOAN smalldatetime default null,
	TRANGTHAI nvarchar(50) default N'Chưa thanh toán',
	TONGTIEN int default 0
	foreign key(MABAN) references BANAN(MABAN)
	
)
go
create table CHITIETHOADON
(
	MACHITIET int identity(1,1)  primary key,
    MAHOADON int ,
	MATHUCAN int,
	SOLUONG int,
	foreign key(MAHOADON) references  HOADON(MAHOADON),
	foreign key(MATHUCAN) references THUCAN(MATHUCAN)
)

go
--Tao procedure cho tung bang
CREATE PROC USP_Login @userName varchar(100),@passWord varchar(100)
AS
BEGIN
	select *from TAIKHOAN where UserName=@userName and PassWord=@passWord
END
go

CREATE PROC USP_Signup
@UserName varchar(100),
@PassWord varchar(100)
as
begin  
insert into TAIKHOAN(UserName,Password)
values 
(@UserName,@PassWord)
end
go
create proc USP_GetListMenuByIdTable @MABAN int --Show ra cai thong tin hoa don bang MABAN
	as
	begin
	   select ta.TENTHUCAN,ct.SOLUONG,ta.GIA,ct.SOLUONG*ta.GIA as 'THANHTIEN'
       from THUCAN as ta,CHITIETHOADON as ct,HOADON as hd
       where ta.MATHUCAN=ct.MATHUCAN and ct.MAHOADON=hd.MAHOADON
	and hd.MABAN=@MABAN and hd.TRANGTHAI=N'Chưa thanh toán'
	end
go
insert into BANAN(MABAN,TENBAN)
values
(1,N'Bàn 1'),
(2,N'Bàn 2'),
(3,N'Bàn 3'),
(4,N'Bàn 4'),
(5,N'Bàn 5'),
(6,N'Bàn 6'),
(7,N'Bàn 7'),
(8,N'Bàn 8'),
(9,N'Bàn 9'),
(10,N'Bàn 10'),
(11,N'Bàn 11'),
(12,N'Bàn 12')
go
insert into LOAITHUCAN(MALOAI,TENLOAI)
values 
(1,N'Cơm '),
(2,N'Món nướng'),
(3,N'Món xào'),
(4,N'Món tráng miệng'),
(5,N'Mì'),
(6,N'Đồ nước')
go
insert into THUCAN(MATHUCAN,TENTHUCAN,GIA,MALOAI)
values 
(1,N'Cơm chiên dương châu',30000,1),
(2,N'Cơm chiên cá mặn',35000,1),
(3,N'Cơm chiên trứng cuộn',25000,1),
(4,N'Cơm chiên trái thơm',35000,1),
(5,N'Bia tiger',150000,6),
(6,N'Sting',12000,6),
(7,N'Pepsi',10000,6),
(8,N'7 up',10000,6),
(9,N'Bia Sài Gòn',12000,6),
(10,N'Mì chiên hải sản',25000,5),
(11,N'Mì Ý',30000,5),
(12,N'Kem dừa chuối chiên',25000,4)
SET DATEFORMAT DMY


