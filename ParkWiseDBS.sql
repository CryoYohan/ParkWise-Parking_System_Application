CREATE DATABASE ParkWiseDBS


CREATE TABLE parkwiseDBS(
	user_id int primary key identity not null,
	plate_no nvarchar(50) unique not null,
	vehicle_type nvarchar(50) not null,
	vehicle_brand nvarchar(50) not null,
	parkin_datetime DATETIME not null
)

INSERT INTO parkwiseDBS(plate_no, vehicle_type, vehicle_brand, parkin_datetime)
VALUES('YDU-353', 'Motorbike', 'Yamaha Aerox', '03/24/24 11:59PM');

DELETE FROM parkwiseDBS;

ALTER TABLE parkwiseDBS NOCHECK CONSTRAINT ALL;
ALTER TABLE parkwiseDBS WITH CHECK CHECK CONSTRAINT ALL;

SELECT *
FROM parkwiseDBS
WHERE plate_no = 'YDU-353';

SELECT * FROM parkwiseDBS

SELECT user_id, plate_no FROM parkwiseDBS WHERE user_id like 15 AND plate_no like 'YDU-353'