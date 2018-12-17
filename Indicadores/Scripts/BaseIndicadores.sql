CREATE DATABASE BaseIndicadores
GO

USE BaseIndicadores
GO

CREATE TABLE dbo.Indicadores(
	Sigla VARCHAR(10) NOT NULL,
	NomeIndicador VARCHAR(60) NOT NULL,
	UltimaAtualizacao DATETIME NOT NULL,
	Valor NUMERIC (18,4) NOT NULL,
	CONSTRAINT PK_Indicadores PRIMARY KEY (Sigla)
)
GO


INSERT INTO dbo.Indicadores
           (Sigla
           ,NomeIndicador
           ,UltimaAtualizacao
           ,Valor)
     VALUES
           ('SALARIO'
           ,'Salario minimo'
           ,'01.01.2018'
           ,954.00)


INSERT INTO dbo.Indicadores
           (Sigla
           ,NomeIndicador
           ,UltimaAtualizacao
           ,Valor)
     VALUES
           ('IPCA'
           ,'Indice Nacional de Precos ao Consumidor Amplo'
           ,'30.11.2018'
           ,-0.0021)


INSERT INTO dbo.Indicadores
           (Sigla
           ,NomeIndicador
           ,UltimaAtualizacao
           ,Valor)
     VALUES
           ('SELIC'
           ,'Taxa Referencial - Sistema de Liquidacao e Custodia'
           ,'31.10.2018'
           ,0.065)