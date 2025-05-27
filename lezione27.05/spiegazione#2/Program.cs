// DESIGN PATTERN
// sono soluzioni riutilizzabili a problemi comuni di design del software.

// non sono frammenti di codice, ma piuttosto linee guida su come strutturare il codice
// grazie al pattern, è possibile migliorare la manutenibilità, la leggibilità e la riusabilità del codice

// il concetto di design pattern è stato introdotto nel libro "Design Patterns: Elements of Reusable Object-Oriented Software" di Erich Gamma, Richard Helm, Ralph Johnson e John Vlissides, pubblicato nel 1994.

// si suddividono in tre categorie principali:
// 1. Creazionali: si occupano della creazione degli oggetti, gestendo la complessità della loro istanziazione.
// 2. Strutturali: si occupano della composizione degli oggetti, definendo come gli oggetti possono essere combinati per formare strutture più complesse.
// 3. Comportamentali: si occupano della comunicazione tra gli oggetti, definendo come gli oggetti interagiscono tra loro e come si scambiano informazioni.

// i cinque design pattern più comuni sono:
// 1. Singleton: garantisce che una classe abbia una sola istanza e fornisce un punto di accesso globale a essa.
// 2. Factory Method: definisce un'interfaccia per creare oggetti, ma lascia la decisione su quale classe istanziare alle sottoclassi.
// 3. Observer: definisce una dipendenza uno-a-molti tra oggetti, in modo che quando uno cambia stato, tutti i suoi dipendenti vengano notificati e aggiornati automaticamente.
// 4. Strategy: definisce una famiglia di algoritmi, incapsulandoli e rendendoli intercambiabili, permettendo di variare il comportamento di un oggetto in modo dinamico.
// 5. Decorator: consente di aggiungere funzionalità a un oggetto in modo dinamico, senza modificare la sua struttura originale, permettendo di estendere le funzionalità degli oggetti in modo flessibile e riutilizzabile.

// CREAZIONALE separare la logica di creazione degli oggetti dal resto del codice
// si usano quando servono nuovi oggetti, in modo dinamico o condizionato

// STRTTURALI definire come classi e oggetti si compongono per formare strutture più grandi
// si usano quando si vuole combinare più oggetti per formare strutture più complesse

// COMPORTAMENTALI definire come gli oggetti interagiscono tra loro e come si scambiano informazioni
// si usano quando è necessario orchestrare la logica di esecuzione, la comunicazione o il flusso di dati tra oggetti

// non si escludono mutualmente, ma si possono combinare per risolvere problemi complessi

// PATTERN COMPORTAMENTALI
// INTENT definire e gestire flussi di comunicazione tra oggetti 

// PATTERN STRUTTURALI
// mira a costruire strutture in modo tale che sia più facile gestirli
// INTENT comporre classi e oggetti in strtture più grandi, definendo nuove funzionalità senza modificare il codice eistente
// si usano quando si vuole aggiungere responsabilità a un oggetto senza modificare la sua struttura originale, unire interfacce incompatibili

// PATTERN CREAZIONALI
// si concentrano sul come vengono creati gli oggetti, nascondendo la complessità della loro istanziazione
// INTENT nascondere la complessità di creazione degli oggetti
// si usano per le istanziazioni condizionali, gestione del ciclo di vita di oggetti costosi, creazione di famiglie di oggetti correlati

