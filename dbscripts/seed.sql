
\connect blogdb

CREATE TABLE blog
(
    id serial PRIMARY KEY,
    title  VARCHAR (50)  NOT NULL,
    description  VARCHAR (100)  NOT NULL
);

CREATE TABLE "user"
(   
    id serial PRIMARY KEY,
    firstname  VARCHAR (50)  NOT NULL,
    lastname  VARCHAR (50)  NOT NULL
);

ALTER TABLE "user" OWNER TO bloguser;

Insert into "user"(firstname,lastname) values( 'Title 1','lastname 1');
Insert into "user"(firstname,lastname) values( 'Title 2','lastname 2');
Insert into "user"(firstname,lastname) values( 'Title 3','lastname 3');
Insert into "user"(firstname,lastname) values( 'Title 4','Description 4');
