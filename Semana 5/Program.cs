
string name, minus, mayus;
int num4, facn, numn;
double radio,area, perimetro,an, al, x1, x2, y1, y2;

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

//Aquí realizo los calculos para determinar el promedio de n numeros en una lista de n numeros.
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



//Aquí realizo la conversión de una cadena de letras en minusculas a mayusculas.
Console.WriteLine("Por favor inserte a continuación la cadena de letras que desea convertir en Mayusculas: ");
    minus = Console.ReadLine();
static string Mayus(string cad)
{
    return cad.ToUpper();
}
mayus = Mayus(minus);
Console.WriteLine($"El resultado de la conversión de la cadena a Mayusculas es: {mayus}");



//Aquí realizo los calculos para determinar la distancia entre dos puntos de un plano cartesiano.
Console.WriteLine("Por favor inserta a continuación inserte la distancia entre dos puntos de un plano cartesiano, recibiendo como parámetros las cordenadas X y Y de ambos puntos:");
    Console.WriteLine("Inserta continuación el primer valor de X: ");
        x1=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Inserta continuación el segundo valor de X: ");
        x2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Inserta continuación el primer valor de Y: ");
        y1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Inserta continuación el segundo valor de Y: ");
        y2 = Convert.ToDouble(Console.ReadLine());

static double Dist(double x1, double y1, double x2, double y2)
{
    double dist= Math.Sqrt(Math.Pow(x2-x1,1)+Math.Pow(y2-y1,2));
    return dist;
}
Console.WriteLine($"La distancia entre los dos puntos del plano cartesiando es: \n{Dist}");

//Aquí realizo la suma de un n numero natural
Console.WriteLine("Por favor inserta a continuación el n numero natural que deseas sumar:");
numn = Convert.ToInt32(Console.ReadLine());

static int suman(int n)
{
    int suma = (n * (n + 1) / 2);
    return suma;
}
Console.WriteLine($"El resultado de la suma de {numn} es: \n{suman}");



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