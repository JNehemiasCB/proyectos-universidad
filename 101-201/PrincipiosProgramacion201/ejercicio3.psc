Proceso ejercicio3
	Definir c1,c2,c3,c4,c5, promedio,n_ctrl Como Real;
	definir nombre Como Caracter;
	Definir contador, alum Como Entero;
	contador <- -1;
	Escribir "cuantos alumnos va a promediar?";
	Leer alum;
	Mientras contador <= alum Hacer
		Escribir "ingresa el nombre y numero de control del alumno";
		Leer nombre, n_ctrl;
		promedio<-(c1+c2+c3+c4+c5)/5;
		Escribir "el promedio es: " ,promedio;
		si promedio < 6
			Entonces
			Escribir "reprobado";
		SiNo
			Escribir "aprobado";
		FinSi
		
	FinMientras
	
	
	
;	
FinProceso
