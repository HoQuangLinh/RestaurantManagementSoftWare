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
    MANHANVIEN int identity(1,1)  primary key,
	HOTEN nvarchar(100) not null,
	CHUCVU nvarchar(100) not null,
	GIOITINH nvarchar(10) not null,
	NGAYSINH date
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
   MATHUCAN int identity(1,1)  primary key,
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
	NGAYGOIMON date,
	NGAYTHANHTOAN date default null,
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
create proc USP_SwitchTable @Maban1 int,@Maban2 int
as
begin
declare @MaHD1 int  
declare @MaHD2 int

select @MaHD1=MAHOADON from HOADON
where MABAN=@Maban1 and TRANGTHAI=N'Chưa thanh toán'
select @MaHD2=MAHOADON from HOADON
where MABAN=@Maban2 and TRANGTHAI=N'Chưa thanh toán'
if(@MAHD2 is null)
  begin 
	insert into HOADON(MABAN)
	values(@MaBan2)
	select @MaHD2=max(MAHOADON) from HOADON
	update CHITIETHOADON set MAHOADON=@MaHD2 where MAHOADON=@MAHD1
	update BANAN set TRANGTHAI=N'Trống' where MABAN=@Maban1
	update BANAN set TRANGTHAI=N'Có người' where MABAN=@Maban2
	delete HOADON where MAHOADON=@MaHD1
  end
else if(@MAHD1 is null)
  begin
	insert into HOADON(MABAN)
	values(@MaBan1)
	select @MaHD1=max(MAHOADON) from HOADON
	update CHITIETHOADON set MAHOADON=@MaHD1 where MAHOADON=@MAHD2
	update BANAN set TRANGTHAI=N'Trống' where MABAN=@Maban2
	update BANAN set TRANGTHAI=N'Có người' where MABAN=@Maban1
	delete HOADON where MAHOADON=@MaHD2
  end
else
  begin
	select MACHITIET into temp
	from CHITIETHOADON
	where MAHOADON=@MAHD1 

	update CHITIETHOADON set MAHOADON=@MAHD1 where MAHOADON=@MaHD2;
	update CHITIETHOADON set MAHOADON=@MAHD2 
	where MACHITIET in (select MACHITIET from temp)
	drop table temp
  end
 

end
go
create proc USP_MergeTable @Maban1 int,@Maban2 int
as
begin
declare @MaHD1 int  
declare @MaHD2 int

select @MaHD1=MAHOADON from HOADON
where MABAN=@Maban1 and TRANGTHAI=N'Chưa thanh toán'
select @MaHD2=MAHOADON from HOADON
where MABAN=@Maban2 and TRANGTHAI=N'Chưa thanh toán'
 if(@MAHD2 is null)
  begin 
	insert into HOADON(MABAN)
	values(@Maban2)
	select @MaHD2=max(MAHOADON) from HOADON
	update CHITIETHOADON set MAHOADON=@MaHD2 where MAHOADON=@MAHD1
	update BANAN set TRANGTHAI=N'Trống' where MABAN=@Maban1
	update BANAN set TRANGTHAI=N'Có người' where MABAN=@Maban2
	delete HOADON where MAHOADON=@MaHD1
  end
  else
  begin
	update CHITIETHOADON set MAHOADON=@MAHD2 where MAHOADON=@MaHD1;
	delete HOADON where MAHOADON=@MaHD1
	update BANAN set TRANGTHAI=N'Trống' where MABAN=@Maban1
	
  end
 

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
insert into THUCAN(TENTHUCAN,GIA,MALOAI)
values 
(N'Cơm chiên dương châu',30000,1),
(N'Cơm chiên cá mặn',35000,1),
(N'Cơm chiên trứng cuộn',25000,1),
(N'Cơm chiên trái thơm',35000,1),
(N'Bia tiger',150000,6),
(N'Sting',12000,6),
(N'Pepsi',10000,6),
(N'7 up',10000,6),
(N'Bia Sài Gòn',12000,6),
(N'Mì chiên hải sản',25000,5),
(N'Mì Ý',30000,5),
(N'Kem dừa chuối chiên',25000,4)
SET DATEFORMAT DMY
