Proceso MPG
	Escribir "ingresa las millas recorridas";
	Definir millas Como Real;
	Leer millas;
	Escribir "ingresa los galones utilizados";
	Definir galones Como Real;
	Leer galones;
	Definir resultado Como Real;
	resultado <- millas/galones;
	Escribir "el rendimiento del gas por las millas recorridas fue de ",resultado;
	Definir km Como Real;
	km <- millas * 1609;
	resultado <- km/galones;
	Escribir "El rendimiento en km fue de: ", resultado "km";
FinProceso
