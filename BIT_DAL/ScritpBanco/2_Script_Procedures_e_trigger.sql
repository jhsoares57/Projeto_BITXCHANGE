use PIM5_
go

/*
Procedure para validar se o usu�rio existe e realizar login no sistema

autor: Jos� Hugo Soares de Barros
Data: 18/09/2020

Manuten��o:
Data: 20/09/2020 Autor: Hugo Descri��o: Ajuste para retornar o tipo do usu�rio
Data: 20/09/2020 Autor: Hugo Descri��o: Ajuste para remover o filtro do tipo do usu�rio
*/
GO
CREATE PROCEDURE USP_USUARIOS_SEL
@LOGIN VARCHAR(50),
@SENHA VARCHAR(100)
AS
BEGIN
	SELECT USU_INT_ID, USU_STR_NOME, USU_STR_SENHA,USU_STR_EMAIL,USU_STR_TIPO
	FROM TB_USUARIO
	WHERE USU_STR_EMAIL = @LOGIN AND USU_STR_SENHA = @SENHA
END


/*
Procedure para inserir usu�rio

autor: Jos� Hugo Soares de Barros
Data: 18/09/2020

Manuten��o:
Data: 25/10/2020 autor: Luis Suzuki Descri��o: cria��o de carteira para usu�rio mobile

*/
GO
CREATE PROCEDURE [dbo].[USP_USUARIO_INSERT]
@NOME VARCHAR(100),
@CPF CHAR(15),
@DTNASCIMENTO DATE,
@SEXO CHAR(1),
@EMAIL VARCHAR(50),
@SENHA VARCHAR(MAX),
@STATUS CHAR(1),--P - PENDENTE; A - ATIVO;
@TIPO CHAR(1),
@DTCADASTRO DATETIME,
@ID_OUT INT OUTPUT

AS
BEGIN TRY
    DECLARE @CAR_ID INT
    DECLARE @cnt INT = 0
    DECLARE @MOE_ID INT
    INSERT INTO TB_USUARIO(USU_STR_NOME,USU_STR_CPF,USU_DT_DTNASCIMENTO,USU_STR_SEXO,USU_STR_EMAIL,USU_STR_SENHA,USU_STR_STATUS,USU_STR_TIPO,USU_DT_DTCADASTRO)
    VALUES(@NOME,@CPF,@DTNASCIMENTO,@SEXO,@EMAIL,@SENHA,@STATUS,@TIPO,@DTCADASTRO)
    SET @ID_OUT = (SELECT SCOPE_IDENTITY())

    IF (@ID_OUT>0 AND @TIPO=2)
    BEGIN
        INSERT INTO TB_CARTEIRA(USU_INT_ID)
        VALUES(@ID_OUT)
    
        SET @CAR_ID = (SELECT MAX(CAR_INT_ID) FROM TB_CARTEIRA)
        SET @MOE_ID = (SELECT MIN(MOE_INT_ID) from TB_MOEDA)

        WHILE (@cnt < 4 AND @ID_OUT>0 AND @TIPO=2)
        BEGIN
            INSERT INTO TB_MOEDA_CARTEIRA(CAR_INT_ID, MOE_INT_ID, MC_DEC_SALDO)
            VALUES(@CAR_ID, @MOE_ID, 0)
            SET @cnt = @cnt + 1
            SET @MOE_ID = @MOE_ID + 1
	        IF((SELECT MAX(MOE_INT_ID) FROM TB_MOEDA_CARTEIRA WHERE CAR_INT_ID= @CAR_ID) < 4)
	        CONTINUE
            ELSE
	        BREAK
        END
    END    
END TRY

BEGIN CATCH
    SELECT   
        ERROR_NUMBER() AS ErrorNumber  
        ,ERROR_SEVERITY() AS ErrorSeverity  
        ,ERROR_STATE() AS ErrorState  
        ,ERROR_PROCEDURE() AS ErrorProcedure  
        ,ERROR_LINE() AS ErrorLine  
        ,ERROR_MESSAGE() AS ErrorMessage;
