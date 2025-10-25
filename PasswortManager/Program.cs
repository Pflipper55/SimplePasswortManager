// See https://aka.ms/new-console-template for more information
Console.WriteLine($"Dies ist ein einfacher Passwort-Manager");
Console.WriteLine("Wie heißt du?");
string benutzerName = Console.ReadLine();
Console.WriteLine($"Willkommen, {benutzerName}!");

// 
Console.WriteLine("Welche Aktion willst du durchführen, bitte gebe die entsprechende Zahl ein um fortzufahren");
string userInput = Console.ReadLine();
int userChoice = int.Parse(userInput);

if (userChoice == 1)
{
    Console.WriteLine("Sie haben die 1 ausgewählt");
}
else if (userChoice == 2)
{
    Console.WriteLine("Sie haben die 2 ausgewählt");
}
else
{
    Console.WriteLine("Das war eine ungültige Auswahl!");
}

/*
 * Hausaufgabe:
 * Ändern Sie das Programm so ab, dass
 * 1) Das uns das Programm sagt, welche Zahlen für welche Aktionen stehen 
 *    Dabei soll es uns folgende Aktionen vorschlagen: 1 - Passwort erstellen, 2 - Passwort verändern, 3 - Passwort löschen, 4 - Passwort suchen, 5 - Programm beenden
 * 2) Das Programm uns sagt welche Aktion wir ausgewählt haben. D.h wenn der User die 1 auswählt, soll das Programm ausgeben: "Sie haben die Aktion 'Passwort erstellen' ausgewählt"
*/