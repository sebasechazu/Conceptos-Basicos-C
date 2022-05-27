namespace ClaseParcial
{
    partial class Rectangulo
    {
        public double RetornarSuperficie()
        {
            double superficie;

            superficie = (this.ancho * this.alto);

            return superficie;
        }

        public double RetornarPerimetro()
        {
            double perimetro;

            perimetro = (this.ancho * 2) + (this.alto * 2);

            return perimetro;
        }
    }
}