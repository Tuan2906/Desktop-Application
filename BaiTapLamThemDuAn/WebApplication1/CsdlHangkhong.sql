
create database QuanLyHangKhong;
use QuanLyHangKhong;
alter table khachang add NgaySinh date;
alter table khachang modify NgaySinh varchar(15);
alter table khachang modify NgaySinh varchar(25);
alter table khachang modify TenKH varchar(25);
alter table muave add loaive varchar(20);
select * from chuyenbay where macb='VN478';
select * from khachang;
select * from muave;
update muave
set soGhe="F10"
where Makh=21 and MACB='VN477'
select * from chuyenbay where date(gioDi) like "2023-09-27";
Update chuyenbay set 	
gioDi="2023-09-27  07:55:00"
where MACB="VN431";
Update chuyenbay set 	
chiphi=455
where MACB="VN477";
delete from khachang where makh=1;
delete from khachang where makh=1;
delete from khachang where makh=khachangmuave2;
delete from khachang where makh=47;
delete from khachang where makh=48;
delete from khachang where makh=49;
delete from khachang where makh=57;
delete from khachang where makh=56;
delete from muave where makh=47;
delete from muave where makh=48;
delete from muave where makh=46;
delete from muave where makh=40;

select * from muave;
alter table muave modify thue varchar(20)
default 500000;
alter table muave alter thue drop default;
create table MAYBAY (
	MaMB int,
	Loai varchar(50),
	TamBay int,
	constraint MAYBAY_PK primary key (MaMB)
);

create table NHANVIEN (
	MaNV char(9),
	Ten varchar(50),
	Luong int,
	constraint NHANVIEN_PK primary key (MaNV)
);

create table CHUYENBAY (
	MaCB char(5),
	GaDi varchar(50),
	GaDen varchar(50),
	DoDai int,
	GioDi datetime,
	GioDen datetime,
	ChiPhi int,
	MaNV char(9),
	MaMB int,
	constraint CHUYENBAY_PK primary key (MaCB),
	foreign key(MaNV) references NHANVIEN (MaNV),
	foreign key(MaMB) references MAYBAY (MaMB)
);

create table CHUNGNHAN (
	MaNV char(9),
	MaMB int,
	constraint CHUNGNHAN_PK primary key (MaNV, MaMB),
	constraint CHUNGNHAN_NHANVIEN_FK foreign key (MaNV) references NHANVIEN (MaNV),
	constraint CHUNGNHAN_MAYBAY_FK foreign key (MaMB) references MAYBAY (MaMB)
);
select*from muave;
alter  table muave modify column macb varchar(10);
alter table muave add constraint muave1_chuyenbay_fk  foreign key (MaCB) references CHUYENBAY (MaCB);
alter table chuyenbay modify column macb varchar(10);
alter table khachang add column CCCD varchar(13) unique; 
insert into khachang values('1','nguyenchautuan','113');
alter table muave drop constraint MUAVE_MAYBAY_FK;
insert into MuaVe values('VN431','1','Da thanh toan',90000);
alter table muave modify column tinhTrang varchar(20);
select A.MaCB,b.Loai,A.GaDi,A.GaDen,A.GioDi,A.GioDen,b.Loai,c.MAKH from chuyenbay A
join maybay b on A.MaMB=b.MaMB	
join muave c on A.MaCB=c.MaCB;
alter table khachang add column gioitinh varchar(5); 
alter table muave add column thue varchar(20);
alter table muave add column soluongmua varchar(10);
alter table muave add column soGhe varchar(15);
-- chen du lieu NHANVIEN
insert into NHANVIEN values ('242518965','Tran Van Son',120433);
insert into NHANVIEN values ('141582651','Doan Thi Mai',178345);
insert into NHANVIEN values ('011564812','Ton Van Quy',153972);
insert into NHANVIEN values ('567354612','Quan Cam Ly',256481);
insert into NHANVIEN values ('552455318','La Que',101745);
insert into NHANVIEN values ('550156548','Nguyen Thi Cam',205187);
insert into NHANVIEN values ('390487451','Le Van Luat',212156);
insert into NHANVIEN values ('274878974','Mai Quoc Minh',99890);
insert into NHANVIEN values ('254099823','Nguyen Thi Quynh',24450);
insert into NHANVIEN values ('356187925','Nguyen Vinh Bao',44740);
insert into NHANVIEN values ('355548984','Tran Thi Hoai An',212156);
insert into NHANVIEN values ('310454876','Ta Van Do',212156);
insert into NHANVIEN values ('489456522','Nguyen Thi Quy Linh',127984);
insert into NHANVIEN values ('489221823','Bui Quoc Chinh',23980);
insert into NHANVIEN values ('548977562','Le Van Quy',84476);
insert into NHANVIEN values ('310454877','Tran Van Hao',33546);
insert into NHANVIEN values ('142519864','Nguyen Thi Xuan Dao',227489);
insert into NHANVIEN values ('269734834','Truong Tuan Anh',289950);
insert into NHANVIEN values ('287321212','Duong Van Minh',48090);
insert into NHANVIEN values ('552455348','Bui Thi Dung',92013);
insert into NHANVIEN values ('248965255','Tran Thi Ba',43723);
insert into NHANVIEN values ('159542516','Le Van Ky',48250);
insert into NHANVIEN values ('348121549','Nguyen Van Thanh',32899);
insert into NHANVIEN values ('574489457','Bui Van Lap',20);
insert into NHANVIEN values ('517354612','chau tuan',256481);
insert into NHANVIEN values ('517354613','nguyen chau tuan','256482');
select * from chuyenbay where GioDi
-- chen du lieu MAYBAY
insert into MAYBAY values (747,'Boeing 747 - 400',13488);
insert into MAYBAY values (737,'Boeing 737 - 800',5413);
insert into MAYBAY values (380,'Airbus A380 - 500',15000);
insert into MAYBAY values (340,'Airbus A340 - 300',11392);
insert into MAYBAY values (757,'Boeing 757 - 300',6416);
insert into MAYBAY values (777,'Boeing 777 - 300',10306);
insert into MAYBAY values (767,'Boeing 767 - 400ER',10360);
insert into MAYBAY values (320,'Airbus A320',4168);
insert into MAYBAY values (319,'Airbus A319',2888);
insert into MAYBAY values (727,'Boeing 727',2406);
insert into MAYBAY values (154,'Tupolev 154',6565);
select (ChiPhi-0.1*chiphi) as giave from chuyenbay;

