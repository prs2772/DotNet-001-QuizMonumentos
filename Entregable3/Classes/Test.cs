internal class Test
{
  private string _titulo = string.Empty;
  private List<PreguntaTest> _preguntas = new List<PreguntaTest>();

  public List<PreguntaTest> Preguntas { get { return _preguntas; } }//Solo lectura
  public string Titulo { get { return _titulo; } }//Solo lectura

  public Test()
  {
    _titulo = "¡Adivina el monumento!";
    //Generamos el test
    PreguntaTest pregunta;

    //Pregunta 1
    pregunta = new PreguntaTest(1, "Monumento diseñado para la exposición Universal de 1889 de París, conocido como la torre de los 300 metros en sus inicios, se trata de: ");
    pregunta.Opciones.Add(new OpcionPregunta("EL TESORO DE PETRA", false));
    pregunta.Opciones.Add(new OpcionPregunta("TORRE EIFFEL", true));
    pregunta.Opciones.Add(new OpcionPregunta("STONEHENGE", false));
    pregunta.Opciones.Add(new OpcionPregunta("EL CASTILLO DE NEUSCHWANSTEIN", false));
    _preguntas.Add(pregunta);

    //Pregunta 2
    pregunta = new PreguntaTest(2, "Construida y reconstruida entre los siglos V A.C. y el siglo XVI se erigió para evitar la invasión de los Mongoles en China. Con sus 21.200 kilómetros de largo es uno de los mayores monumentos creados por el hombre.");
    pregunta.Opciones.Add(new OpcionPregunta("STONEHENGE", false));
    pregunta.Opciones.Add(new OpcionPregunta("ÓPERA DE SIDNEY", false));
    pregunta.Opciones.Add(new OpcionPregunta("EL TESORO DE PETRA", false));
    pregunta.Opciones.Add(new OpcionPregunta("GRAN MURALLA CHINA", true));
    _preguntas.Add(pregunta);

    //Pregunta 3
    pregunta = new PreguntaTest(3, "Sitio arqueológico cerca de Ciudad de México. Uno de los centros políticos, religiosos y administrativos de toda mesoamérica entre los años 200 y 600. Entre sus numerosos monumentos destacan sus pirámides de la luna y del sol.");
    pregunta.Opciones.Add(new OpcionPregunta("TEOTIHUACÁN", true));
    pregunta.Opciones.Add(new OpcionPregunta("EL CASTILLO DE NEUSCHWANSTEIN", false));
    pregunta.Opciones.Add(new OpcionPregunta("LA BASÍLICA DE SAN PEDRO", false));
    pregunta.Opciones.Add(new OpcionPregunta("LA ESTATUA DE LA LIBERTAD", false));
    _preguntas.Add(pregunta);

    //Pregunta 4
    pregunta = new PreguntaTest(4, "Este anfiteatro del Imperio Romano se construyó en el siglo I y es uno de los que mejor se conserva del mundo. En su interior se vivieron luchas de gladiadores y tenía un aforo de 65.000 espectadores.");
    pregunta.Opciones.Add(new OpcionPregunta("EL GOLDEN GATE", false));
    pregunta.Opciones.Add(new OpcionPregunta("EL COLISEO DE ROMA", true));
    pregunta.Opciones.Add(new OpcionPregunta("TEOTIHUACÁN", false));
    pregunta.Opciones.Add(new OpcionPregunta("LA BASÍLICA DE SAN PEDRO", false));
    _preguntas.Add(pregunta);

    //Pregunta 5
    pregunta = new PreguntaTest(5, "Hecho de mármol blanco, erigido entre 1631 y 1654 en la localidad india de Agra es un monumento funerario de Arjumand Banu Begum");
    pregunta.Opciones.Add(new OpcionPregunta("TAJ MAHAL", true));
    pregunta.Opciones.Add(new OpcionPregunta("LOS GUERREROS DE TERRACOTA", false));
    pregunta.Opciones.Add(new OpcionPregunta("ANGKOR WAT", false));
    pregunta.Opciones.Add(new OpcionPregunta("LA ALHAMBRA", false));  
    _preguntas.Add(pregunta);
  }
}
//Fuente: https://www.elledecor.com/es/hoteles-restaurantes-planes/g40867596/monumentos-mas-bonitos-famosos-mundo/
