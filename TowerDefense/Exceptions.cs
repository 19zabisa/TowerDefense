using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense
{
    class Exceptions : System.Exception
    {
        public Exceptions()
        {

        }

        public Exceptions(string message) : base(message)
        {

        }
    }

    class OutOfBoundsException : Exceptions
    {
        public OutOfBoundsException()
        {

        }

        public OutOfBoundsException(string message) : base(message)
        {

        }
    }
}
