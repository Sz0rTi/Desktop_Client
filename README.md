# Desktop_Client

[WIP]

Desktopowy klient tworzony w Windows Forms. 

Zawiera opcje: tworzenia produktu, wyświetlania produktów po kategorii oraz (niekompletna) wystawiania faktury sprzedażowej.

Podczas wystawiania faktury sprzedażowej możemy wyszukać klienta po numerze NIP w systemie GUS. 
Dane wypełnią się automatycznie (z drobnymi błędami, np, numer domu ze / na końcu, brak ulicy kiedy jest to mała wieś itd.).

Faktura zostanie dopisana do wybranego, istniejąccego klienta lub zostanie utworzony nowy klient, jeśli takowy nie występuje w bazie
(identyfikacja opiera się na numerze NIP).

Podgląd faktur na ten moment tylko z poziomu Swaggera na serwerze.
