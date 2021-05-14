create database PTTK
go

use PTTK
go

-- Table: ChungChiQuocTe
create table ChungChiQuocTe (
   MaChungChi		int		identity(1,1)		not null,
   TenChungChi		varchar(30)		null,               
   constraint PK_CHUNGCHIQUOCTE primary key (MaChungChi)
)
go

-- Table: DotThi
create table DotThi (
	MaSoDotThi		int		identity(1,1)	not null,
	DiaDiem			varchar(30)				null,
	NgayBatDau		date					null,
	NgayKetThuc		date					null,
	constraint PK_DOTTHI primary key (MaSoDotThi)
)
go

-- Table: LichThi
create table LichThi (
	MaSoDotThi		int				not null,
	MaChungChi		int				not null,
	NgayThi			date			null,
	constraint PK_LICHTHI primary key (MaSoDotThi, MaChungChi)
)
go

-- Table: PhieuDuThi
create table PhieuDuThi (
	SoPhieu			int		identity(1,1)	not null,
	MaThiSinh		int						null,
	PhongThi		int						null,
	MaSoDotThi		int						null,
	MaChungChi		int						null,
	NgayCap			date					null,
	MaHoaDon		int						null,
	constraint PK_PHIEUDUTHI primary key (SoPhieu)
)
go

-- Table: NguoiThamDuThi
create table NguoiThamDuThi (
	MaThiSinh		int		identity(1,1)	not null,
	HoTen			varchar(50)				null,
	CMND			varchar(10)				null,
	DiaChi			varchar(50)				null,
	NgaySinh		date					null,
	Phai			varchar(3)				null,
	SDT				varchar(10)				null,
	constraint PK_NGUOITHAMDUTHI primary key (MaThiSinh)
)
go

-- Table:	ChiTietLichThi
create table ChiTietLichThi (
	MaSoDotThi		int				not null,
	MaChungChi		int				not null,
	MaThiSinh		int				not null,
	constraint PK_CHITIETLICHTHI primary key (MaSoDotThi, MaChungChi, MaThiSinh)
)
go

-- Table: HoaDonDKChungChiQuocTe
create table HoaDonDKChungChiQuocTe (
	MaHoaDon		int		identity(1,1)	not null,
	NgayLap			date					null,
	GiamGia			int						null,
	TongTien		int						null,
	MaThiSinh		int						null,
	constraint PK_HOADONDKCHUNGCHIQUOCTE primary key (MaHoaDon)
)
go

-- Table: HocVien
create table HocVien (
	MaHocVien		int		identity(1,1)	not null,
	HoTen			varchar(50)				null,
	CMND			varchar(10)				null,
	DiaChi			varchar(50)				null,
	NgaySinh		date					null,
	Phai			varchar(3)				null,
	SDT				varchar(10)				null,
	constraint PK_HOCVIEN primary key (MaHocVien)
)
go

-- Table: ChungChiHocPhanTrungTam 
create table ChungChiHocPhanTrungTam  (
	MaChungChi		int				not null,
	TenChungChi		varchar(30)		null,	
	constraint PK_CHUNGCHIHOCPHANTRUNGTAM primary key (MaChungChi)
)
go

-- Table: ChungChiTrungTam_HocVien 
create table ChungChiTrungTam_HocVien  (
	MaChungChi		int				not null,
	MaHocVien		int				not null,
	constraint PK_CHUNGCHITRUNGTAM_HOCVIEN primary key (MaChungChi, MaHocVien)
)
go

-- Table: ChungChiHocPhanNgoaiTrungTam
create table ChungChiHocPhanNgoaiTrungTam (
	MaChungChi		int				not null,
	TenChungChi		varchar(30)		null,
	NoiCap			varchar(50)		null,
	constraint PK_CHUNGCHIHOCPHANNGOAITRUNGTAM primary key (MaChungChi)
)
go

-- Table: ChungChiTrungTam_HocVien 
create table ChungChiNgoaiTrungTam_HocVien  (
	MaChungChi		int				not null,
	MaHocVien		int				not null,
	constraint PK_CHUNGCHINGOAITRUNGTAM_HOCVIEN primary key (MaChungChi, MaHocVien)
)
go

