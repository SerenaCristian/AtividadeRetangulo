using System;


namespace RetanguloSemClasse
{
    public class Retangulo
    {
        public double area;
        public double perimetro;
        public double altura;
        public double largura;
        public double diagonal;


        public double CalculaPerimetro(double altura, double largura)
        {
            double perimetro = 2 * (altura + largura);
            return perimetro;

        }

        public  double CalcularArea(double altura, double largura)
        {
            double area = altura * largura;
            return area;
        }
        public  double CalcularDiagonal(double altura, double largura)
        {
            double diagonal = Math.Sqrt(Math.Pow(altura, 2) + (Math.Pow(largura, 2)));
            return diagonal;
        }
    }
}
