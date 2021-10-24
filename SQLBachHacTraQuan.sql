-- TẠO DATABASE BACHHACTRAQUAN
CREATE DATABASE BachHacTraQuan;

-- TẠO BẢNG SẢN PHẨM
CREATE TABLE SanPham
(masanpham nvarchar(50) primary key,
tensanpham nvarchar(50),
loai nvarchar(50),
sotonkho int,
gianhap float,
giaban float);

-- TẠO BẢNG NHÂN VIÊN
CREATE TABLE NhanVien
(manhanvien nvarchar(50) primary key,
tennhanvien nvarchar(50),
chucvu nvarchar(50),
ngaysinh date,
cmnd nvarchar(50),
sdt int,
diachi nvarchar(50),
ngaycongchuancuathang int,
songaydilamthucte int,
luongcobanmotngaycong float,
thuclinh float);

-- TẠO BẢNG TÀI KHOẢN
CREATE TABLE TaiKhoan
(username nvarchar(50) primary key,
pass nvarchar(50));

-- TẠO BẢNG HOÁ ĐƠN
CREATE TABLE HoaDon
(mahoadon nvarchar(50) primary key,
ngaymuahang date,
ngaygiaohang date,
manhanvien nvarchar(50),
tennhanvien nvarchar(50),
tenkhachhang nvarchar(50),
sdtkh int,
diachikh nvarchar(50),
phigiaohang float, 
tonghoadon float,
tiencoc float,
canthanhtoan float);

-- TẠO BẢNG CHI TIẾT HOÁ ĐƠN
CREATE TABLE CTHoaDon
(macthoadon nvarchar(50) primary key,
mahoadon nvarchar(50),
tennhanvien nvarchar(50),
tenkhachhang nvarchar(50),
masanpham nvarchar(50),
tensanpham nvarchar(50),
soluong int,
gia float,
thanhtien float,);

-- TẠO BẢNG BÁO CÁO THỐNG KÊ 
CREATE TABLE BaoCaoThongKe
(mabaocao nvarchar(50) primary key,
manhanvien nvarchar(50),
tennhanvien nvarchar(50),
thang int,
thoigianthuchien date);

-- TẠO BẢNG THỐNG KÊ NHẬP XUẤT
CREATE TABLE ThongKeNhapXuat
(manhapxuat nvarchar(50) primary key,
mabaocao nvarchar(50),
tennhanvien nvarchar(50),
thang int,
masanpham nvarchar(50),
tensanpham nvarchar(50),
soluongnhap int,
soluongban int,
gianhap float,
giaban float);

-- TẠO BẢNG THỐNG KÊ THU CHI
CREATE TABLE ThongKeThuChi
(mathuchi nvarchar(50) primary key,
mabaocao nvarchar(50),
tennhanvien nvarchar(50),
thang int,
sotienchi float,
sotienthu float);

----------------------------------------
---------------- HIỂN THỊ BẢNG TÀI KHOẢN
SELECT *
FROM TaiKhoan; 
----------------------------------------
------------------------- BẢNG NHÂN VIÊN
-- NHẬP mã nv, tên, chức vụ, ngày sinh, cmnd, sđt, địa chỉ, số ngày công chuẩn (thoả thuận đi làm), số ngày đi làm thật, lương cơ bản
CREATE PROC ThucLinh
AS
    UPDATE NhanVien 
	SET thuclinh = luongcobanmotngaycong * songaydilamthucte
GO
---
EXEC ThucLinh
SELECT *
FROM NhanVien; 
----------------------------------------
-------------------------- BẢNG SẢN PHẨM
-- NHẬP mã sp, tên, loại, số tồn kho, giá nhập, giá bán
SELECT *
FROM SanPham;
----------------------------------------
--------------------------- BẢNG HOÁ ĐƠN
-- NHẬP mã hd, ngày mua, ngày giao, mã nv, tên kh, sđt, đc, phí giao hàng
-- Cập nhật tên nhân viên tự động
CREATE PROC CapNhatTenNVVaoHoaDon
AS
    UPDATE HoaDon
	SET HoaDon.tennhanvien = NhanVien.tennhanvien
	FROM HoaDon
	INNER JOIN NhanVien
	ON (HoaDon.manhanvien = NhanVien.manhanvien)
GO
----------------------------------------
------------------ BẢNG CHI TIẾT HOÁ ĐƠN
-- NHẬP mã ct, mã hd, mã sp, số lượng
-- Cập nhật giá và tên sản phẩm tự động
CREATE PROC CapNhatBangCTHoaDon
AS
    UPDATE CTHoaDon
	SET CTHoaDon.gia = SanPham.giaban, CTHoaDon.tensanpham = SanPham.tensanpham
	FROM CTHoaDon
	INNER JOIN SanPham
	ON (CTHoaDon.masanpham = SanPham.masanpham)
