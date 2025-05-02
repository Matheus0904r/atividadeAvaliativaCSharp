List<string> tarefas = new List<string>();
List<string> concluidas = new List<string>();

Console.WriteLine("Bem-vindo ao gerenciador de tarefas!");

while (true) {
    Console.WriteLine("1 - Adicionar tarefa");
    Console.WriteLine("2 - Listar tarefas");
    Console.WriteLine("3 - Marcar tarefa como concluída");
    Console.WriteLine("4 - Sair");
    Console.Write("Escolha uma opção: ");
    string opcao = Console.ReadLine();

    switch (opcao) {
        case "1":
            Console.WriteLine();
            Console.Write("Digite a nova tarefa: ");
            string novaTarefa = Console.ReadLine();
            tarefas.Add(novaTarefa);
            Console.WriteLine("Tarefa adicionada!");
            Console.WriteLine();
            break;

        case "2":
            Console.WriteLine();
            Console.WriteLine("Tarefas pendentes:");
            if (tarefas.Count == 0) {
                Console.WriteLine("Nenhuma tarefa pendente.");
            }

            for (int i = 0; i < tarefas.Count; i++) {
                Console.WriteLine($"{i + 1} - {tarefas[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("Tarefas concluídas:");
            if (concluidas.Count == 0) {
                Console.WriteLine("Nenhuma tarefa concluída.");
            }
            for (int i = 0; i < concluidas.Count; i++) {
                Console.WriteLine($"✓ {concluidas[i]}");
            }

            Console.WriteLine();

            break;

        case "3":
            Console.WriteLine();

            if (tarefas.Count == 0) {
                Console.WriteLine("Nenhuma tarefa para concluir.");
                Console.WriteLine();
                break;
            }

            Console.WriteLine();
            Console.WriteLine("Tarefas pendentes:");
            for (int i = 0; i < tarefas.Count; i++) {
                Console.WriteLine($"{i + 1}. {tarefas[i]}");
            }

            Console.Write("Digite o número da tarefa a concluir: ");
            int indice = int.Parse(Console.ReadLine());
            if (indice < 1 || indice > tarefas.Count) {
                Console.WriteLine("Número inválido. Tente novamente.");
                Console.WriteLine();
                break;
            }
            string concluida = tarefas[indice - 1];
            tarefas.RemoveAt(indice - 1);
            concluidas.Add(concluida);
            Console.WriteLine("Tarefa marcada como concluída!");
            Console.WriteLine();

            break;

        case "4":
            Console.WriteLine("Encerrando o programa...");
            return;

        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
}