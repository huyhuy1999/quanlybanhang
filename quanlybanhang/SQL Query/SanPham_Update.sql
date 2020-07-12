Create proc SPham_Update
@MaSP varchar(10),
@TenSP nvarchar(50),
@Gia int,
@NCC nvarchar(20),
@LoaiSP nvarchar(20),
@MoTa nvarchar(100),
@SoLuong int,
@Donvidoluong nvarchar(10)
AS
UPDATE SanPham
   SET MaSP=@MaSP
		,TenSP=@TenSP
		,Gia=@Gia
		,NCC=@NCC
		,LoaiSP=@LoaiSP
		,MoTa=@MoTa
		,SoLuong=@SoLuong
		,Donvidoluong=@Donvidoluong
      
 WHERE MaSP=@MaSP
GO
