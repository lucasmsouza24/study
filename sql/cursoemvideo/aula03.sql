DROP DATABASE cadastro;
CREATE DATABASE cadastro;

USE cadastro;

CREATE TABLE pessoas(
nome VARCHAR(30),
idade INT,
sexo CHAR(1),
peso DECIMAL,
altura DECIMAL,
nacionalidade VARCHAR(15)
);

DESC pessoas;