-- chen du lieu CHUYENBAY
insert into CHUYENBAY values ('VN431','SGN','CAH',3693,'1998-01-23 05:55:00','1998-01-23 06:55:00',236,'242518965',380);
insert into CHUYENBAY values ('VN320','SGN','DAD',2798,'1998-01-23 06:00:00','1998-01-23 07:10:00',221,'567354612',319);
insert into CHUYENBAY values ('VN464','SGN','DLI',2002,'1998-01-23  07:20:00','1998-01-23 08:05:00',225,'574489457',319);
insert into CHUYENBAY values ('VN216','SGN','DIN',4170,'1998-01-23 10:30:00','1998-01-23 14:20:00',262,'574489457',777);
insert into CHUYENBAY values ('VN280','SGN','HPH',11979,'1998-01-23 06:00:00','1998-01-23 08:00:00',1279,'242518965',777);
insert into CHUYENBAY values ('VN254','SGN','HUI',8765,'1998-01-23 18:40:00','1998-01-23 20:00:00',781,'548977562',380);
insert into CHUYENBAY values ('VN338','SGN','BMV',4081,'1998-01-23 15:25:00','1998-01-23 16:25:00',375,'269734834',319);
insert into CHUYENBAY values ('VN440','SGN','BMV',4081,'1998-01-23 18:30:00','1998-01-23 19:30:00',426,'548977562',380);
insert into CHUYENBAY values ('VN651','DAD','SGN',2798,'1998-01-23 19:30:00','1998-01-23 08:00:00',221,'242518965',319);
insert into CHUYENBAY values ('VN276','DAD','CXR',1283,'1998-01-23 09:00:00','1998-01-23 12:00:00',203,'390487451',154);
insert into CHUYENBAY values ('VN374','HAN','VII',510,'1998-01-23 11:40:00','1998-01-23 13:25:00',120,'567354612',757);
insert into CHUYENBAY values ('VN375','VII','CXR',752,'1998-01-23 14:15:00','1998-01-23 16:00:00',181,'390487451',747);
insert into CHUYENBAY values ('VN269','HAN','CXR',1262,'1998-01-23 14:10:00','1998-01-23 15:50:00',202,'390487451',320);
insert into CHUYENBAY values ('VN315','HAN','DAD',134,'1998-01-23 11:45:00','1998-01-23 13:00:00',112,'310454877',320);
insert into CHUYENBAY values ('VN317','HAN','UIH',827,'1998-01-23 15:00:00','1998-01-23 16:15:00',190,'552455348',727);
insert into CHUYENBAY values ('VN741','HAN','PXU',395,'1998-01-23 06:30:00','1998-01-23 08:30:00',120,'552455348',767);
insert into CHUYENBAY values ('VN474','PXU','PQC',1586,'1998-01-23 08:40:00','1998-01-23 11:20:00',102,'552455348',767);
insert into CHUYENBAY values ('VN476','UIH','PQC',485,'1998-01-23 09:15:00','1998-01-23 11:50:00',117,'552455348',767);
insert into CHUYENBAY values ('VN477','Tp. Hồ Chí Minh (SGN)','Pleiku (PXU)',485,'2023-05-21 09:15:00','2023-05-21 11:15:00',127,'552455348',767);
insert into CHUYENBAY values ('VN478','Pleiku (PXU)','Tp. Hồ Chí Minh (SGN)',485,'1998-01-23 09:15:00','2023-06-25 12:00:00',127,'552455348',767);
update Chuyenbay
set GioDi='2023-06-25 11:00:00'
where MACB="VN478";
alter table khachang modify ghichu varchar(30);
select * from khachang;
delete from khachang where makh=1;
select * from muave;
select * from khachang;

