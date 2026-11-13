class Animal {
  hacerSonido() {
    console.log("El animal hace un sonido");
  }
}

class Gato extends Animal {
  hacerSonido() {
    console.log("El gato maúlla: Miau miau");
  }
}

let gato = new Gato();
gato.hacerSonido(); // El gato maúlla: Miau miau
