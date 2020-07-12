Create proc LoaiSPham_Update
@MaLoai varchar(10),
@LoaiSP nvarchar(20)
AS

UPDATE LoaiSP
   SET MaLoai=@MaLoai
		,LoaiSP=@LoaiSP
      
 WHERE MaLoai=@MaLoai
GO
