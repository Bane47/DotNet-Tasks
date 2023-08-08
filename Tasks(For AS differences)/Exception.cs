using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tasks_For_AS_differences_
{
    internal class Trainee
    {
        public string Name { get; set; }
        public double CSharpScore { get; set; }
        public double UIScore { get; set; }
        public double TotalScore { get; set; }
        public double AvgScore { get; set; }

    }

    internal class UserDefinedException
    {
        
        static void Main(string[] args)
        {
            Trainee trainee;
            try { 
            trainee = new Trainee();

                trainee.Name = "Satis Kumar*&";
                trainee.CSharpScore = 44;
                trainee.UIScore = 97;
                trainee.TotalScore = 100;
                trainee.AvgScore = (trainee.CSharpScore + trainee.UIScore) / 2;
                Validate(trainee);


            }
            catch(InvalidNameException e)
            {
                Console.WriteLine($"{e.Message}");
            }
            catch(InvalidAvgScoreException e)
            {
                Console.WriteLine($"{e.Message}");
            }


        }

        public static void Validate(Trainee trainee)
        {
            Regex obj = new Regex("^[A-Za-z]$");
            if (!obj.IsMatch(trainee.Name)){
                throw new InvalidNameException(trainee.Name);
            }
            if (trainee.AvgScore < 50)
            {
                throw new InvalidAvgScoreException($"{trainee.AvgScore}");

            }

        }
    }

    
    class InvalidNameException : Exception
    {
        public InvalidNameException(string message) : base($"Invalid Name:{message} (Name must contain only alphabets)") { }
       
    }

    internal class InvalidAvgScoreException : Exception
    {
        public  InvalidAvgScoreException(string message):base($"Invalid Score:{message} (Average should be greater than or equal to 7)") { }
    }




}
