Create proc SP_Insert
(@MaSP varchar(10)
,@TenSP nvarchar(50)
,@Gia int
,@NCC nvarchar(20)
,@LoaiSP nvarchar(20)
,@MoTa nvarchar(100)
,@SoLuong int
,@Donvidoluong nvarchar(10)
)
AS
INSERT INTO [SanPham]
           ([MaSP]
           ,[TenSP]
		   ,[Gia]
		   ,[NCC]
		   ,[LoaiSP]
		   ,[MoTa]
		   ,[SoLuong]
		   ,[Donvidoluong]
		   )
     VALUES
           (
		   @MaSP
		,@TenSP
		,@Gia
		,@NCC
		,@LoaiSP
		,@MoTa
		,@SoLuong
		,@Donvidoluong)
GO