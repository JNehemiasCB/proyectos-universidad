//En JavaScript, una clase es una forma de crear objetos con propiedades y métodos. Internamente, sigue siendo un azúcar sintáctico sobre el viejo sistema de prototipos de JavaScript, pero se usa igual que en otros lenguajes orientados a objetos.

// Definir una clase
class Animal {
  constructor(nombre, especie) {
    this.nombre = nombre;
    this.especie = especie;
  }

  // método
  verInfo() {
    console.log(`El nombre del animal es ${this.nombre} y su especie es ${this.especie}`);
  }
}

// Crear un objeto (instancia)
let gato = new Animal("Mishi", "Felino");

// Acceder a propiedades y métodos
console.log(gato.nombre);  // Mishi
gato.verInfo();            // El nombre del animal es Mishi y su especie es Felino
