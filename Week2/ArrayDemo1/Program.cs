using System;
namespace ArrayDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5, 10, 15, 20, 25 };
            for (int i = 0; i<5; i++)
            {
                Console.WriteLine(numbers[i]);

            }
            Console.WriteLine("Now let's make a string array");
            string[] names = new string[] { "Fred", "Sally", "Julia", "Sam" };
            Console.WriteLine(names[0]); //Print out the first one
            Console.WriteLine(names[2]); //print out the third one
            Console.WriteLine(names[3]); //print out the fourth one
            // let's suppose we need to cchange one
            // let's change Sam to Samantha
            names[3] = "Samantha";
            for (int i=0; i< names.Length; i++)
            {
                Console.WriteLine(names[i]);


                string[] words = new string[4];
                words[0] = "Apple";
                words[1] = "Banana";
                words[2] = "Orange";
                words[3] = "Watermelon";

                for (int a = 0; a < words.Length; i++)
                {
                    Console.WriteLine(words[a]);
                }
            }
        }

    }

}