
// seleccionamos el elemento "ul" posterior a la clase "output" y 
// lo guardamos en la varaiable "list" inicializando su HTML interno 
let list = document.querySelector('.output ul');
list.innerHTML ='';

// guardamos frases en un arreglo "saludos"
let saludos = ['Feliz cumpleaños', 'Pásala bien', ' Feliz Navidad', 'Que pases una feliz Navidad', 'Felicidades para todo'];

//Realizamos ciclos desde i=0 hast i< longitud_del_arreglo
// Revisando si las frases contienen la palabra "Navidad" en cuyo
// caso se selecciona
 for (let i=0; i< saludos.length; i++){

   // guardar en la variable "input" la frase correspondiente al 
   // indice i en turno (i=0, 1, 2, ... )
   let input = saludos[i];

   //Si la i-ésima frase contiene la palabra 'Navidad' se selecciona y almacena en la variable "result"
   // indexOf(subCadena) devuelve el indice donde inicia subCadena dentro de una cadena. Si no existe devuelve -1
   if (saludos[i].indexOf('Navidad') !== -1)
      {
         let result = input;
         console.log (input);
         // se crea un elemento HTML de tipo list item
         let listItem = document.createElement('li');

         // se coloca en el elemento "li" creado, la i-ésima frase selecionada antes y almacenada en la variable "result"
         listItem.textContent = result;

         // Se agrega el elemento "li" a la lista "ul" 
         list.appendChild(listItem);
         console.log(listItem);
         console.log(result);
      }   
 }