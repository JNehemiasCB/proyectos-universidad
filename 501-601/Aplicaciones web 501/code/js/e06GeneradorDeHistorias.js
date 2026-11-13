
// EJEMPLO 06  GENERADOR DE HISTORIAS ABSURDAS

const customName = document.getElementById('customname');
console.log(customName);
const randomize = document.querySelector('.randomize');
const story = document.querySelector('.story');

function randomValueFromArray(array){
  const random = Math.floor(Math.random()*array.length);
  return array[random];
  
}

let storyText = "It was 94 fahrenheit outside, so :insertx: went for a walk. When they got to :inserty:, they stared in horror for a few moments, then :insertz:. Bob saw the whole thing, but was not surprised — :insertx: weighs 300 pounds, and it was a hot day.";

let insertX =[ 'Willy the Goblin', 'Big Daddy', 'Father Christmas'];
// Willy the Goblin, Big Daddy, Papá Noel

let insertY =['the soup kitchen', 'Disneyland', 'the White House'];

// spontaneously combusted = se quemó espontáneamente
// melted into a puddle on the sidewalk = se derritió en un charco en la acera
// turned into a slug and crawled away = se convirtió en una babosa y se alejó arrastrándose

let insertZ =['spontaneously combusted', 'melted into a puddle on the sidewalk', 'turned into a slug and crawled away'];

randomize.addEventListener('click', result);

function result() {
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
 
   if(document.getElementById("uk").checked) {
     const weight = Math.round(300/14) + ' stones';
     const temperature =  Math.round((94-32)* 5/9) + ' centigrade';
     newStory = newStory.replace('94 fahrenheit', temperature);
     newStory = newStory.replace('300 pounds', weight);
   
   }
 
   story.textContent = newStory ;
   story.style.visibility = 'visible';
 }
 