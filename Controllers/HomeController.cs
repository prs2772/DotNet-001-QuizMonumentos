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
    StringBuilder result = new StringBuilder();
    List<string> aciertos = new List<string>();
    List<string> fallos = new List<string>();
    if (HttpMethods.IsPost(Request.Method))
    {
      try
      {
        for (ushort preguntaIndx = 0; preguntaIndx < test.Preguntas.Count; preguntaIndx++)
        {
          var pregunta = test.Preguntas[preguntaIndx];
          string opcSelected = Request.Form[$"rbtn_{pregunta.NumPregunta}"].ToString();
          for (ushort opcionIndx = 0; opcionIndx < pregunta.Opciones.Count; opcionIndx++)
          {
            OpcionPregunta opcion = pregunta.Opciones[opcionIndx];
            if (opcSelected.Equals(opcion.Opcion))
            {
              if (opcion.Valida)
              {
                aciertos.Add(pregunta.Pregunta + " -> " + opcion.Opcion);
              }
              else
              {
                fallos.Add(pregunta.Pregunta + " -> " + opcion.Opcion);
              }
              break;
            }
          }
        }
        foreach(string cadena in aciertos)
        {
          Console.WriteLine(cadena);
        }
        foreach(string cadena in aciertos)
        {
          Console.WriteLine(cadena);
        }
      }
      catch (Exception)
      { }
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
