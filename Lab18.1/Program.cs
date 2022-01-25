using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            Console.WriteLine(Check(str));
            Console.ReadKey();
        }


        static bool Check(string str)
        {
            Stack<char> st = new Stack<char>();
            Dictionary<char, char> sk = new Dictionary<char, char>
            {
                {'(',')' },
                {'[',']' },
                {'{','}' },
            };
            foreach (char c in str)
            {
                if (c == '(' || c == '[' || c == '{')
                    st.Push(sk[c]);
                if (c == ')' || c == ']' || c == '}')
                {
                    if (st.Count == 0 || st.Pop() != c)
                    {
                        return false;
                    }
                }

            }
            if (st.Count == 0)
                return true;

            else
                return false;
        }
    }
}
