CREATE DATABASE ParkingVehicles

use ParkingVehicles

CREATE TABLE parkwisevehicles(
	
	id INTEGER PRIMARY KEY IDENTITY not null,
	Plate_Number VARCHAR(20) unique,
	Vehicle_Type VARCHAR (20) not null,
	Vehicle_Brand VARCHAR(20) not null,
	Parkin_DateTime DATETIME not null
);

INSERT INTO parkwisevehicles(Plate_Number, Vehicle_Type, Vehicle_Brand, Parkin_DateTime)
VALUES('YDU-351', 'Motorbike', 'Yamaha Aerox', '03/24/24 11:59PM');

SELECT * FROM parkwisevehicles
