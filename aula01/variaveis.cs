using System;

namespace OlaMundo
{
    class Variaveis
    {
        static void Main()
        {
            int x = 4;
            double y = 3.3;
            const double frequencia = 60;
            double area = x * y;

            Console.WriteLine("A área do quadrado é " + area);
        }
    }
}

/*
Comentários explicativos:

1. A declaração `using System;` permite o uso das classes definidas no namespace `System`.

2. A declaração `namespace OlaMundo` define um escopo que contém um conjunto de objetos relacionados.

3. A classe `Variaveis` é definida dentro do namespace `OlaMundo`. Ela demonstra a declaração e uso de variáveis.

4. O método `Main` é o ponto de entrada do programa. Quando o programa é executado, a execução começa neste método.

5. `int x = 4;` declara uma variável inteira `x` e a inicializa com o valor 4.

6. `double y = 3.3;` declara uma variável de ponto flutuante `y` e a inicializa com o valor 3.3.

7. `const double frequencia = 60;` declara uma constante `frequencia` de ponto flutuante com o valor 60.

8. `double area = x * y;` calcula a área multiplicando `x` por `y` e armazena o resultado em `area`.

9. `Console.WriteLine("A área do quadrado é " + area);` exibe o valor da variável `area` no console com a mensagem "A área do quadrado é ".
*/

