using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Calculadora_Simples.Equacoes
{
    class Multiplicacao
    {
        public double Resultado { get; private set; }

        public void _multiplicar(params double[] valor)
        {
            double multiplicar = valor[0];
            for (int i = 1; i < valor.Length; i++)
            {

                multiplicar *= valor[i];

            }
            Resultado = multiplicar;
        }

        public override string ToString()
        {

            return $"Resultado Multiplicação: {Resultado.ToString("f2", CultureInfo.InvariantCulture)}";


        }
    }
}
