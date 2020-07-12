Create proc KhachHang_SelectBySDT
@SDT varchar(11)
AS
Select SDT from KhachHang
Where SDT=@SDT