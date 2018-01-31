# Prevoditelj

Zadatak projekta: 
Napraviti GUI program koji će omogućiti interaktivno prevođenje teksta korištenjem npr. Google Translate servisa.
Program treba imati dva polja: s tekstom koji treba prevesti i s prijevodom. 
Također, program mora imati dvije kontrole koje će omogućiti zadavanja jezika izvornog teksta, odnosno jezika prijevoda.

## GUI
![Screenshot](prevoditelj.png)

GUI ima Combobox gdje se odabire izvorni jezik (jezik sa kojeg se želi prevesti) i Combobox gdje se odabire odredišni jezik (na koji se želi prevesti).

U prvi TextBox se upisuje teks za prijevod, pritiskom na gumb Prevedi u drugom TextBoxu se prikazuje prijevod.

Postavljene su i dvije labele koje naznačuju gdje se bira izvorni a gdje odredišni jezik.

## API
Korišten je Yendex API. Potrebno je zatražiti ključ na web stranici: https://translate.yandex.com/developers
Korišteni su i URL-ovi za komunikaciju se servisom kako bih mogla dohvatiti jezike.

## Library
Za potrebu projekta korišten je RestSharp za lakše i brže pristupanje servisu putem zahtjeva.
Korišten je i Newtonsoft.Json. Potreban je za konverziju u .net objekt.
Primjer koda: 
```var rijecnik = JsonConvert.DeserializeObject<IDictionary>(odgovor.Content);```
