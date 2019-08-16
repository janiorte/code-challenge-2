using System.Linq;

namespace Fenergo
{
    class Program
    {
        public static bool SplitArray(int[] input)
        {
            var arrOrdered = input.OrderByDescending(x => x).ToArray();

            var intSumGroup1 = 0;
            var intSumGroup2 = 0;

            for(var i = 0; i < arrOrdered.Length; i++)
            {
                if(intSumGroup1 <= intSumGroup2)
                {
                    intSumGroup1 += arrOrdered[i];
                }
                else
                {
                    intSumGroup2 += arrOrdered[i];
                }
            }

            return intSumGroup1 == intSumGroup2;
        }

        static void Main()
        {
            SplitArray(new[] { 3, 4, 5, 7, 9, 11, 25, 12, 28, 70, 36, 38, 39 , 13});
        }
    }
}
