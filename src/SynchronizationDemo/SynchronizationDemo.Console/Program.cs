using System;
using SynchronizationDemo.Domain;

var semaforo = new SemaphoreExperiment();
bool termina = false;

while (!termina)
{
    Console.WriteLine();
    Console.WriteLine("=== DIMOSTRAZIONE DELLA SINCRONIZZAZIONE ===");
    Console.WriteLine("1. Semaforo");
    Console.WriteLine("0. Esci");
    Console.Write("Scelta: ");

    switch (Console.ReadLine()?.Trim())
    {
        case "1":
            semaforo.Run();
            break;

        case "0":
            termina = true;
            break;

        default:
            Console.WriteLine("Scelta non valida. Riprova.");
            break;
    }
}

Console.WriteLine("Programma terminato.");