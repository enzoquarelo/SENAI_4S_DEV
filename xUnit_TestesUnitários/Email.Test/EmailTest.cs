using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email.Test
{
    public class EmailTest
    {
        [Fact]
        public void TestValidateEmail()
        {
            var email = "enzo.quarelo@gmail.com";

            var result = Email.ValidateEmail(email);

            Assert.Equal(email, result);

        }

        [Fact]
        public void TestInvalidateEmail()
        {
            var email = "slasla";
            var result = Email.ValidateEmail(email);
            Assert.Equal("Não Válido", result);
        }
    }
}
