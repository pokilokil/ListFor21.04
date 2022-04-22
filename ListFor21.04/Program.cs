using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.IO;
using System.Xml;
using System.Diagnostics;
using System.Threading;
using System.Collections;

namespace Lesson2

{ 

    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();
                /*for (int m = 0; m < 1000000; m++)
            {

                List<int> list = new List<int>();
                list.Add(m);
                list.IndexOf(896753);
                
            } */
            List<int> list1 = new List<int>();

            int i = 0;
            while (i < 10000000)
            {
                i++;
                list1.Add(i);
                
            }
            Console.WriteLine(list1.IndexOf(896753));

            stopwatch1.Stop();
            Console.WriteLine("1 Time elapsed: {0:hh\\:mm\\:ss} ms {1}", stopwatch1.Elapsed, stopwatch1.Elapsed.Milliseconds);

            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();

            ArrayList  list2 = new ArrayList ();

            int y = 0;
            while (y < 10000000)
            {
                y++;
                list2.Add(y);
                
            }
            Console.WriteLine(list2.IndexOf(896753));
            stopwatch2.Stop();
            Console.WriteLine("2 Time elapsed: {0:hh\\:mm\\:ss}  ms {1}", stopwatch2.Elapsed, stopwatch2.Elapsed.Milliseconds);
            
            Stopwatch stopwatch3 = new Stopwatch();
            stopwatch3.Start();

            LinkedList<int> list3 = new LinkedList<int>();
            int z = 0;
            while (z < 10000000)
            {
                z++;
                list3.AddFirst(z);
                //Console.WriteLine(z);
                

            }
            list3.Find(896753);
            stopwatch3.Stop();
            Console.WriteLine("3 Time elapsed: {0:hh\\:mm\\:ss} ms {1}", stopwatch3.Elapsed, stopwatch3.Elapsed.Milliseconds);
            
            Console.ReadKey();

        }

    }
    
}