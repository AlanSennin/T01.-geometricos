using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraccionP1
{
    public abstract class Geometricos
    {
        public abstract void Saludo(); //Creo el metodo para decir que figura es en Abstracto

        public abstract void CalcularArea(int Lado1=5, int Lado2=10); //Creo el metodo para Calcular el Area en Abstracto y les asigno valor en Lado 1 y Lado 2 como parametros.
        public abstract void CalcularPerimetro(int Lado1=5, int Lado2=10); //Creo el metodo para Calcular el Perimetro en Abstracto y les asigno valor en Lado 1 y Lado 2 como parametros.
    }
}
