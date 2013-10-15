drop table tblShootingRange
drop table tblClient
drop table tblGun

create table tblShootingRange (
rangeID int identity (1,1) primary key,
rangeName varchar (20),
rangeLocation varchar (20),
rangeAge int,
rangeType varchar (20)
)

create table tblClient (
clientID int identity (1,1) primary key,
clientName varchar (20),
clientSurname varchar (20),
clientAddress varchar (50),
clientEmail varchar (50),
clientIDNum varchar (13),
clientCell varchar (10)
)

insert into tblClient (clientName, clientSurname, clientAddress, clientEmail, clientIDNum, clientCell)
values ('Daniel', 'Tromp', '86 Cook Road', 'dan@tromps.co.za', '9209255131986','0828506768'),
('Byron', 'Coetsee', '23 SilverWood', 'byroncoetsee@gmail.com', '9110157837594', '0729293991')


create table tblGun(
gunID int identity (1,1) primary key,
clientID int foreign key references tblClient(clientID),
gunType varchar (20),
gunAmmo varchar (20),
gunYear varchar (10),
gunWeight int,
gunColour varchar (10)
)

insert into tblGun(clientID, guntype, gunAmmo, gunYear, gunWeight, gunColour)
values (2, 'Automatic', 'Hollow-Points', '1990','7', 'Black'),
(1, 'Semi-Automatic', '.22', '1995', '4', 'Blue')

select *
from tblClient