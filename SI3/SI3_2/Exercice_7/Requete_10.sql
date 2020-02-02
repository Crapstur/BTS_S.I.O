SELECT CHB_NUMERO
FROM tj_chb_pln_cli, t_chambre
WHERE tj_chb_pln_cli.CHB_ID=t_chambre.CHB_ID
AND PLN_JOUR = "2013-12-31"
AND CHB_PLN_CLI_RESERVE = 0 ;