
// EJEMPLO 06  GENERADOR DE HISTORIAS ABSURDAS

const customName = document.getElementById('customname');
console.log(customName);
const randomize = document.querySelector('.randomize');
const story = document.querySelector('.story');

function randomValueFromArray(array){
  const random = Math.floor(Math.random()*array.length);
  return array[random];
  
}

let storyText = "Hacía 94 grados Fahrenheit afuera, así que :insertx: salió a caminar. Cuando los turistas llegaron a :inserty:, se quedaron mirando horrorizados por unos momentos, :insertx: :insertz:. Bob lo vio todo, pero no se sorprendió: :insertx: pesa 300 libras, y era un día caluroso.";

let insertX =[ 'Willy the Goblin', 'Big Daddy', 'Father Christmas'];
// Willy the Goblin, Big Daddy, Papá Noel

let insertY =['el comedor social', 'Disneylandia', 'la casa blanca'];

// spontaneously combusted = se quemó espontáneamente
// melted into a puddle on the sidewalk = se derritió en un charco en la acera
// turned into a slug and crawled away = se convirtió en una babosa y se alejó arrastrándose

let insertZ =['se incendió espontáneamente', 'se derritió en un charco en la acera', 'se convirtió en una babosa y se arrastró lejos'];

randomize.addEventListener('click', result);

function result() {
   let newStory = storyText;
   let xItem = randomValueFromArray(insertX);
   let yItem = randomValueFromArray(insertY);
   let zItem = randomValueFromArray(insertZ);

   newStory = newStory.replace(':insertx:', xItem);
   newStory = newStory.replace(':inserty:', yItem);
   newStory = newStory.replace(':insertx:', xItem);
   newStory = newStory.replace(':insertz:', zItem);
   newStory = newStory.replace(':insertx:', xItem);

   if(customName.value !== '') {
     const name = customName.value;
     newStory = newStory.replace('Bob', name);
   }
 
   if(document.getElementById("uk").checked) {
     const weight = Math.round(300 * 0.453) + ' kilos';
     const temperature =  Math.round((94-32)* 5/9) + ' grados centigrados';
     newStory = newStory.replace('94 grados Fahrenheit', temperature);
     newStory = newStory.replace('300 libras', weight);
   
   }
 
   story.textContent = newStory ;
   story.style.visibility = 'visible';
 }
 