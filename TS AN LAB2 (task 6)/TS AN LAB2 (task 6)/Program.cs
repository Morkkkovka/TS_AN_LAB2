using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS_AN_LAB2__task_6_
{
    public class CurrencyConverter
    {
        public double USD { get; }
        public double EUR { get; }
        public double RUB { get; }

        public CurrencyConverter(double usd, double eur, double rub)
        {
            USD = usd;
            EUR = eur;
            RUB = rub;
        }

        public double ConvertToUsd(double value)
        {
            return value / USD;
        }

        public double ConvertToEur(double value)
        {
            return value / EUR;
        }

        public double ConvertToRub(double value)
        {
            return value / RUB;
        }

        public double ConvertFromUsd(double value)
        {
            return USD * value;
        }

        public double ConvertFromEur(double value)
        {
            return EUR * value;
        }

        public double ConvertFromRub(double value)
        {
            return RUB * value;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var converter = new CurrencyConverter(26.71, 31.36, 0.37);

            Console.WriteLine("Виберіть опперацію:");
            Console.WriteLine("1: Конвертувати в гривні");
            Console.WriteLine("2: Конвертувати з гривень");

            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    ConvertTo(converter);
                    break;
                case 2:
                    ConvertFrom(converter);
                    break;
            }

            Console.WriteLine("Готово");
            Console.ReadKey();
        }

        private static void ConvertTo(CurrencyConverter currencyConverter)
        {
            Console.WriteLine("Виберіть операцію:");
            Console.WriteLine("1: Конвертувати з USD");
            Console.WriteLine("2: Конвертувати з EUR");
            Console.WriteLine("3: Конвертувати з RUB");

            var option = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть кількість");

            var input = double.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine(currencyConverter.ConvertFromUsd(input));
                    break;
                case 2:
                    Console.WriteLine(currencyConverter.ConvertFromEur(input));
                    break;
                case 3:
                    Console.WriteLine(currencyConverter.ConvertFromRub(input));
                    break;
            }
        }

        private static void ConvertFrom(CurrencyConverter currencyConverter)
        {
            Console.WriteLine("Виберіть операцію:");
            Console.WriteLine("1: Конвертувати в USD");
            Console.WriteLine("2: Конвертувати в EUR");
            Console.WriteLine("3: Конвертувати в RUB");

            var option = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть кількість");

            var input = double.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine(currencyConverter.ConvertToUsd(input));
                    break;
                case 2:
                    Console.WriteLine(currencyConverter.ConvertToEur(input));
                    break;
                case 3:
                    Console.WriteLine(currencyConverter.ConvertToRub(input));
                    break;
            }
        }
    }
}
