using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasico.Metodos
{
    public class GeradorNumeroAleatorio
    {
        public static string GeradorRange()
        {
            var random = new Random();
            var possibilidades = Enumerable.Range(0, 10).ToList();
            var resultado = possibilidades.OrderBy(number => random.Next()).Take(6).ToArray();
            var CupomValido = string.Join("", resultado);
            return CupomValido;
        }

        public static string GeradorConcat()
        {
            Random rnd = new();
            int n1 = rnd.Next(0, 10);
            int n2 = rnd.Next(10);
            int n3 = rnd.Next(0, 10);
            int n4 = rnd.Next(10);
            int n5 = rnd.Next(0, 10);
            int n6 = rnd.Next(10);
            var Cupom = string.Concat(n1, n2, n3, n4, n5, n6);

            return Cupom;
        }
    }
}
