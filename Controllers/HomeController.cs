using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Entregable3.Models;
using System.Text;

namespace Entregable3.Controllers;

public class HomeController : Controller
{
  private readonly ILogger<HomeController> _logger;

  public HomeController(ILogger<HomeController> logger)
  {
    _logger = logger;
  }

  public IActionResult Index()
  {
    return View();
  }

  public IActionResult TestOrtodoxo()
  {
    Test test = new Test();
    StringBuilder aciertos = new StringBuilder(), fallos = new StringBuilder();
    if (HttpMethods.IsPost(Request.Method))
    {
      try
      {
        for (ushort preguntaIndx = 0; preguntaIndx < test.Preguntas.Count; preguntaIndx++)
        {
          var pregunta = test.Preguntas[preguntaIndx];
          string opcSelected = Request.Form[$"rbtn_{pregunta.NumPregunta}"].ToString();
          //Por cada opción de la pregunta actual ->
          for (ushort opcionIndx = 0; opcionIndx < pregunta.Opciones.Count; opcionIndx++)
          {
            OpcionPregunta opcion = pregunta.Opciones[opcionIndx];
            if (opcSelected.Equals(opcion.Opcion))
            {
              if (opcion.Valida)
              {
                aciertos.Append($"#{preguntaIndx + 1}) {pregunta.Pregunta}  ->  Respondiste: {opcion.Opcion}!SLN!");
              }
              else
              {
                fallos.Append($"#{preguntaIndx + 1}) {pregunta.Pregunta}  ->  Respondiste: {opcion.Opcion}!SLN!");
              }
              break;
            }
          }
        }
        aciertos.Insert(0, aciertos.Length > 0 ? "!SLN!!SLN!!SLN!Tus aciertos: !SLN!!SLN!" : string.Empty);
        fallos.Insert(0, fallos.Length > 0 ? "!SLN!!SLN!!SLN!Tus errores: !SLN!!SLN!" : string.Empty);
        ViewData["resultadosTest"] = aciertos.ToString() + fallos.ToString();
        ViewData["terminado"] = "terminado";
      }
      catch (Exception)
      { }
    }
    else
    {
      ViewData["resultadosTest"] = string.Empty;
    }
    return View();
  }

  public IActionResult Privacy()
  {
    return View();
  }

  [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
  public IActionResult Error()
  {
    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
  }
}
