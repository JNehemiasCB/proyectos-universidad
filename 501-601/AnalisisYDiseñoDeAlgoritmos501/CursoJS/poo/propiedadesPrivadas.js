class Usuario {
  #password; // privada

  constructor(nombre, password) {
    this.nombre = nombre;
    this.#password = password;
  }

  verificarPassword(pass) {
    return this.#password === pass;
  }
}

let u = new Usuario("Carlos", "1234");
console.log(u.nombre); // Carlos
// console.log(u.#password); ❌ Error: campo privado
console.log(u.verificarPassword("1234")); // true
