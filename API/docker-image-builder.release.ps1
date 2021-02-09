 docker build -t sapphire-api:latest -f dockerfile.release .
 docker-compose -f docker-compose.release.yml up -d --force-recreate