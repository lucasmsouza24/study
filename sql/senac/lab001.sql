-- 1
drop database dbzoologico;
create database dbzoologico;

-- 2
use dbzoologico;

create table tbanimais(
codigoAni int not null auto_increment,
tipoAni varchar(15),
nomeAni varchar(30),
idadeAni int,
valorAni decimal(10,2),
primary key(codigoAni)
);

insert into tbanimais(tipoAni, nomeAni, idadeAni, valorAni)values('cachorro', 'Djundi', 3, 300);
insert into tbanimais(tipoAni, nomeAni, idadeAni, valorAni)values('cachorro', 'Sula', 5, 300);
insert into tbanimais(tipoAni, nomeAni, idadeAni, valorAni)values('cachorro', 'Sarina', 7, 300);
insert into tbanimais(tipoAni, nomeAni, idadeAni, valorAni)values('gato', 'Pipa', 2, 500);
insert into tbanimais(tipoAni, nomeAni, idadeAni, valorAni)values('gato', 'Sarangue', 2, 500);
insert into tbanimais(tipoAni, nomeAni, idadeAni, valorAni)values('gato', 'Clarences', 2, 500);
insert into tbanimais(tipoAni, nomeAni, idadeAni, valorAni)values('coruja', 'Agnes', 0, 700);
insert into tbanimais(tipoAni, nomeAni, idadeAni, valorAni)values('coruja', 'Arabela', 1, 700);
insert into tbanimais(tipoAni, nomeAni, idadeAni, valorAni)values('sapo', 'Quash', 1, 100);
insert into tbanimais(tipoAni, nomeAni, idadeAni, valorAni)values('peixe', 'Fish', 0, 100);

-- 3
select * from tbanimais;

-- 4
select tipoAni, nomeAni from tbanimais;

-- 5
select tipoAni, nomeAni, idadeAni from tbanimais;

-- 6
select tipoAni as 'Tipo do Animal', nomeAni as 'Nome do Animal' from tbanimais;

-- 7
select tipoAni as 'Tipo de Animal', nomeAni as 'Nome do Animal', idadeAni as 'Tempo de Vida' from tbanimais;

-- 8
select 'Animal Domestico' as 'Procedencia', tipoAni as 'Tipo', nomeAni as 'Nome', idadeAni as 'Tempo de Vida' from tbanimais;

-- 9
select tipoAni as 'Tipo', nomeAni as 'Nome', idadeAni as 'Idade', valorAni as 'Valor Original', valorAni+valorAni/10 as 'Valor de Venda' from tbanimais;

-- 10
select distinct tipoAni as 'Tipo', valorAni as 'Valor Original', valorAni+valorAni/10 from tbanimais;