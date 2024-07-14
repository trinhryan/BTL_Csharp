create table ChucVu
(
    MaCV  int identity
        primary key,
    TenCV nvarchar(100) not null
)
go

create table CuaHang
(
    MaCuaHang  int identity
        primary key,
    TenCuaHang nvarchar(100) not null,
    DiaChi     nvarchar(255)
)
go

create table KhachHang
(
    MaKH   int identity
        primary key,
    TenKH  nvarchar(100),
    SDT    varchar(15),
    DiaChi nvarchar(255)
)
go

create table NguoiDung
(
    TenDangNhap varchar(50) not null
        primary key,
    HoTen       nvarchar(100),
    MatKhau     varchar(50),
    GioiTinh    char,
    SDT         varchar(15),
    DiaChi      nvarchar(255)
)
go

create table NhaCungCap
(
    MaNCC  int identity
        primary key,
    TenNCC nvarchar(100) not null,
    DiaChi nvarchar(255),
    SDT    varchar(15)
)
go

create table QuanLy
(
    MaQL     int identity
        primary key,
    TenQL    nvarchar(100) not null,
    SDT      varchar(15),
    DiaChi   nvarchar(255),
    NgaySinh date,
    GioiTinh char,
    MaCV     int
        references ChucVu
)
go

create table HoaDon
(
    MaHD     int identity
        primary key,
    MaSP     int            not null,
    TenSP    nvarchar(100)  not null,
    SoLuong  int            not null,
    DonGia   decimal(10, 2) not null,
    NgayBan  date,
    TongTien decimal(10, 2),
    MaQL     int
        references QuanLy
)
go

create table PhieuNhap
(
    MaPN         int identity
        primary key,
    NgayNhap     date,
    MaNCC        int
        references NhaCungCap,
    SDTNCC       varchar(15),
    MaSP         int not null,
    MaCuaHang    int
        references CuaHang,
    TongTienHang decimal(10, 2),
    MaQL         int
        references QuanLy
)
go

create table Sale
(
    MaSale      int identity
        primary key,
    TenSale     nvarchar(100)             not null,
    NgaySinh    date,
    GioiTinh    char                      not null,
    SDT         varchar(15),
    MaCuaHang   int
        references CuaHang,
    SL          int,
    MaQL        int
        references QuanLy,
    TenDangNhap varchar(50)
        references NguoiDung,
    DiaChi      nvarchar(255) default N'' not null,
    MaCV        int
        references ChucVu
)
go

create table PhieuXuat
(
    MaPX      int identity
        primary key,
    MaCuaHang int           not null
        references CuaHang,
    NgayXuat  date,
    MaQL      int
        references QuanLy,
    TenSP     nvarchar(100) not null,
    MaSale    int
        references Sale
)
go

create table SanPham
(
    MaSP       int identity
        primary key,
    SoLuong    int default 0  not null,
    TenSP      nvarchar(100)  not null,
    GiaSP      decimal(10, 2) not null
        check ([GiaSP] >= 0),
    HSD        date,
    NSX        date,
    PhanLoaiSP nvarchar(100)
)
go

create table DonHang
(
    MaDH      int identity
        primary key,
    MaSP      int
        references SanPham,
    MaKH      int
        references KhachHang,
    MaCuaHang int
        references CuaHang,
    NgayTao   date,
    TongTien  decimal(10, 2),
    TrangThai nvarchar(50) default N'' not null
)
go

create table ChiTietDonHang
(
    MaDH        int
        references DonHang,
    NgayTao     date,
    CuaHang     int
        references CuaHang,
    MaKH        int
        references KhachHang,
    TenKH       nvarchar(100),
    SDT         varchar(15),
    MaSP        int
        references SanPham,
    TenSP       nvarchar(100),
    SoLuongSP   int,
    TongGiaTien decimal(10, 2)
)
go

create table __EFMigrationsHistory
(
    MigrationId    nvarchar(150) not null
        primary key,
    ProductVersion nvarchar(32)  not null
)
go


INSERT INTO ChucVu (TenCV)
VALUES
    (N'Giám đốc'),
    (N'Phó giám đốc'),
    (N'Trưởng phòng kinh doanh'),
    (N'Trưởng phòng marketing'),
    (N'Trưởng phòng nhân sự'),
    (N'Trưởng phòng kế toán'),
    (N'Trưởng phòng IT'),
    (N'Quản lý cửa hàng'),
    (N'Nhân viên bán hàng'),
    (N'Nhân viên kho'),
    (N'Nhân viên tiếp thị'),
    (N'Nhân viên thiết kế'),
    (N'Nhân viên IT'),
    (N'Nhân viên kế toán'),
    (N'Nhân viên giao hàng'),
    (N'Nhân viên chăm sóc khách hàng'),
    (N'Nhân viên bảo vệ'),
    (N'Nhân viên vệ sinh'),
    (N'Lễ tân'),
    (N'Thực tập sinh');


