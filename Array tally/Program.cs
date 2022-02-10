using System;

namespace Array_tally {
    /// <summary>
    /// creates an array and the for/foreach go thru each data in the array and adds them all together in the sum variable
    /// </summary>
    class Program {
        static void Main(string[] args) { 
            int[] ages = { 60, 60, 40, 23, 22, 17, 16, 13, 10 };
            
            int sum = 0;
            for (int i = 0; i < ages.Length; i++) {
                sum = sum + ages[i];
            }
            sum = 0;
            foreach(int age in ages) {
                sum = sum + age;
            }
            Console.WriteLine($"sum is {sum}");
        }
    }
}
