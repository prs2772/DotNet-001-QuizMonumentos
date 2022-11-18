internal class OpcionPregunta
{
  //Texto de la opción
  private string _opcion = string.Empty;
  //Indica si la opción es valida (si da la pregunta por buena cuando es seleccionada). Puede haber varias opciones válidas por pregunta
  private bool _valida = false;
  //Indica si está seleccionada por el usuario
  private bool _seleccionada = false;

  public string Opcion { get { return _opcion; } }
  public bool Valida { get { return _valida; } }
  public bool Seleccionada { get { return _seleccionada; } set { _seleccionada = value; }}

  public OpcionPregunta(string _opcion, bool _valida)
  {
    this._opcion = _opcion;
    this._valida = _valida;
  }
}
