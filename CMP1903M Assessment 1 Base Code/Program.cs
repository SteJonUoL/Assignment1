//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            //Create 'Input' object
            //Get either manually entered text, or text from a file

            Input a = new Input();
            string text = "nothing";
            Console.WriteLine("Hello there! For manual input; Press 1 | For file input; Press 2.");
            ConsoleKeyInfo menuChoice = Console.ReadKey();
            if (menuChoice.Key == ConsoleKey.D1)
            {
                text = a.manualTextInput();
            }
            else if (menuChoice.Key == ConsoleKey.D2)
            {
                Console.Write("\nEnter your File Path> ");
                string filePath = Console.ReadLine();
                text = a.fileTextInput(filePath);
            }
            
            Analyse textAnalyser = new Analyse();
            //Create an 'Analyse' 
            //Pass the text input to the 'analyseText' 
            //Receive a list of integers 
            //Report the results of the 
            Report repOut = new Report();
            string tempvar1 = repOut.outputReport(textAnalyser.analyseText(text));


            //TO ADD: Get the frequency of individual letters?

            Console.ReadKey(); 
        }
        
        
    
    }
}
