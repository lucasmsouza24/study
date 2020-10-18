drop database dbLivraria;
create database dbLivraria;
use dbLivraria;

create table tbGenero(
idgenero int not null auto_increment,
descricao varchar(100) not null,
primary key(idgenero)
);

create table tbLivro(
idLivro int not null auto_increment,
tituloLivro varchar(100) not null unique,
precoLivro decimal(9,2) not null,
estoqueLivro int not null,
idgenero int,
primary key(idLivro),
foreign key(idgenero) references tbGenero(idgenero)
);

create table tbCliente(
idCliente int not null auto_increment unique,
nomeCliente varchar(100) not null,
telefoneCliente varchar(45),
primary key(idCliente)
);

create table tbAutor(
idAutor int auto_increment not null unique,
nomeAutor varchar(100) not null,
emailAutor varchar(100) not null, 
primary key(idAutor)
);

create table tbEscreve(
idLivro int not null,
idAutor int not null,
foreign key(idLivro) references tbLivro(idLivro),
foreign key(idAutor) references tbAutor(idAutor) 
);

create table tbVenda(
idVenda int not null auto_increment unique,
dataVenda datetime not null,
totalVenda decimal(9, 2) not null,
idCliente int,
primary key(idVenda),
foreign key(idCliente) references tbCliente(idCliente)
);
 
create table tbItens_da_venda(
idvenda int not null,
idlivro int not null,
qtdItens int not null,
subtotal varchar(45) not null,
foreign key(idvenda) references tbVenda(idVenda),
foreign key(idLivro) references tbLivro(idLivro)
);

insert into tbGenero(descricao) values('Historia');
insert into tbLivro(tituloLivro, precoLivro, estoqueLivro, idgenero) values('Sapiens: Uma breve história da humanidade', 31.90, 43, 1);
insert into tbCliente(nomeCliente, telefoneCliente) values('Lucas', '4444-4444');
insert into tbAutor(nomeAutor, emailAutor) values('Yuval Noah Harari', 'harari@gmail.com');
insert into tbEscreve(idLivro, idAutor) values(1, 1);
-- insert into tbVenda() values();
-- insert into tbItens_da_venda() values();

