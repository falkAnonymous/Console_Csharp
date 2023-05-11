using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Simples.Equacoes
{
    class Soma
    {
        public double Resultado { get; private set; }

        public void _soma(params double[] valor)
        {
            double soma = 0.0;

            for (int i = 0; i < valor.Length; i++)
            {
                soma += valor[i];
            }
            Resultado = soma;
            //return Resultado;

        }

        public override string ToString()
        {

            return $"Resultado Soma: {Resultado.ToString("f2", CultureInfo.InvariantCulture)}";

        }
    }
}
