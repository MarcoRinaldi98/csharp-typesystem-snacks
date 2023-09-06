// SNACK 2
// L’utente inserisce due parole in successione. Il software stampa prima la parola più corta, poi la parola più lunga.
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
