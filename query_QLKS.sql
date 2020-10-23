--sinh ma auto
IF EXISTS (
    SELECT * FROM sysobjects WHERE id = object_id(N'SinhMA') 
    AND xtype IN (N'FN', N'IF', N'TF')
)
    DROP FUNCTION SinhMA
GO


create function SinhMA(@ma nchar (2),@tableName nvarchar(100)) 
 returns char(5)

As
Begin
	declare @MaxMAHD char(5)
	declare @NewMAHD varchar(5)
	declare @stt	int
	declare @i	int	
	declare @sokytu	int
	
	if(@tableName ='Phong')
	begin
	if exists(select * from Phong )---Nếu bảng hóa đơn có dữ liệu
	 begin
		--Lấy mã giáo viên lớn nhất hiện có
		select @MaxMAHD = max(MaPhong) 
		from Phong
		--Trích phần ký số của mã lớn nhất và chuyển thành số 
		set @stt=convert(int, right(@MaxMAHD,3)) + 1 --Số thứ tự của giáo viên mới
	 end
	  
	  else--Nếu bảng giáo viên đang rỗng (nghĩa là chưa có giáo viên nào được lưu trữ trong CSDL.
	 set @stt= 1 -- Số thứ tự của giáo viên trong trường hợp chưa có gv nào trong CSDL
	--Kiểm tra và bổ sung chữ số 0 để đủ 3 ký số trong mã gv.
	set @sokytu = len(convert(varchar(3), @stt))
	set @NewMAHD= @ma
	set @i = 0
	while @i < 3 -@sokytu
		begin
			set @NewMAHD = @NewMAHD + '0'
			set @i = @i + 1
		end	
	set @NewMAHD = @NewMAHD + convert(varchar(3), @stt)
	  end
	  if(@tableName ='KhachHangThueDichVu')
	begin
	if exists(select * from KhachHangThueDichVu )---Nếu bảng hóa đơn có dữ liệu
	 begin
		--Lấy mã giáo viên lớn nhất hiện có
		select @MaxMAHD = max(MaThueDV) 
		from KhachHangThueDichVu
		--Trích phần ký số của mã lớn nhất và chuyển thành số 
		set @stt=convert(int, right(@MaxMAHD,3)) + 1 --Số thứ tự của giáo viên mới
	 end
	  
	  else--Nếu bảng giáo viên đang rỗng (nghĩa là chưa có giáo viên nào được lưu trữ trong CSDL.
	 set @stt= 1 -- Số thứ tự của giáo viên trong trường hợp chưa có gv nào trong CSDL
	--Kiểm tra và bổ sung chữ số 0 để đủ 3 ký số trong mã gv.
	set @sokytu = len(convert(varchar(3), @stt))
	set @NewMAHD= @ma
	set @i = 0
	while @i < 3 -@sokytu
		begin
			set @NewMAHD = @NewMAHD + '0'
			set @i = @i + 1
		end	
	set @NewMAHD = @NewMAHD + convert(varchar(3), @stt)
	  end
	  if(@tableName ='KhachHang')
	begin
	if exists(select * from KhachHang )---Nếu bảng hóa đơn có dữ liệu
	 begin
		--Lấy mã giáo viên lớn nhất hiện có
		select @MaxMAHD = max(MaKH) 
		from DatPhong
		--Trích phần ký số của mã lớn nhất và chuyển thành số 
		set @stt=convert(int, right(@MaxMAHD,3)) + 1 --Số thứ tự của giáo viên mới
	 end
	  	  
	else--Nếu bảng giáo viên đang rỗng (nghĩa là chưa có giáo viên nào được lưu trữ trong CSDL.
	 set @stt= 1 -- Số thứ tự của giáo viên trong trường hợp chưa có gv nào trong CSDL
	--Kiểm tra và bổ sung chữ số 0 để đủ 3 ký số trong mã gv.
	set @sokytu = len(convert(varchar(3), @stt))
	set @NewMAHD= @ma
	set @i = 0
	while @i < 3 -@sokytu
		begin
			set @NewMAHD = @NewMAHD + '0'
			set @i = @i + 1
		end	
	set @NewMAHD = @NewMAHD + convert(varchar(3), @stt)
	end
	 if(@tableName ='CT_DichVu')
	begin
	if exists(select * from CT_DichVu )---Nếu bảng hóa đơn có dữ liệu
	 begin
		--Lấy mã giáo viên lớn nhất hiện có
		select @MaxMAHD = max(MaLoaiDV) 
		from CT_DichVu
		--Trích phần ký số của mã lớn nhất và chuyển thành số 
		set @stt=convert(int, right(@MaxMAHD,3)) + 1 --Số thứ tự của giáo viên mới
	 end
	  	  
	else--Nếu bảng giáo viên đang rỗng (nghĩa là chưa có giáo viên nào được lưu trữ trong CSDL.
	 set @stt= 1 -- Số thứ tự của giáo viên trong trường hợp chưa có gv nào trong CSDL
	--Kiểm tra và bổ sung chữ số 0 để đủ 3 ký số trong mã gv.
	set @sokytu = len(convert(varchar(3), @stt))
	set @NewMAHD= @ma
	set @i = 0
	while @i < 3 -@sokytu
		begin
			set @NewMAHD = @NewMAHD + '0'
			set @i = @i + 1
		end	
	set @NewMAHD = @NewMAHD + convert(varchar(3), @stt)
	end

return @NewMAHD
End
--Phong
select * from Phong
drop proc usp_Insert_Phong
go
create proc usp_Insert_Phong
@tenPhong nvarchar(500),@loaiPhong varchar(100),@gia int ,@chuThich nvarchar(1000)
, @tinhtrang nvarchar(100)
as 
begin
  declare @ma nchar(5)
begin
set @ma =dbo.SinhMA('PP','Phong')
  if exists(select * from Phong where MaPhong =@ma)
        begin    
	     print N'Exists Ma Phong :' +@ma
		 end
		 else
		 begin
		   insert into Phong values(@ma,@tenPhong,@loaiPhong,@gia,@chuThich,@tinhtrang)
		  print N'Insert Success'
		  end
	end
	end
exec usp_Insert_Phong '301','2 nguoi',12000,null,'Het Phong'  
--update phong
drop proc usp_update_Phong
create proc usp_update_Phong
@maphong nvarchar(100),@tenPhong nvarchar(500),@loaiPhong varchar(100),@gia int ,@chuThich nvarchar(1000)
, @tinhtrang nvarchar(100)
as
  if  exists (select * from Phong where MaPhong =@maphong)
     begin
	 if not exists (select * from DatPhong Where MaPhong =@maphong)
	  begin
	    update Phong
		set TenPhong =@tenPhong , LoaiPhong =@loaiPhong,Gia =@gia , ChuTich =@chuThich ,TinhTrang =@tinhtrang 
		where MaPhong =@maphong

		print N'Update success!'
		end 
		else
		  print N'Phong co nguoi o khong duoc update' 
	end
	else
		  print N'Fail exist :'+ @maphong
	 
exec usp_update_Phong 'PP001' ,'302','4 nguoi',150000,'phong 4 nguoi ','con phong'

--delete Phong
drop proc usp_delete_Phong
create proc usp_delete_Phong
@maphong nchar(100)
as
  if exists(select * from Phong where MaPhong =@maphong)
   begin
   if not exists (select * from DatPhong Where MaPhong =@maphong)
   begin
   delete 
	 from Phong
	 where MaPhong =@maphong
      print N'Delete Success'
	end
	   else
		  print N'Phong co nguoi o khong duoc update' 
	end
	else
	  print N'fail not exist :' +@maphong 
exec usp_delete_Phong 'PP001'
select * from Phong
--dat phong

create proc usp_datPhong
@maphong nchar(100)
,@maKH nchar(100),@ngayNhan smalldatetime,@ngayTra smalldatetime
as
begin

  if exists(select * from Phong where MaPhong =@maphong) and exists(select * from KhachHang where MaKH =@maKH)
     begin
	 insert into DatPhong values (@maphong,@maKH,@ngayNhan,@ngayTra)
	 print N'Insert Success'
     end
	 else
	 print N'Fail not exists: ' + @maKH +' va'+ @maphong
	 end
--update Dat Phong
    drop proc usp_DatPhong
  create proc usp_DatPhong
  @maphong nchar(100),@ngaynhan smalldatetime ,@ngaytra smalldatetime
  as
    if exists (select * from DatPhong where MaPhong =@maphong)
	  begin
	   if(Day(@ngaynhan) >DAY(@ngaytra))
	   begin
	     print N'Ngay nhan phai nho hon ngay tra'
	   end
	   else
	   begin
	   update DatPhong
	   set NgayNhan =@ngaynhan,NgayTra =@ngaytra
	   where MaPhong =@maphong
	    print N'Update Success'
	   end
	   end
	   else
       print N'Not Exists ma Phong '+@maphong
--exec usp_datPhong 
 --Delete Phong
   create proc usp_delete_DatPhong
      @maphong nchar(100)
	  as
	    if exists (select * from DatPhong where MaPhong =@maphong)
           begin
		   delete
		    from DatPhong
			where MaPhong =@maphong
			print N'Delete Success'
			end
			else
			 print N'Not Exists ma Phong '+@maphong

--Dich Vu
create proc usp_DichVu
@maDV nchar(100)
,@tenDV nvarchar(1000)
as
begin

  if not exists(select * from DichVu where MaDV =@maDV) 
     begin
	insert into DichVu values (@maDV,@tenDV)
	 print N'Insert Success'
     end
	 else
	 print N'Fail  exists: ' + @maDV
	 end
exec usp_DichVu 'MS','giat ui'

select * from DichVu
--CT_DichVu
drop proc usp_CT_DichVu
create proc usp_CT_DichVu
 @tenLoaiDV nchar(100)
,@donGia int , @donvi nvarchar(50),@maDV nchar(100)
as
begin
  declare @maloaiDV nchar(5)
  set @maloaiDV =dbo.SinhMA('LV','CT_DichVu')
  if exists(select * from DichVu where MaDV =@maDV) 
   begin
   if exists(select * from CT_DichVu  where TenLoaiDv =@tenLoaiDV)
     begin
	  print N'Fail  exists: ' + @tenLoaiDV
	 end
	 else
	 begin
	insert into CT_DichVu values (@maloaiDV,@tenLoaiDV,@donGia,@donvi,@maDV)
	 print N'Insert Success'
     end
	 end
	 else
	 print N'Fail not exists: ' + @maDV
	 
end
exec usp_CT_DichVu 'Giat men',4000,kq,'MS'

select * from CT_DichVu
delete from CT_DichVu

--Sap Xep giam bang gia dich vu
drop proc usp_SapXep_giam_Gia

create proc usp_SapXep_giam_Gia
@loaisapxep nchar(100)
as
 if(@loaisapxep ='DonGia')
  begin
select * 
from CT_DichVu A
order by DonGia desc
end
 else
    begin
	  select * 
from CT_DichVu A
order by TenLoaiDv desc
end
exec usp_SapXep_giam_Gia 'TenDV'
 --Sap Xep tang bang gia dich vu
 drop proc usp_SapXep_tang_Gia 
create proc usp_SapXep_tang_Gia
@loaisapxep nchar (100)
as

 if(@loaisapxep ='DonGia')
  begin
select * 
from CT_DichVu A
order by DonGia asc
end
 else
    begin
	  select * 
from CT_DichVu A
order by TenLoaiDv asc
end

   
exec usp_SapXep_tang_Gia 'DongGia'

