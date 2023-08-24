using ExceptionTask.AllExceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionTask.Validations
{
    public class EmailValidator
    {
        public bool Validate(string email)
        {
            if (email.Length<10)
            {
                throw new ShortEmailException("Email lenght must be at least 10 char");
            }
            if (!email.EndsWith("@mail.com"))
            {
                throw new NotAnEmailAddressException("Mail address is not true");

            }
            return true;

        }
    }
}
