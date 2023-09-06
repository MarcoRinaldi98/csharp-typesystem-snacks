// SNACK 10
// Fai inserire un numero, che chiameremo N, all’utente. Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100. Ogni volta che ne crei uno, stampalo a schermo.

Console.WriteLine("Inserisci un numero: ");
int N = int.Parse(Console.ReadLine());

if (N > 0)
{
    Random random = new Random();

    for (int i = 0; i < N; i++)
    {
        int[] array = new int[10];

        for (int x = 0; x < 10; x++)
        {
            array[x] = random.Next(1, 101);
        }

        Console.WriteLine($"Array {i + 1}: [{string.Join(", ", array)}]");
    }
}