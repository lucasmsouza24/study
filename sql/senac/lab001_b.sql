#1
drop database dbzoologico_b;
create database dbzoologico_b;

#2
use dbzoologico_b;
create table tbanimais(
codigo int not null auto_increment,
tipo varchar(15),
nome varchar(30),
idade int,
valor decimal(10,2),
primary key(codigo)
);

insert into tbanimais(tipo, nome, idade, valor) values('cachorro', 'Djudi', 3, 300.00);
insert into tbanimais(tipo, nome, idade, valor) values('cachorro', 'Sula', 5, 200.00);
insert into tbanimais(tipo, nome, idade, valor) values('cachorro', 'Sarina', 7, 200.00);
insert into tbanimais(tipo, nome, idade, valor) values('gato', 'Pipa', 2, 500.00);
insert into tbanimais(tipo, nome, idade, valor) values('gato', 'Sarangue', 2, 500.00);
insert into tbanimais(tipo, nome, idade, valor) values('gato', 'Clarences', 1, 500.00);
insert into tbanimais(tipo, nome, idade, valor) values('coruja', 'Agnes', 0, 700.00);
insert into tbanimais(tipo, nome, idade, valor) values('coruja', 'Arabela', 1, 700.00);
insert into tbanimais(tipo, nome, idade, valor) values('sap0', 'Quash', 1, 100.00);
insert into tbanimais(tipo, nome, idade, valor) values('peixe', 'Fish', 0, 100.00);

update tbanimais set tipo='sapo' where codigo=9;

#3
select * from tbanimais;

#4
select tipo, nome from tbanimais;

#5
select tipo, nome, idade from tbanimais;

#6
select tipo as 'Tipo de Animal', nome as 'Nome do Animal' from tbanimais;

#7
select tipo as 'Tipo do Animal', nome as 'Nome do Animal', idade as 'Tempo de Vida' from tbanimais;

#8
select 'Animal Domestico' as 'Procedencia', tipo, nome, idade as 'Tempo de Vida' from tbanimais;

#9
select tipo, nome, idade, valor as 'Valor Original', valor+(valor/10) as 'Valor de Venda' from tbanimais;

#10
select distinct tipo, idade, valor as 'Valor Original', valor+valor/10 as 'Valor de Venda' from tbanimais;