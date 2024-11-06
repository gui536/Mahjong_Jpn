CREATE DATABASE Mahjong;

USE Mahjong;

-- Tabela para Jogadores
CREATE TABLE Jogador (
    Id INT PRIMARY KEY IDENTITY,
    Nome NVARCHAR(100) NOT NULL,
    Pontuacao INT NOT NULL
);

-- Tabela para Partidas
CREATE TABLE Partida (
    Id INT PRIMARY KEY IDENTITY,
    Jogador1Id INT FOREIGN KEY REFERENCES Jogador(Id),
    Jogador2Id INT FOREIGN KEY REFERENCES Jogador(Id),
    VencedorId INT FOREIGN KEY REFERENCES Jogador(Id)
);