END CATCH

RETURN @ID_OUT
GO

/****************************************
Procedure para listar todos os usu�rio

autor: Jos� Hugo Soares de Barros
Data: 18/09/2020

Manuten��o:

*****************************************/
GO
CREATE PROCEDURE USP_LEVANTAR_USER
AS
BEGIN
SELECT USU_INT_ID AS [CODIGO],USU_STR_NOME AS [NOME],USU_STR_CPF AS [CPF],USU_STR_EMAIL AS [EMAIL] FROM TB_USUARIO
END

/*
Procedure para filtrar usu�rio de acordo com o nome usando like

autor: Jos� Hugo Soares de Barros
Data: 18/09/2020

Manuten��o:

*/
GO
CREATE PROCEDURE USP_FILTRAR_USER
@NOME VARCHAR(100)
AS
BEGIN
SELECT USU_INT_ID AS [CoDIGO],USU_STR_NOME AS [NOME],USU_STR_CPF AS [CPF],USU_STR_EMAIL AS [EMAIL] FROM TB_USUARIO where (USU_STR_NOME like'%'+@Nome+'%')
END


/*
Procedure para levantar usu�rio de acordo com ID

autor: Jos� Hugo Soares de Barros
Data: 18/09/2020

Manuten��o:

*/
GO
CREATE PROCEDURE USP_LEVANTAR_USER_EDITAR
@ID INT
AS
BEGIN
SELECT USU_INT_ID ,USU_STR_NOME,USU_STR_CPF,USU_DT_DTNASCIMENTO,USU_STR_SEXO,USU_STR_EMAIL,USU_STR_SENHA,USU_STR_STATUS,USU_STR_TIPO,USU_DT_DTCADASTRO FROM TB_USUARIO WHERE USU_INT_ID = @ID
END


/*
Procedure para atualizar cliente

autor: Jos� Hugo Soares de Barros
Data: 18/09/2020

Manuten��o:

*/
GO
CREATE PROCEDURE USP_USUARIO_UPDATE
@ID INT,
@NOME VARCHAR (100),
@CPF CHAR(15),
@DTNASCIMENTO DATE,
@SEXO CHAR(1),
@EMAIL VARCHAR (50),
@SENHA VARCHAR(MAX),
@STATUS CHAR(1),--P - PENDENTE; A - ATIVO;
@TIPO CHAR(1),
@DTCADASTRO DATETIME,
@ID_OUT INT OUTPUT
AS
BEGIN
UPDATE TB_USUARIO SET USU_STR_NOME=@NOME,USU_STR_CPF=@CPF,USU_DT_DTNASCIMENTO=@DTNASCIMENTO,USU_STR_SEXO=@SEXO,USU_STR_EMAIL=@EMAIL,USU_STR_SENHA=@SENHA,USU_STR_STATUS=@STATUS,USU_STR_TIPO=@TIPO,USU_DT_DTCADASTRO=@DTCADASTRO WHERE USU_INT_ID = @ID
SET @ID_OUT = @ID
RETURN @ID_OUT
END

go

/*
Procedure para listar opera��es de acordo com unica data

autor: Jos� Hugo Soares de Barros
Data: 18/09/2020

Manuten��o:
Data: 25/09/2020 autor: Jos� Hugo Descri��o: Ajustado para realizar buscas na view de transa��es
Data: 25/09/2020 autor: Jos� Hugo Descri��o: Adicionadao campo de protocolo
*/
go
CREATE PROCEDURE USP_RELATORIO_TRANSACOES
@DATAINCIAL DATETIME
AS
BEGIN
SELECT [DATA] as [Data Transferencia],TR.PROTOCOLO AS [Protocolo],USU_STR_NOME as [Nome usu�rio],'TRANSFERENCIA' as [Tipo],VALOR as [Valor],MOE_STR_SIGLA as [Moeda]  FROM VW_TRANSACOES TR
INNER JOIN TB_USUARIO USU ON USU.USU_INT_ID = TR.USUARIO
INNER JOIN TB_MOEDA M ON M.MOE_INT_ID = TR.MOEDA
WHERE [DATA] = @DATAINCIAL
END

