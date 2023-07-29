using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task4
{
    internal class Task4
    {

        public void linkedlist()
        {
            LinkedList<string> lst = new LinkedList<string>();

            lst.AddFirst("Darshan");
            lst.AddLast("Satis Kumar");
            lst.AddLast("Sharon");
            lst.AddLast("Hemanth");

            Console.Write("\n");

            Console.WriteLine("The elements in the linked list: ");

            foreach (string element in lst)
            {
                Console.WriteLine(element);
            }
            Console.Write("\n");
            Console.WriteLine("The elements in the linked list after removing Darshan:");

            lst.Remove("Darshan");
            foreach(string element in lst)
            {
                Console.WriteLine(element);
            }

        }

        public void hashSet()
        {
            // An hashset is used to prevent from adding duplicates
            HashSet<string> values = new HashSet<string> ();

            values.Add("Sivaji Vaila Jilebi");
            values.Add("Bharath mata ki Jai");
            values.Add("Indha naadu mattu en kai la sikkichuu..");

            Console.WriteLine("\n");

            Console.WriteLine("The values in the hashset: ");
            foreach(string element in values)
            {
                Console.WriteLine(element);
            }

            //We will try add an element which is already in the hashset

            values.Add("Sivaji Vaila Jilebi");

            Console.WriteLine("\n");

            Console.WriteLine("The values in the hashset after trying to add a duplicate value: ");

            foreach (string element in values)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Therefore, even if we try to add a duplicate element the hashset wont allow it to enter into it");
        }

        public void queue()
        {
            Queue<string> que = new Queue<string>();

            que.Enqueue("'Why so serious?' ~ Joker");
            que.Enqueue("'You merely adopted the dark, I was born in it' ~ Bane");
            que.Enqueue("'You become a hero  or you live long enough to see yourself become a villain' ~ Batman");

            Console.WriteLine("\n");

            Console.WriteLine("The values in the queue : ");
            foreach (string element in que)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\n");
            Console.WriteLine("When we try to remove an element, it will remove the most old element");

            que.Dequeue();
            foreach (string element in que)
            {
                Console.WriteLine(element);
            }

        }

        public struct attendance 
        {
         public  int present;
            public int absent;
            public int total;
        }

        static void Main(string[] args)
        {
            Task4 obj = new Task4();
            Hashtable ht = new Hashtable();         //it has key value pair

            ht.Add(1, "Darshan");
            ht.Add(2, "Sharon");
            ht.Add(3, "Satis");


            foreach (DictionaryEntry ele1 in ht)
            {
                Console.WriteLine("Key    : "+ele1.Key);
                Console.WriteLine("Value  : "+ele1.Value);
            }

            obj.linkedlist();

            obj.hashSet();

            obj.queue();

            attendance attendance = new attendance();
            Console.WriteLine('\n');

            Console.WriteLine("Working of struct");

            attendance.present = 12;
            attendance.absent = 8;
            attendance.total = attendance.present + attendance.absent;
            Console.WriteLine($"The number of present: {attendance.present}");
            Console.WriteLine($"The number of absent: {attendance.absent}");
            Console.WriteLine($"Total number of trainees are: {attendance.total}");

            Console.WriteLine("");

            Console.ReadLine();
        }


    }
}
