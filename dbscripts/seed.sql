
\connect userdb

CREATE TABLE users
(   
    id serial PRIMARY KEY,
    firstname  VARCHAR (50)  NOT NULL,
    lastname  VARCHAR (50)  NOT NULL
);