Proceso MayoresAleatorios
    Definir datos, n, i, may1, may2 Como Numeros;
    // Declaramos un arreglo de 200 elementos
    Dimension datos[200];
	
    // Pedimos al usuario ingresar la cantidad de datos, que no deberá ser mayor a 200
    Escribir "Ingrese la cantidad de datos (de 2 a 200):";
    Leer n;
	
    // Generamos números aleatorios y los almacenamos en el arreglo
    Para i<-0 Hasta n-1 Hacer
        datos[i] <- Aleatorio(0,100); // Genera un número aleatorio entre 0 y 999
    FinPara
	
    // Inicializamos may1 y may2 con los dos primeros elementos del arreglo
    Si datos[0] > datos[1] Entonces
        may1 <- datos[0];
        may2 <- datos[1];
    SiNo
        may1 <- datos[1];
        may2 <- datos[0];
    FinSi
	
    // Recorremos el resto de los elementos del arreglo para encontrar los dos mayores
    Para i<-1 Hasta n-1 Hacer
        Si datos[i] > may1 Entonces // Si hay un valor mayor que may1
            may2 <- may1; // may1 pasa a ser el segundo mayor
            may1 <- datos[i]; // El nuevo dato toma el primer puesto (mayor de todos)
        Sino // Si no era más grande que may1, todavía puede ser más grande que may2
            Si datos[i] > may2 Entonces // Si supera al segundo mayor que teníamos
                may2 <- datos[i]; // Lo guardamos como segundo mayor
            FinSi
        FinSi
    FinPara
	
    // Mostramos los resultados
    Escribir "El mayor es: ", may1;
    Escribir "El segundo mayor es: ", may2;
FinProceso
