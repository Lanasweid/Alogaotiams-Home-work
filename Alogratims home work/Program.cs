using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alogratims_home_work
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            int target = 7;
            int iterativeresult = IterativeBinary(array, target);
            if (iterativeresult != -1)
            {
                Console.WriteLine($"value {target}(iterative)is found in the index:{iterativeresult}");
            }
            else
            {
                Console.WriteLine($"value{target}(iterative)is not found");
            }

            int recursiveresult = RecursiveBinarySearch(array, target, 0, array.Length - 1);
            if (recursiveresult != -1)
            {
                Console.WriteLine($"value{target}(recursive) is found in index:{recursiveresult}");
            }
            else
            {
                Console.WriteLine($"value{target}(recursive) is not found");
            }
        }

        private static int RecursiveBinarySearch(int[] array, int target, int v1, int v2)
        {
            throw new NotImplementedException();
        }

        private static int IterativeBinary(int[] array, int target)
        {
            throw new NotImplementedException();
        }
    }
}
