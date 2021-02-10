 dotnet publish .\SapphireApi\ -o publish
 docker build -t sapphire-api:latest -f dockerfile.debug .
 docker-compose -f docker-compose.debug.yml up -d --force-recreate