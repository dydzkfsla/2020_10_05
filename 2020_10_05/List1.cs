using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020_10_05
{
    class List1
    {
        public void Main()
        {
            List<string> list = new List<string>();
            list.Add("김치찌개");
            list.Add("된장찌개");
            list.Add("순두부찌개");
            list.Add("동태찌개");
            list.Add("부대찌개");
            foreach (string temp in list)
            {
                Console.WriteLine(temp);
            }

            list.Sort();
            list.Reverse();

            int[] strArr = new int[3] { 10, 20, 30 };
            List<int> iList = strArr.ToList<int>();
            string[] arr  =    list.ToArray();
        }
    }
}