/*
Procedure para listar opera��es de acordo com data inicial e final

autor: Jos� Hugo Soares de Barros
Data: 18/09/2020

Manuten��o:
Data: 25/09/2020 autor: Jos� Hugo Descri��o: Ajustado para realizar buscas na view de transa��es
Data: 25/09/2020 autor: Jos� Hugo Descri��o: Adicionadao campo de protocolo

*/
go
CREATE PROCEDURE USP_RELATORIO_TRANSACOES_MENSAL
@DATAINCIAL DATETIME,
@DATAFINAL DATETIME
AS
BEGIN
SELECT [DATA] as [Data Transferencia],TR.PROTOCOLO AS [Protocolo],USU_STR_NOME as [Nome usu�rio],'TRANSFERENCIA' as [Tipo],VALOR as [Valor],MOE_STR_SIGLA as [Moeda]  FROM VW_TRANSACOES TR
INNER JOIN TB_USUARIO USU ON USU.USU_INT_ID = TR.USUARIO
INNER JOIN TB_MOEDA M ON M.MOE_INT_ID = TR.MOEDA
WHERE [DATA] BETWEEN @DATAINCIAL and @DATAFINAL
END


/*
Procedure para carregar as ultimas 100 transa��es realizadas

autor: Jos� Hugo Soares de Barros
Data: 18/09/2020

Manuten��o:
Data: 25/09/2020 autor: Jos� Hugo Descri��o: Ajustado para realizar buscas na view de transa��es
Data: 25/09/2020 autor: Jos� Hugo Descri��o: Adicionadao campo de protocolo
*/
go
CREATE PROCEDURE USP_ULTIMAS_TRANSACOES
AS
BEGIN
SELECT TOP 100 [DATA] as [Data Transferencia],TR.PROTOCOLO AS [Protocolo],USU_STR_NOME as [Nome usu�rio],'TRANSFERENCIA' as [Tipo],VALOR as [Valor],MOE_STR_SIGLA as [Moeda]  FROM VW_TRANSACOES TR
INNER JOIN TB_USUARIO USU ON USU.USU_INT_ID = TR.USUARIO
INNER JOIN TB_MOEDA M ON M.MOE_INT_ID = TR.MOEDA
END

/*
Procedure para listar cota��o das moedas

autor: Jos� Hugo Soares de Barros
Data: 18/09/2020

Manuten��o:

Data: 20/11/2020 autor: Luis Henrique Descri��o: ajuste na tabela de deposito

*/
GO
CREATE PROCEDURE USP_LEVANTAR_COTACAO_MOEDA
AS
BEGIN
SELECT COT_DEC_VALORCOT,MOE_INT_ID FROM TB_COTACAO
END

/*
Procedure para listar cota��o das moedas

autor: Jos� Hugo Soares de Barros
Data: 18/09/2020

Manuten��o:

*/

GO

CREATE PROCEDURE [dbo].[USP_LEVANTAR_COTACAO]
@ID_MOEDA INT
AS
BEGIN
SELECT COT_DEC_VALORCOT FROM TB_COTACAO WHERE MOE_INT_ID = @ID_MOEDA
END
GO

go


