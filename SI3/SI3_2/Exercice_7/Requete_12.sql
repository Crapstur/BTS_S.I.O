SELECT t_facture.PMT_CODE As Mode_Paiement, COUNT(CLI_ID) As Nbr_Utilisation
FROM t_facture, t_mode_paiement
WHERE t_facture.PMT_CODE=t_mode_paiement.PMT_CODE
GROUP BY t_facture.PMT_CODE
ORDER BY Nbr_Utilisation DESC 
LIMIT 2 ;