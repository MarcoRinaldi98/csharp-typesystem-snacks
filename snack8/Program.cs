// SNACK 8
// Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.

int[] numeriInteri = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
int somma = 0;

for (int i = 1; i < numeriInteri.Length; i += 2)
{
        somma += numeriInteri[i];
}

Console.WriteLine($"La somma di tutti gli elementi che sono in posizione dispari è: {somma}");