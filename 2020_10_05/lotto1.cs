using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_10_05
{
    class lotto1
    {
        static void Main()
        {
            List<int> lotto = new List<int>();
            Random rnd = new Random();

            while (true)
            {
                int temp = (rnd.Next(1, 47));
                if (!lotto.Contains(temp))
                    lotto.Add(temp);
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
