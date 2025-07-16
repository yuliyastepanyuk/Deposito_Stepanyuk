-- Traccia: Trova i titoli dei film che hanno lo stesso numero di attori del film "ACADEMY DINOSAUR".
SELECT 
	film.title
FROM
	film
JOIN
	film_actor
ON
	film.film_id = film_actor.film_id
GROUP BY
film.title
HAVING
	COUNT(film_actor.actor_id) = (
    SELECT COUNT(film_actor.actor_id)
    FROM film_actor
    JOIN film ON film.film_id = film_actor.film_id -- devo rifare la join
    WHERE film.title = "ACADEMY DINOSAUR"
    );

-- Trova i clienti che hanno speso più della media delle spese totali dei clienti.
/*SELECT 
	CONCAT(customer.first_name, ' ', customer.last_name), total_spent
FROM
	CUSTOMER*/

SELECT DISTINCT CONCAT(customer.first_name, ' ', customer.last_name), SUM(payment.amount)
FROM
	payment

JOIN 
	customer
ON
	payment.customer_id = customer.customer_id
WHERE 
	SUM(payment.amount) > (SELECT
							AVG(payment.amount) -- devono uscire 285 record
						FROM
							payment); -- parto al contrario, mi serve la media di payment

-- prendere l'amount di tutti i clienti, devo identificare quelli che sono i maggiori spendenti, amount cliente > amount media
    
-- Trova i titoli dei film che non sono mai stati noleggiati.
SELECT DISTINCT film.title
FROM
	film
JOIN
	inventory
ON
	film.film_id = inventory.film_id
JOIN
	rental
ON
	inventory.inventory_id = rental.inventory_id
WHERE
	film.film_id NOT IN (
    SELECT rental.rental_id
    FROM rental
	);
--
SELECT 
	title
FROM 
	film
WHERE film_id NOT IN (
    SELECT inventory.film_id
    FROM inventory
    JOIN rental ON inventory.inventory_id = rental.inventory_id
);
     

-- --
SELECT c.name, COUNT(fc.film_id) AS num_film
FROM category c
JOIN film_category fc ON c.category_id = fc.category_id
GROUP BY c.category_id
HAVING COUNT(fc.film_id) > (
SELECT AVG(film_count)
FROM (
SELECT COUNT(*) AS film_count
FROM film_category
GROUP BY category_id
) AS sub
);
-- --
SELECT c.first_name, c.last_name, SUM(p.amount) as spesaTot
from customer c
JOIN payment p on c.customer_id = p.customer_id
GROUP BY c.customer_id, c.first_name, c.last_name
HAVING spesaTot > (
SELECT AVG(s.spesaTotale)
FROM(
SELECT SUM(amount) as spesaTotale
FROM payment
GROUP BY customer_id
)AS s
)
ORDER BY spesaTot DESC;

-- esercizio tre HAVING total_spent > ; quattro WHERE film_id NOT IN

-- trova i nomi dello staff che processano più pagamenti della media degli altri, mostra anche il numero totale di pagamenti processati
-- trova gli store_id che fanno più noleggi della media degli altri, con il loro indirizzo
-- trova i nomi dei clienti che non hanno mai noleggiato un film
-- trova il paese i cui i clienti noleggiano più film rispetto alla media degli altri paesi, in aggiunta anche il numero totale di clienti in ciascun paese
-- trova gli attori i cui film sono stati noleggiati di meno della media dei noleggi per tutti gli attori
-- trova tutti i film noleggiati da un determinato customer
