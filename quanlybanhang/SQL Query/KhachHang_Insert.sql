Create proc KH_Insert
(@MaKH varchar(10)
,@TenKH nvarchar(100)
,@SDT varchar(10)
,@TongTien int
,@TichDiem int
)
AS
INSERT INTO [KhachHang]
           ([MaKH]
           ,[TenKH]
		   ,[SDT]
		   ,[TongTien]
		   ,[TichDiem]
		   )
     VALUES
           (
		   @MaKH
		,@TenKH
		,@SDT
		,@TongTien
		,@TichDiem
		)
GO