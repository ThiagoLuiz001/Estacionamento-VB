use BdEstacionamento

create table TbCadastro(
Id int primary key identity(1,1) Not null,
Nome Nvarchar(100) Not null,
Cpf Nvarchar(15) Not null,
Nascimento Nvarchar(50) Not null,
Email Nvarchar(100) Not null,
Celular Nvarchar(18) Not null,
Cep Nvarchar(9),
UF Nvarchar(2) ,
Rua Nvarchar(50),
Bairro Nvarchar(50),
Número Nvarchar(5),
Complemento Nvarchar(50),
DtCriacao Nvarchar(30),
Ativo bit Not null,
)
go

Select * from TbCadastro
drop table TbCadastro


insert into TbCadastro (Nome,Cpf,Nascimento,Email,Celular,Cep,UF,Rua,Bairro,Número,Complemento,DtCriacao, Ativo) values ( 'Pedro','000.000.000-00',10/02/2000,'kaltoum8503@uorak.com','3200000-0000',68552-053,'PA','Rua C-Dezoito','Capuava',234,'Casa', '02/04/2024', 1)
insert into TbCadastro (Nome,Cpf,Nascimento,Email,Celular,Cep,UF,Rua,Bairro,Número,Complemento,DtCriacao,Ativo) values ( 'Paulo','111.111.111-11',01/01/2001,'ingo6954@uorak.com','32-10000-0000',59630-620,'RN','Rua Ventura Almeida Soares','Rincão',564,'Casa', '02/02/2024',1)
insert into TbCadastro (Nome,Cpf,Nascimento,Email,Celular,Cep,UF,Rua,Bairro,Número,Complemento,DtCriacao,Ativo) values ( 'Alice','222.222.222-22',02/02/2002,'hristo2358@uorak.com','32-20000-00',72235-406,'DF','Quadra QNP 24 Conjunto F','Ceilândia Sul',674,'Casa', '02/02/2024',1)
insert into TbCadastro (Nome,Cpf,Nascimento,Email,Celular,Cep,UF,Rua,Bairro,Número,Complemento,DtCriacao,Ativo) values ( 'Mônica','333.333.333-33',03/03/2003,'hrachya1740@uorak.com','32-30000-00',63119-370,'CE','Rua Maestro Azul','Vila Alta',742,'Casa', '02/02/2024',1)
insert into TbCadastro (Nome,Cpf,Nascimento,Email,Celular,Cep,UF,Rua,Bairro,Número,Complemento,DtCriacao,Ativo) values (' Flavia','444.444.444-44',04/04/2004,'herminda9015@uorak.com','32-40000-00',13409-325,'SP','Alameda Doze','Vivendas Bela Vista',973,'Casa', '02/02/2024',1)
insert into TbCadastro (Nome,Cpf,Nascimento,Email,Celular,Cep,UF,Rua,Bairro,Número,Complemento,DtCriacao,Ativo) values (' Alexandre','555.555.555-55',05/05/2005,'mfaddal1426@uorak.com','32-50000-00',64011-688,'PI','Quadra B1','Aroeiras',257,'Casa', '02/02/2024',1)
insert into TbCadastro (Nome,Cpf,Nascimento,Email,Celular,Cep,UF,Rua,Bairro,Número,Complemento,DtCriacao,Ativo) values (' Giovanni','666.666.666-66',06/06/2005,'kleber3580@uorak.com','32-60000-00',31960-080,'MG','Rua Agenor de Abreu','Goiânia',325,'Casa', '02/02/2024',1)
insert into TbCadastro (Nome,Cpf,Nascimento,Email,Celular,Cep,UF,Rua,Bairro,Número,Complemento,DtCriacao,Ativo) values (' Renato','777.777.777-77',07/07/2005,'clemmie3874@uorak.com','32-70000-00',77023-498,'TO','Quadra 1004 Sul Alameda 9','Plano Diretor Sul',574,'Casa', '02/02/2024',1)
insert into TbCadastro (Nome,Cpf,Nascimento,Email,Celular,Cep,UF,Rua,Bairro,Número,Complemento,DtCriacao,Ativo) values (' Arthur','888.888.888-88',08/08/2005,'magyar3694@uorak.com','32-80000-00',60822-281,'CE','Avenida Minervina Moreira','Cambeba',127,'Casa', '02/02/2024',1)
insert into TbCadastro (Nome,Cpf,Nascimento,Email,Celular,Cep,UF,Rua,Bairro,Número,Complemento,DtCriacao,Ativo) values (' Luis','999.999.999-99',09/09/2005,'britany4883@uorak.com','32-90000-00',72870-271,'GO','Rua 7','Novo Jardim Oriente',754,'Casa', '02/02/2024',1)
insert into TbCadastro (Nome,Cpf,Nascimento,Email,Celular,Cep,UF,Rua,Bairro,Número,Complemento,DtCriacao,Ativo) values (' Miguel','121.212.122-12',10/10/2005,'daisey9163@uorak.com','32-11000-00',57051-210,'AL','Rua Doutor Adalberto Marroquim','Farol',598,'Casa', '02/02/2024',1)
insert into TbCadastro (Nome,Cpf,Nascimento,Email,Celular,Cep,UF,Rua,Bairro,Número,Complemento,DtCriacao,Ativo) values (' Lara','343.434.434-43',11/11/2005,'kai6675@uorak.com','32-01000-00',59101-000,'RN','Rua Porto Rico','Igapó',082,'Casa', '02/02/2024',1)
insert into TbCadastro (Nome,Cpf,Nascimento,Email,Celular,Cep,UF,Rua,Bairro,Número,Complemento,DtCriacao,Ativo) values (' Laura','656.656.656-65',12/12/2005,'noraida5003@uorak.com','32-12000-00',69902-446,'AC','Travessa Neves','Eldorado',042,'Casa', '02/02/2024',1)
insert into TbCadastro (Nome,Cpf,Nascimento,Email,Celular,Cep,UF,Rua,Bairro,Número,Complemento,DtCriacao,Ativo) values (' Sophia','787.788.787-87',13/12/2005,'nita3463@uorak.com','32-13000-00',79022-240,'MS','Rua Utiariti','Vila Rica',749,'Casa', '02/02/2024',1)
insert into TbCadastro (Nome,Cpf,Nascimento,Email,Celular,Cep,UF,Rua,Bairro,Número,Complemento,DtCriacao,Ativo) values (' Isabella','989.989.888.98',14/12/2005,'lenin4930@uorak.com','32-14000-00',59155-530,'RN','Rua da Independência','Liberdade',134,'Casa', '02/02/2024',1)
insert into TbCadastro (Nome,Cpf,Nascimento,Email,Celular,Cep,UF,Rua,Bairro,Número,Complemento,DtCriacao,Ativo) values (' Rafaella','321.231.546-54',15/12/2005,'bertram4880@uorak.com','32-15000-00',69088-380,'AM','Rua das Perpétuas','Jorge Teixeira',987,'Casa', '02/02/2024',1)
insert into TbCadastro (Nome,Cpf,Nascimento,Email,Celular,Cep,UF,Rua,Bairro,Número,Complemento,DtCriacao,Ativo) values (' Cristina','567.331.746-83',16/12/2005,'buenviaje4353@uorak.com','32-16000-00',57084-156,'AL','Condomínio Recanto das Orquídias','Benedito Bentes',981,'Casa', '02/02/2024',1)
insert into TbCadastro (Nome,Cpf,Nascimento,Email,Celular,Cep,UF,Rua,Bairro,Número,Complemento,DtCriacao,Ativo) values ( 'Jose','965.346.695-25',17/12/2005,'halimatou4755@uorak.com','32-17000-00',31570-080,'MG','Rua Norico Furtado da Silva','Letícia',871,'Casa', '02/02/2024',1)
insert into TbCadastro (Nome,Cpf,Nascimento,Email,Celular,Cep,UF,Rua,Bairro,Número,Complemento,DtCriacao,Ativo) values (' Marcos','789.346.348-48',18/12/2005,'paula4069@uorak.com','32-18000-00',29172-784,'ES','Rua dos Lírios','Vila Nova de Colares',133,'Casa',' 02/02/2024',1)
insert into TbCadastro (Nome,Cpf,Nascimento,Email,Celular,Cep,UF,Rua,Bairro,Número,Complemento,DtCriacao,Ativo) values ( 'Tulio','012.458.575-23',19/12/2005,'fenna4264@uorak.com','32-19000-00',64210-040,'PI','Rua Professora Clarice Araújo da Silva','Dirceu Arcoverde',238,'Casa', '02/02/2024',1)


