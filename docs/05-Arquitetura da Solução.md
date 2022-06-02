# Arquitetura da Solução

Definição de como o software é estruturado em termos dos componentes que fazem parte da solução e do ambiente de hospedagem da aplicação.

![Arquitetura da Solução](img/Arquitetura_Solução.png)

## Diagrama de Classes

O diagrama de classes ilustra graficamente como será a estrutura do software, e como cada uma das classes da sua estrutura estarão interligadas. Essas classes servem de modelo para materializar os objetos que executarão na memória.

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Classes”.

> - [Diagramas de Classes - Documentação da IBM](https://www.ibm.com/docs/pt-br/rational-soft-arch/9.6.1?topic=diagrams-class)
> - [O que é um diagrama de classe UML? | Lucidchart](https://www.lucidchart.com/pages/pt/o-que-e-diagrama-de-classe-uml)

## Modelo ER

O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.]

As referências abaixo irão auxiliá-lo na geração do artefato “Modelo ER”.

> - [Como fazer um diagrama entidade relacionamento | Lucidchart](https://www.lucidchart.com/pages/pt/como-fazer-um-diagrama-entidade-relacionamento)

## Esquema Relacional

O Esquema Relacional corresponde à representação dos dados em tabelas juntamente com as restrições de integridade e chave primária.
O esquema é composto por três tabelas. Uma tabela representando os usuários (administrativos) do sistema, com seus respectivos dados. E duas tabelas
para representar os carros elétricos e os carros a combustão. Os carros recebem como chave estrangeira a chave primária do usuário que o cadastrou, possibilitando
em sua seção, listar somente os carros cadastrados por ele.

![Esquema Relacional](img/esquema_relacional.png)


## Modelo Físico (DDL)
O arquivo (ddl.sql) contendo os comandos para a criação das tabelas do banco de dados relacional do projeto encontra-se dentro da pasta src/bd. 

## Instruções SQL de Manipulação do BD (DML)

O arquivo (dml.sql) contendo os scripts de manipulação de banco de dados está incluído dentro da pasta src\bd.

## Tecnologias Utilizadas

Tecnologias utilizadas para geração de conteúdo no lado servidor.

 - **Framework ASP.NET Core MVC** 

Outras tecnologias 

IDE (Ambiente de desenvolvimento integrado) 

Usado para o desenvolvimento do código. 

- **Visual Studio 2022** 

Ferramentas 

Usadas para a criação dos diagramas presentes na documentação do projeto. 

- **Figma** 

- **Lucidchart** 


Figura explicando como as tecnologias estão relacionadas ou como uma interação do usuário com o sistema vai ser conduzida, por onde ela passa até retornar uma resposta ao usuário.
![Web Application](https://user-images.githubusercontent.com/81269914/171063969-73541949-04d3-458b-96c9-a25b6375d656.png)


## Hospedagem

- **Heroku**

O Heroku utiliza o Git para realizar o deploy dos app.

> **Links Úteis**:
>
> - [Website com GitHub Pages](https://pages.github.com/)
> - [Programação colaborativa com Repl.it](https://repl.it/)
> - [Getting Started with Heroku](https://devcenter.heroku.com/start)
> - [Publicando Seu Site No Heroku](http://pythonclub.com.br/publicando-seu-hello-world-no-heroku.html)