INSERT INTO CuaHang (TenCuaHang, DiaChi)
VALUES
    (N'Cửa hàng Big C', N'123 Đường Nguyễn Trãi, Quận 1, TP.HCM'),
    (N'Siêu thị Co.opmart', N'456 Đường Lê Văn Lương, Quận 7, TP.HCM'),
    (N'Cửa hàng VinMart+', N'789 Đường Nguyễn Văn Linh, Quận 8, TP.HCM'),
    (N'Siêu thị Lotte Mart', N'321 Đường Võ Văn Kiệt, Quận 1, TP.HCM'),
    (N'Cửa hàng Aeon Mall', N'654 Đường Tân Phú, Quận Tân Phú, TP.HCM'),
    (N'Siêu thị Emart', N'987 Đường Cộng Hòa, Quận Tân Bình, TP.HCM'),
    (N'Cửa hàng Bách Hóa Xanh', N'246 Đường Phan Văn Trị, Quận Gò Vấp, TP.HCM'),
    (N'Siêu thị MM Mega Market', N'135 Đường Xa Lộ Hà Nội, Quận 2, TP.HCM'),
    (N'Cửa hàng Satrafoods', N'864 Đường 3 Tháng 2, Quận 10, TP.HCM'),
    (N'Siêu thị Go!', N'579 Đường Quang Trung, Quận Gò Vấp, TP.HCM'),
    (N'Cửa hàng Circle K', N'369 Đường Nguyễn Thị Minh Khai, Quận 3, TP.HCM'),
    (N'Siêu thị FamilyMart', N'753 Đường Phạm Văn Đồng, Quận Thủ Đức, TP.HCM'),
    (N'Cửa hàng MiniStop', N'486 Đường Lê Hồng Phong, Quận 10, TP.HCM'),
    (N'Siêu thị GS25', N'975 Đường Nguyễn Kiệm, Quận Gò Vấp, TP.HCM'),
    (N'Cửa hàng 7-Eleven', N'258 Đường Điện Biên Phủ, Quận 3, TP.HCM'),
    (N'Cửa hàng Shop&Go', N'642 Đường Nguyễn Chí Thanh, Quận 5, TP.HCM'),
    (N'Siêu thị Vincom+', N'123 Đường Đồng Khởi, Quận 1, TP.HCM'),
    (N'Cửa hàng The Coffee House', N'456 Đường Nguyễn Huệ, Quận 1, TP.HCM'),
    (N'Cửa hàng Phúc Long', N'789 Đường Hai Bà Trưng, Quận 1, TP.HCM'),
    (N'Cửa hàng Highlands Coffee', N'321 Đường Lê Duẩn, Quận 1, TP.HCM');

INSERT INTO NguoiDung (TenDangNhap, HoTen, MatKhau, GioiTinh, SDT, DiaChi)
VALUES
    ('user1', N'Nguyễn Văn An', 'password', 'M', '0987654321', N'123 Nguyễn Trãi, Quận 1, TP.HCM'),
    ('user2', N'Trần Thị Bình', 'password', 'F', '0912345678', N'456 Lê Văn Lương, Quận 7, TP.HCM'),
    ('user3', N'Lê Văn Cường', 'password', 'M', '0987654322', N'789 Nguyễn Văn Linh, Quận 8, TP.HCM'),
    ('user4', N'Phạm Thị Dung', 'password', 'F', '0912345679', N'321 Võ Văn Kiệt, Quận 1, TP.HCM'),
    ('user5', N'Hoàng Văn Em', 'password', 'M', '0987654323', N'654 Tân Phú, Quận Tân Phú, TP.HCM'),
    ('user6', N'Nguyễn Thị Gái', 'password', 'F', '0912345680', N'987 Cộng Hòa, Quận Tân Bình, TP.HCM'),
    ('user7', N'Trần Văn Hùng', 'password', 'M', '0987654324', N'246 Phan Văn Trị, Quận Gò Vấp, TP.HCM'),
    ('user8', N'Lê Thị Hương', 'password', 'F', '0912345681', N'135 Xa Lộ Hà Nội, Quận 2, TP.HCM'),
    ('user9', N'Phạm Văn Minh', 'password', 'M', '0987654325', N'864 3 Tháng 2, Quận 10, TP.HCM'),
    ('user10', N'Nguyễn Thị Oanh', 'password', 'F', '0912345682', N'579 Quang Trung, Quận Gò Vấp, TP.HCM'),
    ('user11', N'Trần Văn Phong', 'password', 'M', '0987654326', N'369 Nguyễn Thị Minh Khai, Quận 3, TP.HCM'),
    ('user12', N'Lê Thị Quyên', 'password', 'F', '0912345683', N'753 Phạm Văn Đồng, Quận Thủ Đức, TP.HCM'),
    ('user13', N'Phạm Văn Tài', 'password', 'M', '0987654327', N'486 Lê Hồng Phong, Quận 10, TP.HCM'),
    ('user14', N'Nguyễn Thị Uyên', 'password', 'F', '0912345684', N'975 Nguyễn Kiệm, Quận Gò Vấp, TP.HCM'),
    ('user15', N'Trần Văn Vương', 'password', 'M', '0987654328', N'258 Điện Biên Phủ, Quận 3, TP.HCM'),
    ('user16', N'Lê Thị Xuyên', 'password', 'F', '0912345685', N'642 Nguyễn Chí Thanh, Quận 5, TP.HCM'),
    ('user17', N'Phạm Văn Ý', 'password', 'M', '0987654329', N'123 Đồng Khởi, Quận 1, TP.HCM'),
    ('user18', N'Nguyễn Thị Ánh', 'password', 'F', '0912345686', N'456 Nguyễn Huệ, Quận 1, TP.HCM'),
    ('user19', N'Trần Văn Bảo', 'password', 'M', '0987654330', N'789 Hai Bà Trưng, Quận 1, TP.HCM'),
    ('user20', N'Lê Thị Cúc', 'password', 'F', '0912345687', N'321 LêDuẩn, Quận 1, TP.HCM');

