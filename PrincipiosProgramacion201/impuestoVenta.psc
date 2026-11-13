Proceso impuestoVenta
	Definir impCond, impEst, montoC, montoImp Como Real;
	Escribir "ingresa el monto de la compra";
	Leer montoC;
	impCond<- montoC*0.02;
	impEst<- montoC*0.04;
	montoImp<-montoC+impCond+impEst;
	Escribir "la compra fue de ",montoC,", su impuesto estatal fue de ",impEst,", el del condado de ",impCond,", entonces el total con todo e impuestos es de: ",montoImp;

	
FinProceso
