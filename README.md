# RedisCache
###### Install/run docker
###### Run Redis server using docker
```
  docker run --name my-redis -p 5002:6379 - d redis
```
###### Change/set connection string in the app

    "ConnectionStrings": {
      "Redis": "localhost:5002"
    }

###### Run commands on redis cli
```
  - docker exec -it my-redis sh
  - redis-cli
  - ping
```