INSERT INTO KhachHang (TenKH, SDT, DiaChi)
VALUES
    (N'Nguyễn Văn A', '0987654321', N'123 Nguyễn Trãi, Quận 1, TP.HCM'),
    (N'Trần Thị B', '0912345678', N'456 Lê Văn Lương, Quận 7, TP.HCM'),
    (N'Lê Văn C', '0987654322', N'789 Nguyễn Văn Linh, Quận 8, TP.HCM'),
    (N'Phạm Thị D', '0912345679', N'321 Võ Văn Kiệt, Quận 1, TP.HCM'),
    (N'Hoàng Văn E', '0987654323', N'654 Tân Phú, Quận Tân Phú, TP.HCM'),
    (N'Nguyễn Thị F', '0912345680', N'987 Cộng Hòa, Quận Tân Bình, TP.HCM'),
    (N'Trần Văn G', '0987654324', N'246 Phan Văn Trị, Quận Gò Vấp, TP.HCM'),
    (N'Lê Thị H', '0912345681', N'135 Xa Lộ Hà Nội, Quận 2, TP.HCM'),
    (N'Phạm Văn I', '0987654325', N'864 3 Tháng 2, Quận 10, TP.HCM'),
    (N'Nguyễn Thị K', '0912345682', N'579 Quang Trung, Quận Gò Vấp, TP.HCM'),
    (N'Trần Văn L', '0987654326', N'369 Nguyễn Thị Minh Khai, Quận 3, TP.HCM'),
    (N'Lê Thị M', '0912345683', N'753 Phạm Văn Đồng, Quận Thủ Đức, TP.HCM'),
    (N'Phạm Văn N', '0987654327', N'486 Lê Hồng Phong, Quận 10, TP.HCM'),
    (N'Nguyễn Thị O', '0912345684', N'975 Nguyễn Kiệm, Quận Gò Vấp, TP.HCM'),
    (N'Trần Văn P', '0987654328', N'258 Điện Biên Phủ, Quận 3, TP.HCM'),
    (N'Lê Thị Q', '0912345685', N'642 Nguyễn Chí Thanh, Quận 5, TP.HCM'),
    (N'Phạm Văn R', '0987654329', N'123 Đồng Khởi, Quận 1, TP.HCM'),
    (N'Nguyễn Thị S', '0912345686', N'456 Nguyễn Huệ, Quận 1, TP.HCM'),
    (N'Trần Văn T', '0987654330', N'789 Hai Bà Trưng, Quận 1, TP.HCM'),
    (N'Lê Thị U', '0912345687', N'321 Lê Duẩn, Quận 1, TP.HCM');

