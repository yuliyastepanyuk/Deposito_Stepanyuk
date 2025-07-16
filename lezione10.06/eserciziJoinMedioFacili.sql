SELECT *
FROM
	film;
--
SELECT *
FROM
	language;
--
SELECT film.title, language.name AS language
FROM
	film
JOIN 
	language
ON
	film.language_id = language.language_id;
--
SELECT * 
FROM
	customer
JOIN
	store
ON
	customer.store_id = store.store_id;
--
SELECT * 
FROM
	customer;
--
SELECT *
FROM
	store;
--
SELECT film.title, category.name -- definire cosa vogliamo
FROM
	film -- partiamo dalla lista di tutti i film
JOIN
	film_category -- da qua facciamo il primo passaggio, tramite film_id
ON
	film.film_id = film_category.film_id -- sulla chiave in comune
JOIN
	category -- faccio il secondo passaggio
ON
	film_category.category_id = category.category_id; -- sulla chiave in comune
--
SELECT customer.first_name, address.address, city.city, country.country
FROM
	customer
JOIN
	address
ON
	address.address_id = customer.address_id
JOIN
	city
ON 
	address.city_id =  city.city_id
JOIN
	country
ON
	city.country_id = country.country_id;
    
-- per ogni rental mostrare customer servito e staff che ha eseguito il servizio
SELECT rental.rental_id, customer.first_name, staff.first_name
FROM
	rental
JOIN
	customer
ON
	rental.customer_id = customer.customer_id
JOIN 
	staff
ON 
	rental.staff_id = staff.staff_id;

-- per ogni categoria trovare quanti film sono stati fatti
SELECT category.name, COUNT(*)
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
GROUP BY
	category.name; -- Il raggruppamento per category.name assicura che il conteggio sia fatto per ogni categoria individualmente.
--
SELECT actor.first_name, actor.last_name, COUNT(film.film_id) as numero
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
GROUP BY
	actor.actor_id
HAVING
	numero > 35;
-- Mostra il nome del film, la sua categoria e gli attori che vi hanno recitato (usa JOIN multipli)
SELECT
    film.title,
    category.name AS categoria,
    CONCAT(actor.first_name, ' ', actor.last_name) AS actor_name -- group_concat
FROM
    film
JOIN
    film_category ON film.film_id = film_category.film_id
JOIN
    category ON film_category.category_id = category.category_id
JOIN
    film_actor ON film.film_id = film_actor.film_id
JOIN
    actor ON film_actor.actor_id = actor.actor_id;
-- Trova i clienti che hanno effettuato più di 5 noleggi.
SELECT customer.customer_id, CONCAT(customer.first_name, ' ', customer.last_name), COUNT(*)
FROM
	customer
JOIN
	rental
ON 
	customer.customer_id = rental.customer_id
GROUP BY
	customer.customer_id,
    CONCAT(customer.first_name, ' ', customer.last_name)
HAVING
	COUNT(*) > 5;	
/* Nella maggior parte dei sistemi di gestione di database SQL, quando si utilizza una clausola GROUP BY, è necessario includere tutte le colonne non aggregate presenti nella clausola SELECT nella clausola GROUP BY. Questo è un requisito del linguaggio SQL per garantire che i risultati siano deterministici e coerenti.

Nella query che hai fornito, stai selezionando tre colonne:

1. customer.customer_id
2. CONCAT(customer.first_name, ' ', customer.last_name) (che è una colonna calcolata)
3. COUNT(*) (che è una funzione di aggregazione)
Poiché COUNT(*) è una funzione di aggregazione, non è necessario includerla nella clausola GROUP BY. Tuttavia, sia customer.customer_id che CONCAT(customer.first_name, ' ', customer.last_name) devono essere inclusi nella clausola GROUP BY perché sono colonne non aggregate.
*/

-- Elenca tutti i film che non sono mai stati noleggiati.
SELECT film.title
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
WHERE rental.rental_id IS NULL;

-- Mostra il nome del film, la sua categoria e il totale speso dai clienti per quel film (basato sui noleggi).
SELECT film.title, category.name, SUM(payment.amount)
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
	film.title,
    category.name;
    
-- Trova gli attori che non hanno mai recitato in un film di una determinata categoria (es: 'Action').
SELECT CONCAT(actor.first_name, ' ', actor.last_name) AS FullName, group_concat(category.name separator "/") as Categoria
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
	film_category
ON
	film.film_id = film_category.film_id
JOIN
	category
ON
	film_category.category_id = category.category_id
GROUP BY
	FullName,
	CONCAT(actor.first_name, ' ', actor.last_name)
HAVING
	Categoria NOT LIKE '%action%';


-- Trova le categorie di film con il numero medio di attori più alto per film.
SELECT category.name, COUNT(actor.actor_id)/COUNT(distinct film.film_id)
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
	film_actor
ON
	film.film_id = film_actor.film_id
JOIN
	actor
ON
	film_actor.actor_id = actor.actor_id
GROUP BY
    category.name




	
	

	

	
	
	

	
	
	
	
	
	
	
    
	

    