-- Table:	HoaDonHocPhan 
create table HoaDonHocPhan  (
	MaHoaDon		int		identity(1,1)	not null,
	NgayLap			date					null,
	TongTien		int						null,
	MaHocVien		int						null,
	constraint PK_HOADONHOCPHAN primary key (MaHoaDon)
)
go

-- Table:	Nam_Khoa
create table Nam_Khoa  (
	Nam				int				not null,
	Khoa			int				not null,
	constraint PK_NAM_KHOA primary key (Nam, Khoa)
)
go

-- Table:	HocPhan
create table HocPhan  (
	MaHocPhan		int		identity(1,1)	not null,
	LoaiHocPhan		varchar(30)				null,
	TenHocPhan		varchar(30)				null,
	constraint PK_HOCPHAN primary key (MaHocPhan)
)
go

-- Table:	GiaoVien
create table GiaoVien  (
	MaGiaoVien		int		identity(1,1)	not null,
	HoTenGV			varchar(50)				null,
	DiaChiGV		varchar(50)				null,
	NgaySinhGV		date					null,
	Phai			varchar(3)				null,
	SDT				varchar(10)				null,
	constraint PK_GIAOVIEN primary key (MaGiaoVien)
)
go

-- Table:	HocPhanMo
create table HocPhanMo  (
	MaHocPhan		int				not null,
	Nam				int				not null,
	Khoa			int				not null,
	PhongHoc		varchar(30)		null,
	SoLuongSV		int				null,
	MaGV			int				null,
	constraint PK_HOCPHANMO primary key (MaHocPhan, Nam, Khoa)
)
go

-- Table: KetQuaDangKyHocPhan
create table KetQuaDangKyHocPhan  (
	MaHocPhan		int				not null,
	Nam				int				not null,
	Khoa			int				not null,
	MaHocVien		int				not null,
	Diem			int				null,
	MaChungChi		int				null, 
	NgayCap			date			null
	constraint PK_KETQUADANGKYHOCPHAN primary key (MaHocPhan, Nam, Khoa, MaHocVien)
)
go

-- Table: KetQuaThiLai
create table KetQuaThiLai (
	MaHocPhan		int				not null,
	Nam				int				not null,
	Khoa			int				not null,
	MaHocVien		int				not null,
	Diem			int				null,
	NgayThiLai		date			null,
	SoLanDaThiLai	int				null,
	constraint PK_KETQUATHILAI primary key (MaHocPhan, Nam, Khoa, MaHocVien)
)
go

-- Constraint
alter table NguoiThamDuThi
add constraint C_Phai check(Phai in ('Nam','Nu'))
go

alter table HocVien
add constraint C_Phai_HocVien check(Phai in ('Nam','Nu'))
go

alter table GiaoVien
add constraint C_Phai_GiaoVien check(Phai in ('Nam','Nu'))
go

--1
alter table LichThi add constraint FK_LICHTHI_DOTTHI
					foreign key (MaSoDotThi)
					references DotThi(MaSoDotThi)
go

--2
alter table LichThi add constraint FK_LICHTHI_CCQT
					foreign key (MaChungChi)
					references ChungChiQuocTe(MaChungChi)
go


--3
alter table ChiTietLichThi add constraint FK_CTLICHTHI_LICHTHI
					foreign key (MaSoDotThi, MaChungChi)
					references LichThi(MaSoDotThi, MaChungChi)
go 

--4
alter table ChiTietLichThi add constraint FK_CTLICHTHI_NGUOITHAMDUTHI
					foreign key (MaThiSinh)
					references NguoiThamDuThi (MaThiSinh)
go

--5
alter table HoaDonDKChungChiQuocTe add constraint FK_HOADONDKCCQT_NGUOITHAMGIADUTHI
					foreign key (MaThiSinh)
					references NguoiThamDuThi (MaThiSinh)
go 

--6
alter table PhieuDuThi add constraint FK_PHIEUDUTHI_NGUOITHAMGIADUTHI
					foreign key (MaThiSinh)
					references NguoiThamDuThi (MaThiSinh)
go 

--7
alter table PhieuDuThi add constraint FK_PHIEUDUTHI_LICHTHI
					foreign key (MaSoDotThi, MaChungChi)
					references LichThi (MaSoDotThi, MaChungChi)
