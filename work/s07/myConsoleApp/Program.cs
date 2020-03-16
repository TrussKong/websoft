using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
//using Microsoft.AspNetCore.Hosting;

namespace myConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
             bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            // Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) View Accounts");
            Console.WriteLine("2) View Acconts by numbers");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");
         
            switch (Console.ReadLine())
            {
                case "1":
                    ViewAccounts();
                    return true;
                case "2":
                     ViewAccountsByNumbers();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }
        private static void ViewAccounts(){
            var accounts = ReadAccounts();
                Console.WriteLine();
                Console.WriteLine("------------------------------------");
                Console.WriteLine("| Number | Balance | Label | Owner |");
                Console.WriteLine("------------------------------------");
            foreach(var account in accounts){
                //Console.WriteLine(account);
               
                Console.WriteLine("| " + account.Number + " |        " + account.Balance + "| " + account.Label + "|     " + account.Owner + "| ");
                Console.WriteLine("------------------------------------");


            }

        }
        private static void ViewAccountsByNumbers(){
            String accountNumber = CaptureInput();
            //Console.WriteLine(accountNumber);
            var accounts = ReadAccounts();
            foreach(var account in accounts){
                //Console.WriteLine(account.Number);
            if(accountNumber.Equals(account.Number.ToString())){
                Console.WriteLine();
                Console.WriteLine("------------------------------------");
                Console.WriteLine("| Number | Balance | Label | Owner |");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("| " + account.Number + " |        " + account.Balance + "| " + account.Label + "|     " + account.Owner + "| ");
                Console.WriteLine("------------------------------------");


            }

            }

        }

        private static String CaptureInput()
        {
            Console.Write("Enter the account id for details:  ");
            return Console.ReadLine();
        }
        public static IEnumerable<Account> ReadAccounts()
        {
            String file = "data/account.json";

            using (StreamReader r = new StreamReader(file))
            {
                string data = r.ReadToEnd();
                 //Console.WriteLine(data);

                var json = JsonSerializer.Deserialize<Account[]>(
                    data,
                    new JsonSerializerOptions {
                        PropertyNameCaseInsensitive = true
                    }
                );

                //Console.WriteLine(json[0]);
                return json;
            }
        }

    

        public class Account
        {
            public int Number { get; set; }
            public int Balance { get; set; }
            public string Label { get; set; }
            public int Owner { get; set; }
            
            public override string ToString() {
                return JsonSerializer.Serialize<Account>(this);
            }
        }

    }
}
