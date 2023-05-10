// See https://aka.ms/new-console-template for more information
Console.WriteLine("Este programa es un juego que consiste adivinar un número del 1 al 15.");
int numerocorrecto = new Random().Next(1, 15); // Genera un número aleatorio entre 1 y 15
int intentosrestantes = 3;
    Console.Write("Vas a tener 3 intentos,¡TEN CUIDADO!.");
while (intentosrestantes > 0)
{
    Console.Write("Por favor introduce un número del 1 al 15:");
    int respuesta = Convert.ToInt32(Console.ReadLine());

    if (respuesta == numerocorrecto)
    {
        Console.WriteLine("Bien hecho, lo lograste.");
        break;
    }
    else if (respuesta < numerocorrecto)
    {
        Console.WriteLine("Vaya ese no es, el que buscas es mayor.");
    }
    else
    {
        Console.WriteLine("Vaya ese no es, el que buscas es menor.");
    }

    intentosrestantes--;
    if (intentosrestantes > 0)
    {
        Console.WriteLine("Cuidao te quedan {intentosrestantes} intentos.");
    }
    else
    {
        Console.WriteLine("¡Has perdido! La respuesta correcta es " + numerocorrecto);
    }
}