# aula06 - alterando tabelas

DROP DATABASE cadastro;

CREATE DATABASE cadastro
DEFAULT CHARACTER SET utf8
DEFAULT COLLATE utf8_general_ci;

USE cadastro;

CREATE TABLE pessoas(
id INT NOT NULL AUTO_INCREMENT,
nome VARCHAR(30) NOT NULL,
nascimento DATE NOT NULL,
sexo enum('M', 'F'),
peso DECIMAL(5,2),
altura DECIMAL(3,2),
nacionalidade VARCHAR(15) DEFAULT 'Brasil',
PRIMARY KEY(id)
) DEFAULT CHARSET = utf8;

INSERT INTO pessoas(nome, nascimento, sexo, peso, altura, nacionalidade) VALUES
('Lucas', '2001-07-03', 'M', '49', '1.65', 'Brasil'),
('Casey', '2002-07-03', 'F', '67', '1.75', 'EUA'),
('Josh', '2001-03-28', 'M', '52', '1.62', 'Alemanha'),
('Jacob', '1999-08-22', 'M', '46', '1.58', DEFAULT),
('Clhoe', '2003-08-23', 'F', '45', '1.55', DEFAULT),
('Joey', '2000-03-21', 'M', '73', '1.81', 'Mexico');

# ALTER (DDL)
# create a new column in a existing table;
ALTER TABLE pessoas 
ADD COLUMN profissao VARCHAR(10);

# remove column of table
ALTER TABLE pessoas
DROP COLUMN profissao;

# create a new column in a wished position
ALTER TABLE pessoas 
ADD COLUMN profissao VARCHAR(10) 
AFTER sexo;

# create a new column on first position
/*
ALTER TABLE pessoas
ADD COLUMN profissao2 VARCHAR(10)
first;
*/

# modify column rules
/*
ALTER TABLE pessoas
MODIFY COLUMN profissao VARCHAR(20) NOT NULL DEFAULT 'desempregado';
*/

# agree modify column rules and rename column
/*
ALTER TABLE pessoas
CHANGE COLUMN profissao prof VARCHAR(30);
*/

# renaming table
/*
ALTER TABLE pessoas
RENAME TO newname;
*/

SELECT * FROM pessoas;
DESC pessoas;

# create a new table just if this not exists;
CREATE TABLE IF NOT EXISTS cursos(
	nome VARCHAR(30) NOT NULL UNIQUE, # UNIQUE constraint define column value as unique
	descricao TEXT,
	carga INT UNSIGNED, # UNSIGNED constrait ignores negative values
	totalaulas INT UNSIGNED,
	ano YEAR DEFAULT '2016'
) DEFAULT CHARSET = utf8;

ALTER TABLE cursos
ADD COLUMN id_curso INT FIRST;

ALTER TABLE cursos
ADD PRIMARY KEY(id_curso);

DESC cursos;