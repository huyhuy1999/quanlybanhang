USE [QLBH]
GO
/****** Object:  StoredProcedure [dbo].[KhachHang_TichDiem]    Script Date: 28-Jan-19 2:45:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[KhachHang_TichDiem]
@TongTien int,
@TichDiem int
AS

UPDATE KhachHang
		
   SET TichDiem=TongTien/1000000
