using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraccionP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo T = new Triangulo(); //Instancio la clase Triangulo como T
            T.Saludo(); //Mando a llamar el metodo Saludo
            T.CalcularArea(); //Mando a llamar el metodo para calcular el Area
            T.CalcularPerimetro(); //Mando a llamar el metodo para calcular el Perimetro

            Cuadrado C = new Cuadrado(); //Instancio la clase Cuadrado como C
            C.Saludo(); //Mando a llamar el metodo Saludo
            C.CalcularArea(); //Mando a llamar el metodo para calcular el Area
            C.CalcularPerimetro(); //Mando a llamar el metodo para calcular el Perimetro

            Rectangulo R = new Rectangulo(); //Instancio la clase Rectangulo como R
            R.Saludo(); //Mando a llamar el metodo Saludo
            R.CalcularArea(); //Mando a llamar el metodo para calcular el Area
            R.CalcularPerimetro(); //Mando a llamar el metodo para calcular el Perimetro

            Console.ReadKey(); //Readkey para que no se cierre el programa xd
        }
    }
}
