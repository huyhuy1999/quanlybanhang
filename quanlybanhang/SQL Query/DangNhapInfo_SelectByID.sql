Create proc DangNhapInfo_SelectByID
@UserName varchar(100)
as
select UserName from DangKyNDangNhap
Where UserName = @UserName
