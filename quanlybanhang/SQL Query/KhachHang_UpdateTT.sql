Create proc KhachHang_UpdateTT
@MaKH varchar(10),
@TenKH nvarchar(100),
@SDT varchar(10),
@TongTien int,
@TichDiem int
AS

UPDATE KhachHang
		
   SET TongTien=TongTien+@TongTien
      
 WHERE SDT=@SDT
GO
