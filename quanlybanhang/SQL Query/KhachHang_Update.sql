Create proc KhachHang_Update
@MaKH varchar(10),
@TenKH nvarchar(100),
@SDT varchar(10)
AS

UPDATE KhachHang
		
   SET MaKH=@MaKH,
   TenKH=@TenKH
		,SDT=@SDT
      
 WHERE MaKH=@MaKH
GO
