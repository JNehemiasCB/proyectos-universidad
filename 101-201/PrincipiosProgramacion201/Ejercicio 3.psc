Algoritmo Contar_Impares
    Definir L, SumaImpares, ContadorImpares Como Entero;
    L = 0;
    SumaImpares = 0;
	ContadorImpares = 0;
	
    Mientras L <= 50 Hacer
        Si L MOD 2 == 0 Entonces
            Escribir "Número par:", L;
        Sino
            Escribir "Número impar:", L;
            SumaImpares <- SumaImpares + L;
			ContadorImpares <- ContadorImpares + 1;
        FinSi
        L <- L + 1;
    FinMientras
	
    Escribir "La suma de los números impares es:", SumaImpares;
	Escribir "Cantidad de números impares:", ContadorImpares;
FinAlgoritmo
