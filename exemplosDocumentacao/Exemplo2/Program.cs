namespace ProgramaPrincipal
{


    // a classe é abstrata porém deve ser pública ou protegido 
    public abstract class Pessoa
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public Pessoa(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void MostrarDados()
        {
            Console.WriteLine($"Nome: {Name}");
            Console.WriteLine($"Idade: {Age}");
        }
    }
    
    public class Funcionario : Pessoa
    {
        public float Salario {get; set;}

        // BASE seria como um super() que tem no JavaScript
        public Funcionario(string name, int age, float salario) : base(name, age)
        {
            Salario = salario;
        }

        public void MostrarSalario()
        {
            Console.WriteLine($"Salário: R$ {Salario}");
        }
    } 

    public class Program{
        public static void Main()
        {
            Funcionario p1 = new("joão",24,1500);
            p1.MostrarDados();
            p1.MostrarSalario();
        }
    }
}
