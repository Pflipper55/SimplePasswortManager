# C# Cheat-Sheet Tag 5

## Zufallszahlen mit `Random`
Um zufällige Werte zu erzeugen, verwendet man die Klasse `Random`:
```csharp
Random zufall = new Random();
int zahl = zufall.Next(0, 10); // Gibt eine Zufallszahl zwischen 0 und 9 zurück
```

## Passwort-Generierung
Mit einer eigenen Methode kann man ein Passwort nach bestimmten Regeln generieren:
- Auswahl von Zeichen (Buchstaben, Zahlen, Sonderzeichen)
- Abfrage der gewünschten Länge
- Zusammensetzen des Passworts aus zufälligen Zeichen

### Beispiel für Passwort-Generierung
```csharp
string letters = "abcdefghiklmnopqrstuvwxyz";
if (großbuchstaben) letters += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
if (sonderzeichen) letters += "!'§$%&/()=?-.,_#*<>;";
if (zahlen) letters += "1234567890";

string password = "";
for (int i = 0; i < länge; i++)
{
    int random = new Random().Next(0, letters.Length);
    password += letters[random];
}
```

## Benutzerabfragen für Optionen
Das Programm fragt den Benutzer, ob bestimmte Zeichenarten im Passwort enthalten sein sollen:
```csharp
Console.WriteLine("Sollen Großbuchstaben inkludiert werden [j|n]?");
if (Console.ReadLine() == "j") { /* ... */ }
```

## Zusammenfassung
- Mit `Random` können Zufallszahlen und damit zufällige Zeichen erzeugt werden
- Passwort-Generierung kann flexibel gestaltet werden (Zeichenarten, Länge)
- Benutzerabfragen steuern die Optionen für das generierte Passwort
