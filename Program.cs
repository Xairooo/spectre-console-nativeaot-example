using Spectre.Console;

// Einfache Beispiel-Anwendung mit Spectre.Console und Native AOT
AnsiConsole.Write(
    new FigletText("Spectre.Console")
        .LeftJustified()
        .Color(Color.Blue));

AnsiConsole.MarkupLine("[bold green]Willkommen zu Spectre.Console mit Native AOT![/]");
AnsiConsole.WriteLine();

// Erstelle eine Tabelle
var table = new Table();
table.AddColumn("[yellow]Feature[/]");
table.AddColumn("[green]Status[/]");

table.AddRow("Native AOT", "[green]✓ Aktiviert[/]");
table.AddRow("Spectre.Console", "[green]✓ Funktioniert[/]");
table.AddRow("Kompilierung", "[green]✓ Schnell[/]");
table.AddRow("Dateigröße", "[cyan]Klein[/]");

AnsiConsole.Write(table);
AnsiConsole.WriteLine();

// Fortschrittsbalken-Beispiel
AnsiConsole.Status()
    .Start("[yellow]Verarbeite Daten...[/]", ctx =>
    {
        Thread.Sleep(1000);
        ctx.Status("[green]Daten verarbeitet![/]");
        Thread.Sleep(500);
    });

// Interaktive Auswahl
var choice = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("[green]Wähle eine Option:[/]")
        .PageSize(10)
        .AddChoices(new[] {
            "Option 1: Mehr Informationen",
            "Option 2: Demo ausführen",
            "Option 3: Beenden"
        }));

AnsiConsole.MarkupLine($"Du hast gewählt: [cyan]{choice}[/]");

// Panel mit Informationen
var panel = new Panel(
    new Markup(
        "[bold]Native AOT Compilation[/]\n\n" +
        "Vorteile:\n" +
        "• [green]Schnellere Startzeit[/]\n" +
        "• [green]Kleinere Binärdateien[/]\n" +
        "• [green]Kein .NET Runtime erforderlich[/]\n" +
        "• [green]Bessere Performance[/]"))
{
    Header = new PanelHeader("[bold yellow]Informationen[/]"),
    Border = BoxBorder.Rounded,
    BorderStyle = new Style(Color.Yellow)
};

AnsiConsole.Write(panel);
AnsiConsole.WriteLine();
AnsiConsole.MarkupLine("[dim]Drücke eine beliebige Taste zum Beenden...[/]");
Console.ReadKey();
