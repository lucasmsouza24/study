/*Começo padrão*/
DROP DATABASE pets;
CREATE DATABASE pets;
USE pets;

CREATE TABLE cats(
id INT NOT NULL AUTO_INCREMENT,
name VARCHAR(150) NOT NULL,
owner VARCHAR(150) NOT NULL, 
birth DATE NOT NULL,
PRIMARY KEY(id)
);

CREATE TABLE people(
id INT NOT NULL AUTO_INCREMENT,
first_name VARCHAR(30) NOT NULL,
last_name VARCHAR(30) NOT NULL,
birth DATE NOT NULL,
email VARCHAR(30) NOT NULL,
PRIMARY KEY(id)
);

INSERT INTO people(first_name, last_name, birth, email) VALUES
("Lucas", "Mesquita", "2001-07-03", "lucasmesquita58@hotmail.com"),
("Andressa", "Maria", "2000-11-09", "andressa11@hotmail.com"),
("Roberto", "Pires", "1982-04-23", "roberto19@hotmail.com"),
("Alice", "Mesquita", "2011-12-28", "amesquita28@hotmail.com"),
("Claudia", "Mesquita", "1977-08-29", "cmesquita29@hotmail.com"),
("Laura", "Mesquita", "2007-03-21", "lmesquita21@hotmail.com"),
("Casey", "Saint", "1999-09-12", "csaint12@hotmail.com"),
("Clark", "Kent", "1998-05-30", "ckent30@hotmail.com"),
("Joseph", "Tyler", "1991-08-20", "jtyler20@hotmail.com"),
("Joey", "Silver", "2000-02-20", "jsilver20@hotmail.com"),
("John", "Frusciant", "2004-03-16", "jfrusc16@hotmail.com"),
("test", "test", "2020-09-12", "test@test.com");

SELECT * FROM people;
SELECT * FROM people WHERE last_name = "Mesquita";
/*

SHOW TABLES;

DESC cats;

INSERT INTO cats(name, owner, birth) VALUES
('Sandy', 'Lennon', '2015-01-03'),
('Cookie', 'Casey', '2013-11-13'),
('Charlie', 'River', '2016-05-21');

SELECT * FROM cats;*/