go 


--8
alter table PhieuDuThi add constraint FK_PHIEUDUTHI_HoaDonDKCCQT
					foreign key (MaHoaDon)
					references HoaDonDKChungChiQuocTe(MaHoaDon)
go 

--9
alter table ChungChiTrungTam_HocVien add constraint FK_CCTRUNGTAM_HOCVIEN_CCHOCPHANTRUNGTAM
					foreign key (MaChungChi)
					references ChungChiHocPhanTrungTam(MaChungChi)
go 

--10
alter table ChungChiTrungTam_HocVien add constraint FK_CCTRUNGTAM_HOCVIEN_HOCVIEN
					foreign key (MaHocVien)
					references HocVien(MaHocVien)
go

--11
alter table ChungChiNgoaiTrungTam_HocVien add constraint FK_CCNGOAITRUNGTAM_HOCVIEN_CCHOCPHANNGOAITRUNGTAM
					foreign key (MaChungChi)
					references ChungChiHocPhanNgoaiTrungTam(MaChungChi)
go 

--12
alter table ChungChiNgoaiTrungTam_HocVien add constraint FK_CCNGOAITRUNGTAM_HOCVIEN_HOCVIEN
					foreign key (MaHocVien)
					references HocVien(MaHocVien)
go

--13
alter table	HoaDonHocPhan add constraint FK_HOADONHOCPHAN_HOCVIEN
					foreign key (MaHocVien)
					references HocVien(MaHocVien)
go

--14
alter table	HocPhanMo add constraint FK_HOCPHANMO_HOCPHAN
					foreign key (MaHocPhan)
					references HocPhan(MaHocPhan)
go

--15
alter table	HocPhanMo add constraint FK_HOCPHANMO_NAM_KHOA
					foreign key (Nam, Khoa)
					references Nam_Khoa(Nam, Khoa)
go

--16
alter table	HocPhanMo add constraint FK_HOCPHANMO_GIAOVIEN
					foreign key (MaGV)
					references GiaoVien(MaGiaoVien)
go

--17
alter table	KetQuaDangKyHocPhan add constraint FK_KQDKHOCPHAN_HOCPHANMO
					foreign key (MaHocPhan, Nam, Khoa) 
					references HocPhanMo(MaHocPhan, Nam, Khoa)
go

--18
alter table	KetQuaDangKyHocPhan add constraint FK_KQDKHOCPHAN_HOCVIEN
					foreign key (MaHocVien) 
					references HocVien(MaHocVien)
go

--19
alter table	KetQuaThiLai add constraint FK_KQTHILAI_HOCPHANMO
					foreign key (MaHocPhan, Nam, Khoa) 
					references HocPhanMo(MaHocPhan, Nam, Khoa)
go

--20
alter table	KetQuaThiLai add constraint FK_KQTHILAI_HOCVIEN
					foreign key (MaHocVien) 
					references HocVien(MaHocVien)
go

SET DATEFORMAT dmy;
--INSERT DATA
-- table: ChungChiQuocTe
insert into ChungChiQuocTe values ('Chung chi tin hoc MOS');
insert into ChungChiQuocTe values ( 'Chung chi tin hoc IC3');
insert into ChungChiQuocTe values ('Chung chi tin hoc CEL');
insert into ChungChiQuocTe values ('Chung chi tin hoc KE4');

--table: DotThi
insert into DotThi values ('Trung tam tin hoc ABC', '01/03/2020',  '20/03/2020');
insert into DotThi values ('Trung tam tin hoc UIO', '01/06/2020',  '20/06/2020');
insert into DotThi values ('Trung tam tin hoc KEK', '01/09/2020',  '20/09/2020');
insert into DotThi values ('Trung tam tin hoc TGB', '01/12/2020',  '20/12/2020');



