// Imprime algo na tela
using dotNetComments.Models;

Console.WriteLine("comantário de uma linha.");

/*
    Comentário com várias linhas...
    pode 
    ir 
    colocando
    várias
    coisas.
*/
Console.WriteLine("comentário de varias linhas /* */ ...");

// Comentário com várias linhas... utilizando o ctrl + k e ctrl + c
// pode 
// ir 
// colocando
// várias
// coisas.
Console.WriteLine("comentário de várias linhas utilizando o ctrl + k e ctrl + c");

Pessoa p1 = new();

p1.Nome = "Leonardo Silva";

p1.ApresentarPessoa();

p1.Apresentar("Leonardo", "Cardoso");
