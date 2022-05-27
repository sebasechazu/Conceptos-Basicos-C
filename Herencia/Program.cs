List<Figura> figuras = new List<Figura>();

Circulo circulo = new Circulo();

Rectangulo rectangulo = new Rectangulo();

Triangulo triangulo = new Triangulo();

figuras.Add(circulo);
figuras.Add(rectangulo);
figuras.Add(triangulo);

foreach (Figura figura in figuras)
{
    figura.Dibujar();
}