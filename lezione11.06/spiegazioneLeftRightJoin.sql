SELECT
	actor.actor_id,
    actor.first_name,
    actor.last_name,
    film.title
FROM
	actor
JOIN
	film_actor
ON
	actor.actor_id = film_actor.actor_id
JOIN
	film
ON
	film_actor.film_id = film.film_id;

--
SELECT
	customer.customer_id, 
    customer.first_name, 
    customer.last_name, 
    rental.rental_id
FROM
	customer
JOIN
	rental
ON
	customer.customer_id = rental.customer_id;
--
SELECT
	customer.customer_id, 
    customer.first_name, 
    customer.last_name, 
    rental.rental_id
FROM
	customer
LEFT JOIN
	rental
ON
	customer.customer_id = rental.customer_id;
--
INSERT INTO actor (first_name, last_name, last_update)
VALUES ('Mario', 'Rossi', NOW());
--
SELECT a.actor_id, a.first_name, a.last_name, f.title
FROM actor a
JOIN film_actor fa ON a.actor_id = fa.actor_id
JOIN film f ON fa.film_id = f.film_id
WHERE a.first_name = 'Mario';
--
SELECT a.actor_id, a.first_name, a.last_name, f.title
FROM actor a
LEFT JOIN film_actor fa ON a.actor_id = fa.actor_id
LEFT JOIN film f ON fa.film_id = f.film_id
WHERE a.first_name = 'Mario';

	