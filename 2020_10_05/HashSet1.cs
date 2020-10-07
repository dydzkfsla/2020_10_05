using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_10_05
{
    class HashSet1
    {
        static void Main()
        {
            HashSet<int> lotto = new HashSet<int>();
            Random rnd = new Random();

            while(true)
            {
                lotto.Add(rnd.Next(1, 47));
                if (lotto.Count > 6)
                    break;
            }
            foreach(int temp in lotto)
            {
                Console.WriteLine(temp);
            }
        }
    }
}
