select first_name, last_name from actor;
--
SELECT * FROM film 
WHERE rating = 'G' 
    AND (rental_rate = 0.99 OR rental_rate = 4.99);
--
SELECT * FROM film;
--
SELECT title, length
FROM film;
--
SELECT title, rating
FROM film
WHERE length > 120;
--
SELECT * FROM customer
WHERE address_id = 312;

--

SELECT * 
FROM payment
WHERE amount = 5.99;
--
SELECT *
FROM film
WHERE length > 90
AND
rating = "PG";
--
SELECT *
FROM customer
WHERE address_id = 312
OR
address_id = 459;
--
SELECT *
FROM film
WHERE length < 80
OR length > 180;
--
SELECT *
FROM film
WHERE rating <> 'R';
--
SELECT *
FROM payment
WHERE amount NOT BETWEEN 2 AND 5;
--
SELECT *
FROM film
WHERE rating
BETWEEN 'PG' AND 'R';
--
SELECT *
FROM film
WHERE rating IN ('G', 'PG', 'PG-13');
--
SELECT *
FROM film
WHERE title 
LIKE 'THE%';
--
SELECT *
FROM customer
WHERE first_name
LIKE 'A%';
--
SELECT *
FROM rental
WHERE return_date
IS NULL;
--
SELECT *
FROM film
ORDER BY length DESC
LIMIT 10;
--
SELECT *
FROM customer
ORDER BY create_date DESC
LIMIT 5;
--
SELECT DISTINCT amount
FROM payment
ORDER BY amount DESC;
--
SELECT *
FROM film
WHERE rating = 'PG-13'
ORDER BY length desc
LIMIT 3;
--
SELECT title, LENGTH(title) 
FROM film;
--
SELECT UPPER(first_name), UPPER(last_name)
FROM customer;
--
SELECT LOWER(title)
FROM film
LIMIT 10;
--
SELECT 
  CONCAT(title, ' (', rating, ')') AS titolo_completo
FROM 
  film;
  --
SELECT 
  LEFT(title, 10) 
FROM 
  film;
--
SELECT 
	RIGHT(title, 5)
FROM
	film
LIMIT
	10;
--
SELECT
	LEFT(last_name, 3) AS LastTruncate
FROM
	customer;
--
SELECT
	substring_index(title, ' ', 1) AS prima_parola,
    COUNT(*) AS occorrenze
FROM
	film
GROUP BY 
	prima_parola
ORDER BY
	occorrenze DESC;
--
SELECT 
    first_name,        
    create_date,      
    CURDATE() AS data_creazione
    -- NOW() AS data_attuale
FROM 
    customer;
--
SELECT 
    first_name,
    create_date,
    CURDATE() AS data_attuale,
    DATEDIFF(CURDATE(), create_date) AS giorni_trascorsi
FROM 
    customer;
--
SELECT 
    first_name,
    create_date,
    YEAR(create_date) AS anno_creazione
FROM 
    customer;
--
SELECT *
FROM
	rental
WHERE
	YEAR(rental_date) = 2005;
--
SELECT 
    *, 
    DATEDIFF(NOW(), create_date) AS giorni_registrato
FROM 
    customer
LIMIT 10;




