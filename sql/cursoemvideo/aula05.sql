# erase database
DROP DATABASE cadastro;
CREATE DATABASE cadastro
DEFAULT CHARACTER SET utf8
DEFAULT COLLATE utf8_general_ci;

USE cadastro;

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

INSERT INTO pessoas(nome, nascimento, sexo, peso, altura, nacionalidade)
VALUES
('Lucas', '2001-07-03', 'M', '49', '1.65', 'Brasil'),
('Casey', '2002-07-03', 'F', '67', '1.75', 'EUA'),
('Josh', '2001-03-28', 'M', '52', '1.62', 'Alemanha'),
('Jacob', '1999-08-22', 'M', '46', '1.58', DEFAULT),
('Clhoe', '2003-08-23', 'F', '45', '1.55', DEFAULT),
('Joey', '2000-03-21', 'M', '73', '1.81', 'Mexico');

SELECT * FROM pessoas;
