CREATE TABLE Servicos (
    ServicoID INT IDENTITY(1, 1) PRIMARY KEY,
    NomeServico VARCHAR(255) NOT NULL,
    DescricaoServico Varchar (200) not null,
    ValorServico Decimal (10,2) not null,
    DuracaoEmHoras DECIMAL(4, 2) NOT NULL
);
SELECT
    Agendamentos.AgendamentoID,
    Agendamentos.DataAgendamento,
    Agendamentos.NomeCliente,
    Agendamentos.Telefone,
    Agendamentos.Servico,
    Agendamentos.Descricao,
    Horarios.Hora AS HorarioAgendamento,
    Servicos.NomeServico,
    Servicos.DescricaoServico,
    Servicos.ValorServico,
    Servicos.DuracaoEmHoras
FROM
    Agendamentos
JOIN
    Horarios ON Agendamentos.FK_HorarioID = Horarios.HorarioID
JOIN
    Servicos ON Agendamentos.FK_ServicoID = Servicos.ServicoID;
------------------------------------------------
INSERT INTO Servicos (NomeServico, DescricaoServico, ValorServico, DuracaoEmHoras) VALUES 
('Corte de Cabelo Feminino', 'Corte de cabelo para mulheres', 50.00, 1),
('Corte de Cabelo Masculino', 'Corte de cabelo para homens', 30.00, 1),
('Coloração de Cabelo', 'Aplicação de tintura no cabelo', 80.00, 2),
('Manicure', 'Cuidados com as unhas', 25.00, 1),
('Pedicure', 'Cuidados com os pés e unhas', 30.00, 1),
('Maquiagem', 'Maquiagem profissional', 60.00, 1),
('Depilação', 'Remoção de pelos indesejados', 40.00, 1),
('Tratamento Facial', 'Limpeza e tratamento da pele facial', 70.00, 2),
('Massagem Relaxante', 'Massagem para relaxamento', 80.00, 1),
('Penteado para Eventos', 'Penteado elaborado para eventos especiais', 65.00, 1);

------------------------------------------------

select * from Servicos
drop table Servicos




CREATE TABLE Agendamentos (
    AgendamentoID INT IDENTITY(1, 1) PRIMARY KEY,
    FK_ServicoID INT  ,
    FK_HorarioID INT  ,
    DataAgendamento DATETIME NOT NULL,   
    NomeCliente VARCHAR(255) NOT NULL,
    Telefone Varchar (100) not null,
    Servico Varchar (100) not null,
    Descricao varchar (100),

    Foreign key (FK_ServicoID) references Servicos(ServicoID),
    Foreign key (FK_HorarioID) references Horarios(HorarioID),

);
drop table Agendamentos
select *from Agendamentos
INSERT INTO Agendamentos (FK_ServicoID, FK_HorarioID, DataAgendamento, NomeCliente, Telefone, Servico, Descricao)
VALUES
   ( '2023-11-09', 'Nome do Cliente', '123456789', 'Tipo de Serviço', 'Descrição do Agendamento');


