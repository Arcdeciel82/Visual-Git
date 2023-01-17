using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Test
{
    class Program
    {
        private int steve;
        public int getSteve()
        {
            return steve;
        }
        public void setSteve(int i)
        {
            steve = i;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World" + 5);
            Console.ReadKey();
            Console.WriteLine("Setting steve to 4");
            Program p = new Program();
            p.setSteve(4);
            Console.WriteLine("Steve is: " + p.getSteve());
            Console.ReadKey();
        }
    }
}
