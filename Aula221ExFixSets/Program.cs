namespace Aula221ExFixSets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Isntanciando os cursos como conjuntos de inteiros
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int cod = int.Parse(Console.ReadLine()); //Recebendo o código do aluno
                courseA.Add(cod); //Adicionando o código no conjunto do curso 
            }

            Console.Write("How many students for course B? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                courseB.Add(cod); //Adicionando o código no conjunto do curso 
            }

            Console.Write("How many students for course C? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                courseC.Add(cod); //Adicionando o código no conjunto do curso 
            }

            HashSet<int> all = new HashSet<int>(courseA); //Instanciando um novo conjunto de inteiro all recebendo como paramento o conjunto courseA
            all.UnionWith(courseB); //Fazendo a união entre all e CourseB (ou seja, pegando todos os valores exceto os que estão repetidos nos dois conjuntos)
            all.UnionWith(courseC); //Fazendo novamento a união entre all e CourseC (ou seja, pegando todos os valores exceto os que estão repetidos nos dois conjuntos)
            Console.WriteLine("Total students: " + all.Count); //Imprimindo na tela a soma do tamaho do conjunto completo (all)

        }
    }
}