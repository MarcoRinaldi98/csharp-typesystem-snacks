// SNACK 9
// Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.
int[] numeriUtente = new int[49];
int somma = 0;
int index  = 0;

for (int i = 0;i < 50; i++)
{
    Console.Write("Inserisci un numero: ");
    int numeroCorrente = int.Parse(Console.ReadLine());
    somma += numeroCorrente;

    if (somma < 50)
    {
        numeriUtente[index] = numeroCorrente;
        index++;
    } else
    {
        Console.WriteLine($"Non puoi piu inserire numeri perchè la somma è arrivata ad un totale di {somma}");
        break;
    }
}    

