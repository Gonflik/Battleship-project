namespace ConsoleApp1
{
    class MatrShip
    {
        private bool[,] mapsS = new bool[6, 6];

        public MatrShip()
        {
            Random rand = new Random();

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    int a = rand.Next(4);
                    if (a == 0)
                    {
                        mapsS[i, j] = true;
                    }
                    else
                    {
                        mapsS[i, j] = false;
                    }
                }
            }
        }

        public void ShowAll()
        {
            Console.WriteLine("   0 1 2 3 4 5");
            Console.WriteLine("   -----------");
            for (int i = 0; i < 6; i++)
            {
                Console.Write(i + " |");
                for (int j = 0; j < 6; j++)
                {
                    if (mapsS[i, j] == true)
                    {
                        Console.Write("1" + " ");
                    }
                    else
                    {
                        Console.Write("0" + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        public bool getMaps(int a, int b)
        {
            return mapsS[a, b];
        }
    }

    class PhantomS
    {
        private int[,] phantom = new int[6, 6];

        public PhantomS()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    phantom[i, j] = 2;
                }
            }
        }

        public void ShowAll()
        {
            Console.WriteLine("   0 1 2 3 4 5");
            Console.WriteLine("   -----------");
            for (int i = 0; i < 6; i++)
            {
                Console.Write(i + " |");
                for (int j = 0; j < 6; j++)
                {
                    if (phantom[i, j] == 1)
                    {
                        Console.Write("1" + " ");
                    }
                    else if (phantom[i, j] == 2)
                    {
                        Console.Write("*" + " ");
                    }
                    else
                    {
                        Console.Write("0" + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        public void hitInS(int a, int b, MatrShip ship)
        {
            if (ship.getMaps(a, b) == true)
            {
                phantom[a, b] = 1;
                Console.WriteLine("Hit");
            }
            if (ship.getMaps(a, b) == false)
            {
                phantom[a, b] = 0;
                Console.WriteLine("Pass");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MatrShip ship = new MatrShip();
            ship.ShowAll();
            /*MatrShip p1 = new MatrShip();
            ship.ShowAll();*/

            Console.WriteLine();

            PhantomS phantom = new PhantomS();
            phantom.ShowAll();

            Console.WriteLine();

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            phantom.hitInS(a, b, ship);

            phantom.ShowAll();
        }
    }
}
