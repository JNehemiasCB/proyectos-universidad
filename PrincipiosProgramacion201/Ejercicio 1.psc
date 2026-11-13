Proceso arrpar
	Definir i, l Como Entero;
	Definir n Como Entero;
	Leer n;
	Dimension l[n];
	Para i = 1 Hasta n Hacer
		l[i] = l[i] + 1;
	FinPara
	Para i = 1 Hasta n Hacer
		Si l[i] mod 2 = 0
			Entonces
			Escribir l[i];
		FinSi
	FinPara
FinProceso