--table: LichThi
insert into LichThi values (1, 1, '01/03/2020');
insert into LichThi values (1, 2, '08/03/2020');
insert into LichThi values (1, 3, '15/03/2020');
insert into LichThi values (1, 4, '25/09/2020');
insert into LichThi values (2, 1, '22/06/2020');
insert into LichThi values (2, 2, '14/03/2020');
insert into LichThi values (2, 3, '11/06/2020');
insert into LichThi values (2, 4, '16/06/2020');
insert into LichThi values (3, 1, '02/09/2020');
insert into LichThi values (3, 2, '07/09/2020');
insert into LichThi values (3, 3, '12/09/2020');
insert into LichThi values (3, 4, '19/09/2020');
insert into LichThi values (4, 1, '15/06/2020');
insert into LichThi values (4, 2, '09/09/2020');
insert into LichThi values (4, 3, '02/02/2020');
insert into LichThi values (4, 4, '05/12/2020');

--table: NguoiThamDuThi
insert into NguoiThamDuThi values ('Tran Quoc Bao', '2912322180', '14 Truong Quyen, P.6, Q.3, TPHCM', '22/06/1999', 'Nam', '0976452178');
insert into NguoiThamDuThi values ('Le Thi Nhu Quynh', '2567322180', '54A Xo Viet Nghe Tinh, Q.Binh Thanh, TPHCM', '05/09/1995', 'Nu', '0971947178');
insert into NguoiThamDuThi values ('Nguyen Trung Nhat', '2876322180', '343/79A Nguyen Trong Tuyen, Q.Tan Binh, TPHCM', '13/08/1997', 'Nam', '0923672178');
insert into NguoiThamDuThi values ('Dao Nhat Huy', '2912366180', '14/5 Pho Quang, Tan Binh, TPHCM', '17/02/1998', 'Nam', '0976102978');
insert into NguoiThamDuThi values ('Le Chi Thanh', '2912322690', '140/5B Lac Long Quan, Tan Binh, TPHCM', '20/01/1996', 'Nam', '0919552178');
insert into NguoiThamDuThi values ('Duong Thuy Van', '2419322180', '253 Tan Huong, Tan Phu, TPHCM', '14/03/1999', 'Nu', '0976889178');
insert into NguoiThamDuThi values ('Tran Ngoc Bao Tran', '2911292180', '1459 3 THANG 2, Q.11, TPHCM', '25/09/1998', 'Nu', '0828452178');
insert into NguoiThamDuThi values ('Le Van Linh', '2915622180', '23 Nguyen Thai Son, Go vap, TPHCM', '02/02/1999', 'Nam', '0786452178');

insert into NguoiThamDuThi values ('Tran Ngoc Bao', '2208771648', '27 Nguyen Van Cu, P.6, Q.3, TPHCM', '22/02/1989', 'Nam', '0484278568');
insert into NguoiThamDuThi values ('Do Thi Ly', '2768195708', '16 Luong Dinh Cua, Q.Binh Thanh, TPHCM', '07/08/1996', 'Nu', '0255058495');
insert into NguoiThamDuThi values ('Nguyen Tran Hieu', '2640582919', '100/25A Tran Hung Dao, Q.Tan Binh, TPHCM', '16/01/1987', 'Nam', '0514255888');
insert into NguoiThamDuThi values ('Dao Huy Quang', '2709544193', '29/15 Mac Dinh Chi, Tan Binh, TPHCM', '17/06/1999', 'Nam', '0679780606');
insert into NguoiThamDuThi values ('Le Quang Ngoc', '2407815267', '12 Vo Van Kiet, Tan Binh, TPHCM', '20/11/1995', 'Nam', '0290794874');
insert into NguoiThamDuThi values ('Tran Minh Duc', '2541606645', '22/6 Vo Van Tan, Tan Phu, TPHCM', '14/12/1992', 'Nu', '0231166868');
insert into NguoiThamDuThi values ('Le Thi Lan', '2651704288', '159 Ban Co, Q.11, TPHCM', '24/02/2000', 'Nu', '0761644835');
insert into NguoiThamDuThi values ('Tran Duc Tuan', '2828752747', '290 Nguyen Thai Hoc, Go vap, TPHCM', '04/01/1997', 'Nam', '0767339318');

