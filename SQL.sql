--Select
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

Select * from Customers where City ='Berlin'

--case insensitive
seLEct * from Products where categoryID=1 or categoryID=3

seLEct * from Products where categoryID=1 and UnitPrice>=10

select * from Products where CategoryID=1 order by UnitPrice desc    --ascending --descending

select count(*) Adet from Products

select CategoryID,count(*) from products where UnitPrice>20 group by CategoryID having count(*)<10

select Products.ProductID, products.ProductName, products.UnitPrice, Categories.CategoryName
from products inner join Categories 
on products.CategoryID = Categories.CategoryID
where products.UnitPrice>10

--DTO Data Transformation Object

select * from Products p left join [Order Details] od
on p.ProductID=od.ProductID
inner join Orders o
on o.OrderID = od.OrderID

select * from Customers c left join Orders o
on c.CustomerID=o.CustomerID
where o.CustomerID is null