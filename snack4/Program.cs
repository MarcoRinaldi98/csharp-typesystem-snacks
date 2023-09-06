// SNACK 4
// Calcola la somma e la media dei numeri da 2 a 10.
int[] numeri = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int somma = 0;

for (int i = 0; i < numeri.Length; i++)
{
    somma += numeri[i];
}

float media = somma / numeri.Length;


Console.WriteLine($"La somma dei numeri da 2 a 10 è {somma}");
Console.WriteLine($"La media dei numeri da 2 a 10 è {media}");


