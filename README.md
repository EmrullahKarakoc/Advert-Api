# Advert Api

```bash
docker-compose up -d
```

## Endpoints

```python

[HttpGet]
Adverts/all
sample curl: curl -X GET "https://localhost:44301/all?limit=50" -H  "accept: text/plain"
*default page value = 0 and limit value=50. First page page nukber is 0.


[HttpGet]
Adverts/{advertId} 
sample curl: curl -X GET "https://localhost:44301/15501819" -H  "accept: text/plain"
 


[HttpPost]
/visit
sample curl: curl -X POST "https://localhost:44301/visit" -H  "accept: text/plain" -H  "Content-Type: application/json" -d "{\"advertId\":15763769}"



```
