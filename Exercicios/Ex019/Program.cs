using System;

class Program
{
    static void Main()
    {
        char sexo = 'A';
        int idade, cont = 0;
        // Adicionei = 0f na soma para permitir o cálculo acumulativo
        float peso, altura, media = 0f, alto = 0f, pesado = 0f, soma = 0f;
        
        string nome, HomemMaisAlto = "", MulherMaisPesada = "";

        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.Write("Nome do atleta (ou 'fim' para sair): ");
        nome = Console.ReadLine();

        while (nome.ToLower() != "fim")
        {
            Console.Write("Idade: ");
            idade = int.Parse(Console.ReadLine());
            
            Console.Write("Peso: ");
            peso = float.Parse(Console.ReadLine());

            Console.Write("Altura: ");
            altura = float.Parse(Console.ReadLine());

            // O loop de sexo agora funcionará para todos os atletas 
            // porque resetamos o valor ao final do ciclo
            while (sexo != 'M' && sexo != 'F')
            {
                Console.Write("Sexo [M/F]: ");
                sexo = char.Parse(Console.ReadLine().ToUpper());
            }

            soma += idade;
            cont += 1;

            if (sexo == 'M')
            {
                if (altura > alto)
                {
                    alto = altura;
                    HomemMaisAlto = nome;
                }
            }
            else if (sexo == 'F') // Usei else if para otimizar, já que não pode ser os dois
            {
                if (peso > pesado)
                {
                    pesado = peso;
                    MulherMaisPesada = nome;
                }
            }

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            
            // IMPORTANTE: Resetamos o sexo para 'A' para o loop de validação
            // funcionar na próxima repetição
            sexo = 'A'; 

            Console.Write("Nome do atleta: ");
            nome = Console.ReadLine();
        }

        // Verificação para evitar erro de divisão por zero se nenhum atleta for inserido
        if (cont > 0)
        {
            media = soma / cont;
            Console.WriteLine($"\nAo todo foram {cont} atletas.");
            Console.WriteLine($"Média de idade do grupo: {media:F1} anos.");
            Console.WriteLine($"O nome do atleta masculino mais alto é: {HomemMaisAlto} ({alto}m)");
            Console.WriteLine($"A atleta feminina mais pesada é: {MulherMaisPesada} ({pesado}kg)");
        }
        else
        {
            Console.WriteLine("Nenhum atleta foi cadastrado.");
        }
    }
}