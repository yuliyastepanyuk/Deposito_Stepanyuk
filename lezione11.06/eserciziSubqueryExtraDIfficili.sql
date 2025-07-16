-- 1 - Trova i film che hanno la durata più lunga per ogni categoria
SELECT
	title,
    length,
    category.name as Categoria
FROM
	film
JOIN 
	film_category
ON
	film.film_id = film_category.film_id
JOIN
	category
ON
	film_category.category_id = category.category_id
GROUP BY
	title,
    length,
    Categoria
HAVING film.length > (
	SELECT MAX(film.length) as DurataLunga
    FROM (
    SELECT category.name as Genere
    FROM category
    JOIN film_category ON category.category_id = film_category.category_id
    JOIN film ON film_category.film_id = film.film_id
    GROUP BY
		Genere
	));

	
 
-- 2 - trova gli attori i cui film sono stati noleggiati di meno della media dei noleggi per tutti gli attori
SELECT 
	CONCAT(actor.first_name, ' ', actor.last_name) AS NomeCognome, COUNT(rental.rental_id)
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
    COUNT(rental.rental_id) < (
        SELECT AVG(noleggi_per_attore) -- count(r.rental_id)/count(distinct a.actor_id)
        FROM (						   -- from actor
            SELECT COUNT(rental.rental_id) AS noleggi_per_attore
            FROM actor
            JOIN film_actor ON actor.actor_id = film_actor.actor_id
            JOIN film ON film_actor.film_id = film.film_id
            JOIN inventory ON film.film_id = inventory.film_id
            JOIN rental ON inventory.inventory_id = rental.inventory_id
            GROUP BY actor.actor_id
        ) AS calcolo
    );
-- select nome e cognome in join nome conome e film havin j0leggio < media

-- 3 - Trova il paese i cui i clienti noleggiano più film rispetto alla media degli altri paesi, in aggiunta anche il numero totale di clienti in ciascun paese
SELECT
	country.country,
    COUNT(customer.customer_id) AS Totale,
    COUNT(rental.rental_id)
FROM
	country
JOIN
	city
ON
	country.country_id = city.country_id
JOIN
	address
ON
	city.city_id = address.city_id
JOIN
	customer
ON
	address.address_id = customer.address_id
JOIN
	rental
ON
	customer.customer_id = rental.customer_id
GROUP BY
	country.country
HAVING
	COUNT(rental.rental_id) > (
     SELECT AVG(noleggi_per_paese)
        FROM (
            SELECT COUNT(rental.rental_id) AS noleggi_per_paese
            FROM country
            JOIN city ON country.country_id = city.country_id
            JOIN address ON city.city_id = address.city_id
            JOIN customer ON address.address_id = customer.address_id
            JOIN rental ON customer.customer_id = rental.customer_id
            GROUP BY country.country
        ) AS calcolo
    );
	
-- 4 - Trova i titoli dei film e il loro rental_rate che hanno un costo di noleggio (rental_rate) superiore al rental_rate medio di tutti i film che appartengono alla stessa categoria di rating
SELECT 
	DISTINCT title,
    rental_rate,
    rating
FROM
	film f1
WHERE
	rental_rate > (
    SELECT AVG(f2.rental_rate)
    FROM film f2
    WHERE f1.rating  = f2.rating 
    );

-- I film e le loro categorie sono in relazione many-to-many, quindi vanno collegate: film → film_category → category. Per ogni film, vogliamo calcolare: la sua categoria (tramite join), il suo rental_rate e confrontarlo con la media dei rental_rate degli altri film nella stessa categoria. Serve quindi una subquery correlata nella WHERE, che calcola la media per la categoria corrente.