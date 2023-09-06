// SNACK 6
// In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.
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
