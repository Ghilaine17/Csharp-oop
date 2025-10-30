Nel progetto csharp-oop-shop, creare la classe Prodotto che gestisce i prodotti dello shop.

Un prodotto è caratterizzato da:

codice (numero intero)

nome

descrizione

prezzo

iva

Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:

alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random

Il codice prodotto sia accessibile solo in lettura

Gli altri attributi siano accessibili sia in lettura che in scrittura

Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva

Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome

Testate poi i vostri oggetti Prodotto, istanziandoli e provando ad interargirci per testare tutti i metodi che avete previsto.

BONUS:

create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri (ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)
Usando un array, dichiarate un elenco dei prodotti di un negozio e inseriteci al suo interno qualche prodotto che vi aspettate di trovare nel negozio. Stampate poi l’elenco dei vostri prodotti che avete previsto nel negozio.
Bonus aggiuntivo: Lv1: Inserire sia nel prezzo che nell'iva un controllo in caso venga settato un valore negativo che stampi a schermo un messaggio di errore sul prezzo inserito e che assegni al prezzo e/o all'iva il valore assoluto positivo del numero passato in input. Lv2: Ottimizzare il controllo dei negativi sull'iva e sul prezzo usando una sola helper function che esegua la trasformazione da negativo a positivo e stampi il messaggio di errore a schermo (la helper function deve essere una static).
