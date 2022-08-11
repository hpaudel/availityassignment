using System;
using System.Collections.Generic;
using System.Linq;

namespace Availity
{
    class CSVParser : IFileParser
    {
        public void Parser(string[] csvString)
        {
            try
            {
                Console.WriteLine("CSV file parsed");
                
                for (int i=1;i<csvString.Length;i++)
                {
                    Console.WriteLine($" {} {} {} {}");
                }
                
                
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
