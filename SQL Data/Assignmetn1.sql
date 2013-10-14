drop table tblCustomer
drop table tblOrder
drop table tblReturns
drop table tblProduct
drop table tblProductsOrdered
drop table tblProductMaterial
drop table tblMaterial

create table tblCustomer (
CustomerID int not null primary key,
FirstName varchar (20),
Surname varchar (20),
Addres varchar (35),
Email varchar (35),
DOB varchar (35),
)

create table tblProduct(
ProductID varchar (20) primary key,
ProductName varchar (20),
Price money,
Dimensions varchar (35),
Edging varchar (10)
)

create table tblOrder(
OrderID int not null primary key,
OrderDate date,
Quantity int,
Comments varchar (50),
CustomerID int references tblCustomer(CustomerID)
)

create table tblProductsOrdered(
ProductsOrderedID int not null primary key,
ProductID varchar (20) references tblProduct(ProductID),
OrderID int foreign key references tblOrder(OrderID)
)

create table tblReturns(
ReturnID int not null primary key,
Reason varchar (20),
ReturnDate date,
CustomerID int foreign key references tblCustomer(CustomerID),
ProductID varchar (20) foreign key references tblProduct(ProductID)
)

create table tblProductMaterial(
ProductMaterialID int not null primary key,
MaterialID varchar (20) foreign key references tblMaterial(MaterialID),
ProductID varchar  (20) foreign key references tblProduct(ProductID) 
)

create table tblMaterial(
MaterialID varchar (20) not null primary key,
MaterialDesc varchar (35),
Dimensions varchar (35),
Quantity int
)



insert into tblCustomer (CustomerID, FirstName, Surname, Addres, Email, DOB)
values (1001, 'Wayne', 'Prinsloo', '10 Main Road', 'wcla@isat.com', '1981-12-15')
insert into tblCustomer (CustomerID, FirstName, Surname, Addres, Email, DOB)
values (1002, 'Jeff', 'Hassen', '8 Water Road', 'jh@icon.com', '1984-01-05')
insert into tblCustomer (CustomerID, FirstName, Surname, Addres, Email, DOB)
values (1003, 'Lwasi', 'Martin', '12 Lilly Road', 'mar@isat.com', '1960-03-08')
insert into tblCustomer (CustomerID, FirstName, Surname, Addres, Email, DOB)
values (1004, 'Kelly', 'Jafta', '1 Gladys Road', 'kjaft@exp.com', '1975-10-25')
insert into tblCustomer (CustomerID, FirstName, Surname, Addres, Email, DOB)
values (1005, 'James', 'Bennet', '5 Martin Road', 'benj@isat.com', '1990-06-17')
insert into tblCustomer (CustomerID, FirstName, Surname, Addres, Email, DOB)
values (1006, 'Benni', 'Rundle', '17 Water Road', 'brun@msend.com', '1965-11-19')
insert into tblCustomer (CustomerID, FirstName, Surname, Addres, Email, DOB)
values (1007, 'Rodney', 'Williams', '19 Cape Road', 'wcla@isat.com', '1983-01-03')
insert into tblCustomer (CustomerID, FirstName, Surname, Addres, Email, DOB)
values (1008, 'Sarah', 'Jones', '3 Old Road', 'sj@isat.com', '1987-10-11')
insert into tblCustomer (CustomerID, FirstName, Surname, Addres, Email, DOB)
values (1009, 'Simpihiwe', 'Gcina', '5 Long Road', 'sg@isat.com', '1977-02-18')
insert into tblCustomer (CustomerID, FirstName, Surname, Addres, Email, DOB)
values (1010, 'Lazola', 'Dube', '25 Main Road', 'ldub@isat.com', '1971-04-28')

insert into tblProduct (ProductID, ProductName, Price, Dimensions, Edging)
values ('T1511', 'Oak Desk', 2500.00, '750mm x 750mm', 'Yes')
insert into tblProduct (ProductID, ProductName, Price, Dimensions, Edging)
values ('T1512', 'Pine Desk', 1799.00, '750mm x 750mm', 'Yes')
insert into tblProduct (ProductID, ProductName, Price, Dimensions, Edging)
values ('T1513', 'Classique Desk', 1899.00, '750mm x 750mm', 'Yes')
insert into tblProduct (ProductID, ProductName, Price, Dimensions, Edging)
values ('T1514', 'Heritage Desk', 2299.00, '750mm x 750mm', 'No')
insert into tblProduct (ProductID, ProductName, Price, Dimensions, Edging)
values ('T1515', 'Oak Cabinet', 3599.00, '900mm x 1600mm', 'Yes')
insert into tblProduct (ProductID, ProductName, Price, Dimensions, Edging)
values ('T1516', 'Pine Cabinet', 2899.00, '900mm x 1600mm', 'Yes')
insert into tblProduct (ProductID, ProductName, Price, Dimensions, Edging)
values ('T1517', 'Classique Cabinet', 2999.00, '900mm x 1600mm', 'Yes')
insert into tblProduct (ProductID, ProductName, Price, Dimensions, Edging)
values ('T1518', 'Heritage Cabinet', 3299.00, '900mm x 1600mm', 'No')
insert into tblProduct (ProductID, ProductName, Price, Dimensions, Edging)
values ('T1519', 'Mahogany Desk', 2499.00, '900mm x 1600mm', 'Yes')
insert into tblProduct (ProductID, ProductName, Price, Dimensions, Edging)
values ('T1521', 'Mahogany Cabinet', 2899.00, '900mm x 1600mm', 'Yes')

