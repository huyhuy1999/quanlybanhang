Create proc LoaiSanPham_delete
@MaLoai varchar(10)
As
DELETE FROM LoaiSP
      WHERE MaLoai=@MaLoai