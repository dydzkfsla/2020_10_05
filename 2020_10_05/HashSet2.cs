using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_10_05
{
    class HashSet2
    {
        static void Main()
        {
            HashSet<string> sets = new HashSet<string>();
            sets.Add("홍길동");
            sets.Add("김길동");
            sets.Add("홍길동");

            Console.WriteLine(sets.Count);

            HashSet<PhonInfo> persons = new HashSet<PhonInfo>();
            persons.Add(new PhonInfo("홍길동"));
            persons.Add(new PhonInfo("홍길동"));
            persons.Add(new PhonInfo("홍길동"));

            Console.WriteLine(persons.Count);
        }
    }
}
