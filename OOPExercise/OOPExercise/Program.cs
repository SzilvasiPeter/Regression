using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataProvider;

namespace OOPExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            DataProvider dataProvider = new DataProvider();

            File.WriteAllLines("../../data.json", lines);

        }
    }
}
