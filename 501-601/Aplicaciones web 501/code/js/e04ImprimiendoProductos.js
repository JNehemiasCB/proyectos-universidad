// EJEMPLO 04  IMPRIMIENDO PRODUCTOS
let list = document.querySelector ('.output ul');
list.innerHTML= '';

let totalBox = document.querySelector ('.output p');
totalBox.textContent ='';

let total =0;

let products = [
  'Calzoncillos : 189.50',
  'Calcetines   : 149.50',
  'Camisetas    : 395.50',
  'Pantalones   : 590.50',
  'Zapatos      : 795.50'];

  for (let i= 0; i < products.length; i++){
   // Utilizamos split() para separar las cadenas en un arreglo de dos  elementos, el seprador es ':'
    let subArray = products[i].split(':');
    
    let name = subArray[0];
    // se extrae la subcadena correspondiente a la cantidad, se convierte a número y se almacena en la variable price
    let price = Number(subArray[1]);
   
      total+= price; // total = total + price

      itemText = name + '--- $ ' + price;
      
   let listItem = document.createElement ('li');
   listItem.textContent = itemText;
   list.appendChild(listItem);
  }
  totalBox.textContent = 'Total =    $ '+ total.toFixed(2);



