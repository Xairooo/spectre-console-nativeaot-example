# Spectre.Console Native AOT Template

[![Build and Publish Native AOT](https://github.com/Xairooo/spectre-console-nativeaot-example/actions/workflows/build-and-publish.yml/badge.svg)](https://github.com/Xairooo/spectre-console-nativeaot-example/actions/workflows/build-and-publish.yml)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Ein produktionsbereites Template für C# Konsolenanwendungen mit [Spectre.Console](https://spectreconsole.net/) und Native AOT Kompilierung in .NET 8.

## 🚀 Features

- ✅ **Native AOT Compilation** - Schnellere Startzeit, kleinere Binärdateien, keine Runtime erforderlich
- ✅ **Spectre.Console Integration** - Schöne CLI mit Rich-Text, Tabellen, Prompts und mehr
- ✅ **Cross-Platform Builds** - Automatische Builds für Linux, Windows und macOS
- ✅ **GitHub Actions CI/CD** - Vollständig konfigurierte Pipeline mit automatischen Releases
- ✅ **Production Ready** - Best Practices für Native AOT und Performance-Optimierungen

## 📋 Verwendung als Template

### Option 1: GitHub Template verwenden
1. Klicke auf **"Use this template"** oben rechts auf der GitHub-Seite
2. Gib deinem neuen Repository einen Namen
3. Klone dein neues Repository und starte mit der Entwicklung

### Option 2: Manuelles Klonen
```bash
git clone https://github.com/Xairooo/spectre-console-nativeaot-example.git mein-projekt
cd mein-projekt
rm -rf .git
git init
```

## 🛠️ Anpassung

### 1. Projektname ändern

**SpectreConsoleNativeAOT.csproj** umbenennen:
```bash
mv SpectreConsoleNativeAOT.csproj MeinProjekt.csproj
```

**GitHub Action anpassen** (`.github/workflows/build-and-publish.yml`):
```yaml
# Ändere alle Vorkommen von "SpectreConsoleNativeAOT" zu "MeinProjekt"
binary-name: MeinProjekt.exe  # Für Windows
binary-name: MeinProjekt      # Für Linux/macOS
```

### 2. Eigene Anwendung entwickeln

Ersetze den Inhalt von `Program.cs` mit deiner eigenen Logik. Beispiele findest du in der [Spectre.Console Dokumentation](https://spectreconsole.net/).

### 3. Dependencies hinzufügen

```bash
dotnet add package MeinPackage
```

**Wichtig für Native AOT:** Nicht alle NuGet-Pakete sind Native AOT kompatibel. Überprüfe die Kompatibilität auf [NuGet.org](https://www.nuget.org/).

## 💻 Lokale Entwicklung

### Voraussetzungen

- .NET 8 SDK oder höher
- Für Native AOT Builds:
  - **Windows**: Visual Studio 2022 mit C++ Desktop Development Workload
  - **Linux**: `sudo apt install clang zlib1g-dev`
  - **macOS**: Xcode Command Line Tools (`xcode-select --install`)

### Standard Build & Run
```bash
dotnet restore
dotnet run
```

### Native AOT Build

**Linux:**
```bash
dotnet publish -c Release -r linux-x64 --self-contained -p:PublishAot=true
./bin/Release/net8.0/linux-x64/publish/SpectreConsoleNativeAOT
```

**Windows:**
```bash
dotnet publish -c Release -r win-x64 --self-contained -p:PublishAot=true
.\bin\Release\net8.0\win-x64\publish\SpectreConsoleNativeAOT.exe
```

**macOS:**
```bash
dotnet publish -c Release -r osx-x64 --self-contained -p:PublishAot=true
./bin/Release/net8.0/osx-x64/publish/SpectreConsoleNativeAOT
```

## ⚙️ GitHub Actions

### Automatische Builds

Die GitHub Action wird ausgelöst bei:
- 🔸 Push zum `main` Branch
- 🔸 Pull Requests
- 🔸 Manueller Trigger (workflow_dispatch)

### Automatische Releases

Bei jedem Push zum `main` Branch:
1. Alle drei Plattformen werden kompiliert (Linux, Windows, macOS)
2. Ein neues Release wird automatisch erstellt
3. Alle Binaries werden als Download bereitgestellt

Release-Format: `v2026.01.29-1230` (Jahr.Monat.Tag-StundeMinute)

## 📊 Native AOT Vorteile

| Feature | Standard .NET | Native AOT |
|---------|--------------|------------|
| **Startzeit** | ~500ms | ~50ms |
| **Dateigröße** | ~100MB | ~2-5MB |
| **Runtime erforderlich** | ✅ Ja | ❌ Nein |
| **Speicherverbrauch** | Höher | Niedriger |
| **Performance** | Gut | Exzellent |

## 📁 Projektstruktur

```
.
├── .github/
│   ├── workflows/
│   │   └── build-and-publish.yml    # CI/CD Pipeline
│   └── template.yml                 # Template Metadaten
├── Program.cs                        # Hauptanwendung
├── SpectreConsoleNativeAOT.csproj   # Projektdatei mit AOT-Konfiguration
├── LICENSE                          # MIT License
└── README.md                        # Diese Datei
```

## 📝 Wichtige Konfigurationen

### .csproj Eigenschaften

```xml
<PublishAot>true</PublishAot>
<InvariantGlobalization>true</InvariantGlobalization>
<JsonSerializerIsReflectionEnabledByDefault>false</JsonSerializerIsReflectionEnabledByDefault>
```

- `PublishAot`: Aktiviert Native AOT Kompilierung
- `InvariantGlobalization`: Reduziert Dateigröße (deaktiviert Kultur-spezifische Features)
- `JsonSerializerIsReflectionEnabledByDefault`: Optimiert JSON Serialisierung für AOT

## 🐛 Bekannte Einschränkungen

- ❌ Reflection ist eingeschränkt (nutze Source Generators)
- ❌ Dynamisches Code-Laden nicht möglich
- ❌ Einige NuGet-Pakete sind nicht kompatibel
- ✅ Spectre.Console ist vollständig kompatibel!

Mehr Infos: [Native AOT Deployment](https://learn.microsoft.com/en-us/dotnet/core/deploying/native-aot/)

## 📚 Beispiele

Das Template enthält Beispiele für:
- 🎨 Figlet-Text und farbiges Markup
- 📋 Tabellen mit Styling
- ⏳ Status-Anzeigen und Spinner
- ⌨️ Interaktive Prompts und Menüs
- 📦 Panels und Layouts

Weitere Beispiele: [Spectre.Console Examples](https://spectreconsole.net/examples)

## 🤝 Contributing

Beiträge sind willkommen! Bitte erstelle einen Pull Request oder öffne ein Issue.

## 💬 Support

- 📚 [Spectre.Console Dokumentation](https://spectreconsole.net/)
- 📖 [.NET Native AOT Guide](https://learn.microsoft.com/en-us/dotnet/core/deploying/native-aot/)
- 🐛 [Issues](https://github.com/Xairooo/spectre-console-nativeaot-example/issues)

## 📜 Lizenz

MIT License - siehe [LICENSE](LICENSE) Datei für Details.

---

**Tipp:** Nach dem Erstellen eines neuen Projekts aus diesem Template, vergiss nicht die Badge-URLs in dieser README zu aktualisieren!
