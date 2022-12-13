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

Exemplo da resposta após a requisição:

    {
      "Id": 1
      "titulo": "De Volta Para o Futuro",
      "diretor": "Robert Zemeckis",
      "genero": "Ficção científica, aventura",
      "duracao": 116
    }
    
Desse modo conseguimos criar o primeiro filme utilizando a API e salvar dentro do banco de dados.

## Read - Parte 1

Agora usaremos o mesmo processo feito acima criando um novo filme para que possamos ver uma lista de filmes já criadas.

Exemplo json

    {
        "Titulo": "Homem de Ferro",
        "Diretor": "Jon Favreau",
        "Genero": "Ação, Ficção-científica",
        "Duracao": 126
    }


Exemplo da resposta após a requisição:

    {
        "id": 2,
        "titulo": "Homem de Ferro",
        "diretor": "Jon Favreau",
        "genero": "Ação, Ficção-científica",
        "duracao": 126
    }

Utilizando o Postman, devemos enviar uma requesição do tipo `get` para http://localhost:5000/filme

Não haverá necessidade de um exemplo json para a solicitação da lista de filmes já criada, pois a requisição apenas retorna uma lista.

Exemplo da resposta após a requisição:

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

Note que agora temos dois filmes registrados **De Volta Para o Futuro** e **Homem de Ferro**, cada um com seu próprio `id`.

## Read - Parte 2

A parte 2 do Read será apenas uma requisição, sem um exemplo json, já que o mesmo segue o padrão de uma requisição `get` para a url http://localhost:5000/filme só que agora através de um id nessa url.

Dentro do Postman faremos uma solicitação do tipo `get` para http://localhost:5000/filme/1. O valor 1 representa o id do filme **De Volta Para o Futuro** que foi criado anteriormente

Exemplo da resposta após a requisição:

    {
        "id": 1,
        "titulo": "De Volta Para o Futuro",
        "diretor": "Robert Zemeckis",
        "genero": "Ficção científica, aventura",
        "duracao": 116,
        "horaDaConsulta": "0001-01-01T00:00:00"
    }

Alterando o valor 1 para 2 receberemos o filme **Homem de Ferro** já que o `id: 2` diz respeito somente a este filme.

OBS: a hora da consulta deveria retornar um valor correspondente ao momento que é feito a requisição, mas o valor fica "zerado" por motivos desconhecido. :warning: Em manutenção.

## Update

:warning: :runner: 

:construction: Em construção :construction: 
