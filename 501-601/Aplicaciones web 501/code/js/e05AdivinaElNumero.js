// EJEMPLO 05  ADIVINA EL NÚMERO
// Proceso del juego:
// 1.	Generar un número aleatorio entre 1 y 100. 
// 2.	Registrar el número del intento en el que el jugador se encuentre. Empezando en 1. 
// 3.	Darle al jugador una forma de adivinar cuál es el número. 
// 4.	Una vez que se ha introducido el número, registrarlo en alguna parte para que el jugador pueda ver sus intentos previos. 
// 5.	A continuación, comprobar si el número es correcto. 
// 6.	Si es correcto: 
      // a.	Mostrar un mensaje de felicitaciones.
      // b.	Hacer que el jugador no pueda introducir más intentos (esto arruinaría el juego).
      // c.	Mostrar un control que permita al jugador volver a empezar el juego.
// 7.	Si es incorrecto y al jugador todavía le quedan intentos: 
      // a.	Decirle al jugador que ha fallado.
      // b.	Dejar que el jugador lo intente de nuevo.
      // c.	Incrementa el número de intentos en 1.
// 8.	Si el jugador falla y no le quedan turnos: 
      // a.	Decirle al jugador que el juego se ha terminado.
      // b.	Hacer que el jugador no pueda introducir más intentos (esto arruinaría el juego).
      // c.	Mostrar un control que permita al jugador volver a empezar el juego.
// 9.	Una vez que el juego se reinicia, asegúrate de que la lógica del juego y la IU (interfaz de usuario) se restablezcan por completo, luego vuelve al paso 1.

// variables y constantes
// Referencias al campo donde el usuario introducirá  el valor 
   const guessField = document.querySelector('.guessField');

 //Referencia al botón Submit
   const guessSubmit = document.querySelector('.guessSubmit');

// referencia al párrafo que mostrará los intentos anteriores 
   const guesses = document.querySelector('.guesses');

//Referencia al párrafo que mostrará el mensaje del resultado del último intento
   const lastResult = document.querySelector('.lastResult');

//Referencia al párrafo que indicará si el último intento estuvo alto o bajo 
   const lowOrHi = document.querySelector('.lowOrHi');

// número aleatorio entre 1 y 100
   let randomNumber = Math.floor(Math.random() * 100) + 1;

// Variables para almacenar el número de intentos y botón reiniciar
   let guessCount = 1;
   let resetButton;

   //Agregar un listener de evento click en el botón tipo Submit: "Enviar" 
   guessSubmit.addEventListener('click', checkGuess);

   // Colocar el foco en el campo para introducir el valor
   // Variables que no son referencias a elementos de formulario no tienen método focus(). 
      guessField.focus();

// funciones

// Fución que checa si el intento fué exitoso o no o si se cabaron los intentos
function checkGuess() {
   // Se captura el dato, se transforma aNúmero y se almacena en la variable
  let userGuess = Number(guessField.value);

  if (guessCount === 1) {
    guesses.textContent = 'Intentos anteriores: ';
  }
   // agregar intento a mensaje intentos anteriores
  guesses.textContent += userGuess + ' ';     

   // Si lo adivinó se envía mensaje en fondo verde se reinicia la variable lowUrHi y se termina el juego
  if (userGuess === randomNumber) {
    lastResult.textContent = '¡Felicidades! ¡Lo adivinaste!';
    lastResult.style.backgroundColor = 'green';
    lowOrHi.textContent = '';
    setGameOver();

    // Si no adivino y se llegó al intento 8 se envía mensaje y termina el juego
  } else if (guessCount === 8) {
    lastResult.textContent = '¡¡¡Fin del juego!!!';
    setGameOver();

   // Si el intento fue incorrecto pero aún tiene intentos por hacer se envía mensaje en color de fondo rojo y se envía el mensaje si el intento fué alto o bajo    
  } else {
    lastResult.textContent = '¡Incorrecto!';
    lastResult.style.backgroundColor = 'red';
    if(userGuess < randomNumber) {
      lowOrHi.textContent = '¡El número es muy bajo!';
    } else if(userGuess > randomNumber) {
      lowOrHi.textContent = '¡El número es muy grande!';
    }
  }

  // Se incrementa el número de intentos, reinicia el campo de captura y se coloca el foco 
  guessCount++;
  guessField.value = '';
  guessField.focus();
}

// Se termina el juego y: 
// 1) se deshabilitan el campo para introducir valor y el botón par a enviarlo, 
// 2) Se crea y agrega un botón para iniciar otro juego y
// 3) Se le agrega un listener para evento click.

function setGameOver() {
  guessField.disabled = true;
  guessSubmit.disabled = true;
  resetButton = document.createElement('button');
  resetButton.textContent = 'Iniciar nuevo juego';
  document.body.append(resetButton);
  resetButton.addEventListener('click', resetGame);
}

// Se reinicia el juego lo cual inplica: 
// 1) Reiniciar la variable de conteo de intentos y los párrafos de mensajes,
// 2) se elimina el boton "reiniciar", 
// 3) se habilitan el campo para introducir el valor y el botón para enviarlo,
// 4) se reinicia y coloca el foco en el campo de captura
// 5) Se modifica el fondo a blanco y
// 6) Se calcula el nuevo valor a adivinar 
function resetGame() {
  guessCount = 1;

  const resetParas = document.querySelectorAll('.resultParas p');
  for (let i = 0 ; i < resetParas.length ; i++) {
    resetParas[i].textContent = '';
  }

  resetButton.parentNode.removeChild(resetButton);

  guessField.disabled = false;
  guessSubmit.disabled = false;
  guessField.value = '';
  guessField.focus();

  lastResult.style.backgroundColor = 'white';

  randomNumber = Math.floor(Math.random() * 100) + 1;
}



