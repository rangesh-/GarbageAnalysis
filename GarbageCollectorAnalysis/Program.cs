using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace GarbageCollectorAnalysis
{
    class Program
    {
        /// <summary>
        /// Allows an <see cref="T:System.Object"/> to attempt to free resources and perform other cleanup operations before the <see cref="T:System.Object"/> is reclaimed by garbage collection.
        /// </summary>
        ~Program()
        {
            Console.WriteLine("Finzalize ....");
            Console.ReadLine();
            Console.WriteLine("Destructed");
            Console.ReadLine();
        }

    
        public static int a = 0;
        public int b = 0;
         static void Main(string[] args)
        {

            Program p=new Program();
           p.Final();
             Console.WriteLine("After Finalize");
             Console.ReadLine();

        }



        public void Final()
        {
            try
            {
                Console.WriteLine("hello i m in try block");
                Console.WriteLine("Hit Enter");
                Console.ReadLine();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Data);
            }
            
        }

        public  void RootAnalysis(Program p)
        {

            Console.WriteLine("Incrementing Static Reference");
            a++;
            Console.WriteLine("Static"+a);
            Console.ReadLine();
           p.b=p.b++;
            Console.ReadLine();
            Console.WriteLine("Non-static"+b);
        }

        private static void GeneratorAnalysis()
        {
            Console.WriteLine("Analysing GC,Hit Enter Key");
            String var = Console.ReadLine();
            Console.WriteLine("u Entered {0}", var);
            Program.a++;
            Console.WriteLine(Program.a);
            Console.ReadLine();
        }


        
    }
}
