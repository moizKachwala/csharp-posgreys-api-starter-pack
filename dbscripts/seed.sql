
\connect blogdb

CREATE TABLE Users
(   
    id serial PRIMARY KEY,
    firstname  VARCHAR (50)  NOT NULL,
    lastname  VARCHAR (50)  NOT NULL
);

ALTER TABLE Users OWNER TO bloguser;