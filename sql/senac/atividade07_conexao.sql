drop database dbAcessoBD;
create database dbAcessoBD;
use dbAcessoBD;

create table tbEstados(
codigoEst int not null auto_increment,
nomeEst varchar(50) not null unique,
ufEst varchar(2) not null,
primary key(codigoEst)
);

create table tbClientes(
codigoCli int not null auto_increment unique,
nomeCli varchar(100) not null,
sexoCli varchar(1) not null,
primary key(codigoCli)
);

insert into tbClientes(nomeCli, sexoCli) values('Lucas Mesquita de Souza', 'M');
insert into tbClientes(nomeCli, sexoCli) values('Lucas Krebs', 'M');
insert into tbClientes(nomeCli, sexoCli) values('Beatriz Medeiros', 'F');
insert into tbClientes(nomeCli, sexoCli) values('Euclides', 'M');
insert into tbClientes(nomeCli, sexoCli) values('Simone de Beauvoir', 'F');

insert into tbEstados(nomeEst, ufEst) values('Acre', 'AC');
insert into tbEstados(nomeEst, ufEst) values('Alagoas', 'AL');
insert into tbEstados(nomeEst, ufEst) values('Amapa', 'AP');
insert into tbEstados(nomeEst, ufEst) values('Amazonas', 'AM');
insert into tbEstados(nomeEst, ufEst) values('Bahia', 'BA');
insert into tbEstados(nomeEst, ufEst) values('Ceara', 'CE');
insert into tbEstados(nomeEst, ufEst) values('Distrito Federal', 'DF');
insert into tbEstados(nomeEst, ufEst) values('Espírito Santo', 'ES');
insert into tbEstados(nomeEst, ufEst) values('Goias', 'GO');
insert into tbEstados(nomeEst, ufEst) values('Maranhao', 'MA');
insert into tbEstados(nomeEst, ufEst) values('Mato Grosso', 'MT');
insert into tbEstados(nomeEst, ufEst) values('Mato Grosso do Sul', 'MS');
insert into tbEstados(nomeEst, ufEst) values('Minas Gerais', 'MG');
insert into tbEstados(nomeEst, ufEst) values('Para', 'PA');
insert into tbEstados(nomeEst, ufEst) values('Paraiba', 'PB');
insert into tbEstados(nomeEst, ufEst) values('Parana', 'PR');
insert into tbEstados(nomeEst, ufEst) values('Pernabuco', 'PE');
insert into tbEstados(nomeEst, ufEst) values('Piaui', 'PI');
insert into tbEstados(nomeEst, ufEst) values('Rio de Janeiro', 'RJ');
insert into tbEstados(nomeEst, ufEst) values('Rio Grande do Norte', 'RN');
insert into tbEstados(nomeEst, ufEst) values('Rio Grande do Sul', 'RS');
insert into tbEstados(nomeEst, ufEst) values('Rondonia', 'RO');
insert into tbEstados(nomeEst, ufEst) values('Roraima', 'RR');
insert into tbEstados(nomeEst, ufEst) values('Santa Catarina', 'SC');
insert into tbEstados(nomeEst, ufEst) values('Sao Paulo', 'SP');
insert into tbEstados(nomeEst, ufEst) values('Sergipe', 'SE');
insert into tbEstados(nomeEst, ufEst) values('Tocantins', 'TO');