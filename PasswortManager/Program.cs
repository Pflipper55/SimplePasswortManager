List<PasswortRegistry> passwords = new List<PasswortRegistry>();

// See https://aka.ms/new-console-template for more information
Console.WriteLine($"Dies ist ein einfacher Passwort-Manager");
Console.WriteLine("Wie heißt du?");
string benutzerName = Console.ReadLine();
Console.WriteLine($"Willkommen, {benutzerName}!");

int userChoice = GetUserMenuInput();

while (userChoice != 5)
{
    if (userChoice == 1)
    {
        Console.WriteLine("Sie haben die Aktion 'Passwort erstellen' ausgewählt");
        Console.WriteLine("Geben sie den Namen ein, unter dem Sie das Passwort nachher wieder finden:");
        string name = Console.ReadLine();
        Console.WriteLine("Geben sie den Benutzernamen ein:");
        string userName = Console.ReadLine();
        Console.WriteLine("Geben sie das Passwort ein:");
        string password = Console.ReadLine();

        passwords.Add(new PasswortRegistry(name, userName, password));
    }
    else if (userChoice == 2)
    {
        Console.WriteLine("Sie haben die Aktion 'Passwort verändern' ausgewählt");
    }
    else if (userChoice == 3)
    {
        Console.WriteLine("Sie haben die Aktion 'Passwort löschen' ausgewählt");
    }
    else if (userChoice == 4)
    {
        Console.WriteLine("Sie haben die Aktion 'Passwort suchen' ausgewählt");
    }
    else if (userChoice == 5)
    {
        Console.WriteLine("Sie haben die Aktion 'Programm beenden' ausgewählt");
    }
    else
    {
        Console.WriteLine("Das war eine ungültige Auswahl!");
    }

    userChoice = GetUserMenuInput();
}

// (einfacher) Aufbau eines Methodenkopfes: Typ des Rückgabewert (z.B string oder int), Methodenname, evtl. Parameter
int GetUserMenuInput()
{
    Console.WriteLine("Welche Aktion willst du durchführen, bitte gebe die entsprechende Zahl ein um fortzufahren");
    Console.WriteLine("1 - Passwort erstellen");
    Console.WriteLine("2 - Passwort verändern");
    Console.WriteLine("3 - Passwort löschen");
    Console.WriteLine("4 - Passwort suchen");
    Console.WriteLine("5 - Programm beenden");
    string userInput = Console.ReadLine();
    userChoice = int.Parse(userInput);
    return userChoice;
}

/*
 * Hausaufgabe:
 * Ändern Sie das Programm so ab, dass
 * 1) Lagern sie die Anweisungen für das Erstellen eines Passwortes in eine eigene Methode um. 
 *    Name: Passwort erstellen. Die Methode soll dabei nichts zurückliefern (Rückgabewert void , kein return statement)
 * 2) Erstellen sie für die anderen Aktionen auch Methoden. Hierbei soll erstmall nur ein Methodenkopf definiert werden. Rufen sie die Methode an der richtigen Stelle auf.
*/