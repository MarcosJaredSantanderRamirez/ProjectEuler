namespace Fibonacci{
    static class Problema{
        static void Main(String[] args){
            int[] valores = new int[32];
            int suma = 0;

            valores[0] = 1;
            valores[1] = 2;
            Console.WriteLine(valores[0]);
            Console.WriteLine(valores[1]);

            for (int i = 2; i < valores.Length; i++) {
                    valores[i] = valores[i - 1] + valores[i - 2];
                    if (valores[i] < 4000000) {
                        Console.WriteLine(valores[i]);
                    }
                    else if (valores[i] > 4000000) {
                        Console.WriteLine("Los valores exceden 400000");
                        valores[i] = 0;
                        for (int j = 0; j < valores.Length; j++) {
                            if (valores[j] % 2 == 0){
                                suma += valores[j];
                            }
                         }
                        Console.WriteLine("La suma de pares es " + suma);
                        break;
                    }
            }
        }
    }
}