using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BIT_EXCEPTION
{
    [Serializable]
    public class ExceptionErro : Exception
    {
        public ExceptionErro()
        {
        }

        public ExceptionErro(string message) : base(message)
        {
        }

        public ExceptionErro(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ExceptionErro(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
