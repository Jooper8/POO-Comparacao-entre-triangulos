//Frederico Guilherme Camilli Proença RA:200925

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis, sendo elas as variáveis x e y da classe triângulo.
            Triangle x, y;

            //Instanciação das variáveis.
            x = new Triangle();
            y = new Triangle();

            //Pedido da inserção das medidas do triângulo X, justo à sua inserção.
            Console.WriteLine("Insira as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Cálculo da área do triângulo X.
            double px = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(px * (px - x.A) * (px - x.B) * (px - x.C));

            //Impressão do resultado da área do triângulo X.
            Console.WriteLine("A área de X é: " + areaX.ToString("F4", CultureInfo.InvariantCulture));

            //Pedido da inserção das medidas do triângulo Y, justo à sua inserção.
            Console.WriteLine("Agora insira as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Cálculo da área do triângulo Y.
            double py = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(py * (py - y.A) * (py - y.B) * (py - y.C));

            //Impressão do resultado da área do triângulo Y.
            Console.WriteLine("A área de Y é: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            //Comparação e dados a serem informados ao usuário.
            if (areaX > areaY)
                Console.WriteLine("A área do triângulo X ({0}) é maior que a área do triângulo Y ({1}).", areaX.ToString("F4", CultureInfo.InvariantCulture), areaY.ToString("F4", CultureInfo.InvariantCulture));
            else if (areaX < areaY)
                Console.WriteLine("A área do triângulo Y ({0}) é maior que a área do triângulo X ({1}).", areaY.ToString("F4", CultureInfo.InvariantCulture), areaX.ToString("F4", CultureInfo.InvariantCulture));
            else
                Console.WriteLine("As áreas de ambos os triângulos são iguais.");


        }
    }
}
