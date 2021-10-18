using System;

namespace CSharpMasters
{
    /// <summary>
    /// This program is for magenic masters only
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //WEEK 1 - ASSIGNMENT
            ContextualKeywords();

            //WEEK 2- ASSIGNMENT

        }


        //Week 1 - Contextual Keywords
        // I will use where keyword from generic class concept for my assignment 
        // source - https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/where-generic-type-constraint

        static void ContextualKeywords()
        {

            var printer = new Printer<string>();
            printer.Print("Hello");
        }




    }   
}
