using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Simples
{
    class ParamsCalculadora
    {
        public int Soma(params int[] n)
        {
            int soma = 0;

            for (int i = 0; i < n.Length; i++)
            {
                soma += n[i];
            }
            return soma;
        }
    }
}
