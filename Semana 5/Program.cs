﻿
string name;
int num4,facn;
double radio,area, perimetro,an, al;

//Primero que nada se le solicita al usuario su nombre para así darle una pequeña bienvenida.
Console.WriteLine("Primero que nada, dime, ¿Como te llamas?");
    name = Console.ReadLine();
Console.WriteLine($"Bienvenid@ {name}, a continuación se te solicitarán ciertos por faor insertalos de manera correcta.");

//Calculo del radio de un circulo.
Console.WriteLine("\nPor favor inserta a continuación el radio del circulo que deseas calcular:");
    radio = Convert.ToDouble(Console.ReadLine());
static double AreaC(double radio)
{
    //Es un static double por que trabajare con datos double.
    double area = Math.PI * Math.Pow(radio, 2);
    return area;
}
//En este punto el Math.PI es para calcular el valor de π seguido de un Math.Pow el cual me devuelve un valor especifico
//Claramente elevado a una potencia en este caso sería radio^2

area = AreaC(radio);
Console.WriteLine($"El area del circulo es en total: \n{area}");

//Obtención del perimetro de un triangulo.
Console.WriteLine("Por favor inserta a continuación la altura y el ancho del perimetro que deseas calcular:");
Console.ReadLine();

static double Perimetros(double an, double al)
{
    double perimetro = 2 * (an + al);
    return perimetro;
}
Console.WriteLine("Inserta  el ancho del perimetro del triangulo que deseas calcular:");
    an = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Inserta la altura del perimetro del triangulo que deseas calcular:");
    al = Convert.ToDouble(Console.ReadLine());
    perimetro = Perimetros(an, al);
Console.WriteLine($"El perimetro total del triangulo es: \n{perimetro}");



Console.WriteLine("Por favor inserta a continuación la lista de numeros enteros de los cuales desesas obtener un promedio:");




//Determinación si un numero es par o impar.
Console.WriteLine("Por favor inserta a continuación el numero que quieres saber si es par o impar:");
num4=Convert.ToInt32(Console.ReadLine());

if ((num4 % 2) == 0)
{
    Console.WriteLine("El numero insertado es par.");
}
else
{
    Console.WriteLine("El numero insertado es impar.");
}


Console.WriteLine("Por favor inserta a continuación los numeros que deseas sumar:");

//Calculo del factorial de n numero.
Console.WriteLine("Por favor inserta a continuación el numero del cual quieres obtener el factorial:");
facn=Convert.ToInt32(Console.ReadLine());

static int Fact(int facn)
{ 
    int Fact = 1;
        for (int i = 0; i < facn; i++)
        {
            Fact *= i;
        }
        return Fact;
}
Console.WriteLine($"El factorial de {facn} es: {Fact}");
Console.ReadKey();