insert into NguoiThamDuThi values ('Nguyen Minh Long', '2263820402', '90 De Tham, P.6, Q.3, TPHCM', '21/06/1995', 'Nam', '0463030418');
insert into NguoiThamDuThi values ('Tran Bao Loc', '2761692964', '60 Hai Thuong Lan Ong, Q.Binh Thanh, TPHCM', '15/06/1994', 'Nam', '0549058399');
insert into NguoiThamDuThi values ('Nguyen Thi Ba', '2704752060', '99 Co Giang, Q.Tan Binh, TPHCM', '20/01/1993', 'Nu', '0245817473');
insert into NguoiThamDuThi values ('Le Minh Tam', '2545342165', '20/2 Nguyen Hue, Tan Binh, TPHCM', '19/09/1995', 'Nam', '0178030053');
insert into NguoiThamDuThi values ('Tran Minh Anh', '2993882696', '199/57 Hoa Sua, Tan Binh, TPHCM', '07/08/1997', 'Nu', '0322223363');
insert into NguoiThamDuThi values ('Nguyen Le Van Anh', '2244721629', '25 CMT8, Tan Phu, TPHCM', '21/09/1998', 'Nu', '0502409567');
insert into NguoiThamDuThi values ('Nguyen Ngoc Long', '2814006190', '559 Nguyen Khac Nhu, Q.11, TPHCM', '15/10/1994', 'Nam', '0912704671');
insert into NguoiThamDuThi values ('Le Trung Luong', '2270272062', '67 Tran Xuan Soan, Go vap, TPHCM', '12/10/1992', 'Nam', '0851090754');



--table: ChiTietLichThi
insert into ChiTietLichThi values (1, 1, 1);
insert into ChiTietLichThi values (1, 1, 2);
insert into ChiTietLichThi values (2, 2, 2);
insert into ChiTietLichThi values (3, 1, 3);
insert into ChiTietLichThi values (3, 3, 4);
insert into ChiTietLichThi values (1, 2, 5);
insert into ChiTietLichThi values (2, 3, 5);
insert into ChiTietLichThi values (2, 4, 5);
insert into ChiTietLichThi values (4, 4, 6);
insert into ChiTietLichThi values (1, 1, 7);
insert into ChiTietLichThi values (2, 2, 7);
insert into ChiTietLichThi values (1, 3, 8);
insert into ChiTietLichThi values (1, 4, 9);
insert into ChiTietLichThi values (2, 1, 10);
insert into ChiTietLichThi values (3, 1, 11);
insert into ChiTietLichThi values (2, 2, 12);
insert into ChiTietLichThi values (1, 3, 13);
insert into ChiTietLichThi values (4, 1, 14);
insert into ChiTietLichThi values (1, 4, 14);
insert into ChiTietLichThi values (2, 3, 15);
insert into ChiTietLichThi values (2, 3, 16);
insert into ChiTietLichThi values (3, 1, 17);
insert into ChiTietLichThi values (1, 2, 17);
insert into ChiTietLichThi values (2, 3, 18);
insert into ChiTietLichThi values (2, 4, 19);
insert into ChiTietLichThi values (4, 1, 20);
insert into ChiTietLichThi values (1, 2, 21);
insert into ChiTietLichThi values (3, 1, 22);
insert into ChiTietLichThi values (3, 3, 23);
insert into ChiTietLichThi values (1, 3, 24);
insert into ChiTietLichThi values (2, 4, 24);