/*
PROCEDURE PARA LEVANTAR transa��es DO USUARIO

autor: Jos� Hugo Soares de Barros
Data: 23/09/2020

Manuten��o:

Data: 25/09/2020 autor: Jos� Hugo Descri��o, ajuste para buscar a sigla da moeda
Data: 28/10/2020 autor: Jos� Hugo Descri��o, adicionado order by na data de cadastro
Data: 23/11/2020 autor: Jos� Hugo Descri��o, adicionado campos de nome e observa��o

*/
GO
CREATE PROCEDURE USP_EXTRATO_USUARIO
@USUARIO INT
AS
BEGIN
SELECT VW.DATA,VW.PROTOCOLO,VW.TIPO,VW.VALOR,M.MOE_STR_DESC AS [MOEDA], VW.NOME AS NOME, VW.OBSERVACAO
FROM VW_TRANSACOES VW
INNER JOIN TB_MOEDA M ON M.MOE_INT_ID = VW.MOEDA
 WHERE USUARIO = @USUARIO
 ORDER BY VW.DATA DESC
END

/*
PROCEDURE PARA LEVANTAR TRANSA��ES DO USUARIO

autor: Jos� Hugo Soares de Barros
Data: 12/10/2020

Manuten��o:
Data: 28/10/2020 autor: Jos� Hugo Descri��o, adicionado order by na data de cadastro

*/
GO
CREATE PROCEDURE USP_EXTRATO_USUARIO_3
@USUARIO INT
AS
BEGIN
SELECT TOP 3 VW.DATA,VW.PROTOCOLO,VW.TIPO,VW.VALOR,M.MOE_STR_DESC AS [MOEDA] FROM VW_TRANSACOES VW
INNER JOIN TB_MOEDA M on M.MOE_INT_ID = VW.MOEDA
 WHERE USUARIO = @USUARIO
 ORDER BY VW.DATA DESC
END

go


/*
PROCEDURE PARA INSERIR DADOS DA GERA��O DE BACKUP

autor: Jos� Hugo Soares de Barros
Data: 23/09/2020

Manuten��o:


*/
GO
CREATE PROCEDURE USP_INSERT_LOG_BACKUP
@DATA DATETIME,
@DATABASE VARCHAR(30),
@DIRETORIO VARCHAR(255),
@TATUS CHAR(1),
@USUARIO INT
AS
BEGIN
INSERT INTO TB_BACKUP VALUES (@DATA,@DATABASE,@DIRETORIO,@TATUS,@USUARIO)
END


/*
PROCEDURE PARA LISTAR OS ULTIMOS 20 BACKUPS EXECUTADOS

autor: Jos� Hugo Soares de Barros
Data: 23/09/2020

Manuten��o:


*/
GO
CREATE PROCEDURE USP_LISTAR_BACKUP
AS
BEGIN
SELECT TOP 20 U.USU_STR_NOME AS [USUARIO],B.BC_DT_DATA AS [DATA],B.BC_STR_DATABASE AS [BASE],B.BAC_STR_DIRETORIO AS [DIRETORIO],
CASE WHEN B.BAC_STR_STATUS = 'F' THEN 'FINALIZADO' ELSE 'ERRO' END AS [STATUS] FROM TB_BACKUP B
INNER JOIN TB_USUARIO U ON U.USU_INT_ID = B.USU_INT_ID
ORDER BY B.BAC_INT_ID DESC
END

go


/*
PROCEDURE PARA BUSCAR O SALDO DO USUARIO

autor: Jos� Hugo Soares de Barros
Data: 14/10/2020

Manuten��o:


*/
GO
CREATE PROCEDURE USP_SELECIONAR_CARTEIRA_USUARIO
@ID INT,
@MOEDA INT
AS
BEGIN
SELECT MC.MOE_INT_ID,MC.MC_DEC_SALDO FROM TB_CARTEIRA CAR 
INNER JOIN TB_MOEDA_CARTEIRA MC ON MC.CAR_INT_ID = CAR.CAR_INT_ID WHERE CAR.USU_INT_ID = @ID and MC.MOE_INT_ID = @MOEDA
END
GO

