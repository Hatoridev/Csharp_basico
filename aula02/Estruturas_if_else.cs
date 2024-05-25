using System;

namespace OlaMundo
{
    class Comparacoes
    {
        static void Main()
        {
            var n1 = 5;
            var n2 = 9;
            var n3 = 10;
            
            if (n1 < n2)
            {
                Console.WriteLine("Condição 1 é satisfeita!!");
                Console.WriteLine("Resultado da soma é {0}", n1 + n2);
            }

            if (n3 < n2)
            {
                Console.WriteLine(n3 + n2);
            }
            else
            {
                Console.WriteLine("Condição 2 não é satisfeita!!");
            }
        }
    }
}

/*
Comentários explicativos:

1. `if (n1 < n2)` verifica se `n1` é menor que `n2`.

2. `Console.WriteLine("Condição 1 é satisfeita!!");` exibe uma mensagem indicando que a condição 1 foi satisfeita.

3. `Console.WriteLine("Resultado da soma é {0}", n1 + n2);` exibe o resultado da soma de `n1` e `n2`.

4. `if (n3 < n2)` verifica se `n3` é menor que `n2`.

5. `Console.WriteLine(n3 + n2);` exibe a soma de `n3` e `n2` caso a condição seja verdadeira.

6. Caso a condição do segundo `if` não seja satisfeita, o bloco `else` é executado, exibindo uma mensagem indicando que a condição 2 não foi satisfeita.
*/

