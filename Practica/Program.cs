using ClaseParcial;

Console.WriteLine("Hello, World!");

Rectangulo rectangulo = new Rectangulo()
{
    ancho = 5,
    alto = 10
};

Console.WriteLine(rectangulo.RetornarSuperficie());

Console.WriteLine(rectangulo.RetornarPerimetro());