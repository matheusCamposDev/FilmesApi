# FilmesApi

API que permite criar, ler, editar e excluir um filme (CRUD) através de requisições.

# Tecnologias

1. .Net 5.0 :scream:
2. MySql 8.0 :+1:
3. Postman :smiley:

# CRUD

Esta seção explicará como funciona basicamente o CRUD de FilmesAPI, mostrando como fazer uma requisição e a resposta através do aplicativo Postman.

## Create

Utilizando o Postman, devemos enviar uma requesição do tipo `post` para http://localhost:5000/filme

Exemplo json:

    {
      "Titulo": "De Volta Para o Futuro",
      "Diretor": "Robert Zemeckis",
      "Genero": "Ficção científica, aventura",
      "Duracao": 116
    }

Ao clicar no botão `send` haverá uma reposta de `Status: 201 created` e uma informação referente ao json criado com `"id": 1`

Corpo da resposta:

    {
      "Id": 1
      "titulo": "De Volta Para o Futuro",
      "diretor": "Robert Zemeckis",
      "genero": "Ficção científica, aventura",
      "duracao": 116
    }
    
Desse modo conseguimos criar o primeiro filme utilizando a API e salvar dentro do banco de dados.

## Read

Agora usaremos o mesmo processo feito acima criando um novo filme para que possamos ver uma lista de filmes já criadas.

Exemplo json

    {
        "Titulo": "Homem de Ferro",
        "Diretor": "Jon Favreau",
        "Genero": "Ação, Ficção-científica",
        "Duracao": 126
    }

Podemos realizar a busca dos filme de duas maneiras:

1. Fazendo uma requisição do tipo `get` à url http://localhost:5000/filme que retornará uma lista de filmes

Se houver uma lista de filmes retornará: `Status: 200 OK`

Corpo da resposta:

    [
        {
            "id": 1,
            "titulo": "De Volta Para o Futuro",
            "diretor": "Robert Zemeckis",
            "genero": "Ficção científica, aventura",
            "duracao": 116
        },
        {
            "id": 2,
            "titulo": "Homem de Ferro",
            "diretor": "Jon Favreau",
            "genero": "Ação, Ficção-científica",
            "duracao": 126
        }
    ]

2. Fazendo uma requisição do tipo `get` à url http://localhost:5000/filme/id onde `id` será substituído pelo valor 1

Se houver o `id` de filmes retornará: `Status: 200 OK`

Corpo da resposta:

    {
        "id": 1,
        "titulo": "De Volta Para o Futuro",
        "diretor": "Robert Zemeckis",
        "genero": "Ficção científica, aventura",
        "duracao": 116,
        "horaDaConsulta": "0001-01-01T00:00:00"
    }

Caso não existir o `id` informado retornará `Status: 404 Not Found`

OBS: A busca por id retorna um campo a mais `horaDaConsulta` que está retornando sempre um tempo padrão. :warning: bug em correção.

## Update

Suponda que queriamos registrar o filme **De Volta Para o Futuro II** e por engano registramos o primeiro filme da franquia iremos atualizar apenas o título e a duração do filme.

Mais uma vez com Postman enviaremos uma requisição, agora utilizando o tipo `put`, para url http://localhost:5000/filme/1 

Exemplo json

    {
        "titulo": "De Volta Para o Futuro II",
        "diretor": "Robert Zemeckis",
        "genero": "Ficção científica, aventura",
        "duracao": 108
    }

Em seguida haverá um resposta `Status: 204 No Content` e ao buscar o filme pelo `id: 1` ou a lista completa de filmes encontraremos o filme **De Volta Para o Futuro II** com título e duração alterados.

Corpo da resposta:

    {
        "id": 1,
        "titulo": "De Volta Para o Futuro II",
        "diretor": "Robert Zemeckis",
        "genero": "Ficção científica, aventura",
        "duracao": 108,
        "horaDaConsulta": "0001-01-01T00:00:00"
    }

## Delete

Por fim, deletaremos um dos filmes e mais uma vez utilizando o Postman enviando uma requisição do tipo `delete` para a url 
http://localhost:5000/filme/1

Em seguida haverá um resposta `Status: 204 No Content` e ao buscar o filme pelo `id: 1` ou a lista completa de filmes não encontraremos mais o filme **De Volta Para o Futuro II**.

:warning: :runner: 

:construction: Em construção :construction: 
