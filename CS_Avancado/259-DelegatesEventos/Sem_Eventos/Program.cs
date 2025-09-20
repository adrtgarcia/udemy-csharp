using Sem_Eventos;

Console.WriteLine("\n ### Exemplo monitoração de limite sem usar Eventos ###\n");
Console.ReadKey();

var estoqueCanetas = new Estoque_SemEvento("Caneta Azul", 200, 10);
var estoqueCadernos= new Estoque_SemEvento("Caderno Espiral", 100, 5);

estoqueCanetas.Retirar(195); // Estoque vai para 15, abaixo do nível crítico de 20.
estoqueCadernos.Retirar(80); // Estoque vai para 20, acima do nível crítico de 5
estoqueCadernos.Retirar(17); // Estoque vai para 3, abaixo do nível crítico de 5

Console.WriteLine("\nProcesso concluído. Pressione algo para sair.");
Console.ReadKey();