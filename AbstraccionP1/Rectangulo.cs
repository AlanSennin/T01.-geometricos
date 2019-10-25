using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraccionP1
{
    class Rectangulo: Geometricos
    {
        public override void Saludo() //Metodo para el Saludo de que es un Rectangulo
        {
            Console.WriteLine("¡Este es un Rectangulo!"); //Imprimir Saludo de que figura es
        }

        public override void CalcularArea(int Lado1=5, int Lado2=10) //Metodo para Calcular el Area recibiendo parametros
        {
            int Area; //Declaro Area como int

            Area = Lado1 * Lado2; //Operacion para calcular el Area

            Console.WriteLine("El Area del Rectangulo es: "+Area+ " metros cuadrados."); //Imprimir los resultados
        }

        public override void CalcularPerimetro(int Lado1=5, int Lado2=10) //Metodo para Calcular el Perimetro recibiendo parametros
        {
            int Perimetro; //Declaro Perimetro como int

            Perimetro = ((Lado1 * 2) + (Lado2 * 2)); //Operacion para calcular el Perimetro

            Console.WriteLine("El Perimetro del Rectangulo es: "+Perimetro+ " metros."); //Imprimir los resultados
            Console.WriteLine(""); //Write Line en blanco para dejar pasar un renglon entre figuras
        }
    }
}
