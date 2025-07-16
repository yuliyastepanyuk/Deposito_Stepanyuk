-- Esercizio 1: Clienti con più di 20 noleggi totali, ordinati per spesa totale decrescente. Richiesta mostra l’id, il nome, cognome, numero totale di noleggi e somma spesa totale per quei clienti che hanno fatto più di 20 noleggi. Ordina per somma spesa decrescente.
SELECT 
	customer.customer_id, CONCAT(customer.first_name, ' ', customer.last_name) AS Customer, COUNT(rental.rental_id) AS NoleggiTOT, SUM(payment.amount) AS Totale
FROM
	customer
JOIN
	rental
ON
	customer.customer_id = rental.customer_id
JOIN
	payment
ON
	rental.rental_id = payment.payment_id
GROUP BY
	customer.customer_id
HAVING
	COUNT(rental.rental_id) > 20
ORDER BY
	SUM(payment.amount) DESC;

-- Esercizio 2: Numero medio di noleggi per categoria di film. Richiesta calcola il numero medio di noleggi per ogni categoria (category.name). Ordina per media decrescente. Mostra solo categorie con almeno 50 noleggi totali.
SELECT
	category.name as Genere, COUNT(rental.rental_id)/COUNT(distinct film.film_id) as Media_Noleggi, COUNT(rental.rental_id) AS NoleggiTOT
FROM
	category
JOIN
	film_category
ON
	category.category_id = film_category.category_id
JOIN
	film
ON
	film_category.film_id = film.film_id
JOIN
	inventory
ON
	film.film_id = inventory.film_id
JOIN
	rental
ON
	inventory.inventory_id = rental.inventory_id
GROUP BY
	Genere
HAVING
	NoleggiTOT > 50
ORDER BY
	Media_Noleggi DESC;

-- Esercizio 3: Attori con più film a catalogo e noleggi totali. Richiesta mostra gli attori che hanno partecipato ad almeno 10 film presenti nell’inventario e il numero totale di noleggi per i film in cui hanno recitato. Ordina per noleggi totali decrescenti.
SELECT CONCAT(actor.first_name, ' ', actor.last_name) AS NomeCognome, COUNT(rental.rental_id) AS NumeroREN, COUNT(distinct film.film_id) AS NumeroFilm -- ho messo colonna non inerente
FROM
	actor
JOIN
	film_actor
ON
	actor.actor_id = film_actor.actor_id
JOIN
	film
ON
	film_actor.film_id = film.film_id
JOIN 
	inventory
ON
	film.film_id = inventory.film_id
JOIN
	rental
ON
	inventory.inventory_id = rental.inventory_id
GROUP BY 
	NomeCognome
HAVING
	NumeroFilm >= 10
ORDER BY
	NumeroREN DESC;
    
-- Categorie più "redditizie" per spesa totale media per film. Richiesta per ogni categoria, mostra la spesa totale media per film (non per noleggio). Ordina per media decrescente.
SELECT 
	category.name, SUM(payment.amount) / COUNT(distinct film.film_id) as media_spesa
FROM
	category
JOIN
	film_category
ON
	category.category_id = film_category.category_id
JOIN
	film
ON
	film_category.film_id = film.film_id
JOIN
	inventory
ON
	film.film_id = inventory.film_id
JOIN
	rental
ON
	inventory.inventory_id = rental.inventory_id
JOIN
	payment
ON
	rental.rental_id = payment.rental_id
GROUP BY
	category.name
ORDER BY
	media_spesa DESC;


	
	
	
	
	

	
	
	