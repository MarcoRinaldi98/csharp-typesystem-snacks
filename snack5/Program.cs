// SNACK 5
// Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.
Console.WriteLine("Inserisci un numero:");
int numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine(numero);
} else
{
    Console.WriteLine(numero + 1);
}
