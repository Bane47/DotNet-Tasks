using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tasks_For_AS_differences_
{
    internal class Reg_exp
    {

        static void Main(string[] args)
        {
            Regex reg_pass = new Regex("[A-Za-z][0-9](?=.*?[!@#$%^&*]){8,16}");
            Regex reg_Phone = new Regex("[3-5]{3}-[0-9]{4}-[0-9]{3}");
            Regex reg_mobile = new Regex("[1-8]{10}");

            var Password = new List<string> { }; 
            var phone = new List<string> { };
            var mobile = new List<string> { };
            Console.WriteLine("Enter the Mobile number: ");
            mobile.Add(Console.ReadLine());

            mobile.ForEach(q => Console.WriteLine(Regex.IsMatch(q.ToString(), reg_mobile.ToString())));
            Console.WriteLine("Enter the password: ");
            Password.Add(Console.ReadLine());
                            
            Password.ForEach(p => Console.WriteLine(Regex.IsMatch(p, reg_pass.ToString())));

            Console.WriteLine("Enter the Tele phone number: ");
            phone.Add(Console.ReadLine());

            phone.ForEach(q => Console.WriteLine(Regex.IsMatch(q.ToString(), reg_Phone.ToString())));


          


        }
    }
}
