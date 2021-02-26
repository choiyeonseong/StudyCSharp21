using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Address
    {
        private int a;
        private int b;
        private int c;

        public Address(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

        }

        public int A
        {
            get { return this.a; }
            set
            {
                this.a = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Address[] add;
            add = new Address[10];

            for (int i = 0; i < add.Length; i++)
            {
                add[i] = new Address(i,i+1,i+2);
            }
            foreach (var item in add)
            {
                Console.WriteLine($"{item.A}");
            }


        }
    }
}
