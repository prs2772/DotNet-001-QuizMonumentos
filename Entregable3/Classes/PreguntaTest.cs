internal class PreguntaTest
{
  private ushort _numPregunta;
  private string _pregunta = string.Empty;
  private List<OpcionPregunta> _opciones = new List<OpcionPregunta>();

  public string Pregunta { get { return _pregunta; } set { _pregunta = value; } }
  public List<OpcionPregunta> Opciones { get { return _opciones; } }
  public ushort NumPregunta { get { return _numPregunta; } }

  public PreguntaTest(ushort _numPregunta, string _pregunta)
  {
    this._numPregunta = _numPregunta;
    this._pregunta = _pregunta;
  }

  public List<OpcionPregunta> OpcionesCorrectas()
  {
    List<OpcionPregunta> opcionesCorrectas = new List<OpcionPregunta>();
    foreach(OpcionPregunta opcion in _opciones)
    {
      if(opcion.Valida)
        opcionesCorrectas.Add(opcion);
    }
    return opcionesCorrectas;
  }
  public List<string> OpcionesCorrectasStr()
  {
    List<string> opcionesCorrectas = new List<string>();
    foreach(OpcionPregunta opcion in _opciones)
    {
      if(opcion.Valida)
        opcionesCorrectas.Add(opcion.Opcion);
    }
    return opcionesCorrectas;
  }
}