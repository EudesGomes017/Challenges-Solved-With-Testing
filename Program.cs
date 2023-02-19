using Treinamento_Logica;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Staircase staircase = new Staircase();

            int a = 6;
            int result = staircase.staircase(a);

            Console.WriteLine(result);
        }
    }
}
    



    
    


