using System;
using System.Globalization;

namespace W2L8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello in my homework from lesson number 8");

            Console.WriteLine("\n----- Exercise nr. 1 -----\n");
            string str;
            int a = 0, result = 0, b, i, j, greater, z;
            double x = 0.0, y;
            char[] characters, binary;
            char m;
            for(a = 2; a <= 100; a++)
            {
                if(a == 2 || a == 3 || a == 5 || a == 7)
                {
                    result++;
                }
                else if ((a % 2 == 0) || (a % 3 == 0) || (a % 5 == 0) || (a % 7 == 0))
                {
                    result = result;
                }
                else
                {
                    result++;
                }
            }
            Console.WriteLine("From 0 to 100 we have " + result + " prime numbers");
            Console.WriteLine(" 0 and 1 isn't prime number, the first prime number is 2");


            Console.WriteLine("\n----- Exercise nr. 2 -----\n");
            a = 0;
            result = 0;
            do
            {
                if(a % 2 == 0)
                {
                    Console.Write(a + ", ");
                    result++;
                }

                a++;

            } while (a <= 1000);
            Console.WriteLine("\n Is " + result + " even numbers from 0 to 1000");

            Console.WriteLine("\n----- Exercise nr. 3 -----\n");
            a = 0;
            b = 0;
            i = 0;
            result = 0;
            while(i < 20)
            {
                if(i == 0 || i == 1)
                {
                    result = i;
                    Console.WriteLine($"Iteration: {i++} result: " + result + ", ");
                    a = b;
                    b = result;
                }
                else 
                {
                    result = a + b;
                    Console.WriteLine($"Iteration: {i++} result: " + result + ", ");
                    a = b;
                    b = result;
                }
            }
            Console.WriteLine("\n----- Exercise nr. 4 -----\n");
            Console.Write("Enter a number: ");
            a = Int32.Parse(Console.ReadLine());
            b = 1;
            for (i = 0; i <= a; i++)
            {
                for (j = 0; j < i + 1; j++)
                {
                    if (b > a)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write(b + " ");
                        b++;
                    }

                }
                Console.WriteLine("");

            }


            Console.WriteLine("\n----- Exercise nr. 5 -----\n");
            for (i = 0; i <= 20; i++)
            {
                Console.WriteLine(Math.Pow(i, 3));
            }

            Console.WriteLine("\n----- Exercise nr. 6 -----\n");

            x = 0.0;
            double p = 0.0;
            for (p = 0.0; p <= 20; p++)
            {
                x = p + (p / 2) + (p / 3) + (p / 4);
                x = Math.Round(x, 3);
                Console.WriteLine(x);
            }

            Console.WriteLine("\n----- Exercise nr. 7 -----\n");
            Console.Write("Enter a odd number: ");
            a = Int32.Parse(Console.ReadLine());
            b = a / 2;
            z = 1;
            for(i = 0; i < a; i++)
            {
                for(j = 0; j < b; j++)
                {
                    Console.Write(" ");
                }
                b--;
                for (j = 0; j < z; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
                z += 2; 
                if(z > a)
                {
                    break;
                }
            }
            z = a - 2;
            b = 1;
            for (i = 0; i < a; i++)
            {
                for(j = 0; j < b; j++)
                {
                    Console.Write(" ");
                }
                b++;
                for (j = 0; j < z; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
                z -= 2;
                if (z < 1)
                {
                    break;
                }
            }


            Console.WriteLine("\n----- Exercise nr. 8 -----\n");
            Console.Write("Enter string: ");
            str = Console.ReadLine();
            characters = str.ToCharArray();
            a = characters.Length;
            Console.Write("String backward: ");
            for (i = a; i > 0; i--)
            {
                b = i - 1;
                m = characters[b];
                Console.Write(m);
            }
            Console.WriteLine("");

            Console.WriteLine("\n----- Exercise nr. 9 -----\n");
            Console.Write("Enter integer number: ");
            a = Int32.Parse(Console.ReadLine());
            str = "";
            while (a != 0)
            {
                x = a % 2;
                y = a / 2;
                a = Convert.ToInt32(Math.Floor(y));
                str += x;
            }
            binary = str.ToCharArray();
            a = binary.Length;
            Console.Write("After convert from binary number: ");
            for (i = a; i > 0; i--)
            {
                b = i - 1;
                m = binary[b];
                Console.Write(m);
            }
            Console.WriteLine("");


            Console.WriteLine("\n----- Exercise nr. 10 -----\n");
            Console.WriteLine("Enter two integer number: ");
            Console.Write("Enter a: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            b = Int32.Parse(Console.ReadLine());
            if (a >= b)
                greater = a;
            else
                greater = b;
            i = greater;
            for (i = greater; i >= 1; i--)
            {
                if ((a % i == 0) && (b % i == 0))
                {
                    break;
                }
            }
            greater = a * b / i;
            Console.WriteLine("The lowest common multiple is: " + greater);

        }
    }
}
