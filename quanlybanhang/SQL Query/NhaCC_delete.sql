Create proc NhaCC_delete
@MaNCC varchar(50)
As
DELETE FROM NhaCC
      WHERE MaNCC=@MaNCC