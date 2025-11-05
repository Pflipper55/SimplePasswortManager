# C# Dateiverarbeitung Cheat-Sheet

## JSON (JavaScript Object Notation)
JSON ist ein Format, um Daten zu speichern und auszutauschen. Es ist leicht zu lesen und zu schreiben.

```json
// Beispiel einer JSON-Datei (passwoerter.json)
[
    {
        "Name": "Google",
        "UserName": "max.mustermann",
        "Passwort": "123456"
    }
]
```

## System.Text.Json
Dies ist die .NET Bibliothek zum Arbeiten mit JSON-Dateien.

```csharp
// Benötigter Import
using System.Text.Json;

// JSON in ein C# Objekt umwandeln (Deserialisierung)
string jsonText = File.ReadAllText("datei.json");
List<MeinKlasse> liste = JsonSerializer.Deserialize<List<MeinKlasse>>(jsonText);

// C# Objekt in JSON umwandeln (Serialisierung)
string jsonString = JsonSerializer.Serialize(liste);
```

### Wichtige Konzepte bei JSON
- Eckige Klammern `[]` bedeuten eine Liste/Array
- Geschweifte Klammern `{}` bedeuten ein Objekt
- Daten sind immer "Name": Wert Paare
- Text steht in Anführungszeichen

## Dateien Lesen und Schreiben

### Datei Lesen
```csharp
// Ganzen Text aus Datei lesen
string inhalt = File.ReadAllText("datei.txt");

// Alle Zeilen als Array lesen
string[] zeilen = File.ReadAllLines("datei.txt");
```

### Datei Schreiben
```csharp
// Text in Datei schreiben (überschreibt existierende Datei)
File.WriteAllText("datei.txt", "Hallo Welt");

// Text an Datei anhängen
File.AppendAllText("datei.txt", "Neue Zeile");
```

## Dateipfade
Ein Dateipfad gibt an, wo eine Datei gespeichert ist.

```csharp
// Relativer Pfad (vom aktuellen Verzeichnis aus)
string datei1 = "datei.txt";
string datei2 = "ordner/datei.txt";

// Absoluter Pfad (vollständiger Pfad)
string datei3 = "C:/Users/Max/Dokumente/datei.txt";
```

### Path-Klasse für Dateipfade
```csharp
// Pfade zusammenführen
string pfad = Path.Combine("ordner", "unterdordner", "datei.txt");

// Dateierweiterung bekommen
string erweiterung = Path.GetExtension("datei.txt");  // ".txt"

// Dateiname ohne Pfad
string dateiname = Path.GetFileName("/ordner/datei.txt");  // "datei.txt"
```
