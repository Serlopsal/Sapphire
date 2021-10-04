#Sapphire (Testing-Project)

This is the api of project with the same name. The api was build with NetCore 5.0 and EntityFrameworkCore, with connection to MySQL database, all this as microservices hosted in docker, some bash scripts are included to facilitate the deployment of the docker containers.

## Environments
- debug
- mysql
- release

to change of environment it's necesary to change the system variable ASPNETCORE_ENVIRONMENT

### Example (MacOS)
 > export ASPNETCORE_ENVIRONMENT=DockerMySql
 
 ## Requirements
 - Docker installed
 
 or
 to run locally
 - NetCore 5.0
 - MySQL
 - Update Connection string in config file
