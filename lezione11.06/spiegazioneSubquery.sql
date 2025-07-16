SELECT
	title,
    length
FROM
	film
WHERE 
	length > (
		SELECT AVG(length)
        FROM film
	);
--
SELECT
	film.title,
    actor_count
FROM (
	SELECT film_actor.film_id, COUNT(*) AS actor_count
    FROM film_actor
    GROUP BY film_actor.film_id
) AS film_actor_count -- count degli attori per ogni film
JOIN
	film
ON
	film_actor_count.film_id = film.film_id
ORDER BY
	actor_count DESC;
-- una subquery la utilizziamo con WHERE o con FROM o con HAVING
	