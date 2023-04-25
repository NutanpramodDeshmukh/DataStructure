using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackandQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.push(20);
            st.push(40);
            st.Display();
            Console.ReadKey();

        }
    }
}
