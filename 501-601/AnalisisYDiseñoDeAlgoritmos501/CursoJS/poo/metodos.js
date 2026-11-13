//Los métodos se definen dentro de la clase sin usar la palabra clave function:

class Vehiculo {
  constructor(marca) {
    this.marca = marca;
  }

  encender() {
    console.log(`${this.marca} está encendido`);
  }

  apagar() {
    console.log(`${this.marca} se ha apagado`);
  }
}

let auto = new Vehiculo("Toyota");
auto.encender(); // Toyota está encendido
auto.apagar();   // Toyota se ha apagado

//💡 En JavaScript los métodos están en el prototype de la clase, no en cada instancia, por lo tanto no se duplican en memoria.