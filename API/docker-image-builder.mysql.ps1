docker build -t sapphire-api:debug -f dockerfile.debug .
docker-compose -f docker-compose.mysql.yml up -d --force-recreate
docker logs -f -n 10 api_api_1