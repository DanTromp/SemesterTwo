drop table tblEmployee
drop table tblCustomer
drop table tblProduct
drop table tblOrder

create table tblEmployee(
EmployeeID int primary key identity (1,1),
FirstName varchar (20),
Surname varchar (20),
CustomerID int foreign key references tblCustomer(CustomerID),
OrderID int foreign key references tblOrder(OrderID)
)

create table tblCustomer(
CustomerID int primary key identity (1,1),
FirstName varchar (20),
Surname varchar (20),
EmployeeID int foreign key references tblEmployee(EmployeeID),
OrderID int foreign key references tblOrder(OrderID)
)
create table tblProduct(

)

create table tblOrder(
OrderID int primary key identity (1,1),

)