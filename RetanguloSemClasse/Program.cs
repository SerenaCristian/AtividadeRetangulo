using System;

namespace RetanguloSemClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            double area;
            double perimetro;
            double altura;
            double largura;
            double diagonal;

            Retangulo retangulo = new Retangulo();
            string sep = new string('.', 50);

            Console.WriteLine("Sistema Calcular Retangulo");
            Console.WriteLine(sep);

            Console.Write("Digite a Altura do Retangulo: ");
            altura = double.Parse(Console.ReadLine());
            retangulo.altura = altura;

            Console.Write("Digite a Largura do Retangulo: ");
            largura = double.Parse(Console.ReadLine());
            retangulo.largura = largura;

            Console.WriteLine(sep);

            area = retangulo.CalcularArea(retangulo.altura, retangulo.largura);
            perimetro = retangulo.CalculaPerimetro(retangulo.altura, retangulo.largura);
            diagonal = retangulo.CalcularDiagonal(retangulo.altura, retangulo.largura);

            

            Console.WriteLine(sep);

            Console.WriteLine($"\nO Valor da área do Retangulo é de: {area.ToString("F2")}");
            Console.WriteLine($"\nO Valor do perimetro do Retangulo é de: {perimetro.ToString("F2")}");
            Console.WriteLine($"\nO Valor da diagonal do Retangulo é de: {diagonal.ToString("F2")}");

            Console.WriteLine(sep);
        }
    }
}

