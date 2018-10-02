using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {

        static void Main(string[] args)
        {
            string str1 = "jo";
            string str2 = "jee";
            string.Compare(str1, str2);

            string one = "cat cat cat";
            string two = "dogdog dog";
            string three = "fish fishfish";
            String.Concat(one,two);
            three = three.Insert(8, two);
            int minus = one.Length - 3;
            one = one.Remove(minus);
            two = two.Replace("dog", "bird");

            string strNull = null;
            string strFull = "full";
            strNull = strFull;
            string newStr = String.Format("{0} + {1} = {2}", strNull, strFull, strNull + strFull);
            Console.WriteLine(strNull);
            Console.WriteLine(newStr);

            StringBuilder build = new StringBuilder();
            for (int i = 0; i < 30; i++) build.Append(i + ",");
            Console.WriteLine(build.ToString());
            build.AppendFormat("вставка в конец"); .
            build.Insert(0, "вставкав начало");
            Console.WriteLine(build);


        }
    }
}
