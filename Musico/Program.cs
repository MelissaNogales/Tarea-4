using System;
using System.Collections.Generic;

namespace Musico
{
  abstract class Musico
  {
    public string nombre;

    public Musico (string n)
    {
      nombre = n;
    }

    public /*(C)*/ string Display()
    { 
      return nombre;
    }
  }

  interface IAfina
  {
    void IAfina();
  }

class Bajista: Musico, IAfina
{
  public string instrumento;

  public Bajista (string n, string instrumento):base(n)
  {
    this.instrumento = instrumento;
  }

  public void IAfina()
  {
      Console.WriteLine("Se afina el bajo");
  }
}

class Guitarrista: Musico, IAfina
{
  public string instrumento;

  // Falta el constructor y otras cosas??
  //si

  public Guitarrista (string n, string instrumento):base(n)
  {
    this.instrumento = instrumento;
  }

  public void IAfina()
  {
      Console.WriteLine("Se afina la guitarra");
  }
}

  class Program
  {
    static void Main(string[] args)
    {
      //Musico musico = new Musico("Django"); (D)

      Bajista b = new Bajista("Flea", "bajo");
      Guitarrista g = new Guitarrista("Santana", "guitarra");

      List<Musico> musicos = new List<Musico>();

      musicos.Add(b);
      musicos.Add(g);

       foreach(Musico mu in musicos)
        {
          Console.WriteLine(mu as IAfina);
        }

      // (m as IAfina).Afina()

      Console.ReadKey();
    }
  }
}