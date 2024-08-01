using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos.Test
{
    public class CalculoUnitTest
    {
        [Fact] 
        public void TestarOMetodoSomar() 
        {
            var n1 = 4.1; 
            var n2 = 5.9;
            var valorEsperado = 10;

            var soma = Calculo.Somar(n1, n2);

            Assert.Equal(valorEsperado, soma);
        }

        [Fact]
        public void TestarOMetodoSubtrair()
        {
            var n1 = 5.8;
            var n2 = 4.3;
            var valorEsperado = 1.5;

            var subtração = Calculo.Subtrair(n1, n2);

            Assert.Equal(valorEsperado, subtração);
        }

        [Fact]
        public void TestarOMetodoMultiplicar()
        {
            var n1 = 2;
            var n2 = 2;
            var valorEsperado = 4;

            var multiplicação = Calculo.Multiplicar(n1, n2);

            Assert.Equal(valorEsperado, multiplicação);
        }

        [Fact]
        public void TestarOMetodoDividir()
        {
            var n1 = 5;
            var n2 = 5;
            var valorEsperado = 1;

            var divisão = Calculo.Dividir(n1, n2);

            Assert.Equal(valorEsperado, divisão);
        }
    }
}
