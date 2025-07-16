-- tutti i film che hanno un rental rate maggiore della media del rental rate stesso
SELECT
	film.title,
	film.rental_rate
FROM
	film
WHERE
	film.rental_rate > (
    SELECT AVG(film.rental_rate) -- AVG sempre nel SELECT
    FROM film
    );

-- Elenca i nomi e cognomi degli attori che hanno recitato in almeno un film della categoria "Action"
SELECT CONCAT(actor.first_name, ' ', actor.last_name) AS NomeCognome -- confronto con la subquery
FROM
	actor
WHERE
	-- category.name = ()
    actor.actor_id IN (  -- soltanti id degli attori che hanno recitato in action, quindi lista
		SELECT fa.actor_id
		FROM film_actor fa
		JOIN film f ON fa.film_id = f.film_id
		JOIN film_category fc ON f.film_id = fc.film_id
		JOIN category c ON fc.category_id = c.category_id
		WHERE c.name = 'Action'
    );

/* Approccio "filtrante": chiedi al DB di selezionare solo gli attori il cui actor_id è tra quelli trovati dalla subquery.
La subquery genera un insieme di ID, che viene poi confrontato.
Tende a essere più leggibile se vuoi solo il risultato filtrato e non stai usando molte colonne.
Meno flessibile: difficile mostrare anche i titoli dei film, categorie, ecc., senza complicare la subquery.*/

-- senza la subquery : Ogni riga rappresenta un match attore-film-categoria.
    