Algoritmo Multiplos_2_y_3
    Definir L, Contador, Suma Como Entero;
    L = 0;
    Contador = 0;
    Suma = 0;
	
    Mientras L <= 50 Hacer
        Si L MOD 2 == 0 Y L MOD 3 == 0 Entonces
            Contador <- Contador + 1;
            Escribir "Elemento en posición", Contador, ":", L;
            Suma <- Suma + L;
        FinSi
        L <- L + 1;
    FinMientras
	
    Escribir "La suma de los elementos múltiplos de 2 y 3 es:", Suma;
FinAlgoritmo

