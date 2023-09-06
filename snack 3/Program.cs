// SNACK 3
// Il software deve chiedere per 10 volte all’utente di inserire un numero. Il programma stampa la somma di tutti i numeri inseriti.
int somma = 0;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Inserisci un numero:");
    somma += int.Parse(Console.ReadLine());
}

Console.WriteLine($"La somma di tutti i numeri inseriti è: {somma}");