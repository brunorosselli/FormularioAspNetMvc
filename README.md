# TESTE TRAINEE RCB

Teste para a vaga de Trainee da RCB.

Trainee:

- Criar um projeto utilizando ASP.NET (fique à vontade para escolher a versão), contendo um front-end de apenas um módulo funcional e envio de dados para o back-end;

- O back-end deve ser feito em C# e o front-end utilizando jQuery como biblioteca;

               

Módulo "criar":

- Criar um formulário para envio dos dados de uma pessoa com as seguintes informações: CPF, nome e e-mail.

- Os campos de CPF e e-mail devem ter máscaras aplicadas em seus elementos de input;

- Os mesmos campos citados anteriormente devem ser validados no back-end e retornar um erro caso não sejam válidos. Podem ser validados no front-end também, mas a validação no back-end é imprescindível.

- Ao finalizar o envio dos dados, exibir uma mensagem para o usuário indicando que os dados foram enviados com sucesso.

                               

Não há limitação de uso de bibliotecas externas ou arquivos CSS prontos (como Bootstrap ou Material UI); fique à vontade para adaptá-las ao seu uso no projeto.

                               

O programa pode (não deve) persistir os dados. Um JSON local do projeto pode ser usado, não precisa persistir os dados em um banco de dados.

Se optar por implementar a persistência dos dados em um banco de dados, utilize SQL Server ou MySQL e inclua o script de criação das tabelas no repositório.

As tecnologias usadas foram: 

 - ASP.NET
 - C#
 - jQuery
 - Bootstrap
 - MySQL Server
 
Esse sistema foi desenvolvido por Bruno Eduardo Martins Rosselli.

QUERY DO DATABASE: 

CREATE DATABASE RCB;

USE RCB;

CREATE TABLE PESSOAS (
CPF VARCHAR(20) PRIMARY KEY,
NOME VARCHAR (100),
EMAIL VARCHAR (100)
);

SELECT * FROM PESSOAS

