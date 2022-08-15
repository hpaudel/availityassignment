using System;
using System.IO;

namespace Availity
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /* Assignment 4 *****/
                bool check = Checker.IsBalanced("(");
                Console.WriteLine($"Parenthesis is Balanced: {check}");

                /* Assignment 6 *****/
                string extension = "";
                string path = @"c:/File/file.csv";

                if (!File.Exists(path))
                {
                    Console.Write($"No file {path} found");
                    return;
                }

                FileInfo fi = new FileInfo(path);
                extension = fi.Extension;
                CreateFileObject.CreateParser(path, extension);
                Console.Read();

            }
            catch (Exception ex)
            {
                Logs.Log(ex.Message);
            }
        }
    }
}
