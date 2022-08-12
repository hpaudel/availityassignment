using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Availity
{
    class CSVParser : IFileParser
    {
        public void Parser(string path)
        {

            string[] csvString = null;

            try
            {
                

                IList<User> userList = new List<User>();

                csvString = File.ReadAllLines(path);

                for (int i=1;i<csvString.Length;i++)
                {
                    
                    string[] values = csvString[i].Split(',');

                    User user = new User
                    {
                        UserId = Convert.ToInt32(values[0]),
                        FirstName = values[1],
                        LastName = values[2],
                        Version = Convert.ToInt32(values[3]),
                        Insurance = values[4]
                    };

                    userList.Add(user);
                    var result = userList.GroupBy(u => u.Insurance);

                    foreach(var userGroup in result)
                    {
                        
                        foreach(var item in userGroup)
                        {
                            Console.WriteLine($"{item.UserId}{item.FirstName}{item.LastName}{item.Version}{item.Insurance}");
                        }

                    }
                 
                }
                

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
