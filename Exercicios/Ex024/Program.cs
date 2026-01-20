namespace ex024
{


    public class CadAluno
    {
        public string Nome {get;set;}
        public float[] Notas {get;set;}
    }


    public class Program{
        public static void Main()
        {
            int tam = 2;
            CadAluno[] alunos = new CadAluno[tam];
            
            int i,j;

            for(i = 0; i < alunos.Length; i++)
            {
                alunos[i] = new(){Notas = new float[4]};

                Console.Write("informe o nome do aluno: ");
                alunos[i].Nome = Console.ReadLine();

                for(j = 0; j < alunos[i].Notas.Length; j++)
                {
                    Console.Write($"informe a nota {j+1}: ");
                    alunos[i].Notas[j] = float.Parse(Console.ReadLine());
                }
            }

            for(i = 0; i < alunos.Length; i++)
            {
                
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");   
                Console.WriteLine($"Aluno: {alunos[i].Nome}");

                for(j = 0; j < alunos[i].Notas.Length; j++)
                {
                    Console.WriteLine($"Nota {j+1}: {alunos[i].Notas[j]}");
                }
                
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            }
        }
    }
}