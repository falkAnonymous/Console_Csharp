using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Calculadora_Simples.Equacoes
{
    class Subtracao
    {
        public double Resultado { get; private set; }

        public void _subtracao(params double[] valores)
        {
            double subtrair = valores[0];
            for (int i = 1; i < valores.Length; i++)
            {
                subtrair -= valores[i];
            }
            Resultado = subtrair;
            //return Resultado;
        }

        public override string ToString()
        {
            return $"Resultado Subtração: {Resultado.ToString("f2", CultureInfo.InvariantCulture)}";

        }
    }
}