-- chen du lieu CHUNGNHAN
insert into CHUNGNHAN values ('567354612',747);
insert into CHUNGNHAN values ('567354612',737);
insert into CHUNGNHAN values ('567354612',757);
insert into CHUNGNHAN values ('567354612',777);
insert into CHUNGNHAN values ('567354612',767);
insert into CHUNGNHAN values ('567354612',727);
insert into CHUNGNHAN values ('567354612',340);
insert into CHUNGNHAN values ('552455318',737);
insert into CHUNGNHAN values ('552455318',319);
insert into CHUNGNHAN values ('552455318',747);
insert into CHUNGNHAN values ('552455318',767);
insert into CHUNGNHAN values ('390487451',340);
insert into CHUNGNHAN values ('390487451',320);
insert into CHUNGNHAN values ('390487451',319);
insert into CHUNGNHAN values ('274878974',757);
insert into CHUNGNHAN values ('274878974',767);
insert into CHUNGNHAN values ('355548984',154);
insert into CHUNGNHAN values ('310454876',154);
insert into CHUNGNHAN values ('142519864',747);
insert into CHUNGNHAN values ('142519864',757);
insert into CHUNGNHAN values ('142519864',777);
insert into CHUNGNHAN values ('142519864',767);
insert into CHUNGNHAN values ('142519864',737);
insert into CHUNGNHAN values ('142519864',340);
insert into CHUNGNHAN values ('142519864',320);
insert into CHUNGNHAN values ('269734834',747);
insert into CHUNGNHAN values ('269734834',737);
insert into CHUNGNHAN values ('269734834',340);
insert into CHUNGNHAN values ('269734834',757);
insert into CHUNGNHAN values ('269734834',777);
insert into CHUNGNHAN values ('269734834',767);
insert into CHUNGNHAN values ('269734834',320);
insert into CHUNGNHAN values ('269734834',319);
insert into CHUNGNHAN values ('269734834',727);
insert into CHUNGNHAN values ('269734834',154);
insert into CHUNGNHAN values ('242518965',737);
insert into CHUNGNHAN values ('242518965',757);
insert into CHUNGNHAN values ('141582651',737);
insert into CHUNGNHAN values ('141582651',757);
insert into CHUNGNHAN values ('141582651',767);
insert into CHUNGNHAN values ('011564812',737);
insert into CHUNGNHAN values ('011564812',757);
insert into CHUNGNHAN values ('574489457',154);
insert into CHUNGNHAN(MANV,MAMB) VALUE('517354612',154);
Select A.* from chuyenbay A join maybay B
on A.MAMB=B.MAMB AND A.GaDen="DAD";
Select * from maybay where TamBay > "10000km";
select * From nhanvien where Luong < "10000";
select A.* from chuyenbay A join maybay B on
A.MAMB=B.MAMB and B.TamBay between 8000 and 10000;  
select A.* from chuyenbay A where A.GaDi="SGN" and A.GaDen ="BMV"; 
SELECT COUNT(*) FROM chuyenbay A where A.GaDi="SGN";
Select Count(*) from  maybay A where A.Loai like "%Boeing%"; 
select Sum(Luong) from nhanvien;

select C.MaNV from chungnhan A
join maybay B on A.MAMB=B.MAMB
AND B.Loai like "%Boeing%"
join NhanVien C on A.MANV=C.MANV
group by C.MANV;

