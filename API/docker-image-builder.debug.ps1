 docker build -t sapphire-api:debug -f dockerfile.debug .
 dotnet publish .\SapphireApi\ -o publish
 docker-compose -f docker-compose.debug.yml up -d --force-recreate