Select * from TbCadastro


drop Table TbEntrada

create table TbEntrada(
Id int primary key identity(1,1) Not null,
Placa nvarchar(10) Not null,
Modelo Nvarchar(50) Not null,
Cor Nvarchar(20) Not null,
Cpf Nvarchar(15) Not null,
Entrada datetime Not null,
Vaga Nvarchar(50) Not null,
Ativo bit Not null,
)
go

insert into TbEntrada (Placa,Modelo,Cor,Cpf,Entrada,Vaga,Ativo) Values ('IDT-0248','BMW','Verde','000.000.000-00','2024-02-01 12:30',1,1)
insert into TbEntrada (Placa,Modelo,Cor,Cpf,Entrada,Vaga,Ativo) Values ('IAA-9154','BMW','Vermelho','012.458.575-23','2024-02-01 12:40',2,1)
insert into TbEntrada (Placa,Modelo,Cor,Cpf,Entrada,Vaga,Ativo) Values ('KCY-1494','BMW','Roxo','111.111.111-11','2024-02-01 12:50',3,1)
insert into TbEntrada (Placa,Modelo,Cor,Cpf,Entrada,Vaga,Ativo) Values ('MUX-0607','BMW','Amarelo','222.222.222-22','2024-02-01 12:60',4,1)
insert into TbEntrada (Placa,Modelo,Cor,Cpf,Entrada,Vaga,Ativo) Values ('KBC-0832','BMW','Laranja','333.333.333-33','2024-02-01 12:00',5,1)
insert into TbEntrada (Placa,Modelo,Cor,Cpf,Entrada,Vaga,Ativo) Values ('KEM-4583','BMW','Rosa','444.444.444-44','2024-02-01 11:30',6,1)
insert into TbEntrada (Placa,Modelo,Cor,Cpf,Entrada,Vaga,Ativo) Values ('MXG-7025','BMW','Prata','555.555.555-55','2024-02-01 13:30',7,1)
insert into TbEntrada (Placa,Modelo,Cor,Cpf,Entrada,Vaga,Ativo) Values ('JKJ-7860','BMW','Preto','666.666.666-66','2024-02-01 14:30',8,1)
insert into TbEntrada (Placa,Modelo,Cor,Cpf,Entrada,Vaga,Ativo) Values ('JTK-1298','BMW','Dourado','777.777.777-77','2024-02-01 15:30',9,1)
insert into TbEntrada (Placa,Modelo,Cor,Cpf,Entrada,Vaga,Ativo) Values ('JGA-5955','BMW','Branco','888.888.888-88','2024-02-01 16:30',10,1)
insert into TbEntrada (Placa,Modelo,Cor,Cpf,Entrada,Vaga,Ativo) Values ('MDQ-4892','BMW','Cinza','999.999.999-99','2024-02-01 17:30',11,1)
insert into TbEntrada (Placa,Modelo,Cor,Cpf,Entrada,Vaga,Ativo) Values ('FXA-8956','BMW','Preto','121.212.122-12','2024-02-01 18:30',12,1)
insert into TbEntrada (Placa,Modelo,Cor,Cpf,Entrada,Vaga,Ativo) Values ('HTO-7840','BMW','Preto','343.434.434-43','2024-02-01 10:30',13,1)
insert into TbEntrada (Placa,Modelo,Cor,Cpf,Entrada,Vaga,Ativo) Values ('JVO-4437','BMW','Preto','656.656.656-65','2024-02-01 9:30',14,1)
insert into TbEntrada (Placa,Modelo,Cor,Cpf,Entrada,Vaga,Ativo) Values ('MOV-2299','BMW','Preto','787.788.787-87','2024-02-01 8:30',15,1)
insert into TbEntrada (Placa,Modelo,Cor,Cpf,Entrada,Vaga,Ativo) Values ('MWV-5779','BMW','Preto','989.989.888.98','2024-02-01 7:30',16,1)
insert into TbEntrada (Placa,Modelo,Cor,Cpf,Entrada,Vaga,Ativo) Values ('NEJ-7461','Renegade','Preto','321.231.546-54','2024-02-01 6:30',17,1)
insert into TbEntrada (Placa,Modelo,Cor,Cpf,Entrada,Vaga,Ativo) Values ('EDU-2349','BMWX1','Preto','567.331.746-83','2024-02-01 19:30',18,1)
insert into TbEntrada (Placa,Modelo,Cor,Cpf,Entrada,Vaga,Ativo) Values ('JNK-5993','BMW','Preto','965.346.695-25','2024-02-01 20:30',19,1)
insert into TbEntrada (Placa,Modelo,Cor,Cpf,Entrada,Vaga,Ativo) Values ('NAC-5700','HB20','Preto','789.346.348-48','2024-02-01 21:30',20,1)

