using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_23;

namespace Task_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dogQ= new Dog();
            dogQ.Name = "Q";
            dogQ.DoGav();

            Dog dog = new Dog();
            dog.Name = "Bobic";
            dog.DoGav();
        }
    }
}
