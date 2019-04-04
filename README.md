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

class B: A
{
   public int b;

   public B(): base()
   {
        b = 15;
   }

    //#Redefine el método Display( ) en este espacio,  debe regresar el campo b como string.
    public override string Display()
   {
       Console.WriteLine("{0}");
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
#### _virtual_

### 2. Considera el siguiente fragmento de programa:
```csharp 
using System;
using System.Collections.Generic;

 abstract class Musico
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

interface ISaluda
{
    void Saluda();
}

interface IHobby
{
    void Hobby();
}

class Bajista: Musico, ISaluda, IHobby
{
    public string instrumento;

    public Bajista (string n, string i ) 
    {
        this.nombre = n;
        this.instrumento = i;
    }

    public override Afina()
    {
      return "Bajo afinado";
    }

    public void Saluda()
        {
            Console.WriteLine("Hola soy bajista");
        }

    public void Hobby()
    {
        Console.WriteLine("Me gusta tocar el bajo");
    }
}

class Guitarrista: Musico, ISaluda, IHobby
{
    public instrumento;

    public Guitarrista (string n, string i ) 
    {
        this.nombre = n;
        this.instrumento = i;
    }

    public override Afina()
    {
      return "Guitarra afinada";
    }

      // Falta el constructor y otras cosas??
      //Si

    public void Saluda()
    {
        Console.WriteLine("Hola soy guitarrista");
    }

    public void Hobby()
    {
        Console.WriteLine("Me gusta tocar la guitarra");
    }
}
 
class Program
{
  public static Main()
   {
        Musico m = new Musico("Django"); (D)

        Bajista b = new Bajista("Flea");
        Guitarrista g = new Guitarrista("Santana");

        Musico [] m = ____________________

        m[0] = b;
        m[1] = g;

        foreach (Musico mu in musicos)
            {
                Console.WriteLine(mu.Afina());
            }

            Console.WriteLine(m.Afina());

        Console.ReadKey();
    }
}
```

### _2.1. Completa el programa._

### _2.2. Hay un error en uno de los puntos (A)(B)(C)(D). ¿Cuál es y por qué?_
####      _Ninguno_

#### _2.3. ¿Qué método se debe implementar obligatoriamente en ambas clases y por qué?_
####        _Afina, porque es abstracto._

#### _2.4. ¿Por qué no se ponen las llaves en (B)?, ¿Cuando si se pondrían?_
####        _Porque la clase no puede hacer ese método, las llaves se ponen cuando hay bloque de                        instruciones, los métodos son virtuales._

#### _2.5. ¿Qué pasa si el método Afina() lo hacemos virtual en lugar de abstract?_
####        _Marcaría error._

#### _3. Implementa el programa utilizando interfaces en lugar de herencia._