#1

drop database DB_CDS;
create database DB_CDS;

#2

use DB_CDS;

#

create table TB_ARTISTAS(
COD_ART int not null auto_increment,
NOME_ART varchar(100) not null unique,
primary key(COD_ART)
);

create table TB_GRAVADORAS(
COD_GRAV int not null auto_increment,
NOME_GRAV varchar(50) not null unique,
primary key(COD_GRAV)
);

create table TB_CATEGORIAS(
COD_CAT int not null auto_increment,
NOME_CAT varchar(50) not null unique,
primary key(COD_CAT) 
);

create table TB_ESTADOS(
SIGLA_EST char(2) not null,
NOME_EST varchar(50) not null unique,
primary key(SIGLA_EST)
);

create table TB_CIDADES(
COD_CID int not null auto_increment,
SIGLA_EST char(2) not null,
NOME_CID varchar(50) not null,
primary key(COD_CID),
foreign key(SIGLA_EST) references TB_ESTADOS(SIGLA_EST)
);

create table TB_CLIENTES(
COD_CLI int not null auto_increment,
COD_CID int not null,
NOME_CLI varchar(50) not null,
END_CLI varchar(100) not null,
RENDA_CLI decimal(9, 2) default 0 not null check(RENDA_CLI>=0),
SEXO_CLI char(1) default 'F' not null check(SEXO_CLI in ('F', 'M')),
primary key(COD_CLI),
foreign key(COD_CID) references TB_CIDADES(COD_CID)
);

create table TB_CONJUGUE(
COD_CLI int not null,
NOME_CONJ varchar(50) not null,
RENDA_CONJ decimal(9,2) default 0 not null check(RENDA_CONJ>=0),
SEXO_CONJ char(1) default 'F' not null check(SEXO_CONJ in ('F', 'M')),
primary key(COD_CLI),
foreign key(COD_CLI) references TB_CLIENTES(COD_CLI)
);

create table TB_FUNCIONARIOS(
COD_FUNC int not null auto_increment,
NOME_FUNC varchar(50) not null,
END_FUNC varchar(100) not null,
SAL_FUNC decimal(9, 2) default 0 not null check(SAL_FUNC>=0),
SEXO_FUNC char(1) default 'F' not null check(SEXO_FUNC in ('F', 'M')),
primary key(COD_FUNC)
);

create table TB_DEPENDENTES(
COD_DEP int not null auto_increment,
COD_FUNC int not null,
NOME_DEP varchar(100) not null,
SEXO_DEP char(1) default 'F' not null check(SEXO_DEP in ('F', 'M')),
primary key(COD_DEP),
foreign key(COD_FUNC) references TB_FUNCIONARIOS(COD_FUNC)
);

create table TB_TITULOS(
COD_TIT int not null auto_increment,
COD_CAT int not null,
COD_GRAV int not null,
NOME_CD varchar(50) not null unique,
VAL_CD decimal(9, 2) not null check(VAL_CD>0),
QTD_ESTQ int not null check(QTD_ESTQ>=0),
primary key(COD_TIT),
foreign key(COD_CAT) references TB_CATEGORIAS(COD_CAT),
foreign key(COD_GRAV) references TB_GRAVADORAS(COD_GRAV)
);

create table TB_PEDIDOS(
NUM_PED int not null auto_increment,
COD_CLI int not null,
COD_FUNC int not null,
DATA_PED date not null,
VAL_PED decimal(9, 2) default 0 not null check(VAL_PED>=0),
primary key(NUM_PED),
foreign key(COD_CLI) references TB_CLIENTES(COD_CLI),
foreign key(COD_FUNC) references TB_FUNCIONARIOS(COD_FUNC)
);

create table TB_TITULOS_PEDIDO(
NUM_PED int not null,
COD_TIT int not null,
QTD_CD int not null check(QTD_CD>=1),
VAL_CD decimal(9, 2) not null check(VAL_CD>0),
foreign key(NUM_PED) references TB_PEDIDOS(NUM_PED),
foreign key(COD_TIT) references TB_TITULOS(COD_TIT)
);

create table TB_TITULOS_ARTISTA(
COD_TIT int not null,
COD_ART int not null,
foreign key(COD_TIT) references TB_TITULOS(COD_TIT),
foreign key(COD_ART) references TB_ARTISTAS(COD_ART)
);

-- 4

insert into TB_ARTISTAS(NOME_ART) values('MARISA MONTE');
insert into TB_ARTISTAS(NOME_ART) values('GILBERTO GIL');
insert into TB_ARTISTAS(NOME_ART) values('CAETANO VELOSO');
insert into TB_ARTISTAS(NOME_ART) values('MILTON NASCIMENTO');
insert into TB_ARTISTAS(NOME_ART) values('LEGIÃO URBANA');
insert into TB_ARTISTAS(NOME_ART) values('THE BEATLES');
insert into TB_ARTISTAS(NOME_ART) values('RITA LEE');

