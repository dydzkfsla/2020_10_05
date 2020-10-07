using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_10_05
{
    class Genric1
    {
        static void Main()
        {
            //List<int> list = new List<int>();
            //list.Add(10);
            //list.Add(20);
            ////list.Add("딸기");

            //for(int i =0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            List<PhonInfo> list = new List<PhonInfo>();
            list.Add(new PhonInfo("홍길똥"));
            list.Add(new PhonInfo("김길똥"));
            list.Add(new PhonInfo("박길똥"));
            list.Add(new PhonInfo("이길똥"));


            for (int i =0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].name);
            }
        }
    }
}
