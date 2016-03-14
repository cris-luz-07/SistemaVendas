﻿CREATE DATABASE BDCADASTRO

USE BDCADASTRO

CREATE TABLE CLIENTE (
ID INT NOT NULL IDENTITY, 
NOME VARCHAR(50) NOT NULL, 
ENDERECO VARCHAR(50), 
CEP VARCHAR(9),
BAIRRO VARCHAR(50),
CIDADE VARCHAR(50), 
UF VARCHAR(2), 
TELEFONE VARCHAR(15), 
CONSTRAINT PK_CLIENTE 
PRIMARY KEY(ID) )



