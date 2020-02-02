SELECT CHB_ID, COUNT(CHB_PLN_CLI_RESERVE) AS Nbr_Reserv
FROM tj_chb_pln_cli
WHERE CHB_PLN_CLI_RESERVE = 1
GROUP BY CHB_ID
ORDER BY Nbr_Reserv DESC
LIMIT 10;