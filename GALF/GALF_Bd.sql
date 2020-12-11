create database galf;

use galf;

create table Login(
	id int unsigned auto_increment not null,
    login varchar(30) not null,
    senha varchar(30) not null,
    primary key(id)
);

insert into Login(id, login, senha)
value(null, "Fatec", "ADS2020");