Select soGhe from muave where MaCB like "%VN477%"
select C.* from chungnhan A  
join NhanVien C on A.MANV=C.MANV AND  A.MAMB="747"
group by C.MANV;
select C.MAMB from NhanVien A  
join chungnhan C on A.Ten like"Nguyen%" and A.MANV=C.MANV
group by C.MAMB;
select C.MaNV from chungnhan A
join maybay B on A.MAMB=B.MAMB
join NhanVien C on A.MANV=C.MANV
where  B.Loai like "Boeing%" or B.Loai like "Airbus%"
group by C.MANV;
select A.Loai from mayBay A
join chuyenbay B on 
A.MAMB=B.MAMB AND B.MACB LIKE 'VN280';
select A.* from chuyenbay A
join maybay B on 
A.MAMB=B.MAMB AND B.Loai LIKE 'Airbus A320';
Select A.Ten from nhanvien A join
chungnhan B on A.MANV=B.MANV 
join maybay C on B.MAMB=C.MAMB AND C.Loai like "%Boeing%"
group by A.Ten;
select A.MAMB, B.Loai,Count(*) as TongSoPhiCong from
 chungnhan A join maybay B on A.MAMB=B.MAMB
 join nhanvien C on A.MANV=C.MANV
 group by A.MAMB;
 
 select A.MAMB,A.GaDi,A.GaDen from chuyenbay A join 
 maybay B where A.MAMB=B.MAMB
 GROUP by  A.MAMB,A.GaDi,A.GaDen;
 -- Ga di bang ga den va nguoc lai ----
 select A.macb,A.GaDi,A.GaDen,A.GioDi,A.GioDen from chuyenbay A 
 join 
 (select Gaden,Gadi from chuyenbay group by Gaden,Gadi 
 having GaDen like '%Pleiku (PXU)%' or GaDi like '%Pleiku (PXU)%') B
 on A.GaDi=B.GaDen and A.GaDen=B.GaDi 
where A.GioDi like '%2023-05-21%' or A.GioDi like "%2023-06-25%";
 select A.GaDen from chuyenbay A 
 join (select Gaden,Gadi from chuyenbay group by Gaden,Gadi) B
 on A.GaDi=B.GaDen and A.GaDkhachangen=B.GaDi
where  A.GaDi='Tp. Hồ Chí Minh (SGN)' or A.GaDi like'%Đà Nẵng (DAD)%';
 select Round(ChiPhi-0.1*ChiPhi +100000) as giave from chuyenbay;
-- 18. Với mỗi ga có chuyến bay xuất phát từ ga đó cho biết có bao nhiêu chuyến bay	 khởi hành
 Select distinct(Count(*))as SoChuyenBay,A.GaDi from chuyenbay A
 group by A.GaDi
-- 19. Với mỗi ga có chuyến bay xuất phát từ ga đó cho biết tổng chi phí phải trả cho phi công lái
-- các chuyến bay khởi hành. 
 Select A.GaDi,sum(A.ChiPhi)as TongChiPhi from chuyenbay A
 group by A.GaDi;
 -- 20. Với mỗi địa điểm xuất phát cho biết có bao nhiêu chuyến bay có thể khởi hành trước 12:00.
 select GaDi,count(*) as SoChuyenBay from chuyenbay 
 where hour(GioDi) < 12
 group by GaDi;
