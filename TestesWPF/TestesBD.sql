create database MeusAlunos; 
use MeusAlunos;
create table DadosAlunos (
id integer  primary key,
Nome varchar(30),
Nota1 float,
Nota2 float,
Ano varchar(10),

);

 
 insert into DadosAlunos values (1,'João', 5, 10, '2023'), (2,'João', 7, 5, '2022'),
(3,'Carlos', 3, 7, '2023'), (4,'João', 2, 10, '2022'), (5,'Vinicius', 4, 6, '2022'), (6,'Vinicius', 3.1, 7.7, '2022');


CREATE VIEW info_alunos 
AS
select dadosalunos.id, dadosalunos.Nome as 'Nome do aluno', dadosalunos.Nota1 as
'Nota do primeiro semestre', dadosalunos.Nota2 as 'Nota do segundo Semestre', (dadosalunos.nota1 + dadosalunos.nota2)/2.0 as 'Média Anual',
dadosalunos.ano as "Ano", CASE WHEN (dadosalunos.nota1 + dadosalunos.nota2)/2.0 > 6 THEN 'Aprovado' ELSE 'Reprovado' END as status from dadosalunos;

select * from info_alunos;

create view info_alunosMaior6 as select dadosalunos.id, dadosalunos.Nome as "Nome do aluno", dadosalunos.Nota1 as

'Nota do primeiro semestre', dadosalunos.Nota2 as 'Nota do segundo Semestre', (dadosalunos.nota1 + dadosalunos.nota2)/2.0 as 'Média Anual',
dadosalunos.ano as 'Ano', CASE WHEN (dadosalunos.nota1 + dadosalunos.nota2)/2.0 > 6 THEN 'Aprovado' ELSE 'Reprovado' END as status from dadosalunos where
(dadosalunos.nota1 + dadosalunos.nota2)/2.0 > 6;


select * from info_alunosMaior6;