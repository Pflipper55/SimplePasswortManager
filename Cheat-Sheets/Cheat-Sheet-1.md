# C# Grundlagen Cheat-Sheet

## Console.WriteLine
`Console.WriteLine` ist ein Befehl, der Text auf dem Bildschirm ausgibt. Der Text erscheint in einer neuen Zeile.
```csharp
Console.WriteLine("Hallo Welt!");  // Gibt "Hallo Welt!" aus
```

### Besonderheit mit $
Mit einem `$` vor dem Text können wir Variablen direkt im Text verwenden:
```csharp
string name = "Max";
Console.WriteLine($"Hallo {name}!");  // Gibt "Hallo Max!" aus
```

## Strings (Texte)
Ein String ist eine Textvariable. Strings werden in Anführungszeichen geschrieben.
```csharp
string meinText = "Dies ist ein Text";
```

## Console.ReadLine
`Console.ReadLine` liest eine Eingabe von der Tastatur ein. Das Programm wartet, bis der Benutzer ENTER drückt.
```csharp
string eingabe = Console.ReadLine();  // Wartet auf Benutzereingabe
```

## int (Ganzzahlen)
`int` speichert ganze Zahlen (keine Kommazahlen).
```csharp
int zahl = 42;
```

## int.Parse
`int.Parse` wandelt einen Text (String) in eine Zahl (int) um.
```csharp
string eingabe = "123";
int zahl = int.Parse(eingabe);  // wandelt "123" in die Zahl 123 um
```

## if/else if/else (Bedingungen)
Mit `if`, `else if` und `else` können wir verschiedene Aktionen ausführen, je nachdem welche Bedingung erfüllt ist.

```csharp
int zahl = 5;

if (zahl == 1)
{
    // wird ausgeführt, wenn zahl gleich 1 ist
    Console.WriteLine("Die Zahl ist 1");
}
else if (zahl == 2)
{
    // wird ausgeführt, wenn zahl gleich 2 ist
    Console.WriteLine("Die Zahl ist 2");
}
else
{
    // wird ausgeführt, wenn keine der obigen Bedingungen zutrifft
    Console.WriteLine("Die Zahl ist weder 1 noch 2");
}
```

### Vergleichsoperatoren
- `==` ist gleich
- `!=` ist nicht gleich
- `<` ist kleiner als
- `>` ist größer als
- `<=` ist kleiner oder gleich
- `>=` ist größer oder gleich