using System;
using System.Configuration;
using System.Data;
using MySql.Data;
using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;

namespace ProXSchedule // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Sql conections

            var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("C:\\Users\\jrodr\\OneDrive\\Documents\\Repo\\XproSchedule\\XproSchedule\\bin\\Debug\\net7.0\\appsetting.json")
            .Build();

            string connString = config.GetConnectionString("DefaultConnection");
            IDbConnection conn = new MySqlConnection(connString);



            Console.WriteLine("****************Welcome to ProX Schedule*******************");


            
            Console.WriteLine();
            do
            {
                Console.WriteLine("Please Press 1 to show Service Scheduled :");
            var userinput1 = int.Parse(Console.ReadLine());

            if (userinput1 != 1) 
            {


                Console.WriteLine("Try again wrong selection!");

            
            
            }
               else if (userinput1 == 1)
                {
                   
                    
                    Console.WriteLine("Please wait Loadding Data");


                     for (int i = 0; i < 6; i++)
                    {
                        Console.Write(".");
                        Thread.Sleep(1000);
                    }
                    
                }

                Console.Clear();

                Console.WriteLine("**************All Schduled************");
                var time = DateAndTime.Now;
                Console.WriteLine($"As Date & Time of :{time}");
                Console.WriteLine();
                var repo = new ServiceRepository(conn);
                var info = repo.GetLisschedule();
                Console.WriteLine(" ID ");

                foreach (var item in info)
                {

                    Console.WriteLine($"{item.ID}  {item.Name} {item.Description} {item.Problems} {item.Datetime2} {item.Phone} {item.Address} {item.City} {item.Zipcode}");


                }
 

            } while (true);







        }
    }
}