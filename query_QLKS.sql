-- xoá function
if exists(
           select * from sysobjects where id = OBJECT_ID(N'SinhMA_table')
		   and xtype in (N'FN', N'IF', N'TF'))
		   drop function SinhMA_table
go


--sinh mã tự động cho khách hàng có truyền tham số
 create function SinhMA_table(@ma nchar(2), @NameTable nvarchar(1000)) 
 
 returns nchar(5)

As
Begin
	declare @MaxMA nchar(5)
	declare @NewMA varchar(5)
	declare @stt	int
	declare @i	int	
	declare @sokytu	int

	 if(@NameTable ='CT_DichVu')
	begin
	if exists(select * from CT_DichVu )---Nếu bảng hóa đơn có dữ liệu
	 begin
		--Lấy mã giáo viên lớn nhất hiện có
		select @MaxMA = max(MaLoaiDV) 
		from CT_DichVu
		--Trích phần ký số của mã lớn nhất và chuyển thành số 
		set @stt=convert(int, right(@MaxMA,3)) + 1 --Số thứ tự của giáo viên mới
	 end
	  	  
	else--Nếu bảng giáo viên đang rỗng (nghĩa là chưa có giáo viên nào được lưu trữ trong CSDL.
	 set @stt= 1 -- Số thứ tự của giáo viên trong trường hợp chưa có gv nào trong CSDL
	--Kiểm tra và bổ sung chữ số 0 để đủ 3 ký số trong mã gv.
	set @sokytu = len(convert(varchar(3), @stt))
	set @NewMA= @ma
	set @i = 0
	while @i < 3 -@sokytu
		begin
			set @NewMA = @NewMA + '0'
			set @i = @i + 1
		end	
	set @NewMA = @NewMA + convert(varchar(3), @stt)
	end

	if(@NameTable ='Phong')
	begin
	if exists(select * from Phong )---Nếu bảng hóa đơn có dữ liệu
	 begin
		--Lấy mã giáo viên lớn nhất hiện có
		select @MaxMA = max(MaPhong) 
		from Phong
		--Trích phần ký số của mã lớn nhất và chuyển thành số 
		set @stt=convert(int, right(@MaxMA,3)) + 1 --Số thứ tự của giáo viên mới
	 end
	  
	  else--Nếu bảng giáo viên đang rỗng (nghĩa là chưa có giáo viên nào được lưu trữ trong CSDL.
	 set @stt= 1 -- Số thứ tự của giáo viên trong trường hợp chưa có gv nào trong CSDL
	--Kiểm tra và bổ sung chữ số 0 để đủ 3 ký số trong mã gv.
	set @sokytu = len(convert(varchar(3), @stt))
	set @NewMA= @ma
	set @i = 0
	while @i < 3 -@sokytu
		begin
			set @NewMA = @NewMA + '0'
			set @i = @i + 1
		end	
	set @NewMA = @NewMA + convert(varchar(3), @stt)
	  end
	  if(@NameTable ='KhachHangThueDichVu')
	begin
	if exists(select * from KhachHangThueDichVu )---Nếu bảng hóa đơn có dữ liệu
	 begin
		--Lấy mã giáo viên lớn nhất hiện có
		select @MaxMA = max(MaThueDV) 
		from KhachHangThueDichVu
		--Trích phần ký số của mã lớn nhất và chuyển thành số 
		set @stt=convert(int, right(@MaxMA,3)) + 1 --Số thứ tự của giáo viên mới
	 end
	  
	  else--Nếu bảng giáo viên đang rỗng (nghĩa là chưa có giáo viên nào được lưu trữ trong CSDL.
	 set @stt= 1 -- Số thứ tự của giáo viên trong trường hợp chưa có gv nào trong CSDL
	--Kiểm tra và bổ sung chữ số 0 để đủ 3 ký số trong mã gv.
	set @sokytu = len(convert(varchar(3), @stt))
	set @NewMA= @ma
	set @i = 0
	while @i < 3 -@sokytu
		begin
			set @NewMA = @NewMA + '0'
			set @i = @i + 1
		end	
	set @NewMA = @NewMA + convert(varchar(3), @stt)
	  end
	if (@NameTable ='KhachHang')
	begin
	if exists(select * from KhachHang )---Nếu bảng hóa đơn có dữ liệu
	 begin
		--Lấy mã giáo viên lớn nhất hiện có
		select @MaxMA = max(MaKH) 
		from KhachHang
		--Trích phần ký số của mã lớn nhất và chuyển thành số 
		set @stt=convert(int, right(@MaxMA,3)) + 1 --Số thứ tự của giáo viên mới
	 end
	else--Nếu bảng giáo viên đang rỗng (nghĩa là chưa có giáo viên nào được lưu trữ trong CSDL.
	 set @stt= 1 -- Số thứ tự của giáo viên trong trường hợp chưa có gv nào trong CSDL
	--Kiểm tra và bổ sung chữ số 0 để đủ 3 ký số trong mã gv.
	set @sokytu = len(convert(varchar(3), @stt))
	set @NewMA= @ma
	set @i = 0
	while @i < 3 -@sokytu
		begin
			set @NewMA = @NewMA + '0'
			set @i = @i + 1
		end	
	set @NewMA = @NewMA + convert(varchar(3), @stt)
	end


	if(@NameTable ='HoaDon')
	begin
	if exists(select * from HoaDon )---Nếu bảng hóa đơn có dữ liệu
	 begin
		--Lấy mã giáo viên lớn nhất hiện có
		select @MaxMA = max(MaHD) 
		from HoaDon
		--Trích phần ký số của mã lớn nhất và chuyển thành số 
		set @stt=convert(int, right(@MaxMA,3)) + 1 --Số thứ tự của giáo viên mới
	 end
	else--Nếu bảng giáo viên đang rỗng (nghĩa là chưa có giáo viên nào được lưu trữ trong CSDL.
	 set @stt= 1 -- Số thứ tự của giáo viên trong trường hợp chưa có gv nào trong CSDL
	--Kiểm tra và bổ sung chữ số 0 để đủ 3 ký số trong mã gv.
	set @sokytu = len(convert(varchar(3), @stt))
	set @NewMA= @ma
	set @i = 0
	while @i < 3 -@sokytu
		begin
			set @NewMA = @NewMA + '0'
			set @i = @i + 1
		end	
	set @NewMA = @NewMA + convert(varchar(3), @stt)
	end
	 if(@NameTable ='KhachHangThueDichVu')
	begin
	if exists(select * from KhachHangThueDichVu )---Nếu bảng hóa đơn có dữ liệu
	 begin
		--Lấy mã giáo viên lớn nhất hiện có
		select @MaxMA = max(MaThueDV) 
		from KhachHangThueDichVu
		--Trích phần ký số của mã lớn nhất và chuyển thành số 
		set @stt=convert(int, right(@MaxMA,3)) + 1 --Số thứ tự của giáo viên mới
	 end
	  
	  else--Nếu bảng giáo viên đang rỗng (nghĩa là chưa có giáo viên nào được lưu trữ trong CSDL.
	 set @stt= 1 -- Số thứ tự của giáo viên trong trường hợp chưa có gv nào trong CSDL
	--Kiểm tra và bổ sung chữ số 0 để đủ 3 ký số trong mã gv.
	set @sokytu = len(convert(varchar(3), @stt))
	set @NewMA= @ma
	set @i = 0
	while @i < 3 -@sokytu
		begin
			set @NewMA = @NewMA + '0'
			set @i = @i + 1
		end	
	set @NewMA = @NewMA + convert(varchar(3), @stt)
	  end
return @NewMA
   
End


--PROC PHÒNG

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
 set @MaKH = dbo.SinhMA_table('KH','KhachHang')
 if not exists(select * from KhachHang where MaKH = @MaKh)
 begin
    
	insert into KhachHang values(@MaKH ,@TenKH, @CMND,@QuocTich , @GioiTinh, @Tuoi, @SDT)
	print N'Thêm khách hàng thành công'
 end
 else
 print N'Đã có mã khách' + @MaKH + N' trong cơ sở dữ liệu'
end
go

--update khách hàng
create proc usp_Update_KH
@makh nchar(100),
@tenkh nvarchar(1000),
@cmnd nchar(10),
@quoctich nvarchar(100),
@gt bit,
@tuoi int,
@sdt int
as
	if exists(select * from KhachHang where MaKH = @makh )
	 begin 
		Update KhachHang
		set TenKH =@tenkh, CMND = @cmnd, QuocTich =@quoctich, GioiTinh =@gt, Tuoi = @tuoi, SDT = @sdt
		where MaKH = @makh
		print N'Update success'
	 end
	else
	 print N'Not exist '+ @makh + N' trong cơ sở dữ liệu'
go

exec usp_Update_KH 'KH0010',N'nguyen dinh','000011111', 'trung na',0, 12,123123 

-- delete khách hàng 

create proc usp_Delete_KH
@makh nchar(100)
as
	if not exists(select * from DatPhong where MaKH = @makh) and not exists (select * from HoaDon where MaKH = @makh) 
		if exists(select * from KhachHang where MaKH = @makh)
		begin
			delete from KhachHang where MaKH = @makh
			print N'Delete success'
		end
	else
	 print N'Not exist '+@makh
go
exec usp_Delete_KH 'KH002'

 -- thêm dữ liệu phòng
exec usp_insert_khachhang N'Tân Ngáo đá ', '09090090', N'Việt Nam', 0, 20, 0909190011


--khách hàng
select * from KhachHang
delete from KhachHang

drop proc usp_insert_HoaDon
create proc usp_insert_HoaDon
@MaKH nchar(100),
@NgayXuatHD smalldatetime,
@ThanhTien int
as
	declare @MAHD nchar(100)
	set @MAHD = dbo.SinhMA_table('HD','HoaDon')
	begin
	if exists(select * from KhachHang where MaKH = @MaKH)
		if not exists(select * from dbo.HoaDon where MaHD = @MAHD)
		begin
			insert into  dbo.HoaDon values (@MAHD, @MaKH, @NgayXuatHD, @ThanhTien)
			print N'Thêm hoá đơn thành công'
		end
		else
		 print N'Đã có '+@MAHD+N' trong cơ sỏ dữ liệu'
	else print N'Không có '+@MaKH+N' trong cơ sỏ dữ liệu'
end

set dateformat dmy
exec usp_insert_HoaDon 'KH002','12/2/2020',35000000

select *from HoaDon

create proc usp_Update_HoaDon
@MAHD nchar(100),
@MaKH nchar(100),
@NgayXuatHD smalldatetime,
@ThanhTien int
as
 if exists(select * from HoaDon where MaHD = @MAHD)
	begin 
		Update HoaDon
		set MaKH = @MaKH, NgayXuatHD = @NgayXuatHD, ThanhTien = @ThanhTien
		where MaHD = @MAHD
		print N'Update sucess'
	end
else print N'Not Exist '+ @MAHD
go
--update hoá đơn

create proc usp_Delete_HoaDon
@MAHD nchar(100)
as
	if exists(select * from HoaDon where MaHD = @MAHD)
		begin
			Delete from HoaDon where MaHD = @MAHD
			print N'Delete sucess'
		end
	else Print 'Not exist '+ @MAHD
go


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
set @ma =dbo.SinhMA_table('PP','Phong')
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
exec usp_Insert_Phong '302','2 nguoi',12000,null,1  
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
set dateformat dmy
exec usp_datPhong 'PP002','KH002' ,'20/10/2000', '23/10/2020'
select *from DatPhong

--update Dat Phong
    drop proc usp_DatPhong
  create proc usp_Update_DatPhong
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
exec usp_DichVu 'NN','Nuoc Ngot'

create proc usp_Update_DV
@maDV nchar(100)
,@tenDV nvarchar(1000)
as 
if exists(select * from DichVu where MaDV = @maDV)
	begin
		update DichVu
		set TenDV = @tenDV
		where MaDV = @maDV
		print N'Update sucess'
	end
	else
	print N'Not exist '+ @maDV
go

--Delete dich vu

create proc usp_Delete_Dv
@maDV nchar(100)
as
	if not exists(select * from CT_DichVu where MaDV = @maDV )
		if exists(select * from DichVu where MaDV = @maDV)
	begin
		delete from DichVu where MaDV = @maDV
		print N'Delete sucess'
	end
	else
	 print N'Not exist'+ @maDV
go

--CT_DichVu

create proc usp_CT_DichVu
 @tenLoaiDV nchar(100)
,@donGia int , @donvi nvarchar(50),@maDV nchar(100)
as
begin
  declare @maloaiDV nchar(5)
  set @maloaiDV =dbo.SinhMA_table('LV','CT_DichVu')
  if exists(select * from DichVu where MaDV =@maDV) 
     begin
	insert into CT_DichVu values (@maloaiDV,@tenLoaiDV,@donGia,@donvi,@maDV)
	 print N'Insert Success'
     end
	 else
	 print N'Fail not exists: ' + @maDV
	 
end
exec usp_CT_DichVu 'cocacola',7000,lon,'NN'

select * from CT_DichVu

--update dich
create proc usp_Update_CTDV
@maLoaiDV nvarchar(100),
 @tenLoaiDV nchar(100)
,@donGia int , @donvi nvarchar(50)
as
 if exists(select * from CT_DichVu where MaLoaiDV = @maLoaiDV)
	begin
	update CT_DichVu
	set TenLoaiDv =@tenLoaiDV, DonGia = @donGia where MaLoaiDV = @maLoaiDV
	print N'Update sucess'
	end
else print N'Not exist '+@maLoaiDV
go

exec usp_Update_CTDV 'LV002', 'pepsi', 12000, 'lon'

--delete chi tiết dịch vụ
create proc usp_Delete_CTDV
@maLoaiDV nvarchar(100)
as
	if exists(select * from CT_DichVu where MaLoaiDV = @maLoaiDV)
	 begin
		delete from CT_DichVu where MaLoaiDV = @maLoaiDV
		print N'Delete Sucess'
	 end
	else
	print N'Not exist '+@maLoaiDV
go

-- khách hàng thuê dich cụ
drop  usp_Insert_KHDV
create proc usp_Insert_KHDV
@mkh nchar(100),
@maloaiDV nchar(100),
@soluongdat int,
@tendv nvarchar(500)
as

 if exists(select * from KhachHang where MaKH = @mkh) and exists (select * from CT_DichVu where MaLoaiDV = @maloaiDV)
	begin
	declare @mathuedichvu nchar(5)

	set @mathuedichvu = dbo.SinhMA_table('MT','KhachHangThueDichVu')
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

	select * from CT_DichVu
	select * from KhachHang
------ Update khách hàng thuê dịch vụ
drop proc usp_Update_KHThueDichVu
create proc usp_Update_KHThueDichVu
@makh nchar(100),
@mathuedichvu nchar(100),
@maloaiDV nchar(100),
@slDat int,
@tenDV nvarchar(500)
as
	if exists(select * from CT_DichVu where MaLoaiDV = @maloaiDV and TenLoaiDv =@tenDV) and exists(select * from dbo.KhachHang where MaKH = @makh)
	begin
	 if exists(select * from dbo.KhachHangThueDichVu where MaThueDV = @mathuedichvu )
		begin 
			update dbo.KhachHangThueDichVu 
			set TenDV = @tenDV, SoLuongDat =@slDat, MaLoaiDV = @maloaiDV
			where MaThueDV = @mathuedichvu
			print 'Update sucess'
		end
	else print 'Not exist '+  @mathuedichvu
	end
	else print 'Not exist ' + @maloaiDV +' or '+@makh
go

exec usp_Update_KHThueDichVu 'KH001', 'MT001', 'LV001',3 ,'cocacola'

select * from KhachHangThueDichVu

---Delete khách hàng thuê dich vụ
create proc usp_Delete_KHThueDichVu
@mathuedichvu nchar(100)
as
 if not exists(select * from dbo.CT_HoaDon where MaThueDV = @mathuedichvu)
	begin
		Delete from KhachHangThueDichVu where MaThueDV = @mathuedichvu
		print 'Delete Sucess'
	end
else print 'Existed ' +@mathuedichvu +' in table HoaDon'


--liệt kê danh sách phòng/ khách hàng sử dụng dịch một dịch vụ nào đó
create proc usp_lietkeDSDV
@tenLoaiDV nvarchar(500)

as
	begin
		select A.TenKH,  B.TenDV, C.TenPhong
		from KhachHang A, KhachHangThueDichVu B, Phong C, DatPhong D
		where B.TenDV = @tenLoaiDV and  A.MaKH = B.MaKH and C.MaPhong = D.MaPhong and A.MaKH = D.MaKH and B.MaKH =D.MaKH 
		
	end
go

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



select *from CT_DichVu
select *from Phong
select * from KhachHangThueDichVu
select * from DatPhong


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
exec usp_tinh_tien_suDung_dichVu 'PP001'

	


