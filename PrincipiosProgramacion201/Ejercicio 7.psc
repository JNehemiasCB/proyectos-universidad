Proceso Frases
	Definir mayor_longitud, menor_longitud, posicion_mayor, posicion_menor,i Como Entero;
	Dimension frase[6];  // Definimos un arreglo de frases con capacidad para 5 elementos
	
	// Solicitamos al usuario que ingrese las frases
    Para i <- 1 Hasta 5 Con Paso 1 Hacer
        Escribir "Ingresa la frase ", i;
        Leer frase[i];
    Fin Para
	
	// Imprimimos la lista de frases
    Escribir "Lista de frases:";
    Para i <- 1 Hasta 5 Con Paso 1 Hacer
        Escribir frase[i];
    Fin Para
	
    // Encontramos la frase de mayor longitud y su posición
    mayor_longitud <- Longitud(frase[1]);
    posicion_mayor <- 1;
    Para i <- 2 Hasta 5 Con Paso 1 Hacer
        Si Longitud(frase[i]) > mayor_longitud Entonces
            mayor_longitud <- Longitud(frase[i]);
            posicion_mayor <- i;
        Fin Si
    Fin Para
    Escribir "La frase más larga es: ", frase[posicion_mayor], "posición: ", posicion_mayor;
	
    // Encontramos la frase más pequeña y su posición
    menor_longitud <- Longitud(frase[1]);
    posicion_menor <- 1;
    Para i <- 2 Hasta 5 Con Paso 1 Hacer
        Si Longitud(frase[i]) < menor_longitud Entonces
            menor_longitud <- Longitud(frase[i]);
            posicion_menor <- i;
        Fin Si
    Fin Para
	Escribir "La frase más pequeña es: ", frase[posicion_menor], "posición: ", posicion_menor;
FinProceso