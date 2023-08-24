using ExceptionTask.AllExceptions;
using ExceptionTask.Validations;
using System;

namespace ExceptionTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmailValidator validator=new EmailValidator();
            try
            {
                Console.WriteLine(validator.Validate("sasa@mail.ru"));
            }
            catch (ShortEmailException ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch (NotAnEmailAddressException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}
