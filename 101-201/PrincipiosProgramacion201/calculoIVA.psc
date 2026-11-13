Proceso calculoIVA
	Definir i, precioArt, IVA, total, subTotal Como Real;
	Definir num Como Entero;
	i<-0;
	subTotal<-0;
	Escribir "ingresa el numero de artiulos que quieres sacarles IVA";
	Leer num;
	Para i<-1 Hasta num Con Paso 1 Hacer
		Escribir "ingresa el precio del articulo ",i,":";
		Leer precioArt;
		subTotal<-subTotal+precioArt;
	Fin Para
	Escribir "el subTotal es: ", subTotal;
	IVA<-subTotal*0.16;
	Escribir "el IVA es de: ",IVA;
	total<- subTotal+IVA;
	Escribir "el total es de: ",total;
FinProceso