--table: HoaDonDKChungChiQuocTe
insert into HoaDonDKChungChiQuocTe values ('02/01/2020', 0, 2000000, 1);
insert into HoaDonDKChungChiQuocTe values ('03/02/2020', 0, 4000000, 2);
insert into HoaDonDKChungChiQuocTe values ('04/01/2020', 0, 2000000, 3);
insert into HoaDonDKChungChiQuocTe values ('05/01/2020', 0, 2000000, 4);
insert into HoaDonDKChungChiQuocTe values ('06/01/2020', 0, 6000000, 5);
insert into HoaDonDKChungChiQuocTe values ('07/01/2020', 0, 2000000, 6);
insert into HoaDonDKChungChiQuocTe values ('08/01/2020', 0, 4000000, 7);
insert into HoaDonDKChungChiQuocTe values ('09/01/2020', 0, 2000000, 8);
insert into HoaDonDKChungChiQuocTe values ('10/01/2020', 0, 2000000, 9);
insert into HoaDonDKChungChiQuocTe values ('12/01/2020', 0, 2000000, 10);
insert into HoaDonDKChungChiQuocTe values ('13/01/2020', 0, 2000000, 11);
insert into HoaDonDKChungChiQuocTe values ('14/01/2020', 0, 2000000, 12);
insert into HoaDonDKChungChiQuocTe values ('15/01/2020', 0, 2000000, 13);
insert into HoaDonDKChungChiQuocTe values ('16/01/2020', 0, 4000000, 14);
insert into HoaDonDKChungChiQuocTe values ('17/01/2020', 0, 2000000, 15);
insert into HoaDonDKChungChiQuocTe values ('18/01/2020', 0, 2000000, 16);
insert into HoaDonDKChungChiQuocTe values ('19/01/2020', 0, 4000000, 17);
insert into HoaDonDKChungChiQuocTe values ('20/01/2020', 0, 2000000, 18);
insert into HoaDonDKChungChiQuocTe values ('21/01/2020', 0, 2000000, 19);
insert into HoaDonDKChungChiQuocTe values ('22/01/2020', 0, 2000000, 20);
insert into HoaDonDKChungChiQuocTe values ('23/01/2020', 0, 2000000, 21);
insert into HoaDonDKChungChiQuocTe values ('25/01/2020', 0, 2000000, 22);
insert into HoaDonDKChungChiQuocTe values ('26/01/2020', 0, 2000000, 23);
insert into HoaDonDKChungChiQuocTe values ('29/01/2020', 0, 4000000, 24);




--table: PhieuDuThi
insert into PhieuDuThi values (1, 01,  1, 1, '12/01/2020', 1);
insert into PhieuDuThi values (2, 02,  2, 2, '17/01/2020', 2);
insert into PhieuDuThi values (2, 04,  4, 4, '15/01/2020', 2);
insert into PhieuDuThi values (3, 03,  3, 4, '13/01/2020', 3);
insert into PhieuDuThi values (4, 01,  1, 1, '18/01/2020', 4);
insert into PhieuDuThi values (5, 08,  2, 3, '19/01/2020', 5);
insert into PhieuDuThi values (5, 09,  3, 1, '14/01/2020', 5);
insert into PhieuDuThi values (5, 02,  3, 4, '02/01/2020', 5);
insert into PhieuDuThi values (6, 01,  1, 4, '03/01/2020', 6);
insert into PhieuDuThi values (7, 04,  1, 2, '06/01/2020', 7);
insert into PhieuDuThi values (7, 05,  2, 3, '08/01/2020', 7);
insert into PhieuDuThi values (8, 02,  4, 1, '09/01/2020', 8);
insert into PhieuDuThi values (9, 01,  2, 1, '14/01/2020', 9);
insert into PhieuDuThi values (10, 03,  3, 2, '16/01/2020', 10);
insert into PhieuDuThi values (11, 04,  3, 2, '18/01/2020', 11);
insert into PhieuDuThi values (12, 07,  1, 3, '19/01/2020', 12);
insert into PhieuDuThi values (13, 01,  4, 3, '18/01/2020', 13);
insert into PhieuDuThi values (14, 06,  2, 4, '17/01/2020', 14);
insert into PhieuDuThi values (14, 09,  1, 4, '16/01/2020', 14);
insert into PhieuDuThi values (15, 01,  3, 1, '14/01/2020', 15);
insert into PhieuDuThi values (16, 02,  3, 1, '12/01/2020', 16);
insert into PhieuDuThi values (17, 03,  4, 3, '11/01/2020', 17);
insert into PhieuDuThi values (17, 07,  1, 3, '09/01/2020', 17);
insert into PhieuDuThi values (18, 04,  2, 4, '07/01/2020', 18);
insert into PhieuDuThi values (19, 06,  2, 1, '08/01/2020', 19);
insert into PhieuDuThi values (20, 04,  4, 1, '06/01/2020', 20);
insert into PhieuDuThi values (21, 02,  2, 1, '05/01/2020', 21);
insert into PhieuDuThi values (22, 05,  3, 3, '02/01/2020', 22);
insert into PhieuDuThi values (23, 06,  1, 2, '03/01/2020', 23);
insert into PhieuDuThi values (24, 07,  3, 2, '16/01/2020', 24);
insert into PhieuDuThi values (24, 01,  2, 4, '17/01/2020', 24);


