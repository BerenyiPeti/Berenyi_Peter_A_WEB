use master 
go
create database vizsga
go

use vizsga
go
alter table teszt add foreign key (kategoriaId) references kategoria(id)