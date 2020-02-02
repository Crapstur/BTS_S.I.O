SELECT SUM(CapaType) As Capacité_Totale
FROM [TYPE-AVION], AVION
WHERE [TYPE-AVION].CodeType = AVION.CodeType
AND AVION.CodeType = "A320"