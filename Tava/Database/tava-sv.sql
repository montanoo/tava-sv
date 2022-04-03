USE master
GO

CREATE DATABASE Tava
GO

USE Tava
GO

CREATE TABLE [user] (
    id int IDENTITY(1,1) NOT NULL,
    username varchar(255) NOT NULL,
    [password] varchar(255) NOT NULL,

    CONSTRAINT PK_user_id PRIMARY KEY (id),
    CONSTRAINT CHK_password CHECK(DATALENGTH([password]) >= 8),
)

CREATE TABLE [admin] (
    id int IDENTITY (1,1) NOT NULL, -- pk
    [user_id] int NOT NULL, -- fk
    identitynumber varchar(15),-- unique
    [name] varchar(255) NOT NULL,
	lastname varchar(255),
	bankaccount varchar(10),
	companyname varchar(255)

    CONSTRAINT PK_admin_id PRIMARY KEY (id),
    CONSTRAINT UNQ_idnumber UNIQUE (identitynumber)
)
CREATE TABLE products (
    id int IDENTITY (1,1) NOT NULL, -- pk
    [name] varchar(255) UNIQUE,
    [description] varchar(MAX),
	stock int NOT NULL,
    price float,
	package varchar(255),
	unitsperset int,


    CONSTRAINT PK_products_id PRIMARY KEY (id),
	CONSTRAINT UNQ_products_name UNIQUE ([name])
)
CREATE TABLE client (
    id int IDENTITY (1,1) NOT NULL, -- pk
    [name] varchar(255) NOT NULL,
	lastname varchar(255),
    phone int,

    CONSTRAINT PK_client_id PRIMARY KEY (id),
)
CREATE TABLE pointofsale (
    id int IDENTITY(1,1) NOT NULL,
    [type] varchar(255),
    [address] varchar(MAX),

    CONSTRAINT PK_pointofsale PRIMARY KEY (id)
)
CREATE TABLE billing (
    id int IDENTITY (1,1) NOT NULL,
	[admin_id] int,
    [client_id] int,
    [date] date,
    [product_id] int,
    quantity int,
    totalprice float,
	[pointofsale_id] int,

    CONSTRAINT PK_billing PRIMARY KEY (id)
)
ALTER TABLE [admin]
ADD CONSTRAINT FK_admin_id FOREIGN KEY ([user_id]) REFERENCES [user](id)
ON DELETE CASCADE
ON UPDATE CASCADE 
GO
ALTER TABLE [billing]
ADD CONSTRAINT FK_billing_admin_id FOREIGN KEY ([admin_id]) REFERENCES [admin](id)
ON DELETE CASCADE
ON UPDATE CASCADE
GO
ALTER TABLE [billing]
ADD CONSTRAINT FK_billing_client_id FOREIGN KEY ([client_id]) REFERENCES client(id)
ON DELETE CASCADE
ON UPDATE CASCADE
GO
ALTER TABLE [billing]
ADD CONSTRAINT FK_billing_product_id FOREIGN KEY ([product_id]) REFERENCES products(id)
GO
ALTER TABLE [billing]
ADD CONSTRAINT FK_salepoint_address_id FOREIGN KEY ([pointofsale_id]) REFERENCES pointofsale(id)
GO