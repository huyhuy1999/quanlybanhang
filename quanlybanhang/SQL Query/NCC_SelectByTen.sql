Create proc NCC_SelectByTen
@NCC nvarchar(100)
AS
Select NCC from NhaCC
Where NCC=@NCC