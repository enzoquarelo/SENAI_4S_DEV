using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email
{
    public class Email
    {
        public static string ValidateEmail(string email)
        {
            if (email is not null)
            {
                bool isValid = email.Contains("@") && email.Contains(".");

                if (isValid)
                {
                    return email;
                }
            }

            return "Não Válido";
        }
    }
}
