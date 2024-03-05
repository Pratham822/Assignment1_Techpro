using System.Security.Cryptography;

class Pattern
{
    static void Main()
    {
        Console.WriteLine("Enter the number of rows :");
        int n = Convert.ToInt32(Console.ReadLine());

        // Printhollowsquare(n);
        //Numbertrianglepatter(n);
        // Numberincreasingpattern(n);
        //  Numberincreasingreversepyramid(n);
        //Numberchangingpyramid(n);
        //zeroonetriangle(n
        //palindrometriangle(n);
        // Rhombuspattern(n);
        // DiamondStar(n);
        // Mirrorimagetriangle(n);
        // Hollowtriangle(n);
        //Hollowreversetriangle(n);
        // Hollow_Hourglass_Pattern(n);
        //Hollow_Diamond_Pyramid(n);
        Pascal_Triangle(n);
        Console.ReadKey();
    }

    public static void Printhollowsquare(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (i == 1 || i == n || j == 1 || j == n)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();

        }
    }

    public static void Numbertrianglepatter(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j <= n; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= i; k++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
    public static void Numberincreasingpattern(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");

            }
            Console.WriteLine();
        }
    }
    public static void Numberincreasingreversepyramid(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j <= n; j++)
            {
                Console.Write(j + " ");

            }
            Console.WriteLine();
        }
    }
    public static void Numberchangingpyramid(int n)
    {
        int num = 1;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(num + " ");
                num++;
            }
            Console.WriteLine();
        }
    }
    public static void zeroonetriangle(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                if ((i + j) % 2 == 0)
                {
                    Console.Write("1");
                }
                else
                {
                    Console.Write("0");
                }

            }
            Console.WriteLine();
        }
    }
    public static void palindrometriangle(int n)
    {
        int num = 1;

        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j < n; j++)
            {
                Console.Write("  ");
            }

            for (int j = 1; j < i; j++)
            {
                Console.Write(j + " ");
            }

            for (int j = i; j >= 1; j--)
            {
                Console.Write(j + " ");
            }

            Console.WriteLine();
        }


    }
    public static void Rhombuspattern(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= n; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    public static void DiamondStar(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j < n; j++)
            {
                Console.Write(" ");

            }
            for (int k = 1; k <= i; k++)
            {
                Console.Write("*");
            }
            for (int k = 2; k <= i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        for (int i = n - 1; i >= 1; i--)
        {
            for (int j = i; j < n; j++)
            {
                Console.Write(" ");

            }
            for (int k = 1; k <= i; k++)
            {
                Console.Write("*");
            }
            for (int k = 2; k <= i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

    }
    public static void Mirrorimagetriangle(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(" ");
            }
            for (int k = i; k <= n; k++)
            {
                Console.Write(k + " ");
            }
            Console.WriteLine();
        }
        for (int i = n - 1; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(" ");
            }
            for (int k = i; k <= n; k++)
            {
                Console.Write(k + " ");
            }
            Console.WriteLine();
        }

    }
    public static void Hollowtriangle(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j <= n; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k < (2 * i) - 1; k++)
            {
                if (k == 1 || i == n)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.Write("*");
            Console.WriteLine();
        }
    }

    public static void Hollowreversetriangle(int n)

    {
        for (int i = n; i >= 1; i--)
        {
            for (int j = i; j <= n; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k < (2 * i) - 1; k++)
            {
                if (k == 1 || i == n)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.Write("*");
            Console.WriteLine();
        }
    }

    public static void Hollow_Hourglass_Pattern(int n)
    {
        for (int i = n; i >= 1; i--)
        {
            for (int j = i; j <= n; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k < (2 * i) - 1; k++)
            {
                if (k == 1 || i == n)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.Write("*");
            Console.WriteLine();
        }

        for (int i = 2; i <= n; i++)
        {
            for (int j = i; j <= n; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k < (2 * i) - 1; k++)
            {
                if (k == 1 || i == n)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.Write("*");
            Console.WriteLine();
        }

    }

    public static void Hollow_Diamond_Pyramid(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j <= n; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k < (2 * i) - 1; k++)
            {
                if (k == 1 )
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.Write("*");
            Console.WriteLine();
        }
        for (int i = n-1; i >=1 ; i--)
        {
            for (int j = i; j <= n; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k < (2 * i) - 1; k++)
            {
                if (k == 1 )
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.Write("*");
            Console.WriteLine();
        }

    }
     
    public static void Pascal_Triangle(int n)
    {

        for (int i = 0; i < n; i++)
        {
            int num = 1;
            for (int j = 0; j < n - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 0; k <= i; k++)
            {
                Console.Write(num + " ");
                num = num * (i - k) / (k + 1);
            }
            Console.WriteLine();
        }
    }
}













