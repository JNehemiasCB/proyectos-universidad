/* ================================================
1.- Ir a https://developer.nytimes.com/get-started 
2.- Crear un acuenta, crear un nuevo proyectp y acceder a 
3.- Registrar una APP y copiar su API KEY
4.- Click en APIs y habiitar el acceso a la app
5.- Colocar a API Key en la línea siguiente:
*/

// Definir la URL base y la llave de la API (token)

const baseURL = 'https://api.nytimes.com/svc/search/v2/articlesearch.json';
const key = '';

// almacenar todas las referencias a los elementos del DOM
 
const searchTerm = document.querySelector('.search');
const startDate = document.querySelector('.start-date');
const endDate = document.querySelector('.end-date');
const searchForm = document.querySelector('form');
const nextBtn = document.querySelector('.next');
const previousBtn = document.querySelector('.prev');
const section = document.querySelector('section');
const nav = document.querySelector('nav');

// Esconder los botones de navegación : "Previous"/"Next" puesto que al inicio no se requieren 

nav.style.display = 'none';

// Definir la página inicial y declarar algunas variables auxiliares

let pageNumber = 0;
let url='';
let iniDate='';
let finDate='';
let imgUrl;


// Event listeners para controlar l afuncionalidad
searchForm.addEventListener('submit', submitSearch);
nextBtn.addEventListener('click', nextPage);
previousBtn.addEventListener('click', previousPage);

// definición de la función que se ejecutará al hacer clic en el borón submit
function submitSearch(e){
  pageNumber = 0;
  fetchResults(e);
}


 let corsProxy = 'https://cors-anywhere.herokuapp.com/';

function fetchResults(e) {
  // Use preventDefault() to stop the form submitting
  e.preventDefault();

// == Se utiliza corsProxy porque la API del NYTimes no permite solicitudes directas desde JavaScript del lado del navegador.
// Para solucionar esto durante el desarrollo, podemos usar un proxy CORS.
// PARA CADA VES QUE SE REQUIERA PROBAR SE TIENE QUE IR AL SITIO https://cors-anywhere.herokuapp.com/
//DONDE SE MOSTRARÁ EL MENSAJE : 
//This demo of CORS Anywhere should only be used for development purposes, see https://github.com/Rob--W/cors-anywhere/issues/301.To temporarily unlock access to the demo, click on the following button: 
// PRESIONAR EL BOTÓN: "Request temporary access to the demo server
// ENVIA EL SIGUIENTE MENSAJE: "You currently have temporary access to the demo server."
// ¡¡¡Listo¡¡¡


// Assemble the full URL, starting with a '?' for the first parameter.
 
url = `${corsProxy}${baseURL}?q=${searchTerm.value}&page=${pageNumber}`;

// La APY requiere que las fechas se escriban en formato aaaammdd
// Por lo tanto se eliminar los guiones

  if (startDate.value !== '') {
    iniDate=startDate.value;
    iniDate=iniDate.replaceAll("-","");  
    url = `${url}&begin_date=${iniDate}`;
  };

  if (endDate.value !== '') {
    finDate=endDate.value;
    finDate=finDate.replaceAll("-","");
    url = `${url}&end_date=${finDate}`;
  };
  url=url+`&api-key=${key}`;

  // Usar fetch() para realizar la petición a la API
  /*
Aquí ejecutamos la solicitud pasando nuestra variable de URL a `fetch()`, convertimos el cuerpo de la respuesta a JSON usando la función `json()`, y luego pasamos el JSON resultante a la función `displayResults()` para que los datos se muestren en nuestra interfaz de usuario. También capturamos y registramos cualquier error que pueda producirse.
*/

  fetch(url)
    .then( response => response.json() )
    .then( json => displayResults(json) )
    .catch( error => console.error(`Error fetching data: ${error.message}`) );
}

// Borrar todo el contenido que tenga el elemento HTML <section>

function displayResults(json) {

  while (section.firstChild) {
    section.removeChild(section.firstChild);
  }
    
/* almacenar el array que contiene los objetos que representan los artículos regresados */
      
  const articles = json.response.docs;
  
 /*   Se comprueba si se devuelven 10 artículos (la API devuelve hasta 10 artículos a la vez). Si es así, se muestra el menú de navegación con los botones de paginación «Anteriores 10» y «Siguientes 10». Si se devuelven menos de 10 artículos, caben todos en una sola página, por lo que no es necesario mostrar los botones de paginación.  */

console.log(articles);

  if (articles.length === 10) {
    nav.style.display = 'block';
  } else {
    nav.style.display = 'none';
  }

  // Si no hay artículos retornados
  if (articles.length === 0) {
    const para = document.createElement('p');
    para.textContent = 'No results returned.'
    section.appendChild(para);
  } else {
	  
    /* Para determinar qué propiedades de los objetos de artículo contenían los datos correctos para mostrar, consultamos la referencia de la API de búsqueda de artículos (véase NYTimes APIs)
    https://developer.nytimes.com/docs/articlesearch-product/1/types/Article
    */
    for (const current of articles) {
      const article = document.createElement('article');
      const heading = document.createElement('h2');
      const link = document.createElement('a');
      const img = document.createElement('img');
      const para1 = document.createElement('p');
      const keywordPara = document.createElement('p');
      keywordPara.classList.add('keywords');

      console.log(current);

      link.href = current.web_url;
      link.textContent = current.headline.main;
      para1.textContent = current.snippet;
      // insertar las palabras clave asociadas
      keywordPara.textContent = 'Keywords: ';
      for (const keyword of current.keywords) {
        const span = document.createElement('span');
        span.textContent = `${keyword.value} `;
        keywordPara.appendChild(span);
      }
      
      // checar si hay una imagen asociada
      // Solo mostramos la primera imagen si existe; de ​​lo contrario, se produciría un error.
      img.src = current.multimedia.default.url;

      // if (current.multimedia.length > 0) {
      //   img.src = `${corsProxy}${current.multimedia.default.url}`;
             
      //   img.alt = current.headline.main;
      //   imgUrl= imgUrl.add(img.src);
      //   console.log("IMG"+imgUrl );
      // }

      article.appendChild(heading);
      heading.appendChild(link);
      article.appendChild(img);
      article.appendChild(para1);
      article.appendChild(keywordPara);
      section.appendChild(article);
    }
  }
};


/*
La API del NYTimes solo devuelve 10 resultados a la vez; si hay más de 10 resultados disponibles, devolverá los primeros 10 (0-9) si el parámetro de la URL de la página está establecido en 0 (o no se incluye en absoluto ( 0 es el valor predeterminado); los siguientes 10 (10-19) si el parámetro está establecido en 1, y así sucesivamente se incrementa el parámetro para ir obteniendo las sucesivas páginas.
*/
function nextPage(e) {
  pageNumber++;
  fetchResults(e);
};

function previousPage(e) {
  if(pageNumber > 0) {
    pageNumber--;
  } else {
    return;
  }
  fetchResults(e);
};
