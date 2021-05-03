using System;

namespace LabAssignment4
{
    class Program
    {
        static void Main(string[] args)
        {

            //declares an integer array of size 5
            double[] scores = new double[5];

            System.Console.WriteLine("Enter your mark for each course");

            //reads the input value, convert it to the integer and assigned it to index position [0]
            var input1 = Console.ReadLine();
            if(input1 == null)
            {
                System.Console.WriteLine("Value cannot be null");
            }
            else if(input1 == "")
            {
                System.Console.WriteLine("Enter a Valid Number");
            }
            else
            {
                var firstInput = double.Parse(input1);
                scores[0] = firstInput;
            }


            //reads the input value, convert it to the integer and assigned it to index position [1]
            var input2 = Console.ReadLine();
            if(input2 == null)
            {
                System.Console.WriteLine("Value cannot be null");
            }
            else if(input2 == "")
            {
                System.Console.WriteLine("Enter a Valid Number");
            }
            else
            {
                var secondInput = double.Parse(input2);
                scores[1] = secondInput;
            }

            //reads the input value, convert it to the integer and assigned it to index position [2]
            var input3 = Console.ReadLine();
            if(input3 == null)
            {
                System.Console.WriteLine("value cannot be null");
            }
            else if(input3 == "")
            {
                System.Console.WriteLine("Enter a Valid Number");
            }
            else
            {
                var thirdInput = double.Parse(input3);
                scores[2] = thirdInput;
            }

            //reads the input value, convert it to the integer and assigned it to index position [3]
            var input4 = Console.ReadLine();
            if(input4 == null)
            {
                System.Console.WriteLine("Value cannot be null");
            }
            else if(input4 == "")
            {
                System.Console.WriteLine("Enter a Valid Number");
            }
            else
            {
                var fourthInput = double.Parse(input4);
                scores[3] = fourthInput;
            }

            //reads the input value, convert it to the integer and assigned it to index position [4]
            var input5 = Console.ReadLine();
            if(input5 == null)
            {
                System.Console.WriteLine("Value cannot be null");
            }
            else if(input5 == "")
            {
                System.Console.WriteLine("Enter a Valid Number");
            }
            else
            {
                var fifthInput = double.Parse(input5);
                scores[4] = fifthInput;
            }

            //calls the method to calculate the CGPA
            double cgpaResult = calculateCGPA(scores);
            System.Console.WriteLine($"You CGPA is {Math.Round(cgpaResult, 2)}");

            //calls the method to calculate the percentage CGPA
            double percentageCGPAResult = percentageCGPA(cgpaResult);
            System.Console.WriteLine($"You Percentage CGPA is {Math.Round(percentageCGPAResult, 2)}%");

        }

        public static double calculateCGPA(double[] scores)
        {
            double totalScore = 0;

            //loop through the array of scores
            foreach(var score in scores)
            {
                totalScore += score;
            }
            
            var formula = totalScore/5;
            return formula;
        }

        public static double percentageCGPA(double result)
        {
            double percentageCGPAResult = result * 9.5;
            return percentageCGPAResult;
        }
    }
}
