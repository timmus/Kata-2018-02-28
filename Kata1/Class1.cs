using System;
using System.Linq;

namespace Kata1
{
    public class Class1
    {
        public int chop(int needle, int[] haystack)
        {
            if (haystack == null || haystack.Length == 0)
            {
                return -1;
            }            

            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
