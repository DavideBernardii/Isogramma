# Isogramma

## Consegna 
Determina se una parola o una frase è un isogramma.

Per come lo intendiamo in questo esercizio, un isogramma è una parola o una frase che non ha lettere ripetute.
Sono ammessi spazi e segni di punteggiatura ripetuti.

Esempi di isogrammi:

- lumberjacks
- background
- downstream
- six-year-old

Gli isogrammi possono essere utili come chiavi di cifratura dato che la corrispondenza fra lettere è univoca. 

Isogrammi di 10 lettere, per esempio PATHFINDER, DUMBWAITER o BLACKHORSE, possono essere utilizzate da venditori di beni il cui prezzo può essere negoziato, come macchine usate, gioielli e antichità.

Per esempio le cifre decimali possono essere mappate secondo questo schema:

P	A	T	H	F	I	N	D	E	R

1	2	3	4	5	6	7	8	9	0

Ammettiamo che il prezzo indicato fosse 1200 € ma nel cartellino ci fossero anche le lettere FRR, il venditore saprebbe che il prezzo originale era 500 € in modo da non scendere sotto quella soglia.

Un isogramma di 12 lettere si può usare per mappare i mesi dell'anno.

## Codice 
``` c#
using System;
using System.Linq;

public static class Isogramma
{
    public static bool Verifica(string word)
    {

        word = word.ToLower();

        for(int i=0;i<word.Length;i++)
        for(int n = 0; n < word.Length; n++)
        if((word[i] == word[n]) && (i != n) && (word[i] != '') && (word[i] != '-'))

        return false;

        return true;
    }

}
```
## Spiegazione del codice
Questo codice definisce una classe statica chiamata "Isogramma" che contiene un metodo statico "Verifica" che prende in input una stringa "word" e restituisce un booleano.

Il metodo "Verifica" controlla se la stringa "word" è un isogramma, ovvero una parola in cui non ci sono lettere ripetute. Questo viene fatto nel seguente modo:

La stringa "word" viene convertita in minuscolo, in modo da poter confrontare le lettere indipendentemente dal loro case.

Viene utilizzato un doppio ciclo for per confrontare ogni coppia di lettere nella stringa. La variabile "i" rappresenta l'indice della prima lettera, mentre la variabile "n" rappresenta l'indice della seconda lettera.

Se le lettere confrontate sono uguali, e gli indici "i" e "n" non sono gli stessi (in modo da non confrontare la stessa lettera con se stessa), e la lettera non è né uno spazio vuoto né un trattino, allora la stringa non è un isogramma e viene restituito il valore booleano "false".

Se il ciclo termina senza trovare lettere duplicate, allora la stringa è un isogramma e viene restituito il valore booleano "true".


