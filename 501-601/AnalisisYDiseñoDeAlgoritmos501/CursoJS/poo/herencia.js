//Puedes crear una clase hija que herede de una clase padre con extends. super() se usa dentro del constructor de la clase hija para llamar al constructor de la clase padre y pasarle los parámetros necesarios.

class Animal {
  constructor(nombre, especie) {
    this.nombre = nombre;
    this.especie = especie;
  }

  verInfo() {
    console.log(`El nombre del animal es ${this.nombre} y su especie es ${this.especie}`);
  }
}

class Perro extends Animal {
  constructor(nombre, raza) {
    super(nombre, "Canino"); // llama al constructor de Animal
    this.raza = raza;
  }

  ladrar() {
    console.log(`${this.nombre} dice: ¡Guau guau!`);
  }
}

let perro1 = new Perro("Firulais", "Labrador");
perro1.verInfo(); // El nombre del animal es Firulais y su especie es Canino
perro1.ladrar();  // Firulais dice: ¡Guau guau!
