Create proc KH_UpdateTongTien
@SDT varchar(11),
@TongTien int
AS

UPDATE KhachHang
		
   SET SDT=@SDT
		,TongTien=@TongTien
      
 WHERE SDT=@SDT
GO
