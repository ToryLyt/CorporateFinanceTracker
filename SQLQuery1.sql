--create database FinanceTrackerDb
--go

use FinanceTrackerDb
go

--create table Currency_tb(
--	ID int identity not null,
--	Name nvarchar(100) not null
--		constraint CK_Currency_name check(Name!=N''),
--	Code nvarchar(10) not null
--		constraint CK_Currency_code check(Code!=N''),
--	Symbol nvarchar(10) null,
--	DecimalPlaces int not null
--		constraint CK_Currency_dp check(DecimalPlaces>=0),

	--constraint PK_Currency_id primary key(ID),
	--constraint UQ_Currency_code unique(Code)
--)

--insert into Currency_tb(Name, Code, Symbol, DecimalPlaces)
--values (N'Euro', N'EUR', N'€', 2)

--select * from Currency_tb
----delete from Currency_tb


--------------------------------------------------

--create table Category_tb(
--	ID int identity not null,
--	Name nvarchar(200) not null
--		constraint CK_Category_name check(Name!=N''),
--	Description nvarchar(500) not null
--		constraint CK_Category_description check(Description!=N''),

--		constraint PK_Category_id primary key(ID),
--		constraint UQ_Category_name unique(Name)
--)

--select * from Category_tb

--------------------------------------------------

--drop table if exists SubCategory_tb


--create table SubCategory_tb(
--	ID int identity not null,
--	CategoryId int not null,
--	Name nvarchar(200) not null
--		constraint CK_SubCategory_name check(Name!=N''),
--	Description nvarchar(500) not null
--		constraint CK_SubCategory_description check(Description!=N''),

--		constraint PK_SubCategory_id primary key(ID),
--		constraint FK_SubCategory_Category
--		foreign key(CategoryId) references Category_tb(ID)
--)

--select * from SubCategory_tb

--------------------------------------------------

--drop table if exists Project_tb


--create table Project_tb(
--	ID int identity not null,
--	Name nvarchar(200) not null
--		constraint CK_Project_name check(Name!=N''),
--	Description nvarchar(500) not null
--		constraint CK_Project_descr check(Description!=N''),
--	IsActive bit not null
--		constraint DF_Project_active default(1),

--		constraint PK_Project_id primary key(ID),
--		constraint UQ_Project_name unique(Name)
--)

--select * from SubCategory_tb

--------------------------------------------------

create table Transaction_tb(
	ID int identity not null,

	AccountID int not null,
	Amount money not null
		constraint CK_Trx_amount check(Amount != 0),

	CurrencyID int not null,
	TrxDate datetime not null,

	Description nvarchar(500) not null
		constraint CK_Trx_descr check(Description != N''),

	RequestedByUserID int not null,
	StatusID int not null,
	TrxTypeID int not null,

	CreatedByUserID int not null,
	LastModifiedByUserID int not null,

	DateCreated datetime not null,
	DateModified datetime not null,

	IsIncome bit not null,

	ReceiptPath nvarchar(500) not null
		constraint CK_Trx_receipt check(ReceiptPath != N''),

	CategoryID int not null,
	ProjectID int not null,
	SubCategoryID int not null,

		constraint PK_Transaction_id primary key(ID),
		constraint FK_Trx_account foreign key(AccountID) references Account_tb(ID),
		constraint FK_Trx_currency foreign key(CurrencyID) references Currency_tb(ID),
		constraint FK_Trx_status foreign key(StatusID) references Status_tb(ID),
		constraint FK_Trx_type foreign key(TrxTypeID) references TrxType_tb(ID),

		constraint FK_Trx_req_user foreign key(RequestedByUserID) references User_tb(ID),
		constraint FK_Trx_cr_user foreign key(CreatedByUserID) references User_tb(ID),
		constraint FK_Trx_mod_user foreign key(LastModifiedByUserID) references User_tb(ID),

		constraint FK_Trx_cat foreign key(CategoryID) references Category_tb(ID),
		constraint FK_Trx_subcat foreign key(SubCategoryID) references SubCategory_tb(ID),
		constraint FK_Trx_project foreign key(ProjectID) references Project_tb(ID)
)


--------------------------------------------------
--------------------------------------------------
--------------------------------------------------
--------------------------------------------------
--------------------------------------------------
--------------------------------------------------
--------------------------------------------------
--------------------------------------------------
--------------------------------------------------
--------------------------------------------------


