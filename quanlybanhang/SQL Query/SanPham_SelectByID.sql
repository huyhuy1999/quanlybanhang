Create proc SanPham_SelectByID
@MaSP varchar(10)
AS
Select MaSP from SanPham
Where MaSP=@MaSP