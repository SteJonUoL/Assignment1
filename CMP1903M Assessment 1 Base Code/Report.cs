﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        public string outputReport(List<int> values)
        {
            Console.WriteLine("Vowels: " + values[0]);
            Console.WriteLine("Consonants: ", + values[1]);
            Console.WriteLine();
            Console.WriteLine();
            return "1";
        }
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)
    }
}
