// dichiaro una variabile di tipo intero
int num;
// chiedo all'utente di inserire un numero intero
Console.WriteLine("Inserisci un numero intero:");
int.TryParse(Console.ReadLine(), out num);

// ciclo for per moltiplicare il numero inserito per i numeri da 1 a 10
for (byte i = 1; i <= 10; i++)
{
    // calcolo il risultato della moltiplicazione
    int result = num * i;
    // stampo il risultato
    Console.WriteLine($"{num} x {i} = {result}");
}
