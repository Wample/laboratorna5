using System;

namespace laba5
{
    enum ProgramProduct
    {
        AccountingSystem1,
        AccountingSystem2,
        AccountingSystem3,
        LogisticsSystem1,
        LogisticsSystem2,
        LogisticsSystem3
    }

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Список проограмних родуктів:");
            Console.WriteLine($"{ProgramProduct.AccountingSystem1} - Система для автоматизації обліку 1 - №0");
            Console.WriteLine("Автор програми: John Doe");
            Console.WriteLine($"{ProgramProduct.AccountingSystem2} - Система для автоматизації обліку 2 - №1");
            Console.WriteLine("Автор програми: Mark Zuckerberg");
            Console.WriteLine($"{ProgramProduct.AccountingSystem3} - Система для автоматизації обліку 3 - №2");
            Console.WriteLine("Автор програми: Barak Obama");
            Console.WriteLine($"{ProgramProduct.LogisticsSystem1} - Система для управління логістикою 1 - №3");
            Console.WriteLine("Автор програми: Elon Musk");
            Console.WriteLine($"{ProgramProduct.LogisticsSystem2} - Система для управління логістикою 2 - №4");
            Console.WriteLine("Автор програми: Sylvester Stallone");
            Console.WriteLine($"{ProgramProduct.LogisticsSystem3} - Система для управління логістикою 3 - №5");
            Console.WriteLine("Автор програми: John Doe");

            Console.Write("Введіть номери програмних продуктів, які ви хочете придбати (через кому): ");
            string input = Console.ReadLine();

            string[] productNumbers = input.Split(',');

            Console.WriteLine("Обрані програмні продукти:");

            Console.WriteLine("Системи для автоматизації обліку:");
            foreach (string productNumber in productNumbers)
            {
                if (Enum.TryParse(productNumber.Trim(), out ProgramProduct product) && product <= ProgramProduct.AccountingSystem3)
                {
                    Console.WriteLine(Enum.GetName(typeof(ProgramProduct), product));
                }
            }

            Console.WriteLine("Системи для управління логістикою:");
            foreach (string productNumber in productNumbers)
            {
                if (Enum.TryParse(productNumber.Trim(), out ProgramProduct product) && product >= ProgramProduct.LogisticsSystem1)
                {
                    Console.WriteLine(Enum.GetName(typeof(ProgramProduct), product));
                }
            }
        }
    }
}
