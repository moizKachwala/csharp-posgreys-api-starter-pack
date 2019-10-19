# csharp-postgreysdb-api-starter-pack
Starter pack with C# postgreysdb Docker

It will perform basic CRUD operations. Postman suite attached in the repository topcoder-suite.json


## Steps to Run
1. Clone the repository
2. Install Docker
3. execute command `docker-compose up`
4. It will pull the postgreys image and run the app.


## Steps to Rebuild
`docker-compose build`

## Steps to stop the container
`docker-compose down`

### MONGO Configuration in docker compose

`postgreysDB__DATABASE` - Database Name

`postgreysDB__Host` - Database Host

`postgreysDB__PORT` - Database Port

`postgreysDB__USER` - Database User

`postgreysDB__PASSWORD` - Database Password

# API's dcoumentation
`http://localhost:5000/api/users`

### GET All Users
`GET http://localhost:5000/api/users`

### Create User
`POST http://localhost:5000/api/users`

`{
	"firstName": "john",
	"lastName": "smith"
}`

### PUT User
`PUT http://localhost:5000/api/users/1`

`{
	"firstName": "john",
	"lastName": "wills"
}`

### GET User
`GET http://localhost:5000/api/users/1`


### DELETE User
`DELETE http://localhost:5000/api/users/1`


### Postman Suite
`top-coder-postgreys-starter.postman_collection.json`