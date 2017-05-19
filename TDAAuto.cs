public class TDAAuto {

  //atributos
  private List<TDARueda> colecRuedas;
  private TDACarroceria tdaCarroceria;
  private []TDAVentana colecVentanas;
  
  //constructor
  public TDAAuto( TDACarroceria paramCarroceria, int cantVentanas ) {
    colecRuedas = new List<TDARueda>();
    tdaCarroceria = paramCarroceria;
    colecVentanas = new TDAVentana[cantVentanas];
  }
  
  //encapsulamiento
  public List<TDARueda> ColecRuedas {
    get { return colecRuedas; }
    set { colecRuedas = value; }
  }
    
  public TDACarroceria TdaCarroceri {
    get { return tdaCarroceria; }
    set { tdaCarroceria = value; }
  }
    
  public []TDAVentana ColecVentanas {
    get { return colecVentanas; }
    set { colecVentanas = value; }
  }
  
}
