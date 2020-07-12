Create proc LoaiSP_Insert
(@MaLoai varchar(10)
,@LoaiSP nvarchar(20)
)
AS
INSERT INTO [LoaiSP]
           ([MaLoai]
           ,[LoaiSP]
		   )
     VALUES
           (
		   @MaLoai
		,@LoaiSP)
GO