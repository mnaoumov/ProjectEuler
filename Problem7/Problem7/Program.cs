﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            var solver = new MySolver();
            Console.WriteLine(solver.Solve(10001));
        }
    }
}
