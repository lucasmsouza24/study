# Criação de bando de dados com codificação utf-8
CREATE DATABASE cadastro
DEFAULT CHARACTER SET utf8
DEFAULT COLLATE utf8_general_ci;

USE cadastro;

# Criação de tabela com algumas constraints

/*
	NOT NULL -> impede que o campo receba NULL como valor;
	AUTO_INCREMENT -> valor que aumenta automaticamente a cada registro;
	DEFAULT -> define algum valor padrão;
*/

/*
	DATA TYPES:
	INT -> valor inteiro entre -2147483648 e 2147483647;
	VARCHAR(M) -> string com uma length maxima igual à M;
	DATE -> string de data com o seguinte modelo: yyyy-mm-dd;
	ENUM(M, N) -> permite apenas os valores M ou N;
	DECIMAL(M, N) -> número com ponto flutuante,
		onde M é a quantidade de casas (contando as decimais)
		e N especifica a quantidade de casas decimais;
*/

CREATE TABLE pessoas(
id INT NOT NULL AUTO_INCREMENT,
nome VARCHAR(30) NOT NULL,
nascimento DATE NOT NULL,
sexo ENUM('M', 'F'),
peso DECIMAL(5, 2),
altura DECIMAL(3, 2),
nacionalidade VARCHAR(15) DEFAULT 'Brasil',
PRIMARY KEY(id)
) DEFAULT CHARSET = utf8;

DESC pessoas;

/*
test
CREATE TABLE test(
numero int);

INSERT INTO test(numero) VALUES(0);
INSERT INTO test(numero) VALUES(1);
INSERT INTO test(numero) VALUES(10);
INSERT INTO test(numero) VALUES(11);
INSERT INTO test(numero) VALUES(100);
INSERT INTO test(numero) VALUES(101);
INSERT INTO test(numero) VALUES(110);
INSERT INTO test(numero) VALUES(111);
INSERT INTO test(numero) VALUES(1000);
INSERT INTO test(numero) VALUES(1001);
INSERT INTO test(numero) VALUES(1010);
INSERT INTO test(numero) VALUES(1011);
INSERT INTO test(numero) VALUES(1100);
INSERT INTO test(numero) VALUES(1101);
INSERT INTO test(numero) VALUES(1110);
INSERT INTO test(numero) VALUES(1111);
INSERT INTO test(numero) VALUES(10000);
INSERT INTO test(numero) VALUES(10001);
INSERT INTO test(numero) VALUES(10010);
INSERT INTO test(numero) VALUES(10011);
INSERT INTO test(numero) VALUES(10100);
INSERT INTO test(numero) VALUES(10101);
INSERT INTO test(numero) VALUES(10110);
INSERT INTO test(numero) VALUES(10111);
INSERT INTO test(numero) VALUES(11000);
INSERT INTO test(numero) VALUES(11001);
INSERT INTO test(numero) VALUES(11010);
INSERT INTO test(numero) VALUES(11011);
INSERT INTO test(numero) VALUES(11100);
INSERT INTO test(numero) VALUES(11101);
INSERT INTO test(numero) VALUES(11110);
INSERT INTO test(numero) VALUES(11111);
INSERT INTO test(numero) VALUES(100000);

SELECT * FROM test;
*/

# erase database
DROP DATABASE cadastro;