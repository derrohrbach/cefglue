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

## 3. Code neu erzeugen

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

## 4. Neue Enums und Strukturen identifizieren

Vergleiche die CEF-Header der neuen Version mit den bisherigen. Tauchen dort
neue `enum`- oder `struct`-Definitionen auf, erstelle passende Dateien unter
`CefGlue/Enums` bzw. `CefGlue/Structs`. Beispiel: Der letzte Versionssprung
führte die Enum `CefZoomCommand` ein, die von Hand eingepflegt wurde.

## 5. Partial-Klassen aktualisieren

Die generierten `.g.cs`-Dateien definieren nur das Grundgerüst. Eigentliche
Logik liegt in den Partial-Klassen unter `CefGlue/Classes.Handlers` und
`CefGlue/Classes.Proxies`. Suche dort nach neuen Methoden oder geänderten
Signaturen und implementiere sie. Die Zoom-Funktionen in
`CefBrowserHost` können als Beispiel dienen.

## 6. Entfernte Methoden aufräumen

Falls CEF Funktionen entfernt hat, erscheinen sie nicht mehr in den neu
generierten Dateien. Entferne dann auch die entsprechenden Methoden aus den
Partial-Klassen und lösche die nicht mehr benötigten `.g.cs`-Dateien.
`CefGlue.g.props` listet alle automatisch eingebundenen Dateien und hilft bei der
Prüfung.

## 7. Lösung bauen und testen

1. Öffne `Xilium.CefGlue.sln` und baue alle Projekte.
2. Führe die Beispielanwendungen aus, um sicherzustellen, dass die neuen
   Funktionen wie erwartet arbeiten.
3. Erst wenn alles läuft, sollten überflüssige Dateien endgültig entfernt werden.

Mit diesen Schritten lässt sich die Bibliothek auf eine neue CEF-Version
aktualisieren. Achte darauf, nach jedem Lauf der Generator-Skripte die
Änderungen in Git zu committen, damit sich der Verlauf nachvollziehen lässt.