const form = document.getElementById("formularioReserva");
const btnReservar = document.getElementById("btnReservar");
const toast = document.getElementById("toastReserva");

// COMPONENTE TOAST
const toastBootstrap = bootstrap.Toast.getOrCreateInstance(toast);

// FORMULARIO RESERVA
form.addEventListener("submit", function (e) {
  e.preventDefault();

  const data = new FormData(form);

  const datosFormulario = Object.fromEntries(data);

  datosFormulario.Taller = data.getAll("Taller");

  console.log(datosFormulario);

  // MOSTRAR TOAST
  toastBootstrap.show();
});
