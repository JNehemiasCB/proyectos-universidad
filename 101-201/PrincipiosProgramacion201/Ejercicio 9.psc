Algoritmo ListaUnidimensional
    Definir num, i, j, posicion Como Entero;
    Definir repetido, valido Como Logico;
	Dimension lista[51];
	
    // Inicializar la lista con ceros
    Para i <- 1 Hasta 50 Con Paso 1 Hacer
	lista[i] <- 0;
    Fin Para
	
    // Generar números aleatorios y llenar la lista
    Para posicion <- 1 Hasta 50 Con Paso 1 Hacer
        Repetir
            valido <- Verdadero;
            repetido <- Falso;
		
	// Generar un número aleatorio entre 1 y 100
	num <- Aleatorio(1, 100);
			
	// Verificar si el número ya está en la lista
            Para j <- 1 Hasta posicion - 1 Con Paso 1 Hacer
                Si lista[j] = num Entonces
                    repetido <- Verdadero;
                Fin Si
            Fin Para
			
            // Verificar si el número es múltiplo de la posición
            Si num MOD posicion = 0 Entonces
                valido <- Falso;
            Fin Si
			
        Hasta Que repetido = Falso Y valido = Verdadero
		
        // Asignar el número a la posición correspondiente en la lista
        lista[posicion] <- num;
    Fin Para
	
    // Imprimir la lista
    Para i <- 1 Hasta 50 Con Paso 1 Hacer
        Escribir "Elemento[", i, "] = ", lista[i];
    Fin Para
FinAlgoritmo
