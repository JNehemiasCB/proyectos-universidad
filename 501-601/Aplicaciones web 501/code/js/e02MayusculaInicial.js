// seleccionamos el elemento "ul" posterior a la clase "output" y 
// lo guardamos en la varaiable "list" inicializando su HTML interno 
let list = document.querySelector ('.output ul');
list.innerHTML= '';

// guardamos nombres de ciudades en un arreglo "citries"
let cities = [ 'acaPulco', 'chilPanCinGo', 'cuerNaVaCa', 'oMeTePec'];

for (let i= 0; i< cities.length; i++) {
    let input = cities[i];

    // pasamos a minúsculas todo el nombre de la ciudad 
    let lower = input.toLowerCase();

    // En JS cada palabra se puede considerar como un arreglo de caracteres
    //recortamos el riner caracter del nombre de la ciudad con slice()
    // .slice(0,1)  <== desde el elemento 0 hasta el anterior al 1
    let firstLetter =  lower.slice(0,1);

    // reemplazamos la primer letra 
    let capitalized = lower.replace(firstLetter, firstLetter.toUpperCase());

    let result = capitalized;

    // Creamos un elemento "li" (list-item) 
    let listItem = document.createElement('li');

    // Colocamos en el list-item creado la capitalización de la primer letra 
    listItem.textContent = result;
    // Agregamos el "li" como "hijo" de la lista "ul"
    list.appendChild(listItem);
}
