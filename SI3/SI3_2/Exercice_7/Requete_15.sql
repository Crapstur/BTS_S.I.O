SELECT COUNT(*) * 100 / (SELECT COUNT(*)
                         FROM t_planning)
                         Taux_Occup
FROM tj_chb_pln_cli
WHERE CHB_ID = 2
AND CHB_PLN_CLI_OCCUPE = 1