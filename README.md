<h1 align="left">Advert Api</h1>

###

```bash
docker-compose up -d

Swagger: http://localhost:44301/swagger/index.html
pgAdmin: http://localhost:5051/browser/
```

###

<h2 align="left">Endpoints</h2>

###

```python

[HttpGet]
Adverts/all
sample curl: curl -X GET "https://localhost:44301/all?limit=50" -H  "accept: text/plain"
*default values -->  page=0 - limit=50 
*First page page number is 0.


[HttpGet]
Adverts/{advertId} 
sample curl: curl -X GET "https://localhost:44301/15501819" -H  "accept: text/plain"
 


[HttpPost]
/visit
sample curl: curl -X POST "https://localhost:44301/visit" -H  "accept: text/plain" -H  "Content-Type: application/json" -d "{\"advertId\":15763769}"



```

###

<h2 align="left">Tech Stack</h2>

###

<div align="left">
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" height="60" alt="csharp logo"  />
  <img width="12" />
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/dotnetcore/dotnetcore-original.svg" height="60" alt="dotnetcore logo"  />
  <img width="12" />
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/postgresql/postgresql-original.svg" height="60" alt="postgresql logo"  />
  <img width="12" />
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/docker/docker-original.svg" height="60" alt="docker logo"  />
    <img width="12" />
  <img src="https://i.ibb.co/Nn4qQFK/automapper.png" height="60" alt="automapper logo"  />
      <img width="12" />
  <img src="https://i.ibb.co/n1nT4XG/dapper.jpg" height="60" alt="dapper logo"  />
  
  
</div>

###