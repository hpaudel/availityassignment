using System;

namespace Availity
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string value = "";
                string extension = "";
                CreateFileObject.CreateParser(value,extension);
                Console.Read();

            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }
    }
}