/*
PROCEDURE INSERIRI TRANSFERENCIA

autor: Jos� Hugo Soares de Barros
Data: 23/10/2020

Manuten��o:


*/
GO
CREATE PROCEDURE USP_INSERIR_TRANSFERENCIA
@TRA_STR_DESC VARCHAR(70),
@TRA_DOU_VALOR DECIMAL(9,2),
@TRA_DT_DATATRANS DATE,
@TRA_STR_PROTOCOLO VARCHAR(15),
@MOE_INT_ID INT,
@USU_INT_ID INT,
@ID_OUT INT OUTPUT
AS
BEGIN
	INSERT INTO TB_TRANSFERENCIA (TRA_STR_DESC,TRA_DOU_VALOR,TRA_DT_DATATRANS,MOE_INT_ID,USU_INT_ID,TRA_STR_PROTOCOLO)
	VALUES(@TRA_STR_DESC,@TRA_DOU_VALOR,@TRA_DT_DATATRANS,@MOE_INT_ID,@USU_INT_ID,@TRA_STR_PROTOCOLO)
	SET @ID_OUT = (SELECT SCOPE_IDENTITY())
	RETURN @ID_OUT
END

/*
TRIGGER PARA DEBITAR O SALDO AP�S TRANSFERENCIA

autor: Jos� Hugo Soares de Barros
Data: 23/10/2020

Manuten��o:


*/

GO
CREATE TRIGGER DEBITAR_MOEDAR
ON TB_TRANSFERENCIA
FOR INSERT
AS
BEGIN
DECLARE 
@MOEDA INT,
@VALOR DECIMAL,
@USUARIO INT,
@CARTEIRA INT

--ATRIBUINDO VALOR QUE FOI INSERIDO NA TABELA DE TRANSFERENCIA
SELECT @MOEDA = MOE_INT_ID, @VALOR=TRA_DOU_VALOR,@USUARIO=USU_INT_ID FROM INSERTED
--SELECIONANDO A CARTEIRA DO USUARIO A PARTIR DO ID
SELECT @CARTEIRA = (SELECT CAR_INT_ID FROM TB_CARTEIRA WHERE USU_INT_ID=@USUARIO)
--REALIZANDO UPDATE PARA ATUZALIA��O DE SALDO
UPDATE TB_MOEDA_CARTEIRA SET MC_DEC_SALDO=(SELECT (MC_DEC_SALDO - @VALOR) FROM TB_MOEDA_CARTEIRA WHERE CAR_INT_ID=@CARTEIRA AND MOE_INT_ID=@MOEDA) WHERE CAR_INT_ID=@CARTEIRA AND MOE_INT_ID=@MOEDA

END
GO


/*
PROCEDURE PARA INSERIR CONVERS�O

autor: Jos� Hugo Soares de Barros
Data: 11/11/2020

Manuten��o:


*/
GO
CREATE PROCEDURE USP_INSERT_CONVERSAO
@USUARIO INT,
@MOEDA_ORI INT,
@MOEDA_FIM INT,
@VALOR_IN DECIMAL(9,2),
@VALOR_FI DECIMAL(9,2),
@PROTOCOLO VARCHAR(15),
@DATA DATE,
@ID_OUT INT OUTPUT
AS
BEGIN
INSERT INTO TB_CONVERSAO(USU_INT_ID,CON_INT_MOE_IN,CON_INT_MOE_FI,CON_DEC_VLR_IN,CON_DEC_VLR_FI,CON_STR_PROTO,CON_STR_DATA) VALUES (@USUARIO,@MOEDA_ORI,@MOEDA_FIM,@VALOR_IN,@VALOR_FI,@PROTOCOLO,@DATA)
SET @ID_OUT = (SELECT SCOPE_IDENTITY())
	RETURN @ID_OUT
END

