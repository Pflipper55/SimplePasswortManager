# C# Cheat-Sheet Tag 4


## Listen durchsuchen und bearbeiten
### Suchen mit `FindIndex`
Mit `FindIndex` kann man das erste Element finden, das eine Bedingung erfüllt:
```csharp
int index = passwords.FindIndex(password => password.name == searchTerm);
```

### Elemente löschen mit `RemoveAt`
```csharp
passwords.RemoveAt(index); // Löscht das Element an der Stelle 'index'
```

## Case-insensitive Suche mit `ToLower()`
Um unabhängig von Groß- und Kleinschreibung zu suchen:
```csharp
if (password.name.ToLower().Contains(suchbegriff.ToLower()))
```

## Programm beenden mit `Environment.Exit()`
```csharp
Environment.Exit(0); // Beendet das Programm sofort
```

## Serialisierung und Deserialisierung von Listen
Mit System.Text.Json kann man Listen von Records speichern und laden:
```csharp
// Speichern
string jsonString = JsonSerializer.Serialize<List<PasswortRegistry>>(passwords);
File.WriteAllText("passwoerter.json", jsonString);

// Laden
string jsonString = File.ReadAllText("passwoerter.json");
List<PasswortRegistry> passwords = JsonSerializer.Deserialize<List<PasswortRegistry>>(jsonString);
```

## Zusammenfassung
- Listen können durchsucht, bearbeitet und gespeichert werden
- Case-insensitive Suche mit ToLower
- Programm sauber beenden mit Environment.Exit
- Serialisierung und Deserialisierung von Listen mit System.Text.Json
