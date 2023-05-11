using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Calculadora_Simples.Equacoes
{
    class Resto
    {
        public double Resultado { get; private set; }

        public void _resto(params double[] valor)
        {
            double resto = valor[0];
            for (int i = 1; i < valor.Length; i++)
            {

                resto %= valor[i];

            }
            Resultado = resto;
        }

        public override string ToString()
        {

            return $"Resultado Resto: {Resultado.ToString("f2", CultureInfo.InvariantCulture)}";

        }
    }
}
