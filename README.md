Matheus Ribas de Lima
Eduardo Muniz Marodin
Warley Victor Maurício Rodrigues neto

1 - Validador de Senhas Fortes: Recebe uma senha do usuário faz as validações necessárias e retorna ser a senha é valida ou se deu um "erro".
2 - Tabuada Completa com Laço: Recebe um, número inteiro e faz a multiplicação dele mesmo de 1 a 10 em um for e mostra no console.
3 - Cálculo de Fatorial com while: Recebe um número inteiro e calcula o fatorial dele através de um while.
4 - Conversor de Temperaturas com Menu: Entra em um While no qual é mostrado o menu, A opção é escolhida no Switch e a converção é mostrada no console.
5 - Verificador de Palíndromos: Primeiro recebemos uma frase, depois Formatamos essa frase tirando pontuação e espaços, e depois removemos os acentos. Após isso, invertemos a frase formatada e verificamos se ela é igual a frase. Se sim, é mostrado que é um palíndromo.
6 - Cadastro Simples de Produtos: Criamos duas classes, uma de produtos onde é criado o produto, com nome, preço e quantidade e a função que multiplica a quantidade em estoque pelo valor (Valor total). Colocamos esses produtos em uma lista e depois percorremos ela mostrando o item, o preço e o valor total. 
7 - Soma de Números Pares de um Array: Primeiro com um for coletamos 10 itens do usuário e guardamos em uma lista. Após isso percorremos a lista com um foreach e verificamos se o MOD 2 do número é igual a 0 (significa que ele é par), se sim somamos ao total.
8 - Cálculo de IMC com Classificação: Pedimos o peso e a altura do usuário, e somamos o IMC (peso / (altura * altura)). Classificamos o usuário e mostramos a situação atual.
9 - Jogo da Adivinhação: Geramos um número de 1 a 100, e dentro de um while contamos as tentativas do usuário e verificamos se ele acertou ou não. Se o usuário acertar mostramos a quantidade de tentativas e o número correto.
10 - Lista de Tarefas (To-Do List): Esse código temos duas listas, a de tarefas e a de concluidos. Temos um While para mostrar o menu e dentro um switch para pegar a opção que o usuário escolheu. Assim dentro de cada caso é realizado a ação conforme a escolha.


EXPLICAÇÂO MAIS COMPLETA DOS EXERCICIOS 2 e 4:

2 - Nesse exercícios recebemos um número inteiro e já convertemos para inteiro (pois recebemos ele como um texto), coletemos o número na mesma linha para não ter código desnecessário. Usamos um for (Tipo de loop) pela facilidade de definir 10 repetições em um loop, e dentro do for, mostramos no terminal o numero X o numero atual do loop interpolando na string a operação matematica.

4 - E nesse exercício colocamos dentro de um while(true) (Tipo de Loop) para que apenas saia quando o usuário selecionar a opção sair. Mostramos o menu e coletamos o número já convertendo na mesma variavel novamente, e em seguida, colocamos ela no Switch (Verifica se a opção é igual a um dos casos dentro dele).
Dentro do case 1 do switch, coletamos um numero que representa a temperatura em Celsius e convertemos ela pra fahrenheit com a fórmula ((celsius * 9/5) + 32), depois mostramos a temperatura convertida para o usuário.
Dentro do case 2, Coletamos um número que representa o fahrenheit e fazemos a fórmula reversa ((fahrenheit - 32) * 5/9), em seguida, mostramos a temperatura em celsius.
Temos o o case 0, que é para sair, que basicamente mostra uma mensagem de saindo e retorna, oque encerra o código.
E temos o ultimo default, que caso não entre em nenhum dos casos acima, cai no default e mostra uma mensagem de opção inválida e volta para o menu.