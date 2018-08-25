using System;

namespace Letter_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Your Letters");
            string input = Console.ReadLine().ToUpper();
            string whatIgetBack = " ";
            int counter = 1;

            //Looping to get string
            foreach (var letter in input)
            {
                //What I'll get back
                var lettersToGet = "";
                for (int i = 0; i < counter; i++)
                {
                    lettersToGet += letter.ToString().ToLower();
                }

                //adding the dash still at the END ...
                lettersToGet += "-";
                //finding first letter to change back to string and capitalize first letter 
                lettersToGet = lettersToGet[0].ToString().ToUpper() + lettersToGet.Substring(1);
                //after all completed, what I should see in the console
                whatIgetBack += lettersToGet;
                counter++;
            }
            //What's shown in the console.
            Console.WriteLine(whatIgetBack);
            Console.ReadLine();


        }

    }
}
