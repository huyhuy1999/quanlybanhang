Create proc BanHang_Update
@MaSP varchar(10),
@SoLuong int
As
Update SanPham set SoLuong=@SoLuong
where MaSP=@MaSP