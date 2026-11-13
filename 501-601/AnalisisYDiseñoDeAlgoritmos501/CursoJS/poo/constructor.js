//El método constructor() es el que se ejecuta automáticamente al crear una instancia de la clase con new.Aquí defines las propiedades iniciales del objeto:

class Persona {
  constructor(nombre, edad) {
    this.nombre = nombre;
    this.edad = edad;
  }
}

let persona1 = new Persona("Juan", 30);
console.log(persona1.nombre); // Juan
console.log(persona1.edad);   // 30
