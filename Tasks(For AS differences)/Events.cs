using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_For_AS_differences_
{
    //Publisher class
    class orderEventArgs : EventArgs
    {
        public string Email { get; set; }
        public string Phone { get; set; }

    }
    class order
    {
        public event EventHandler<orderEventArgs> OnCreated;

        int count = 0;

        public void Create(string email,string phone, int amount)
        {
            if(OnCreated != null)
            {
                Console.WriteLine("ORder created");
                Console.WriteLine($"order id {++count} with amount {amount}");
                OnCreated(this, new orderEventArgs { Email = email, Phone = phone });

            }
        }
    }

    class Email
    {
        public static void Send(object sender , orderEventArgs e)
        {
            Console.WriteLine("Email is "+e.Email);
        }
    }
    class SMS
    {
        public static void Send(object sender , orderEventArgs e)
        {
            Console.WriteLine("The phone number is: " + e.Phone);
        }
    }


    internal class ProgramEvents
    {
        static void Main(string[] args)
        {
            var order = new order();

            order.OnCreated += Email.Send;
            order.OnCreated += SMS.Send;
            int orders,amount;
            string mail, phone;

            Console.WriteLine("Enter number of orders placed");
            orders = Convert.ToInt32(Console.ReadLine());


            for(int i = 0; i<orders; i++)
            {
                Console.WriteLine("Enter the customer details");
                Console.WriteLine("MaildID");
                mail = Console.ReadLine();
                Console.WriteLine("Enter the Phone number: ");
                phone = Console.ReadLine();
                Console.WriteLine("Enter the ID:");
                
                order.OnCreated -= Email.Send;

            }
        }
    }
}
