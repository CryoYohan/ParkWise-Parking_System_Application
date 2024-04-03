CREATE DATABASE Vehicles;



Create table parking(
id integer primary key,
customer_id varchar(10) not null,
plate_num varchar(10) primary key not null,
vehicle_type varchar(10) not null,
vehicle_brand varchar(10) not null,
park_date time
);

SELECT plate_num as[Plate Number], vehicle_brand as [Vehicle Brand], vehicle_type as [Vehicle Type], park_date as [Park-in Date/Time] from parking;
INSERT into parking (customer_id,plate_num, vehicle_type, vehicle_brand, park_date)
VALUES ('PRKWS','YDU-351', 'Motorbike', 'Yamaha', '3/22/24 11:59PM');
INSERT into parking (customer_id,plate_num, vehicle_type, vehicle_brand, park_date)
VALUES ('PRKWS','YDU-353', 'SUV', 'Toyota', '3/22/24 11:59PM');
INSERT into parking (customer_id,plate_num, vehicle_type, vehicle_brand, park_date)
VALUES ('PRKWS','YDU-352', 'Sedan', 'Nissan', '3/22/24 11:59PM');
SELECT * from parking where plate_num = 'YDU-353'
SELECT * from parking
