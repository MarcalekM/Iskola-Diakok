using Iskola_Diakok;

string[] Nevek = new string[30]
        {
            "Bence", "Anna", "Zoltán", "Erika", "Tamás", "Réka", "László", "Katalin",
            "Péter", "Eszter", "Gábor", "Judit", "István", "Orsolya", "Ferenc", "Anita",
            "Attila", "Edit", "Miklós", "Zsófia", "János", "Beáta", "Ádám", "Mária",
            "Balázs", "Noémi", "András", "Ilona", "Csaba", "Gabriella"
        };
Iskola Szent_Györgyi = new();
foreach (string nev in Nevek) Szent_Györgyi.DiakFelvitele(new(nev, "Infó"));

Console.WriteLine($"Az iskolában tanulók száma: {Szent_Györgyi.DiakokSzama}");
Console.WriteLine($"A diákok átlag életkora: {Szent_Györgyi.DiakokAtlagEletkora}");