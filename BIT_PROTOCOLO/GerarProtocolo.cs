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
    }
}
