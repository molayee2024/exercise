public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(IsPrime(25));
        Console.WriteLine(IsAyenee(2522252));
        Console.WriteLine(Fibo(3));
        Console.WriteLine(Fact(5));
        Mosalas(5, 10);
        //Console.WriteLine(Average());
    }

    public static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }
        if (number == 2)
        {
            return true;
        }
        if (number % 2 == 0)
        {
            return false;
        }

        for (int i = 3; i < number; i += 1)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    public static bool IsAyenee(int number)
    {
        int left = number;
        int rev = 0;
        while (Convert.ToBoolean(left)) // instead of left>0 , to reverse signed numbers as well
        {
            int r = left % 10;
            rev = rev * 10 + r;
            left = left / 10;  //left = Math.floor(left / 10); 
        }

        if (number == rev)
        {
            return true;
        }
        return false;
    }

    public static double Average()
    {
        double sum = 0;
        double sumVahed = 0;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("enter vahed darse " + (i + 1));
            string str = Console.ReadLine();
            double vahed = double.Parse(str);
            sumVahed += vahed;
            Console.WriteLine("enter nomre darse " + (i + 1));
            string str2 = Console.ReadLine();
            double nomreh = double.Parse(str2);
            sum += nomreh * vahed;
        }

        return sum / sumVahed;
    }

    public static int Fibo(int len)
    {
        int n1 = 0, n2 = 1, c = 0;
        for (int i = 2; i < len; i++)
        {
            c = n1 + n2;
            n1 = n2;
            n2 = c;
        }
        return c;
    }

    public static int Fact(int num)
    {
        int n = 1;
        while (num > 0)
        {
            n = num;
            for (int i = n - 1; i > 0; i--)
            {
                n *= i;
            }
            num--;
        }
        return n;
    }


    public static void Mosalas(int n, int m)
    {

        for (int i = n; i <= m; i++)
        {
            Console.WriteLine(i * (i + 1) / 2);
        }

    }
}

