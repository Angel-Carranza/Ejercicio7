using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL19037Ejercicio7Guia7
{
    class ConjeUlam
    {
        int numero;

        public int Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        public int CalculoUlamPar()
        {
            int Calculo = 0;

            Calculo = numero / 2;

            return Calculo;
        }
        public int NumeroImpar()
        {
            int num;

            num = (numero * 3) + 1;

            return num;
        }
        public int CalculoUlamImpar()
        {
            int Calculo = 0;

            Calculo = ((numero * 3) + 1) / 2;

            return Calculo;
        }

    }
}
