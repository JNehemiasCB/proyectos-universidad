Algoritmo Tabla_de_multiplicar
	Definir tabla, limite, resultado, i Como Entero;
	
	Escribir "Ingresa un número para la tabla de multiplicar:";
	Leer tabla;
	
	Escribir "Ingresa el límite de la tabla:";
	Leer limite;
	
	Para i <- 1 Hasta limite Con Paso 1 Hacer
		resultado <- tabla * i;
		Escribir tabla, " x ", i, " = ", resultado;
	FinPara
	
	Si limite >= 3 Entonces
		Escribir "El tercer elemento de la tabla es: ", tabla * 3;
	Sino
		Escribir "La tabla no tiene suficientes elementos para mostrar el tercero";
	FinSi
FinProceso
