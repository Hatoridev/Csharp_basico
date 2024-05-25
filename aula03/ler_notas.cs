using System;

namespace OlaMundo
{
    class Conclusao
    {
        static void Main()
        {
            float media = 0;

            Console.WriteLine("Olá, bem vindo ao programa de cálculo de média!");
            Console.WriteLine("Irei auxiliar você a calcular a média do seu aluno!");

            Console.WriteLine("Digite a primeira nota: ");
            int.TryParse(Console.ReadLine(), out int notal);

            Console.WriteLine("Digite a segunda nota: ");
            int.TryParse(Console.ReadLine(), out int nota2);

            Console.WriteLine("Digite a terceira nota: ");
            int.TryParse(Console.ReadLine(), out int nota3);

            media = (notal + nota2 + nota3) / 3;

            Console.WriteLine("A média do aluno é: {0}", media);

            if (media < 7)
            {
                Console.WriteLine("Aluno está em recuperação");
            }
            else
            {
                Console.WriteLine("Aluno aprovado");
            }
        }
    }
}

/*
Comentários explicativos:

1. `float media = 0;` declaração da variável `media` e inicialização com 0.

2. As mensagens de boas-vindas e instruções fornecem orientações ao usuário sobre o funcionamento do programa.

3. `int.TryParse(Console.ReadLine(), out int notal);` solicita e lê a primeira nota do aluno.

4. O mesmo padrão é seguido para a segunda e terceira notas (`nota2` e `nota3`).

5. `media = (notal + nota2 + nota3) / 3;` calcula a média das notas.

6. `Console.WriteLine("A média do aluno é: {0}", media);` exibe a média calculada.

7. A estrutura condicional `if` verifica se a média é menor que 7, e exibe a mensagem correspondente.
*/

