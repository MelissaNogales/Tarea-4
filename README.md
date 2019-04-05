# **Tare 4**
## **Unidad 4: Polimorfismo.**
### 1. Considera el siguiente fragmento de programa:
```csharp 
using System;

class A
{
  public int a;

  public A()
  {
    a = 10;
  }

  public _______ string Display()
  {
    return a.ToString();
  }
}

class B:A
{
  public int b;

  public B():base()
  {
    b = 15;
  }

  //  #  Después de contestar la pregunta 1                  

  //   #  Redefine el método Display( ) en este espacio,  debe regresar el campo b como string.
  public override string Display()
  {
    return b.ToString();
  }
}

 class Program
  {
    public static void Main()
    {
      A objA = new A();
      B objB = new B();

      Console.WriteLine(objA.Display()); ////  (1 )
      Console. WriteLine(objB.Display()); ////  ( 2)
    }
  }
   ```

### _1.1. ¿Qué valores imprimen las lineas (1) y (2)?_
####     _10 y 15._

### _1.2. Redefine el método Display en el espacio indicado,_
###      _Una vez redefinido el método, ¿qué valores imprimen las lineas (1) y (2)?._
####     _10 y 15._

### _1.3. ¿Que palabra debes agregar en la linea (public _______ string Display()) al definir A.Display()?_
####      _virtual_

### 2. Considera el siguiente fragmento de programa:
```csharp 
using System;
using System.Collections.Generic;

 ________ class Musico
{
  public string nombre;

  public Musico (string n)
  {
    nombre = n;
  }

  public abstract (A) void Afina();  (B)

  public (C) string Display()
  { 
    return nombre;
  }
}

class Bajista; Musico
{
  public string instrumento;

  public Bajista (string n, string i ) ......

  .........

  public _________ Afina()
  {
   ________________
  }
}

class Guitarrista ____________
{
  public instrumento;

  // Falta el constructor y otras cosas??
}

class Program
{
  public static Main()
  {
    Musico musico = new Musico("Django"); (D)

    Bajista b = new Bajista("Flea");
    Guitarrista g = new Guitarrista("Santana");

    List<Musico> musicos = ____________________

    musicos.Add( b);
    musicos.Add(g);

    foreach ( _____in musicos______)
          ____________________

    // (m as IAfina).Afina()

    Console.ReadKey();

  }
}
```

### _2.1. Completa el programa._
```csharp
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

    public abstract /*(A)*/ string Afina();  /*(B)*/

    public /*(C)*/ string Display()
    { 
      return nombre;
    }
  }

class Bajista: Musico
{
  public string instrumento;

  public Bajista (string n, string instrumento):base(n)
  {
    this.instrumento = instrumento;
  }

  public override string Afina()
  {
    return String.Format("Mi bajo está afinado", nombre);
  }
}

class Guitarrista: Musico
{
  public string instrumento;

  // Falta el constructor y otras cosas??
  //si

  public Guitarrista (string n, string instrumento):base(n)
  {
    this.instrumento = instrumento;
  }

  public override string Afina()
  {
    return String.Format("La guitarra está afinada", nombre);
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
          Console.WriteLine(mu.Afina());
        }

      // (m as IAfina).Afina()

      Console.ReadKey();
    }
  }
}
```

### _2.2. Hay un error en uno de los puntos (A)(B)(C)(D). ¿Cuál es y por qué?_
####      _(D) Las clases abstractas no se pueden instanciar._

#### _2.3. ¿Qué método se debe implementar obligatoriamente en ambas clases y por qué?_
####        _Afina, porque es abstracto._

#### _2.4. ¿Por qué no se ponen las llaves en (B)?, ¿Cuando si se pondrían?_
####        _Porque la clase no puede hacer ese método y  las llaves se ponen cuando hay bloque de                      instrucciones y los métodos son virtuales._

#### _2.5. ¿Qué pasa si el método Afina() lo hacemos virtual en lugar de abstract?_
####        _Marcaría error._

#### _3. Implementa el programa utilizando interfaces en lugar de herencia._
```csharp
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
```