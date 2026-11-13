# Juego de la Vida de Conway – Implementación en C#

![Consola](https://img.shields.io/badge/Plataforma-Consola-brightgreen)
![Lenguaje-C#](https://img.shields.io/badge/Lenguaje-C%23-239120)

Implementación del famoso autómata celular **Juego de la Vida de Conway** en C#, usando arreglos bidimensionales y reglas clásicas de evolución.

---

## 📌 Introducción

El Juego de la Vida de Conway simula la evolución de una población de células en una cuadrícula, siguiendo reglas simples:
- **Soledad**: < 2 vecinos → muerte.
- **Supervivencia**: 2 o 3 vecinos → vive.
- **Nacimiento**: 3 vecinos → nace.
- **Sobrepoblación**: > 3 vecinos → muerte.

Este programa muestra un **planeador** (glider) evolucionando durante 20 generaciones.

---

## 🧠 Algoritmos y uso de arreglos

- **Arreglo bidimensional** `bool[,]` almacena el estado del mundo (15×30).
- **Conteo de vecinos**: recorre las 8 celdas adyacentes, respetando límites.
- **Nueva generación**: se calcula en un arreglo separado para evitar interferencias.
- **Complejidad**: O(n×m) por generación (n = filas, m = columnas).

---

## ▶️ Cómo ejecutar

### Requisitos
- .NET 6.0 o superior


🔧 Personalización
Modifica el método InicializarMundo() en Program.cs para probar otros patrones:
// Bloque estático
mundo[5, 10] = true;
mundo[5, 11] = true;
mundo[6, 10] = true;
mundo[6, 11] = true;

Presiona cualquier tecla para iniciar.
Observa la evolución del planeador.
Al final, presiona una tecla para salir.

Notas
Los bordes no son toroidales (las células fuera de límites se consideran muertas).
Ideal para aprender sobre autómatas celulares, arreglos y simulaciones en C#.