INSERT INTO NhaCungCap (TenNCC, DiaChi, SDT)
VALUES
    (N'Công ty TNHH ABC', N'123 Nguyễn Trãi, Quận 1, TP.HCM', '0987654321'),
    (N'Công ty Cổ phần XYZ', N'456 Lê Văn Lương, Quận 7, TP.HCM', '0912345678'),
    (N'Doanh nghiệp TNHH MTV DEF', N'789 Nguyễn Văn Linh, Quận 8, TP.HCM', '0987654322'),
    (N'Cơ sở sản xuất GHI', N'321 Võ Văn Kiệt, Quận 1, TP.HCM', '0912345679'),
    (N'Công ty TNHH JKL', N'654 Tân Phú, Quận Tân Phú, TP.HCM', '0987654323'),
    (N'Công ty Cổ phần MNO', N'987 Cộng Hòa, Quận Tân Bình, TP.HCM', '0912345680'),
    (N'Doanh nghiệp Tư nhân PQR', N'246 Phan Văn Trị, Quận Gò Vấp, TP.HCM', '0987654324'),
    (N'Cơ sở sản xuất STU', N'135 Xa Lộ Hà Nội, Quận 2, TP.HCM', '0912345681'),
    (N'Công ty TNHH VWX', N'864 3 Tháng 2, Quận 10, TP.HCM', '0987654325'),
    (N'Công ty Cổ phần YZA', N'579 Quang Trung, Quận Gò Vấp, TP.HCM', '0912345682'),
    (N'Doanh nghiệp TNHH MTV BCD', N'369 Nguyễn Thị Minh Khai, Quận 3, TP.HCM', '0987654326'),
    (N'Cơ sở sản xuất EFG', N'753 Phạm Văn Đồng, Quận Thủ Đức, TP.HCM', '0912345683'),
    (N'Công ty TNHH HIJ', N'486 Lê Hồng Phong, Quận 10, TP.HCM', '0987654327'),
    (N'Công ty Cổ phần KLM', N'975 Nguyễn Kiệm, Quận Gò Vấp, TP.HCM', '0912345684'),
    (N'Doanh nghiệp Tư nhân NOP', N'258 Điện Biên Phủ, Quận 3, TP.HCM', '0987654328'),
    (N'Cơ sở sản xuất QRS', N'642 Nguyễn Chí Thanh, Quận 5, TP.HCM', '0912345685'),
    (N'Công ty TNHH TUV', N'123 Đồng Khởi, Quận 1, TP.HCM', '0987654329'),
    (N'Công ty Cổ phần WXY', N'456 Nguyễn Huệ, Quận 1, TP.HCM', '0912345686'),
    (N'Doanh nghiệp TNHH MTV ZAB', N'789 Hai Bà Trưng, Quận 1, TP.HCM', '0987654330'),
    (N'Cơ sở sản xuất CDE', N'321 Lê Duẩn, Quận 1, TP.HCM', '0912345687');

INSERT INTO SanPham (TenSP, SoLuong, GiaSP, HSD, NSX, PhanLoaiSP)
VALUES
    (N'Sữa tươi Vinamilk', 50, 25000.00, '2024-12-31', '2024-07-01', N'Thực phẩm'),
    (N'Bánh quy Oreo', 100, 12000.00, '2025-03-15', '2024-09-01', N'Thực phẩm'),
    (N'Nước ngọt Coca Cola', 80, 10000.00, '2024-08-31', '2024-04-01', N'Đồ uống'),
    (N'Mì tôm Hảo Hảo', 120, 5000.00, '2025-06-30', '2024-12-01', N'Thực phẩm'),
    (N'Bột giặt Omo', 30, 45000.00, NULL, NULL, N'Hóa mỹ phẩm'),
    (N'Nước rửa chén Sunlight', 40, 30000.00, NULL, NULL, N'Hóa mỹ phẩm'),
    (N'Gạo thơm ST25', 20, 80000.00, '2025-01-31', '2024-07-01', N'Thực phẩm'),
    (N'Dầu ăn Neptune', 50, 55000.00, '2024-10-31', '2024-05-01', N'Thực phẩm'),
    (N'Sữa chua Vinamilk', 60, 8000.00, '2024-09-15', '2024-08-01', N'Thực phẩm'),
    (N'Bánh mì tươi Kinh Đô', 70, 15000.00, '2024-08-20', '2024-08-15', N'Thực phẩm'),
    (N'Bia Heineken', 90, 18000.00, '2025-12-31', '2024-06-01', N'Đồ uống'),
    (N'Nước mắm Nam Ngư', 25, 40000.00, '2026-02-28', '2024-08-01', N'Thực phẩm'),
    (N'Bánh Chocopie', 110, 35000.00, '2025-04-30', '2024-10-01', N'Thực phẩm'),
    (N'Xà phòng Lifebuoy', 35, 15000.00, NULL, NULL, N'Hóa mỹ phẩm'),
    (N'Kem đánh răng P/S', 45, 20000.00, NULL, NULL, N'Hóa mỹ phẩm'),
    (N'Sữa đặc Ông Thọ', 55, 38000.00, '2025-09-30', '2024-03-01', N'Thực phẩm'),
    (N'Cà phê Trung Nguyên', 65, 70000.00, '2026-05-31', '2024-11-01', N'Đồ uống'),
    (N'Trà xanh C2', 85, 9000.00, '2024-11-15', '2024-05-01', N'Đồ uống'),
    (N'Bánh quy Cosy', 105, 10000.00, '2025-02-28', '2024-08-01', N'Thực phẩm'),
    (N'Giấy vệ sinh An An', 30, 25000.00, NULL, NULL, N'Hóa mỹ phẩm');


