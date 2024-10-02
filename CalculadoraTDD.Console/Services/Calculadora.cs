using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraTDD.Console.Services
{
    public class Calculadora
    {
        private List<string> historico;
        private string data;
        public Calculadora(string data)
        {
            historico = new List<string>();
            this.data = data;
        }

        public double Somar(double n1, double n2)
        {
            var resultado = n1 + n2;

            historico.Insert(0, "Res: "+resultado+" - "+data);

            return resultado;
        }

        public double Subtrair(double n1, double n2)
        {
            var resultado = n1 - n2;

            historico.Insert(0, "Res: "+resultado+" - "+data);

            return resultado;
        }

        public double Multiplicar(double n1, double n2)
        {
            var resultado = n1 * n2;

            historico.Insert(0, "Res: "+resultado+" - "+data);

            return resultado;
        }

        public double Dividir(double n1, double n2)
        {
            var resultado = n1 / n2;

            historico.Insert(0, "Res: "+resultado+" - "+data);

            return resultado;
        }

        public List<string> Historico()
        {
            historico.RemoveRange(3, historico.Count - 3);
            return historico;
        }
    }
}