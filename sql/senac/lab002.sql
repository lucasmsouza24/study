drop database dbLab;
create database dbLab;

use dbLab;

CREATE TABLE TBPRODUTOS
(
CODIGO INT,
NOME VARCHAR(50),
TIPO VARCHAR(25),
QUANTIDADE INT,
VALOR DECIMAL(10,2)
);
INSERT INTO TBPRODUTOS ( CODIGO, NOME, TIPO, QUANTIDADE, VALOR ) VALUES ( 1,'IMPRESSORA', 'INFORMATICA', 200, 600.00);
INSERT INTO TBPRODUTOS ( CODIGO, NOME, TIPO, QUANTIDADE, VALOR ) VALUES ( 2,'CAMERA DIGITAL', 'DIGITAIS', 300, 400.00);
INSERT INTO TBPRODUTOS ( CODIGO, NOME, TIPO, QUANTIDADE, VALOR ) VALUES ( 3,'DVDPLAYER', 'ELETRONICOS', 250, 500.00);
INSERT INTO TBPRODUTOS ( CODIGO, NOME, TIPO, QUANTIDADE, VALOR ) VALUES ( 4,'MONITOR', 'INFORMATICA', 400, 900.00 );
INSERT INTO TBPRODUTOS ( CODIGO, NOME, TIPO, QUANTIDADE, VALOR ) VALUES ( 5,'TELEVISOR', 'ELETRONICOS', 350, 650.00 );
INSERT INTO TBPRODUTOS ( CODIGO, NOME, TIPO, QUANTIDADE, VALOR ) VALUES ( 6,'FILMADORA DIGITAL', 'DIGITAIS', 500, 700.00 );
INSERT INTO TBPRODUTOS ( CODIGO, NOME, TIPO, QUANTIDADE, VALOR ) VALUES ( 7,'CELULAR', 'TELEFONE', 450, 850.00 );
INSERT INTO TBPRODUTOS ( CODIGO, NOME, TIPO, QUANTIDADE, VALOR ) VALUES ( 8,'TECLADO', 'INFORMATICA', 300, 450.00 );
INSERT INTO TBPRODUTOS ( CODIGO, NOME, TIPO, QUANTIDADE, VALOR ) VALUES ( 9,'VIDEOCASSETE', 'ELETRONICOS', 200, 300.00 );
INSERT INTO TBPRODUTOS ( CODIGO, NOME, TIPO, QUANTIDADE, VALOR ) VALUES ( 10,'MOUSE', 'INFORMATICA', 400, 60.00 );

select * from TBPRODUTOS;

-- 1 Aumente em 12% o valor dos produtos cujos nomes iniciem com  a letra 'F'
update TBPRODUTOS set valor=valor*1.12 where nome like 'F%';
select * from TBPRODUTOS;

-- 2 Aumente em 50 unidades todos os produtos cujo valor seja maior que 400 e inferior a 600
update TBPRODUTOS set QUANTIDADE=QUANTIDADE+50 where valor>400 and valor<600;
select * from TBPRODUTOS;

-- 3 Aplicar um desconto de 50% em todos os produtos que as unidades de estoque sejam maiores que 300
update TBPRODUTOS set valor=valor*0.5 where QUANTIDADE>300;
select * from TBPRODUTOS;

-- 4 Exiba o produto de código 4
select * from TBPRODUTOS where CODIGO=4;

-- 5 Exibir todos os produtos que não tenham a letra 'Y'
select * from TBPRODUTOS where nome not like '%Y%';

-- 6 Exibir todos os produtos que se iniciem com o nome 'MO' e tenham como tipo as letras 'MA'
select * from TBPRODUTOS where nome like 'MO%' and tipo like '%MA%';