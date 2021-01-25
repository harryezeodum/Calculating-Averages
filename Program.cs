using System;

namespace CalculatingAverages
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            int averageScore = 0;

            // Sum of numbers
            Console.WriteLine($" The sum of numbers between 0 and 100: ");
            // 10 + 20 + 30 + 40 + 50 + 60 + 70 + 80 + 90 + 100
            int sum = 10 + 20 + 30 + 40 + 50 + 60 + 70 + 80 + 90 + 100;
            Console.WriteLine($" The sum of ten numbers is {sum}\n");

            // Average ten scores
            Console.WriteLine($" Ten test scores between 0 and 100: ");
            // 98 + 90 + 88 + 85 + 90 + 89 + 91 + 80 + 92 + 86 / 10
            int TestScore = (98 + 90 + 88 + 85 + 90 + 89 + 91 + 80 + 92 + 86);
            int averageTestScore = TestScore / 10;
            Console.WriteLine($" The average of ten test scores is {averageTestScore} ");

            if (averageTestScore >= 90)
            {
                Console.WriteLine($" Grade is \"A\" ");
            }
            else if (averageTestScore >= 80)
            {
                Console.WriteLine($" Grade is \"B\" ");
            }
            else if (averageTestScore >= 70)
            {
                Console.WriteLine($" Grade is \"C\" ");
            }
            else
            {
                Console.WriteLine($" Grade is \"F\" ");
            }
            Console.WriteLine();

            // Average a specific number of scores
            Console.WriteLine($" Ten test scores between 0 and 100: ");
            Console.Write($" Please enter the number of test scores ");
            int numberOfTestScores = int.Parse(Console.ReadLine());

            Console.Write($" Please enter the total test score ");
            int totalScore = int.Parse(Console.ReadLine());
            int average = totalScore / numberOfTestScores;
            Console.WriteLine($" The average of ten test scores is {average} ");

            if (average >= 90)
            {
                Console.WriteLine($" Grade is \"A\" ");
            }
            else if (average >= 80)
            {
                Console.WriteLine($" Grade is \"B\" ");
            }else if (average >= 70)
            {
                Console.WriteLine($" Grade is \"C\" ");
            }else
            {
                Console.WriteLine($" Grade is \"F\" ");
            }
            Console.WriteLine();


            // Average a non-specific number of scores
            Console.WriteLine($" Please enter ten test scores between 0 and 100.");
            
            Console.Write($" ");
            input = Convert.ToInt32(Console.ReadLine());

            Console.Write($" ");
            input += Convert.ToInt32(Console.ReadLine());

            Console.Write($" ");
            input += Convert.ToInt32(Console.ReadLine());

            Console.Write($" ");
            input += Convert.ToInt32(Console.ReadLine());

            Console.Write($" ");
            input += Convert.ToInt32(Console.ReadLine());

            Console.Write($" ");
            input += Convert.ToInt32(Console.ReadLine());

            Console.Write($" ");
            input += Convert.ToInt32(Console.ReadLine());

            Console.Write($" ");
            input += Convert.ToInt32(Console.ReadLine());

            Console.Write($" ");
            input += Convert.ToInt32(Console.ReadLine());

            Console.Write($" ");
            input += Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($" The sum of all ten test scores are \n {input}");

            // Average ten scores

            averageScore = input / 10;
            Console.WriteLine($" Average score is {averageScore}");
            
            if (averageScore >= 90)
            {
                Console.WriteLine($" Grade is \"A\" ");
            } else if (averageScore >= 80)
            {
                Console.WriteLine($" Grade is \"B\" ");
            }else if (averageScore >= 70)
            {
                Console.WriteLine($" Grade is \"C\" ");
            }else
            {
                Console.WriteLine($" Grade is \"F\" ");
            }
        }
    }
}
