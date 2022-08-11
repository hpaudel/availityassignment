using System;
namespace Availity
{
    public  class CreateFileObject
    {
        public static void CreateParser(string value, string extension)
        {
            if (extension.Equals("csv")) new CSVParser().Parser(value);
        }
    }
}
