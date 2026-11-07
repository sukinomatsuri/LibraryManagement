-- ==============================================================================
-- HỆ THỐNG QUẢN LÝ THƯ VIỆN (LIBRARY MANAGEMENT SYSTEM)
-- Full Database Script for SQL Server (T-SQL)
-- Database Name: QLTV
-- Tương thích: Microsoft SQL Server 2012 / 2014 / 2016 / 2019 / 2022
-- ==============================================================================
-- TÀI KHOẢN MẶC ĐỊNH (Mật khẩu đều là: 123456):
-- 1. Quản trị viên (Admin):
--    - Username: admin
--    - Password: 123456
-- 2. Bạn đọc (User):
--    - Username: vinhcntt
--    - Password: 123456
-- 3. Bạn đọc (User):
--    - Username: bandoc1
--    - Password: 123456
-- ==============================================================================

USE [master];
GO

-- 1. TẠO CƠ SỞ DỮ LIỆU QLTV NẾU CHƯA TỒN TẠI
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'QLTV')
BEGIN
    CREATE DATABASE [QLTV];
    PRINT N'Cơ sở dữ liệu [QLTV] đã được tạo thành công!';
END
ELSE
BEGIN
    PRINT N'Cơ sở dữ liệu [QLTV] đã tồn tại, tiếp tục cập nhật cấu trúc...';
END
GO

USE [QLTV];
GO

-- 2. XÓA BẢNG CŨ THEO THỨ TỰ RÀNG BUỘC KHÓA NGOẠI (NẾU CÓ)
IF OBJECT_ID(N'dbo.ChiTietPhieuMuon', N'U') IS NOT NULL DROP TABLE dbo.ChiTietPhieuMuon;
IF OBJECT_ID(N'dbo.PhieuMuon', N'U') IS NOT NULL DROP TABLE dbo.PhieuMuon;
IF OBJECT_ID(N'dbo.Sach', N'U') IS NOT NULL DROP TABLE dbo.Sach;
IF OBJECT_ID(N'dbo.TheLoai', N'U') IS NOT NULL DROP TABLE dbo.TheLoai;
IF OBJECT_ID(N'dbo.NhaXuatBan', N'U') IS NOT NULL DROP TABLE dbo.NhaXuatBan;
IF OBJECT_ID(N'dbo.TacGia', N'U') IS NOT NULL DROP TABLE dbo.TacGia;
IF OBJECT_ID(N'dbo.NguoiDung', N'U') IS NOT NULL DROP TABLE dbo.NguoiDung;
GO

-- 3. TẠO CÁC BẢNG DỮ LIỆU

-- 3.1. Bảng NguoiDung (Người dùng / Độc giả / Quản trị viên)
CREATE TABLE dbo.NguoiDung (
    ID               INT IDENTITY(1,1) NOT NULL,
    TenDangNhap      VARCHAR(50)       NOT NULL,
    MatKhau          VARBINARY(MAX)    NOT NULL,
    Email            VARCHAR(50)       NOT NULL,
    NgayDangKi       DATETIME          NULL DEFAULT GETDATE(),
    MaOTP            VARCHAR(6)        NULL,
    ThoiGianNhanOTP  DATETIME          NULL,
    TrangThaiXacThuc BIT               NOT NULL DEFAULT 0,
    QuyenHan         VARCHAR(5)        NOT NULL DEFAULT 'user',
    HoTen            NVARCHAR(50)      NULL,
    SoSachMuon       INT               NOT NULL DEFAULT 0,
    BiKhoa           BIT               NOT NULL DEFAULT 0,
    CONSTRAINT PK_NguoiDung PRIMARY KEY CLUSTERED (ID ASC),
    CONSTRAINT UQ_NguoiDung_TenDangNhap UNIQUE (TenDangNhap),
    CONSTRAINT UQ_NguoiDung_Email UNIQUE (Email),
    CONSTRAINT CK_NguoiDung_QuyenHan CHECK (QuyenHan IN ('admin', 'user'))
);
GO

-- 3.2. Bảng TacGia (Tác giả)
CREATE TABLE dbo.TacGia (
    MaTG     INT IDENTITY(1,1) NOT NULL,
    TenTG    NVARCHAR(50)      NOT NULL,
    MoTa     NVARCHAR(500)     NULL,
    SoMaSach INT               NOT NULL DEFAULT 0,
    CONSTRAINT PK_TacGia PRIMARY KEY CLUSTERED (MaTG ASC)
);
GO

