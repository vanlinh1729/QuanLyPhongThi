-- Tạo database
CREATE DATABASE QuanLyPhongThi;
Go
USE QuanLyPhongThi;
Go
-- Tạo bảng PhongHoc với MaPhong tự động tăng
CREATE TABLE PhongHoc (
    MaPhong INT AUTO_INCREMENT PRIMARY KEY,
    TenPhong VARCHAR(100),
    SucChua INT,
    TrangThietBi VARCHAR(255),
    TinhTrang VARCHAR(50)
);

-- Tạo bảng SinhVien
CREATE TABLE SinhVien (
    MaSinhVien INT PRIMARY KEY,
    HoTen VARCHAR(100),
    NgaySinh DATE,
    Lop VARCHAR(50)
);

-- Tạo bảng MonHoc
CREATE TABLE MonHoc (
    MaMonHoc INT PRIMARY KEY,
    TenMonHoc VARCHAR(100),
    SoTinChi INT
);

-- Tạo bảng LichThi
CREATE TABLE LichThi (
    MaLichThi INT PRIMARY KEY,
    MaPhong INT,
    MaMonHoc INT,
    NgayThi DATE,
    ThoiGianBatDau TIME,
    ThoiGianKetThuc TIME,
    FOREIGN KEY (MaPhong) REFERENCES PhongHoc(MaPhong),
    FOREIGN KEY (MaMonHoc) REFERENCES MonHoc(MaMonHoc)
);

-- Tạo bảng LichThi_SinhVien
CREATE TABLE LichThi_SinhVien (
    MaLichThi INT,
    MaSinhVien INT,
    PRIMARY KEY (MaLichThi, MaSinhVien),
    FOREIGN KEY (MaLichThi) REFERENCES LichThi(MaLichThi),
    FOREIGN KEY (MaSinhVien) REFERENCES SinhVien(MaSinhVien)
);
