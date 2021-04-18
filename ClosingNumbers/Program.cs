using System;

namespace ClosingNumbers
{
    class MainClass
    {
        public static bool isClosingNum(string setOfNums)
        {
            if (setOfNums.Length % 2 != 0)
            {
                return false;
            }
            for (int i = 0; i < setOfNums.Length; i++)
            {
                for (int j = setOfNums.Length-1; j > 0; j--)
                {
                    
                    if (setOfNums[i] != setOfNums[j])
                    {
                        return false;
                    }
                    i++;
                }
            }

            return true;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(isClosingNum("654321123456"));
        }
    }
}
