//=== EJEMPLO 11 SELECCIÓN DE TEMA (color de fondo) 

const select = document.querySelector('select');
const html = document.querySelector('html');
// declaración de la variable choice fuera de la función
// su ámbito será global
      let choice;
	  
//Evento onchange como propiedad y uso de una 
// función anónima como manejadora del evento 

      select.onchange = function() {
       choice = select.value;

//== declaración de la variable choice 
//== dentro de la función (su amito será la función)
       //const choice = select.value;
// == uso de switch
      switch(choice) {
        case 'black':
          update('black','white');
          break;
        case 'white':
          update('white','black');
          break;
        case 'purple':
          update('purple','white');
          break;
        case 'yellow':
          update('yellow','darkgray');
          break;
        case 'psych':
          update('lime','purple');
          break;
      }
      // desde el ambito de función 
      console.log("choice interno =", choice);
    }
// desde el ambito global
		console.log("choice externo =", choice);

      function update(bgColor, textColor) {
        html.style.backgroundColor = bgColor;
        html.style.color = textColor;
      }


      
