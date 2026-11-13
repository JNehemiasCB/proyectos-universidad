//Los métodos o propiedades estáticas pertenecen a la clase, no a las instancias. Se acceden con Clase.metodo(), no con objeto.metodo().
class Matematica {
  static sumar(a, b) {
    return a + b;
  }
}

console.log(Matematica.sumar(3, 5)); // 8