insert into TB_GRAVADORAS(NOME_GRAV) values('POLYGRAM');
insert into TB_GRAVADORAS(NOME_GRAV) values('EMI');
insert into TB_GRAVADORAS(NOME_GRAV) values('SOM LIVRE');
insert into TB_GRAVADORAS(NOME_GRAV) values('SOM MUSIC');

insert into TB_CATEGORIAS(NOME_CAT) values('MPB');
insert into TB_CATEGORIAS(NOME_CAT) values('TRILHA SONORA');
insert into TB_CATEGORIAS(NOME_CAT) values('ROCK INTERNACIONAL');
insert into TB_CATEGORIAS(NOME_CAT) values('ROCK NACIONAL');

insert into TB_ESTADOS(SIGLA_EST, NOME_EST) values('SP', 'SÃO PAULO');
insert into TB_ESTADOS(SIGLA_EST, NOME_EST) values('MG', 'MINAS GERAIS');
insert into TB_ESTADOS(SIGLA_EST, NOME_EST) values('RJ', 'RIO DE JANEIRO');
insert into TB_ESTADOS(SIGLA_EST, NOME_EST) values('ES', 'ESPIRITO SANTO');

insert into TB_CIDADES(SIGLA_EST, NOME_CID) values('SP', 'SÃO PAULO');
insert into TB_CIDADES(SIGLA_EST, NOME_CID) values('SP', 'SOROCABA');
insert into TB_CIDADES(SIGLA_EST, NOME_CID) values('SP', 'JUNDIAI');
insert into TB_CIDADES(SIGLA_EST, NOME_CID) values('SP', 'AMERICANA');
insert into TB_CIDADES(SIGLA_EST, NOME_CID) values('SP', 'ARARAQUARA');
insert into TB_CIDADES(SIGLA_EST, NOME_CID) values('MG', 'OURO PRETO');
insert into TB_CIDADES(SIGLA_EST, NOME_CID) values('ES', 'CACHOEIRA DO ITAPEMIRIM');

insert into TB_CLIENTES(COD_CID, NOME_CLI, END_CLI, RENDA_CLI, SEXO_CLI) values(1, 'JOSE NOGUEIRA', 'RUA A', 1500, 'M');
insert into TB_CLIENTES(COD_CID, NOME_CLI, END_CLI, RENDA_CLI, SEXO_CLI) values(1, 'ANGELO PEREIRA', 'RUA B', 2000, 'M');
insert into TB_CLIENTES(COD_CID, NOME_CLI, END_CLI, RENDA_CLI, SEXO_CLI) values(1, 'ALEM MAR PARANHOS', 'RUA C', 1500, 'M');
insert into TB_CLIENTES(COD_CID, NOME_CLI, END_CLI, RENDA_CLI, SEXO_CLI) values(1, 'CATARINA SOUZA', 'RUA D', 892, 'F');
insert into TB_CLIENTES(COD_CID, NOME_CLI, END_CLI, RENDA_CLI, SEXO_CLI) values(1, 'VAGNER COSTA', 'RUA E', 950, 'M');
insert into TB_CLIENTES(COD_CID, NOME_CLI, END_CLI, RENDA_CLI, SEXO_CLI) values(2, 'ANTENOR DA COSTA', 'RUA F', 1582, 'M');
insert into TB_CLIENTES(COD_CID, NOME_CLI, END_CLI, RENDA_CLI, SEXO_CLI) values(2, 'MARIA AMELIA DE SOUZA', 'RUA G', 1152, 'F');
insert into TB_CLIENTES(COD_CID, NOME_CLI, END_CLI, RENDA_CLI, SEXO_CLI) values(2, 'PAULO ROBERTO SILVA', 'RUA H', 3250, 'M');
insert into TB_CLIENTES(COD_CID, NOME_CLI, END_CLI, RENDA_CLI, SEXO_CLI) values(3, 'FATIMA SOUZA', 'RUA I', 1632, 'F');
insert into TB_CLIENTES(COD_CID, NOME_CLI, END_CLI, RENDA_CLI, SEXO_CLI) values(3, 'JOEL DA ROCHA', 'RUA J', 2000, 'M');

insert into TB_CONJUGUE(COD_CLI, NOME_CONJ, RENDA_CONJ, SEXO_CONJ) values(1, 'CARLA NOGUEIRA', 2500, 'F');
insert into TB_CONJUGUE(COD_CLI, NOME_CONJ, RENDA_CONJ, SEXO_CONJ) values(2, 'EMILIA PEREIRA', 5500, 'F');
insert into TB_CONJUGUE(COD_CLI, NOME_CONJ, RENDA_CONJ, SEXO_CONJ) values(6, 'ALTIVA DA COSTA', 3000, 'F');
insert into TB_CONJUGUE(COD_CLI, NOME_CONJ, RENDA_CONJ, SEXO_CONJ) values(7, 'CARLOS DE SOUZA', 3250, 'M');

