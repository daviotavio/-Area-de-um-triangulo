using System;

namespace área_de_um_triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            float area,base1,altura;

            Console.Write("A área de um triângulo é calculada utitlizando a fórmula: (área=base x altura)/2, portanto, determine a base: ");
            base1 = float.Parse(Console.ReadLine());

            Console.Write("Agora, determine a altura: ");
            altura = float.Parse(Console.ReadLine());

            area = (base1 * altura)/2;

            Console.Write("A área do seu triângulo é: " + area);
        }
    }
}