drop table Agendamentos
CREATE TABLE Cliente (
    IdCliente      INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
    Nome           VARCHAR(50) NOT NULL,
    CPF            VARCHAR(50),
    Telefone       VARCHAR(12),
    Email          VARCHAR(50) NOT NULL,
    DataCadastro   DATETIME DEFAULT (getdate()) NOT NULL
);
select * from Cliente
--clientes falsos---------------------------------------------------------------------------------------------------
INSERT INTO Cliente (Nome, CPF, Telefone, Email) VALUES ('João Silva', '123.456.789-01', '(11) 98765-4321', 'joao.silva@email.com');
INSERT INTO Cliente (Nome, CPF, Telefone, Email) VALUES ('Maria Oliveira', '987.654.321-09', '(21) 99876-5432', 'maria.oliveira@email.com');
INSERT INTO Cliente (Nome, CPF, Telefone, Email) VALUES ('Pedro Santos', '111.222.333-44', '(31) 98765-1234', 'pedro.santos@email.com');
INSERT INTO Cliente (Nome, CPF, Telefone, Email) VALUES ('Ana Pereira', '555.666.777-88', '(41) 99876-5432', 'ana.pereira@email.com');
INSERT INTO Cliente (Nome, CPF, Telefone, Email) VALUES ('Lucas Lima', '999.888.777-66', '(51) 98765-4321', 'lucas.lima@email.com');
INSERT INTO Cliente (Nome, CPF, Telefone, Email) VALUES ('Fernanda Rocha', '444.555.666-77', '(61) 99876-5432', 'fernanda.rocha@email.com');
INSERT INTO Cliente (Nome, CPF, Telefone, Email) VALUES ('Ricardo Sousa', '777.888.999-00', '(71) 98765-1234', 'ricardo.sousa@email.com');
INSERT INTO Cliente (Nome, CPF, Telefone, Email) VALUES ('Carla Costa', '123.321.123-32', '(81) 99876-5432', 'carla.costa@email.com');
INSERT INTO Cliente (Nome, CPF, Telefone, Email) VALUES ('Gabriel Oliveira', '987.654.321-09', '(91) 98765-4321', 'gabriel.oliveira@email.com');
INSERT INTO Cliente (Nome, CPF, Telefone, Email) VALUES ('Isabela Santos', '111.222.333-44', '(01) 99876-5432', 'isabela.santos@email.com');
INSERT INTO Cliente (Nome, CPF, Telefone, Email) VALUES ('Paulo Pereira', '555.666.777-88', '(11) 98765-1234', 'paulo.pereira@email.com');
INSERT INTO Cliente (Nome, CPF, Telefone, Email) VALUES ('Mariana Lima', '999.888.777-66', '(21) 99876-5432', 'mariana.lima@email.com');
INSERT INTO Cliente (Nome, CPF, Telefone, Email) VALUES ('Matheus Rocha', '444.555.666-77', '(31) 98765-4321', 'matheus.rocha@email.com');
INSERT INTO Cliente (Nome, CPF, Telefone, Email) VALUES ('Amanda Sousa', '777.888.999-00', '(41) 99876-5432', 'amanda.sousa@email.com');
INSERT INTO Cliente (Nome, CPF, Telefone, Email) VALUES ('Daniel Costa', '123.321.123-32', '(51) 98765-1234', 'daniel.costa@email.com');
INSERT INTO Cliente (Nome, CPF, Telefone, Email) VALUES ('Larissa Oliveira', '987.654.321-09', '(61) 99876-5432', 'larissa.oliveira@email.com');
INSERT INTO Cliente (Nome, CPF, Telefone, Email) VALUES ('Tiago Santos', '111.222.333-44', '(71) 98765-4321', 'tiago.santos@email.com');
INSERT INTO Cliente (Nome, CPF, Telefone, Email) VALUES ('Camila Lima', '555.666.777-88', '(81) 99876-5432', 'camila.lima@email.com');
INSERT INTO Cliente (Nome, CPF, Telefone, Email) VALUES ('Lucas Rocha', '999.888.777-66', '(91) 98765-1234', 'lucas.rocha@email.com');
----------------------------------------------------------------------------------------------------------------------

CREATE TABLE Login
(
	IdLogin int primary key identity (1,1) NOT NULL,
	Login          VARCHAR(12) NULL,
    Senha          VARCHAR(12) NOT NULL, 
    FKCliente int not null,
	Foreign key (FKCliente) references Cliente(IdCliente)  
);

DECLARE @hora TIME = '09:00';

-- Deleta os registros existentes para reiniciar a tabela
DELETE FROM Horarios;

WHILE @hora <= '17:00'
BEGIN
    INSERT INTO Horarios (Hora, Disponivel)
    VALUES (@hora, 1); -- Assumindo que todos os horários inicialmente estão disponíveis
    SET @hora = DATEADD(HOUR, 1, @hora);
END;
 select * from Horarios
 drop table Horarios

 CREATE TABLE Horarios (
    HorarioID INT IDENTITY(1, 1) PRIMARY KEY,
    Hora TIME NOT NULL,
    Disponivel BIT NOT NULL,
);