/*
TRIGGER PARA DEBITAR e ATUALIZAR O SALDO AP�S CONVERSAO

autor: Jos� Hugo Soares de Barros
Data: 23/10/2020

Manuten��o:


*/
GO
CREATE TRIGGER DEBITAR_ADICIONAR_MOEDA_CONVERSAO
ON TB_CONVERSAO
FOR INSERT
AS
BEGIN
DECLARE 
@USUARIO INT,
@CARTEIRA INT,
@MOEDA_ORI INT,
@MOEDA_FIM INT,
@VALOR_IN DECIMAL(9,2),
@VALOR_FI DECIMAL(9,2)

--ATRIBUINDO VALOR QUE FOI INSERIDO NA TABELA DE TRANSFERENCIA
SELECT @MOEDA_ORI = CON_INT_MOE_IN,@MOEDA_FIM =CON_INT_MOE_FI , @VALOR_IN=CON_DEC_VLR_IN,@VALOR_FI =CON_DEC_VLR_FI ,@USUARIO=USU_INT_ID FROM INSERTED
--SELECIONANDO A CARTEIRA DO USUARIO A PARTIR DO ID
SELECT @CARTEIRA = (SELECT CAR_INT_ID FROM TB_CARTEIRA WHERE USU_INT_ID=@USUARIO)
--REALIZANDO UPDATE PARA ATUZALIA��O DEBITO DA MOEDA DE ORIGEM
UPDATE TB_MOEDA_CARTEIRA SET MC_DEC_SALDO=(SELECT (MC_DEC_SALDO - @VALOR_IN) FROM TB_MOEDA_CARTEIRA WHERE CAR_INT_ID=@CARTEIRA AND MOE_INT_ID=@MOEDA_ORI) WHERE CAR_INT_ID=@CARTEIRA AND MOE_INT_ID=@MOEDA_ORI

--REALIZANDO UPDATE PARA ATUZALIA��O DE MOEDA FINAL
UPDATE TB_MOEDA_CARTEIRA SET MC_DEC_SALDO=(SELECT (MC_DEC_SALDO + @VALOR_FI) FROM TB_MOEDA_CARTEIRA WHERE CAR_INT_ID=@CARTEIRA AND MOE_INT_ID=@MOEDA_FIM) WHERE CAR_INT_ID=@CARTEIRA AND MOE_INT_ID=@MOEDA_FIM

END
GO

/*

PROCEDURE PARA INSERIR DEPOSITO POR BOLETO

autor: Luis Henrique Suzuki Silva
Data: 10/11/2020

Manuten��o:

*/

CREATE PROCEDURE [dbo].[USP_DEPOSITO_BOLETO]
@TIPO CHAR(1),
@TITULAR VARCHAR(100),
@DTVENCIMENTO DATE,
@DTPAGAMENTO DATE,
@DPVALOR DECIMAL(9,2),
@STATUS CHAR(1),
@CARTEIRAID INT,
@PROTOCOLO INT,
@NUMBLT CHAR(48),
@USERID INT,
@ID_OUT INT OUTPUT

AS
BEGIN TRY
    SET @CARTEIRAID = (SELECT CAR_INT_ID FROM TB_USUARIO AS a, TB_CARTEIRA AS b WHERE b.USU_INT_ID = a.USU_INT_ID AND a.USU_INT_ID = @USERID)
    INSERT INTO TB_DEPOSITO(DEP_STR_TIPO,DEP_STR_TITULAR,DEP_DT_DTVENC,DEP_DT_DTPAG,DEP_DOU_VALOR,DEP_STR_STATUS,CAR_INT_ID,DEP_STR_PROTOCOLO, DEP_STR_NUMBLT)
    VALUES(@TIPO,@TITULAR,@DTVENCIMENTO,@DTPAGAMENTO,@DPVALOR,@STATUS,@CARTEIRAID,@PROTOCOLO, @NUMBLT)
    SET @ID_OUT = (SELECT SCOPE_IDENTITY())

    IF (@ID_OUT>0 AND @TIPO=1)
    BEGIN
        UPDATE TB_MOEDA_CARTEIRA
        SET MC_DEC_SALDO = MC_DEC_SALDO + @DPVALOR
        WHERE MOE_INT_ID = 4 AND CAR_INT_ID = @CARTEIRAID
    END    
