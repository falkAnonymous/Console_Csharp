using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Simples.Equacoes
{
    class Divisao
    {
        public double Resultado { get; private set; }

        public void _divisao(params double[] valor)
        {
            double dividir = valor[0];
            for (int i = 1; i < valor.Length; i++)
            {
                dividir /= valor[i];
            }
            Resultado = dividir;
        }

        public override string ToString()
        {

            return $"Resultado Divisão: {Resultado.ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
