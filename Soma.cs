using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Renato_EstagioTargetSistemas
{
    internal class Soma
    {
        public int SOMA() {
            int indice = 13;
            int soma = 0;
            int k = 0;

            while (k < indice) {
                k++;
                soma += k;
            }

            return soma;
        }
    }
}
