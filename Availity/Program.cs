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
                string[] csvLines=null;
                string extension = "";
                string path = @"c:/File/file.csv";

                if(!File.Exists(path))
                {
                    Console.Write($"No file {path} found");
                    return; 
                }
                csvLines = File.ReadAllLines(path);
                FileInfo fi = new FileInfo(path);
                extension = fi.Extension;
                CreateFileObject.CreateParser(csvLines, extension);
                Console.Read();

            }
            catch (Exception ex)
            {
                Logs.Log(ex.Message);
            }
        }
    }
}
