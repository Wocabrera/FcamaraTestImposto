CREATE PROCEDURE [DBO].[P_EXERCICIO_4]
	AS

SELECT
	CFOP AS [CFOP],
	SUM(BASEICMS) AS [TOTAL_BASE_ICMS],
	SUM(VALORICMS) AS [TOTAL_TOTAL_ICMS],
	SUM(BASEIPI) [TOTAL_BASE_IPI],
	SUM(VALORIPI) [TOTAL_TOTAL_IPI]
FROM DBO.NOTAFISCALITEM
GROUP BY CFOP