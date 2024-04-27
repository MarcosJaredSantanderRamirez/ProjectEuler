public class FactoresPrimos
{
    static void Main(string[] args)
    {
        long valor = 600851475143;
        int divisor = 1;
        int[] primos = new int[50];
        int c = 0;
        while (valor != 1)
        {
            divisor++;
            if (valor % divisor == 0)
            {
                primos[c] = divisor;
                valor = valor / divisor;
                c++;
            }
        }
        foreach (int i in primos)
        {
            if (i == 0) { continue; }
            Console.WriteLine(i);

        }
    }
}
