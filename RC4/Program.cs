using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RC4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            RC4 rc4 = new RC4();
            string text = "AABBCCDD11223344";
            string key = "71472185720000";

            Console.WriteLine("Plain text: {0}\nKey: {1}\n", text, key);

            try
            {
                double time;

                sw.Start();
                rc4.Text = text; ;
                rc4.Key = key;
                rc4.compute();
                sw.Stop();
                time = (double)sw.ElapsedTicks / 10000;
                Console.WriteLine("Encoded text: {0}\nTime Elapsed: {1} ms\n", rc4, time);

                sw.Start();
                rc4.Key = key;
                rc4.compute();
                sw.Stop();
                time = (double)sw.ElapsedTicks / 10000;
                Console.WriteLine("Decoded text: {0}\nTime Elapsed: {1} ms\n", rc4, time);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.Write("\nFinished!");
            Console.ReadKey();
        }
    }
}
