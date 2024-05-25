using System;

namespace OlaMundo
{
    class Atividades
    {
        static void Main()
        {
            var atividade1 = true;
            var atividade2 = false;
            
            var todas = atividade1 && atividade2;
            Console.WriteLine("Fez todas as atividades? {0}", todas);
            
            var umaApenas = atividade1 || atividade2;
            Console.WriteLine("Fez pelo menos uma das atividades? {0}", umaApenas);
            
            Console.WriteLine("Não fez nenhuma? {0}", !umaApenas);
        }
    }
}

/*
Comentários explicativos:

1. `var atividade1 = true;` declara uma variável `atividade1` e a inicializa como verdadeira.

2. `var atividade2 = false;` declara uma variável `atividade2` e a inicializa como falsa.

3. `var todas = atividade1 && atividade2;` verifica se todas as atividades foram feitas utilizando o operador lógico "E" (AND).

4. `Console.WriteLine("Fez todas as atividades? {0}", todas);` exibe se todas as atividades foram feitas.

5. `var umaApenas = atividade1 || atividade2;` verifica se pelo menos uma atividade foi feita utilizando o operador lógico "OU" (OR).

6. `Console.WriteLine("Fez pelo menos uma das atividades? {0}", umaApenas);` exibe se pelo menos uma atividade foi feita.

7. `Console.WriteLine("Não fez nenhuma? {0}", !umaApenas);` exibe se nenhuma atividade foi feita, utilizando o operador lógico de negação "NÃO" (NOT).
*/

