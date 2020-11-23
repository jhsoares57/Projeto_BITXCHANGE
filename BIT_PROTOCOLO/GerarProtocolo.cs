using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT_PROTOCOLO
{
    public class GerarProtocolo
    {
        public string Protocolo()
        {
            Random random = new Random();

            int valor = random.Next(100000000);

            string value = Convert.ToInt32(valor).ToString();
            string newValue = value.PadLeft(15, '0');

            return newValue;
        }

        public string Boleto()
        {
            Random random = new Random();

            int valor = random.Next(1000000000);
            int valor1 = random.Next(1000000000);
            int valor2 = random.Next(1000000000);
            int valor3 = random.Next(1000000000);
            int valor4 = random.Next(10000000);

            string value = Convert.ToInt32(valor).ToString();
            string value1 = Convert.ToInt32(valor1).ToString();
            string value2 = Convert.ToInt32(valor2).ToString();
            string value3 = Convert.ToInt32(valor3).ToString();
            string value4 = Convert.ToInt32(valor4).ToString();

            string newValue = value + value1 + value2 + value3 + value4;

            return newValue;
        }
    }
}
