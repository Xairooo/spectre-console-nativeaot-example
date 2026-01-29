# Spectre.Console Native AOT Example

Dieses Projekt demonstriert die Verwendung von [Spectre.Console](https://spectreconsole.net/) mit Native AOT Kompilierung in .NET 8.

## Features

- ✅ **Native AOT Compilation** - Schnelle Startzeit und kleine Binärdateien
- ✅ **Spectre.Console** - Schöne Konsolenanwendungen mit Rich-Text, Tabellen, und mehr
- ✅ **Cross-Platform** - Builds für Linux, Windows und macOS
- ✅ **GitHub Actions** - Automatisches Kompilieren und Veröffentlichen

## Voraussetzungen

- .NET 8 SDK oder höher
- Für Native AOT Build: entsprechende Compiler-Tools
  - **Windows**: Visual Studio 2022 mit C++ Desktop Development Workload
  - **Linux**: `clang` und `zlib1g-dev`
  - **macOS**: Xcode Command Line Tools

## Lokales Bauen

### Standard Build
```bash
dotnet run
```

### Native AOT Build

**Linux/macOS:**
```bash
dotnet publish -c Release -r linux-x64 --self-contained -p:PublishAot=true
./bin/Release/net8.0/linux-x64/publish/SpectreConsoleNativeAOT
```

**Windows:**
```bash
dotnet publish -c Release -r win-x64 --self-contained -p:PublishAot=true
.\bin\Release\net8.0\win-x64\publish\SpectreConsoleNativeAOT.exe
```

## GitHub Actions

Die GitHub Action compiliert automatisch für drei Plattformen:
- Linux (linux-x64)
- Windows (win-x64)
- macOS (osx-x64)

Bei jedem Push zum `main` Branch wird automatisch ein neues Release mit allen kompilierten Binärdateien erstellt.

## Native AOT Vorteile

- 🚀 **Schnellere Startzeit** - Keine JIT-Kompilierung zur Laufzeit
- 📦 **Kleinere Dateien** - Nur der benötigte Code wird eingebunden
- ⚡ **Keine Runtime erforderlich** - Self-contained Executable
- 💪 **Bessere Performance** - Optimierte Ahead-of-Time Kompilierung

## Projekt-Struktur

```
.
├── Program.cs                          # Hauptanwendung mit Spectre.Console Beispielen
├── SpectreConsoleNativeAOT.csproj     # Projektdatei mit AOT-Konfiguration
├── .github/
│   └── workflows/
│       └── build-and-publish.yml      # GitHub Actions Workflow
└── README.md
```

## Lizenz

MIT License
