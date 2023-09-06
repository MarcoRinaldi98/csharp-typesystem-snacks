// SNACK 7
// Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.
int[] numeriDispari = new int[6];
int index = 0;

for (int i = 0; i < 6; i++)
{
    Console.Write("Inserisci un numero: ");
    int numeroCorrente = int.Parse(Console.ReadLine());
    if (numeroCorrente %2 != 0 )
    {
        numeriDispari[index] = numeroCorrente;   
        index++;
    }
}

Console.WriteLine("I numeri dispari inseriti sono:");
for (int i = 0; i < index; i++)
{
    Console.WriteLine(numeriDispari[i]);
}
