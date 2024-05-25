using System;

namespace OlaMundo
{
    class Conclusao
    {
        static void Main()
        {
            bool opcao = true;

            Console.WriteLine("Olá, irei realizar a soma de números que você deseja até você desejar parar.");
            Console.WriteLine("Digite o valor inicial:");
            float.TryParse(Console.ReadLine(), out float inicial);

            while (opcao == true)
            {
                Console.WriteLine("Digite o número que deseja somar ao número inicial:");
                float.TryParse(Console.ReadLine(), out float n1);

                inicial += n1;

                Console.WriteLine("A soma até o momento é: {0}", inicial);
                Console.WriteLine("Deseja sair do programa? Digite 1 para sim ou 2 para não:");

                int.TryParse(Console.ReadLine(), out int saida);

                switch (saida)
                {
                    case 1:
                        Console.WriteLine("Saindo do Programa.");
                        opcao = false;
                        break;
                    case 2:
                        Console.WriteLine("Continua a Soma.");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida. Retornando para soma.");
                        break;
                }
            }
        }
    }
}

/*
Comentários explicativos:

1. `bool opcao = true;` declaração da variável `opcao` e inicialização com verdadeiro.

2. As mensagens de boas-vindas e instruções fornecem orientações ao usuário sobre o funcionamento do programa.

3. `float.TryParse(Console.ReadLine(), out float inicial);` solicita e lê o valor inicial para a soma.

4. O loop `while` continua até que a opção de saída seja escolhida pelo usuário.

5. Dentro do loop, o usuário é solicitado a inserir o número a ser somado ao valor inicial.

6. A variável `inicial` é atualizada com o novo valor inserido.

7. A soma atual é exibida.

8. O usuário é perguntado se deseja sair do programa.

9. Um switch é utilizado para processar a escolha do usuário.

10. O programa sai do loop caso a opção escolhida seja 1, caso contrário, continua a soma.
*/