-- 21. Cho biết mã số của các phi công chỉ lái được 3 loại máy bay.
select MaNV from chungnhan 
group by MaNV having Count(MAMB)=3;
-- 22. Với mỗi phi công có thể lái nhiều hơn 3 loại máy bay, cho biết mã số phi công và tầm bay
-- lớn nhất của các loại máy bay mà phi công đó có thể lái
select A.MaNV,max(TamBayMax),Count(A.MaMB) from chungnhan A
join (select C.TamBay as TamBayMax,MaMB from maybay C group by MaMB)B on 
A.MaMB=B.MaMB
group by A.MANV having Count(A.MaMB)>3;
-- 23. Với mỗi phi công cho biết mã số phi công và tổng số loại máy bay mà phi công đó có thể
-- lái
select A.MANV, COUNT(distinct(A.MaMB)) from chungnhan A 
GROUP BY A.MANV;
-- 24. Cho biết mã số của các phi công có thể lái được nhiều loại máy bay nhất
select MaNV  from chungnhan 
GROUP BY MANV having count(MAMB) =
(select MAX(soluong) as tongMAX
from
(select MANV,count(MAMB) as soluong from chungnhan
group by MANV));
-- Cho biết mã số của các phi công có thể lái được ít loại máy bay nhất.
select MaNV  from chungnhan 
GROUP BY MANV having count(MAMB) =
(select min(soluong) 
from
(select MANV,count(MAMB) as soluong from chungnhan
group by MANV) 
as T);
select * from nhanvien where MaNV not in(
select MANV FROM chungnhan
) 
-- Cho biết mã số của các nhân viên có lương cao nhất.
select MaNV from nhanvien where
Luong = (select max(Luong) from nhanvien) 
select Sum(Luong) from nhanvien where
MANV in (select MANV FROM chungnhan group by MANV)
-- Tìm các chuyến bay có thể được thực hiện bởi tất cả các loại máy bay Boeing.
select * from chuyenbay where 
MAMB in( select MAMB from maybay where loai like "%Boeing%");
-- Cho biết mã số của các máy bay có thể được sử dụng để thực hiện chuyến bay từ Sài Gòn
-- (SGN) đến Huế (HUI).
select MAMB from maybay where 
MaMB in (select MaMB from chuyenbay where GaDi="SGN" and GaDen="HUI")
-- Tìm các chuyến bay có thể được lái bởi các phi công có lương lớn hơn 100,000.
select * FROM chuyenbay A where
A.MANV in (SELECT B.MANV From nhanvien B 
where luong > 100000 and MANV in(select C.MANV FROM chungnhan C)) 
-- Cho biết tên các phi công có lương nhỏ hơn chi phí thấp nhất của đường bay từ Sài Gòn
-- (SGN) đến Buôn Mê Thuộc (BMV)
select Ten from nhanvien where luong <( select Min(ChiPhi) from chuyenbay where GaDi="SGN" and
GaDen="BMV") and MANV in(select MANV from chungnhan)
-- Cho biết mã số của các phi công có lương cao nhất
select MANV from nhanvien where luong=(select max(Luong) from nhanvien) 
and MANV in(select MANV from chungnhan)
-- Cho biết mã số của các nhân viên có lương cao thứ nhì;
 SELECT manv,Ten from nhanvien order by luong desc limit 2 offset 1;
-- Cho biết mã số của các nhân viên có lương cao thứ nhất hoặc thứ nhì.
select * from nhanvien where luong =(select max(luong) from nhanvien)
or luong=(select luong from nhanvien order by luong desc limit 1 offset 1)
-- Cho biết tên và lương của các nhân viên không phải là phi công và có lương lớn hơn lương
-- trung bình của tất cả các phi công
select * from nhanvien where MANV not in ( select MANV from chungnhan )
and luong > ( select avg(luong) from nhanvien where MANV in(select MANV FROM chungnhan)); 
-- Cho biết tên các phi công có thể lái các máy bay có tầm bay lớn hơn 4,800km nhưng không
-- có chứng nhận lái máy bay Boeing.
select * from nhanvien where MANV in( select MANVfrom chungnhan where MAMB in (SELECT MAMB
FROM MAYBAY WHERE LOAI not like "%Boeing%" and TamBay > 4800)
group by MANV
)
--  Cho biết tên các phi công lái ít nhất 3 loại máy bay có tầm bay xa hơn 3200km.
select * from nhanvien where MANV in
(
select MANV  from chungnhan
where MAMB in( select MAMB from maybay where tambay>3200)
group by MANV having  Count(MAMB)>=3 );
UPDATE CHUYENBAY 
SET 
    GaDi = 'Tp. Hồ Chí Minh (SGN)'
WHERE
    MaCB = 'VN216';
UPDATE CHUYENBAY a 
join (select MaCB from chuyenbay where GaDi='SGN')b
SET 
    GaDi = 'Tp. Hồ Chí Minh (SGN)'
where a.MaCB=b.MaCB ;
UPDATE CHUYENBAY 
SET 
    GaDi = 'Tp. Hồ Chí Minh (SGN)'
WHERE
    MaCB = 'VN216';
UPDATE CHUYENBAY a 
join (select MaCB from chuyenbay where GaDi='DAD')b
SET 
    GaDi = 'Đà Nẵng (DAD)'
where a.MaCB=b.MaCB;
UPDATE CHUYENBAY a 
join (select MaCB from chuyenbay where GaDi='HAN')b
SET 
    GaDi = 'Hà Nội (HAN)'
where a.MaCB=b.MaCB ;
UPDATE CHUYENBAY a 
join (select MaCB from chuyenbay where GaDi='VII')b
SET 
    GaDi = 'Vinh(VII)'
where a.MaCB=b.MaCB ;
UPDATE CHUYENBAY a 
join (select MaCB from chuyenbay where GaDi='PXU')b
SET 
    GaDi = 'Pleiku (PXU)'
where a.MaCB=b.MaCB ;
UPDATE CHUYENBAY a 
join (select MaCB from chuyenbay where GaDi='UIH')b
SET 
GaDi='Quy Nhơn (UIH)'
where a.MaCB=b.MaCB ;

select*from chuyenbay;