insert into TB_FUNCIONARIOS(NOME_FUNC, END_FUNC, SAL_FUNC, SEXO_FUNC) values('VANIA GABRIELA PEREIRA', 'RUA A', 2500, 'F');
insert into TB_FUNCIONARIOS(NOME_FUNC, END_FUNC, SAL_FUNC, SEXO_FUNC) values('NORBERTO PEREIRA DA SILVA', 'RUA B', 300, 'M');
insert into TB_FUNCIONARIOS(NOME_FUNC, END_FUNC, SAL_FUNC, SEXO_FUNC) values('OLAVO LINHARES', 'RUA C', 580, 'M');
insert into TB_FUNCIONARIOS(NOME_FUNC, END_FUNC, SAL_FUNC, SEXO_FUNC) values('PAULA DA SILVA', 'RUA D', 3000, 'F');
insert into TB_FUNCIONARIOS(NOME_FUNC, END_FUNC, SAL_FUNC, SEXO_FUNC) values('ROLANDO ROCHA', 'RUA E', 2000, 'M');

insert into TB_DEPENDENTES(COD_FUNC, NOME_DEP, SEXO_DEP) values(1, 'ANA PEREIRA', 'F');
insert into TB_DEPENDENTES(COD_FUNC, NOME_DEP, SEXO_DEP) values(1, 'ROBERTO PEREIRA', 'M');
insert into TB_DEPENDENTES(COD_FUNC, NOME_DEP, SEXO_DEP) values(1, 'CELSO PEREIRA', 'M');
insert into TB_DEPENDENTES(COD_FUNC, NOME_DEP, SEXO_DEP) values(3, 'BRISA LINHARES', 'F');
insert into TB_DEPENDENTES(COD_FUNC, NOME_DEP, SEXO_DEP) values(3, 'MARI SOL LINHARES', 'F');
insert into TB_DEPENDENTES(COD_FUNC, NOME_DEP, SEXO_DEP) values(4, 'SONIA DA SILVA', 'F');

insert into TB_TITULOS(COD_CAT, COD_GRAV, NOME_CD, VAL_CD, QTD_ESTQ) values(1, 1, 'TRIBALISTAS', 30, 1500);
insert into TB_TITULOS(COD_CAT, COD_GRAV, NOME_CD, VAL_CD, QTD_ESTQ) values(1, 2, 'TROPICALIA', 50, 500);
insert into TB_TITULOS(COD_CAT, COD_GRAV, NOME_CD, VAL_CD, QTD_ESTQ) values(1, 1, 'AQUELE ABRACO', 50, 600);
insert into TB_TITULOS(COD_CAT, COD_GRAV, NOME_CD, VAL_CD, QTD_ESTQ) values(1, 2, 'REFAZENDA', 60, 1000);
insert into TB_TITULOS(COD_CAT, COD_GRAV, NOME_CD, VAL_CD, QTD_ESTQ) values(1, 3, 'TOTALMENTE DEMAIS', 50, 2000);
insert into TB_TITULOS(COD_CAT, COD_GRAV, NOME_CD, VAL_CD, QTD_ESTQ) values(1, 3, 'TRAVESSIA', 55, 500);
insert into TB_TITULOS(COD_CAT, COD_GRAV, NOME_CD, VAL_CD, QTD_ESTQ) values(1, 2, 'COURAGE', 30, 200);
insert into TB_TITULOS(COD_CAT, COD_GRAV, NOME_CD, VAL_CD, QTD_ESTQ) values(4, 3, 'LEGIAO URBANA', 20, 100);
insert into TB_TITULOS(COD_CAT, COD_GRAV, NOME_CD, VAL_CD, QTD_ESTQ) values(3, 2, 'THE BEATLES', 30, 300);
insert into TB_TITULOS(COD_CAT, COD_GRAV, NOME_CD, VAL_CD, QTD_ESTQ) values(4, 1, 'RITA LEE', 30, 500);

