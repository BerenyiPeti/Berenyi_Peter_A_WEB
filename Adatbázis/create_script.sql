use master 
go
create database vizsga
go

use vizsga
go

CREATE TABLE [dbo].[kategoria](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[kategorianev] [nvarchar](max) NOT NULL,
	primary key (id)
)
go

CREATE TABLE [dbo].[teszt](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[kerdes] [nvarchar](max) NOT NULL,
	[v1] [nvarchar](max) NOT NULL,
	[v2] [nvarchar](max) NOT NULL,
	[v3] [nvarchar](max) NOT NULL,
	[v4] [nvarchar](max) NOT NULL,
	[helyes] [nvarchar](max) NOT NULL,
	[kategoriaId] [int] NOT NULL,
primary key (id)
)
go

alter table teszt add foreign key (kategoriaId) references kategoria(id)

