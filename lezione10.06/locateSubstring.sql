/* LOCATE(substr, str)
Restituisce la posizione della prima occorrenza della sottostringa substr nella stringa str. Se non trova nulla, restituisce 0. */

SELECT title, LOCATE('DOG', title) AS posizione_dog
FROM film
WHERE LOCATE('DOG', title) > 0;

-- TROVARE DOVE SI TROVA IL CARATTERE "A" NEL NOME DEGLI ATTORI --
SELECT first_name, last_name, LOCATE('A', first_name) AS posizione_a
FROM actor
WHERE LOCATE('A', first_name) > 0;

-- SUBSTRING(string, start, length) // SUBSTRING(string FROM start FOR length) --

-- ESTRARRE I PRIMI 5 CARATTERI DEI TITOLI --
SELECT title, SUBSTRING(title, 1, 5) AS primi_cinque
FROM film;

-- Estrarre l'ultima parte del cognome --
SELECT last_name, SUBSTRING(last_name, LENGTH(last_name) - 2, 3) AS ultimi_tre
FROM actor
WHERE LENGTH(last_name) >= 3;

-- LOCATE + SUBSTRING – estrarre tutto dopo “AT” nel titolo --
SELECT
title,
SUBSTRING(title, LOCATE('AT ', title) + 3) AS dopo_at
FROM film
WHERE LOCATE('AT ', title) > 0;


-- Cerca l’ultimo spazio (con REVERSE) e ricava da lì la ultima parola. --
SELECT
title,
SUBSTRING(title, LENGTH(title) - LOCATE(' ', REVERSE(title)) + 2) AS ultima_parola
FROM film
WHERE title LIKE '% %';