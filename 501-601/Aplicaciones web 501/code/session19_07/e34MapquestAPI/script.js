/* Ir a https://developer.mapquest.com	
darse de alta con una cuenta Free hasta 15000 transacciones por mes  y obtener la Cosumer Key (requiere una tarjeta de crédito o debidto pero no se realiza ningun cargo hasta que se consumen las 15000 solicitudes gratuitas)

Documentación: https://developer.mapquest.com/documentation/mapquest-js/v1.3/l-mapquest-control/

*/
L.mapquest.key = '';

// 'map' refers to a <div> element with the ID map
const map = L.mapquest.map('map', {

  // coordenadas de Acapulco en 
  //https://www.123coordenadas.com/

  center: [16.8531086, -99.8236533],
  // center: [53.480759, -2.242631],   <== Manchester
  // 1. change 'map' to 'hybrid', try other type of map
  // "Satellite", "Dark" , "Light", 
  // probar diferente nivel de zoom

  layers: L.mapquest.tileLayer('hybrid'),
  zoom: 12
});

// 2. Add control
// creates a simple full-featured control set, and it is placed in the top-right-hand corner by default.
// Se puede modificar, utilizando por ejemplo: 
// map.addControl(L.mapquest.control({ position: 'bottomright' }));
// There are other types of control available, for example:
// mapquest.searchControl() and mapquest.satelliteControl()


map.addControl(L.mapquest.control());

// 3. Add icon
// agregar un markador indicando su posición y el icono
// L.marker([53.480759, -2.242631], {

L.marker([16.8531086, -99.8236533], {  
  icon: L.mapquest.icons.marker({
    primaryColor: '#22407F',
    secondaryColor: '#3B5998',
    shadow: true,
    size: 'md',
    symbol: 'A'
  })
})
.bindPopup( 'Aqui está mi Acapulquito querido')
//.bindPopup('This is Manchester!')
.addTo(map);

/* ===========Ejemplo con New York ======================
L.mapquest.key = 'KEY';
var baseLayer = L.mapquest.tileLayer('dark');
          
L.mapquest.geocoding().geocode(['New York, NY'], showMap);

function showMap(err, data) {
  var map = createMap();
  map.addControl(L.mapquest.control());
  addLayerControl(map);
}

function createMap() {
  var map = L.mapquest.map('map', {
    center: [40.7237, -73.9825],
    zoom: 14,
    layers: baseLayer
  });
  return map;
}

function addLayerControl(map) {
  L.control.layers({
    'Map': L.mapquest.tileLayer('map'),
    'Satellite': L.mapquest.tileLayer('satellite'),
    'Hybrid': L.mapquest.tileLayer('hybrid'),
    'Light': L.mapquest.tileLayer('light'),
    'Dark': baseLayer
  }, {}, { position: 'topleft'}).addTo(map);
}

*/
