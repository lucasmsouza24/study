# UPDATE, DELETE e TRUNCATE

DROP DATABASE cadastro;
CREATE DATABASE IF NOT EXISTS cadastro
DEFAULT CHARACTER SET utf8
DEFAULT COLLATE utf8_general_ci;

USE CADASTRO;

CREATE TABLE IF NOT EXISTS cursos(
id_curso INT NOT NULL AUTO_INCREMENT,
nome VARCHAR(30) NOT NULL UNIQUE,
descricao TEXT,
carga INT UNSIGNED,
total_aulas INT UNSIGNED,
ano YEAR DEFAULT '2016',
PRIMARY KEY(id_curso)
) DEFAULT CHARSET = utf8;

INSERT INTO cursos(nome, descricao, carga, total_aulas, ano) VALUES
('HTML4', 'CURSO DE HTML5', 40, 37, 2014),
('Algoritmos', 'Logica de Programacao', 20, 15, 2014),
('PHOTOSHOP', 'Dicas de Photoshop CC', 10, 8, 2014),
('PGP', 'Curso de PHP para iniciantes', 40, 20, 2010),
('Jarva', 'Introducao a linguagem Java', 10, 29, 2000),
('MySQL', 'Bancos de Dados MySQL', 30, 15, 2016),
('Word', 'Curso Completo de Word', 40, 30, 2016),
('Sapateado', 'Dancas Ritmicas', 40, 30, 2018),
('Cozinha Arabe', 'Aprenda a fazer Kibe', 40, 30, 2018),
('Youtuber', 'Gerar polemica e ganhar inscritos', 5, 2, 2018);

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

SELECT * FROM cursos;

# UPDATE (DML)
# modifying register value based on id;
# syntax: UPDATE table_name SET column_name = 'new value' WHERE id = 'id_value';
UPDATE cursos SET nome = 'HTML5' WHERE id_curso = 1 LIMIT 1; # LIMIT 1 limita quantidade de registros afetados (nesse caso é redundante, mas pode ser útil como prevenção)
UPDATE cursos SET nome = 'PHP', ano = 2015 WHERE id_curso = 4 LIMIT 1;
UPDATE cursos SET nome = 'Java', carga = 40, ano = 2015 WHERE id_curso = 5 LIMIT 1;

# DELETE (DML)
# delete integer register based on id = 'id_value;
# syntax: DELETE DROM table_name WHERE 
DELETE FROM cursos WHERE id_curso = 8;
DELETE FROM cursos WHERE ano = 2018 LIMIT 2;

# TRUNCATE (DML)
# delete all registers from table but conserve the structure 
/*
TRUNCATE TABLE cursos;
*/

SELECT * FROM cursos;