insert into tblOrder (OrderID, OrderDate, Quantity, Comments, CustomerID)
values (551, '2012-09-15', 2, 'Purchase and Delivery paid.', 1005)
insert into tblOrder (OrderID, OrderDate, Quantity, Comments, CustomerID)
values (552, '2012-09-15', 2, 'Delivery payment outstanding.', 1010)
insert into tblOrder (OrderID, OrderDate, Quantity, Comments, CustomerID)
values (553, '2012-09-15', 2, 'Long distance delivery.', 1001)
insert into tblOrder (OrderID, OrderDate, Quantity, Comments, CustomerID)
values (554, '2012-10-16', 2, 'Purchase and delivery paid.', 1003)
insert into tblOrder (OrderID, OrderDate, Quantity, Comments, CustomerID)
values (555, '2012-10-17', 2, 'Purchase and delivery paid.', 1002)
insert into tblOrder (OrderID, OrderDate, Quantity, Comments, CustomerID)
values (556, '2012-10-18', 2, 'Delivery payment outstanding.', 1007)
insert into tblOrder (OrderID, OrderDate, Quantity, Comments, CustomerID)
values (557, '2012-10-18', 2, 'Purchase and Delivery paid.', 1007)
insert into tblOrder (OrderID, OrderDate, Quantity, Comments, CustomerID)
values (558, '2012-10-18', 2, 'Purchase and Delivery paid.', 1008)
insert into tblOrder (OrderID, OrderDate, Quantity, Comments, CustomerID)
values (559, '2012-10-20', 2, 'Delivery payment outstanding.', 1009)
insert into tblOrder (OrderID, OrderDate, Quantity, Comments, CustomerID)
values (560, '2012-10-20', 2, 'Long distance delivery.', 1005)

insert into tblProductsOrdered (ProductsOrderedID, ProductID, OrderID)
values (1, 'T1511', 555)
insert into tblProductsOrdered (ProductsOrderedID, ProductID, OrderID)
values (2, 'T1513', 552)
insert into tblProductsOrdered (ProductsOrderedID, ProductID, OrderID)
values (3, 'T1515', 558)
insert into tblProductsOrdered (ProductsOrderedID, ProductID, OrderID)
values (4, 'T1513', 552)
insert into tblProductsOrdered (ProductsOrderedID, ProductID, OrderID)
values (5, 'T1514', 551)
insert into tblProductsOrdered (ProductsOrderedID, ProductID, OrderID)
values (6, 'T1515', 553)
insert into tblProductsOrdered (ProductsOrderedID, ProductID, OrderID)
values (7, 'T1515', 553)
insert into tblProductsOrdered (ProductsOrderedID, ProductID, OrderID)
values (8, 'T1517', 554)
insert into tblProductsOrdered (ProductsOrderedID, ProductID, OrderID)
values (9, 'T1511', 558)
insert into tblProductsOrdered (ProductsOrderedID, ProductID, OrderID)
values (10, 'T1511', 559)

insert into tblReturns (ReturnID, Reason, ReturnDate, CustomerID, ProductID)
values (1, 'Faulty Legs', '2012-09-25', 1003, 'T1511')
insert into tblReturns (ReturnID, Reason, ReturnDate, CustomerID, ProductID)
values (2, 'Damaged side', '2012-09-07', 1007, 'T1511')
insert into tblReturns (ReturnID, Reason, ReturnDate, CustomerID, ProductID)
values (3, 'Water damage', '2012-09-15', 1010, 'T1511')
insert into tblReturns (ReturnID, Reason, ReturnDate, CustomerID, ProductID)
values (4, 'Water damage', '2012-09-15', 1001, 'T1511')
insert into tblReturns (ReturnID, Reason, ReturnDate, CustomerID, ProductID)
values (5, 'Visible scratch', '2012-09-22', 1007, 'T1511')
insert into tblReturns (ReturnID, Reason, ReturnDate, CustomerID, ProductID)
values (6, 'Faulty Legs', '2012-09-24', 1010, 'T1511')
insert into tblReturns (ReturnID, Reason, ReturnDate, CustomerID, ProductID)
values (7, 'Visible scratch', '2012-09-25', 1010, 'T1511')
insert into tblReturns (ReturnID, Reason, ReturnDate, CustomerID, ProductID)
values (8, 'Faulty Legs', '2012-09-27', 1001, 'T1511')
insert into tblReturns (ReturnID, Reason, ReturnDate, CustomerID, ProductID)
values (9, 'Water Damage', '2012-09-28', 1007, 'T1511')
insert into tblReturns (ReturnID, Reason, ReturnDate, CustomerID, ProductID)
values (10, 'Faulty Legs', '2012-09-28', 1009, 'T1511')
insert into tblReturns (ReturnID, Reason, ReturnDate, CustomerID, ProductID)
values (11, 'Missing Part', '2012-09-95', 1003, 'T1511')

