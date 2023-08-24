using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionTask.AllExceptions
{
    public class NotAnEmailAddressException:Exception
    {
        public NotAnEmailAddressException(string message):base(message)
        {

        }
    }
}
