create database myfinance;

use myfinance;

create table planoconta(
id int identity(1,1) not null,
nome varchar(50) not null,
tipo char(1) not null,
primary key (id)
);

create table transacao(
id int identity(1,1) not null,
historico varchar(100) null,
data datetime null,
valor decimal(9,2)
planocontaid
primary key (id),
foreign key (planocontaid) references planoconta(id)
);

insert into planoconta(nome, tipo) values('Combustível', 'D')
insert into planoconta(nome, tipo) values('Alimentação', 'D')
insert into planoconta(nome, tipo) values('Saúde', 'D')
insert into planoconta(nome, tipo) values('Carro', 'D')
insert into planoconta(nome, tipo) values('Salário', 'R')
insert into planoconta(nome, tipo) values('Juros Recebidos', 'R')
insert into planoconta(nome, tipo) values('Créditos de Dividendos', 'R')
insert into planoconta(nome, tipo) values('Restituição de IR', 'R')

select * from planoconta

SET DATEFORMAT dmy;
insert into transacao(historico, data, valor, planocontaid) values('Combustível Blazer',getdate(), 489, 1)
insert into transacao(historico, data, valor, planocontaid) values('Almoço de Domingo', '26-06-2025 12:00', 150, 2)
insert into transacao(historico, data, valor, planocontaid) values('Peças de Hardware', '28-06-2025 19:00', 1300, 4)
insert into transacao(historico, data, valor, planocontaid) values('Salário', '15-06-2025 19:00', 8500, 6)
insert into transacao(historico, data, valor, planocontaid) values('ITAU', '16-06-2025 19:00', 489, 1)

select * from transacao
