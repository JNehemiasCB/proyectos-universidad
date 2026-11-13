Algoritmo GenerarListaAleatoria
    Definir n, i, num, posicion_3, posicion_40 Como Entero;
    Dimension lista[51] ;  // Definimos la lista con 50 elementos
	
    // Generar números aleatorios y llenarlos en la lista
    Para i = 1 Hasta 50 Hacer
        num = Aleatorio(1, 100);  // Genera un número aleatorio entre 1 y 100
	lista[i] = num;
    FinPara
	
    // Imprimir la lista completa
    Para i = 1 Hasta 50 Hacer
        Escribir "Elemento ", i, ": ", lista[i];
    FinPara
	
    // Imprimir los elementos en las posiciones 3 y 40
    posicion_3 = lista[3];
    posicion_40 = lista[40];
    Escribir "Elemento en la posición 3: ", posicion_3;
    Escribir "Elemento en la posición 40: ", posicion_40;
FinAlgoritmo
