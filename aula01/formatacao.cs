using System;

namespace OlaMundo
{
    class Formatacao
    {
        static void Main()
        {
            double x = 20.232;

            Console.WriteLine(x.ToString("F1"));
            Console.WriteLine(x.ToString("C"));
            Console.WriteLine(x.ToString("P"));
        }
    }
}


/*
Comentários explicativos:

1. A declaração `using System;` permite o uso das classes definidas no namespace `System`.

2. A declaração `namespace OlaMundo` define um escopo que contém um conjunto de objetos relacionados.

3. A classe `Formatacao` é definida dentro do namespace `OlaMundo`. Ela demonstra diferentes formas de formatar números.

4. O método `Main` é o ponto de entrada do programa. Quando o programa é executado, a execução começa neste método.

5. `double x = 20.232;` declara uma variável de ponto flutuante `x` e a inicializa com o valor 20.232.

6. `Console.WriteLine(x.ToString("F1"));` exibe o valor da variável `x` com uma casa decimal.

7. `Console.WriteLine(x.ToString("C"));` exibe o valor da variável `x` como uma moeda.
8. `Console.WriteLine(x.ToString("P"));` exibe o valor da variável `x` como uma porcentagem.
*/

