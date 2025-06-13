CREATE DATABASE app_viaggi;

CREATE TABLE utente (
utente_id int auto_increment primary key,
username varchar(255) UNIQUE NOT NULL,
email varchar(255) UNIQUE NOT NULL,
password varchar(255) NOT NULL,
telefono varchar(25),
ruolo_id int NOT NULL,
INDEX idx_ruolo (ruolo_id),
foreign key(ruolo_id) references ruolo(ruolo_id)
);

CREATE TABLE ruolo (
ruolo_id int auto_increment primary key,
tipo_ruolo varchar(15) UNIQUE NOT NULL
);

CREATE TABLE metodo_pagamento (
metodo_pagamento_id int auto_increment primary key,
tipo_pagamento varchar(100) UNIQUE NOT NULL
);

CREATE TABLE paese (
paese_id int auto_increment primary key,
nome_paese varchar(255) UNIQUE NOT NULL
);

CREATE TABLE citta (
citta_id int auto_increment primary key,
nome_citta varchar(255) NOT NULL,
paese_id int NOT NULL,
unique (nome_citta, paese_id),
foreign key(paese_id) references paese(paese_id)
);

CREATE TABLE destinazione (
destinazione_id int auto_increment primary key,
nome_destinazione varchar(100) NOT NULL,
descrizione text,
citta_id int NOT NULL,
foreign key(citta_id) references citta(citta_id),
unique (nome_destinazione, citta_id)
);

CREATE TABLE categoria (
categoria_id int auto_increment primary key,
nome_categoria varchar(100) UNIQUE NOT NULL
);

CREATE TABLE attrazione (
attrazione_id int auto_increment primary key,
nome_attrazione varchar(100) NOT NULL,
descrizione text,
prezzo decimal (7,2),
destinazione_id int NOT NULL,
unique (nome_attrazione, destinazione_id),
foreign key(destinazione_id) references destinazione(destinazione_id)
);

CREATE TABLE categoria_attrazione (
attrazione_id int NOT NULL,
categoria_id int NOT NULL,
primary key (attrazione_id, categoria_id),
foreign key(attrazione_id) references attrazione(attrazione_id),
foreign key(categoria_id) references categoria(categoria_id)
);

CREATE TABLE prenotazione (
prenotazione_id int auto_increment primary key,
data_prenotazione datetime DEFAULT current_timestamp,
stato_prenotazione varchar(100),
utente_id int,
foreign key(utente_id) references utente(utente_id)
);

CREATE TABLE pagamento (
pagamento_id int auto_increment primary key,
importo decimal (7,2) NOT NULL,
data_pagamento datetime DEFAULT current_timestamp,
prenotazione_id int UNIQUE,
foreign key (prenotazione_id) references prenotazione(prenotazione_id),
metodo_pagamento_id int,
foreign key(metodo_pagamento_id) references metodo_pagamento(metodo_pagamento_id)
);

CREATE TABLE prenotazione_destinazione (
prenotazione_id int,
destinazione_id int,
primary key (prenotazione_id, destinazione_id),
foreign key(prenotazione_id) references prenotazione(prenotazione_id),
foreign key(destinazione_id) references destinazione(destinazione_id)
);

-- INSERT INTO ruolo (tipo_ruolo) values ("utente");

/*DROP TABLE prenotazione;
DROP TABLE pagamento;
DROP TABLE prenotazione_destinazione;*/

/*DROP TABLE attrazione;
DROP TABLE categoria;
DROP TABLE categoria_attrazione;*/

-- select * from ruolo;

/*ALTER TABLE utente
MODIFY ruolo_id int DEFAULT 1 NOT NULL;*/

-- select * from utente;