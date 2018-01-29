using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inworldz.Joke.Serialization
{
    public class SerializationException : Exception
    {
        public SerializationException()
            : base()
        {

        }

        public SerializationException(string message)
            : base(message)
        {
        }
    }
}