-- 3.3. Bảng NhaXuatBan (Nhà xuất bản)
CREATE TABLE dbo.NhaXuatBan (
    MaNXB    INT IDENTITY(1,1) NOT NULL,
    TenNXB   NVARCHAR(50)      NOT NULL,
    MoTa     NVARCHAR(500)     NULL,
    SoMaSach INT               NOT NULL DEFAULT 0,
    CONSTRAINT PK_NhaXuatBan PRIMARY KEY CLUSTERED (MaNXB ASC)
);
GO

-- 3.4. Bảng TheLoai (Thể loại sách)
CREATE TABLE dbo.TheLoai (
    MaTheLoai INT IDENTITY(1,1) NOT NULL,
    TenTheLoai NVARCHAR(50)     NOT NULL,
    MoTa       NVARCHAR(500)    NULL,
    SoMaSach   INT              NOT NULL DEFAULT 0,
    CONSTRAINT PK_TheLoai PRIMARY KEY CLUSTERED (MaTheLoai ASC)
);
GO

-- 3.5. Bảng Sach (Thông tin sách)
CREATE TABLE dbo.Sach (
    ID         INT IDENTITY(1,1) NOT NULL,
    TenSach    NVARCHAR(100)     NOT NULL,
    MaTG       INT               NULL,
    MaNXB      INT               NULL,
    MaTheLoai  INT               NULL,
    SoLuong    INT               NOT NULL DEFAULT 1,
    SoSachMuon INT               NOT NULL DEFAULT 0,
    CONSTRAINT PK_Sach PRIMARY KEY CLUSTERED (ID ASC),
    CONSTRAINT FK_Sach_TacGia FOREIGN KEY (MaTG) REFERENCES dbo.TacGia(MaTG),
    CONSTRAINT FK_Sach_NhaXuatBan FOREIGN KEY (MaNXB) REFERENCES dbo.NhaXuatBan(MaNXB),
    CONSTRAINT FK_Sach_TheLoai FOREIGN KEY (MaTheLoai) REFERENCES dbo.TheLoai(MaTheLoai)
);
GO

-- 3.6. Bảng PhieuMuon (Phiếu mượn sách)
-- Ý nghĩa TrangThai:
--   0: Đăng ký mượn (chờ thủ thư duyệt)
--   1: Đang mượn / Quá hạn
--   2: Đã trả sách
CREATE TABLE dbo.PhieuMuon (
    MaPhieu        INT IDENTITY(1,1) NOT NULL,
    IDBanDoc       INT               NOT NULL,
    NgayDangKyMuon DATETIME          NULL,
    NgayMuon       DATETIME          NULL,
    HanTra         DATETIME          NULL,
    NgayTra        DATETIME          NULL,
    TrangThai      INT               NOT NULL DEFAULT 0,
    CONSTRAINT PK_PhieuMuon PRIMARY KEY CLUSTERED (MaPhieu ASC),
    CONSTRAINT FK_PhieuMuon_NguoiDung FOREIGN KEY (IDBanDoc) REFERENCES dbo.NguoiDung(ID)
);
GO

-- 3.7. Bảng ChiTietPhieuMuon (Chi tiết từng cuốn sách trong phiếu mượn)
CREATE TABLE dbo.ChiTietPhieuMuon (
    MaChiTiet INT IDENTITY(1,1) NOT NULL,
    MaPhieu   INT               NOT NULL,
    IDSach    INT               NOT NULL,
    SoLuong   INT               NOT NULL DEFAULT 1,
    CONSTRAINT PK_ChiTietPhieuMuon PRIMARY KEY CLUSTERED (MaChiTiet ASC),
    CONSTRAINT FK_ChiTietPhieuMuon_PhieuMuon FOREIGN KEY (MaPhieu) REFERENCES dbo.PhieuMuon(MaPhieu) ON DELETE CASCADE,
    CONSTRAINT FK_ChiTietPhieuMuon_Sach FOREIGN KEY (IDSach) REFERENCES dbo.Sach(ID)
);
GO

-- ==============================================================================
-- 4. THÊM DỮ LIỆU KHỞI TẠO MẪU (SEED DATA)
-- ==============================================================================

