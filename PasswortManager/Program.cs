using System.Text.Json;

List<PasswortRegistry> passwords = new List<PasswortRegistry>();
string filePathJson = "passwoerter.json";

// See https://aka.ms/new-console-template for more information
Console.WriteLine($"Dies ist ein einfacher Passwort-Manager");
Console.WriteLine("Wie heißt du?");
string benutzerName = Console.ReadLine();
Console.WriteLine($"Willkommen, {benutzerName}!");

int userChoice = GetUserMenuInput();

while (userChoice != 6)
{
    if (userChoice == 1)
    {
        CreatePassword();
    }
    else if (userChoice == 2)
    {
        Console.WriteLine("Welches Passwort wollen sie verändern?");
        UpdatePassword(Console.ReadLine());
    }
    else if (userChoice == 3)
    {
        DeletePassword();
    }
    else if (userChoice == 4)
    {
        Console.WriteLine("Welches Passwort suchen sie?");
        SearchPassword(Console.ReadLine());
    }
    else if(userChoice == 5)
    {
        string password = GeneratePassword();
        Console.WriteLine($"Generiertes Passwort: {password}");
    }
    else if (userChoice == 6)
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
    Console.WriteLine("5 - Passwort generieren");
    Console.WriteLine("6 - Programm beenden");
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

void UpdatePassword(string searchTerm)
{
    Console.WriteLine("Sie haben die Aktion 'Passwort verändern' ausgewählt");
    Console.WriteLine("Geben Sie das neue Passwort ein");
    string newPassword = Console.ReadLine();
    int index = passwords.FindIndex(password => password.name == searchTerm);
    passwords[index] = new PasswortRegistry(passwords[index].name, passwords[index].userName, newPassword);
    SavePasswordsInJson(passwords);
}

void SearchPassword(string searchTerm)
{
    Console.WriteLine("Sie haben die Aktion 'Passwort suchen' ausgewählt");
    passwords = LoadPasswordsFromJson();
    foreach (var password in passwords)
    {
        if (password.name.ToLower().Contains(searchTerm.ToLower()))
        {
            Console.WriteLine("=======================================");
            Console.WriteLine($"Name: {password.name}");
            Console.WriteLine($"Benutzername: {password.userName}");
            Console.WriteLine($"Name: {password.passwort}");
            Console.WriteLine("=======================================");
            return;
        }
    }
    Console.WriteLine("Passwort nicht gefunden :c");
    Console.WriteLine("Alle ausgeben [j|n] ?");
    string input = Console.ReadLine();
    if (input == "j")
    {
        foreach (var password in passwords)
        {
            Console.WriteLine("=======================================");
            Console.WriteLine($"Name: {password.name}");
            Console.WriteLine($"Benutzername: {password.userName}");
            Console.WriteLine($"Name: {password.passwort}");
            Console.WriteLine("======================================="); 
        }
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

string GeneratePassword()
{
    string letters = "abcdefghiklmnopqrstuvwxyz";
    string password = string.Empty;
    Console.WriteLine("Sollen Großbuchstaben inkludiert werden [j|n]?");
    if (Console.ReadLine() == "j")
    {
        letters += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    }

    Console.WriteLine("Sollen Sonderzeichen inkludiert werden");
    if (Console.ReadLine() == "j")
    {
        letters += "!'§$%&/()=?-.,_#*<>;";
    }

    Console.WriteLine("Sollen Zahlen inkludiert werden?");
    if (Console.ReadLine() == "j")
    {
        letters += "1234567890";
    }

    Console.WriteLine("Wie lang soll das Passwort werden?");
    int length = int.Parse(Console.ReadLine());

    for (int i = 0; i < length; i++)
    {
        int random = new Random().Next(0, letters.Length);
        password += letters[random];
    }
    return password;
}