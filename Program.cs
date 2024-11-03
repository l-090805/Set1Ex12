namespace Set1Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Introdu numarul n: ");
            int n = int.Parse(Console.ReadLine());

            while ( n == 0)
            { 
                Console.WriteLine("N nu poate fi 0, incerci din nou: ");
                n = int.Parse(Console.ReadLine());
            }

            Console.Write("Introdu primul numar din interval: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Introdu ultimul numar din interval: ");
            int b = int.Parse(Console.ReadLine());
            int primul;
            if ( n % a == 0 )
            {
                 primul = a;
            }
            else
            {
                 primul = a + (n - a%n);
            }

            int ultimul = b - (b % n);

            if(primul > b)
            {
                Console.WriteLine("Nu existe numere deriabile cu n in interval");
            }
            else
            {
                int nrMultipliN = (ultimul - primul) / n + 1;
                Console.WriteLine($"In intervalul [{a},{b}] exista {nrMultipliN}  numere divizibile cu {n}");
            }
    

        }
    }
}
