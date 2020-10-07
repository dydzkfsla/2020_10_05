using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_10_05
{
    class ArrayList1
    {
        static void Main()
        {
            PhonInfo info = new PhonInfo();
            info.name = "홈길동";
            info.phon = "010-1111-1111";
            ArrayList alist = new ArrayList();

            alist.Add("사과");
            alist.Add("사과");
            alist.Add("딸기");
            alist.Add("참외");
            alist.Add("수박");
            alist.Add(123);
            alist.Add(info);
            alist.Insert(0,"포도");
            alist.Remove("딸기");
            
            for (int i = 0; i < alist.Count; i++)
            {
                if (alist[i] is PhonInfo)
                {
                    PhonInfo temp = alist[i] as PhonInfo;
                    Console.WriteLine(temp.name);
                }
                else
                {
                    Console.WriteLine(alist[i]);
                }
            }

            
        }
    }
}
