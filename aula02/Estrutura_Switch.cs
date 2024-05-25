using System;

namespace OlaMundo
{
    class EstruturaSwitch
    {
        static void Main()
        {
            Console.WriteLine("Qual a nota você dá para o prato? 0, 5, ou 10");
            Int32.TryParse(Console.ReadLine(), out int nota);

            switch (nota)
            {
                case 0:
                    Console.WriteLine("Comida muito ruim!");
                    break;
                case 5:
                    Console.WriteLine("Comida razoável.");
                    break;
                case 10:
                    Console.WriteLine("Comida muito boa.");
                    break;
                default:
                    Console.WriteLine("Nota inexistente.");
                    break;
            }
        }
    }
}

/*
Comentários explicativos:

1. A mensagem "Qual a nota você dá para o prato? 0, 5, ou 10" é exibida para solicitar ao usuário que insira a nota do prato.

2. `Int32.TryParse(Console.ReadLine(), out int nota);` lê a entrada do usuário e tenta converter para um valor inteiro, armazenando-o na variável `nota`.

3. `switch (nota)` inicia a estrutura switch com base no valor da variável `nota`.

4. `case 0:` verifica se a nota é igual a 0 e executa o bloco de código seguinte se a condição for verdadeira.

5. `Console.WriteLine("Comida muito ruim!");` exibe a mensagem indicando que a comida é muito ruim.

6. `break;` encerra o bloco de código do case.

7. O mesmo padrão é seguido para os outros cases (5 e 10) e para o caso padrão (default), onde é exibida a mensagem "Nota inexistente" caso nenhuma das opções anteriores seja correspondida.
*/