-- 4.1. Thêm dữ liệu bảng NguoiDung
-- Lưu ý: Mật khẩu mặc định đều là "123456" mã hóa MD5 -> 0xE10ADC3949BA59ABBE56E057F20F883E
SET IDENTITY_INSERT dbo.NguoiDung ON;
INSERT INTO dbo.NguoiDung (ID, TenDangNhap, MatKhau, Email, NgayDangKi, MaOTP, ThoiGianNhanOTP, TrangThaiXacThuc, QuyenHan, HoTen, SoSachMuon, BiKhoa)
VALUES
(1, 'admin', 0xE10ADC3949BA59ABBE56E057F20F883E, 'admin@library.com', '2026-11-01 08:00:00', NULL, NULL, 1, 'admin', N'Quản trị viên', 0, 0),
(2, 'vinhcntt', 0xE10ADC3949BA59ABBE56E057F20F883E, 'thomphuc13112003@gmail.com', '2026-10-28 09:30:00', NULL, NULL, 1, 'user', N'Nguyễn Thị Vinh', 4, 0),
(3, 'bandoc1', 0xE10ADC3949BA59ABBE56E057F20F883E, 'bandoc1@gmail.com', '2026-10-18 10:15:00', NULL, NULL, 1, 'user', N'Trần Thị Mai', 0, 0);
SET IDENTITY_INSERT dbo.NguoiDung OFF;
GO

-- 4.2. Thêm dữ liệu bảng TacGia
SET IDENTITY_INSERT dbo.TacGia ON;
INSERT INTO dbo.TacGia (MaTG, TenTG, MoTa, SoMaSach)
VALUES
(1, N'Nam Cao', N'Nhà văn hiện thực xuất sắc của văn học Việt Nam', 5),
(2, N'Vũ Trọng Phụng', N'Cây bút hiện thực trào phúng hàng đầu', 5),
(3, N'Nguyễn Nhật Ánh', N'Nhà văn của tuổi thơ và học trò', 10),
(4, N'Dale Carnegie', N'Tác giả Đắc Nhân Tâm - Kỷ lục bán chạy thế giới', 5);
SET IDENTITY_INSERT dbo.TacGia OFF;
GO

-- 4.3. Thêm dữ liệu bảng NhaXuatBan
SET IDENTITY_INSERT dbo.NhaXuatBan ON;
INSERT INTO dbo.NhaXuatBan (MaNXB, TenNXB, MoTa, SoMaSach)
VALUES
(1, N'NXB Kim Đồng', N'Nhà xuất bản sách thiếu nhi hàng đầu Việt Nam', 10),
(2, N'NXB Trẻ', N'Nhà xuất bản Trẻ TP. Hồ Chí Minh', 10),
(3, N'NXB Văn Học', N'Nhà xuất bản chuyên văn học cổ điển & đương đại', 10),
(4, N'NXB Giáo Dục', N'Nhà xuất bản Giáo dục Việt Nam', 5);
SET IDENTITY_INSERT dbo.NhaXuatBan OFF;
GO

-- 4.4. Thêm dữ liệu bảng TheLoai
SET IDENTITY_INSERT dbo.TheLoai ON;
INSERT INTO dbo.TheLoai (MaTheLoai, TenTheLoai, MoTa, SoMaSach)
VALUES
(1, N'Văn học thiếu nhi', N'Truyện và tiểu thuyết dành cho lứa tuổi thanh thiếu niên', 5),
(2, N'Tiểu thuyết', N'Tác phẩm văn xuôi truyện dài phản ánh xã hội', 5),
(3, N'Kỹ năng sống', N'Sách rèn luyện tư duy và phát triển bản thân', 5),
(4, N'Công nghệ thông tin', N'Sách lập trình, cơ sở dữ liệu và khoa học máy tính', 5);
SET IDENTITY_INSERT dbo.TheLoai OFF;
GO

-- 4.5. Thêm dữ liệu bảng Sach
SET IDENTITY_INSERT dbo.Sach ON;
INSERT INTO dbo.Sach (ID, TenSach, MaTG, MaNXB, MaTheLoai, SoLuong, SoSachMuon)
VALUES
(1, N'Cho Tôi Xin Một Vé Đi Tuổi Thơ', 3, 2, 1, 10, 1),
(2, N'Mắt Biếc', 3, 2, 2, 15, 1),
(3, N'Số Đỏ', 2, 3, 2, 8, 2),
(4, N'Chí Phèo', 1, 3, 2, 6, 0),
(5, N'Đắc Nhân Tâm', 4, 2, 3, 12, 0),
(6, N'Lập trình C# WinForms từ cơ bản đến nâng cao', 1, 4, 4, 10, 0);
SET IDENTITY_INSERT dbo.Sach OFF;
GO

