using System.Collections;

namespace Treinamento_Logica
{
    public class MaximoValues
    {
        public void MaximoAndMinimis(List<int> arr)
        {

            for (int i = 0; i < arr.Count; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

           
            // Ordena os números em ordem crescente
             arr.Sort();

            int minSum = arr[0] + arr[1] + arr[2] + arr[3];
            int maxSum = arr[1] + arr[2] + arr[3] + arr[4];
    
            // List<int> resultFinaly =  new List<int> {minSum, maxSum};
            Console.WriteLine("{0} {1}", minSum, maxSum);

        }
    }
}
