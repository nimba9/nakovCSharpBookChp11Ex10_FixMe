using System;

/* 
 * The following program contains an error (or more {the more the merrier :-)}) made 
 * during the process of solving.
 * It serves as a remainder and memory training.
 */


namespace nakovCSharpBookChp11Ex10_FixMe
{
    public class StringNumbersAdding
    {
        public static void Main()
        {
            Console.WriteLine("Please enter number separated by comma, point or space: ");

            string userInp = Console.ReadLine();

            SumNumbers(userInp);
        }

        public static void SumNumbers(string userInp)


        {
            string digits = userInp.Trim(new Char[] { ' ', '*', '.' }); // The new Char part was copied online

            int sum = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                sum += digits.add();

                if (digits != ' ')
                {
                    int num;
                    digits.TryParse(digits, out num);

                }

            }

        }
    }
}

