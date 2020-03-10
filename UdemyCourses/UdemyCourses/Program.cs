using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCourses
{


    class Program
    {
        static void Main(string[] args)
        {
            // Nomal pointer to an object.
            int[] a = new int[5] {10, 20, 30, 40, 50 };

            //Must be in unsafe code to use interior pointers
            unsafe
            {
                fixed (int* p = &a[0])
                {
                    // p is pinned as well as object, so create another
                    int* p2 = p;
                    Console.WriteLine(*p2);

                    // Incrementing p2 bumps the pointer by foir bytes
                    p2 += 1;
                    Console.WriteLine(*p2);
                    p2 += 1;
                    Console.WriteLine(*p2);
                    Console.WriteLine("--------");
                    Console.WriteLine(*p);

                    //Dereferencing p and incrementing changes
                    *p += 1;
                    Console.WriteLine(*p);
                    *p += 1;
                    Console.WriteLine(*p);
                }
            }

            Console.WriteLine("-----");
            Console.WriteLine(a[0]);
        }
    }
}
