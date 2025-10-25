using System.Text.Json;

List<PasswortRegistry> passwords = new List<PasswortRegistry>();
string filePathJson = "passwoerter.json";

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
        CreatePassword();
    }
    else if (userChoice == 2)
    {
        UpdatePassword();
    }
    else if (userChoice == 3)
    {
        DeletePassword();
    }
    else if (userChoice == 4)
    {
        SearchPassword();
    }
    else if (userChoice == 5)
    {
        ExitProgramm();
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

void CreatePassword()
{
    Console.WriteLine("Sie haben die Aktion 'Passwort erstellen' ausgewählt");
    Console.WriteLine("Geben sie den Namen ein, unter dem Sie das Passwort nachher wieder finden:");
    string name = Console.ReadLine();
    Console.WriteLine("Geben sie den Benutzernamen ein:");
    string userName = Console.ReadLine();
    Console.WriteLine("Geben sie das Passwort ein:");
    string password = Console.ReadLine();

    passwords.Add(new PasswortRegistry(name, userName, password));
    SavePasswordsInJson(passwords);
}

void UpdatePassword()
{
    Console.WriteLine("Sie haben die Aktion 'Passwort verändern' ausgewählt");
}

void SearchPassword()
{
    Console.WriteLine("Sie haben die Aktion 'Passwort suchen' ausgewählt");
    passwords = LoadPasswordsFromJson();
    foreach (var password in passwords)
    {
        Console.WriteLine(password);
    }
}

void DeletePassword()
{
    Console.WriteLine("Sie haben die Aktion 'Passwort löschen' ausgewählt");
}

void ExitProgramm()
{
    Console.WriteLine("Sie haben die Aktion 'Programm beenden' ausgewählt");
    Environment.Exit(0);
}

void SavePasswordsInJson(List<PasswortRegistry> listWithPasswords)
{
    string jsonString = JsonSerializer.Serialize<List<PasswortRegistry>>(listWithPasswords);
    File.WriteAllText(filePathJson, jsonString);
}

List<PasswortRegistry> LoadPasswordsFromJson()
{
    string jsonString = File.ReadAllText(filePathJson);
    List<PasswortRegistry> passwordsFromJson = JsonSerializer.Deserialize<List<PasswortRegistry>>(jsonString);
    return passwordsFromJson;
}


/*
 * Hausaufgabe:
 * Ändern Sie das Programm so ab, dass
 * 1) sie die Einträge in der JSON ließt und zählt. Am Ende soll eine Konsolenausgabe die Anzahl der Passwörter geben.
*/