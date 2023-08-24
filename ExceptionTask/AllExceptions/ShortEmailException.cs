using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionTask.AllExceptions
{
    public class ShortEmailException:Exception
    {
        public ShortEmailException(string message):base(message)
        {

        }
    }
}
