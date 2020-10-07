using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_10_05
{
    class ArrayList2
    {
        static void Main()
        {
            ArrayList list = new ArrayList();

            list.Add(new PhonInfo("홍길똥"));
            list.Add(new PhonInfo("김길똥"));
            list.Add(new PhonInfo("박길똥"));
            list.Add(new PhonInfo("이길똥"));

            list.Sort();

            foreach(PhonInfo temp in list)
            {
                Console.WriteLine(temp.name);
            }

        }
    }
}
