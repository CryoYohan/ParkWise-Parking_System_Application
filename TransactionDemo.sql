CREATE TABLE Vehicles(
	v_id int primary key identity,
	pn nvarchar(20) unique,
	vt nvarchar(100) not null,
	vb nvarchar(100) not null,
	IsActive bit DEFAULT 1
)

CREATE TABLE p_trans(
	p_id int primary key,
	p_loc nvarchar(100),
	p_slot int null,
	p_date datetime
)

CREATE TABLE payments(
	t_id int,
	t_pn nvarchar(20),
	t_vt nvarchar(100),
	t_date datetime,
	t_payment decimal(10,2) 
)

UPDATE payments
SET t_date = '05/03/24 11:45AM', t_payment = 40.00
WHERE t_pn = 'KAIJU-01';

INSERT INTO payments(t_id, t_pn, t_vt)
SELECT v_id, pn, vt FROM Vehicles
WHERE pn = 'KAIJU-01';

drop table Vehicles

INSERT INTO Vehicles
VALUES('GAW-A23', 'SUV', 'Mercedez');

INSERT INTO p_trans(p_id,p_loc,p_slot, p_date )
VALUES(1,'GF-A1', 0, '5/02/24 11:43AM');

SELECT * FROM Vehicles
SELECT * FROM p_trans
SELECT * FROM payments

DELETE FROM Vehicles
DELETE FROM Vehicles WHERE pn = 'KAIJU-01'
DELETE FROM p_trans
DELETE FROM payments

dbcc checkident('Vehicles', reseed, 0);
dbcc checkident('p_trans', reseed, 0);