--table: HocVien
insert into HocVien values ('Nguyen Van Dat', '2956788124', '5 Pham Ngu Lao, Go Vap, TPHCM', '22/12/2000', 'Nam', '0983526718');
insert into HocVien values ('Nguyen Tat Chung', '2956128122', '223 Ly Thuong Kiet, Di An, Binh Duong', '21/09/1999', 'Nam', '0983172898');
insert into HocVien values ('Dao Xuan Nhu', '2589048127', '81 Dinh Tien Hoang, Binh Thanh, TPHCM', '13/08/2001', 'Nu', '0988192818');
insert into HocVien values ('Trinh Thanh Van', '2918298128', '297 Ngo Gia Tu, Q.10, TPHCM', '01/03/1998', 'Nu', '0981827718');

insert into HocVien values ('Nguyen Van Ngoc', '2015208102', '25 Ly Chinh Thang, Go Vap, TPHCM', '22/12/2000', 'Nam', '0614252918');
insert into HocVien values ('Ly Thanh Chung', '2886706460', '28/12 Nguyen Thuong Hien, Di An, Binh Duong', '21/09/1999', 'Nam', '0417142745');
insert into HocVien values ('Tran Xuan Quynh', '2106857202', '123 Tran Hung Dao, Binh Thanh, TPHCM', '13/08/2001', 'Nu', '0379237805');
insert into HocVien values ('Nguyen Thanh Tan', '2358970004', '250 Truong Sa, Q.10, TPHCM', '01/03/1998', 'Nam', '0371942384');

--table: ChungChiHocPhanTrungTam
insert into ChungChiHocPhanTrungTam values (1, 'Chung chi AE9');
insert into ChungChiHocPhanTrungTam values (2, 'Chung chi BK2');
insert into ChungChiHocPhanTrungTam values (3, 'Chung chi CKL');

--table: ChungChiTrungTam_HocVien 
insert into ChungChiTrungTam_HocVien values (1, 1);
insert into ChungChiTrungTam_HocVien values (2, 2);
insert into ChungChiTrungTam_HocVien values (1, 3);
insert into ChungChiTrungTam_HocVien values (2, 4);
insert into ChungChiTrungTam_HocVien values (3, 5);
insert into ChungChiTrungTam_HocVien values (1, 6);
insert into ChungChiTrungTam_HocVien values (3, 7);


--table: ChungChiHocPhanNgoaiTrungTam
insert into ChungChiHocPhanNgoaiTrungTam values (1, 'Chung Chi AE9', 'Trung tam tin hoc ABC');
insert into ChungChiHocPhanNgoaiTrungTam values (2, 'Chung Chi BK2', 'Trung tam tin hoc ABC');
insert into ChungChiHocPhanNgoaiTrungTam values (3, 'Chung Chi AE9', 'Trung tam tin hoc KEK');
insert into ChungChiHocPhanNgoaiTrungTam values (4, 'Chung Chi CKL', 'Trung tam tin hoc UIO');

--table: ChungChiNgoaiTrungTam_HocVien 
insert into ChungChiNgoaiTrungTam_HocVien values (1, 2);
insert into ChungChiNgoaiTrungTam_HocVien values (2, 3);
insert into ChungChiNgoaiTrungTam_HocVien values (3, 4);
insert into ChungChiNgoaiTrungTam_HocVien values (4, 2);

--table: HoaDonHocPhan 
insert into HoaDonHocPhan (NgayLap, TongTien, MaHocVien) values ('20/02/2020', 3100000, 1);
insert into HoaDonHocPhan (NgayLap, TongTien, MaHocVien) values ('21/02/2020', 2100000, 2);
insert into HoaDonHocPhan (NgayLap, TongTien, MaHocVien) values ('22/02/2020', 2100000, 3);
insert into HoaDonHocPhan (NgayLap, TongTien, MaHocVien) values ('22/02/2020', 2300000, 4);
insert into HoaDonHocPhan (NgayLap, TongTien, MaHocVien) values ('23/02/2020', 3500000, 5);
insert into HoaDonHocPhan (NgayLap, TongTien, MaHocVien) values ('24/02/2020', 2100000, 6);
insert into HoaDonHocPhan (NgayLap, TongTien, MaHocVien) values ('27/02/2020', 3100000, 7);

