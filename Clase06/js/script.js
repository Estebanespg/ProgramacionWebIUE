const boton = document.getElementById("btnCambiar");
const mensaje = document.getElementById("mensaje");

boton.addEventListener("click", function () {
  mensaje.textContent = "Javascript modificó el HTML";
});

// Variables
let nombre = "Ana"; //String
let edad = 25; // Entero
let inscrito = true; // Booleano
const nombreEvento = "Programación Web";
let telefono; // undefined
let ciudad = null; // null

// console.log(nombre);
// console.log(edad);
// console.log(inscrito);

console.log(typeof nombre);

let mensajePersona = `${nombre} hola, tienes ${edad} años.`;
console.log(mensajePersona);

/*******************************************************************
 * Ciclos
 *******************************************************************/
for (let particante of participantes) {
  // console.log(particante);
}

/*******************************************************************
 * Objetos
 *******************************************************************/
const persona = {
  nombre: "Ana",
  apellido: "García",
  edad: 25,
};

// console.log(persona.apellido);

/*******************************************************************
 * Clase
 *******************************************************************/
class Persona {
  constructor(nombre, apellido, edad) {
    this.nombre = nombre;
    this.apellido = apellido;
    this.edad = edad;
  }

  nombreCompleto() {
    return `${this.nombre} ${this.apellido}`;
  }

  esMayorEdad() {
    return this.edad >= 18;
  }
}

const personas = [
  new Persona("Ana", "Garcia", 25),
  new Persona("Luis", "Pérez", 17),
  new Persona("María", "López", 32),
];

const contenedor = document.getElementById("listaParticipantes");

for (let persona of personas) {
  const estado = persona.esMayorEdad() ? "Mayor de edad" : "Menor de edad";

  contenedor.innerHTML += `
        <article>
            <h2>${persona.nombreCompleto()}</h2>
            <p>Edad: ${persona.edad}</p>
            <p>${estado}</p>
        </article>
    `;
}
