# URL-Shortener

## Docker Anleitung ein Befehl
git clone https://github.com/StayFN/URL-Shortener.git && docker build -t shortener ./URL-Shortener/URL-Shortener/ && docker run -p 8080:80 shortener

Zum automatisch starten
* Windows noch am ende "start http://localhost:8080"
* Linux noch am ende "xdg-open http://localhost:8080"
* macOS noch am ende "open http://localhost:8080"

## Docker Anleitung
* Repository Clonen
* Im Verzeichnis URL-Shortener/URL-Shortener: (Namen und Ports nur beispielhaft)
  * docker build -t shortener
  * docker run -p 8080:80 shortener
* Im Browser aufrufen

## Anwendungsanleitung
* In das Feld "URL" die zu kürzende URL einfügen. (z.B. https://www.youtube.com)
* In das Feld "Custom Path" den gewünschten Kurzpfad eingeben (optional) (z.B. yt)
* Auf den Button "Create" Klicken
* Link Kopieren und Go
* Sollte der Kurzpfad schon existieren wird er in der DB einfach mit der neuen URL überschrieben

