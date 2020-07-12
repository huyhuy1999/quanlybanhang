Create proc NCC_delete
@NCC nvarchar(100)
As
DELETE FROM NhaCC
      WHERE NCC=@NCC