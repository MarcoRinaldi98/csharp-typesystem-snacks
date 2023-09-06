// SNACK 1
Console.WriteLine("Inserisci il primo numero:");
int numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Inserisci il secondo numero:");
int numero2 = int.Parse(Console.ReadLine());

if (numero1 > numero2)
{
    Console.WriteLine($"Il numero piu grande inserito è {numero1}");
}
else if (numero1 < numero2)
{
    Console.WriteLine($"Il numero piu grande inserito è {numero2}");
} else
{
    Console.WriteLine("I due numeri soino uguali!");
}
