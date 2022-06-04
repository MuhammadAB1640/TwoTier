Create Database ThreeTier
go

Use TwoTier
go

Create Table Users
(
	Username int Primary Key identity(1,1),
	Password nvarchar(50) not null
)
go

Select * from Users

Insert into Users values ('Muhammad', '123')