INSERT INTO Sale (TenSale, NgaySinh, GioiTinh, SDT, MaCV, MaCuaHang, SL, MaQL, TenDangNhap, DiaChi)
VALUES
    (N'Nguyễn Văn A', '1994-05-12', 'M', '0987654321', 1, 1, 25, 1, 'user1', N'123 Nguyễn Trãi, Quận 1, TP.HCM'),
    (N'Trần Thị B', '1995-08-20', 'F', '0912345678', 2, 2, 38, 2, 'user2', N'456 Lê Văn Lương, Quận 7, TP.HCM'),
    (N'Lê Văn C', '1993-03-15', 'M', '0987654322', 3, 3, 52, 3, 'user3', N'789 Nguyễn Văn Linh, Quận 8, TP.HCM'),
    (N'Phạm Thị D', '1996-11-08', 'F', '0912345679', 1, 4, 18, 4, 'user4', N'321 Võ Văn Kiệt, Quận 1, TP.HCM'),
    (N'Hoàng Văn E', '1992-07-22', 'M', '0987654323', 2, 5, 60, 5, 'user5', N'654 Tân Phú, Quận Tân Phú, TP.HCM'),
    (N'Nguyễn Thị F', '1997-02-05', 'F', '0912345680', 3, 6, 43, 6, 'user6', N'987 Cộng Hòa, Quận Tân Bình, TP.HCM'),
    (N'Trần Văn G', '1994-09-30', 'M', '0987654324', 1, 7, 21, 7, 'user7', N'246 Phan Văn Trị, Quận Gò Vấp, TP.HCM'),
    (N'Lê Thị H', '1995-04-18', 'F', '0912345681', 2, 8, 75, 8, 'user8', N'135 Xa Lộ Hà Nội, Quận 2, TP.HCM'),
    (N'Phạm Văn I', '1993-12-25', 'M', '0987654325', 3, 9, 36, 9, 'user9', N'864 3 Tháng 2, Quận 10, TP.HCM'),
    (N'Nguyễn Thị K', '1996-06-11', 'F', '0912345682', 1, 10, 58, 10, 'user10', N'579 Quang Trung, Quận Gò Vấp, TP.HCM'),
    (N'Trần Văn L', '1992-01-03', 'M', '0987654326', 2, 1, 15, 11, 'user11', N'369 Nguyễn Thị Minh Khai, Quận 3, TP.HCM'),
    (N'Lê Thị M', '1997-09-28', 'F', '0912345683', 3, 2, 82, 12, 'user12', N'753 Phạm Văn Đồng, Quận Thủ Đức, TP.HCM'),
    (N'Phạm Văn N', '1994-06-17', 'M', '0987654327', 1, 3, 32, 13, 'user13', N'486 Lê Hồng Phong, Quận 10, TP.HCM'),
    (N'Nguyễn Thị O', '1995-12-04', 'F', '0912345684', 2, 4, 49, 14, 'user14', N'975 Nguyễn Kiệm, Quận Gò Vấp, TP.HCM'),
    (N'Trần Văn P', '1993-08-09', 'M', '0987654328', 3, 5, 27, 15, 'user15', N'258 Điện Biên Phủ, Quận 3, TP.HCM'),
    (N'Lê Thị Q', '1996-03-23', 'F', '0912345685', 1, 6, 64, 16, 'user16', N'642 Nguyễn Chí Thanh, Quận 5, TP.HCM'),
    (N'Phạm Văn R', '1992-10-31', 'M', '0987654329', 2, 7, 19, 17, 'user17', N'123 Đồng Khởi, Quận 1, TP.HCM'),
    (N'Nguyễn Thị S', '1997-05-07', 'F', '0912345686', 3, 8, 90, 18, 'user18', N'456 Nguyễn Huệ, Quận 1, TP.HCM'),
    (N'Trần Văn T', '1994-01-14', 'M', '0987654330', 1, 9, 30, 19, 'user19', N'789 Hai Bà Trưng, Quận 1, TP.HCM'),
    (N'Lê Thị U', '1995-07-06', 'F', '0912345687', 2, 10, 41, 20, 'user20', N'321 Lê Duẩn, Quận 1, TP.HCM');


