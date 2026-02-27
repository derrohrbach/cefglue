# Update von CefGlue auf eine neue CEF-Version

Diese Anleitung beschreibt Schritt für Schritt, wie die CEF-Header
aktualisiert werden und welche Dateien danach angepasst werden müssen.
Sie richtet sich an Entwickler, die bereits ein funktionierendes CefGlue-Setup
haben und nur die CEF-Version erneuern möchten.

## 1. Neue CEF-Header einspielen

1. Lade die gewünschte CEF-Distribution herunter und entpacke sie.
2. Ersetze den Ordner `CefGlue.Interop.Gen/include` im Repository durch den
   `include`-Ordner der neuen Distribution.
3. Sichere die alten Header, falls du später Vergleiche anstellen möchtest.

## 2. Klassenrollen anpassen

Neue oder umbenannte Klassen müssen im Skript `schema_cef3.py` einem
**Role** zugeordnet werden. Dort wird festgelegt, ob eine Klasse als
Handler oder als Proxy behandelt wird:

```python
classdef = {
    'CefBrowser': { 'role': ROLE_PROXY },
    'CefClient':  { 'role': ROLE_HANDLER, 'reversible': True },
    # ...
}
```

Füge neue Klassen entsprechend hinzu, damit der Generator die richtigen
Wrapper erzeugen kann.

## 3. Typ-Mappings in schema.py pflegen

Neue Enum-Typen aus den CEF-Headern müssen in `schema.py` im Dictionary
`c2cs_enumtypes` registriert werden, damit der Generator die C-Typen korrekt
auf C#-Enums abbildet:

```python
c2cs_enumtypes = {
    'cef_runtime_style_t': 'CefRuntimeStyle',
    # ...
}
```

Ohne diesen Eintrag erzeugt der Generator falsche Signaturen.

## 4. Code neu erzeugen

Unter Windows steht das Skript `gen-cef3.cmd` bereit. Es ruft
`cefglue_interop_gen.py` mit den benötigten Parametern auf:

```cmd
"%ProgramFiles%\Python313\python.exe" -B cefglue_interop_gen.py --cpp-header-dir include --cefglue-dir ..\CefGlue\ --no-backup
```

Auf anderen Plattformen startest du das Python-Skript manuell:

```bash
python cefglue_interop_gen.py --cpp-header-dir include --cefglue-dir ../CefGlue/ --no-backup
```

Nach dem Lauf finden sich neue Dateien in `CefGlue/Interop` und `CefGlue/Classes.g`.

## 5. Neue Enums und Strukturen identifizieren

Vergleiche die CEF-Header der neuen Version mit den bisherigen. Tauchen dort
neue `enum`- oder `struct`-Definitionen auf, erstelle passende Dateien unter
`CefGlue/Enums` bzw. `CefGlue/Structs` und die zugehörigen Interop-Structs
unter `CefGlue/Interop/Structs`.

## 6. Manuell gepflegte Interop-Structs abgleichen

Einige Interop-Structs werden **nicht** vom Generator erzeugt, sondern von Hand
gepflegt. Dazu gehören u.a.:

- `cef_settings_t.cs`
- `cef_browser_settings_t.cs`
- `cef_request_context_settings_t.cs`
- `cef_window_info_t.cs`

Vergleiche diese mit den Definitionen in `include/internal/cef_types.h` bzw.
`cef_types_win.h`. Entfernte Felder müssen gelöscht, neue Felder ergänzt
werden – die **Reihenfolge** muss exakt mit dem C-Header übereinstimmen, da
sonst das Struct-Layout nicht passt und CEF beim Initialisieren abstürzt.
Aktualisiere parallel die zugehörigen Wrapper-Klassen in `CefGlue/Structs`
(z.B. `CefSettings.cs`, `CefBrowserSettings.cs`).

## 7. Partial-Klassen aktualisieren

Die generierten `.g.cs`-Dateien definieren nur das Grundgerüst. Eigentliche
Logik liegt in den Partial-Klassen unter `CefGlue/Classes.Handlers` und
`CefGlue/Classes.Proxies`. Suche dort nach neuen Methoden oder geänderten
Signaturen und implementiere sie. Die Zoom-Funktionen in
`CefBrowserHost` können als Beispiel dienen.

## 8. Entfernte Methoden aufräumen

Falls CEF Funktionen entfernt hat, erscheinen sie nicht mehr in den neu
generierten Dateien. Entferne dann auch die entsprechenden Methoden aus den
Partial-Klassen und lösche die nicht mehr benötigten `.g.cs`-Dateien.
`CefGlue.g.props` listet alle automatisch eingebundenen Dateien und hilft bei der
Prüfung.

## 9. Projektdatei aktualisieren

`CefGlue.csproj` verwendet explizite `<Compile Include>`-Einträge (kein
Auto-Globbing). Jede neu angelegte Datei muss dort von Hand eingetragen werden,
sonst wird sie nicht kompiliert. Ebenso müssen Einträge gelöschter Dateien
entfernt werden.

## 10. Nachgelagerte Projekte anpassen

Projekte wie `CefGlue.WindowsForms`, `CefGlue.WPF` und die Demo-Anwendungen
überschreiben virtuelle Methoden aus den Handler-Klassen. Ändern sich deren
Signaturen, müssen die Overrides in diesen Projekten ebenfalls aktualisiert
werden. Ein Solution-weiter Build deckt fehlende Anpassungen zuverlässig auf.

## 11. NuGet-Paketversion aktualisieren

Die nativen CEF-Binaries werden über die NuGet-Pakete
`chromiumembeddedframework.runtime` und
`chromiumembeddedframework.runtime.win-x64` (analog für win-x86 / win-arm64)
eingebunden. Passe die Versionsnummer in allen Launcher-Projekten an:

```xml
<PackageReference Include="chromiumembeddedframework.runtime"
                  Version="145.0.26" GeneratePathProperty="true" />
<PackageReference Include="chromiumembeddedframework.runtime.win-x64"
                  Version="145.0.26" GeneratePathProperty="true" />
```

Die verfügbaren Versionen findest du unter
`https://www.nuget.org/packages/chromiumembeddedframework.runtime`.

Wähle die neueste Patch-Version, die zu deiner CEF-Hauptversion passt. Kleine
Abweichungen (z.B. `145.0.26` vs. `145.0.27`) sind unkritisch.

## 12. Assembly-Version anpassen

In `CefGlue/CefGlue.csproj` steht die Assembly-Version des Pakets.
Setze sie auf die neue CEF-Version, damit die versionierten Assemblys
eindeutig einer CEF-Version zuzuordnen sind:

```xml
<Version>145.0.27</Version>
```

Der Wert entspricht der CEF-Version, gegen die die Interop-Structs und
API-Hashes in `CefGlue/Interop/version.g.cs` generiert wurden.

## 13. Lösung bauen und testen

1. Öffne `Xilium.CefGlue.sln` und baue alle Projekte.
2. Führe die Beispielanwendungen aus, um sicherzustellen, dass die neuen
   Funktionen wie erwartet arbeiten.
3. Erst wenn alles läuft, sollten überflüssige Dateien endgültig entfernt werden.

Mit diesen Schritten lässt sich die Bibliothek auf eine neue CEF-Version
aktualisieren. Achte darauf, nach jedem Lauf der Generator-Skripte die
Änderungen in Git zu committen, damit sich der Verlauf nachvollziehen lässt.