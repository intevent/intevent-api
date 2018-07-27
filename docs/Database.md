#Database commands (MSSQL) **WORK IN PROGRESS**

## Starting the database container
```bash
docker run \
  -e 'ACCEPT_EULA=Y' \
  -e 'SA_PASSWORD=<YourStrong!Passw0rd>' \
  -p 1433:1433 \
  -v <host directory>:/var/opt/mssql \
  --name <container name> \
  -d \
  microsoft/mssql-server-linux:2017-CU8
```

## Connecting to the database container
```bash
docker exec -it <container name> "bash"
```
