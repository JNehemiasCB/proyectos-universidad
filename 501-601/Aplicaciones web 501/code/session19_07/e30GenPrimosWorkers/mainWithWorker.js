/* ==================  WORKERS  ==================================
A thread is a sequence of instructions that a program follows. Because the program consists of a single thread, it can only do one thing at a time: so if it is waiting for our long-running synchronous call to return, it can't do anything else.

Workers give you the ability to run some tasks in a different thread, so you can start the task, then continue with other processing (such as handling user actions).
There are three different sorts of workers: dedicated workers, shared workers, service workers

*/

const titulo = document.querySelector('h1')
titulo.textContent = "Ejemplo usando workers"

// Create a new worker, giving it the code in "generate.js"
const worker = new Worker('./generateWithWorker.js');

// When the user clicks "Generate primes", send a message to the worker.
// The message command is "generate", and the message also contains "quota",
// which is the number of primes to generate.

document.querySelector('#generate').addEventListener('click', () => {
  const quota = document.querySelector('#quota').value;
  worker.postMessage({
    command: 'generate',
    quota,
  });
});

// When the worker sends a message back to the main thread,
// update the output box with a message for the user, including the number of
// primes that were generated, taken from the message data.

worker.addEventListener('message', (message) => {
  document.querySelector('#output').textContent = `Finished generating ${message.data} primes!`;
});

document.querySelector('#reload').addEventListener('click', () => {
  document.querySelector('#user-input').value = '';
  document.location.reload();
});
