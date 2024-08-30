Documentação do Componente de Carrossel de Livros
Visão Geral
Este documento descreve a implementação de um componente de carrossel de
livros reutilizável e responsivo, desenvolvido utilizando JavaScript ES6, jQuery,
HTML5, CSS3, Bootstrap e a metodologia BEM. O componente foi integrado
em um projeto ASP.NET MVC com C#.
Estrutura do Projeto
O projeto é composto por várias partes, incluindo a estrutura HTML, estilos
CSS, scripts JavaScript e a lógica do controlador em C#.
Estrutura HTML
A estrutura HTML do carrossel é definida na view Index.cshtml. O carrossel
utiliza o componente carousel do Bootstrap para criar um carrossel de livros
com capas clicáveis que redirecionam para a página de detalhes do livro.
Estilos CSS
Os estilos CSS são definidos utilizando a metodologia BEM para garantir a
modularidade e reutilização do código. Os estilos são adicionados no
arquivo site.css.
CSS
Scripts JavaScript
Os scripts JavaScript são responsáveis por inicializar o carrossel e gerenciar o
redirecionamento ao clicar nas capas dos livros. O código é adicionado no
arquivo site.js.
Controlador ASP.NET MVC
O controlador BookController é responsável por fornecer os dados dos livros
para a view. A lógica para obter os dados dos livros é definida no
método GetBooks.
Desenvolvi um carrossel de livros para um projeto ASP.NET MVC, focando em
criar algo que fosse fácil de usar, flexível e visualmente agradável. Usei a
metodologia BEM para organizar o CSS, o que torna o código mais reutilizável
e fácil de manter. Com o Bootstrap, garanti que o carrossel fosse totalmente
responsivo, funcionando bem em qualquer dispositivo.
Utilizei JavaScript e jQuery para dar vida ao carrossel, permitindo que, ao clicar
nas capas dos livros, os usuários sejam redirecionados diretamente para a
página de detalhes. Todo o design foi pensado para ser simples e eficiente, e
fiz questão de manter o código limpo para facilitar futuras manutenções. A
integração com o ASP.NET MVC foi cuidadosamente planejada, garantindo que
a lógica dos livros e a exibição no carrossel funcionem de maneira harmoniosa,
proporcionando uma experiência fluida para o usuário.
