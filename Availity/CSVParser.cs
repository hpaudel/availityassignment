using System;

namespace Availity
{
    class CSVParser : IFileParser
    {
        public void Parser(string csvString)
        {
            try
            {
                Console.WriteLine("Accessing CSV File Parser");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