select * from TbEntrada




create table TbVaga(
id int primary key identity (1,1) Not null,
Vaga Nvarchar(3) Not null,
Andar nvarchar (20) not null,
Ativo bit Not null,
)
go

sELECT * FROM TbVaga
insert into TbVaga (Vaga, andar, ativo) values ('A0','1°Andar', 1)
insert into TbVaga (Vaga, andar, ativo) values('A1','1°Andar', 1)
insert into TbVaga (Vaga,andar, ativo) values ('A2','1°Andar', 1)
insert into TbVaga (Vaga,andar, ativo) values ('A3','1°Andar', 1)
insert into TbVaga (Vaga,andar, ativo) values ('A4','1°Andar', 1)
insert into TbVaga (Vaga,andar, ativo) values ('A5','1°Andar', 1)
insert into TbVaga (Vaga,andar, ativo) values ('A6','1°Andar', 1)
insert into TbVaga (Vaga,andar, ativo) values ('A7','1°Andar', 1)
insert into TbVaga (Vaga,andar, ativo) values ('A8','1°Andar', 1)
insert into TbVaga (Vaga,andar, ativo) values ('A9','1°Andar', 1)
insert into TbVaga (Vaga,andar, ativo) values ('B0','2°Andar', 1)
insert into TbVaga (Vaga,andar, ativo) values ('B1','2°Andar', 1)
insert into TbVaga (Vaga,andar, ativo) values ('B2','2°Andar', 1)
insert into TbVaga (Vaga,andar, ativo) values ('B3','2°Andar', 1)
insert into TbVaga (Vaga,andar, ativo) values ('B4','2°Andar', 1)
insert into TbVaga (Vaga,andar, ativo) values ('B5','2°Andar', 1)
insert into TbVaga (Vaga,andar, ativo) values ('B6','2°Andar', 1)
insert into TbVaga (Vaga,andar, ativo) values ('B7','2°Andar', 1)
insert into TbVaga (Vaga,andar, ativo) values ('B8','2°Andar', 1)
insert into TbVaga (Vaga,andar, ativo) values ('B9','2°Andar', 1)
insert into TbVaga (Vaga,andar, ativo) values ('C0','3°Andar', 1)
insert into TbVaga (Vaga,andar, ativo) values ('C1','3°Andar', 1)
insert into TbVaga (Vaga,andar, ativo) values ('C2','3°Andar', 1)
insert into TbVaga (Vaga,andar, ativo) values ('C3','3°Andar', 1)
insert into TbVaga (Vaga,andar, ativo) values ('C4','3°Andar', 1)
insert into TbVaga (Vaga,andar, ativo) values ('C5','3°Andar', 1)
insert into TbVaga (Vaga,andar, ativo) values ('C6','3°Andar', 1)
insert into TbVaga (Vaga,andar, ativo) values ('C7','3°Andar', 1)
insert into TbVaga (Vaga,andar, ativo) values ('C8','3°Andar', 1)
insert into TbVaga (Vaga,andar, ativo) values ('C9','3°Andar', 1)

select * from TbVaga