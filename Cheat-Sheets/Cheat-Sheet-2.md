# C# Grundlagen Cheat-Sheet

## Listen (List<T>)
Eine Liste ist wie ein Container, in dem wir mehrere Elemente des gleichen Typs speichern können.
```csharp
// Eine neue, leere Liste erstellen
List<string> namen = new List<string>();

// Elemente zur Liste hinzufügen
namen.Add("Max");
namen.Add("Anna");

// Auf Elemente zugreifen (beginnt bei 0!)
string ersterName = namen[0];  // Ergibt "Max"
```

### Wichtige List-Operationen
- `Add()` - Fügt ein Element hinzu
- `Remove()` - Entfernt ein Element
- `Count` - Gibt die Anzahl der Elemente zurück
- `Clear()` - Entfernt alle Elemente

## Records
Records sind eine einfache Möglichkeit, Datencontainer zu erstellen. Sie werden oft verwendet, um zusammengehörige Daten zu gruppieren.
```csharp
// Definition eines Records
public record Person(string Name, int Alter);

// Verwendung
Person max = new Person("Max", 25);
string name = max.Name;  // Zugriff auf die Daten
```

### Besonderheiten von Records
- Automatische Erstellung von Get-Eigenschaften
- Unveränderlich (immutable) - Werte können nach der Erstellung nicht geändert werden
- Automatischer Vergleich von Werten

## Methoden (Functions)
Methoden sind wiederverwendbare Codeblöcke, die einen Namen haben und aufgerufen werden können.

```csharp
// Methode ohne Rückgabewert (void)
void Begrüßung()
{
    Console.WriteLine("Hallo!");
}

// Methode mit Rückgabewert
int Addiere(int zahl1, int zahl2)
{
    return zahl1 + zahl2;  // gibt das Ergebnis zurück
}
```

### Aufbau einer Methode
1. Rückgabetyp (`void`, `int`, `string`, etc.)
2. Name (wie eine Variable, aber mit Klammern)
3. Parameter in Klammern (optional)
4. Code in geschweiften Klammern

## While-Schleifen
Eine while-Schleife wiederholt Code, solange eine Bedingung wahr (true) ist.

```csharp
int zähler = 0;
while (zähler < 5)
{
    Console.WriteLine(zähler);
    zähler = zähler + 1;
}
```

### Wichtig bei Schleifen
- Die Bedingung wird VOR jeder Ausführung geprüft
- Der Code in den geschweiften Klammern wird wiederholt ausgeführt
- Achte darauf, dass die Schleife irgendwann endet!

## Return Statement
`return` beendet eine Methode und gibt optional einen Wert zurück.

```csharp
int Verdopple(int zahl)
{
    return zahl * 2;  // Beendet die Methode und gibt das Ergebnis zurück
}

void Beenden()
{
    return;  // Beendet die Methode ohne Rückgabewert
}
```

### Wichtige Regeln
- Der Rückgabewert muss zum Typ der Methode passen
- Nach `return` wird kein weiterer Code in der Methode ausgeführt
- Jeder mögliche Pfad in einer Methode mit Rückgabetyp muss ein `return` haben
