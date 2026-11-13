Proceso ejercicio1
	Definir nombre Como Caracter;
	Definir c1,c2,c3,c4,c5, promedio Como Real;
	Definir n_ctrl Como Entero;
	Escribir "ingresa tu numero de control";
	Leer n_ctrl;
	Escribir "ingresa tu nombre";
	Leer nombre;
	Escribir "ingresa tus calificaciones";
	Leer c1,c2,c3,c4,c5;
	Escribir "el alumno cuyo nombre es: ", nombre, ", numero de control es: ",n_ctrl;
	Escribir c1;
	Escribir c2;
	Escribir c3;
	Escribir c4;
	Escribir c5;
	promedio <- (c1+c2+c3+c4+c5) / 5;
	Escribir "su promedio es: ", promedio;
	
FinProceso
