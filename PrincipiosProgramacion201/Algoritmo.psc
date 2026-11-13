Algoritmo Algoritmo
		Definir a,b,c, Mayor como entero;
		escribir "ingrese a";
		leer a;
		escribir "ingrese b:";
		leer b;
		escribir "ingrese c:";
		leer c;
		Si a > b Y a > c mostrar "El numero mayor es a";
			fin si
			si b > a y b > c mostrar "El numero mayor es b";
				fin si
				si c > a y c > b mostrar "El numero mayor es c";
				fin si
				si b > a y b >= c Entonces
					mostrar "Los numeros b y c son mayores que a";
				FinSi
				si a > b y a >= c Entonces
					mostrar "Los numeros a y c son mayores que b";
				FinSi
				si a > c y a >= b Entonces
					mostrar "Los numeros a y b son mayores que c ";
				FinSi
				si a = b y b = c Entonces
					mostrar "Todos los numeros son iguales.";
				FinSi
FinAlgoritmo
