using System;

namespace finalizers
{
    public class Employee
    {
        public Employee()
        {
            Console.WriteLine("Object Created...");
        }

        ~Employee()
        {
            //code to clean resources
            Console.WriteLine("Object Destroyed");
        }
    }
}