﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function iniciaTest(idPregunta) {
  document.getElementById("btn-inicia-test").style.display = "none";
  document.getElementById(idPregunta).style.display = "block";
  document.getElementById("counters").style.display = "block";
}
function aceptarPregunta(id, idMax, ans) {
  //alert(JSON.stringify(ans))
  if (validaRbtn(id)) {
    //Marcamos solo si fue correcta o no
    let ele = document.getElementsByName("rbtn_" + id);
    let seleccion;
    let idBtnSeleccion
    for (i = 0; i < ele.length; i++) {
      //Marcamos
      if (ele[i].checked) {
        seleccion = ele[i].value
        idBtnSeleccion = ele[i].id
      }
    }
    let alertMess = ""
    for (var key in ans) {
      if (ans[key]["Opcion"] === seleccion) {
        document.getElementById("lbl_" + idBtnSeleccion).className = "opcion-correcta"
        document.getElementById("lblResultadoActual").innerText = (parseInt(document.getElementById("lblResultadoActual").innerHTML) + 1)
        alertMess = "¡Correcto!"
        break
      }else{
        document.getElementById("lbl_" + idBtnSeleccion).className = "opcion-incorrecta"
        alertMess = "Hmmm. No, esa no es la respuesta"
      }
    }
    //Ponemos visible el siguiente y ocultamos este botón
    siguientePaso(id, idMax, alertMess)
  }
}
function siguientePaso(id, idMax, alertMess) {
  //Pasamos a la siguiente
  alert(alertMess)
  if (id < idMax) {
    document.getElementById("pregunta_" + id).style.display = "none";
    document.getElementById("pregunta_" + (id + 1)).style.display = "block";
  } else {
    document.getElementById("pregunta_" + id).style.display = "none";
    document.getElementById("resultados").style.display = "block";
  }
}
function validaRbtn(id) {
  let radios = document.getElementsByName("rbtn_" + id);
  let formValid = false;

  let i = 0;
  while (!formValid && i < radios.length) {
    if (radios[i].checked) formValid = true;
    i++;
  }
  if (!formValid) alert("Antes de continuar, selecciona una opción");
  return formValid;
}
