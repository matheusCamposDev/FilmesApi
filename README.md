# FilmesApi

API que permite criar, ler, editar e excluir um filme (CRUD) através de requisições.

# Tecnologias

1. .Net 5.0 :scream:
2. MySql 8.0 :+1:
3. Postman :smiley:

# CRUD

**CREATE**

Utilizando o Postman, devemos enviar uma requesição do tipo `post` para http://localhost:5000/filme

Exemplo Json:

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

**READ**

:warning: :runner: 

:construction: Em construção :construction: 
