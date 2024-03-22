CREATE DATABASE Vehicles;



Create table parking(
customer_id varchar(10) not null,
plate_num varchar(10) primary key not null,
vehicle_type varchar(10) not null,
vehicle_brand varchar(10) not null,
park_date date





);

SELECT plate_num as[Plate Number], vehicle_brand, vehicle_type from parking where plate_num = 'ABC123';