insert into tblProductMaterial (ProductMaterialID, MaterialID, ProductID)
values (1, 'LL151', 'T1511')
insert into tblProductMaterial (ProductMaterialID, MaterialID, ProductID)
values (2, 'LL153', 'T1512')
insert into tblProductMaterial (ProductMaterialID, MaterialID, ProductID)
values (3, 'LL155', 'T1513')
insert into tblProductMaterial (ProductMaterialID, MaterialID, ProductID)
values (4, 'LL157', 'T1514')
insert into tblProductMaterial (ProductMaterialID, MaterialID, ProductID)
values (5, 'LL158', 'T1515')
insert into tblProductMaterial (ProductMaterialID, MaterialID, ProductID)
values (6, 'LL159', 'T1516')
insert into tblProductMaterial (ProductMaterialID, MaterialID, ProductID)
values (7, 'LL153', 'T1517')
insert into tblProductMaterial (ProductMaterialID, MaterialID, ProductID)
values (8, 'LL154', 'T1518')
insert into tblProductMaterial (ProductMaterialID, MaterialID, ProductID)
values (9, 'LL155', 'T1519')
insert into tblProductMaterial (ProductMaterialID, MaterialID, ProductID)
values (10, 'LL156', 'T1521')

insert into tblMaterial (MaterialID, MaterialDesc, Dimensions, Quantity)
values ('LL151', 'African Rosewood', '100mm x 100mm', 100)
insert into tblMaterial (MaterialID, MaterialDesc, Dimensions, Quantity)
values ('LL152', 'Redwood', '50mm x 30mm', 50)
insert into tblMaterial (MaterialID, MaterialDesc, Dimensions, Quantity)
values ('LL153', 'African Rosewood', '50mm x 30mm', 75)
insert into tblMaterial (MaterialID, MaterialDesc, Dimensions, Quantity)
values ('LL154', 'Round Pine', '1000mm x 10mm', 15)
insert into tblMaterial (MaterialID, MaterialDesc, Dimensions, Quantity)
values ('LL155', 'European timber', '20mm x 20mm', 80)
insert into tblMaterial (MaterialID, MaterialDesc, Dimensions, Quantity)
values ('LL156', 'Scots Pine', '100mm x 100mm', 100)
insert into tblMaterial (MaterialID, MaterialDesc, Dimensions, Quantity)
values ('LL157', 'Maple', '50mm x 30mm', 110)
insert into tblMaterial (MaterialID, MaterialDesc, Dimensions, Quantity)
values ('LL158', 'Draw', '50mm x 30mm', 108)
insert into tblMaterial (MaterialID, MaterialDesc, Dimensions, Quantity)
values ('LL159', 'Yellow wood', '1000mm x 1000mm', 93)
insert into tblMaterial (MaterialID, MaterialDesc, Dimensions, Quantity)
values ('LL161', 'Meranti wood', '25mm x 25mm', 65)

--Question 3
select tblCustomer.FirstName + ' , ' + tblCustomer.surname as [Customer Name], tblProduct.ProductName as [Product Name], tblOrder.OrderDate as [Order Date]
from tblOrder
join tblCustomer on tblCustomer.CustomerID = tblOrder.CustomerID
join tblProductsOrdered on tblOrder.OrderID = tblProductsOrdered.OrderID
join tblProduct on tblProductsOrdered.ProductID = tblProduct.ProductID

--Question 4
select tblCustomer.Surname as [Surname], tblCustomer.Addres as [Address], tblProduct.ProductName as [Product Name], tblProduct.Price as [Price]
from tblOrder
join tblCustomer on tblCustomer.CustomerID = tblOrder.CustomerID
join tblProductsOrdered on tblOrder.OrderID = tblProductsOrdered.OrderID
join tblProduct on tblProductsOrdered.ProductID = tblProduct.ProductID
where tblCustomer.Surname = 'Dube'

--Question 5
select LEFT (FirstName, 1) +' , ' + Surname as [Customer Name], datediff(day, orderDate, getdate()) as [Days Waited]
from tblCustomer
join tblOrder on tblCustomer.CustomerID = tblOrder.CustomerID


--Question 6
select tblCustomer.FirstName as [First Name], tblCustomer.Surname as [Surname], tblCustomer.Email as [Email]
from tblCustomer
left join tblReturns on tblCustomer.CustomerID = tblReturns.CustomerID
where tblReturns.CustomerID IS NULL


--Question 7
select tblCustomer.Surname as [Surname], tblOrder.OrderDate as [Order Date], tblProduct.ProductName as [Product Name]

--Question 8
select top 1 tblCustomer.FirstName
from tblCustomer
join tblOrder on tblCustomer.CustomerID = tblOrder.CustomerID
join tblProductsOrdered