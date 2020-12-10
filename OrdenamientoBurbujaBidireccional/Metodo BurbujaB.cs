using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenamientoBurbujaBidireccional
{
    class Metodo_BurbujaB
    {
        
        public void BurbujaB(int[] vector)
        {
            int der = 0;
            int izq = 0;
            int aux = 0;

            der = vector.Length - 1;

            do
            {
                for (int i = izq; i < der; i++)
                {
                    if (vector[i] > vector[i + 1])
                    {
                        aux = vector[i];
                        vector[i] = vector[i + 1];
                        vector[i + 1] = aux;
                    }
                }

                for (int j = der; j > izq; j--)
                {
                    aux = vector[j];
                    vector[j] = vector[j - 1];
                    vector[j - 1] = aux;
                }

                izq++;
                der--;
            } while (izq < der);
        }

    }
}
