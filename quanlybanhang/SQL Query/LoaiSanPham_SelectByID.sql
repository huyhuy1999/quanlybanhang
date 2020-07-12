Create proc LoaiSanPham_SelectByID
@MaLoai varchar(10)
AS
Select MaLoai from LoaiSP
Where MaLoai=@MaLoai