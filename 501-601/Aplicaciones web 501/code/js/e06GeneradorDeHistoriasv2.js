
// EJEMPLO 06  GENERADOR DE HISTORIAS ABSURDAS

const customName = document.getElementById('customname');
const randomize = document.querySelector('.randomize');
const story = document.querySelector('.story');

function randomValueFromArray(array){
  const random = Math.floor(Math.random()*array.length);
  return array[random];
  
}
let storyText, insertX, insertY, insertZ;

let storyTextEN = "It was 94 fahrenheit outside, so :insertx: went for a walk. When he got to :inserty:, he stared in horror for a few moments, then :insertz:. Bob saw the whole thing, but was not surprised — :insertx: weighs 300 pounds, and it was a hot day.";

let insertXEN =[ 'Willy the Goblin', 'Big Daddy', 'Father Christmas'];
let insertYEN =['the soup kitchen', 'Disneyland', 'the White House'];
let insertZEN =['spontaneously combusted', 'melted into a puddle on the sidewalk', 'turned into a slug and crawled away'];

let storyTextES = "Afuera hacía 34 grados centígrados, así que :insertx: salió a caminar. Cuando llegó a :inserty:, miró con horror por unos momentos, luego :insertz:. Bob vio todo, pero no se sorprendió — :insertx: pesa 127 kilos y era un día caluroso.";

let insertXES =[ 'Willy el duende', 'Gran Humanoide', 'Papá Noel'];
let insertYES =['el comedor de beneficencia', 'Disneylandia', 'la Casa Blanca'];
let insertZES =['se quemó espontáneamente', 'se fundió en un charco en la acera', 'se convirtió en una babosa y se arrastró lejos'];

// spontaneously combusted = se quemó espontáneamente
// melted into a puddle on the sidewalk = se derritió en un charco en la acera
// turned into a slug and crawled away = se convirtió en una babosa y se alejó arrastrándose



randomize.addEventListener('click', result);

function result() {
  if(document.getElementById("es").checked) {
    storyText = storyTextES;
    insertX = insertXES;
    insertY = insertYES;
    insertZ = insertZES; 
    }
    else{
    storyText = storyTextEN;
    insertX = insertXEN;
    insertY = insertYEN;
    insertZ = insertZEN; 
    }
   let newStory = storyText;
   let xItem = randomValueFromArray(insertX);
   let yItem = randomValueFromArray(insertY);
   let zItem = randomValueFromArray(insertZ);

   newStory = newStory.replace(':insertx:', xItem);
   newStory = newStory.replace(':inserty:', yItem);
   newStory = newStory.replace(':insertz:', zItem);
   newStory = newStory.replace(':insertx:', xItem);

   if(customName.value !== '') {
     const name = customName.value;
     newStory = newStory.replace('Bob', name);
   }
 
   story.textContent = newStory ;
   story.style.visibility = 'visible';
 }
 