// SNACK 3
int somma = 0;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Inserisci un numero:");
    somma += int.Parse(Console.ReadLine());
}

Console.WriteLine($"La somma di tutti i numeri inseriti è: {somma}");