GO
-- Tính thành tiền = số lượng * giá bán
CREATE PROC ThanhTien
AS
    UPDATE CTHoaDon 
	SET thanhtien = soluong * gia
GO
-- Tính tổng hoá đơn = thành tiền + phí giao hàng, tiền cọc = 5-% tổng hoá đơn, cần thanh toán = tổng hoá đơn - tiền cọc
CREATE PROC TongHoaDon_TienCoc_CanThanhToan
AS
    UPDATE HoaDon
	SET tonghoadon = (SELECT SUM(thanhtien) + phigiaohang
                      FROM CTHoaDon
                      WHERE CTHoaDon.mahoadon = HoaDon.mahoadon),
		tiencoc = tonghoadon * 0.5,
		canthanhtoan = tonghoadon - tiencoc
    WHERE mahoadon = mahoadon;
GO
-- Cập nhật tên theo mã vào báo cáo thống kê
CREATE PROC CapNhatBCTK
AS
    UPDATE BaoCaoThongKe
	SET BaoCaoThongKe.tennhanvien = NhanVien.tennhanvien
	FROM BaoCaoThongKe
	INNER JOIN NhanVien
	ON (BaoCaoThongKe.manhanvien = NhanVien.manhanvien)
GO
-- Cập nhật hàng vào trong kho sau khi đã bán hoặc cập nhật: Số tồn kho = số tồn kho - số lượng bán
CREATE PROC Cap_Nhat_Hang_Ton_Kho
AS
    UPDATE SanPham 
	SET sotonkho = (SELECT sotonkho - SUM(soluong)
		            FROM CTHoaDon
					WHERE CTHoaDon.masanpham = SanPham.masanpham)
	WHERE masanpham = masanpham;
GO
-- Cập nhật tên, giá từ Sản Phẩm sang Báo Cáo
CREATE PROC CapNhatTen_GiaBaoCao
AS
    UPDATE ThongKeNhapXuat
	SET ThongKeNhapXuat.tensanpham = SanPham.tensanpham, 
	    ThongKeNhapXuat.gianhap = SanPham.gianhap, 
	    ThongKeNhapXuat.giaban = SanPham.giaban
	FROM ThongKeNhapXuat
	INNER JOIN SanPham
	ON (ThongKeNhapXuat.masanpham = SanPham.masanpham)
GO
--
CREATE PROC CapNhatSoLuongSPBaoCao
AS
    UPDATE ThongKeNhapXuat 
	SET soluongban = (SELECT 100 - sotonkho
		              FROM SanPham
				      WHERE ThongKeNhapXuat.masanpham = SanPham.masanpham)
	WHERE thang = thang;
GO
--
CREATE PROC CapNhatTen_ThangBCNX
AS 
      UPDATE ThongKeNhapXuat
	  SET ThongKeNhapXuat.tennhanvien = BaoCaoThongKe.tennhanvien,
	      ThongKeNhapXuat.thang = BaoCaoThongKe.thang
	  FROM ThongKeNhapXuat
	  INNER JOIN BaoCaoThongKe
	  ON (ThongKeNhapXuat.mabaocao = BaoCaoThongKe.mabaocao)
GO
--
CREATE PROC CapNhatTienBCTC
AS
    UPDATE ThongKeThuChi 
	SET sotienchi = (SELECT SUM(soluongnhap * gianhap)
		             FROM ThongKeNhapXuat
				     WHERE ThongKeNhapXuat.mabaocao = ThongKeThuChi.mabaocao),
		sotienthu = (SELECT SUM(soluongban * giaban)
		             FROM ThongKeNhapXuat
				     WHERE ThongKeNhapXuat.mabaocao = ThongKeThuChi.mabaocao)
	Where mabaocao = mabaocao
GO
--
CREATE PROC CapNhatTenBCTC
AS 
      UPDATE ThongKeThuChi
	  SET ThongKeThuChi.tennhanvien = BaoCaoThongKe.tennhanvien
	  FROM ThongKeThuChi
	  INNER JOIN BaoCaoThongKe
	  ON (ThongKeThuChi.mabaocao = BaoCaoThongKe.mabaocao)
GO
--
EXEC CapNhatTenNVVaoHoaDon
--
EXEC CapNhatBangCTHoaDon
--
EXEC ThanhTien
--
EXEC TongHoaDon_TienCoc_CanThanhToan
--
EXEC CapNhatBCTK
--
EXEC CapNhatTen_ThangBCNX
--
EXEC Cap_Nhat_Hang_Ton_Kho
--
EXEC CapNhatTen_GiaBaoCao
--
EXEC CapNhatSoLuongSPBaoCao
--
SELECT *
FROM HoaDon;
--
SELECT *
FROM CTHoaDon;
--
SELECT *
FROM SanPham;
--
SELECT *
FROM BaoCaoThongKe;
--
SELECT *
FROM ThongKeNhapXuat;
--
EXEC CapNhatTienBCTC
--
EXEC CapNhatTenBCTC
--
SELECT *
FROM ThongKeThuChi;
--
ALTER TABLE CTHoaDon 
  ADD CONSTRAINT XoaHD_CTHD 
  FOREIGN KEY (mahoadon) 
  REFERENCES HoaDon(mahoadon) 
