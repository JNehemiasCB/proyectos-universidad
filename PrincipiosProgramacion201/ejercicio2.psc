Proceso ejercicio2
	Definir nom Como Caracter;
	Definir c1, c2, c3, c4, c5, promedio Como Real;
	Escribir "ingresa tu nombre";
	Leer nom;
	escribir "ingresa tus calificaciones";
	Leer c1, c2, c3, c4, c5;
	promedio <- (c1+c2+c3+c4+c5)/5;
	Escribir "tu promedio es: ", promedio;
	si promedio < 6
		Entonces
		Escribir "reprobado";
	SiNo
		Escribir "aprobado";
	FinSi

FinProceso
