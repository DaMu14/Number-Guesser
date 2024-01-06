# Number Generator

## Informieren
 

 Anforderungen
| US-№ | Verbindlichkeit | Typ        | Beschreibung |                                                                                                                       
| ---- | --------------- | ---------- | ---------------------------------------------------------------------------------------------------------------------------------|
| 1  |    Muss           | Funktional |  Als Benutzer möchte ich, dass der Computer eine Geheimzahl zwischen 1 und 100 speichert, damit ich sie erraten kann. |
|2  |   Muss             | Funktional| Als Benutzer möchte ich, dass ich Zahlen erraten kann, damit das Spiel spass macht. |
|  3 |   Muss |  Funktional    | Als Benutzer möchte ich, dass mir angezeigt wird, ob die gesuchte Zahl grösser, kleiner oder die richtige ist, damit ich weiss wo ich weiter raten muss.|
| 4   | Muss       | Funktional | Als Benutzer möchte ich, dass die Versuche angezeigt werden, damit ich weiss wieviele Versuche ich hatte. |
|  5  |  Muss |        | Funktional   | Als Benutzer möchte ich, dass mir der Highscore angezeigt wird, damit ich weiss was mein bester Versuch war. |
|  6   |  Muss   |  Funktional | Als Benutzer möchte ich, dass ich zwischen 5 und unbegrenzten Versuchen entscheiden kann, damit ich mehr Spielspass habe.   |
|  7  |  Muss    | Funktional | Als Benutzer möchte ich, dass Eingabefehler abgefangen werden, damit das Programm nicht immer abstürzt. |


 


## Planen

| US-№ | Datum | Arbeitspaket  | Verantwortliche Person   |
| ---- | ----- | ------------- | ------------------------- |
| 1.1 | 18.08.23   | Ziele erstellen | Damian Müller |
| 2.1 | 18.08.23   | Projekt planen |Damian Müller |
| 3.1 | 18.08.23   | Der Computer speichert eine Zufallszahl zwischen und mit 1 bis 100 als Geheimzahl.   | Damian Müller |
| 4.1 | 25.08.23   | Der Benutzer kann Zahlen erraten. | Damian Müller |
| 5.1 | 25.08.23   | Dem Benutzer wird angezeigt, ob die Zahl grösser, kleiner oder richtig ist. | Damian Müller |
| 6.1 | 25.08.23   | Die Anzahl Versuche werden angezeigt. | Damian Müller |
| 7.1 | 1.9.23     | Dem Benutzer wird der Highscore angezeigt. | Damian Müller |
| 8.1 | 25.08.23   | Der Benutzer kann zwischen 5 und unbegrenzten Versuche wählen | Damian Müller |
| 9.1| 25.08.23   | Das Programm kann Eingabefehler abfangen | Damian Müller|


## Kontrollieren

### Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
|---|---|---|---|
| 3.1 | Applikation ist gestartet | 5 oder unbegrenzte Versuche auswählen | Zahl wird gespeichert|
| 4.1 | Applikation ist gestartet | 1 oder 2  |  Geben sie eine Zahl ein |
| 5.1 | Eine Zahl wurde eingegeben | 10 | Zahl ist grösser, kleiner oder die richtige Zahl |
| 6.1 | Zahl wurde erraten |  - | Anzahl Versuche |
| 7.1 | Zahl wurde erraten | - | Highscore wird angezeigt |
| 8.1 | Applikation ist gestartet | 1 oder 2 | 5 und unbegrenzten Versuche gewählt |
| 9.1| Applikation ist gestartet | A | Geben sie eine ganze Zahl ein |


### Testprotokoll

| Test-№ | TC-№ | Resultat | Datum      | Tester |
| ------ | ---- | -------- | ---------- | ------ |
| 1 | 3.1 |  OK ✅         | 6.1.24 | Müller |
| 2 | 4.1 |  OK ✅         | 6.1.24 | Müller |
| 3 | 5.1 |  OK ✅        | 6.1.24 | Müller |
| 4 | 6.1 |  OK ✅         | 6.1.24 | Müller |
| 5 | 7.1 |  OK ✅         | 6.1.24 | Müller |
| 6 | 8.1 |  OK ✅         | 6.1.24 | Müller |
| 7 | 9.1 |  OK ✅         | 6.1.24 | Müller |

Alle Tests sind erfolgreich und das Programm läuft eigentlich so wie es soll.