ON DELETE CASCADE;

ALTER TABLE ThongKeThuChi
  ADD CONSTRAINT XoaBC_TC
  FOREIGN KEY (mabaocao) 
  REFERENCES BaoCaoThongKe(mabaocao) 
ON DELETE CASCADE;

-- HIỂN THỊ BẢNG BÁO CÁO THỐNG KÊ
SELECT *
FROM BaoCaoThongKe; 

-- HIỂN THỊ BẢNG THỐNG KÊ NHẬP XUẤT
SELECT *
FROM ThongKeNhapXuat; 

-- HIỂN THỊ BẢNG THỐNG KÊ THU CHI
SELECT *
FROM ThongKeThuChi; 
------------------------------------------------------------------------------
------------------------------------------------------------------------------
-- XOÁ THÀNH PHẦN TRONG BẢNG
DELETE FROM ThongKeNhapXuat
WHERE manhapxuat = 'NX03';
------------------------------------------------------------------------------
------------------------------------------------------------------------------
-- XOÁ CỘT TRONG BẢNG
ALTER TABLE CTHoaDon
DROP COLUMN tenkhachhang;
------------------------------------------------------------------------------
------------------------------------------------------------------------------
-- THÊM TÊN CỘT
ALTER TABLE ThongKeNhapXuat
ADD giaban float;
------------------------------------------------------------------------------
------------------------------------------------------------------------------
-- Cập nhật hàng vào trong kho sau khi đã bán hoặc cập nhật
CREATE TRIGGER trg_BanHang ON CTHoaDon AFTER INSERT AS 
BEGIN
	UPDATE SanPham
	SET sotonkho = sotonkho - (
		SELECT soluong
		FROM inserted
		WHERE masanpham = SanPham.masanpham
	)
	FROM SanPham
	JOIN inserted ON SanPham.masanpham = inserted.masanpham
END
GO

-- Cập nhật hàng trong số tồn kho sau khi cập nhật chi tiết hoá đơn
CREATE TRIGGER trg_CapNhatSoTonKho on CTHoaDon after update AS
BEGIN
   UPDATE SanPham SET sotonkho = sotonkho - (SELECT soluong FROM inserted WHERE masanpham = SanPham.masanpham) +
	                                        (SELECT soluong FROM deleted WHERE masanpham = SanPham.masanpham)
   FROM SanPham 
   JOIN deleted ON SanPham.masanpham = deleted.masanpham
end
GO




-- Cập nhật hàng trong kho sau khi hủy đơn hàng
create TRIGGER trg_HuyDonHang ON CTHoaDon FOR DELETE AS 
BEGIN
	UPDATE SanPham
	SET sotonkho = sotonkho + (SELECT soluong FROM deleted WHERE masanpham = SanPham.masanpham)
	FROM SanPham 
	JOIN deleted ON SanPham.masanpham = deleted.masanpham
END
--

CREATE TRIGGER CAPNHAT_SS ON CTHOADON
FOR INSERT
AS
DECLARE @SOLUONG INT 
DECLARE @MAHANG CHAR(10)
SET @SOLUONG=(SELECT SOLUONG FROM inserted )
SET @MAHANG=(SELECT MAHANG FROM inserted )
UPDATE HANGHOA
SET SOLUONG=(SELECT HANGHOA.SOLUONG-@SOLUONG
			 FROM CTHOADON 
			 WHERE CTHOADON.MAHANG=@MAHANG
			 GROUP BY MAHANG)


CREATE TRIGGER TG_CapNhat ON CTHoaDon
FOR INSERT
AS
DECLARE @sotonkho INT 
DECLARE @masanpham NVARCHAR(50)
SET @sotonkho = (SELECT sotonkho FROM inserted )
SET @masanpham = (SELECT masanpham FROM inserted )
UPDATE SanPham
SET sotonkho = (SELECT SanPham.sotonkho - soluong
			 FROM CTHoaDon 
			 WHERE CTHoaDon.masanpham=@masanpham
GROUP BY masanpham)


--
SELECT *
FROM CTHoaDon;
--
SELECT *
FROM SanPham;




-- Xoá trigger
USE BachHacTraQuan
GO
DROP TRIGGER trg_BanHang
GO
-- 