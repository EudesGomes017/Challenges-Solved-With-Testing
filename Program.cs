using Treinamento_Logica;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            ExerciseReturnsSymbols exerciseReturnsSymbols = new ExerciseReturnsSymbols();

            var result = exerciseReturnsSymbols.ExerciseReturns();

            Console.WriteLine(result);
        }
    }
}
    



    
    


