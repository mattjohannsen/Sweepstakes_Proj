﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        private static void Main(string[] args)
        {
            Simulation simulation = new Simulation();
            simulation.RunSimulation();
            Console.ReadLine();
        }
    }
}
