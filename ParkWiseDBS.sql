CREATE DATABASE ParkWiseDBS


CREATE TABLE parkwiseDBS(
	user_id int primary key identity not null,
	plate_no nvarchar(50) unique not null,
	vehicle_type nvarchar(50) not null,
	vehicle_brand nvarchar(50) not null,
	parking_slot nvarchar(20) not null,
	parkin_datetime DATETIME not null
)

CREATE TABLE p_trans(
	p_id int primary key identity not null,
	p_usrlog nvarchar(100),
	p_plateNo nvarchar(100),
	p_loc nvarchar(100) null,
	p_date datetime,
	p_flagdown decimal(10,2)
)

CREATE TABLE payments(
	t_idprm int primary key identity not null,
	t_id int references p_trans(p_id),
	t_usrlog nvarchar(100),
	t_pn nvarchar(20),
	t_vt nvarchar(100),
	t_loc nvarchar(100),
	t_date datetime,
	t_payment decimal(10,2) 
)

drop table parkwiseDBS
drop table p_trans
drop table payments


INSERT INTO parkwiseDBS(plate_no, vehicle_type, vehicle_brand, parkin_datetime)
VALUES('YDU-353', 'Motorbike', 'Yamaha Aerox', '03/24/24 11:59PM');

DELETE  FROM parkwiseDBS WHERE plate_no = 'KAIJU-08';

ALTER TABLE parkwiseDBS NOCHECK CONSTRAINT ALL;
ALTER TABLE parkwiseDBS WITH CHECK CHECK CONSTRAINT ALL;

SELECT *
FROM parkwiseDBS
WHERE plate_no = 'YDU-353';

SELECT * FROM parkwiseDBS
SELECT * FROM p_trans
SELECT * FROM payments

DELETE FROM parkwiseDBS;
DELETE FROM p_trans
DELETE FROM payments

dbcc checkident('p_trans',reseed,0);

SELECT user_id, plate_no FROM parkwiseDBS WHERE user_id like 15 AND plate_no like 'YDU-353'