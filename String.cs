using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renato_EstagioTargetSistemas
{
    internal class String
    {
        public void STRING(string text)
        {
            int k = 0;
            int i = 0;

            k = text.Length;
            while (k > 0) {
                i++;
                Console.Write(text[text.Length - i]);
                k--;
            }

        }

    }
}
