using System;

namespace WeirdAlgorithm
{
    public class Class1
    {
        public static void Main()
        {
            Console.WriteLine("Sayı Giriniz");
            string sayi = Console.ReadLine();
            int currentNumber = Int32.Parse(sayi);
            while (currentNumber != 1)
            {
                if (currentNumber % 2 == 1)
                {
                    currentNumber = currentNumber * 3 + 1;
                    Console.WriteLine(currentNumber);

                }

                if (currentNumber % 2 == 0)
                {
                    currentNumber = currentNumber / 2;
                    Console.WriteLine(currentNumber);
                }

            }

            
        }

    }
}