INSERT INTO QuanLy (TenQL, NgaySinh, GioiTinh, SDT, DiaChi, MaCV)
VALUES
    (N'Lê Minh Quân', '1980-03-12', 'M', '0987654321', N'123 Nguyễn Trãi, Quận 1, TP.HCM', 1),
    (N'Trần Thị Thanh Hà', '1985-08-20', 'F', '0912345678', N'456 Lê Văn Lương, Quận 7, TP.HCM', 2),
    (N'Nguyễn Văn Đức', '1978-03-15', 'M', '0987654322', N'789 Nguyễn Văn Linh, Quận 8, TP.HCM', 3),
    (N'Phạm Thị Thu Thủy', '1982-11-08', 'F', '0912345679', N'321 Võ Văn Kiệt, Quận 1, TP.HCM', 4),
    (N'Võ Hoàng Long', '1979-07-22', 'M', '0987654323', N'654 Tân Phú, Quận Tân Phú, TP.HCM', 5),
    (N'Hoàng Thị Diệu', '1981-02-05', 'F', '0912345680', N'987 Cộng Hòa, Quận Tân Bình, TP.HCM', 1),
    (N'Nguyễn Thành Nam', '1984-09-30', 'M', '0987654324', N'246 Phan Văn Trị, Quận Gò Vấp, TP.HCM', 2),
    (N'Trần Ngọc Mai', '1983-04-18', 'F', '0912345681', N'135 Xa Lộ Hà Nội, Quận 2, TP.HCM', 3),
    (N'Lê Anh Tuấn', '1977-12-25', 'M', '0987654325', N'864 3 Tháng 2, Quận 10, TP.HCM', 4),
    (N'Vũ Thị Kim Anh', '1986-06-11', 'F', '0912345682', N'579 Quang Trung, Quận Gò Vấp, TP.HCM', 5),
    (N'Phạm Minh Khang', '1980-01-03', 'M', '0987654326', N'369 Nguyễn Thị Minh Khai, Quận 3, TP.HCM', 1),
    (N'Hoàng Thùy Linh', '1985-09-28', 'F', '0912345683', N'753 Phạm Văn Đồng, Quận Thủ Đức, TP.HCM', 2),
    (N'Nguyễn Đức Toàn', '1979-06-17', 'M', '0987654327', N'486 Lê Hồng Phong, Quận 10, TP.HCM', 3),
    (N'Trần Thu Trang', '1984-12-04', 'F', '0912345684', N'975 Nguyễn Kiệm, Quận Gò Vấp, TP.HCM', 4),
    (N'Vũ Minh Trí', '1978-08-09', 'M', '0987654328', N'258 Điện Biên Phủ, Quận 3, TP.HCM', 5),
    (N'Lê Thanh Huyền', '1983-03-23', 'F', '0912345685', N'642 Nguyễn Chí Thanh, Quận 5, TP.HCM', 1),
    (N'Phạm Hoàng Anh', '1981-10-31', 'M', '0987654329', N'123 Đồng Khởi, Quận 1, TP.HCM', 2),
    (N'Nguyễn Thảo Vy', '1986-05-07', 'F', '0912345686', N'456 Nguyễn Huệ, Quận 1, TP.HCM', 3),
    (N'Trần Đức Duy', '1980-01-14', 'M', '0987654330', N'789 Hai Bà Trưng, Quận 1, TP.HCM', 4),
    (N'Lê Ngọc Ánh', '1985-07-06', 'F', '0912345687', N'321 Lê Duẩn, Quận 1, TP.HCM', 5);

DECLARE @maxMaSP INT = (SELECT MAX(MaSP) FROM SanPham);
DECLARE @maxMaQL INT = (SELECT MAX(MaQL) FROM QuanLy);

INSERT INTO HoaDon (MaSP, TenSP, SoLuong, DonGia, NgayBan, TongTien, MaQL)
VALUES
    (1, N'Sữa tươi Vinamilk', 2, 25000.00, '2024-07-10', 50000.00, 1),
    (2, N'Bánh quy Oreo', 5, 12000.00, '2024-07-11', 60000.00, 2),
    (3, N'Nước ngọt Coca Cola', 3, 10000.00, '2024-07-12', 30000.00, 3),
    (4, N'Mì tôm Hảo Hảo', 10, 5000.00, '2024-07-13', 50000.00, 4),
    (5, N'Bột giặt Omo', 1, 45000.00, '2024-07-14', 45000.00, 5),
    (6, N'Nước rửa chén Sunlight', 2, 30000.00, '2024-07-15', 60000.00, 6),
    (7, N'Gạo thơm ST25', 1, 80000.00, '2024-07-16', 80000.00, 7),
    (8, N'Dầu ăn Neptune', 3, 55000.00, '2024-07-17', 165000.00, 8),
    (9, N'Sữa chua Vinamilk', 4, 8000.00, '2024-07-18', 32000.00, 9),
    (10, N'Bánh mì tươi Kinh Đô', 5, 15000.00, '2024-07-19', 75000.00, 10),
    (11, N'Bia Heineken', 6, 18000.00, '2024-07-20', 108000.00, 1),
    (12, N'Nước mắm Nam Ngư', 1, 40000.00, '2024-07-21', 40000.00, 2),
    (13, N'Bánh Chocopie', 3, 35000.00, '2024-07-22', 105000.00, 3),
    (14, N'Xà phòng Lifebuoy', 2, 15000.00, '2024-07-23', 30000.00, 4),
    (15, N'Kem đánh răng P/S', 3, 20000.00, '2024-07-24', 60000.00, 5),
    (16, N'Sữa đặc Ông Thọ', 2, 38000.00, '2024-07-25', 76000.00, 6),
    (17, N'Cà phê Trung Nguyên', 1, 70000.00, '2024-07-26', 70000.00, 7),
    (18, N'Trà xanh C2', 5, 9000.00, '2024-07-27', 45000.00, 8),
    (19, N'Bánh quy Cosy', 4, 10000.00, '2024-07-28', 40000.00, 9),
    (20, N'Giấy vệ sinh An An', 2, 25000.00, '2024-07-29', 50000.00, 10);

