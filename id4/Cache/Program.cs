using System;
using System.Collections.Generic;

namespace Cache
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var cacheFunc = Cache<int,int>(DoSomething);
            Console.WriteLine(cacheFunc(10));
            Console.WriteLine(cacheFunc(5));
            Console.WriteLine(cacheFunc(10));
            Console.Read();
        }

        static Func<T,R> Cache<T,R>(Func<T,R> func)
        {
            var mem = new Dictionary<T, R>();
            return x =>
            {
                if (!mem.ContainsKey(x))
                {
                    Console.WriteLine($"加入缓存{x}");
                    mem[x] = func(x);

                }
                return mem[x];
            };
        }

        static int DoSomething(int a)
        {
            return a * a;
        }
    }
}
