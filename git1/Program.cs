using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace git1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, github!!!");

            File.Create(".gitignore");
        }
    }
}
