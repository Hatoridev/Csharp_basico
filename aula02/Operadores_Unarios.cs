using System;

namespace OlaMundo
{
    class OperadoresUnarios
    {
        static void Main()
        {
            var X = false;
            var n1 = 6;
            var n2 = 5;
            var n3 = 7;
            var n4 = 8;
            
            Console.WriteLine(!X);
            n3++;
            Console.WriteLine(n3);
            n4--;
            Console.WriteLine(n4);
            Console.WriteLine(n2 == --n1);
            Console.WriteLine(n2-- == ++n1);
        }
    }
}

/*
Comentários explicativos:

1. `Console.WriteLine(!X);` exibe o resultado da negação lógica da variável `X`.

2. `n3++;` incrementa a variável `n3` em uma unidade.

3. `Console.WriteLine(n3);` exibe o valor da variável `n3` após o incremento.

4. `n4--;` decrementa a variável `n4` em uma unidade.

5. `Console.WriteLine(n4);` exibe o valor da variável `n4` após o decremento.

6. `Console.WriteLine(n2 == --n1);` compara se `n2` é igual a `n1` após o decremento de `n1`.

7. `Console.WriteLine(n2-- == ++n1);` compara se `n2` é igual a `n1` antes do incremento de `n2`.
*/

