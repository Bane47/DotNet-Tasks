using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Remoting.Services;

namespace Tasks_For_AS_differences_
{
    internal class traineeDetails {
        public int id;
        public string Name;
        public int Age;
    }

    internal class Files
    {
        internal void gettingValues(int strength,traineeDetails Tdetails,List<traineeDetails> details)
        {
       
            for (int i = 1; i <= strength; i++)
            {
                Console.WriteLine($"Enter the ID of the trainee {i}");
                Tdetails.id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the name:");
                Tdetails.Name = Console.ReadLine();
                Console.WriteLine("Enter the Age: ");
                Tdetails.Age = Convert.ToInt32(Console.ReadLine());

                details.Add(Tdetails);
            }

           
        }
        
        internal static void Main(string[] args)
        {
            FileInfo myFile = new FileInfo(@"D:\.Net\MyFile1.txt");

            FileInfo myFile2 = new FileInfo(@"D:\.Net\MyFile_CreateAnother.txt");
            //FileStream fs = myFile.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            FileStream fs = myFile.Open(FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            FileStream fs2 = myFile2.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);

            StreamWriter sw = new StreamWriter(fs);
            StreamWriter sw2 = new StreamWriter(fs2);

            #region gettingValues

            Console.WriteLine("Enter the number of trainees:");
            int strength = Convert.ToInt32(Console.ReadLine());
            traineeDetails Tdetails = new traineeDetails();

            List<traineeDetails> details = new List<traineeDetails>();

            Files function = new Files();

            function.gettingValues(strength, Tdetails, details);



            #endregion


            try
            {
                foreach (traineeDetails o in details)
                {
                    sw.WriteLine("name: " + o.Name);
                    sw.WriteLine("id: " + o.id);
                    sw.WriteLine("age: " + o.Age);
                }

                File.Copy(@"D:\.Net\MyFile1.txt", @"D:\.Net\MyFile2.txt");
                File.Move(@"D:\.Net\MyFile2.txt", @"D:\.Net2\MyFile2.txt");

                if (File.Exists(@"D:\.Net\MyFile2.txt"))
                {
                    File.Delete(@"D:\.Net\MyFile2.txt");
                }
                else
                {
                    sw2.WriteLine("This is a ");


                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message+"This is the exception!!!!!.......");
            }
            finally
            {
                sw.Close();
                fs.Close();
            }


        }
    }
}