-- 4.6. Thêm dữ liệu bảng PhieuMuon
-- Bao gồm cả 3 trạng thái:
--   - Phiếu 1, 4: Đang mượn trong hạn (màu xanh dương)
--   - Phiếu 2: Đang mượn quá hạn (màu đỏ)
--   - Phiếu 3: Đã trả sách (màu xanh lá)
--   - Phiếu 5: Đăng ký mượn chờ duyệt
SET IDENTITY_INSERT dbo.PhieuMuon ON;
INSERT INTO dbo.PhieuMuon (MaPhieu, IDBanDoc, NgayDangKyMuon, NgayMuon, HanTra, NgayTra, TrangThai)
VALUES
(1, 2, '2026-11-02 16:01:43', '2026-11-02 16:01:43', '2026-11-16 16:01:43', NULL, 1),
(2, 2, '2026-10-18 16:01:43', '2026-10-18 16:01:43', '2026-11-04 16:01:43', NULL, 1),
(3, 2, '2026-10-08 16:01:43', '2026-10-08 16:01:43', '2026-10-22 16:01:43', '2026-10-23 16:01:43', 2),
(4, 2, '2026-11-07 16:18:21', '2026-11-07 16:18:21', '2026-11-26 16:18:21', NULL, 1),
(5, 3, '2026-11-07 16:30:00', NULL, NULL, NULL, 0);
SET IDENTITY_INSERT dbo.PhieuMuon OFF;
GO

-- 4.7. Thêm dữ liệu bảng ChiTietPhieuMuon
SET IDENTITY_INSERT dbo.ChiTietPhieuMuon ON;
INSERT INTO dbo.ChiTietPhieuMuon (MaChiTiet, MaPhieu, IDSach, SoLuong)
VALUES
(1, 1, 2, 1),
(2, 2, 3, 1),
(3, 3, 1, 1),
(4, 4, 1, 1),
(5, 4, 3, 1),
(6, 5, 4, 1),
(7, 5, 5, 1);
SET IDENTITY_INSERT dbo.ChiTietPhieuMuon OFF;
GO

-- ==============================================================================
-- 5. TRUY VẤN KIỂM TRA DỮ LIỆU SAU KHI CÀI ĐẶT
-- ==============================================================================
PRINT N'================ KIỂM TRA BẢNG NGUOIDUNG ================'
SELECT ID, TenDangNhap, Email, QuyenHan, HoTen, SoSachMuon, BiKhoa FROM dbo.NguoiDung;

PRINT N'================ KIỂM TRA BẢNG SACH ===================='
SELECT S.ID, S.TenSach, TG.TenTG, NXB.TenNXB, TL.TenTheLoai, S.SoLuong, S.SoSachMuon, (S.SoLuong - S.SoSachMuon) AS CoSan
FROM dbo.Sach S
LEFT JOIN dbo.TacGia TG ON S.MaTG = TG.MaTG
LEFT JOIN dbo.NhaXuatBan NXB ON S.MaNXB = NXB.MaNXB
LEFT JOIN dbo.TheLoai TL ON S.MaTheLoai = TL.MaTheLoai;

PRINT N'================ KIỂM TRA PHIẾU MƯỢN ==================='
SELECT PM.MaPhieu, ND.HoTen AS TenBanDoc, PM.NgayMuon, PM.HanTra, PM.NgayTra,
       CASE PM.TrangThai 
            WHEN 0 THEN N'Đăng ký mượn' 
            WHEN 1 THEN 
                 CASE WHEN PM.HanTra < GETDATE() THEN N'Quá hạn' ELSE N'Đang mượn' END
            WHEN 2 THEN N'Đã trả' 
       END AS TrangThaiHienThi
FROM dbo.PhieuMuon PM
JOIN dbo.NguoiDung ND ON PM.IDBanDoc = ND.ID;
GO

PRINT N'CÀI ĐẶT TOÀN BỘ CƠ SỞ DỮ LIỆU QLTV THÀNH CÔNG!';
GO
