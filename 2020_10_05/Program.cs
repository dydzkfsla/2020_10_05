using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2020_10_05
{
    class PhonInfo : IComparable
    {
        public string name { get; set; }
        public string phon { get; set; }
        public string birth { get; set; }

        public PhonInfo()
        {

        }

        public PhonInfo(string name)
        {
            this.name = name;
        }

        public PhonInfo(string name, string phon)
        {
            this.name = name;
            this.phon = phon;
        }

        public PhonInfo(string name, string phon, string bith)
        {
            this.name = name;
            this.phon = phon;
            this.birth = bith;
        }

        public int CompareTo(object obj)
        {
            return name.CompareTo((obj as PhonInfo).name);
        }

        public override bool Equals(object obj)
        {
            return obj is PhonInfo info &&
                   name == info.name;
        }

        public override int GetHashCode()
        {
            return 363513814 + EqualityComparer<string>.Default.GetHashCode(name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList name = new ArrayList();
            Console.WriteLine("q를 입력하면 종료");
            while (true)
            {
                string temp1, temp2;
                
                Console.Write($"{name.Count+1}번째 이름: ");
                temp1 = Console.ReadLine();
                if(temp1 == "q")
                {
                    break;
                }

                Console.Write($"{name.Count+1}번째 번호: ");
                temp2 = Console.ReadLine();
                if (temp2 == "q")
                {
                    break;
                }

                name.Add(new PhonInfo(temp1, temp2));
            }
            Console.WriteLine();
            foreach(PhonInfo temp in name)
            {
                Console.WriteLine($"{temp.name}의 번호{temp.phon}");
            }



            List<PhonInfo> name1 = new List<PhonInfo>();
            Console.WriteLine("q를 입력하면 종료");
            while(true)
            {
                string temp1, temp2, temp3;

                Console.Write($"{name.Count + 1}번째 이름: ");
                temp1 = Console.ReadLine();
                if (temp1.ToLower() == "q")
                {
                    break;
                }

                Console.Write($"{name.Count + 1}번째 번호: ");
                temp2 = Console.ReadLine();
                if (temp2.ToLower() == "q")
                {
                    break;
                }

                Console.Write($"{name.Count + 1}번째 생일: ");
                temp3 = Console.ReadLine();
                if (temp3.ToLower() == "q")
                {
                    break;
                }

                name1.Add(new PhonInfo(temp1, temp2, temp3));
            }
            Console.WriteLine();
            foreach (PhonInfo temp in name1)
            {
                Console.WriteLine($"{temp.name}의 번호{temp.phon} 및 생일{temp.birth}");
            }
        }
    }
}