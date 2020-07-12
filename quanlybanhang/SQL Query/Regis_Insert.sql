
Create Proc Regis_Insert
(@UserName varchar(100)
,@Password varchar(20)
,@NameOfUser nvarchar(100)
,@DateOfBirth date
,@Phone varchar(10)
,@Adress nvarchar(300)
,@Sex nvarchar(50)
,@Email varchar(100))
As
INSERT INTO [DangKyNDangNhap]
([UserName]
,[Password]
,[NameOfUser]
,[DateOfBirth]
,[Phone]
,[Adress]
,[Sex]
,[Email]
,[Status])
Values
(@UserName
,@Password
,@NameOfUser
,@DateOfBirth
,@Phone
,@Adress
,@Sex
,@Email
,N'Chưa kích hoạt')
Go
