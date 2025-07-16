SELECT COUNT(*) 
FROM
	film;
--
SELECT AVG(length)
FROM
	film;
--
SELECT MIN(length), MAX(length)
FROM
	film;
--
SELECT SUM(amount)
FROM
	payment;
--
SELECT rating, COUNT(*)
FROM
	film
GROUP BY 
		rating;
--
SELECT customer_id, COUNT(payment_id)
FROM
	payment
GROUP BY
	customer_id;
--
SELECT customer_id, SUM(amount)
FROM
	payment
GROUP BY
	customer_id;
--
SELECT LENGTH, COUNT(length)
FROM
	film
GROUP BY
	length;
--
SELECT rating, AVG(length)
FROM 
	film
GROUP BY
	rating
HAVING
	AVG(length) > 100;
--
SELECT customer_id, SUM(amount)
FROM
	payment
GROUP BY
	customer_id
HAVING
	SUM(amount) > 100;
--
SELECT rating, COUNT(*)
FROM
	film
GROUP BY
	rating
HAVING
	COUNT(*) > 50;
--
SELECT rating, AVG(length), ROUND(length, 1) AS avg_length
FROM 
	film
GROUP BY 
	rating;
--
SELECT customer_id, COUNT(*)
FROM
	payment
GROUP BY
	customer_id
HAVING 
	COUNT(*) > 10;




	