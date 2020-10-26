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
as 
  declare @ma nchar(5)
set @ma =dbo.SinhMA('PP','Phong')
  if exists(select * from Phong where MaPhong =@ma) 
        begin    
	     print N'Exists Ma Phong :' +@ma
		 end
		 else
		 begin
		 if  not exists(select * from Phong where TenPhong =@tenPhong)
		 begin
		   insert into Phong values(@ma,@tenPhong,@loaiPhong,@gia,@chuThich,0)
		  print N'Insert Success'
		  end
		  else
		    print N'Ten Phong bi trung, nhap lai!'
      	end
exec usp_Insert_Phong '302','2 nguoi',12000,null
select * from Phong
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
drop proc usp_datPhong
create proc usp_datPhong
@maphong nchar(100)
,@maKH nchar(100),@ngayNhan smalldatetime,@ngayTra smalldatetime
as
begin

  if exists(select * from Phong where MaPhong =@maphong) and exists(select * from KhachHang where MaKH =@maKH)
     and exists (select * from Phong where TinhTrang =0)
     begin
	 insert into DatPhong values (@maphong,@maKH,@ngayNhan,@ngayTra)
	 print N'Insert Success'
     end
	 else
	 print N'Fail not exists: ' + @maKH +' va'+ @maphong
	 end
	 set dateformat dmy 
exec usp_datPhong 'PP001','KH001','20/10/2020','23/10/2020'
--update Dat Phong
select * from DatPhong
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

--liet ke DS Phong theo tinh trang
select * from Phong
drop proc usp_Show_All_Phong_Theo_TinhTrang
create proc usp_Show_All_Phong_Theo_TinhTrang
@tinhtrang bit
as 
  begin
 select * from Phong where TinhTrang =@tinhtrang
 end
 exec usp_Show_All_Phong_Theo_TinhTrang 0

 drop proc usp_tinh_tien_suDung_dichVu
-- tinh tien su dung dich vu tai phong nao do
create proc usp_tinh_tien_suDung_dichVu
 @maPhong nchar(100)
 as
 --Sum((B.DonGia *C.SoLuongDat)) as N'Tong thanh tien' ,
   if exists (select * from Phong where MaPhong =@maPhong)
	 begin
	     select  D.MaKH,B.DonGia,C.SoLuongDat , C.TenDV, (B.DonGia *C.SoLuongDat) as N'Tong thanh tien' 
		-- (B.DonGia *C.SoLuongDat) as N'Tung Loai'
		 from Phong A ,CT_DichVu B,KhachHangThueDichVu C,DatPhong D
		 where A.MaPhong =D.MaPhong  and D.MaPhong=@maPhong  and D.MaKH = C.MaKH  and C.MaLoaiDV =B.MaLoaiDV
	    --group by A.MaPhong,C.TenDV
	end

select * from Phong
 select * from DatPhong
 select * from KhachHangThueDichVu
 select * from CT_DichVu
 -- insert khach hang

 drop proc usp_insert_khachhang
 create proc usp_insert_khachhang

@TenKH nvarchar(1000),
@CMND nchar(10),
@QuocTich nvarchar(100),
@GioiTinh bit,
@Tuoi int,
@SDT int
as
 begin
 declare  @MaKH nchar(5)
 set @MaKH = dbo.SinhMA('KH','KhachHang')
 if not exists(select * from KhachHang where MaKH = @MaKh)
 begin
    
	insert into KhachHang values(@MaKH ,@TenKH, @CMND,@QuocTich , @GioiTinh, @Tuoi, @SDT)
	print N'Thêm khách hàng thành công'
 end
 else
 print N'Đã có mã khách' + @MaKH + N' trong cơ sở dữ liệu'
end
go
select * from KhachHang
exec usp_insert_khachhang 'nguyen tuan' ,'09876556','Viet Nam',1,18,0949238337


create proc usp_Insert_KHDV
@mkh nchar(100),
@maloaiDV nchar(100),
@soluongdat int,
@tendv nvarchar(500)
as

 if exists(select * from KhachHang where MaKH = @mkh) and exists (select * from CT_DichVu where MaLoaiDV = @maloaiDV)
	begin
	declare @mathuedichvu nchar(5)

	set @mathuedichvu = dbo.SinhMA('MT','KhachHangThueDichVu')
	if not exists(select * from KhachHangThueDichVu where MaThueDV = @mathuedichvu)
		begin
		insert into dbo.KhachHangThueDichVu values(@mkh, @maloaiDV, @soluongdat, @tendv, @mathuedichvu)
		print N'Insert Success'
		end
	else
	 print N'Exist '+@mathuedichvu
	end
else
	print 'Not exist '+ @mkh +' '+ @mathuedichvu

	exec usp_Insert_KHDV 'KH001','LV001', 4 , 'cocacola'
	exec usp_Insert_KHDV 'KH001','LV002', 4 , 'pepsi'





