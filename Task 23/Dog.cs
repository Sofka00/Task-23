using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_23
{
    public class Dog
    {
        public string Name { get; set; }
        public void DoGav()
        {
            Console.WriteLine($"{Name} GAV-GAV");
        }
    }
}
