using System;

namespace StudentsNamesWithSmile
{
    class Program
    {
     

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

   
           string[] lines = System.IO.File.ReadAllLines(@"C:\Users\teacher\Desktop\TsaniMHomeworks\WorkFolder\PU-IntroCSharp-2018-1801681056\StudentsNamesWithSmile\files\std-students-2018.txt");


            System.Console.WriteLine("Contents of Students.txt = ");
            int studentsWithSmile = 0;
            foreach (string line in lines)
            {
                string[] elements = line.Split(" ");

                string firstName = elements[1];
                string secondName = elements[2];
                string thirdName = elements[3];
                string name = $"{0} {1} {2} ";
                int sum1 = 0;
                int sum2 = 0;
                int sum3 = 0;
                int sum = 0;
                for (int i = 0; i < firstName.Length; i++)
                {
                    sum1 = sum1 + (int)firstName[i];
                }
                for (int i = 0; i < secondName.Length; i++)
                {
                    sum2 = sum2 + (int)secondName[i];
                }
                for (int i = 0; i < thirdName.Length; i++)
                {
                    sum3 = sum3 + (int)thirdName[i];
                }
                sum = sum1 + sum2 + sum3;

                              

                    if (sum > 15000)
                    {

                    studentsWithSmile += 1;
                    Console.WriteLine($"{firstName} {secondName} {thirdName} {(char)9786}");
                    }




            }

            Console.WriteLine($"Total Lines {lines.Length}");
            Console.WriteLine($"Smile for:{studentsWithSmile} {(char)9786}");

        }
    }
}
