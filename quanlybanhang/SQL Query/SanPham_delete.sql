Create proc SanPham_delete
@MaSP nvarchar(10)
As
DELETE FROM SanPham
      WHERE MaSP=@MaSP