--table: Nam_Khoa 
insert into Nam_Khoa values (2020, 01);
insert into Nam_Khoa values (2020, 02);
insert into Nam_Khoa values (2020, 03);
insert into Nam_Khoa values (2020, 04);
insert into Nam_Khoa values (2021, 01);
insert into Nam_Khoa values (2021, 02);
insert into Nam_Khoa values (2021, 03);
insert into Nam_Khoa values (2021, 04);

--table: HocPhan
insert into HocPhan values ('Co ban', 'Chung chi AE9');
insert into HocPhan values ('Nang cao', 'Chung chi AE8');
insert into HocPhan values ('Co ban', 'Chung chi BK2');
insert into HocPhan values ('Nang cao', 'Chung chi BK3');
insert into HocPhan values ('Co ban', 'Chung chi CKL');
insert into HocPhan values ('Nang cao', 'Chung chi CKL1');


--table: GiaoVien
insert into GiaoVien (HoTenGV, DiaChiGV, NgaySinhGV, Phai, SDT) values ('Nguyen Thu Ha', '134 Dang Van Bi, Thu Duc, TPHCM', '12/03/1992', 'Nu', '0467389233');
insert into GiaoVien (HoTenGV, DiaChiGV, NgaySinhGV, Phai, SDT) values ('Le Van Long', '289 Vo Van Ngan, Thu Duc, TPHCM', '16/02/1990', 'Nam', '0156789233');
insert into GiaoVien (HoTenGV, DiaChiGV, NgaySinhGV, Phai, SDT) values ('Tran Manh Long', '311 Le Van Viet, Thu Duc, TPHCM', '22/04/1994', 'Nam', '0987389233');
insert into GiaoVien (HoTenGV, DiaChiGV, NgaySinhGV, Phai, SDT) values ('Hoang Hong Hanh', '12 Vo Van Tan, Q4, TPHCM', '01/01/1996', 'Nu', '0973629233');
insert into GiaoVien (HoTenGV, DiaChiGV, NgaySinhGV, Phai, SDT) values ('Le Van Tri', '156 Cong Hoa, Q5, TPHCM', '05/09/1991', 'Nam', '0153239233');

--table: HocPhanMo
insert into HocPhanMo values (1, 2020, 01, 'PhongTH1', 20, 1);
insert into HocPhanMo values (2, 2020, 02, 'PhongTH2', 24, 4);
insert into HocPhanMo values (3, 2020, 02, 'PhongTH3', 21, 1);
insert into HocPhanMo values (4, 2020, 03, 'PhongLT3', 24, 2);
insert into HocPhanMo values (5, 2021, 01, 'PhongLT1', 15, 5);
insert into HocPhanMo values (6, 2021, 02, 'PhongLT5', 18, 3);


--table: KetQuaDangKyHocPhan
insert into KetQuaDangKyHocPhan values (1, 2020, 01, 1, 7, 1, '01/12/2020');
insert into KetQuaDangKyHocPhan values (2, 2020, 02, 2, 8, 2, '02/12/2020');
insert into KetQuaDangKyHocPhan values (3, 2020, 02, 3, 6, 2, '03/12/2020');
insert into KetQuaDangKyHocPhan values (4, 2020, 03, 4, 5, 3, '04/12/2020');
insert into KetQuaDangKyHocPhan values (6, 2021, 02, 5, 8, 2, '06/12/2020');



--table: KetQuaThiLai 
insert into KetQuaThiLai values (5, 2021, 01, 3, 9, '01/06/2020', 1);
insert into KetQuaThiLai values (6, 2021, 02, 6, 8, '05/06/2020', 1);
insert into KetQuaThiLai values (2, 2020, 02, 7, 7, '07/06/2020', 2);
insert into KetQuaThiLai values (4, 2020, 03, 7, 8, '11/06/2020', 1);
insert into KetQuaThiLai values (3, 2020, 02, 2, 8, '11/06/2020', 3);