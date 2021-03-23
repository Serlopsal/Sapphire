 dotnet publish ./SapphireApi/ -o publish
 docker build -t sapphire-api:debug -f dockerfile.debug .
 docker-compose -f docker-compose.mysql.yml up -d --force-recreate