END TRY

BEGIN CATCH
    SELECT   
        ERROR_NUMBER() AS ErrorNumber  
        ,ERROR_SEVERITY() AS ErrorSeverity  
        ,ERROR_STATE() AS ErrorState  
        ,ERROR_PROCEDURE() AS ErrorProcedure
        ,ERROR_LINE() AS ErrorLine
        ,ERROR_MESSAGE() AS ErrorMessage;
END CATCH
RETURN @ID_OUT
GO

/*

PROCEDURE PARA INSERIR DEPOSITO POR CARTAO

autor: Luis Henrique Suzuki Silva
Data: 10/11/2020

Manuten��o:

*/

CREATE PROCEDURE [dbo].[USP_DEPOSITO_CARTAO]
@TIPO CHAR(1),
@TITULAR VARCHAR(100),
@DTVENCIMENTO DATE,
@NUMCARTAO CHAR(16),
@CVV CHAR(3),
@DTPAGAMENTO DATE,
@DPVALOR DECIMAL(9,2),
@STATUS CHAR(1),
@CARTEIRAID INT,
@PROTOCOLO INT,
@USERID INT,
@ID_OUT INT OUTPUT

AS
BEGIN TRY
    SET @CARTEIRAID = (SELECT CAR_INT_ID FROM TB_USUARIO AS a, TB_CARTEIRA AS b WHERE b.USU_INT_ID = a.USU_INT_ID AND a.USU_INT_ID = @USERID)
    INSERT INTO TB_DEPOSITO(DEP_STR_TIPO,DEP_STR_TITULAR,DEP_STR_NUMCARTAO,DEP_STR_CVV,DEP_DT_DTPAG,DEP_DOU_VALOR,DEP_STR_STATUS,CAR_INT_ID,DEP_STR_PROTOCOLO, DEP_STR_CARTAOVENC)
    VALUES(@TIPO,@TITULAR,@NUMCARTAO,@CVV,@DTPAGAMENTO,@DPVALOR,@STATUS,@CARTEIRAID,@PROTOCOLO, @DTVENCIMENTO)
    SET @ID_OUT = (SELECT SCOPE_IDENTITY())

    IF (@ID_OUT>0 AND @TIPO=2)
    BEGIN
        UPDATE TB_MOEDA_CARTEIRA
        SET MC_DEC_SALDO = MC_DEC_SALDO + @DPVALOR
        WHERE MOE_INT_ID = 4 AND CAR_INT_ID = @CARTEIRAID
    END    
END TRY

BEGIN CATCH
    SELECT   
        ERROR_NUMBER() AS ErrorNumber  
        ,ERROR_SEVERITY() AS ErrorSeverity  
        ,ERROR_STATE() AS ErrorState  
        ,ERROR_PROCEDURE() AS ErrorProcedure  
        ,ERROR_LINE() AS ErrorLine  
        ,ERROR_MESSAGE() AS ErrorMessage;
END CATCH
RETURN @ID_OUT
GO

/*

PROCEDURE PARA ATUALIZAR SENHA

autor: Jos� Hugo Soares de Barros
Data: 24/11/2020

Manuten��o:

*/
GO
CREATE PROCEDURE SP_ALTERAR_SENHA
@EMAIL VARCHAR (50),
@SENHA VARCHAR(MAX),
@RETURN INT OUTPUT
AS

BEGIN
	
		UPDATE TB_USUARIO SET USU_STR_SENHA=@SENHA where USU_STR_EMAIL=@EMAIL
		SET @RETURN = (select usu_int_id from TB_USUARIO where USU_STR_EMAIL= @EMAIL)
		RETURN @RETURN
	
END
