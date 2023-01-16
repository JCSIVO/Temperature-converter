// Conversor de temperatura 

Console.WriteLine("Bienvenido al conversor de temperatura");
Console.Write("Introduce el valor a convertir: ");
double grados = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Indica que tipo de grado has introducido: Celsius, Fahrenheit o Kelvin");
Console.WriteLine("1 - Grados Celsius");
Console.WriteLine("2 - Grados Fahrenheit");
Console.WriteLine("3 - Grados Kelvin");
Console.Write("Escoge una  de las tres opciones: ");
int valor = Convert.ToInt32(Console.ReadLine());

double resultadoC = 0;
double resultadoF = 0;
double resultadoK = 0;
double gradosK = 273.15;

switch (valor)
{
    case 1:
    Console.WriteLine("Has introducido grados Celsius");
    resultadoF = (grados * 9/5) + 32;
    resultadoK = (grados + gradosK);
    Console.WriteLine($"Los {grados} grados Celsius se han converitdo a {resultadoF} grados Fahrenheit");
    Console.WriteLine($"Los {grados} grados Celsius se han converitdo a {resultadoK} grados Kelvin");
    break;
    case 2:
    Console.WriteLine("Has introducido grados Fahrenheit");
    resultadoC = ((grados - 32) * 5/9);
    resultadoK = (((grados - 32) * 5/9) + gradosK);
    Console.WriteLine($"Los {grados} grados Fahrenheit se han converitdo a {resultadoC} grados Celsius");
    Console.WriteLine($"Los {grados} grados Fahrenheit se han converitdo a {resultadoK} grados Kelvin");
    break;
    case 3:
    Console.WriteLine("Has introducido grados Kelvin");
    resultadoC = (grados - gradosK);
    resultadoF = (((grados - gradosK)* 1.8)+ 32);
    Console.WriteLine($"Los {grados} grados Kelvin se han converitdo a {resultadoC} grados Celsius");
    Console.WriteLine($"Los {grados} grados Kelvin se han converitdo a {resultadoF} grados Fahreheit");
    break;
}