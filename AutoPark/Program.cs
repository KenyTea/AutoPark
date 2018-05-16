using AutoPark.lib;
using AutoPark.lib.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark
{
    class Program
    {
        static void Main(string[] args)
        {
            Generator gen = new Generator();
           List<Project> projects = null; 

            string massage;
            if (!gen.GeneratorProgect(ref projects, out massage))
            {
                Console.WriteLine(massage);
                return;
            }

            foreach (Project item in projects)
            {
                item.PrintInfo();
            }
        }
}

}