insert into TB_PEDIDOS(COD_CLI, COD_FUNC, DATA_PED, VAL_PED) values(1, 2, '02/05/02', 1500);
insert into TB_PEDIDOS(COD_CLI, COD_FUNC, DATA_PED, VAL_PED) values(3, 4, '02/05/02', 50);
insert into TB_PEDIDOS(COD_CLI, COD_FUNC, DATA_PED, VAL_PED) values(4, 7, '02/06/02', 100);
insert into TB_PEDIDOS(COD_CLI, COD_FUNC, DATA_PED, VAL_PED) values(1, 4, '02/02/03', 200);
insert into TB_PEDIDOS(COD_CLI, COD_FUNC, DATA_PED, VAL_PED) values(7, 5, '02/03/03', 300);
insert into TB_PEDIDOS(COD_CLI, COD_FUNC, DATA_PED, VAL_PED) values(4, 4, '02/03/03', 100);
insert into TB_PEDIDOS(COD_CLI, COD_FUNC, DATA_PED, VAL_PED) values(5, 5, '02/03/03', 50);
insert into TB_PEDIDOS(COD_CLI, COD_FUNC, DATA_PED, VAL_PED) values(8, 2, '02/03/03', 50);
insert into TB_PEDIDOS(COD_CLI, COD_FUNC, DATA_PED, VAL_PED) values(2, 2, '02/03/03', 2000);
insert into TB_PEDIDOS(COD_CLI, COD_FUNC, DATA_PED, VAL_PED) values(7, 1, '02/03/03', 3000);

insert into TB_TITULOS_ARTISTA(COD_TIT, COD_ART) values(1, 1);
insert into TB_TITULOS_ARTISTA(COD_TIT, COD_ART) values(2, 2);
insert into TB_TITULOS_ARTISTA(COD_TIT, COD_ART) values(3, 2);
insert into TB_TITULOS_ARTISTA(COD_TIT, COD_ART) values(4, 2);
insert into TB_TITULOS_ARTISTA(COD_TIT, COD_ART) values(5, 3);
insert into TB_TITULOS_ARTISTA(COD_TIT, COD_ART) values(6, 4);
insert into TB_TITULOS_ARTISTA(COD_TIT, COD_ART) values(7, 4);
insert into TB_TITULOS_ARTISTA(COD_TIT, COD_ART) values(8, 5);
insert into TB_TITULOS_ARTISTA(COD_TIT, COD_ART) values(9, 6);
insert into TB_TITULOS_ARTISTA(COD_TIT, COD_ART) values(10, 7);

insert into TB_TITULOS_PEDIDO(NUM_PED, COD_TIT, QTD_CD, VAL_CD) values(1, 1, 2, 30);
insert into TB_TITULOS_PEDIDO(NUM_PED, COD_TIT, QTD_CD, VAL_CD) values(1, 2, 3, 20);
insert into TB_TITULOS_PEDIDO(NUM_PED, COD_TIT, QTD_CD, VAL_CD) values(2, 1, 1, 50);
insert into TB_TITULOS_PEDIDO(NUM_PED, COD_TIT, QTD_CD, VAL_CD) values(2, 2, 3, 30);
insert into TB_TITULOS_PEDIDO(NUM_PED, COD_TIT, QTD_CD, VAL_CD) values(3, 1, 2, 40);
insert into TB_TITULOS_PEDIDO(NUM_PED, COD_TIT, QTD_CD, VAL_CD) values(4, 2, 3, 20);
insert into TB_TITULOS_PEDIDO(NUM_PED, COD_TIT, QTD_CD, VAL_CD) values(5, 1, 2, 25);
insert into TB_TITULOS_PEDIDO(NUM_PED, COD_TIT, QTD_CD, VAL_CD) values(6, 2, 3, 30);
insert into TB_TITULOS_PEDIDO(NUM_PED, COD_TIT, QTD_CD, VAL_CD) values(6, 3, 1, 35);
insert into TB_TITULOS_PEDIDO(NUM_PED, COD_TIT, QTD_CD, VAL_CD) values(7, 4, 2, 55);
insert into TB_TITULOS_PEDIDO(NUM_PED, COD_TIT, QTD_CD, VAL_CD) values(8, 1, 4, 60);
insert into TB_TITULOS_PEDIDO(NUM_PED, COD_TIT, QTD_CD, VAL_CD) values(9, 2, 3, 15);
insert into TB_TITULOS_PEDIDO(NUM_PED, COD_TIT, QTD_CD, VAL_CD) values(10, 7, 2, 15);

-- select * from TB_CATEGORIAS;
-- select * from TB_ESTADOS;
-- select * from TB_CIDADES order by COD_CID;
-- select * from TB_CLIENTES order by COD_CLI;
-- select * from TB_CONJUGUE order by COD_CLI;
-- select * from TB_FUNCIONARIOS order by COD_FUNC;
-- select * from TB_DEPENDENTES order by COD_DEP;
-- select * from TB_TITULOS order by COD_TIT;
-- select * from TB_PEDIDOS order by NUM_PED;
-- select * from TB_TITULOS_ARTISTA order by COD_TIT;
-- select * from TB_TITULOS_PEDIDO order by NUM_PED;