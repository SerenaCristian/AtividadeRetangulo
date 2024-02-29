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
            string sep = new string('.', 50);


            Console.WriteLine("Sistema Calcular Retangulo");
            Console.WriteLine(sep);

            Console.Write("Digite a Altura do Retangulo: ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Digite a Largura do Retangulo: ");
            largura = double.Parse(Console.ReadLine());

            Console.WriteLine(sep);

            area = CalcularArea(altura, largura);

            perimetro = CalculaPerimetro(altura, largura);

            diagonal = CalcularDiagonal(altura, largura);

            Console.WriteLine($"\nO Valor da área do Retangulo é de: {area.ToString("F2")}");
            Console.WriteLine($"\nO Valor do perimetro do Retangulo é de: {perimetro.ToString("F2")}");
            Console.WriteLine($"\nO Valor da diagonal do Retangulo é de: {diagonal.ToString("F2")}");

            Console.WriteLine(sep);
        }

        public static double CalculaPerimetro(double altura, double largura)
        {
            double perimetro = 2 * (altura + largura);
            return perimetro;

        }

        public static double CalcularArea(double altura, double largura)
        {
            double area = altura * largura;
            return area;
        }
        public static double CalcularDiagonal(double altura, double largura)
        {
            double diagonal = Math.Sqrt(Math.Pow(altura, 2) + (Math.Pow(largura, 2)));
            return diagonal;
        }
    }
}
    

