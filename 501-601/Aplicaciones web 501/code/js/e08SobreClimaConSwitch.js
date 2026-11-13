/*  EJEMPLO 8 Sobre el clima OTRA FORMA MISMO RESULTADO
    USANDO SWITCH  */

let seleccionar = document.querySelector('select');
let parrafo = document.querySelector('p');

seleccionar.addEventListener('change', establecerClima);

function establecerClima() {
  let eleccion = seleccionar.value;

  switch (eleccion) {
      case 'soleado':{
        parrafo.textContent = 'El día esta agradable y soleado hoy. ¡Use pantalones cortos! Ve a la playa o al parque y come un helado.';
        }
        break;

      case 'lluvioso': {
        parrafo.textContent = 'Está lloviendo, tome un abrigo para lluvia y un paraguas, y no se quede por fuera mucho tiempo.';
        } 
      break;
      
      case 'nevando': {
        parrafo.textContent = 'Está nevando ─ ¡está congelando! Lo mejor es quedarse en casa con una taza caliente de chocolate, o hacer un muñeco de nieve.';
      } 
      break;
      
      case 'nublado': {
        parrafo.textContent = 'No está lloviendo, pero el cielo está gris y nublado; podría llover en cualquier momento, así que lleve un saco solo por si acaso.';
        } 
        break;
        default:
      parrafo.textContent = '';
  }
}
