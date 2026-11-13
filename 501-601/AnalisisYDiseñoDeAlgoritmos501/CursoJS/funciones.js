function saludar(){
   let respuesta = prompt("¿Cómo estas?");
   if (respuesta.toLowerCase() === "bien"){
      alert("Me alegro");
   } else {
      alert("una pena");
   }
}

const saludar = function(){
   let respuesta = prompt("¿Cómo estas?");
   if (respuesta.toLowerCase() === "bien"){
      alert("Me alegro");
   } else {
      alert("una pena");
   }  
}

const saludar = () => {
   let respuesta = prompt("¿Cómo estas?");
   if (respuesta.toLowerCase() === "bien"){
      alert("Me alegro");
   } else {
      alert("una pena");
   }
}