
using EjercicioPolimorfismo;

//Figura triangulo = new Triangulo { Base = 5, Altura = 4 };
//Figura circulo = new Circulo { Radio = 3 };

//MostrarInformacion(triangulo);
//MostrarInformacion(circulo);


Triangulo triangulo = new Triangulo();

Console.WriteLine("Cáculo del área y perímetro de un triángulo");
//Console.WriteLine();
Console.WriteLine("Ingrese la Base");
triangulo.Base = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la Altura");
triangulo.Altura = double.Parse(Console.ReadLine());

Circulo circulo = new Circulo();
Console.WriteLine();
Console.WriteLine("Cáculo del área y perímetro de un Círulo");
Console.WriteLine("Ingrese la Base");
circulo.Radio = double.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("*****************************************");
Console.WriteLine("Resultado del cálculo del Triángulo");
MostrarInformacion(triangulo);
Console.WriteLine("*****************************************");


Console.WriteLine("Resultado del cálculo del Círculo");
MostrarInformacion(circulo);
Console.WriteLine("*****************************************");



static void MostrarInformacion(Figura figura)
{
    //Área y perímetro del triángulo
    Console.WriteLine("Area: " + figura.CalcularArea());

    //Área y perímetro del círculo;
    Console.WriteLine("Perimetro: " + figura.CalcularPerimetro());
    //Console.WriteLine();
}