DECLARE @maxMaSP INT = (SELECT MAX(MaSP) FROM SanPham);
DECLARE @maxMaKH INT = (SELECT MAX(MaKH) FROM KhachHang);
DECLARE @maxMaCuaHang INT = (SELECT MAX(MaCuaHang) FROM CuaHang);

INSERT INTO DonHang (MaSP, MaKH, MaCuaHang, NgayTao, TongTien, TrangThai)
VALUES
    (1, 1, 1, '2024-07-01', 500000.00, N'Đã giao hàng'),
    (2, 2, 2, '2024-07-02', 350000.00, N'Đang xử lý'),
    (3, 3, 3, '2024-07-03', 800000.00, N'Đã hủy'),
    (4, 4, 4, '2024-07-04', 200000.00, N'Đã thanh toán'),
    (5, 5, 5, '2024-07-05', 650000.00, N'Đang giao hàng'),
    (6, 6, 6, '2024-07-06', 480000.00, N'Đã giao hàng'),
    (7, 7, 7, '2024-07-07', 920000.00, N'Đang xử lý'),
    (8, 8, 8, '2024-07-08', 320000.00, N'Đã hủy'),
    (9, 9, 9, '2024-07-09', 710000.00, N'Đã thanh toán'),
    (10, 10, 10, '2024-07-10', 550000.00, N'Đang giao hàng'),
    (1, 11, 1, '2024-07-11', 400000.00, N'Đã giao hàng'),
    (2, 12, 2, '2024-07-12', 680000.00, N'Đang xử lý'),
    (3, 13, 3, '2024-07-13', 250000.00, N'Đã hủy'),
    (4, 14, 4, '2024-07-14', 850000.00, N'Đã thanh toán'),
    (5, 15, 5, '2024-07-15', 390000.00, N'Đang giao hàng'),
    (6, 16, 6, '2024-07-16', 520000.00, N'Đã giao hàng'),
    (7, 17, 7, '2024-07-17', 760000.00, N'Đang xử lý'),
    (8, 18, 8, '2024-07-18', 280000.00, N'Đã hủy'),
    (9, 19, 9, '2024-07-19', 630000.00, N'Đã thanh toán')


DECLARE @maxMaNCC INT = (SELECT MAX(MaNCC) FROM NhaCungCap);
DECLARE @maxMaSP INT = (SELECT MAX(MaSP) FROM SanPham);
DECLARE @maxMaCuaHang INT = (SELECT MAX(MaCuaHang) FROM CuaHang);
DECLARE @maxMaQL INT = (SELECT MAX(MaQL) FROM QuanLy);

INSERT INTO PhieuNhap (NgayNhap, MaNCC, SDTNCC, MaSP, MaCuaHang, TongTienHang, MaQL)
VALUES
    ('2024-07-05', 1, '0987654321', 1, 1, 1000000.00, 1),
    ('2024-07-06', 2, '0912345678', 2, 2, 850000.00, 2),
    ('2024-07-07', 3, '0987654322', 3, 3, 1200000.00, 3),
    ('2024-07-08', 4, '0912345679', 4, 4, 500000.00, 4),
    ('2024-07-09', 5, '0987654323', 5, 5, 750000.00, 5),
    ('2024-07-10', 6, '0912345680', 6, 6, 900000.00, 6),
    ('2024-07-11', 7, '0987654324', 7, 7, 1100000.00, 7),
    ('2024-07-12', 8, '0912345681', 8, 8, 600000.00, 8),
    ('2024-07-13', 9, '0987654325', 9, 9, 1350000.00, 9),
    ('2024-07-14', 10, '0912345682', 10, 10, 880000.00, 10),
    ('2024-07-15', 1, '0987654321', 1, 1, 1000000.00, 1),
    ('2024-07-16', 2, '0912345678', 2, 2, 850000.00, 2),
    ('2024-07-17', 3, '0987654322', 3, 3, 1200000.00, 3),
    ('2024-07-18', 4, '0912345679', 4, 4, 500000.00, 4),
    ('2024-07-19', 5, '0987654323', 5, 5, 750000.00, 5),
    ('2024-07-20', 6, '0912345680', 6, 6, 900000.00, 6),
    ('2024-07-21', 7, '0987654324', 7, 7, 1100000.00, 7),
    ('2024-07-22', 8, '0912345681', 8, 8, 600000.00, 8),
    ('2024-07-23', 9, '0987654325', 9, 9, 1350000.00, 9),
    ('2024-07-24', 10, '0912345682', 10, 10, 880000.00, 10);


DECLARE @maxMaSale INT = (SELECT MAX(MaSale) FROM Sale);



