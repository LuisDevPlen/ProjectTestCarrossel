Documentação do Componente de Carrossel de Livros

Visão Geral
Este documento descreve a implementação de um componente de carrossel de livros reutilizável e responsivo, desenvolvido utilizando JavaScript ES6, jQuery, HTML5, CSS3, Bootstrap e a metodologia BEM. O componente foi integrado em um projeto ASP.NET MVC com C#.
Estrutura do Projeto
O projeto é composto por várias partes, incluindo a estrutura HTML, estilos CSS, scripts JavaScript e a lógica do controlador em C#. A seguir, detalhamos cada uma dessas partes.
Estrutura HTML
A estrutura HTML do carrossel é definida na view Index.cshtml. O carrossel utiliza o componente carousel do Bootstrap para criar um carrossel de livros com capas clicáveis que redirecionam para a página de detalhes do livro.
Estilos CSS
Os estilos CSS são definidos utilizando a metodologia BEM para garantir a modularidade e reutilização do código. Os estilos são adicionados no arquivo site.css.
CSS
Scripts JavaScript
Os scripts JavaScript são responsáveis por inicializar o carrossel e gerenciar o redirecionamento ao clicar nas capas dos livros. O código é adicionado no arquivo site.js.
Controlador ASP.NET MVC
O controlador BookController é responsável por fornecer os dados dos livros para a view. A lógica para obter os dados dos livros é definida no método GetBooks.

Este componente de carrossel de livros é totalmente reutilizável e responsivo, permitindo a exibição de capas de livros com seus títulos e redirecionamento para a página de detalhes ao clicar na capa. A implementação segue boas práticas de desenvolvimento, utilizando a metodologia BEM para estilização e integrando-se perfeitamente com o framework ASP.NET MVC.

