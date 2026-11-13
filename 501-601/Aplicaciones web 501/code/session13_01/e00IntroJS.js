// comentario de bloque

// alert("El script está en un archivo adjunto");


/*  Selectores  de JS  */
/* 
document.getElementById("myId")	devuelve 1 solo elemento con id "myId"	
document.getElementsByClassName("myClass")	devuelve Colección de elementos con la clase "myClass"(HTMLCollection)
document.getElementsByTagName('p')	devuelve una colección de elementos 'p'	
document.getElementsByName('name')	devuelve una Colección de nodos de nombre "name"
document.querySelector(".myClss") dev. primer elemento definido por el selector #id, .clase, atributo, etc.
Recomendaciones: 
   1) Usar querySelector() para usar selecctores CSS, es m´s flexible
	2) Usar getElementById() cuando solo se requiera un elemento por su id
	3) Usar queryselectorAll() o getElementsByClassName cuando se necesite varios elementos
*/

/*
VARIABLES y Tipo de las variables
Hay algunos tipos de datos diferentes que podemos almacenar en variables.
No es necesario declarar el tipo de variable JS lo determina al inicializar la variable: 
	Numbers : Enteros, flotantes . 
		let miAge = 68;   //Entera
	
	Strings : cadenas de texto, encerradas entre comillas dobles o simples: 
		let miName= “Ricardo”
	
	Bool: pueden ser true o false:
		let prueba =  10 <3 ; //false
	
	Arreglos : conjuntos de elementos  encerrados entre corchetes y separados por comas.
		let persona = [ “Ricardo”, 65, ‘años’];
		persona[2]   <== devuelve  “años”  (los elementos de un arreglo tienen un 
                     índice que inicia en cero

	Objetos:  Estructura con parejas llave:valor :
		let persona= { nombre: “Ricardo”, edad: 65, género: “masculino”};
		persona.nombre;  <== devuelve “Ricardo”
*/

/*======FORMAS DE INSERTAR ELEMENTOS HTML A UN DOCUMENTO ===========*/

// 1.- Usando innerHTML : Inyecta código HTML directamente como texto interpretado.

     //const cont1 = document.getElementById("contenedor1");
     //cont1.innerHTML = "<p>Hola <b>mundo</b></p>";

// 2. Usando insertAdjacentHTML() : Inserta HTML sin borrar lo que ya había.
	  //const cont2 = document.getElementById("contenedor2");
  	  //cont2.insertAdjacentHTML("afterend", "<p>Un párrafo después dentro de contenedor 2</p>");

// 3.- Usando createElement() y  appendChild()

		 //const cont3 = document.getElementById("contenedor3");
		 //const nuevo3 = document.createElement("p");
		 //nuevo3.textContent = "En un nuevo párrafo Hola mundo dentro de contenedor 3";
		 //cont3.appendChild(nuevo3);

// 4.- Usando prepend() y append() : aceptan texto o nodos y pueden añadir varios a la vez.

		 //const cont4 = document.getElementById("contenedor4");
		 //cont4.prepend("Texto inicial+ ");
		 //cont4.append(" +Texto final");

// 5.-Usando innerText o textContent: Para insertar solo texto plano (no HTML).Sobreescribe
		 //const cont5 = document.getElementById("contenedor5");
		 //cont5.textContent = "<b>No se interpreta</b> y sobreescribe contenido de contenedor 5"; // Se muestra literalmente

// 6.- insertBefore() : Inserta un nodo antes de otro nodo existente.

		 //const lista6 = document.getElementById("lista6");
		 //const nuevoLi6 = document.createElement("li");
		 //nuevoLi6.textContent = "Cero insertado antes de todos los elementos de la lista";
		 //lista6.insertBefore(nuevoLi6, lista6.firstElementChild);

// 7.- Usando replaceChild() o removeChild()
	
		 //const cont7 = document.getElementById("contenedor7");
		 //const nuevo7 = document.createElement("p");
		 //nuevo7.textContent = "Nuevo párrafo insertado en contenedor 7";
		 //cont7.replaceChild(nuevo7, cont7.firstElementChild);

// 8.- Usando DocumentFragment: eficiente para muchos nodos

	//	 const fragment = document.createDocumentFragment();
	//	 for (let i = 1; i <= 3; i++) {
	//	 	const li = document.createElement("li");
	//	 	li.textContent = "Elemento " + i + " insertado en el fragmento (8)";
	//	 	fragment.appendChild(li);
	//	 }
	//	 document.getElementById("lista8").appendChild(fragment);

// 9.- Usando outerHTML: Reemplaza todo el elemento, no solo su contenido.
		 //const caja9 = document.getElementById("contenedor9");
		 //contenedor9.outerHTML = "<section>Contenido reemplazado completamente del contenedor9</section>";



//  ================VARIABLES DECLARACIÓN E INICIALIZACIÓN ====================
// El punto y coma final de cada linea es opcional, pero se recomienda ponerlo

		 let nombre;             // declaración de variable nombre
		nombre="Ricardo";       // inicialización de variable nombre
		let apellidos = "Peña Galeana";  // declaración e inicialización simultánea


// EJEMPLO DE USO DE VARIABLES EN JAVASCRIPT

// solicitar un nombre y almacenarlo en una variable userName
		let userName = prompt('¿Cuál es tu nombre ?');

// obtener el elemento de la clase "myClass" y lo asignamos a un avaraiable label
 		const label = document.querySelector('.myClass');

/* Introducir el texto capturado en la propiedad "textContent" del elemento obtenido y almacenado en label */
		 label.textContent = `Mi nombre es ${userName} y estoy aprendiendo JavaScript`; 
		//  label.textContent = 'Mi nombre es '+ userName + " y estoy aprendiendo JavaScript";

		 let arreglo= [1,2,3,4]

		 let objeto = {
		    nombre: "Nehemias",
		    apellidos: "Contreras Barrera",
		    direccion: " Av. las playas "
		 }

		 let frutas= [ "pera", "manzana", "uva", "plátano"];
		 console.table(frutas[1]);


/* ========desde la consola realizar y oservar que se muestran los valores en memoria  */

// >>nombre       <== muestra "Ricardo"	
// >>apellidos   <== muestra "Peña Galeana"
// >>label      <== muestra <h2 class="miClase">
// >>objeto      <== muestra su contenido
// >>arreglo     <== muestra su contenido
// >>frutas      <== muestra su contendio
 



