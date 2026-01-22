using System;

namespace Aula038
{
    public class Animal
    {
        public string nome;

        // Adicionamos um construtor em Animal para aceitar o nome
        public Animal(string nome)
        {
            this.nome = nome;
        }

        // Adicionamos a palavra 'virtual' para permitir o override
        public virtual void EmitirSom()
        {
            Console.WriteLine("som de animal genérico");
        }
    }

    public class Cachorro : Animal
    {
        public string cor { get; set; }
        public string raca { get; set; }

        // Agora o base(nome) funcionará corretamente
        public Cachorro(string nome, string cor, string raca) : base(nome)
        {
            this.cor = cor;
            this.raca = raca;
        }

        // Agora o override é permitido porque o método pai é virtual
        public override void EmitirSom()
        {
            Console.WriteLine("Au! Au! Au!");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Cachorro cachorro = new Cachorro("Nick", "Branco", "Pastor Alemão");
            cachorro.EmitirSom(); // Saída: Au! Au! Au!
        }
    }
}

/*
O que mudou?

public virtual void EmitirSom(): O C# exige que você seja explícito. Se um método pode ser sobrescrito, ele deve ser virtual.

Construtor Animal(string nome): Quando você faz : base(nome), você está chamando o "pai" e entregando o nome a ele. Por isso, o pai precisa ter um construtor para receber esse dado.

Dica: Se você não quiser criar um construtor na classe Animal, você teria que remover o : base(nome) do cachorro e atribuir o nome manualmente com this.nome = nome; dentro do construtor do Cachorro.

Gostaria que eu explicasse mais sobre a diferença entre usar virtual/override e o uso do new para esconder métodos?

*/