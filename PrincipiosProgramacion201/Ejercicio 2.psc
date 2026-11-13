Algoritmo Suma_Impares
    Definir L, SumaImpares Como Entero;
    L = 0;
    SumaImpares = 0;
	
    Mientras L <= 50 Hacer
        Si L MOD 2 == 0 Entonces
            Escribir "Número par:", L;
        Sino
            Escribir "Número impar:", L;
            SumaImpares <- SumaImpares + L;
        FinSi
        L <- L + 1;
    FinMientras
	
    Escribir "La suma de los números impares es:", SumaImpares;
FinAlgoritmo
