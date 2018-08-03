insert into TableAgenda Values ('André','Lancelotte','1968/06/07')
insert into TableAgenda Values ('Felipe','Lancelotte','1998/06/21')
insert into TableAgenda Values ('Karla','Lancelotte','1975/06/14')
insert into TableAgenda Values ('Teste','Lancelotte','2000/06/12')

select * from TableAgenda where Nome = 'André'
select * from TableAgenda where Sobrenome = 'Lancelotte'
select * from TableAgenda where Sobrenome = 'Teste'
select * from TableAgenda where Sobrenome = 't'
select * from TableAgenda where Nome = ''

delete from TableAgenda where nome = 'André'
delete from TableAgenda where nome = 'Teste'
delete from TableAgenda where Sobrenome = 'Lancelotte'


select * from TableAgenda where DAY( DataNascimento)> DAY(CURRENT_TIMESTAMP)  AND MONTH(DataNascimento) = MONTH(CURRENT_TIMESTAMP) ORDER BY DAY(DataNascimento)ASC

select * from TableAgenda where MONTH(DataNascimento) > MONTH(CURRENT_TIMESTAMP) ORDER BY MONTH(DataNascimento), DAY(DataNascimento)ASC 
 
select * from TableAgenda where MONTH(DataNascimento) < MONTH(CURRENT_TIMESTAMP) ORDER BY MONTH(DataNascimento), DAY(DataNascimento)ASC 

select * from TableAgenda where DAY( DataNascimento) < DAY(CURRENT_TIMESTAMP)  AND MONTH(DataNascimento) = MONTH(CURRENT_TIMESTAMP) ORDER BY DAY(DataNascimento)ASC

select * from TableAgenda where DAY( DataNascimento) = DAY(CURRENT_TIMESTAMP) AND MONTH(DataNascimento) = MONTH(CURRENT_TIMESTAMP) ORDER BY YEAR(DataNascimento)ASC