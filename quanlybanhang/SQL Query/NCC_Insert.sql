Create proc NCC_Insert
(@MaNCC varchar(50)
,@NCC nvarchar(100)
)
AS
INSERT INTO [NhaCC]
           ([MaNCC]
           ,[NCC]
		   )
     VALUES
           (
		   @MaNCC
		,@NCC)
GO