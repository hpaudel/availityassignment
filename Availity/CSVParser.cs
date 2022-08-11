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
                

                IList<User> userList = new List<User>();
                
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
                    
                }

                Console.WriteLine(userList);

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
