// JavaScript: explique cómo almacenaría y consultaría información de un arreglo de objetos.
const disciplinas = [
  { id: 1, nombre: 'CrossFit', entrenador: 'Carlos', cupos: 15, disponible: true },
  { id: 2, nombre: 'Yoga', entrenador: 'Ana', cupos: 20, disponible: true },
  { id: 3, nombre: 'Spinning', entrenador: 'Luis', cupos: 0, disponible: false },
  { id: 4, nombre: 'Boxeo', entrenador: 'Carlos', cupos: 10, disponible: true }
];

console.log("--- Lista de disciplinas ---");
console.log(disciplinas);





const disciplinasDisponibles = disciplinas.filter(d => d.disponible == true);
console.log("1. Disciplinas con cupos disponibles:", disciplinasDisponibles);

const disciplinaBuscada = disciplinas.find(d => d.id === 2);
console.log("2. Búsqueda por ID (2):", disciplinaBuscada?.nombre);

const entrenadores = disciplinas.map(d => `Coach: ${d.entrenador} (${d.nombre})`);
console.log("3. Lista de entrenadores y sus clases:", entrenadores);