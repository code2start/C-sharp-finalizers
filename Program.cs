using System;

namespace finalizers
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
            GC.Collect();
        }

        public static void Run()
        {
            Employee e1 = new Employee();
        }
    }
}
