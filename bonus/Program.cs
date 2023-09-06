// BONUS
// Creare un menù dove mostro gli snacks all'utente e chiedo quale vuole eseguire. Una volta la scelta il programma esegue il snack corrispondente.

Console.WriteLine("Inserisci un numero da 1 a 10 per decidere quale snack visualizzare:");
int snackScelto = int.Parse(Console.ReadLine());

// SNACK 1
if (snackScelto == 1)
{
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
    }
    else
    {
        Console.WriteLine("I due numeri sono uguali!");
    }
// SNACK 2
} else if (snackScelto == 2)
{
    Console.WriteLine("Inserisci la prima parola:");
    string parola1 = Console.ReadLine();
    Console.WriteLine("Inserisci la seconda parola:");
    string parola2 = Console.ReadLine();

    if (parola1.Length > parola2.Length)
    {
        Console.WriteLine($"La parola piu lunga è {parola1}");
    }
    else if (parola1.Length < parola2.Length)
    {
        Console.WriteLine($"La parola piu lunga è {parola2}");
    }
    else
    {
        Console.WriteLine("Le due parole sono lunghe uguali!");
    }
// SNACK 3
} else if(snackScelto == 3)
{
    int somma = 0;
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("Inserisci un numero:");
        somma += int.Parse(Console.ReadLine());
    }

    Console.WriteLine($"La somma di tutti i numeri inseriti è: {somma}");
// SNACK 4
} else if (snackScelto == 4)
{
    int[] numeri = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int somma = 0;

    for (int i = 0; i < numeri.Length; i++)
    {
        somma += numeri[i];
    }

    float media = somma / numeri.Length;


    Console.WriteLine($"La somma dei numeri da 2 a 10 è {somma}");
    Console.WriteLine($"La media dei numeri da 2 a 10 è {media}");
// SNACK 5
} else if (snackScelto == 5)
{
    Console.WriteLine("Inserisci un numero:");
    int numero = int.Parse(Console.ReadLine());

    if (numero % 2 == 0)
    {
        Console.WriteLine(numero);
    }
    else
    {
        Console.WriteLine(numero + 1);
    }
// SNACK 6
} else if (snackScelto == 6)
{
    string[] invitati = { "Marco Verdi", "Andrea Rossi", "Gianluca Bianchi", "Mattia Arancioni", "Franco Trenta" };

    Console.WriteLine("Inserisci il tuo Nome e il tuo Cognome:");
    string nomeCompleto = Console.ReadLine();

    bool accesso = false;

    for (int i = 0; i < invitati.Length; i++)
    {
        if (nomeCompleto.Equals(invitati[i]))
        {
            accesso = true;
            break;
        }
    }

    if (accesso)
    {
        Console.WriteLine("Puoi accedere alla festa del Grande Gatsby!");
    }
    else
    {
        Console.WriteLine("Mi dispiace, non sei stato invitato alla festa del Grande Gatsby, non puoi entrare!");
    }
// SNACK 7
} else if (snackScelto == 7)
{
    int[] numeriDispari = new int[6];
    int index = 0;

    for (int i = 0; i < 6; i++)
    {
        Console.Write("Inserisci un numero: ");
        int numeroCorrente = int.Parse(Console.ReadLine());
        if (numeroCorrente % 2 != 0)
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
// SNACK 8
} else if (snackScelto == 8)
{
    int[] numeriInteri = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
    int somma = 0;

    for (int i = 1; i < numeriInteri.Length; i += 2)
    {
        somma += numeriInteri[i];
    }

    Console.WriteLine($"La somma di tutti gli elementi che sono in posizione dispari è: {somma}");
// SNACK 9
} else if (snackScelto == 9)
{
    int[] numeriUtente = new int[49];
    int somma = 0;
    int index = 0;

    for (int i = 0; i < 50; i++)
    {
        Console.Write("Inserisci un numero: ");
        int numeroCorrente = int.Parse(Console.ReadLine());
        somma += numeroCorrente;

        if (somma < 50)
        {
            numeriUtente[index] = numeroCorrente;
            index++;
        }
        else
        {
            Console.WriteLine($"Non puoi piu inserire numeri perchè la somma è arrivata ad un totale di {somma}");
            break;
        }
    }
// SNACK 10
} else if (snackScelto == 10)
{
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
// In caso di numero non valido
} else
{
    Console.WriteLine("Numero inserito non valido!");
}

