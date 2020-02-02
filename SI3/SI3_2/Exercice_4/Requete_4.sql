SELECT AVG(CapaType) As Capacité_Moyenne
FROM [TYPE-AVION], AVION
WHERE [TYPE-AVION].CodeType = AVION.CodeType;