INSERT INTO PhieuXuat (MaCuaHang, NgayXuat, MaQL, TenSP, MaSale)
VALUES
    (1, '2024-07-01', 1, N'Sữa tươi Vinamilk', 21),
    (2, '2024-07-02', 2, N'Bánh quy Oreo', 2),
    (3, '2024-07-03', 3, N'Nước ngọt Coca Cola', 3),
    (4, '2024-07-04', 4, N'Mì tôm Hảo Hảo', 4),
    (5, '2024-07-05', 5, N'Bột giặt Omo', 5),
    (6, '2024-07-06', 6, N'Nước rửa chén Sunlight', 6),
    (7, '2024-07-07', 7, N'Gạo thơm ST25', 7),
    (8, '2024-07-08', 8, N'Dầu ăn Neptune', 8),
    (9, '2024-07-09', 9, N'Sữa chua Vinamilk', 9),
    (10, '2024-07-10', 10, N'Bánh mì tươi Kinh Đô', 10),
    (1, '2024-07-11', 1, N'Bia Heineken', 11),
    (2, '2024-07-12', 2, N'Nước mắm Nam Ngư', 12),
    (3, '2024-07-13', 3, N'Bánh Chocopie', 13),
    (4, '2024-07-14', 4, N'Xà phòng Lifebuoy', 14),
    (5, '2024-07-15', 5, N'Kem đánh răng P/S', 15),
    (6, '2024-07-16', 6, N'Sữa đặc Ông Thọ', 16),
    (7, '2024-07-17', 7, N'Cà phê Trung Nguyên', 17),
    (8, '2024-07-18', 8, N'Trà xanh C2', 18),
    (9, '2024-07-19', 9, N'Bánh quy Cosy', 19),
    (10, '2024-07-20', 10, N'Giấy vệ sinh An An', 20);

INSERT INTO ChiTietDonHang (MaDH, NgayTao, CuaHang, MaKH, TenKH, SDT, MaSP, TenSP, SoLuongSP, TongGiaTien)
VALUES
    (1, '2024-07-01', 1, 1, N'Nguyễn Văn A', '0987654321', 1, N'Sữa tươi Vinamilk', 2, 50000.00),
    (2, '2024-07-02', 2, 2, N'Trần Thị B', '0912345678', 2, N'Bánh quy Oreo', 5, 60000.00),
    (3, '2024-07-03', 3, 3, N'Lê Văn C', '0987654322', 3, N'Nước ngọt Coca Cola', 3, 30000.00),
    (4, '2024-07-04', 4, 4, N'Phạm Thị D', '0912345679', 4, N'Mì tôm Hảo Hảo', 10, 50000.00),
    (5, '2024-07-05', 5, 5, N'Hoàng Văn E', '0987654323', 5, N'Bột giặt Omo', 1, 45000.00),
    (6, '2024-07-06', 6, 6, N'Nguyễn Thị F', '0912345680', 6, N'Nước rửa chén Sunlight', 2, 60000.00),
    (7, '2024-07-07', 7, 7, N'Trần Văn G', '0987654324', 7, N'Gạo thơm ST25', 1, 80000.00),
    (8, '2024-07-08', 8, 8, N'Lê Thị H', '0912345681', 8, N'Dầu ăn Neptune', 3, 165000.00),
    (9, '2024-07-09', 9, 9, N'Phạm Văn I', '0987654325', 9, N'Sữa chua Vinamilk', 4, 32000.00),
    (10, '2024-07-10', 10, 10, N'Nguyễn Thị K', '0912345682', 10, N'Bánh mì tươi Kinh Đô', 5, 75000.00),
    (11, '2024-07-11', 1, 11, N'Trần Văn L', '0987654326', 11, N'Bia Heineken', 6, 108000.00),
    (12, '2024-07-12', 2, 12, N'Lê Thị M', '0912345683', 12, N'Nước mắm Nam Ngư', 1, 40000.00),
    (13, '2024-07-13', 3, 13, N'Phạm Văn N', '0987654327', 13, N'Bánh Chocopie', 3, 105000.00),
    (14, '2024-07-14', 4, 14, N'Nguyễn Thị O', '0912345684', 14, N'Xà phòng Lifebuoy', 2, 30000.00),
    (15, '2024-07-15', 5, 15, N'Trần Văn P', '0987654328', 15, N'Kem đánh răng P/S', 3, 60000.00),
    (16, '2024-07-16', 6, 16, N'Lê Thị Q', '0912345685', 16, N'Sữa đặc Ông Thọ', 2, 76000.00),
    (17, '2024-07-17', 7, 17, N'Phạm Văn R', '0987654329', 17, N'Cà phê Trung Nguyên', 1, 70000.00),
    (18, '2024-07-18', 8, 18, N'Nguyễn Thị S', '0912345686', 18, N'Trà xanh C2', 5, 45000.00),
    (19, '2024-07-19', 9, 19, N'Trần Văn T', '0987654330', 19, N'Bánh quy Cosy', 4, 40000.00)
;

