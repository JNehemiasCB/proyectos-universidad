/* == EJEMPLO 07  Sobre el clima, USO de IF===*/


let seleccionar = document.querySelector('select');
let parrafo = document.querySelector('p');

// Se le agrega un manejador de evento "change" al elemento que se encuentra en la variable seleccionar
seleccionar.addEventListener('change', establecerClima);


// función que se ejecuta cuando ocurre el evento "change"
function establecerClima() {

  // se almacena en la variable elección el valor seleccionado
   let eleccion = seleccionar.value;

   if (eleccion === 'soleado') {
    parrafo.textContent = 'El día esta agradable y soleado hoy. ¡Use pantalones cortos! Ve a la playa o al parque y come un helado.';
   } else if (eleccion === 'lluvioso') {
     parrafo.textContent = 'Está lloviendo, tome un abrigo para lluvia y un paraguas, y no se quede por fuera mucho tiempo.';
   } else if (eleccion === 'nevando') {
     parrafo.textContent = 'Está nevando ─ ¡está congelando! Lo mejor es quedarse en casa con una taza caliente de chocolate, o hacer un muñeco de nieve.';
   } else if (eleccion === 'nublado') {
     parrafo.textContent = 'No está lloviendo, pero el cielo está gris y nublado; podría llover en cualquier momento, así que lleve un saco solo por si acaso.';
   } else {
     parrafo.textContent = '';
   }
 }
 