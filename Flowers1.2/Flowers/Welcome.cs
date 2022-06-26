namespace Flowers
{

    using System;
    using System.Collections.Generic;
    using System.Text;

    public class WelcomeToTheShop
    {
        public static void Welcome()
        {

            Console.Write("Height: ");
            int height = int.Parse(Console.ReadLine());

            string[,] triangle = new string[5, 5]{
                {" "," "," "," "," ", },
                {" "," "," "," "," ", },
                {" "," "," "," "," ", },
                {" "," "," "," "," ", },
                {" "," "," "," "," ", },
                };

            for (int a = 0; a < height; a++)
            {
                for (int e = 0; e < a + 1; e++)
                {
                    triangle[a, 4 - e] = "#";
                }
            }
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(triangle[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Welcome to the flower shop!");

        }
    }
}
